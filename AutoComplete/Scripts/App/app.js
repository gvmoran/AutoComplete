var app = angular.module('myapp', ['angucomplete-alt']);
app.controller('AutoCompleteController', ['$scope', '$http', function ($scope, $http) {
    $scope.Counties = [];
    $scope.SelectedCountry = null;

    $scope.SelectedCountry = function (selected) {
        if (selected) {
            $scope.SelectedCountry = selected.originalObject;
        }
    }

    $http({
        method: 'GET',
        url: '/Home/getAllCountries'
    }).then(function (data) {
        console.log(data);
        $scope.Countries = data.data;
    }, function () {
        alert('Error');
    })
}]);