(function () {
    "use strict";

    trendsTrackerApp.controller('KeywordsCtrl', function ($scope, $modal, $routeParams, keywordsResource, spinner) {

        $scope.keywordsList = {
            searchTerm: $routeParams.searchTerm,
            sortType: $routeParams.sortType,
            pageSize: $routeParams.pageSize,
            page: $routeParams.page
        };

        loadKeywords($scope.keywordsList);

        function loadKeywords(keywordsList) {
            spinner.loading = true;
            keywordsResource.query({
                searchTerm: keywordsList.searchTerm || '',
                sortType: keywordsList.sortType || '',
                page: keywordsList.page || 1
            }, function (data) {
                $scope.keywordsList = data;
                spinner.loading = false;
            });
        };

        $scope.showDialog = function (id) {
            var modalInstance = $modal.open({
                templateUrl: '/app/views/keywordAddUpdate.html',
                controller: 'KeywordAddUpdateCtrl',
                resolve: {
                    keywordId: function () { return id; }
                }
            });

            modalInstance.result.then(function () {
                loadKeywords($scope.keywordsList);
            });
        };

        $scope.search = function () {
            loadKeywords($scope.keywordsList);
        };

        $scope.sort = function (column) {
            if (column == 'name') {
                if ($scope.keywordsList.sortType == 'name_asc') {
                    $scope.keywordsList.sortType = 'name_desc';
                } else {
                    $scope.keywordsList.sortType = 'name_asc';
                }
            }
            loadKeywords($scope.keywordsList);
        };

        $scope.pageChanged = function (page) {
            $scope.keywordsList.page = page;
            loadKeywords($scope.keywordsList);
        };

        $scope.delete = function (id) {
            spinner.loading = true;
            keywordsResource.delete({ id: id }, function () {
                loadKeywords($scope.keywordsList);
                spinner.loading = false;
            });
        };
    });
}());
