(function () {
    'use strict';

    angular.module('XFrameworkApp',
        ['ngRoute',
        'ngCookies',
        'ngLocale',
        'ngAnimate',
        'XFrameworkApp.controllers',
        'XFrameworkApp.directives',
        'XFrameworkApp.services',
        'ui.bootstrap', //ui boostrap must be loaded before ngStrap
        'ui.slimscroll',
        'ui.calendar',
        'ui.XFrameworkLte', //AdminLte specific code
        'mgcrea.ngStrap',
        'ngMorris',
        'pascalprecht.translate',
        'blueimp.fileupload',
        'LocalStorageModule',
        ])
        .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            //use angular routing without the # prefix character
            //$locationProvider.html5Mode(true);
            $routeProvider
                .when('/dashboard', {
                    controller: 'dashboard_index',
                    templateUrl: '../Scripts/app/pages/samples/dashboard/index.html'
                })
                .when('/todo', {
                    controller: 'todoController',
                    templateUrl: '../Scripts/app/pages/Todo.html'
                })
                .when('/charts/morris', {
                    controller: 'section_index',
                    templateUrl: '../Scripts/app/pages/samples/section/index.html'
                })
                .when('/fileupload', {
                    controller: 'fileupload_index',
                    templateUrl: '../Scripts/app/pages/samples/fileupload/index.html'
                })
                .when('/blank', {
                    controller: 'blank_index',
                    templateUrl: '../Scripts/app/pages/samples/blank/index.html'
                })
                .when('/fullcalendar', {
                    controller: 'fullcalendar_index',
                    templateUrl: '../Scripts/app/pages/samples/fullcalendar/index.html'
                })
                .when("/login", {
                    controller: "loginController",
                    templateUrl: "../Scripts/app/pages/account/login.html"
                })
                .when("/signup", {
                    controller: "signupController",
                    templateUrl: "../Scripts/app/pages/account/signup.html"
                })
                .otherwise({
                    redirectTo: '/login'
                });


        }])
        .config(function ($httpProvider) {
             $httpProvider.interceptors.push('authInterceptorService');
         })
        .config(['$translateProvider', function ($translateProvider) {

            $translateProvider.useStaticFilesLoader({
                prefix: Emix.Web.translationsFolder,
                suffix: '.json'
            });

            $translateProvider.preferredLanguage(Emix.Settings.defaultLanguage);
            $translateProvider.fallbackLanguage(Emix.Settings.defaultLanguage);

            $translateProvider.storagePrefix('emix');
            $translateProvider.storageKey('lang');

            $translateProvider.useCookieStorage();
        }]);

    angular.module('XFrameworkApp.services', []);
    angular.module('XFrameworkApp.controllers', []);
    angular.module('XFrameworkApp.directives', []);
}());