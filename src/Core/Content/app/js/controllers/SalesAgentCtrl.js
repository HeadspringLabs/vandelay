vandelayApp.controller('SalesAgentCtrl', ['$scope', '$routeParams', 'SalesAgent', 'Import', function ($scope, $routeParams, SalesAgent, Import) {
    $scope.agents = SalesAgent.query();
    $scope.availableImports = Import.query();

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

    $scope.add = function (_import) {
        $scope.agent.imports = $scope.agent.imports || [];
        $scope.agent.imports.push(_import);
        SalesAgent.save($scope.agent, function () {
            var index = $scope.availableImports.indexOf(_import);
            $scope.availableImports.splice(index, 1);
        });
    };
    
    $scope.remove = function (_import) {
        var index = $scope.agent.imports.indexOf(_import);
        $scope.agent.imports.splice(index, 1);
        SalesAgent.save($scope.agent);
    };
}]);
