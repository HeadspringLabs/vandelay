vandelayApp.service('Enumeration', ['$resource', function ($resource) {
    var defaults = { query: { method: 'GET', isArray: true } };
    return {
        jurisdictions: $resource('api/jurisdiction', {}, defaults),
        importTypes: $resource('api/importtype', {}, defaults),
        measures: $resource('api/measure', {}, defaults)
    };
}]);
