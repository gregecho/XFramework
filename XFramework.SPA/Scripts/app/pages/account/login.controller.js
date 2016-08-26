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
                authService.login($scope.loginData)
                    .then(function (response) {
                    //$window.location.href = "/home/index";
                    $location.path('/dashboard');
                },
                 function (err) {
                     debugger;
                     $scope.message = err.data.error_description;
                 });
            };
        }
    ]);