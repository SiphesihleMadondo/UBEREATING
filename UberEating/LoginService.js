/// <reference path="C:\Users\User\documents\visual studio 2015\Projects\UberEating\UberEating\Scripts/angular-route.js" />
/// <reference path="C:\Users\User\documents\visual studio 2015\Projects\UberEating\UberEating\Scripts/angular.js" />


myApp.factory("loginApi", function ($http) {


    var url = "http://localhost:1620/";
    var loginApi = {};


    loginApi.getAgents = function (username, password) {

        return $http.get(url + "/ api/User_Table/5" + "?Email " + username + "?Password" + password);

    }









})