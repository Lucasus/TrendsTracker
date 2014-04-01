var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordRepository = function ($http, $q)
    {
        var serviceBase = '/api/keywords/';

        this.getAll = function ()
        {
            return $http.get(serviceBase).then(function (results)
            {
                return results.data;
            });
        };

        this.getByName = function (name)
        {
            return $http.get(serviceBase + name).then(function (results)
            {
                return results.data;
            });
        };

    };

}(trendsTracker || (trendsTracker = {})));
