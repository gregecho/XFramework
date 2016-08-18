/*global define*/
'use strict';

//define(['angular'],
//    function (angular) {
        angular.module('XFrameworkApp.controllers').controller('todoController', ['$scope', '$location', 'todoService', 'filterFilter',
            function ($scope, $location, todoService, filterFilter) {
                var todos = [];
                //debugger;
                todoService.get().then(function (response) {
                    //debugger;
                    $scope.todos = response.data;
                    todos = $scope.todos;
                });
                $scope.newTodo = '';
                $scope.editedTodo = null;

                $scope.$watch('todos', function () {
                    // How to deal with server side enum
                    $scope.doneCount = filterFilter(todos, { status: 2 }).length;
                    $scope.remainingCount = todos.length - $scope.doneCount;
                    //$scope.allChecked = !$scope.remainingCount;
                    // List save?
                    //todoService.put(todos);
                    console.log('trigger watch');
                }, true);
                //Location?
                if ($location.path() === '') {
                    $location.path('/');
                }

                $scope.location = $location;

                $scope.$watch('location.path()', function (path) {
                    $scope.statusFilter = (path === '/active') ?
                    { completed: false } : (path === '/completed') ?
                    { completed: true } : null;
                });

                $scope.addTodo = function () {
                    var newTodo = $scope.newTodo.trim();
                    if (!newTodo.length) {
                        return;
                    }
                    // Todo: Need deal with server save and client save
                    todos.push({
                        title: newTodo,
                        status: 0
                    });
                    todoService.post({
                        title: newTodo,
                        status: 0
                    });
                    $scope.newTodo = '';
                };

                $scope.editTodo = function (todo) {
                    $scope.editedTodo = todo;
                    // Clone the original todo to restore it on demand.
                    $scope.originalTodo = angular.copy(todo);
                };

                $scope.doneEditing = function (todo) {
                    $scope.editedTodo = null;
                    todo.title = todo.title.trim();
                    if (!todo.title) {
                        $scope.removeTodo(todo);
                    }
                };

                $scope.revertEditing = function (todo) {
                    todos[todos.indexOf(todo)] = $scope.originalTodo;
                    $scope.doneEditing($scope.originalTodo);
                };

                $scope.removeTodo = function (todo) {
                    todos.splice(todos.indexOf(todo), 1);
                };

                $scope.clearDoneTodos = function () {
                    $scope.todos = todos = todos.filter(function (val) {
                        return !val.completed;
                    });
                };

                $scope.markAll = function (done) {
                    todos.forEach(function (todo) {
                        todo.status = done;
                    });
                };
            }
        ]);
    //}
    //);