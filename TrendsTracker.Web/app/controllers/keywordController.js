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
            });
        };
    };

    KeywordController.$inject = ['$scope', '$routeParams', '$timeout', 'keywordsService'];
    angular.module('trendsTrackerApp').controller('KeywordController', KeywordController);
}());