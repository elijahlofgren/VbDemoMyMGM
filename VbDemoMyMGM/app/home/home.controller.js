'use strict';

angular.module('myApp.home', ['ngRoute', 'LocalEventService'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/home', {
            templateUrl: '/app/home/home.html',
            controller: 'HomeController',
            controllerAs: 'homeCtrl',
        });
    }])

    .controller('HomeController', function (LocalEventService) {
        var vm = this;

        vm.localEvents = [];

        activate();

        function activate() {
            loadEvents();
        }

        function loadEvents() {
            LocalEventService.getAllEvents().then(function (response) {


                vm.localEvents = _.sortBy(response, 'StartDate');
            });
        }
    }); 
