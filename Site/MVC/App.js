var mySample = angular.module('mySample', []);

mySample.directive('myDirective', function () {
    return {
        restrict: 'A',
        replace: true,
        scope: {
            myUrl: '=someAttr',
            myText: '@myLinkText'
        },
        template: '<div><input ng-model="myUrl" type="text" /><a href="{{myUrl}}">{{myText}}</a></div>'
    };
});