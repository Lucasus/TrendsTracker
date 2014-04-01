var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    var app = angular.module('trendsTrackerApp', ['ngRoute'])
        .service('spinner', trendsTracker.Spinner)
        .service('keywordRepository', trendsTracker.KeywordRepository)
        .controller('KeywordController', trendsTracker.KeywordController)
        .controller('SpinnerController', trendsTracker.SpinnerController);

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

