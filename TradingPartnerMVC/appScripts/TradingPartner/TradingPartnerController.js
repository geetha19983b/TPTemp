'use strict';
function detailInit(e) {
    var detailRow = e.detailRow;

    detailRow.find(".tabstrip").kendoTabStrip({
        animation: {
            // fade-out current tab over 1000 milliseconds
            close: {
                duration: 1000,
                effects: "fadeOut"
            },
            // fade-in new tab over 500 milliseconds
            open: {
                duration: 500,
                effects: "fadeIn"
            }
        }
    });
}

angular.module('tPartnerApp').controller('TradingPartnerController', ['$scope', '$uibModal', 'TradingPartnerResource', '$timeout', 'RegexService',  function ($scope, $uibModal, TradingPartnerResource, $timeout, RegexService) {
    $scope.totalRecords = 0;
    $scope.searchTradingPartner = {};
   
    $scope.templateLoader = templateLoader;
    $scope.dataSource = new kendo.data.DataSource({
        transport: {
            read: function (options) {
                var gridParameters = { CurrentPage: options.data.page, PageSize: options.data.pageSize };
                var parameters = angular.extend({}, $scope.searchTradingPartner, gridParameters);
                var promise = null;
                if ($scope.search == true) {
                    //parameters = _.omit(parameters, function (value, key, object) {
                    //    return _.isEmpty(value) && !_.isDate(value);
                    //});

                    parameters.CurrentPage = options.data.page;
                    parameters.PageSize = options.data.pageSize;

                    promise = TradingPartnerResource.search(parameters).$promise
                }
                else {
                    promise = TradingPartnerResource.query(parameters).$promise;
                }
                promise.then(function (response) {
                    $scope.totalRecords = response[0].TotalRecords;
                    options.success(response[0].TPResults);
                    if ($scope.searchFirstTime == true) {
                        $scope.dataSource.page(1);
                        $scope.searchFirstTime = false;
                    }
                }).catch(function (response) {
                    options.error(response);
                });
            }
        },
        serverPaging: true,
        pageSize: 10,
       
        schema: {
            total: function (response) {
                return $scope.totalRecords;
            }
        }
    });
    $scope.gridOptions = {
        dataSource: $scope.dataSource,
        sortable: true,
        scrollable: true,
       // editable: "popup",      //editable type popup/inline/batch
        //toolbar: ["create"],    //toolbar options
        //add this code in maingrid options
        dataBound: function () {
            this.expandRow(this.tbody.find("tr.k-master-row").first());
        },
        detailTemplate: kendo.template($("#template").html()),
        detailInit: detailInit,
        pageable: true,
        columns: [{
            field: "Customer",
            title: "Customer Name",
            width: 100
        },
        {
            field: "CustomerNumber",
            title: "CustomerNumber",
            width: 100
        },
        {
            field: "CustomerEffectiveDate",
            title: "CustomerEffectiveDate",
            template: "{{dataItem.CustomerEffectiveDate |  date:'MM/dd/yyyy'}}",
            width: 150
        },
        {
            field: "CustomerTermDate",
            title: "CustomerTermDate",
            template: "{{dataItem.CustomerTermDate |  date:'MM/dd/yyyy'}}",
            width: 150
        },
         {
             title: "",
             
             template: "<i class='glyphicon glyphicon-pencil grid-icon pull-left' data-trigger='hover' role='button' bs-tooltip data-placement='left' data-title='Edit this code' ng-click='editCode(dataItem)'></i>&nbsp;<i class='glyphicon glyphicon-trash grid-icon' ng-click='deleteCode(dataItem)' bs-tooltip data-placement='left' data-title='Delete this code' data-trigger='hover'></i>",
              
             width: 80
         }

        //{ command: ["edit", "destroy"], title: "Actions", width: "150px" },

        
      
        ]
    };

    $scope.searchCode = function () {
        $scope.search = true;
        $scope.searchFirstTime = true;
        $scope.dataSource.read();
    }
    $scope.editCode = function (dataItem) {
        // GET the add on code before opening the wizard
        TradingPartnerResource.get({ ID: dataItem.ID }).$promise.then(function (response) {
            var editModalInstance = $uibModal.open({
                animation: true,
                templateUrl: '/Static/TradingPartnerAddEditWizard.html',
                controller: 'TradingPartnerModalInstanceController',
                size: 'lg',
                resolve: {
                    dataModel: function () {
                        return response;
                    },
                    editMode: true
                }
            });
            editModalInstance.result.then(function (dataItem) {
                $scope.dataSource.read();
            });
        });
    };

    $scope.deleteCode = function (dataItem) {
        alert('delete triggered');
        //var confirmActionModalInstance = $uibModal.open({
        //    animation: true,
        //    templateUrl: 'views/Common/DeleteModal.html',
        //    controller: 'DeleteModalController',
        //    size: 'sm',
        //    windowClass: 'alert-modal'
        //});

        //confirmActionModalInstance.result.then(function (result) {
        //    AddOnCodeResource.get({ AddonCodeId: dataItem.AddonCodeId }).$promise.then(function (retrievedDataItem) {
        //        var promise = null;
        //        promise = retrievedDataItem.$delete({ AddonCodeId: dataItem.AddonCodeId });
        //        promise.then(function (response) {
        //            $scope.dataSource.read();
        //        });
        //    });
        //});
    };


}]);

angular.module('tPartnerApp').controller('TradingPartnerModalInstanceController', ['$scope', '$uibModalInstance', 'dataModel', 'editMode', 'TradingPartnerResource', '$timeout', 'RegexService', function ($scope, $uibModalInstance, dataModel, editMode, TradingPartnerResource, $timeout, RegexService) {

    $scope.dataModel = dataModel;
    $scope.editMode = editMode;

    $scope.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };
    $scope.save = function () {
        var promise = null;

       
        if (editMode) {
            alert("in edit");
            promise = $scope.dataModel.$update();
        } else {
          
            promise = $scope.dataModel.$save();
        }
        promise.then(function (response) {
            $uibModalInstance.close(response);
        });
    };
}]);