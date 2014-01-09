vandelayApp.controller('NavigationCtrl', ['$scope', function ($scope) {
    $scope.links = [{
        url: '/', name: 'Home'
    }, {
        url: '/imports', name: 'Imports'
    }, {
        url: '/locations', name: 'Locations'
    }, {
        url: '/sales-agents', name: 'Sales Agents'
    }];
}]);
