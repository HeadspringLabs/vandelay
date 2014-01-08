vandelayApp.service('Location', ['$resource', function ($resource) {
    return $resource('api/location', {}, {
        query: { method: 'GET', isArray: true }
    });
}]);
