var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    var app = angular.module('trendsTrackerApp', ['ngRoute'])
        .controller('KeywordController', trendsTracker.KeywordController)
        .service('keywordRepository', trendsTracker.KeywordRepository);

    app.config(['$routeProvider', function ($routeProvider)
    {
        $routeProvider
            .when('/keywords',
            {
                controller: 'KeywordController',
                templateUrl: '/app/views/keywords.html'
            })
            .otherwise({ redirectTo: '/keywords' });
    }]);

}(trendsTracker || (trendsTracker = {})));

