(function ()
{
    "use strict";

    trendsTrackerApp.factory('keywordRepository', function ($resource, $q)
    {
        var resourceUri = '/api/keywords/:name';

        return $resource(resourceUri,
        {
            name: '@Name',
        });
    });
}());
