var trendsTracker;
(function (trendsTracker)
{
    "use strict";

    var app = angular.module('trendsTrackerApp', ['ngRoute'])
        .controller('KeywordController', trendsTracker.KeywordController)
        .factory('keywordRepository', trendsTracker.KeywordRepository);

    app.config(['$routeProvider', function ($routeProvider)
    {
        $routeProvider
            .when('/keyword/:keywordName',
            {
                controller: 'KeywordController',
                templateUrl: '/app/views/keyword.html'
            })
            .otherwise({ redirectTo: '/' });
    }]);

    app.run([
        function ()
        {
        }]);
}(trendsTracker || (trendsTracker = {})));

