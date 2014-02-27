﻿(function ()
{
    "use strict";

    var app = angular.module('trendsTrackerApp',
        ['ngRoute']);

    app.config(['$routeProvider', function ($routeProvider)
    {
        $routeProvider
            .when('/keyword',
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
}());