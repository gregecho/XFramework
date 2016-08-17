#/bin/bash

## Note: All machines should be up to date before any of them run this script,
##       and at least one machine should have all the remote branches checked out.
## Use this script to remove .gitignored files from a git repository's index,
## but to not remove the files locally. It should be run on all machines that
## need to preserve the .gitignored files, since a "git pull" or "git checkout
## <branch>" would remove them otherwise (original idea from
## http://www.arlocarreon.com/blog/git/untrack-files-in-git-repos-without-deleting-them/).

## It can be run for specific files like this:
## $ ./git-rm-files-from-index.sh <file1> [<file2>...]

## To remove all .gitignored files, you could run it like this:
## $ GIT_INDEX_FILE="" git ls-files -oi --exclude-standard | xargs ./git-rm-files-from-index.sh
## (see http://stackoverflow.com/questions/9320218/how-to-list-gitignore-files-that-are-currently-staged-or-committed/9370094#9370094)


if [ "$#" -lt 1 ]; then
	echo "Usage: $0 <file1> [<file2>...]"
	exit
fi

read -p "Are the local branches on this machine AND ON ALL OTHER MACHINES
that will run this script up to date with git remote changes (y/n)? "
if [ "$REPLY" != "y" ]; then
	echo
	echo "Please make sure all machines are up to date before running this script anywhere."
	exit 1
fi

## Save current branch info and run some robustness checks
CURBRANCHREF=$(git symbolic-ref HEAD)
if [ "${CURBRANCHREF:0:11}" != "refs/heads/" ]; then
	echo "Error: not in a local branch. Please, checkout a local branch."
	exit 1
fi
CURBRANCH=${CURBRANCHREF:11}
if [ -n "$(git status --porcelain -uno | grep -v '^ ')" ]; then
	echo "Error: please, commit or stash any staged files before running this script."
	exit 1
fi

# we can only remove the files that are in the git index
# see http://mywiki.wooledge.org/BashFAQ/020 for while loop description
unset i
while IFS= read -r -d '' file; do
	indexedfiles[i++]="$file"
done < <(git ls-files -z "$@")

## First remove them from the current branch
echo "Removing files from index on branch $CURBRANCH"
git rm -r --cached "${indexedfiles[@]}"  || exit
git status
echo
read -p "Do the files that will be removed from the index look correct (y/n)? "
if [ "$REPLY" != "y" ]; then
	echo "Resetting files"
	git reset HEAD "${indexedfiles[@]}"
	echo "Please check your arguments to this script and try again"
	exit 1
fi
git commit -m 'rm some files from git index but keep locally'

## Next, stash your staged and untracked files to prevent problems
## during branch checkout, and this is needed for rebasing
echo "Stashing local changes"
git add .  ## also save untracked files
git stash

### Now, remove them on all other local branches
git for-each-ref --shell --format='LOCALBRANCH=%(refname:short)' refs/heads/ |
while read OUTLINE; do
	eval "$OUTLINE"
	if [ "$LOCALBRANCH" != "$CURBRANCH" ]; then
		git checkout --force "$LOCALBRANCH"
		echo "Removing files from index on branch $LOCALBRANCH"
		git rm -r --cached "${indexedfiles[@]}"
		git commit -m 'rm some files from git index but keep locally'
	fi
done

### Now, pull on all local branches
git for-each-ref --shell --format='LOCALBRANCH=%(refname:short)' refs/heads/ |
while read OUTLINE; do
    eval "$OUTLINE"
    git checkout --force "$LOCALBRANCH"
    git pull --rebase  # prevent numerous empty merge commits by rebasing
done

git checkout "$CURBRANCH"
git stash pop      # unstash any locally changed files
git reset HEAD .   # reset any previously untracked files
git push

echo
echo "All local branches have the passed in files removed from their index."