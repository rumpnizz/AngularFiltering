
var ProductController = function ($scope, apiService) {
    var url = '/api/products';
    $scope.viewbag = {
        title: 'Hello World!'
    };

    $scope.productModel = {};
    apiService.get.call($scope.allProducts, url);

}


ProductController.$inject = ['$scope', 'apiService'];