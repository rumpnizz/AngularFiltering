
var app = angular.module('app', ['ngRoute']);

app.controller('ProductController', ProductController);

app.config(config.routes);