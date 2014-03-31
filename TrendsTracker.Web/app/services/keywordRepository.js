var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordRepository = function ($http, $q)
    {
        var serviceBase = '/api/keywords/';
        var factory = {};

        factory.getByName = function (name)
        {
            return $http.get(serviceBase + name).then(function (results)
            {
                return results.data;
            });
        };

        return factory;
    };

}(trendsTracker || (trendsTracker = {})));
