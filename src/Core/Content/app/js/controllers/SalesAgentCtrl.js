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
