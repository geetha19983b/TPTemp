angular.module('tPartnerApp').factory('TradingPartnerResource', ['$resource', 'APIService',
function ($resource, APIService) {

    return $resource(APIService.getAPIBase() + 'TradingService/' + ':ID', { ID: '@ID' }, {
        update: {
            method: 'PUT'
        },
        search: {
            url: APIService.getAPIBase() + 'TradingService/search',
            method: 'GET',
            isArray: true
        }
    });
}]);