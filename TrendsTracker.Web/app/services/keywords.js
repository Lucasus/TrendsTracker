(function ()
{
    "use strict";

    trendsTrackerApp.factory('keywords', function ($resource, $q)
    {
        return $resource('/api/keywords/:urlFriendlyName',
        {
            urlFriendlyName: '@urlFriendlyName',
            id: '@id'
        }, 
        {
            'update': { method: 'POST', url: '/api/keywords/:id/update' },
            'create': { method: 'POST', url: '/api/keywords/create' },
        });
    });
}());
