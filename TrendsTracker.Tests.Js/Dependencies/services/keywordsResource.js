(function ()
{
    "use strict";

    trendsTrackerApp.factory('keywordsResource', function ($resource, $q)
    {
        var urlPrefix = "/api/keywords/";

        return $resource(urlPrefix + ':urlFriendlyName',
        {
            id: '@id'
        }, 
        {
            'query': { method: 'GET', isArray: false },
            'create': { method: 'POST' },
            'update': { method: 'POST', url: urlPrefix + ':id' },
            'delete': { method: 'DELETE', url: urlPrefix + ':id' }
        });
    });
}());
