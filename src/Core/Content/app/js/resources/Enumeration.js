vandelayApp.service('Enumeration', ['$resource', function ($resource) {
    var defaults = { query: { method: 'GET', isArray: true } };
    return {
        jurisdictions: $resource('api/jurisdiction', {}, defaults),
        measures: $resource('api/measure', {}, defaults)
    };
}]);
