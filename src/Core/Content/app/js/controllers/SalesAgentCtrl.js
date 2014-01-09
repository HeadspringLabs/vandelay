vandelayApp.controller('SalesAgentCtrl', ['$scope', '$routeParams', 'SalesAgent', function ($scope, $routeParams, SalesAgent) {
    $scope.agents = SalesAgent.query();
    $routeParams.id && ($scope.agent = SalesAgent.get($routeParams));

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
