vandelayApp.controller('HomePageCtrl', function ($scope) {
    $scope.message = "welcome to angular country";
});

vandelayApp.controller('SalesAgentCtrl', ['$scope', 'SalesAgent', function ($scope, SalesAgent) {
    $scope.agents = SalesAgent.query();

    $scope.save = function () {
        SalesAgent.save($scope.agent, function (agent) {
            $scope.agents.push(agent);
            $scope.agent = {};
        });
    };

    $scope.delete = function (agent) {
        SalesAgent.delete(agent, function () {
            var index = $scope.agents.indexOf(agent);
            $scope.agents.splice(index, 1);
        });
    };
}]);

vandelayApp.controller('LocationCtrl', ['$scope', 'Location', function ($scope, Location) {
    $scope.locations = Location.query();

    $scope.save = function () {
        Location.save($scope.location, function (location) {
            $scope.locations.push(location);
            $scope.location = {};
        });
    };

    $scope.delete = function (location) {
        Location.delete(location, function () {
            var index = $scope.locations.indexOf(location);
            $scope.locations.splice(index, 1);
        });
    };
}]);

