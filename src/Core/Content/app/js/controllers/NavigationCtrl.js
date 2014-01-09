vandelayApp.controller('NavigationCtrl', ['$scope', function ($scope) {
    $scope.links = [{
        url: '/', name: 'Home'
    }, {
        url: '/locations', name: 'Locations'
    }, {
        url: '/sales-agents', name: 'Sales Agents'
    }];
}]);
