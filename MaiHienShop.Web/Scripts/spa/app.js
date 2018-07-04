/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("myControllerName", myControllerFunc);
myApp.controller("schoolController", schoolController);
myApp.controller("teacherController", teacherController);
myApp.controller("studentController", studentController);

//myControllerFunc.$inject = ['$scope'];
//teacherController.$inject = ['$scope'];
//studentController.$inject = ['$scope'];

//declare
function myControllerFunc($scope) {
    $scope.message = "This is my message from Controller";
}

function schoolController($scope) {
    $scope.message = "Announcement from school";
}

function teacherController($scope) {
    //$scope.message = "This is my message from Teacher";
}

function studentController($scope) {
    $scope.message = "This is my message from Student";
}