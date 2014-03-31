var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordController = function ($scope, $routeParams, $timeout, keywordRepository)
    {
        init();

        function init()
        {
            keywordRepository.getByName($routeParams.keywordName).then(function (data)
            {
                $scope.keyword = data;
            });
        };
    };

}(trendsTracker || (trendsTracker = {})));
