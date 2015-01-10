
var config = {
    routes: function ($routeProvider) {
        $routeProvider.when('/products', { templateUrl: 'product/list' });
    }
};

config.routes.$inject = ['$routeProvider'];
console.log(config.routes);