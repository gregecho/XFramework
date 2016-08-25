

angular.module('XFrameworkApp.controllers')
    .controller('XFrameworkHeaderCtrl', ['$scope', '$window', '$location', '$translate', 'authService', function ($scope, $window, $location, $translate, authService) {
        'use strict';

        $scope.authentication = authService.authentication;
        $scope.logout = authService.logout;

        $scope.isMenuActive = function (path) {
            return $location.path().substr(0, path.length) === path;
        };

        $scope.isLanguageActive = function (language) {
            return language === $translate.use();
        };

        $scope.changeLanguage = function (language) {
            //set cookie value according to translator plugin.
            //the probably methods are internal => possible issues
            $translate.storage().set($translate.storageKey(), language);

            $window.location.reload(); //refresh current page reloading correct culture
        };
    }]);
