(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordsController = function ($scope, $routeParams, $timeout, keywordRepository, spinner)
    {
        init();

        function init()
        {
            spinner.loading = true;
            keywordRepository.query(function (data)
            {
                $scope.keywords = data;
                spinner.loading = false;
            });
        };
    };
}(window.trendsTracker = window.trendsTracker || {}));
