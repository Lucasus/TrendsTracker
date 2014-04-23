(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordAddUpdateCtrl', function ($scope, $route, $modalInstance, keywordsResource, spinner, keywordId)
    {
        init();

        function init()
        {
            $scope.keyword = {};

            if (keywordId)
            {
                spinner.loading = true;
                keywordsResource.get({ id: keywordId }, function (data)
                {
                    $scope.keyword = data;
                    spinner.loading = false;
                });
            }

            $scope.cancel = function ()
            {
                $modalInstance.dismiss('cancel');
            };

            $scope.save = function (keyword)
            {
                spinner.loading = true;
                if (keywordId)
                {
                    keywordsResource.update({ id: keywordId }, keyword, function ()
                    {
                        spinner.loading = false;
                        $modalInstance.dismiss('cancel');
                        $route.reload();
                    });
                }
                else
                {
                    keywordsResource.create({}, keyword, function ()
                    {
                        spinner.loading = false;
                        $modalInstance.dismiss('cancel');
                        $route.reload();
                    });
                }
            }
        };
    });
}());
