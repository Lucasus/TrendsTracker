(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordCtrl', function ($scope, keywords, spinner, urlFriendlyName)
    {
        init();

        function init()
        {
            spinner.loading = true;
            keywords.get({ urlFriendlyName: urlFriendlyName }, function (data)
            {
                $scope.keyword = data;
                spinner.loading = false;
            });
        };
    });
}());
