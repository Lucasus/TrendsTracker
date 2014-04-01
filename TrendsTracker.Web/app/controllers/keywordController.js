var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordController = function ($scope, $routeParams, $timeout, keywordRepository, spinner)
    {
        init();

        function init()
        {
            spinner.loading = true;

            keywordRepository.getAll().then(function (data)
            {
                $scope.keywords = data;
                spinner.loading = false;
            });

            //keywordRepository.getByName($routeParams.keywordName).then(function (data)
            //{
            //    $scope.keyword = data;
            //});
        };
    };

}(trendsTracker || (trendsTracker = {})));
