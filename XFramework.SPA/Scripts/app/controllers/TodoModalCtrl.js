/*global define*/
'use strict';

//define(['angular'],
angular.module('XFrameworkApp.controllers').controller('todoModalInstanceCtrl', function ($scope, $uibModal, todoService) {

    $scope.items = items;
    $scope.selected = {
        item: $scope.items[0]
    };

    $scope.ok = function () {
        $uibModalInstance.close($scope.selected.item);
    };

    $scope.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };
});