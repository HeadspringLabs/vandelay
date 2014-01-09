var partialsDir = 'Content/app/partials/';

var vandelayApp = angular.module('vandelayApp', [
  'ngRoute',
  'ngResource'
]);

vandelayApp.config(['$routeProvider', '$locationProvider',
    function (routeProvider, locationProvider) {
        routeProvider.
            when('/imports', {
                templateUrl: partialsDir + 'imports.html',
                controller: 'ImportCtrl'
            }).
            when('/import/:id', {
                templateUrl: partialsDir + 'import.html',
                controller: 'ImportCtrl'
            }).
            when('/sales-agents', {
                templateUrl: partialsDir + 'sales-agents.html',
                controller: 'SalesAgentCtrl'
            }).
            when('/sales-agent/:id', {
                templateUrl: partialsDir + 'sales-agent.html',
                controller: 'SalesAgentCtrl'
            }).
            when('/locations', {
                templateUrl: partialsDir + 'locations.html',
                controller: 'LocationCtrl'
            }).
            when('/location/:id', {
                templateUrl: partialsDir + 'location.html',
                controller: 'LocationCtrl'
            }).
            when('/', {
                templateUrl: partialsDir + 'index.html'
            }).
            otherwise({ redirectTo: '/' });

        locationProvider.html5Mode(true);
    }
]);
