'use strict';

//Interceptor is regular service (factory) which allow us to capture every XHR request 
//and manipulate it before sending it to the back-end API or after receiving the response from the API
var moduleName = 'XFrameworkApp.services';
angular.module(moduleName)
    .factory('authInterceptorService', ['$q', '$location', 'localStorageService', function ($q, $location, localStorageService) {
        return {
            request: function (config) {
                config.headers = config.headers || {};
                var authData = localStorageService.get('authorizationData');
                if (authData) {
                    config.headers.Authorization = 'Bearer ' + authData.token;
                }
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            },

        };
}]);