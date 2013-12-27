vandelayApp.service('SalesAgent', ['$resource', function ($resource) {
    return $resource('api/salesagent', {}, {
        query: { method: 'GET', isArray: true }
    });
}]);
vandelayApp.service('Location', ['$resource', function ($resource) {
    return $resource('api/location', {}, {
        query: { method: 'GET', isArray: true }
    });
}]);
