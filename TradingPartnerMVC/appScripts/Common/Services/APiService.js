angular.module('tPartnerApp').factory('APIService', function () {
    return {
        getAPIBase: function () {
            return 'http://localhost:10116/api/';
        }
    };
});
