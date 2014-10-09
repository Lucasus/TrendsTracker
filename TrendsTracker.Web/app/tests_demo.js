console.log('tests_demo');
var context = {};

context.myCtrlOld = function () {
    this.doSomething = function () {
        console.log('myControllerOld');
    };
    this.doSomething();
};

context.myCtrlNew = function () {
    this.doSomething = function () {
        console.log('myControllerNew');
    };
    this.doSomething();
};

var app = angular.module('app', []);
app.controller('myCtrl', context.myCtrlOld);

