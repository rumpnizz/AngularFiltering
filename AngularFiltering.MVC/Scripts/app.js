
var app = angular.module('app', ['ngRoute']);

app.service('apiService', apiService);
app.controller('ProductController', ProductController);

app.config(config.routes);