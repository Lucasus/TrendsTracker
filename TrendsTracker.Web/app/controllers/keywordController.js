﻿(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordController = function ($scope, $routeParams, $timeout, keywordRepository, spinner)
    {
        init();

        function init()
        {
            spinner.loading = true;
            keywordRepository.get({ name: $routeParams.name }, function (data)
            {
                $scope.keyword = data;
                spinner.loading = false;
            });
        };
    };
}(window.trendsTracker = window.trendsTracker || {}));
