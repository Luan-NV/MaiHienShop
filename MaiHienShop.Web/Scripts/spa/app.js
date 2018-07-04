/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

//myApp.controller("myControllerName", myControllerFunc);
myApp.controller("schoolController", schoolController);
myApp.service('ValidatorServiceName', ValidatorServiceImpl);

schoolController.$inject = ['$scope', 'ValidatorServiceName'];

//myApp.controller("teacherController", teacherController);
//myApp.controller("studentController", studentController);

//myControllerFunc.$inject = ['$scope'];
//teacherController.$inject = ['$scope'];
//studentController.$inject = ['$scope'];

//declare
//function myControllerFunc($scope) {
//    $scope.message = "This is my message from Controller";
//}

function schoolController($scope, ValidatorServiceName) {
    //$scope.message = "Announcement from school";
    $scope.clickCheckNumber = function () {
        $scope.message = ValidatorServiceName.returnCheckNumber($scope.num);
    }

    $scope.num = 1;
}

//function teacherController($scope) {
//    $scope.message = "This is my message from Teacher";
//}

//function studentController($scope) {
//    $scope.message = "This is my message from Student";
//}

function ValidatorServiceImpl($window) {
    return {
        returnCheckNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else
            return 'This is odd';
    }
}