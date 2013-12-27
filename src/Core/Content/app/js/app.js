var partialsDir = 'Content/app/partials/';

var vandelayApp = angular.module('vandelayApp', [
  'ngRoute',
  'ngResource'
]);

vandelayApp.config(['$routeProvider',
    function (routeProvider) {
        routeProvider.
            otherwise({ redirectTo: '/' });
    }
]);
