vandelayApp.controller('HomePageCtrl', function ($scope) {
    $scope.message = "welcome to angular country";
});

vandelayApp.controller('SalesAgentCtrl', ['$scope', 'SalesAgent', function ($scope, SalesAgent) {
    $scope.agents = SalesAgent.query();
}]);

vandelayApp.controller('LocationCtrl', ['$scope', 'Location', function ($scope, Location) {
    $scope.locations = Location.query();
}]);

