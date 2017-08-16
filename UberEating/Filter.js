/// <reference path="C:\Users\User\Pictures\UberEating\UberEating\Scripts/angular-route.js" />
/// <reference path="C:\Users\User\Pictures\UberEating\UberEating\Scripts/angular.js" />



var app = angular.module("myApp", [])
                  .controller("Filter", function ($scope, $filter, $http) {

                      //var locate = $scope.location;
                      //creating my controller, my controller also serve as service 
                      var location = [$http.get("api/Restaurants").then(function (response) { alert("Success"); $scope.location = response.data },

                            function () {
                                alert("Fail to display");

                            })]

                      $scope.location = location;

                      $scope.search = function (item) {
                          if ($scope.searchText == undefined) {
                              return true;
                          }
                          else {
                              if (item.Name.toLowerCase().indexOf($scope.searchText.toLowerCase()) != -1 ||
                                  item.Location.toLowerCase().indexOf($scope.searchText.toLowerCase()) != -1) {
                                  return true;
                              }
                          }
                          return false;
                      }

                      $scope.hide = function ($scope) {
                          $scope.data = "my data";
                          $scope.searchText = false;
                      }

                  });


//when refferincing of script or controllers make sure u refference the last,
//as the most recent last ..