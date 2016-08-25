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
                    redirectTo: '/dashboard'
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
        }])
        .run(['authService', function (authService) {
            authService.fillAuthData();
        }])
        .run(function ($rootScope, $location, authService) {
            // register listener to watch route changes
            $rootScope.$on("$routeChangeStart", function (event, next, current) {
                if (!authService.authentication.isAuth) {
                    // no logged user, we should be going to #login
                    if (next.templateUrl == "../Scripts/app/pages/account/login.html") {
                        // already going to #login, no redirect needed
                    } else {
                        // not going to #login, we should redirect now
                        $location.path("/login");
                    }
                }
            });
        });
    angular.module('XFrameworkApp.services', []);
    angular.module('XFrameworkApp.controllers', []);
    angular.module('XFrameworkApp.directives', []);
}());