'use strict';

//define(['angular'],
//    function (angular) {
angular.module('XFrameworkApp.controllers').controller('loginController', ['$scope', '$location', 'authService', '$timeout', 'localStorageService',
            function ($scope, $location, authService, $timeout, localStorageService) {
                $scope.loginData = {
                    Name: "",
                    password: ""
                };
                $scope.message = "";
                $scope.login = function () {
                    authService.login($scope.loginData).success(function (response) {
                        localStorageService.set('authorizationData', { token: response.access_token, userName: $scope.loginData.userName });
                        authService._authentication.isAuth = true;
                        authService._authentication.userName = $scope.loginData.userName;
                        //deferred.resolve(response);
                    }).error(function (err, status) {
                        _logOut();
                        //deferred.reject(err);
                    }).then(function (response) {
                        $location.path('/dashboard');
                    },
                     function (err) {
                         $scope.message = err.error_description;
                     });
                };
            }
]);