'use strict';

//define(['angular'],
//    function (angular) {
angular.module('XFrameworkApp.controllers')
    .controller('loginController', ['$scope', '$location', 'authService', '$timeout', 'localStorageService', '$window', '$rootScope',
        function ($scope, $location, authService, $timeout, localStorageService, $window, $rootScope) {
            $scope.loginData = {
                Name: "",
                password: ""
            };
            $scope.message = "";
            $scope.logout = authService.logout;
            $scope.login = function () {
                authService.login($scope.loginData).success(function (response) {
                    localStorageService.set('authorizationData', { token: response.access_token, userName: $scope.loginData.userName });
                    authService.authentication.isAuth = true;
                    authService.authentication.userName = $scope.loginData.userName;
                    //deferred.resolve(response);
                }).error(function (err, status) {
                    logout();
                    //deferred.reject(err);
                }).then(function (response) {
                    //$window.location.href = "/home/index";
                    $location.path('/dashboard');
                },
                 function (err) {
                     $scope.message = err.error_description;
                 });
            };

            $scope.$watchCollection('authService.authentication', function (newValue, oldValue) {
                debugger;
                $("body").toggleClass('sidebar-collapse');
                $("body").toggleClass('sidebar-open');
            }, true);
        }
    ]);