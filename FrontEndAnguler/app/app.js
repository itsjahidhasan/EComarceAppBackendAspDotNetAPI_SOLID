var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider){

  $routeProvider
  .when("/",{
    templateUrl:"views/pages/admin/login.html",
    controller:'login'
  })
}]);