/// <reference path="C:\Users\User\Documents\UberEating\UberEating\Scripts/angular-route.js" />
/// <reference path="C:\Users\User\Documents\UberEating\UberEating\Scripts/angular.js" />
(function () {
    'use strict';

    angular.module('openlmis-config', [])
    .config(function ($qProvider) {
        $qProvider.errorOnUnhandledRejections(false);
    });

})();