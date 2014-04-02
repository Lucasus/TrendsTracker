(function (trendsTracker)
{
    "use strict";

    var app = angular.module('trendsTrackerApp', ['ngRoute', 'ngResource'])
        .service('spinner', trendsTracker.Spinner)
        .factory('keywordRepository', trendsTracker.KeywordRepository)
        .controller('KeywordsController', trendsTracker.KeywordsController)
        .controller('KeywordController', trendsTracker.KeywordController)
        .controller('SpinnerController', trendsTracker.SpinnerController);

    app.config(['$routeProvider', function ($routeProvider)
    {
        $routeProvider
            .when('/keywords',
            {
                controller: 'KeywordsController',
                templateUrl: '/app/views/keywords.html'
            })
            .when('/keywords/:name',
            {
                controller: 'KeywordController',
                templateUrl: '/app/views/keyword.html'
            })
            .otherwise({ redirectTo: '/keywords' });
    }]);

}(window.trendsTracker = window.trendsTracker || {}));
