/*global define*/
'use strict';

/**
 * Services that persists and retrieves TODOs from webapi.
 */
//define(['angualr'],
//    function (angular) {
var moduleName = 'XFrameworkApp.services';
angular.module(moduleName)
        .service('todoService', ['$http', function ($http) {
            return {
                get: function () {
                    //debugger;
                    return $http({
                        method: "GET",
                        url: Emix.Api.Todo.get,
                        cache: false,
                        //params: { name: name }
                    });
                },
                post: function (todo) {
                    return $http({
                        method: "POST",
                        url: Emix.Api.Todo.post,
                        cache: false,
                        data: todo
                    });
                },
                put: function (todo) {
                    return;
                }
            };
        }]);
//});