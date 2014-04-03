(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordsController', function ($scope, $modal, keywordRepository, spinner)
    {
        loadKeywords();

        function loadKeywords()
        {
            spinner.loading = true;
            keywordRepository.query(function (data)
            {
                $scope.keywords = data;
                spinner.loading = false;
            });
        };

        $scope.showInsertDialog = function ()
        {
            var modalInstance = $modal.open({
                templateUrl: '/app/views/keywordModal.html',
                controller: 'KeywordController',
                resolve: {
                    name: function () { return '' },
                    mode: function () { return 'insert' }
                }
            });

            modalInstance.result.then(function ()
            {
                loadKeywords();
            });
        };
    });
}());
