vandelayApp.service('Import', ['$resource', function ($resource) {
    return $resource('api/import', {}, {
        query: { method: 'GET', isArray: true }
    });
}]);
