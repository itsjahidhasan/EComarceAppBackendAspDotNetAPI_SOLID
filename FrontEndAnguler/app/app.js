var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider){

  $routeProvider
  // Admin route
  .when("/Admin",{
    templateUrl:"views/pages/admin/login.html",
    controller:'login'
  })
  .when("/Admin/Home",{
    templateUrl:"views/pages/admin/home.html",
    // controller:''
  })



  // Shop owner route
  .when("/shopowner",{
    templateUrl:"views/pages/shopowner/index.html",
    controller:'shopownerlogin'
    
  })
  .when("/",{

    templateUrl:"views/index.html",

    // controller:''

  })

}]);