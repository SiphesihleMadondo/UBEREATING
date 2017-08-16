/// <reference path="C:\Users\User\documents\visual studio 2015\Projects\UberEating\UberEating\Scripts/angular.js" />
/// <reference path="C:\Users\User\documents\visual studio 2015\Projects\UberEating\UberEating\LoginService.js" />
/// <reference path="C:\Users\User\documents\visual studio 2015\Projects\UberEating\UberEating\Scripts/angular-route.js" />

var myApp = angular.module("myApp", []);
myApp.controller("LoginController", function ($rootscope, $scope, loginApi) {

    $scope.getAgents = function () {

        loginApi.getAgents($scope.username, $scope.password)
        .then
        (function (response) {

            if (response.data == null) {
                alert("error");
            }
            else {

                alert("successfully Logged in" + response.data);
                $rootscope.userInformation = response.data;
                window.location.href = "/AddUser.html";
            }


        }),
        function (response) {

            alert("error login");
        };

    };



});