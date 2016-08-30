'use strict';

angular.module('myApp.home', ['ngRoute', 'LocalEventService'])
.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/home', {
    templateUrl: '/app/home/home.html',
    controller: 'HomeController',
    controllerAs: 'homeCtrl',
  });
}])

.controller('HomeController', function (LocalEventService) {
    var vm = this;

    vm.hello = hello;
    
    function hello() {
        //return 'hello world!';
        return LocalEventService.hello();
    };

});
