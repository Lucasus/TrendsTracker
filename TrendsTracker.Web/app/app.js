var trendsTrackerApp;

(function ()
{
    "use strict";

    trendsTrackerApp = angular.module('trendsTrackerApp', ['ngRoute', 'ngResource', 'ui.bootstrap']);

    trendsTrackerApp.config(['$routeProvider', function ($routeProvider)
    {
        $routeProvider
            .when('/keywords',
            {
                controller: 'KeywordsCtrl',
                templateUrl: '/app/views/keywords.html'
            })
            .when('/keywords/:urlFriendlyName',
            {
                controller: 'KeywordCtrl',
                templateUrl: '/app/views/keyword.html',
                resolve:
                    {
                        urlFriendlyName: function ($route) { return $route.current.params.urlFriendlyName; }
                    }
            })
            .otherwise({ redirectTo: '/keywords' });
    }]);

}());
