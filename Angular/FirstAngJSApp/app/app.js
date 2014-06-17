var app = angular.module("FourSquareApp", ["ngRoute", "ngResource", "ui.bootstrap"]);

app.config(function ($routeProvider) {
    $routeProvider.when('/explorer', {
        controller: 'inbox',
        templateUrl: '/app/views/placesresults.html'
    });

    $routeProvider.otherwise({redirectTo: "/explore"});
});
