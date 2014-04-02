(function (trendsTracker)
{
    "use strict";

    trendsTracker.KeywordRepository = function ($resource, $q)
    {
        var resourceUri = '/api/keywords/:name';

        return $resource(resourceUri,
        {
            name: '@Name',
        });
    };
}(window.trendsTracker = window.trendsTracker || {}));
