(function ()
{
    var keywordsService = function ($http, $q)
    {
        var serviceBase = '/api/keywords/';
        var factory = {};

        factory.getKeyword = function (name)
        {
            return $http.get(serviceBase + name).then(function (results)
            {
                return results.data;
            });
        };

        return factory;
    };

    keywordsService.$inject = ['$http', '$q'];

    angular.module('trendsTrackerApp').factory('keywordsService', keywordsService);

}());