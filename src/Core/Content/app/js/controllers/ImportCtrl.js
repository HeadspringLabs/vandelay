vandelayApp.controller('ImportCtrl', ['$scope', '$routeParams', 'Import', 'Enumeration', function ($scope, $routeParams, Import, Enumeration) {
    $scope.imports = Import.query();
    $routeParams.id && ($scope._import = Import.get($routeParams));
    $scope.jurisdictions = Enumeration.jurisdictions.query();
    $scope.types = Enumeration.importTypes.query();

    $scope.save = function () {
        Import.save($scope._import, function (_import) {
            $scope.imports.push(_import);
        });
    };

    $scope.delete = function (_import) {
        Import.delete(_import, function () {
            var index = $scope.imports.indexOf(_import);
            $scope.imports.splice(index, 1);
        });
    };
}]);

