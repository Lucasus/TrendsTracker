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
                controller: 'KeywordsController',
                templateUrl: '/app/views/keywords.html'
            })
            .when('/keywords/:name/:mode',
            {
                controller: 'KeywordController',
                templateUrl: '/app/views/keyword.html',
                resolve:
                    {
                        name: function ($route)
                        {
                            return $route.current.params.name
                        },

                        mode: function ($route)
                        {
                            return $route.current.params.mode
                        }
                    }
            })
            .otherwise({ redirectTo: '/keywords' });
    }]);

}());
