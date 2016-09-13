var app = angular.module('cricketerapp', ['ngRoute', 'ngAnimate','ui.bootstrap'])

//// configure routes
app.config(function ($routeProvider) {
    debugger;
    $routeProvider
         .when('/', {
             templateUrl: 'Angular/Controllers/CricketerView.html',
             controller: 'CricketerController'
         })
        .when('/detail/:id', {
            templateUrl: 'Angular/Controller/DetailView.html',
            controller: 'DetailController'
        })  
        .otherwise({ redirectTo: '/' });
});
