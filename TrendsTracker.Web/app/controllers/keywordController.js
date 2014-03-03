(function ()
{

    var KeywordController = function ($scope, $routeParams, $timeout, keywordsService)
    {
        init();

        function init()
        {
            keywordsService.getKeyword($routeParams.keywordName).then(function(data)
            {
                $scope.keyword = data;
                //$timeout(function ()
                //{
                //    $scope.keyword = data;
                //}, 3000)
            });
        };
    };

    KeywordController.$inject = ['$scope', '$routeParams', '$timeout', 'keywordsService'];
    angular.module('trendsTrackerApp').controller('KeywordController', KeywordController);
}());