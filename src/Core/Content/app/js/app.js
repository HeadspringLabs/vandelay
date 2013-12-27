var partialsDir = 'Content/app/partials/';

angular.module('vandelay', []).
    config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
            when('/', { templateUrl: partialsDir + 'index.html', controller: HomePage }).
            otherwise({ redirectTo: '/' });
    }]);
