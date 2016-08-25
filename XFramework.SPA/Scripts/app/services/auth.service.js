/*global define*/
'use strict';

/**
 * Services that persists and retrieves auth from webapi.
 */
//define(['angualr'],
//    function (angular) {
var moduleName = 'XFrameworkApp.services';
angular.module(moduleName)
        .service('authService', ['$http', '$q', 'localStorageService', function ($http, $q, localStorageService) {

            var authService = {
                authentication: {
                    isAuth: false,
                    userName: ""
                },
                login: function (loginData) {
                    var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;
                    //var deferred = $q.defer();
                    return $http({
                        method: "POST",
                        url: Emix.Api.Common.tokenUrl,
                        cache: false,
                        data: data,
                        headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                    });
                    //debugger;
                    //return deferred.promise;
                },
                logout: function () {
                    localStorageService.remove('authorizationData');
                    authService.authentication.isAuth = false;
                    authService.authentication.userName = "";
                },
                register: function (registration) {
                    authService.logout();
                    return $http({
                        method: "POST",
                        url: Emix.Api.Account.register,
                        cache: false,
                        data: registration
                    });
                },
                fillAuthData: function () {
                    var authData = localStorageService.get('authorizationData');
                    if (authData) {
                        authService.authentication.isAuth = true;
                        authService.authentication.userName = authData.userName;
                    }
                }
            };
            return authService;
        }]);
//});