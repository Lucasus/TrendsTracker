describe("Test", function () {

    beforeEach(angular.mock.module('app'));

    beforeEach(function () {
        //app.controller('myCtrl', context.myCtrlOld);
        spyOn(context.myCtrlOld, 'doSomething');
    });


    describe("example test", function () {
        it("should return bar", angular.mock.inject(function($rootScope, $controller){ 


          //  context.myCtrl.prototype.doSomething = function () { };

            var ctrl = $controller('myCtrl',
            {
                $scope: {}
            });
            // ctrl.doSomething has already run!

            expect('xxx').toBe(true);


            //expect(App.foo()).toEqual("bar");
        }));
    });
});