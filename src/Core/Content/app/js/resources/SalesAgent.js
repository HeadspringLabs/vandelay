vandelayApp.service('SalesAgent', ['$resource', function ($resource) {
    return $resource('api/salesagent', {}, {
        query: { method: 'GET', isArray: true }
    });
}]);
