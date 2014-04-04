﻿(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordsCtrl', function ($scope, $modal, keywords, spinner)
    {
        loadKeywords();

        function loadKeywords()
        {
            spinner.loading = true;
            keywords.query(function (data)
            {
                $scope.keywords = data;
                spinner.loading = false;
            });
        };

        $scope.showDialog = function (id)
        {
            var modalInstance = $modal.open({
                templateUrl: '/app/views/keywordAddUpdate.html',
                controller: 'KeywordAddUpdateCtrl',
                resolve: {
                    keywordId: function () { return id; }
                }
            });

            modalInstance.result.then(function ()
            {
                loadKeywords();
            });
        };
    });
}());