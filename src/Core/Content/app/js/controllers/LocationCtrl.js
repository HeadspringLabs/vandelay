vandelayApp.controller('LocationCtrl', ['$scope', '$routeParams', 'Location', 'Enumeration', function ($scope, $routeParams, Location, Enumeration) {
    $scope.locations = Location.query();
    $routeParams.id && ($scope.location = Location.get($routeParams));
    $scope.jurisdictions = Enumeration.jurisdictions.query();

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

