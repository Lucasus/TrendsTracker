(function ()
{
    "use strict";

    trendsTrackerApp.controller('KeywordAddUpdateCtrl', function ($scope, $route, $modalInstance, keywords, spinner, keywordId)
    {
        init();

        function init()
        {
            $scope.keyword = {};

            if (keywordId)
            {
                spinner.loading = true;
                keywords.get({ id: keywordId }, function (data)
                {
                    $scope.keyword = data;
                    spinner.loading = false;
                });
            }

            $scope.form =
            {
                header: (keywordId ? 'Edit keyword' : 'New keyword'),
                mode: (keywordId ? 'update' : 'add')
            };

            $scope.cancel = function ()
            {
                $modalInstance.dismiss('cancel');
            };

            $scope.save = function ()
            {
                spinner.loading = true;
                if (keywordId)
                {
                    keywords.update({ id: keywordId }, $scope.keyword, function ()
                    {
                        spinner.loading = false;
                        $modalInstance.dismiss('cancel');
                        $route.reload();
                    });
                }
                else
                {
                    keywords.create({}, $scope.keyword, function ()
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
