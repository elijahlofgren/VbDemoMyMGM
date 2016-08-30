angular.module('LocalEventService', [])
.service('LocalEventService', function () {
    this.hello = function () {
        return 'hello world from service!';
    }
});
