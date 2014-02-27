(function ()
{

    var KeywordController = function ($scope, $routeParams, keywordsService)
    {
        init();

        function init()
        {
            keywordsService.getKeyword($routeParams.keywordName).then(function(data)
            {
                $scope.keyword = data;
            });
        };
    };

    KeywordController.$inject = ['$scope', '$routeParams', 'keywordsService'];
    angular.module('trendsTrackerApp').controller('KeywordController', KeywordController);
}());