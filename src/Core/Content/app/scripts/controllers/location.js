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
