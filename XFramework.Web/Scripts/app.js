// For any third party dependencies, like jQuery, place them in the lib folder.

requirejs.config({
    //By default load any module IDs from js/lib
    baseUrl: 'lib',
    //except, if the module ID starts with "app",
    //load it from the js/app directory. paths
    //config is relative to the baseUrl, and
    //never includes a ".js" extension since
    //the paths config could be for a directory.
    paths: {
        app: '../app'
    }

    //paths: {
    //    "jquery": "jquery-1.10.2",
    //    "jquery-validate": "jquery.validate",
    //    "jquery-validate-unobtrusive": "jquery.validate.unobtrusive",
    //    "bootstrap": "bootstrap",
    //    "respond": "respond",
    //    "i18n": "Components/RequireJS/i18n",
    //    "text": "Components/RequireJS/text",
    //    "menu-module" : "Controllers/Common/menu-module"
    //},
    //"shim": {
    //    "jquery-validate": {
    //        "deps": [ "jquery" ]
    //    },
    //    "jquery-validate-unobtrusive": {
    //        "deps": [ "jquery", "jquery-validate" ]
    //    },
    //    "bootstrap": { 
    //        "deps":  ["jquery"]
    //    }
    //},
    //"autoBundles": {
    //    "main-app": {
    //        "outputPath": "Scripts/Bundles/",
    //        "include": [
    //            {
    //                "directory": "Controllers/Root"
    //            }
    //        ]
    //    },
    //    "require-plugins": {
    //        "outputPath": "Scripts/Bundles/",
    //        "include": [
    //            {
    //                "file": "Components/RequireJS/i18n"
    //            },
    //            {
    //                "file": "Components/RequireJS/text"
    //            }
    //        ]
    //    }
    //}

});

// Start loading the main app file. Put all of
// your application logic in there.
// Start the main app logic.
requirejs(['app/main']);