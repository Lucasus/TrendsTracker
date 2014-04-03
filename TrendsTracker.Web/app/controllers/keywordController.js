(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordController', function ($scope, keywordRepository, spinner, name, mode)
    {
        init();

        function init()
        {
            $scope.form = { mode: mode };

            if (name)
            {
                spinner.loading = true;
                keywordRepository.get({ name: name }, function (data)
                {
                    $scope.keyword = data;
                    spinner.loading = false;
                });
            }
            else
            {
                $scope.keyword = {};
            }
        };
    });
}());
