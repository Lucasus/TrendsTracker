(function ()
{
    "use strict";

    trendsTrackerApp.factory('keywords', function ($resource, $q)
    {
        var urlPrefix = "/api/keywords/";

        return $resource(urlPrefix + ':urlFriendlyName',
        {
            id: '@id'
        }, 
        {
            'create': { method: 'POST' },
            'update': { method: 'POST', url: urlPrefix + ':id' },
            'delete': { method: 'DELETE', url: urlPrefix + ':id' }
        });
    });
}());
