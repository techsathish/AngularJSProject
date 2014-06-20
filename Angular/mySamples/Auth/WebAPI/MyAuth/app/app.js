var angularCartApp = angular.module('angularCart', ['ngRoute']);

angularCartApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/', {
        templateUrl: 'app/views/home/home.html',
        controller: 'HomeController'
    });

    $routeProvider.when('/signup', {
        templateUrl: 'app/views/auth/signup.html',
        controller: 'SignUpController'
    });


}]);