/// <reference path="todoEditModal.html" />
/// <reference path="../pages/Todo.html" />
/// <reference path="../pages/todoEditModal.html" />
/// <reference path="../pages/todoEditModal.html" />
/*global define*/
'use strict';

//define(['angular'],
//    function (angular) {
angular.module('XFrameworkApp.controllers').controller('todoController', ['$scope', '$location', 'todoService', 'filterFilter', '$uibModal',
            function ($scope, $location, todoService, filterFilter, $uibModal) {
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
                    //$scope.editedTodo = todo;
                    // Clone the original todo to restore it on demand.
                    //$scope.originalTodo = angular.copy(todo);
                    //debugger;
                    todoService.put(todo);
                };

                $scope.popupModal = function (todo) {
                    var modalInstance = $uibModal.open({
                        animation: true,
                        templateUrl: './Scripts/app/pages/todo/todoEditModal.html',
                        //controller: 'todoModalInstanceCtrl',
                        controller: function ($uibModalInstance, $scope, todoService, todo) {
                            $scope.todo = todo;
                            $scope.ok = function () {
                                console.log(todo);
                                todoService.put(todo);
                                $uibModalInstance.dismiss('cancel');
                            };
                            $scope.cancel = function () {
                                $uibModalInstance.dismiss('cancel');
                            };
                            //console.log($scope);
                        },
                        //size: size, // lg, sm
                        resolve: {
                            todo: function () {
                                //console.log(todo);
                                return todo;
                            }
                        }
                    });

                    modalInstance.result.then(function (selectedItem) {
                        //$scope.selected = selectedItem;
                    }, function () {
                        // $log.info('Modal dismissed at: ' + new Date());
                    });
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