(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordCtrl', function ($scope, keywordsResource, spinner, urlFriendlyName)
    {
        init();

        function init()
        {
            spinner.loading = true;
            keywordsResource.get({ urlFriendlyName: urlFriendlyName }, function (data)
            {
                $scope.keyword = data;
                spinner.loading = false;
            });
        };
    });
}());
