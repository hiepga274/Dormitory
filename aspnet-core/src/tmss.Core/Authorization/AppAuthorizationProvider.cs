using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;

namespace tmss.Authorization
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// See <see cref="AppPermissions"/> for all permission names.
    /// </summary>
    public class AppAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public AppAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public AppAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

            #region "Datahub API"
            var DatahubAPI = pages.CreateChildPermission(AppPermissions.Pages_Datahub_Permission, L("DatahubApi"));
            DatahubAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Permission_Product, L("DatahubApiProduct"));
            DatahubAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Permission_Finance, L("DatahubApiFinance"));
            DatahubAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Permission_Insurance, L("DatahubApiInsurance"));
            DatahubAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Permission_News, L("DatahubApiNews"));
            DatahubAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Permission_Loyalty, L("DatahubApiLoyalty"));

            var DatahubWebsiteAPI = pages.CreateChildPermission(AppPermissions.Pages_Datahub_Website_Permission, L("DatahubWebsiteApi"));
            DatahubWebsiteAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Website_Permission_Product, L("DatahubApiProduct"));
            DatahubWebsiteAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Website_Permission_Finance, L("DatahubApiFinance"));
            DatahubWebsiteAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Website_Permission_Insurance, L("DatahubApiInsurance"));
            DatahubWebsiteAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Website_Permission_News, L("DatahubApiNews"));
            DatahubWebsiteAPI.CreateChildPermission(AppPermissions.Pages_Datahub_Website_Permission_Loyalty, L("DatahubApiLoyalty"));
            #endregion

            #region API Loyalty
            var LoyaltyAPI = pages.CreateChildPermission(AppPermissions.Pages_LoyaltyAPI_Permission, L("LoyaltyAPI"));
            #endregion

            #region "API Dealers"
            var APIDealers = pages.CreateChildPermission(AppPermissions.Pages_API_Dealers, L("APIDealers"));
            APIDealers.CreateChildPermission(AppPermissions.Pages_API_Dealers_GetCustomerInformation, L("GetCustomerInformationFromSalesApp"));
            APIDealers.CreateChildPermission(AppPermissions.Pages_API_Dealers_UpdateCustomerStatus, L("UpdateCustomerInformationFromSalesApp"));
            APIDealers.CreateChildPermission(AppPermissions.Pages_API_Dealers_GetContractInformation, L("GetContractInformationFromSalesApp"));
            APIDealers.CreateChildPermission(AppPermissions.Pages_API_Dealers_UpdateContractInformation, L("UpdateContractInformationByContractForSalesApp"));
            APIDealers.CreateChildPermission(AppPermissions.Pages_API_Dealers_CreateNewLeadCustomer, L("CreateNewLeadCustomer"));
            #endregion
            #region "Msig Api"
            var msigApi = pages.CreateChildPermission(AppPermissions.Pages_Sales_Tmv_Msig, L("MsigApi"));
            #endregion
            #region "Website Api"
            var websiteApi = pages.CreateChildPermission(AppPermissions.WebsiteApi, L("WebsiteApi"));
            #endregion

            #region "CusApp"
            var CusApp = pages.CreateChildPermission(AppPermissions.Pages_Master_Sales_CustomApi, L("CusApp"));
            #endregion

            #region "Web"
            // Dashboard
            #region "Dashboard"

            #region "Dashboard for Tenant"
            var dashboardForTenant = pages.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard, L("Dashboard"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetOverTable, L("WidgetsOverViewDataTable"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetTransitionStatus, L("WidgetTransitionStatus"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetTargetActualQty, L("WidgetTargetActualQty"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetConversionRate, L("WidgetConversionRate"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetReasonOfLost, L("WidgetReasonOfLost"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetLocateSalesPerson, L("WidgetLocateSalesPerson"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetConversionRateSalesPerson, L("WidgetConversionRateSalesPerson"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetFollowActivitySalesPerson, L("WidgetFollowActivitySalesPerson"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetListSoldCar, L("WidgetListSoldCar"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetNumberOfConversions, L("WidgetNumberOfConversions"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSource, L("WidgetSourceAuthorization"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetGrade, L("WidgetGrade"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetDetailPotentialCustomer, L("DetailPotentialCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSaleProcess, L("WidgetSaleProcess"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetProvince, L("WidgetProvinceAuthorization"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetDistrict, L("WidgetDistrictAuthorization"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSourceInfo, L("WidgetSourceInfo"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetPaymentMethod, L("WidgetPaymentMethod"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerSold, L("WidgetCustomerSold"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetPaymentMethodOfCustomer, L("WidgetPaymentMethodOfCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetDistrictOfCustomer, L("WidgetDistrictOfCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetProvinceOfCutomer, L("WidgetProvinceOfCutomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetProcessOfCustomer, L("WidgetProcessOfCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSourceOfCustomer, L("WidgetSourceOfCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetVehicleOfCustomer, L("WidgetVehicleOfCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetAverageConversiontime, L("WidgetAverageConversiontime"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetAveragecontacttime, L("WidgetAveragecontacttime"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSourceInforOfCustomer, L("WidgetSourceInforOfCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetNumberInquiryOverMonthForDealer, L("WidgetNumberInquiryOverMonthForDealer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetResultConversionOverMonthForDealer, L("WidgetResultConversionOverMonthForDealer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetListInquiryFromTMVForDealer, L("WidgetListInquiryFromTMVForDealer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetStatisticsInquiryOverGroupForDealer, L("WidgetStatisticsInquiryOverGroupForDealer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetStructureGeneralCustomer, L("WidgetStructureGeneralCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetGereralCustomerByDept, L("WidgetGereralCustomerByDept"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetGereralCustomerByWeek, L("WidgetGereralCustomerByWeek"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetGereralCustomerByMonth, L("WidgetGereralCustomerByMonth"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetStructureSourceCustomer, L("WidgetStructureSourceCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSummarySourceCustomer, L("WidgetSummarySourceCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSummaryVehicleCustomer, L("WidgetSummaryVehicleCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetLostVehicleCustomer, L("WidgetLostVehicleCustomer"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetGroupCustomerDRA, L("WidgetGroupCustomerDRA"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetGroupCustomerProvince, L("WidgetGroupCustomerProvince"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerPRMSource, L("WidgetCustomerPRMSource"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerPRMModel, L("WidgetCustomerPRMModel"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerPRMSourceModel, L("WidgetCustomerPRMSourceModel"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetContactDetailHwc, L("WidgetContactDetailHwc"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetVehicleSalesPerson, L("WidgetVehicleSalesPerson"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetContactGeneralHwc, L("WidgetContactGeneralHwc"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetMovementImCwd, L("WidgetMovementImCwd"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetMovementSale, L("WidgetMovementSale"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCwdPlanByModel, L("WidgetCwdPlanByModel"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSaleActualPlanByModel, L("WidgetSaleActualPlanByModel"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCwdPlanByDayOrWeekly, L("WidgetCwdPlanByDayOrWeekly"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSalePlanByDayOrWeekly, L("WidgetSalePlanByDayOrWeekly"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetDetailByModelGrade, L("WidgetDetailByModelGrade"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetImConversionTotalByHotness, L("WidgetImConversionTotalByHotness"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetConversionCwdByHotness, L("WidgetConversionCwdByHotness"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetConvesionRateByHotness, L("WidgetConvesionRateByHotness"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetTotalLossReason, L("WidgetTotalLossReason"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByModel, L("WidgetLossByModel"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByPrivateReasons, L("WidgetLossByPrivateReasons"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByOtherDlrsReasons, L("WidgetLossByOtherDlrsReasons"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByOtherMakerReasons, L("WidgetLossByOtherMakerReasons"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerBySourceTotal, L("WidgetCustomerBySourceTotal"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerBySalepersonSource, L("WidgetCustomerBySalepersonSource"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerByDealerSource, L("WidgetCustomerByDealerSource"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerByTmvSource, L("WidgetCustomerByTmvSource"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerByTotalModels, L("WidgetCustomerByTotalModels"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetNewCustomerByGrade, L("WidgetNewCustomerByGrade"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetRemainingCustomerByGrade, L("WidgetRemainingCustomerByGrade"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetAllCustomerByHotness, L("WidgetAllCustomerByHotness"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetAllOfCustomerByModel, L("WidgetAllOfCustomerByModel"), multiTenancySides: MultiTenancySides.Tenant);
            dashboardForTenant.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard_WidgetSalesActualAndCWDPlanByModel, L("WidgetActualAndCwdWithPlanByModel"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion

            #region "Dashboard for Host"
            var dashboardForHost = pages.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard, L("Dashboard"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetOverTable, L("WidgetsOverViewDataTable"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetTransitionStatus, L("WidgetTransitionStatus"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetTargetActualQty, L("WidgetTargetActualQty"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetReasonOfLost, L("WidgetReasonOfLost"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRate, L("WidgetConversionRate"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNumberInquiryOfMonth, L("WidgetNumberInquiryOfMonth"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateOverMonth, L("WidgetConversionRateOverMonthHost"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionSourceOverMonth, L("WidgetConversionSourceOverMonth"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetStatisticsInquiryOverDealer, L("WidgetStatisticsInquiryOverDealer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetResultConversionOverMonth, L("WidgetResultConversionOverMonth"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetListInquiryFromTMV, L("WidgetListInquiryFromTMV"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetInquiryTMVReasonOfNC, L("WidgetInquiryTMVReasonOfNC"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLeadByAge, L("LeadByAge"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomersSoldForTMV, L("WidgetCustomerSold"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDetailPotentialCustomerForTMV, L("DetailPotentialCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceChartForTMV, L("WidgetSourceAuthorization"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceOfCustomerForTMV, L("WidgetSourceOfCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetGradeChartForTMV, L("WidgetGrade"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProvinceForTMV, L("WidgetProvinceAuthorization"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDistrictForTMV, L("WidgetDistrictAuthorization"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceInforForTMV, L("WidgetSourceInfo"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProcessForTMV, L("WidgetSaleProcess"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetPaymentMethodForTMV, L("WidgetPaymentMethod"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetVehicleOfCustomerForTMV, L("WidgetVehicleOfCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProvinceOfCutomerForTMV, L("WidgetProvinceOfCutomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDistrictOfCustomerForTMV, L("WidgetDistrictOfCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetPaymentMethodOfCustomerForTMV, L("WidgetPaymentMethodOfCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProcessOfCustomerForTMV, L("WidgetProcessOfCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceInforOfCustomerForTMV, L("WidgetSourceInforOfCustomer"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAverageConversiontimeForTMV, L("WidgetAverageConversiontime"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAveragecontacttimeForTMV, L("WidgetAveragecontacttime"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetWeeklyTrackingByAge, L("WeeklyTrackingByAge"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusBySource, L("NewlyAddedLeadStatusBySource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusByRegion, L("NewlyAddedLeadStatusByRegion"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusByRegionAndSource, L("NewlyAddedLeadStatusByRegionAndSource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetViewContactedBySource, L("ViewContactedBySource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetViewSuccessContactedBySource, L("ViewSuccessContactedBySource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetContactAndContactSuccessRate, L("ContactAndContactSuccessRate"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateOfInquiryToSR, L("ConversionRateOfInquiryToSR"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetVehicleSalesPersonForTMV, L("WidgetVehicleSalesPersonForTMV"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetRankingByDealers, L("RankingByDealers"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAverageLeadTimeFromGeneration, L("AverageLeadTimeFromGeneration"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLeadTimeByDealersFromGeneration, L("LeadTimeByDealersFromGeneration"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsCWD, L("DeepDiveAnalysisListOfSelectedLeadsCWD"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsInquiry, L("DeepDiveAnalysisListOfSelectedLeadsInquiry"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsContactedFailed, L("DeepDiveAnalysisListOfSelectedLeadsContactedFailed"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLocateDealerForTMV, L("LocateDealerForTMV"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateForTMV, L("ConversionRateForTMV"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetStatisticsInquiryOverMonthForTmv, L("StatisticsInquiryOverMonthForTmv"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetMovementImCwdForTmv, L("WidgetMovementImCwd"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAllOfCustomerByModelForTmv, L("WidgetAllOfCustomerByModel"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAllCustomerByHotnessForTmv, L("WidgetAllCustomerByHotness"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerBySourceTotalForTmv, L("WidgetCustomerBySourceTotal"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerBySalepersonSourceForTmv, L("WidgetCustomerBySalepersonSource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerByDealerSourceForTmv, L("WidgetCustomerByDealerSource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerByTmvSourceForTmv, L("WidgetCustomerByTmvSource"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetTotalLossReasonForTmv, L("WidgetTotalLossReason"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossByPrivateReasonsForTmv, L("WidgetLossByPrivateReasons"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossOtherDlrsReasonForTmv, L("WidgetLossByOtherDlrsReasons"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossByOttherMakerReasonsForTmv, L("WidgetLossByOtherMakerReasons"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossByModelForTmv, L("WidgetLossByModel"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetContractGeneralHwcForTmv, L("WidgetContactGeneralHwc"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetFollowActivitySalesPrsonForTmv, L("WidgetFollowActivitySalesPerson"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerByTotalModelForTmv, L("WidgetCustomerByTotalModels"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetRemainingCustomerByGradeForTmv, L("WidgetRemainingCustomerByGrade"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewCustomerByGradeForTmv, L("WidgetNewCustomerByGrade"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetImConversionTotalByHotnessForTmv, L("WidgetImConversionTotalByHotness"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionCwdByHotnessForTmv, L("WidgetConversionCwdByHotness"), multiTenancySides: MultiTenancySides.Host);
            dashboardForHost.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateByHotnessForTmv, L("WidgetConvesionRateByHotness"), multiTenancySides: MultiTenancySides.Host);
            #endregion

            #endregion

            // Quản lý khách hàng
            #region "Menu Customer"
            var customer = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Customer, L("SalesMenuCustomerPermission"));
            #region "Customer"
            var salesCustomer = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomer, L("SalesCustomerPermissionWeb"));
            salesCustomer.CreateChildPermission(AppPermissions.Pages_SalesCustomer_Create, L("CreatePermission"));
            salesCustomer.CreateChildPermission(AppPermissions.Pages_SalesCustomer_View, L("ViewPermission"));
            salesCustomer.CreateChildPermission(AppPermissions.Pages_SalesCustomer_Edit, L("EditPermission"));
            salesCustomer.CreateChildPermission(AppPermissions.Pages_SalesCustomer_Delete, L("Delete"));
            salesCustomer.CreateChildPermission(AppPermissions.Pages_SalesCustomer_View_Duplicate_Customer, L("SalesCustomerViewDuplicateCustomer"));
            salesCustomer.CreateChildPermission(AppPermissions.Pages_SalesCustomer_Import_Encode_Customer_Phone, L("SalesCustomerImportEncodeCustomerPhone"));
            #endregion

            #region "Customer Sell Used Car"
            var salesCustomerSellUsedCar = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomerSellUsedCar, L("SalesCustomerSellUsedCar"));
            salesCustomerSellUsedCar.CreateChildPermission(AppPermissions.Pages_SalesCustomerSellUsedCar_View, L("ViewPermission"));
            salesCustomerSellUsedCar.CreateChildPermission(AppPermissions.Pages_SalesCustomerSellUsedCar_Edit, L("EditPermission"));
            #endregion

            #region "Sale Vehicle UIO"
            var salesVehicleUIO = customer.CreateChildPermission(AppPermissions.Pages_SalesVehicleUIO, L("SalesVehicleUio"));
            salesVehicleUIO.CreateChildPermission(AppPermissions.Pages_SalesVehicleUIO_Search, L("GetSalesCustomerAppointment"));
            salesVehicleUIO.CreateChildPermission(AppPermissions.Pages_SalesVehicleUIO_Create, L("CreateNewSalesCustomerAppointment"));
            salesVehicleUIO.CreateChildPermission(AppPermissions.Pages_SalesVehicleUIO_Edit, L("EditSalesCustomerAppointment"));
            salesVehicleUIO.CreateChildPermission(AppPermissions.Pages_SalesVehicleUIO_Delete, L("DeleteSalesCustomerAppointment"));
            #endregion

            #region "Customer vehicle info"
            var salesCustomerVehicleInfo = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomerVehicleInfo, L("SalesCustomerVehicleInfo"));
            salesCustomerVehicleInfo.CreateChildPermission(AppPermissions.Pages_SalesCustomerVehicleInfo_Create, L("CreateNewSalesCustomerVehicleInfo"));
            salesCustomerVehicleInfo.CreateChildPermission(AppPermissions.Pages_SalesCustomerVehicleInfo_Edit, L("EditSalesCustomerVehicleInfo"));
            salesCustomerVehicleInfo.CreateChildPermission(AppPermissions.Pages_SalesCustomerVehicleInfo_Delete, L("DeleteSalesCustomerVehicleInfo"));
            #endregion

            #region " Customer Transaction Info"
            var salesCustomerTransactionInfo = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomerTransactionInfo, L("SalesCustomerTransactionInfo"));
            salesCustomerTransactionInfo.CreateChildPermission(AppPermissions.Pages_SalesCustomerTransactionInfo_ApproveTransaction, L("ApproveTransaction"));
            salesCustomerTransactionInfo.CreateChildPermission(AppPermissions.Pages_SalesCustomerTransactionInfo_GetListCustomerTranferLossFreezeApprover, L("GetListCustomerTranferLossFreezeApprover"));
            #endregion

            #region "Customer Test Drive"
            var salesCustomerTestDrive = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomerTestDrive, L("SalesCustomerTestDrive"));
            salesCustomerTestDrive.CreateChildPermission(AppPermissions.Pages_SalesCustomerTestDrive_Create, L("CreateNewSalesCustomerTestDrive"));
            salesCustomerTestDrive.CreateChildPermission(AppPermissions.Pages_SalesCustomerTestDrive_Edit, L("EditSalesCustomerTestDrive"));
            salesCustomerTestDrive.CreateChildPermission(AppPermissions.Pages_SalesCustomerTestDrive_Delete, L("DeleteSalesCustomerTestDrive"));
            #endregion

            #region " Customer Manager Comment"
            var salesCustomerManagerComment = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomerManagerComment, L("SalesCustomerManagerComment"));
            salesCustomerManagerComment.CreateChildPermission(AppPermissions.Pages_SalesCustomerManagerComment_Create, L("CreateNewSalesCustomerManagerComment"));
            salesCustomerManagerComment.CreateChildPermission(AppPermissions.Pages_SalesCustomerManagerComment_Edit, L("EditSalesCustomerManagerComment"));
            salesCustomerManagerComment.CreateChildPermission(AppPermissions.Pages_SalesCustomerManagerComment_Delete, L("DeleteSalesCustomerManagerComment"));
            #endregion

            #region "Customer Appointment"
            var salesCustomerAppointment = customer.CreateChildPermission(AppPermissions.Pages_SalesCustomerAppointment, L("SalesCustomerAppointment"));
            salesCustomerAppointment.CreateChildPermission(AppPermissions.Pages_SalesCustomerAppointment_Get, L("GetSalesCustomerAppointment"));
            salesCustomerAppointment.CreateChildPermission(AppPermissions.Pages_SalesCustomerAppointment_Create, L("CreateNewSalesCustomerAppointment"));
            salesCustomerAppointment.CreateChildPermission(AppPermissions.Pages_SalesCustomerAppointment_Edit, L("EditSalesCustomerAppointment"));
            salesCustomerAppointment.CreateChildPermission(AppPermissions.Pages_SalesCustomerAppointment_Delete, L("DeleteSalesCustomerAppointment"));
            #endregion

            #region "SalesCustomerAnniversary"
            var salesCustomerAnniversary = customer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerAnniversary, L("SalesCustomerAnniversary"));
            salesCustomerAnniversary.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerAnniversary_CreateSalesCustomerAnniversary, L("CreateSalesCustomerAnniversary"));
            #endregion

            #region "SalesCustomerGallery"
            var salesCustomerGallery = customer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerGallery, L("SalesCustomerGallery"));
            salesCustomerGallery.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerGallery_Create, L("CreateSalesCustomerGallery"));
            salesCustomerGallery.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerGallery_View, L("ViewSalesCustomerGallery"));
            salesCustomerGallery.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerGallery_Delete, L("DeleteSalesCustomerGallery"));
            #endregion

            #region "SalesCustomerSupervisor"
            var salesCustomerSupervisor = customer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerSupervisor, L("SalesCustomerSupervisor"));
            salesCustomerSupervisor.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerSupervisor_Create, L("CreateSalesCustomerSupervisor"));
            salesCustomerSupervisor.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerSupervisor_View, L("ViewSalesCustomerSupervisor"));
            salesCustomerSupervisor.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerSupervisor_Delete, L("DeleteSalesCustomerSupervisor"));
            #endregion

            #region "SalesTestDrive"
            var saleTestDrive = customer.CreateChildPermission(AppPermissions.Pages_SalesDriveTest, L("SalesTestDrivePermission"));

            #endregion

            #region "Test Drive"
            var testDrive = customer.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTestDrive, L("MstSleVehicleProductTestDrivePermission"));
            testDrive.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTestDrive_Search, L("ViewPermission"));
            #endregion

            #region "MstSleVehicleProductBooking"
            var MstSleVehicleProductBooking = customer.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBooking, L("MstSleVehicleProductBookingPermission"));
            MstSleVehicleProductBooking.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBooking_Search, L("ViewPermission"));
            #endregion

            #region "MstSleCitizenIdentificationOriginal"
            var MstSleCitizenIdentificationOriginal = customer.CreateChildPermission(AppPermissions.Pages__Master_Sales_CitizenIdentificationOriginal, L(" MstSleCitizenIdentificationOriginal"));
            #endregion

            #endregion

            // Quản lý hợp đồng
            #region "Menu Contract"
            var contract = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Contract, L("SaleMenuContract"));

            #region "Sales Contract"
            var saleContract = contract.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_Dealer, L("SaleContractPermission"));
            var saleContractDealer = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract, L("CWD"), multiTenancySides: MultiTenancySides.Tenant);
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetAllContract, L("GetAllContract"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetContractForView, L("GetContractForView"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetAll, L("GetAll"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetAllAdvanceFIlter, L("GetAllAdvanceFIlter"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetProposalByContractId, L("GetProposalByContractId"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetContractByCustomerId, L("GetContractByCustomerId"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetContractByPersionId, L("GetContractByPersionId"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetContractInfoInput, L("GetContractInfoInput"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetCustomerInfo, L("GetCustomerInfo"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetCommon, L("GetCommon"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetProposalByContractByPersionId, L("GetProposalByContractByPersionId"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_CreateOrEditPostSaleContract, L("CreateOrEditPostSaleContract"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetAllContractById, L("GetAllContractById"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_DeleteContractVehcle, L("DeleteContractVehcle"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetListProposalApproveForCustomer, L("GetListProposalApproveForCustomer"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetNameCustomerWithmodeContract, L("GetNameCustomerWithmodeContract"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_GetContractForPDF, L("GetContractForPDF"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_DeleteContract, L("DeleteSalesContract"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_Report, L("Report"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_DocumentForm, L("ReportContractButton"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_ContractDetail_CreateOrEditContractDetail, L("CreateOrEditContractDetail"));
            saleContractDealer.CreateChildPermission(AppPermissions.Pages_Sales_SaleContract_ImportContract, L("ImportSaleContract"));

            #endregion

            #region "Contract Approval"
            var contractApproval = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Contract_Approval, L("SaleContractApprovalPermission"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion

            #region "Contract Admin"
            var contractAdmin = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Contract_Admin, L("SaleContractAdminPermission"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion

            #region "Contract Tmss Management"
            var contractTmssManagement = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Contract_Tmss_Management, L("SaleContractTmssManagementPermission"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion

            #region "Fleet Sales Customer"
            var fleetSalesCustomer = contract.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers, L("SalesFleetSalesCustomer"));
            fleetSalesCustomer.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers_Create_Edit, L("CreateOrEditSalesFleetSalesCustomer"));
            fleetSalesCustomer.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers_Delete, L("DeleteSalesFleetSalesCustomer"));
            fleetSalesCustomer.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers_IsComplied, L("SalesFleetSalesCustomerIsComplied"));
            fleetSalesCustomer.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers_QtyMoreThan50, L("SalesFleetSalesCustomerQtyMoreThan50"));
            fleetSalesCustomer.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers_AddOrUpdateFleetDealerInformation, L("AddOrUpdateFleetDealerInformation"));
            fleetSalesCustomer.CreateChildPermission(AppPermissions.Pages_Sales_FleetCustomers_OnlyView, L("OnlyView"));
            #endregion

            #region ""Sales PPM TMV"
            var salesPPM = pages.CreateChildPermission(AppPermissions.Pages_Sales_SalesPPM, L("SalesPpmTmv"));
            salesPPM.CreateChildPermission(AppPermissions.Pages_Sales_SalesPPM_Create_Edit, L("CreateOrEditSalesPpmTmv"));
            #endregion

            #region "SalesContractVehicle"
            var salesContractVehicle = contract.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractVehicle, L("SalesContractVehicle"));
            salesContractVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractVehicle_CreateOrEditSalesContractVehicle, L("CreateOrEditSalesContractVehicle"));
            #endregion

            #region "SalesContractAccessories"
            var salesContractAccessories = contract.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractAccessories, L("SalesContractAccessories"));
            salesContractAccessories.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractAccessories_GetAccessoriesAndPackage, L("GetAccessoriesAndPackage"));
            salesContractAccessories.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractAccessories_GetAccessoryDetailById, L("GetAccessoryDetailById"));
            salesContractAccessories.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractAccessories_CreateOrEditSalesContractAccessories, L("CreateOrEditSalesContractAccessories"));
            #endregion

            #region "SalesContractApprover"
            var salesContractApprover = contract.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover, L("SalesContractApprover"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_GetListForwardToSalesContractApprover, L("GetListForwardToSalesContractApprover"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_InsertContractApprover, L("InsertContractApprover"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_ApproveSalesContract, L("ApproveSalesContract"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_RejectSalesContract, L("RejectSalesContract"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_Forward, L("Chuyển tiếp hợp đồng"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_GetNameCustomerWithmodeContract, L("GetNameCustomerWithmodeContract"));
            salesContractApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractApprover_CreateSalesCustomerTransactionInfo, L("CreateSalesCustomerTransactionInfo"));
            #endregion

            #region "SalesContractFinance"
            var salesContractFinance = contract.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractFinance, L("SalesContractFinance"));
            salesContractFinance.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractFinance_GetInputForContractFinance, L("GetInputForContractFinance"));
            salesContractFinance.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractFinance_CreateOrEditSalesContractFinance, L("CreateOrEditSalesContractFinance"));
            #endregion

            #region "SalesContractInsurance"
            var salesContractInsurance = contract.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractInsurance, L("SalesContractInsurance"));
            salesContractInsurance.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractInsurance_GetInputForContractInsurance, L("GetInputForContractInsurance"));
            salesContractInsurance.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractInsurance_CreateOrEditSalesContractInsurance, L("CreateOrEditSalesContractInsurance"));
            #endregion

            #region "SalesContractPPM"
            var salesContractPPM = contract.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractPPM, L("SalesContractPPM"));
            salesContractPPM.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractPPM_GetAllContractPPMByDealerId, L("GetAllContractPPMByDealerId"));
            salesContractPPM.CreateChildPermission(AppPermissions.Pages_Sales_SalesContractPPM_CreateOrEditSalesContractPPM, L("CreateOrEditSalesContractPPM"));
            #endregion



            #endregion

            // Quản lý thông tin xe
            #region "Sales Vehicle"
            var salesVehicle = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Sales_Vehicle, L("MstSleSalesVehicle"));

            #region "Import Permisson Grid"
            var gridPermisson = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImportGrid, L("PermissionSalesVehicleImport"));
            gridPermisson.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImportGrid_Save, L("DashboardPermissionSave"));
            gridPermisson.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImportGrid_View, L("DashboardPermissionSave"));
            #endregion

            #region "Sales Vehicle Change Request"
            var changerequest = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleChangeRequest, L("PermissionSalesVehicleChangeRequest"));
            changerequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleChangeRequest_Search, L("PermissionSalesVehicleChangeRequestSearch")); 
            changerequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleChangeRequest_Approve, L("PermissionSalesVehicleChangeRequestApprove"));
            #endregion


            #region "Vehicle Info"
            var vehicleInfo = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicle, L("SalesVehicleInfo"));
            var vehicleInfoTmv = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicle_TMV, L("SalesVehicleInfo"));
            #endregion

            #region "Sales Vehicle Stock"
            var vehicleStock = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleStock, L("SalesVehicleStockPermission"));
            vehicleStock.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleStock_CreateOrEdit, L("SalesVehicleStockCreateOrEdit"));
            vehicleStock.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleStock_Search, L("SalesVehicleStockSearch"));
            #endregion


            #region "Sale Cbu Vechile
            var cbuVehicle = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesCbuVehicle, L("SalesTmvSalesCbuVehicleInfoPermission"));
            #endregion

            #region "Sale Ckd Vechile
            var ckdVehicle = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesCkdVehicle, L("SalesTmvSalesCkdVehicleInfoPermission"));
            #endregion

            #region "Sales Vehicle Import"
            var salesVehicleImport = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport, L("PermissionSalesVehicleImport"));
            #region "Color Request"
            var colorRequest = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_001, L("PermissionSalesVehicleImportCR"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_001_Upload, L("PermissionUpload"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_001_Download, L("PermissionDownload"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_001_Import, L("PermissionImport"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_001_ImportHistory, L("PermissionImportHistory"));
            #endregion
            #region "Invoice Discount"
            var invoiceDiscount = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_003, L("PermissionSalesVehicleImportID"));
            invoiceDiscount.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_003_Upload, L("PermissionUpload"));
            invoiceDiscount.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_003_Download, L("PermissionDownload"));
            invoiceDiscount.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_003_Import, L("PermissionImport"));
            invoiceDiscount.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_003_ImportHistory, L("PermissionImportHistory"));
            #endregion

            #region "Truck Location"
            var truckLocation = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_002, L("PermissionSalesVehicleImportTruckLocation"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_002_Upload, L("PermissionUpload"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_002_Download, L("PermissionDownload"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_002_Import, L("PermissionImport"));
            colorRequest.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_002_ImportHistory, L("PermissionImportHistory"));
            #endregion
            #region "Plan Install Time"
            var planInstallTime = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_004, L("SaleVehiclePlanInstallTime"));
            planInstallTime.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_004_Upload, L("PermissionUpload"));
            planInstallTime.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_004_Download, L("PermissionDownload"));
            planInstallTime.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_004_Import, L("PermissionImport"));
            planInstallTime.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_004_ImportHistory, L("PermissionImportHistory"));
            #endregion
            #region "Fix Payment Deadline"
            var fixPaymentDeadline = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_005, L("SalesVehiclePaymentDeadline"));
            fixPaymentDeadline.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_005_Upload, L("PermissionUpload"));
            fixPaymentDeadline.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_005_Download, L("PermissionDownload"));
            fixPaymentDeadline.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_005_Import, L("PermissionImport"));
            fixPaymentDeadline.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_005_ImportHistory, L("PermissionImportHistory"));
            #endregion

            #region "Defer Payment"
            var deferPayment = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_006, L("UpdateDeferPaymentDealer"));
            deferPayment.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_006_Upload, L("PermissionUpload"));
            deferPayment.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_006_Download, L("PermissionDownload"));
            deferPayment.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_006_Import, L("PermissionImport"));
            deferPayment.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_006_ImportHistory, L("PermissionImportHistory"));
            #endregion

            #region "Maintenace Actual Date"
            var maintenaceActualDate = salesVehicleImport.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_007, L("ImportMaintenaceActualDateTMV"));
            maintenaceActualDate.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_007_Upload, L("PermissionUpload"));
            maintenaceActualDate.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_007_Download, L("PermissionDownload"));
            maintenaceActualDate.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_007_Import, L("PermissionImport"));
            maintenaceActualDate.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleImport_007_ImportHistory, L("PermissionImportHistory"));
            #endregion

            #endregion

            #region "Sales Vehicle Report"
            var salesVehicleReport = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleReport, L("PermissionSalesVehicleReport"));
            #endregion

            #region "Sales Vehicle Invoice"
            var salesVehicleInvoice = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleInvoice, L("PermissionSalesVehicleInvoice"));
            #endregion

            #region "Sales Vehicle Invoice TMV"
            var salesVehicleInvoiceTMV = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleInvoiceTMV, L("PermissionSalesVehicleInvoiceTMV"));
            #endregion

            #region "Test Drive Campaign
            var testDriveCampaign = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_TestDriveCampaign, L("MstSleTestDriveCampaignPermission"));
            testDriveCampaign.CreateChildPermission(AppPermissions.Pages_Sales_TestDriveCampaign_CreateOrEdit, L("MstSleTestDriveCampaignCreateOrEdit"));
            testDriveCampaign.CreateChildPermission(AppPermissions.Pages_Sales_TestDriveCampaign_Search, L("MstSleTestDriveCampaignSearch"));
            testDriveCampaign.CreateChildPermission(AppPermissions.Pages_Sales_TestDriveCampaign_Delete, L("Delete"));
            #region "Master Sale Sending Daily Payment Email History"
            var sendingDelayPaymentEmailHistory = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Sending_Daily_Payment_Email_History, L("SendingDelayPaymentEmailHistory"), multiTenancySides: MultiTenancySides.Host);
            #endregion
            #endregion
            #region "Lịch sử Email theo ngày"
            var SendingDailyPaymentEmail = salesVehicle.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_SendingDailyPaymentEmail, L("MstSleSendingDailyPaymentEmailHistory"));
            SendingDailyPaymentEmail.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_SendingDailyPaymentEmail_Search, L("ViewPermission"));
            #endregion


            /*#region "Config Email"
            var configEmail = salesVehicle.CreateChildPermission(AppPermissions.Pages_Sales_SalesVehicleInvoice_Email_Config, L("PermissionSalesVehicleInvoiceConfigEmail"));
            #endregion*/
            #endregion
            #endregion

            //Quản lý đặt xe
            #region "Sales Order Plan"
            var salesOrderPlan = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Order_Plan, L("SalesOrderPlanPermission"));

            #region "nenkei"
            var nenkei = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_Nenkei, L("SalesOrderPlanNenkeiPermission"));
            nenkei.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_Nenkei_Search, L("ViewPermission"));
            nenkei.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_Nenkei_Create, L("CreatePermission"));
            nenkei.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_Nenkei_Edit, L("EditPermission"));
            nenkei.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_Nenkei_Delete, L("Delete"));
            #endregion

            #region "Version Type"
            var versionType = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VersionType, L("SalesOrderPlanVersionTypePermission"));
            versionType.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VersionType_Search, L("ViewPermission"));
            versionType.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VersionType_Create, L("CreatePermission"));
            versionType.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VersionType_Edit, L("EditPermission"));
            versionType.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VersionType_Delete, L("Delete"));
            #endregion

            #region "Order Config"
            var orderConfig = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_OrderConfig, L("SalesOrderPlanOrderConfigPermission"));
            orderConfig.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_OrderConfig_Search, L("ViewPermission"));
            orderConfig.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_OrderConfig_Create, L("CreatePermission"));
            orderConfig.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_OrderConfig_Edit, L("EditPermission"));
            orderConfig.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_OrderConfig_Delete, L("Delete"));
            #endregion

            #region "Contract Target"
            var contractTarget = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractTarget, L("SalesOrderPlanContractTargetPermission"));
            contractTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractTarget_Search, L("ViewPermission"));
            contractTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractTarget_Create, L("CreatePermission"));
            contractTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractTarget_Edit, L("EditPermission"));
            contractTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractTarget_Delete, L("Delete"));
            #endregion

            #region "Sales Target"
            var salesTarget = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTarget, L("SalesOrderPlanSalesTargetPermission"));
            salesTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTarget_Search, L("ViewPermission"));
            salesTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTarget_Create, L("CreatePermission"));
            salesTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTarget_Edit, L("EditPermission"));
            salesTarget.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTarget_Delete, L("Delete"));
            #endregion

            #region "Sales Target Fleet"
            var salesTargetFleet = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTargetFleet, L("SalesOrderPlanSalesTargetFleetPermission"));
            salesTargetFleet.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTargetFleet_Search, L("ViewPermission"));
            salesTargetFleet.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTargetFleet_Create, L("CreatePermission"));
            salesTargetFleet.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTargetFleet_Edit, L("EditPermission"));
            salesTargetFleet.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesTargetFleet_Delete, L("Delete"));
            #endregion

            #region "Data Rundown"
            var dataRundown = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DataRundown, L("SalesOrderPlanDataRundownPermission"));
            dataRundown.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DataRundown_Search, L("ViewPermission"));
            dataRundown.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DataRundown_Create, L("CreatePermission"));
            dataRundown.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DataRundown_Edit, L("EditPermission"));
            dataRundown.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DataRundown_Delete, L("Delete"));
            #endregion

            #region "Contract Plan"
            var contractPlan = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractPlan, L("SalesOrderPlanContractPlanPermission"));
            contractPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractPlan_Search, L("ViewPermission"));
            contractPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractPlan_Create, L("CreatePermission"));
            contractPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractPlan_Edit, L("EditPermission"));
            contractPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_ContractPlan_Delete, L("Delete"));
            #endregion

            #region "Sales Plan"
            var salesPlan = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesPlan, L("SalesOrderPlanSalesPlanPermission"));
            salesPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesPlan_Search, L("ViewPermission"));
            salesPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesPlan_Create, L("CreatePermission"));
            salesPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesPlan_Edit, L("EditPermission"));
            salesPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_SalesPlan_Delete, L("Delete"));
            #endregion

            #region "Dealer Order"
            var dealerOrder = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DealerOrder, L("SalesOrderPlanDealerOrderPermission"));
            dealerOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DealerOrder_Search, L("ViewPermission"));
            dealerOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DealerOrder_Create, L("CreatePermission"));
            dealerOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DealerOrder_Edit, L("EditPermission"));
            dealerOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_DealerOrder_Delete, L("Delete"));
            #endregion

            #region "Vehicle Allocation"
            var vehicleAllocation = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VehicleAllocation, L("SalesOrderPlanVehicleAllocationPermission"));
            vehicleAllocation.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VehicleAllocation_Search, L("ViewPermission"));
            vehicleAllocation.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VehicleAllocation_Create, L("CreatePermission"));
            vehicleAllocation.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VehicleAllocation_Edit, L("EditPermission"));
            vehicleAllocation.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_VehicleAllocation_Delete, L("Delete"));
            #endregion

            #region "Cbu Color Order"
            var cbuColorOrder = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CbuColorOrder, L("SalesOrderPlanCbuColorOrderPermission"));
            cbuColorOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CbuColorOrder_Search, L("ViewPermission"));
            cbuColorOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CbuColorOrder_Create, L("CreatePermission"));
            cbuColorOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CbuColorOrder_Edit, L("EditPermission"));
            cbuColorOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CbuColorOrder_Delete, L("Delete"));
            #endregion

            #region "Ckd Color Order"
            var ckdColorOrder = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CkdColorOrder, L("SalesOrderPlanCkdColorOrderPermission"));
            ckdColorOrder.CreateChildPermission(AppPermissions.Pages_Sales_Order_Plan_CkdColorOrder_Search, L("ViewPermission"));
            #endregion

            #region "Order Dealer Request"
            var dealerRequest = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Order_Dealer_Request, L("SalesOrderDlrRequest"));
            dealerRequest.CreateChildPermission(AppPermissions.Pages_Sales_Order_Dealer_Request_Search, L("ViewPermission"));
            dealerRequest.CreateChildPermission(AppPermissions.Pages_Sales_Order_Dealer_Request_Create, L("CreatePermission"));
            #endregion

            #region "Target Plan By Day
            var salesTargetForTMV = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Sales_Target_Plan_TMV_ByDay, L("SalesTargetPlan"));

            var saleTargetForTMV_Import = salesTargetForTMV.CreateChildPermission(AppPermissions.Pages_Sales_Target_Plan_TMV_ByDay_Import, L("Import"));
            
            var saleTargetForTMV_Edit = salesTargetForTMV.CreateChildPermission(AppPermissions.Pages_Sales_Target_Plan_TMV_ByDay_Edit, L("EditPermission"));

            var saleTargetForTMV_Delete = salesTargetForTMV.CreateChildPermission(AppPermissions.Pages_Sales_Target_Plan_TMV_ByDay_Delete, L("Delete"));


            var CWDTargetForTMV = salesOrderPlan.CreateChildPermission(AppPermissions.Pages_Cwd_Target_Plan_TMV_ByDay, L("CWDTargetPlan"));

            var CWDTargetForTMV_Import = CWDTargetForTMV.CreateChildPermission(AppPermissions.Pages_Cwd_Target_Plan_TMV_ByDay_Import, L("Import"));

            var CWDTargetForTMV_Edit = CWDTargetForTMV.CreateChildPermission(AppPermissions.Pages_Cwd_Target_Plan_TMV_ByDay_Edit, L("EditPermission"));

            var CWDTargetForTMV_Delete = CWDTargetForTMV.CreateChildPermission(AppPermissions.Pages_Cwd_Target_Plan_TMV_ByDay_Delete, L("Delete"));
            #endregion

            #endregion

            //Quan ly dat xe TMAP
            #region"Order PLan TMAP"
            var salesOrderPlanTMAP = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Order_Plan_TMAP, L("SalesOrderPlanTMAPPermission"));
            #region "FSO Grade Submit Config"
            var fsoGradeSubmitConfig = salesOrderPlanTMAP.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Grade_Submit_Config, L("FsoGradeSubmitConfigPermission"));
            fsoGradeSubmitConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Grade_Submit_Config_Search, L("ViewPermission"));
            fsoGradeSubmitConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Grade_Submit_Config_Create, L("CreatePermission"));
            fsoGradeSubmitConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Grade_Submit_Config_Edit, L("EditPermission"));
            fsoGradeSubmitConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Grade_Submit_Config_Delete, L("Delete"));
            #endregion

            #region "FSO Config"
            var fsoConfig = salesOrderPlanTMAP.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config, L("FsoConfigPermission"));
            fsoConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Search, L("ViewPermission"));
            fsoConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Create, L("CreatePermission"));
            fsoConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Edit, L("EditPermission"));
            fsoConfig.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Delete, L("Delete"));
            #endregion

            #region "FSO Config Type"
            var fsoConfigType = salesOrderPlanTMAP.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Type, L("FsoConfigTypePermission"));
            fsoConfigType.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Type_Search, L("ViewPermission"));
            fsoConfigType.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Type_Create, L("CreatePermission"));
            fsoConfigType.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Type_Edit, L("EditPermission"));
            fsoConfigType.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Config_Type_Delete, L("Delete"));
            #endregion

            #region "FSO Allocation"
            var fsoAllocation = salesOrderPlanTMAP.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Allocation, L("FsoAllocationPermission"));
            fsoAllocation.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Allocation_Search, L("ViewPermission"));
            fsoAllocation.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Allocation_Create, L("CreatePermission"));
            fsoAllocation.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Allocation_Edit, L("EditPermission"));
            fsoAllocation.CreateChildPermission(AppPermissions.Pages_Sales_FSO_Allocation_Delete, L("Delete"));
            #endregion

            #endregion

            //Quản lý Swap xe dealer
            #region "Swap"
            var salesSwap = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swap, L("MstSleSalesSwapping"));

            #region "Dealer Sales"
            var dealerSalesSwap = salesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Swap, L("MstSleDealerSalesSwapping"));

            #region "Dealer Vehicle Info"
            var dealerVehicle = dealerSalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Vehicle_Info, L("MstSleDealerVehicleInfoPermission"));
            //dealerVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Vehicle_Info_Create, L("InspectPermission"));
            dealerVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Vehicle_Info_Search, L("ViewPermission"));
            dealerVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Vehicle_Info_Edit, L("EditPermission"));
            #endregion

            #region " Sell Swapping Vehicle"
            var sellSwapping = dealerSalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Sell, L("MstSleSwappingVehicleSellPermission"));
            sellSwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Sell_Create, L("CreatePermission"));
            sellSwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Sell_Search, L("ViewPermission"));
            sellSwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Sell_Edit, L("EditPermission"));
            sellSwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Sell_Delete, L("Delete"));
            #endregion

            #region " Buy Swapping Vehicle"
            var buySwapping = dealerSalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Buy, L("MstSleSwappingVehicleBuyPermission"));
            buySwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Buy_Create, L("CreatePermission"));
            buySwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Buy_Search, L("ViewPermission"));
            buySwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Buy_Edit, L("EditPermission"));
            buySwapping.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Vehicle_Buy_Delete, L("Delete"));
            #endregion

            #region " Search Vehicle"
            var searchVehicle = dealerSalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Search_Vehicle, L("MstSleSearchVehiclePermission"));
            searchVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Search_Vehicle_Search, L("ViewPermission"));
            #endregion

            #region " Swapping Report"
            var swappingReport = dealerSalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Report, L("MstSleDealerSwappingReportPermission"));
            swappingReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Report_Search, L("ViewPermission"));
            #endregion
            #endregion

            #region "TMV Sales"
            var TMVsalesSwap = salesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swap_TMV, L("MstSleTMVSalesSwapping"));

            #region "  Swapping Vehicle TMV"
            var SwappingTMV = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle, L("MstSleSwappingVehiclePermission"));
            SwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Create, L("CreatePermission"));
            SwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Search, L("ViewPermission"));
            SwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Edit, L("EditPermission"));
            SwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Delete, L("Delete"));
            #endregion

            #region " Info Swapping Vehicle TMV"
            var InfoSwappingTMV = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Info, L("MstSleSwappingVehicleInfoPermission"));
            InfoSwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Create, L("CreatePermission"));
            InfoSwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Search, L("ViewPermission"));
            InfoSwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Edit, L("EditPermission"));
            InfoSwappingTMV.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Delete, L("Delete"));
            #endregion

            #region " Dispatch Change Request"
            var dispatchChangeRequest = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Dispatch_Change_Request, L("MstSleDispatchChangeRequestPermission"));
            dispatchChangeRequest.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Dispatch_Change_Request_Create, L("CreatePermission"));
            dispatchChangeRequest.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Dispatch_Change_Request_Search, L("ViewPermission"));
            dispatchChangeRequest.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Dispatch_Change_Request_Edit, L("EditPermission"));
            dispatchChangeRequest.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Dispatch_Change_Request_Delete, L("Delete"));
            #endregion

            #region " Sell-Buy Matching"
            var sellBuyMatching = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Sell_Buy_Matching, L("MstSleSellBuyMatchingPermission"));
            sellBuyMatching.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Sell_Buy_Matching_Create, L("CreatePermission"));
            sellBuyMatching.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Sell_Buy_Matching_Search, L("ViewPermission"));
            sellBuyMatching.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Sell_Buy_Matching_Edit, L("EditPermission"));
            sellBuyMatching.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Sell_Buy_Matching_Delete, L("Delete"));
            #endregion

            #region " Dealer Swapping Vehicle"
            var dealerSwappingVehicle = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Swapping_Vehicle, L("MstSleDealerSwappingVehiclePermission"));
            dealerSwappingVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Swapping_Vehicle_Create, L("CreatePermission"));
            dealerSwappingVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Swapping_Vehicle_Search, L("ViewPermission"));
            dealerSwappingVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Swapping_Vehicle_Edit, L("EditPermission"));
            dealerSwappingVehicle.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Dealer_Swapping_Vehicle_Delete, L("Delete"));
            #endregion

            #region " TMV Swapping Report"
            var tMVswappingReport = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Report, L("MstSleTMVSwappingVehiclePermission"));
            tMVswappingReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Report_Create, L("CreatePermission"));
            tMVswappingReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Report_Search, L("ViewPermission"));
            tMVswappingReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Report_Edit, L("EditPermission"));
            tMVswappingReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_TMV_Swapping_Report_Delete, L("Delete"));
            #endregion

            #region " Swapping Advance Report"
            var swappingAdvenceReport = TMVsalesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Advance_Report, L("MstSleSwappingAdvanceReportPermission"));
            swappingAdvenceReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Advance_Report_Create, L("CreatePermission"));
            swappingAdvenceReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Advance_Report_Search, L("ViewPermission"));
            swappingAdvenceReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Advance_Report_Edit, L("EditPermission"));
            swappingAdvenceReport.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Swapping_Advance_Report_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Send Info
            var sendInforCompanyCustomer = salesSwap.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Send_Info, L("MstSleProductLead"));

            #region "Dealer Vehicle Info"
            var senInforComCusSub = sendInforCompanyCustomer.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Send_Info_Customer_Company, L("MstSleProductCompanyLead"));
            sendInforCompanyCustomer.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Send_Info_Customer_Company_Search, L("ViewPermission"));
            #endregion

            #endregion

            #endregion

            // Quản lý tích điểm
            #region "Loyalty"
            var loyalty = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty, L("MstSleLoyalty"));

            #region "Loyalty Customer"
            var loyaltyCustomer = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Customer, L("MstSleLoyaltyCustomerPermission"));
            loyaltyCustomer.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Customer_Create, L("CreatePermission"));
            loyaltyCustomer.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Customer_Search, L("ViewPermission"));
            loyaltyCustomer.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Customer_Edit, L("EditPermission"));
            loyaltyCustomer.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Customer_Delete, L("Delete"));
            #endregion

            #region "Loyalty Transaction"
            var mstLoyaltyTransaction = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Transaction, L("MstSleLoyaltyTransactionPermission"));
            mstLoyaltyTransaction.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Transaction_Create, L("CreatePermission"));
            mstLoyaltyTransaction.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Transaction_Search, L("ViewPermission"));
            mstLoyaltyTransaction.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Transaction_Edit, L("EditPermission"));
            mstLoyaltyTransaction.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Transaction_Delete, L("Delete"));
            #endregion

            #region "Loyalty Scheme"
            var loyaltyScheme = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Scheme, L("MstSleLoyaltySchemePermission"));
            loyaltyScheme.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Scheme_Create, L("CreatePermission"));
            loyaltyScheme.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Scheme_Search, L("ViewPermission"));
            loyaltyScheme.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Scheme_Edit, L("EditPermission"));
            loyaltyScheme.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Scheme_Delete, L("Delete"));
            #endregion

            #region "Loyalty Rank"
            var mstLoyaltyRank = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Rank, L("MstSleLoyaltyRankInfoPermission"));
            mstLoyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Rank_Create, L("CreatePermission"));
            mstLoyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Rank_Search, L("ViewPermission"));
            mstLoyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Rank_Edit, L("EditPermission"));
            mstLoyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Rank_Delete, L("Delete"));
            #endregion

            #region "Loyalty Gain"
            var loyaltyGain = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain, L("MstSleLoyaltyGainPermission"));
            loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Search, L("ViewPermission"));
            //loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Create, L("CreatePermission"));
            //loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Edit, L("EditPermission"));
            //loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Delete, L("Delete"));
            #endregion

            #region "Loyalty Gain Rank"
            var loyaltyGainRank = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Rank, L("MstSleLoyaltyGainRankPermission"));
            loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Rank_Search, L("ViewPermission"));
            //loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Create, L("CreatePermission"));
            //loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Edit, L("EditPermission"));
            //loyaltyGain.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gain_Delete, L("Delete"));
            #endregion

            #region "Loyalty Redeem"
            var mstLoyaltyRedeem = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Redeem, L("MstSleLoyaltyRedeemInfoPermission"));
            mstLoyaltyRedeem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Redeem_Create, L("CreatePermission"));
            mstLoyaltyRedeem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Redeem_Search, L("ViewPermission"));
            mstLoyaltyRedeem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Redeem_Edit, L("EditPermission"));
            mstLoyaltyRedeem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Redeem_Delete, L("Delete"));
            #endregion

            #region "Loyalty Gift"
            var loyaltyGift = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift, L("MstSleLoyaltyGiftRewardGiftPermission"));
            loyaltyGift.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Search, L("ViewPermission"));
            loyaltyGift.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Create, L("CreatePermission"));
            loyaltyGift.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Edit, L("EditPermission"));
            loyaltyGift.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Delete, L("Delete"));
            loyaltyGift.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_TMV, L("MstSleLoyaltyGiftRewardGiftTMVPermission"));
            #endregion

            #region "Mst Loyalty Rank"
            var loyaltyRank = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Mst_Loyalty_Rank, L("MstLoyaltyRankPermission"));
            loyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Mst_Loyalty_Rank_Create, L("CreatePermission"));
            loyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Mst_Loyalty_Rank_Search, L("ViewPermission"));
            loyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Mst_Loyalty_Rank_Edit, L("EditPermission"));
            loyaltyRank.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Mst_Loyalty_Rank_Delete, L("Delete"));
            #endregion

            #region "Loyalty Gift Item"
            var loyaltyGiftItem = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Item, L("MstSleLoyaltyGiftItemGiftPermission"));
            loyaltyGiftItem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Item_Create, L("CreatePermission"));
            loyaltyGiftItem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Item_Search, L("ViewPermission"));
            loyaltyGiftItem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Item_Edit, L("EditPermission"));
            loyaltyGiftItem.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Gift_Item_Delete, L("Delete"));
            #endregion

            #region "Loyalty Question"
            var mstLoyaltyQuestion = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Question, L("MstSleLoyaltyQuestionInfoPermission"));
            mstLoyaltyQuestion.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Question_Create, L("CreatePermission"));
            mstLoyaltyQuestion.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Question_Search, L("ViewPermission"));
            mstLoyaltyQuestion.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Question_Edit, L("EditPermission"));
            mstLoyaltyQuestion.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Question_Delete, L("Delete"));
            #endregion

            #region "Loyalty Claim"
            var mstLoyaltyClaim = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Claim, L("MstSleLoyaltyClaimInfoPermission"));
            mstLoyaltyClaim.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Claim_Create, L("CreatePermission"));
            mstLoyaltyClaim.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Claim_Search, L("ViewPermission"));
            mstLoyaltyClaim.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Claim_Edit, L("EditPermission"));
            mstLoyaltyClaim.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Claim_Delete, L("Delete"));
            #endregion

            #region "Cấu hình tự động + job"
            var job = loyalty.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Config, L("LoyaltyConfigPermission"));
            //job.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Config_Create, L("CreatePermission"));
            //job.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Config_Search, L("ViewPermission"));
            //job.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Config_Edit, L("EditPermission"));
            //job.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Loyalty_Config_Delete, L("Delete"));
            #endregion



            #endregion

            //Quản lý nhân viên
            #region "Sales Employee"
            var employee = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Employee, L("EmployeeManagerPermission"));
   

            #region "Organizational Structure"
            //var organizationalStructure = employee.CreateChildPermission(AppPermissions.Pages_Sales_Menu_OrganizationalStructure, L("MstSleOrganizationalStructurePermission"));

            #region "Dealer Organization Chart"
            var dealer = employee.CreateChildPermission(AppPermissions.Pages_Master_Sales_DealerOrganizationChart, L("MstSleJobDealerPermission"));
            dealer.CreateChildPermission(AppPermissions.Pages_Master_Sales_DealerOrganizationChart_Search, L("ViewPermission"));

            #endregion


            

            #endregion

            var employeeRole = employee.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Employee_Role, L("EmployeeRolePermission"));

            var dashboardPermission = employee.CreateChildPermission(AppPermissions.Pages_Dashboard_Permission_Menu, L("DashboardPermissionMenu"));
            dashboardPermission.CreateChildPermission(AppPermissions.Pages_Dashboard_Permission_Search, L("DashboardPermissionSearch"));
            dashboardPermission.CreateChildPermission(AppPermissions.Pages_Dashboard_Permission_Save, L("DashboardPermissionSave"));

            #region "EmployeeAccount"
            var employeeAccount = employee.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeAccount, L("EmployeeAccountPermission"));
            employeeAccount.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeAccount_Search, L("ViewPermission"));
            employeeAccount.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeAccount_Create, L("CreatePermission"));
            employeeAccount.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeAccount_Edit, L("EditPermission"));
            employeeAccount.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeAccount_Delete, L("Delete"));
            #endregion
            
            #region "UserClickToCall"
            var userClickToCall = employee.CreateChildPermission(AppPermissions.Pages_Master_Sales_UserClickToCall, L("UserClickToCallPermission"));
            userClickToCall.CreateChildPermission(AppPermissions.Pages_Master_Sales_UserClickToCall_Search, L("ViewPermission"));
            userClickToCall.CreateChildPermission(AppPermissions.Pages_Master_Sales_UserClickToCall_Create, L("CreatePermission"));
            userClickToCall.CreateChildPermission(AppPermissions.Pages_Master_Sales_UserClickToCall_Edit, L("EditPermission"));
            userClickToCall.CreateChildPermission(AppPermissions.Pages_Master_Sales_UserClickToCall_Delete, L("Delete"));
            #endregion

            #region "General Function Role"
            var generalFunctionRole = employee.CreateChildPermission(AppPermissions.Pages_Sales_General_Function_Role, L("GeneralFunctionRolePermission"));
            generalFunctionRole.CreateChildPermission(AppPermissions.Pages_Sales_General_Function_Role_Search, L("ViewPermission"));
            generalFunctionRole.CreateChildPermission(AppPermissions.Pages_Sales_General_Function_Role_Create, L("CreatePermission"));
            generalFunctionRole.CreateChildPermission(AppPermissions.Pages_Sales_General_Function_Role_Edit, L("EditPermission"));
            generalFunctionRole.CreateChildPermission(AppPermissions.Pages_Sales_General_Function_Role_Delete, L("Delete"));
            #endregion

            #region "Sales Person"
            var salesPerson = employee.CreateChildPermission(AppPermissions.Pages_Sales_SalesPerson, L("SalesPersonPermission"));
            salesPerson.CreateChildPermission(AppPermissions.Pages_Sales_SalesPerson_Search, L("ViewPermission"));
            salesPerson.CreateChildPermission(AppPermissions.Pages_Sales_SalesPerson_Create, L("CreatePermission"));
            salesPerson.CreateChildPermission(AppPermissions.Pages_Sales_SalesPerson_Edit, L("EditPermission"));
            salesPerson.CreateChildPermission(AppPermissions.Pages_Sales_SalesPerson_Delete, L("Delete"));
            #endregion

            #region "SalesCustomerPhoneDuplicateDealer"
            var SalesCustomerPhoneDuplicateDealer = employee.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerPhoneDuplicateDealer, L("SalesCustomerPhoneDuplicateDealerPermission"));
            SalesCustomerPhoneDuplicateDealer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerPhoneDuplicateDealer_Search, L("ViewPermission"));
            SalesCustomerPhoneDuplicateDealer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerPhoneDuplicateDealer_Create, L("CreatePermission"));
            SalesCustomerPhoneDuplicateDealer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerPhoneDuplicateDealer_Edit, L("EditPermission"));
            SalesCustomerPhoneDuplicateDealer.CreateChildPermission(AppPermissions.Pages_Sales_SalesCustomerPhoneDuplicateDealer_Delete, L("Delete"));
            #endregion

            #region "DashboardChartGroupConfig"

            var DashboardChartGroupConfig = employee.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartGroupConfig, L("DashboardChartGroupConfigPermission"));

            #region DashboardChartList
                var DashboardChartList = DashboardChartGroupConfig.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartList, L("DashboardChartListPermission"), multiTenancySides: MultiTenancySides.Host);
                DashboardChartList.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartListView, L("ViewPermission"), multiTenancySides: MultiTenancySides.Host);
                DashboardChartList.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartListEdit, L("EditPermission"), multiTenancySides: MultiTenancySides.Host);
            #endregion

            #region DashboardChartGroup
            var DashboardChartGroup = DashboardChartGroupConfig.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartGroup, L("DashboardChartGroupPermission"), multiTenancySides: MultiTenancySides.Tenant);
            DashboardChartGroup.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartGroupView, L("ViewPermission"), multiTenancySides: MultiTenancySides.Tenant);
            DashboardChartGroup.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartGroupEdit, L("EditPermission"), multiTenancySides: MultiTenancySides.Tenant);
            DashboardChartGroup.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartGroupDetailView, L("ViewPermission"), multiTenancySides: MultiTenancySides.Tenant);
            DashboardChartGroup.CreateChildPermission(AppPermissions.Pages_Sales_DashboardChartGroupDetailEdit, L("EditPermission"), multiTenancySides: MultiTenancySides.Tenant);
            #endregion

            #endregion

            #endregion

            //Quản lý nhân sự
            #region
            var humanResource = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Human_Resource, L("EmpPermission"));
            #region Danh mục
            var category = humanResource.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Human_Resource_Category, L("MstSleInformationCategory"));
           

            #region " Job Title"
            var jobTitle = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_JobTitle, L("MstSleJobTitlePermission"));
            jobTitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_JobTitle_Search, L("ViewPermission"));
            jobTitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_JobTitle_Create, L("CreatePermission"));
            jobTitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_JobTitle_Edit, L("EditPermission"));
            jobTitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_JobTitle_Delete, L("Delete"));
            #endregion

            #region "Education"
            var education = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_Education, L("MstSleEducationPermission"));
            education.CreateChildPermission(AppPermissions.Pages_Master_Sales_Education_Search, L("ViewPermission"));
            education.CreateChildPermission(AppPermissions.Pages_Master_Sales_Education_Create, L("CreatePermission"));
            education.CreateChildPermission(AppPermissions.Pages_Master_Sales_Education_Edit, L("EditPermission"));
            education.CreateChildPermission(AppPermissions.Pages_Master_Sales_Education_Delete, L("Delete"));
            #endregion

            #region "jobs"
            var jobs = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_Jobs, L("MstSleJobsPermission"));
            jobs.CreateChildPermission(AppPermissions.Pages_Master_Sales_Jobs_Search, L("ViewPermission"));
            jobs.CreateChildPermission(AppPermissions.Pages_Master_Sales_Jobs_Create, L("CreatePermission"));
            jobs.CreateChildPermission(AppPermissions.Pages_Master_Sales_Jobs_Edit, L("EditPermission"));
            jobs.CreateChildPermission(AppPermissions.Pages_Master_Sales_Jobs_Delete, L("Delete"));
            #endregion

            #region "Department"
            var Department = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_Department, L("MstSleDepartmentPermission"));
            Department.CreateChildPermission(AppPermissions.Pages_Master_Sales_Department_Create, L("CreatePermission"));
            Department.CreateChildPermission(AppPermissions.Pages_Master_Sales_Department_Edit, L("EditPermission"));
            Department.CreateChildPermission(AppPermissions.Pages_Master_Sales_Department_Delete, L("Delete"));
            Department.CreateChildPermission(AppPermissions.Pages_Master_Sales_Department_Search, L("ViewPermission"));
            #endregion

            #region "Certificate"
            var certificate = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertificate, L("MstSleCertificatePermission"));
            certificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertificate_Create, L("CreatePermission"));
            certificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertificate_Edit, L("EditPermission"));
            certificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertificate_Delete, L("Delete"));
            certificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertificate_Search, L("ViewPermission"));
            #endregion

            #region "TradeSchool"
            var tradeSchool = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_TradeSchool, L("MstSleTradeSchoolPermission"));
            tradeSchool.CreateChildPermission(AppPermissions.Pages_Master_Sales_TradeSchool_Create, L("CreatePermission"));
            tradeSchool.CreateChildPermission(AppPermissions.Pages_Master_Sales_TradeSchool_Edit, L("EditPermission"));
            tradeSchool.CreateChildPermission(AppPermissions.Pages_Master_Sales_TradeSchool_Delete, L("Delete"));
            tradeSchool.CreateChildPermission(AppPermissions.Pages_Master_Sales_TradeSchool_Search, L("ViewPermission"));
            #endregion

            #region "ExamConditions"
            var examConditions = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExamConditions, L("MstSleExamConditionsPermission"));
            examConditions.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExamConditions_Create, L("CreatePermission"));
            examConditions.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExamConditions_Edit, L("EditPermission"));
            examConditions.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExamConditions_Delete, L("Delete"));
            examConditions.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExamConditions_Search, L("ViewPermission"));
            #endregion
            #region "ScoringRules"
            var ScoringRules = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleScoringRules, L("MstSleScoringRulesPermission"));
            ScoringRules.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleScoringRules_Create, L("CreatePermission"));
            ScoringRules.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleScoringRules_Edit, L("EditPermission"));
            ScoringRules.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleScoringRules_Delete, L("Delete"));
            ScoringRules.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleScoringRules_Search, L("ViewPermission"));
            #endregion

            #region "Regulation"
            var Regulation = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleRegulation, L("MstSleRegulationPermission"));
            Regulation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleRegulation_Create, L("CreatePermission"));
            Regulation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleRegulation_Edit, L("EditPermission"));
            Regulation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleRegulation_Delete, L("Delete"));
            Regulation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleRegulation_Search, L("ViewPermission"));
            #endregion

            #region "ServiceLocation"
            var ServiceLocation = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleServiceLocation, L("MstSleServiceLocationPermission"));
            ServiceLocation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleServiceLocation_Create, L("CreatePermission"));
            ServiceLocation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleServiceLocation_Edit, L("EditPermission"));
            ServiceLocation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleServiceLocation_Delete, L("Delete"));
            ServiceLocation.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleServiceLocation_Search, L("ViewPermission"));
            #endregion

            #region "CertType"
            var certType = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertType, L("MstSleCertTypePermission"));
            certType.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertType_Create, L("CreatePermission"));
            certType.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertType_Edit, L("EditPermission"));
            certType.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertType_Delete, L("Delete"));
            certType.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCertType_Search, L("ViewPermission"));
            #endregion

            #region "Cert"
            var cert = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCert, L("MstSleCertPermission"));
            cert.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCert_Create, L("CreatePermission"));
            cert.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCert_Edit, L("EditPermission"));
            cert.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCert_Delete, L("Delete"));
            cert.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleCert_Search, L("ViewPermission"));
            #endregion

            #region "MstSleEmployeeCourse"
            var employeeCourse = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeCourse, L("MstSleEmployeeCoursePermission"));
            employeeCourse.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeCourses_Create, L("CreatePermission"));
            employeeCourse.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeCourse_Edit, L("EditPermission"));
            employeeCourse.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeCourse_Delete, L("Delete"));
            employeeCourse.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeCourse_Search, L("ViewPermission"));
            #endregion
            #region "Course"
            var course = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_Course, L("EmployeeCoursePermission"));
            course.CreateChildPermission(AppPermissions.Pages_Master_Sales_Course_Create, L("CreatePermission"));
            course.CreateChildPermission(AppPermissions.Pages_Master_Sales_Course_Edit, L("EditPermission"));
            course.CreateChildPermission(AppPermissions.Pages_Master_Sales_Course_Delete, L("Delete"));
            course.CreateChildPermission(AppPermissions.Pages_Master_Sales_Course_Search, L("ViewPermission"));
            #endregion
            #region "Teacher"
            var teacher = category.CreateChildPermission(AppPermissions.Pages_Master_Sales_Teacher, L("EmployeeTeacherPermission"));
            teacher.CreateChildPermission(AppPermissions.Pages_Master_Sales_Teacher_Create, L("CreatePermission"));
            teacher.CreateChildPermission(AppPermissions.Pages_Master_Sales_Teacher_Edit, L("EditPermission"));
            teacher.CreateChildPermission(AppPermissions.Pages_Master_Teacher_Delete, L("Delete"));
            teacher.CreateChildPermission(AppPermissions.Pages_Master_Sales_Teacher_Search, L("ViewPermission"));
            #endregion

            #endregion
            #region "Information about Workers"
            var informationAboutWorkers = humanResource.CreateChildPermission(AppPermissions.Pages_Sales_Information_About_Workers, L("MstSleInformationAboutWorkers"));

            #region "EmployeeInfo"
            var employeeInfo = informationAboutWorkers.CreateChildPermission(AppPermissions.Pages_Master_Sales_Employee, L("SalesEmployeeInfoPermission"));
            employeeInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Employee_Search, L("ViewPermission"));
            employeeInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Employee_Create, L("CreatePermission"));
            employeeInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Employee_Edit, L("EditPermission"));
            employeeInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Employee_Delete, L("Delete"));
            #endregion
            #region TMV phê duyệt
            var employeeApprove = informationAboutWorkers.CreateChildPermission(AppPermissions.Pages_Sales_Employee_Approve, L("EmployeeApprove"));
            #region
            var employeeContractApprove = employeeApprove.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContractApprove, L("EmployeeContractApprove"));
            employeeContractApprove.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContractApprove_Search, L("EmployeeContractApprove"));
            #endregion

            #region
            var employeeLeaveTemporaryApprove = employeeApprove.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporaryApprove, L("EmployeeLeaveTemporaryApprove"));
            employeeLeaveTemporaryApprove.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporaryApprove_Search, L("EmployeeLeaveTemporaryApprove"));
            #endregion

            #region "EmployeeRotationPermission"
            var employeeRotationApprove = employeeApprove.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotationAprrove, L("MstSleEmployeeRotationApprove"));
            employeeRotationApprove.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotationApprove_View, L("ViewPermission"));
            #endregion
            var employeeLeaveJobApprove = employeeApprove.CreateChildPermission(AppPermissions.Page_Sales_Employee_Leave_Job_Approve, L("EmployeeLeaveJobApprove"));
            employeeLeaveJobApprove.CreateChildPermission(AppPermissions.Page_Sales_Employee_Leave_Job_Approve_Search, L("ViewPermission"));


            #endregion
            #region "EmployeeContract"
            var employeeContract = informationAboutWorkers.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContract, L("SalesEmployeeContractPermission"));
            employeeContract.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContract_Search, L("ViewPermission"));
            employeeContract.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContract_Create, L("CreatePermission"));
            employeeContract.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContract_Edit, L("EditPermission"));
            employeeContract.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeContract_Delete, L("Delete"));
            #endregion

            #region "EmployeeRotation"
            var employeeRotation = informationAboutWorkers.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotation, L("SalesEmployeeRotationPermission"));
            employeeRotation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotation_Search, L("ViewPermission"));
            employeeRotation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotation_Create, L("CreatePermission"));
            employeeRotation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotation_Edit, L("EditPermission"));
            employeeRotation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeRotation_Delete, L("Delete"));
            #endregion

            #region "EmployeeLeaveTemporary"
            var employeeLeaveTemporary = informationAboutWorkers.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporary, L("SalesEmployeeLeaveTemporaryPermission"));
            employeeLeaveTemporary.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporary_Search, L("ViewPermission"));
            employeeLeaveTemporary.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporary_Create, L("CreatePermission"));
            employeeLeaveTemporary.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporary_Edit, L("EditPermission"));
            employeeLeaveTemporary.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveTemporary_Delete, L("Delete"));
            #endregion

            #region "EmployeeLeaveJob"
            var employeeLeaveJob = informationAboutWorkers.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveJob, L("SalesEmployeeLeaveJobPermission"));
            employeeLeaveJob.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveJob_Search, L("ViewPermission"));
            employeeLeaveJob.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveJob_Create, L("CreatePermission"));
            employeeLeaveJob.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveJob_Edit, L("EditPermission"));
            employeeLeaveJob.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeLeaveJob_Delete, L("Delete"));
            #endregion
            #endregion

            #region Cập nhật thông tin cá nhân
            var updatePersonInfor = humanResource.CreateChildPermission(AppPermissions.Pages_Sales_Update_Person_Infor, L("MstSleUpdatePersonInfor"));

            #region "MstSleEmployeeJobTitle"
            var empJobtitle = updatePersonInfor.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeJobTitle, L("MstSleEmployeeJobTitlePermission"));
            empJobtitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeJobTitle_Search, L("ViewPermission"));
            empJobtitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeJobTitle_Create, L("CreatePermission"));
            empJobtitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeJobTitle_Edit, L("EditPermission"));
            empJobtitle.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeJobTitle_Delete, L("Delete"));
            #endregion

            #region "MstSleEmployeeEducation"
            var empEducation = updatePersonInfor.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeEducation, L("MstSleEmployeeEducationPermission"));
            empEducation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeEducation_Search, L("ViewPermission"));
            empEducation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeEducation_Create, L("CreatePermission"));
            empEducation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeEducation_Edit, L("EditPermission"));
            empEducation.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmployeeEducation_Delete, L("Delete"));
            #endregion

            #region "MstSleEmployeeCertificate"
            var employeeCertificate = updatePersonInfor.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleEmployeeCertificate, L("MstSleEmployeeCertificatePermission"));
            employeeCertificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleEmployeeCertificate_Search, L("ViewPermission"));
            employeeCertificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleEmployeeCertificate_Create, L("CreatePermission"));
            employeeCertificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleEmployeeCertificate_Edit, L("EditPermission"));
            employeeCertificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleEmployeeCertificate_Delete, L("Delete"));
            employeeCertificate.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleEmployeeCertificate_Import, L("Import"));
            #endregion
            #endregion

            #region "Employee Report"
            var employeeReport = humanResource.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Employee_Report, L("MstSleEmployeeReport"));
            #endregion

            #region "Employee Education"
            var employeeEducation = humanResource.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Employee_Education, L("MstSleEmployeeSaleEducation"));
            employeeEducation.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Employee_Education_Modify, L("Actions"));
            employeeEducation.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Employee_Education_Search, L("ViewPermission"));
            #endregion

            #region BackDateConfig
            var backDateConfig = humanResource.CreateChildPermission(AppPermissions.Pages_Sales_Back_Date_Config, L("MstSleBackDateConfig"));
            backDateConfig.CreateChildPermission(AppPermissions.Pages_Sales_Back_Date_Config_Create, L("CreatePermission"));
            backDateConfig.CreateChildPermission(AppPermissions.Pages_Sales_Back_Date_Config_Edit, L("EditPermission"));
            backDateConfig.CreateChildPermission(AppPermissions.Pages_Sales_Back_Date_Config_Delete, L("Delete"));
            #endregion
            #endregion

            //Thiết lập tham số
            #region "Setup Parameter"
            var setupParameter = pages.CreateChildPermission(AppPermissions.Pages_Setup_Parameter, L("SalesSetupParameterPermission"));

            #region "Target Setting"
            var targetSetting = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sale_TargetSetting, L("MstSleTargetSettingPermission"));
            targetSetting.CreateChildPermission(AppPermissions.Pages_Master_Sale_TargetSetting_Create, L("CreatePermission"));
            targetSetting.CreateChildPermission(AppPermissions.Pages_Master_Sale_TargetSetting_Edit, L("EditPermission"));
            targetSetting.CreateChildPermission(AppPermissions.Pages_Master_Sale_TargetSetting_Search, L("ViewPermission"));
            targetSetting.CreateChildPermission(AppPermissions.Pages_Master_Sale_TargetSetting_Delete, L("Delete"));
            #endregion

            #region "Config"
            var config = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Config, L("MstSleConfigPermission"));
            config.CreateChildPermission(AppPermissions.Pages_Master_Sales_Config_Create, L("CreatePermission"));
            config.CreateChildPermission(AppPermissions.Pages_Master_Sales_Config_Edit, L("EditPermission"));
            config.CreateChildPermission(AppPermissions.Pages_Master_Sales_Config_Search, L("ViewPermission"));
            #endregion

            #region "Mobile Version"
            var mobileVersion = setupParameter.CreateChildPermission(AppPermissions.Pages_Administration_Mobile_Version, L("AbpMobileVerisonPermission"));
            mobileVersion.CreateChildPermission(AppPermissions.Pages_Administration_Mobile_Version_Create, L("CreatePermission"));
            mobileVersion.CreateChildPermission(AppPermissions.Pages_Administration_Mobile_Version_Search, L("ViewPermission"));
            #endregion

            #region "Lookup"
            var lookup = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Lookup, L("MstSleLookupPermission"));
            lookup.CreateChildPermission(AppPermissions.Pages_Master_Sales_Lookup_Create, L("CreatePermission"));
            lookup.CreateChildPermission(AppPermissions.Pages_Master_Sales_Lookup_Edit, L("EditPermission"));
            lookup.CreateChildPermission(AppPermissions.Pages_Master_Sales_Lookup_Delete, L("Delete"));
            lookup.CreateChildPermission(AppPermissions.Pages_Master_Sales_Lookup_Search, L("ViewPermission"));
            #endregion

            #region "ConfigNumericalNo"
            var configNumericalNo = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Config_Numberical_No, L("MstConfigNumericalNoPermission"));
            configNumericalNo.CreateChildPermission(AppPermissions.Pages_Master_Config_Numberical_No_Create, L("CreatePermission"));
            configNumericalNo.CreateChildPermission(AppPermissions.Pages_Master_Config_Numberical_No_Edit, L("EditPermission"));
            configNumericalNo.CreateChildPermission(AppPermissions.Pages_Master_Config_Numberical_No_Delete, L("Delete"));
            configNumericalNo.CreateChildPermission(AppPermissions.Pages_Master_Config_Numberical_No_Search, L("ViewPermission"));
            #endregion

            #region "Report Config"
            var mstSleReport = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report, L("MstSleReportPermission"));
            mstSleReport.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Search, L("MstSleReportSearch"));
            mstSleReport.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Create, L("MstSleReportCreate"));
            mstSleReport.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Edit, L("MstSleReportEdit"));
            mstSleReport.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Delete, L("MstSleReportDelete"));
            #endregion

            #region "Report Category"
            var mstSleReportCategory = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReportCategory, L("MstSleReportCategoryPermission"));
            mstSleReportCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReportCategory_Search, L("Search"));
            mstSleReportCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReportCategory_Create, L("CreatePermission"));
            mstSleReportCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReportCategory_Edit, L("Edit"));
            mstSleReportCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReportCategory_Delete, L("Delete"));
            #endregion

            #region "Master Report Definition"
            var mstSleReportDefinition = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Definition, L("MstSleReportDefinitionPermission"));
            mstSleReportDefinition.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Definition_Search, L("ViewPermission"));
            mstSleReportDefinition.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Definition_Create, L("CreatePermission"));
            mstSleReportDefinition.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Definition_Edit, L("EditPermission"));
            mstSleReportDefinition.CreateChildPermission(AppPermissions.Pages_Master_Sales_Report_Definition_Delete, L("Delete"));
            #endregion

            #region "Master IP Management"
            var mstSleIPManagement = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_IP_Managemnet, L("MstSleIPManagementPermission"));
            mstSleIPManagement.CreateChildPermission(AppPermissions.Pages_Master_Sales_IP_Managemnet_Search, L("ViewPermission"));
            mstSleIPManagement.CreateChildPermission(AppPermissions.Pages_Master_Sales_IP_Managemnet_Create, L("CreatePermission"));
            mstSleIPManagement.CreateChildPermission(AppPermissions.Pages_Master_Sales_IP_Managemnet_Edit, L("EditPermission"));
            mstSleIPManagement.CreateChildPermission(AppPermissions.Pages_Master_Sales_IP_Managemnet_Delete, L("Delete"));
            #endregion

            #region "Cấu hình mẫu báo cáo đề xuất bán hàng"
            var proposalReportConfig = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Proposal_Report, L("MstSleProposalReport"));
            proposalReportConfig.CreateChildPermission(AppPermissions.Pages_Master_Sales_Proposal_Report_Search, L("ViewPermission"));
            //ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Create, L("CreatePermission"));
            //ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Edit, L("EditPermission"));
            //ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Delete, L("Delete"));
            #endregion 
            #region "Tỉ lệ chi phí"
            var ratioCost = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost, L("MstSleRatioCost"));
            ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Search, L("ViewPermission"));
            //ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Create, L("CreatePermission"));
            //ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Edit, L("EditPermission"));
            //ratioCost.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Delete, L("Delete"));
            #endregion

            #region "Chi phí bảo dưỡng"
            var maintenancePrice = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_Maintenance_Price, L("MstSleMaintenancePrice"));
            maintenancePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_Maintenance_Price_Search, L("ViewPermission"));
            //maintenancePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Create, L("CreatePermission"));
            //maintenancePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Edit, L("EditPermission"));
            //maintenancePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_Ratio_Cost_Delete, L("Delete"));
            #endregion

            #region "MstSleServiceBookingEmail"
            var mstSleServiceBookingEmail = setupParameter.CreateChildPermission(AppPermissions.Pages_Master_Sales_ServiceBookingEmail, L("MstSleServiceBookingEmail"));
            mstSleServiceBookingEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ServiceBookingEmail_Search, L("ViewPermission"));
            mstSleServiceBookingEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ServiceBookingEmail_Create, L("CreatePermission"));
            mstSleServiceBookingEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ServiceBookingEmail_Edit, L("EditPermission"));
            mstSleServiceBookingEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ServiceBookingEmail_Delete, L("Delete"));
            #endregion

            #endregion

            //Danh mục dùng chung
            #region "Master"
            var master = pages.CreateChildPermission(AppPermissions.Pages_Master, L("MasterPermission"));

            #region "MasterCommon"
            var masterCommon = master.CreateChildPermission(AppPermissions.Pages_Master_Common, L("MasterCommonPermission"));

            #region "Master Dealer"
            var mstGenDealers = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Common_MstGenDealers, L("MstGenDealersPermission"));
            mstGenDealers.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenDealers_Search, L("ViewPermission"));
            mstGenDealers.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenDealers_Create, L("CreatePermission"));
            mstGenDealers.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenDealers_Edit, L("EditPermission"));
            mstGenDealers.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenDealers_Delete, L("Delete"));
            #endregion

            #region "Master Dealer Group"
            var mstSleDealerGroups = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleDealerGroups, L("MstSleDealerGroupsPermission"));
            mstSleDealerGroups.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleDealerGroups_Search, L("ViewPermission"));
            mstSleDealerGroups.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleDealerGroups_Create, L("CreatePermission"));
            mstSleDealerGroups.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleDealerGroups_Edit, L("EditPermission"));
            mstSleDealerGroups.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleDealerGroups_Delete, L("Delete"));
            #endregion

            #region "Master Province"
            var mstGenProvinces = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenProvinces, L("MstGenProvincesPermission"));
            mstGenProvinces.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenProvinces_Search, L("ViewPermission"));
            mstGenProvinces.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenProvinces_Create, L("CreatePermission"));
            mstGenProvinces.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenProvinces_Edit, L("EditPermission"));
            mstGenProvinces.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstGenProvinces_Delete, L("Delete"));
            #endregion

            #region "Master District"
            var mstSleDistrict = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_District, L("MstSleDistrictPermission"));
            mstSleDistrict.CreateChildPermission(AppPermissions.Pages_Master_Sales_District_Search, L("ViewPermission"));
            mstSleDistrict.CreateChildPermission(AppPermissions.Pages_Master_Sales_District_Create, L("CreatePermission"));
            mstSleDistrict.CreateChildPermission(AppPermissions.Pages_Master_Sales_District_Edit, L("EditPermission"));
            mstSleDistrict.CreateChildPermission(AppPermissions.Pages_Master_Sales_District_Delete, L("Delete"));
            #endregion

            #region "Source"
            var source = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Source, L("MstSleSourcePermission"));
            source.CreateChildPermission(AppPermissions.Pages_Master_Sales_Source_Create, L("CreatePermission"));
            source.CreateChildPermission(AppPermissions.Pages_Master_Sales_Source_Edit, L("EditPermission"));
            source.CreateChildPermission(AppPermissions.Pages_Master_Sales_Source_Delete, L("Delete"));
            source.CreateChildPermission(AppPermissions.Pages_Master_Sales_Source_Search, L("ViewPermission"));
            #endregion

            #region "Hotness"
            var hotness = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hotness, L("MstSleHotnessPermission"));
            hotness.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hotness_Search, L("ViewPermission"));
            hotness.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hotness_Create, L("CreatePermission"));
            hotness.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hotness_Edit, L("EditPermission"));
            hotness.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hotness_Delete, L("Delete"));
            #endregion

            #region "Excepted Delivery Timing"
            var exceptedDeliveryTiming = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExceptedDeliveryTiming, L("MstSleExpectedDelTimingBannerPermission"));
            exceptedDeliveryTiming.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExceptedDeliveryTiming_Search, L("ViewPermission"));
            exceptedDeliveryTiming.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExceptedDeliveryTiming_Create, L("CreatePermission"));
            exceptedDeliveryTiming.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExceptedDeliveryTiming_Edit, L("EditPermission"));
            exceptedDeliveryTiming.CreateChildPermission(AppPermissions.Pages_Master_Sales_ExceptedDeliveryTiming_Delete, L("Delete"));
            #endregion

            #region "Payment Type"
            var paymentType = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentType, L("MstSlePaymentTypePermission"));
            paymentType.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentType_Search, L("ViewPermission"));
            paymentType.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentType_Create, L("CreatePermission"));
            paymentType.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentType_Edit, L("EditPermission"));
            paymentType.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentType_Delete, L("Delete"));
            #endregion

            #region "Role"
            var Role = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Role, L("MstSleRolePermission"));
            Role.CreateChildPermission(AppPermissions.Pages_Master_Sales_Role_Create, L("CreatePermission"));
            Role.CreateChildPermission(AppPermissions.Pages_Master_Sales_Role_Edit, L("EditPermission"));
            Role.CreateChildPermission(AppPermissions.Pages_Master_Sales_Role_Delete, L("Delete"));
            Role.CreateChildPermission(AppPermissions.Pages_Master_Sales_Role_Search, L("ViewPermission"));
            #endregion

            #region "Gender"
            var gender = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Gender, L("MstSleGenderPermission"));
            gender.CreateChildPermission(AppPermissions.Pages_Master_Sales_Gender_Create, L("CreatePermission"));
            gender.CreateChildPermission(AppPermissions.Pages_Master_Sales_Gender_Edit, L("EditPermission"));
            gender.CreateChildPermission(AppPermissions.Pages_Master_Sales_Gender_Delete, L("Delete"));
            gender.CreateChildPermission(AppPermissions.Pages_Master_Sales_Gender_Search, L("ViewPermission"));
            #endregion

            #region "Marital Status"
            var maritalStatus = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaritalStatus, L("MstSleMaritalStatusPermission"));
            maritalStatus.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaritalStatus_Create, L("CreatePermission"));
            maritalStatus.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaritalStatus_Edit, L("EditPermission"));
            maritalStatus.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaritalStatus_Delete, L("Delete"));
            maritalStatus.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaritalStatus_Search, L("ViewPermission"));
            #endregion

            #region "Occupation"
            var occupation = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Occupation, L("MstSleOccupationPermission"));
            occupation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Occupation_Search, L("ViewPermission"));
            occupation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Occupation_Create, L("CreatePermission"));
            occupation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Occupation_Edit, L("EditPermission"));
            occupation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Occupation_Delete, L("Delete"));
            #endregion

            #region "Hobby"
            var hobby = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hobby, L("MstSleHobbyPermission"));
            hobby.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hobby_Search, L("ViewPermission"));
            hobby.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hobby_Create, L("CreatePermission"));
            hobby.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hobby_Edit, L("EditPermission"));
            hobby.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hobby_Delete, L("Delete"));
            #endregion

            #region "Soucre Of Info"
            var sourceOfInfo = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_SourceOfInfo, L("MstSleSourceOfInfoPermission"));
            sourceOfInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_SourceOfInfo_Search, L("ViewPermission"));
            sourceOfInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_SourceOfInfo_Create, L("CreatePermission"));
            sourceOfInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_SourceOfInfo_Edit, L("EditPermission"));
            sourceOfInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_SourceOfInfo_Delete, L("Delete"));
            #endregion

            #region "Social Channel"
            var socialChannel = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_SocialChannel, L("MstSleSocialChannelPermission"));
            socialChannel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SocialChannel_Search, L("ViewPermission"));
            socialChannel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SocialChannel_Create, L("CreatePermission"));
            socialChannel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SocialChannel_Edit, L("EditPermission"));
            socialChannel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SocialChannel_Delete, L("Delete"));
            #endregion

            #region "Customer Social Channel"
            var CustomerSocialChannel = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_CustomerSocialChannel, L("MstSleCustomerSocialChannelPermission"));
            CustomerSocialChannel.CreateChildPermission(AppPermissions.Pages_Master_CustomerSocialChannel_Search, L("ViewPermission"));
            CustomerSocialChannel.CreateChildPermission(AppPermissions.Pages_Master_CustomerSocialChannel_Create, L("CreatePermission"));
            CustomerSocialChannel.CreateChildPermission(AppPermissions.Pages_Master_CustomerSocialChannel_Edit, L("EditPermission"));
            CustomerSocialChannel.CreateChildPermission(AppPermissions.Pages_Master_CustomerSocialChannel_Delete, L("Delete"));
            #endregion

            #region "Company"
            var Company = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Company, L("MstSleCompanyPermission"));
            Company.CreateChildPermission(AppPermissions.Pages_Master_Sales_Company_Create, L("CreatePermission"));
            Company.CreateChildPermission(AppPermissions.Pages_Master_Sales_Company_Edit, L("EditPermission"));
            Company.CreateChildPermission(AppPermissions.Pages_Master_Sales_Company_Delete, L("Delete"));
            Company.CreateChildPermission(AppPermissions.Pages_Master_Sales_Company_Search, L("ViewPermission"));
            #endregion

            #region "Purpose"
            var Purpose = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Purpose, L("MstSlePurposePermission"));
            Purpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_Purpose_Create, L("CreatePermission"));
            Purpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_Purpose_Edit, L("EditPermission"));
            Purpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_Purpose_Delete, L("Delete"));
            Purpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_Purpose_Search, L("ViewPermission"));
            #endregion

            #region "FAR"
            var FAR = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_FAR, L("MstSleFARPermission"));
            FAR.CreateChildPermission(AppPermissions.Pages_Master_Sales_FAR_Create, L("CreatePermission"));
            FAR.CreateChildPermission(AppPermissions.Pages_Master_Sales_FAR_Edit, L("EditPermission"));
            FAR.CreateChildPermission(AppPermissions.Pages_Master_Sales_FAR_Delete, L("Delete"));
            FAR.CreateChildPermission(AppPermissions.Pages_Master_Sales_FAR_Search, L("ViewPermission"));
            #endregion

            #region "Business Type"
            var BusinessType = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_BusinessType, L("MstSleBusinessTypePermission"));
            BusinessType.CreateChildPermission(AppPermissions.Pages_Master_Sales_BusinessType_Create, L("CreatePermission"));
            BusinessType.CreateChildPermission(AppPermissions.Pages_Master_Sales_BusinessType_Edit, L("EditPermission"));
            BusinessType.CreateChildPermission(AppPermissions.Pages_Master_Sales_BusinessType_Delete, L("Delete"));
            BusinessType.CreateChildPermission(AppPermissions.Pages_Master_Sales_BusinessType_Search, L("ViewPermission"));
            #endregion

            #region "Finance Customer Type"
            var financeCustomerType = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceCustomerType, L("MstSleFinanceCustomerTypePermission"));
            financeCustomerType.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceCustomerType_Create, L("CreatePermission"));
            financeCustomerType.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceCustomerType_Edit, L("EditPermission"));
            financeCustomerType.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceCustomerType_Delete, L("Delete"));
            financeCustomerType.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceCustomerType_Search, L("ViewPermission"));
            #endregion

            #region "PaymentTypeCommission"
            var PaymentTypeCommission = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentTypeCommission, L("MstSlePaymentTypeCommissionPermission"));
            PaymentTypeCommission.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentTypeCommission_Search, L("ViewPermission"));
            PaymentTypeCommission.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentTypeCommission_Create, L("CreatePermission"));
            PaymentTypeCommission.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentTypeCommission_Edit, L("EditPermission"));
            PaymentTypeCommission.CreateChildPermission(AppPermissions.Pages_Master_Sales_PaymentTypeCommission_Delete, L("Delete"));
            #endregion

            #region "Contract Roles"
            var contractRoles = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Contract_Roles, L("MstSleSaleContractRolePermission"));
            contractRoles.CreateChildPermission(AppPermissions.Pages_Master_Sales_Contract_Roles_Create, L("CreatePermission"));
            contractRoles.CreateChildPermission(AppPermissions.Pages_Master_Sales_Contract_Roles_Edit, L("EditPermission"));
            contractRoles.CreateChildPermission(AppPermissions.Pages_Master_Sales_Contract_Roles_Delete, L("Delete"));
            contractRoles.CreateChildPermission(AppPermissions.Pages_Master_Sales_Contract_Roles_Search, L("ViewPermission"));
            #endregion

            #region "ReasonOfChange"
            var ReasonOfChange = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfChange, L("MstSleReasonOfChangePermission"));
            ReasonOfChange.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfChange_Create, L("CreatePermission"));
            ReasonOfChange.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfChange_Edit, L("EditPermission"));
            ReasonOfChange.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfChange_Delete, L("Delete"));
            ReasonOfChange.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfChange_Search, L("ViewPermission"));
            #endregion

            #region "SalesStage"
            var SalesStage = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesStage, L("MstSleSalesStagePermission"));
            SalesStage.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesStage_Create, L("CreatePermission"));
            SalesStage.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesStage_Edit, L("EditPermission"));
            SalesStage.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesStage_Delete, L("Delete"));
            SalesStage.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesStage_Search, L("ViewPermission"));
            #endregion

            #region "Contact By"
            var contactBy = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ContactBy, L("MstSleContactByPermission"));
            contactBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_ContactBy_Create, L("CreatePermission"));
            contactBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_ContactBy_Edit, L("EditPermission"));
            contactBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_ContactBy_Delete, L("Delete"));
            contactBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_ContactBy_Search, L("ViewPermission"));
            #endregion

            #region "ReasonOfNA"
            var ReasonOfNA = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNA, L("MstSleReasonOfNAPermission"));
            ReasonOfNA.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNA_Create, L("CreatePermission"));
            ReasonOfNA.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNA_Edit, L("EditPermission"));
            ReasonOfNA.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNA_Delete, L("Delete"));
            ReasonOfNA.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNA_Search, L("ViewPermission"));
            #endregion

            #region "ReasonOfNC"
            var ReasonOfNC = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNC, L("MstSleReasonOfNCPermission"));
            ReasonOfNC.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNC_Create, L("CreatePermission"));
            ReasonOfNC.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNC_Edit, L("EditPermission"));
            ReasonOfNC.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNC_Delete, L("Delete"));
            ReasonOfNC.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfNC_Search, L("ViewPermission"));
            #endregion

            #region "Delivery Plan Lead Time"
            var deleveryPlanLeadTime = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Delivery_Plan_Lead_Time_Info, L("MstSleDeliveryPlanLeadTimeInfoPermission"));
            deleveryPlanLeadTime.CreateChildPermission(AppPermissions.Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Create, L("CreatePermission"));
            deleveryPlanLeadTime.CreateChildPermission(AppPermissions.Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Edit, L("EditPermission"));
            deleveryPlanLeadTime.CreateChildPermission(AppPermissions.Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Delete, L("Delete"));
            deleveryPlanLeadTime.CreateChildPermission(AppPermissions.Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Search, L("ViewPermission"));
            #endregion

            #region "DayOff"
            var dayOff = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Day_Off_Info, L("MstSleDayOffInfoPermission"));
            dayOff.CreateChildPermission(AppPermissions.Pages_Master_Sales_Day_Off_Info_Create, L("CreatePermission"));
            #endregion

            #region " Yard"
            var Yard = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Yard, L("MstSleYardPermission"));
            Yard.CreateChildPermission(AppPermissions.Pages_Master_Sales_Yard_Create, L("CreatePermission"));
            Yard.CreateChildPermission(AppPermissions.Pages_Master_Sales_Yard_Edit, L("EditPermission"));
            Yard.CreateChildPermission(AppPermissions.Pages_Master_Sales_Yard_Delete, L("Delete"));
            Yard.CreateChildPermission(AppPermissions.Pages_Master_Sales_Yard_Search, L("ViewPermission"));
            #endregion

            #region "PPM Package"
            var ppmPackage = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_PPM_Package, L("MstSlePpmPackagePermission"));
            ppmPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_PPM_Package_Create, L("CreatePermission"));
            ppmPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_PPM_Package_Edit, L("EditPermission"));
            ppmPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_PPM_Package_Delete, L("Delete"));
            ppmPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_PPM_Package_Search, L("ViewPermission"));
            #endregion

            #region "ReasonOfLost"
            var ReasonOfLost = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfLost, L("MstSleReasonOfLostPermission"));
            ReasonOfLost.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfLost_Create, L("CreatePermission"));
            ReasonOfLost.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfLost_Edit, L("EditPermission"));
            ReasonOfLost.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfLost_Delete, L("Delete"));
            ReasonOfLost.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfLost_Search, L("ViewPermission"));
            #endregion


            #region "ReasonOfFreeze"
            var reasonOfFreeze = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfFreeze, L("MstSleReasonOfFreeze"));
            reasonOfFreeze.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfFreeze_Create, L("CreatePermission"));
            reasonOfFreeze.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfFreeze_Edit, L("EditPermission"));
            reasonOfFreeze.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfFreeze_Delete, L("Delete"));
            reasonOfFreeze.CreateChildPermission(AppPermissions.Pages_Master_Sales_ReasonOfFreeze_Search, L("ViewPermission"));
            #endregion

            #region "Road tax Period"
            var period = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Period, L("MstsleRoadTaxPeriodPermission"));
            period.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Period_Search, L("ViewPermission"));
            period.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Period_Create, L("CreatePermission"));
            period.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Period_Edit, L("EditPermission"));
            period.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Period_Delete, L("Delete"));
            #endregion

            #region "Road tax Amount"
            var amount = masterCommon.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Amount, L("MstsleRoadTaxAmountPermission"));
            amount.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Amount_Search, L("ViewPermission"));
            amount.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Amount_Create, L("CreatePermission"));
            amount.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Amount_Edit, L("EditPermission"));
            amount.CreateChildPermission(AppPermissions.Pages_Master_Sales_Road_Tax_Amount_Delete, L("Delete"));
            #endregion


            #endregion

            #region "Vehicle Info"
            var masterVehicle = master.CreateChildPermission(AppPermissions.Pages_Master_Vehicle_Info, L("MasterVehiclePermission"));
            #region "Make Competitor"
            var makeCompetitor = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_Make_Competitor, L("MstSleMakeCompetitorPermission"));
            makeCompetitor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Make_Competitor_Create, L("CreatePermission"));
            makeCompetitor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Make_Competitor_Edit, L("EditPermission"));
            makeCompetitor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Make_Competitor_Delete, L("Delete"));
            makeCompetitor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Make_Competitor_Search, L("ViewPermission"));
            #endregion

            #region "Master Model"
            var mstSleModel = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_Model_Grade, L("MstSleModelPermission"));
            mstSleModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_Model_Grade_Search, L("ViewPermission"));
            mstSleModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_Model_Grade_Create, L("CreatePermission"));
            mstSleModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_Model_Grade_Edit, L("EditPermission"));
            mstSleModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_Model_Grade_Delete, L("Delete"));
            #endregion

            #region "ColorByGrade"
            var colorGrade = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_Color_By_Grade, L("MstSleColorByGradePermission"));
            colorGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_Color_By_Grade_Delete, L("Delete"));
            colorGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_Color_By_Grade_Create, L("CreatePermission"));
            colorGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_Color_By_Grade_Edit, L("EditPermission"));
            colorGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_Color_By_Grade_Search, L("ViewPermission"));
            #endregion

            #region "Color"
            var color = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleColors, L("MstSleColorPermission"));
            color.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleColors_Create, L("CreatePermission"));
            color.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleColors_Edit, L("EditPermission"));
            color.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleColors_Delete, L("Delete"));
            color.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleColors_Search, L("ViewPermission"));
            #endregion

            #region "Master Vehicle Price"
            var MstSleVehiclePrice = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice, L("MstSleVehiclePricePermission"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Search, L("ViewPermission"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Create, L("CreatePermission"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Edit, L("EditPermission"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Delete, L("Delete"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Submit, L("Submit"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Reject, L("Reject"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_Approve, L("Approve"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_CreateVehiclePriceChange, L("CreateVehiclePriceChangePermission"));
            MstSleVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehiclePrice_ImportVehiclePrice, L("ImportVehiclePricePermission"));

            #endregion

            #region "Master Fleet Vehicle Price"
            var MstSleFleetVehiclePrice = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetVehiclePrice, L("MstSleFleetVehiclePricePermission"));
            MstSleFleetVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetVehiclePrice_Search, L("ViewPermission"));
            MstSleFleetVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetVehiclePrice_Create, L("CreatePermission"));
            MstSleFleetVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetVehiclePrice_Edit, L("EditPermission"));
            MstSleFleetVehiclePrice.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetVehiclePrice_Delete, L("Delete"));
            #endregion

            #region "Master Fleet Range"
            var MstSleFleetRange = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetRange, L("MstSleFleetRangePermission"));
            MstSleFleetRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetRange_Search, L("ViewPermission"));
            MstSleFleetRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetRange_Create_Or_Edit, L("CreateOrEditPermission"));
            MstSleFleetRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_FleetRange_Delete, L("Delete"));
            #endregion

            #region "Master Vehicle Image"
            var MstSleVehicleImage = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleImage, L("MstSleVehicleImageBannerPermission"));
            MstSleVehicleImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleImage_Search, L("ViewPermission"));
            MstSleVehicleImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleImage_Create, L("CreatePermission"));
            MstSleVehicleImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleImage_Edit, L("EditPermission"));
            MstSleVehicleImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleImage_Delete, L("Delete"));
            #endregion

            #region "Master Engine Type"
            var MstSleEngineType = masterVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_EngineType, L("MstSleEngineTypePermission"));
            MstSleEngineType.CreateChildPermission(AppPermissions.Pages_Master_Sales_EngineType_Search, L("ViewPermission"));
            MstSleEngineType.CreateChildPermission(AppPermissions.Pages_Master_Sales_EngineType_Create, L("CreatePermission"));
            MstSleEngineType.CreateChildPermission(AppPermissions.Pages_Master_Sales_EngineType_Edit, L("EditPermission"));
            MstSleEngineType.CreateChildPermission(AppPermissions.Pages_Master_Sales_EngineType_Delete, L("Delete"));
            #endregion

            #region "Mst Sle Audio"
            var mstSleAudio = masterVehicle.CreateChildPermission(AppPermissions.Pages_Sales_MstSleAudio, L("MstSleAudioPermission"));
            mstSleAudio.CreateChildPermission(AppPermissions.Pages_Sales_MstSleAudio_Create, L("CreatePermission"));
            mstSleAudio.CreateChildPermission(AppPermissions.Pages_Sales_MstSleAudio_Edit, L("EditPermission"));
            mstSleAudio.CreateChildPermission(AppPermissions.Pages_Sales_MstSleAudio_Delete, L("Delete"));
            mstSleAudio.CreateChildPermission(AppPermissions.Pages_Sales_MstSleAudio_Search, L("ViewPermission"));
            #endregion
            #endregion

            #region "Accessories"
            var accessories = master.CreateChildPermission(AppPermissions.Pages_Master_Accessories, L("MasterAccessoriesPermission"));

            #region "Master Accessories Package"
            var mstSleAccessoriesPackage = accessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Package, L("MstSleAccessoriesPackagesPermission"));
            mstSleAccessoriesPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Package_Search, L("ViewPermission"));
            mstSleAccessoriesPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Package_Create, L("CreatePermission"));
            mstSleAccessoriesPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Package_Edit, L("EditPermission"));
            mstSleAccessoriesPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Package_Delete, L("Delete"));
            #endregion

            #region "Master Accessories"
            var mstSleAccessories = accessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories, L("MstSleAccessoriesPermission"));
            mstSleAccessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Search, L("ViewPermission"));
            mstSleAccessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Create, L("CreatePermission"));
            mstSleAccessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Edit, L("EditPermission"));
            mstSleAccessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessories_Delete, L("Delete"));
            #endregion

            #region "Unit"
            var unit = accessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Unit, L("MstSleUnitPermission"));
            unit.CreateChildPermission(AppPermissions.Pages_Master_Sales_Unit_Create, L("CreatePermission"));
            unit.CreateChildPermission(AppPermissions.Pages_Master_Sales_Unit_Edit, L("EditPermission"));
            unit.CreateChildPermission(AppPermissions.Pages_Master_Sales_Unit_Delete, L("Delete"));
            unit.CreateChildPermission(AppPermissions.Pages_Master_Sales_Unit_Search, L("ViewPermission"));
            #endregion

            #region "AccessoryTypes"
            var accessoryTypes = accessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryTypes, L("MstSleAccessoryTypePermission"));
            accessoryTypes.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryTypes_Search, L("ViewPermission"));
            accessoryTypes.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryTypes_Create, L("CreatePermission"));
            accessoryTypes.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryTypes_Edit, L("EditPermission"));
            accessoryTypes.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryTypes_Delete, L("Delete"));
            #endregion

            #region "Accessories Manufactor"
            var accessoriesManufactor = accessories.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessory_Manufactor, L("MstSleAccessoriesManufactorPermission"));
            accessoriesManufactor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessory_Manufactor_Search, L("ViewPermission"));
            accessoriesManufactor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessory_Manufactor_Create, L("CreatePermission"));
            accessoriesManufactor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessory_Manufactor_Edit, L("EditPermission"));
            accessoriesManufactor.CreateChildPermission(AppPermissions.Pages_Master_Sales_Accessory_Manufactor_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Test Driver"
            var testDriver = master.CreateChildPermission(AppPermissions.Pages_Master_TestDriver, L("MasterTestDriverPermission"));

            #region "Test Drive Place"
            var testDrivePlace = testDriver.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleTestDrivePlace, L("MstSleTestDrivePlacePermission"));
            testDrivePlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleTestDrivePlace_Search, L("ViewPermission"));
            testDrivePlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleTestDrivePlace_Create, L("CreatePermission"));
            testDrivePlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleTestDrivePlace_Edit, L("EditPermission"));
            testDrivePlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleTestDrivePlace_Delete, L("Delete"));
            #endregion

            #region "Test Drive Stall"
            var testDriveStall = testDriver.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveStall, L("MstSleTestDriveStallPermission"));
            testDriveStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveStall_Search, L("ViewPermission"));
            testDriveStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveStall_Create, L("CreatePermission"));
            testDriveStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveStall_Edit, L("EditPermission"));
            testDriveStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveStall_Delete, L("Delete"));
            #endregion

            #region "Supporter"
            var supporter = testDriver.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleSupporter, L("MstSleSupporterPermission"));
            supporter.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleSupporter_Search, L("ViewPermission"));
            supporter.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleSupporter_Create, L("CreatePermission"));
            supporter.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleSupporter_Edit, L("EditPermission"));
            supporter.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleSupporter_Delete, L("Delete"));
            #endregion

            #region "Test Drive Route"
            var testDriveRoute = testDriver.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveRoute, L("MstSleTestDriveRoutePermission"));
            testDriveRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveRoute_Search, L("ViewPermission"));
            testDriveRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveRoute_Create, L("CreatePermission"));
            testDriveRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveRoute_Edit, L("EditPermission"));
            testDriveRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveRoute_Delete, L("Delete"));
            #endregion

            #region "Test Drive Vehicle"
            var testDriveVehicle = testDriver.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveVehicle, L("MstSleTestDriveVehiclePermission"));
            testDriveVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveVehicle_Search, L("ViewPermission"));
            testDriveVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveVehicle_Create, L("CreatePermission"));
            testDriveVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveVehicle_Edit, L("EditPermission"));
            testDriveVehicle.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveVehicle_Delete, L("Delete"));
            #endregion
            #endregion

            #region "Insurance"
            var insurance = master.CreateChildPermission(AppPermissions.Pages_Master_Insurance, L("MasterInsurancePermission"));

            #region "InsuranceCompany"
            var insuranceCompany = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceCompany, L("MstSleInsuranceCompanyPermission"));
            insuranceCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceCompany_Search, L("ViewPermission"));
            insuranceCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceCompany_Create, L("CreatePermission"));
            insuranceCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceCompany_Edit, L("EditPermission"));
            insuranceCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceCompany_Delete, L("Delete"));
            #endregion

            #region "Insurance Type"
            var insuranceType = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceType, L("MstSleInsuranceTypePermission"));
            insuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceType_Create, L("CreatePermission"));
            insuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceType_Edit, L("EditPermission"));
            insuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceType_Delete, L("Delete"));
            insuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceType_Search, L("ViewPermission"));
            #endregion

            #region "InsurancePurpose"
            var InsurancePurpose = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePurpose, L("MstSleInsurancePurposePermission"));
            InsurancePurpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePurpose_Create, L("CreatePermission"));
            InsurancePurpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePurpose_Edit, L("EditPermission"));
            InsurancePurpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePurpose_Delete, L("Delete"));
            InsurancePurpose.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePurpose_Search, L("ViewPermission"));
            #endregion

            #region "Master Insurance TI Product"
            var mstSleInsuranceTIProduct = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceTIProduct, L("MstSleInsuranceTIProductPermission"));
            mstSleInsuranceTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceTIProduct_Search, L("ViewPermission"));
            mstSleInsuranceTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceTIProduct_Create, L("CreatePermission"));
            mstSleInsuranceTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceTIProduct_Edit, L("EditPermission"));
            mstSleInsuranceTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceTIProduct_Delete, L("Delete"));
            #endregion

            #region "Master Insurance Non TI Product"
            var mstSleInsuranceNonTIProduct = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceNonTIProduct, L("MstSleInsuranceNonTIProduct"));
            mstSleInsuranceNonTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceNonTIProduct_Search, L("SearchMstSleInsuranceNonTIProduct"));
            mstSleInsuranceNonTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceNonTIProduct_Create, L("CreateNewMstSleInsuranceNonTiProduct"));
            mstSleInsuranceNonTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceNonTIProduct_Edit, L("EditMstSleInsuranceNonTIProduct"));
            mstSleInsuranceNonTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceNonTIProduct_Delete, L("DeleteMstSleInsuranceNonTIProduct"));
            mstSleInsuranceNonTIProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceNonTIProduct_GetMstSleInsuranceNonTIProductToExcel, L("GetMstSleInsuranceNonTIProductToExcel"));
            #endregion

            #region " Insurance Compulsory"
            var insuranceCompulsory = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceCompulsory, L("MstSleInsuranceCompulsoryPermission"));
            insuranceCompulsory.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceCompulsory_Create, L("CreatePermission"));
            insuranceCompulsory.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceCompulsory_Edit, L("EditPermission"));
            insuranceCompulsory.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceCompulsory_Delete, L("Delete"));
            insuranceCompulsory.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceCompulsory_Search, L("ViewPermission"));
            #endregion

            #region " Insurance Physical Damage Fee"
            var insurancePhysical = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePhysical, L("MstSleInsurancePhysicalPermission"));
            insurancePhysical.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePhysical_Create, L("CreatePermission"));
            insurancePhysical.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePhysical_Edit, L("EditPermission"));
            insurancePhysical.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePhysical_Delete, L("Delete"));
            insurancePhysical.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePhysical_Search, L("ViewPermission"));
            #endregion

            #region "Insurance Voluntarily"
            var insuranceVoluntarily = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceVoluntarily, L("MstSleInsuranceVoluntarilyPermission"));
            insuranceVoluntarily.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceVoluntarily_Create, L("CreatePermission"));
            insuranceVoluntarily.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceVoluntarily_Edit, L("EditPermission"));
            insuranceVoluntarily.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceVoluntarily_Delete, L("Delete"));
            insuranceVoluntarily.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceVoluntarily_Search, L("ViewPermission"));
            #endregion

            #region "Insurance Term"
            var insuranceTerm = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceTerm, L("MstSleInsuranceTermPermission"));
            insuranceTerm.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceTerm_Create, L("CreatePermission"));
            insuranceTerm.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceTerm_Edit, L("EditPermission"));
            insuranceTerm.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceTerm_Delete, L("Delete"));
            insuranceTerm.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceTerm_Search, L("ViewPermission"));
            #endregion

            #region "Insurance Level"
            var insuranceLevel = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceLevel, L("SalesContractInsuranceLevelPermission"));
            insuranceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceLevel_Create, L("CreatePermission"));
            insuranceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceLevel_Edit, L("EditPermission"));
            insuranceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceLevel_Delete, L("Delete"));
            insuranceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceLevel_Search, L("ViewPermission"));
            #endregion

            //#region "Master Insurance People In Car"
            //var mstSleInsurancePeopleInCar = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePeopleInCar, L("MstSleInsurancePeopleInCar"));
            //mstSleInsurancePeopleInCar.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePeopleInCar_Search, L("MstSleInsurancePeopleInCarSearch"));
            //mstSleInsurancePeopleInCar.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePeopleInCar_Create, L("MstSleInsurancePeopleInCarCreate"));
            //mstSleInsurancePeopleInCar.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePeopleInCar_Edit, L("MstSleInsurancePeopleInCarEdit"));
            //mstSleInsurancePeopleInCar.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsurancePeopleInCar_Delete, L("MstSleInsurancePeopleInCarDelete"));
            //#endregion

            #region "InsuranceDriverPassengerFee"
            var insuranceDriverPassengerFee = insurance.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceDriverPassengerFee, L("MstSleInsuranceDriverPassengerFeePermission"));
            insuranceDriverPassengerFee.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceDriverPassengerFee_Search, L("ViewPermission"));
            insuranceDriverPassengerFee.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleInsuranceDriverPassengerFee_Edit, L("CreatePermission"));
            #endregion

            #endregion

            #region "Finance"
            var finance = master.CreateChildPermission(AppPermissions.Pages_Master_Finance, L("MasterFinancePermission"));

            #region "Bank"
            var bank = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_Bank, L("MstSleBankPermission"));
            bank.CreateChildPermission(AppPermissions.Pages_Master_Sales_Bank_Search, L("ViewPermission"));
            bank.CreateChildPermission(AppPermissions.Pages_Master_Sales_Bank_Create, L("CreatePermission"));
            bank.CreateChildPermission(AppPermissions.Pages_Master_Sales_Bank_Edit, L("EditPermission"));
            bank.CreateChildPermission(AppPermissions.Pages_Master_Sales_Bank_Delete, L("Delete"));
            #endregion

            #region " ActiveAccesoryFinance"
            var activeAccesoryFinance = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveAccesoryFinance, L("MstSleActiveAccesoryFinance"));
            activeAccesoryFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveAccesoryFinance_Search, L("ViewPermission"));
            activeAccesoryFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveAccesoryFinance_Create, L("CreatePermission"));
            activeAccesoryFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveAccesoryFinance_Edit, L("EditPermission"));
            activeAccesoryFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveAccesoryFinance_Delete, L("Delete"));
            #endregion
            #region " ActiveInsuranceFinance"
            var activeInsuranceFinance = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveInsuranceFinance, L("MstSleActiveInsuranceFinance"));
            activeInsuranceFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveInsuranceFinance_Search, L("ViewPermission"));
            activeInsuranceFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveInsuranceFinance_Create, L("CreatePermission"));
            activeInsuranceFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveInsuranceFinance_Edit, L("EditPermission"));
            activeInsuranceFinance.CreateChildPermission(AppPermissions.Pages_Master_Sales_ActiveInsuranceFinance_Delete, L("Delete"));
            #endregion

            #region "Finance TFS Package"
            var financeTFSPackage = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceTFSPackage, L("MstSleFinanceTFSPackagePermission"));
            financeTFSPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceTFSPackage_Search, L("ViewPermission"));
            financeTFSPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceTFSPackage_Create, L("CreatePermission"));
            financeTFSPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceTFSPackage_Edit, L("EditPermission"));
            financeTFSPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceTFSPackage_Delete, L("Delete"));
            #endregion

            #region "Finance Loan Value"
            var financeLoanValue = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceLoanValue, L("MstSleFinanceLoanValuePermission"));
            financeLoanValue.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceLoanValue_Search, L("ViewPermission"));
            financeLoanValue.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceLoanValue_Create, L("CreatePermission"));
            financeLoanValue.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceLoanValue_Edit, L("EditPermission"));
            financeLoanValue.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceLoanValue_Delete, L("Delete"));
            #endregion

            #region "Finance Instalment Plan"
            var financeInstalmentPlan = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceInstalmentPlan, L("MstSleFinanceInstalmentPlanPermission"));
            financeInstalmentPlan.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceInstalmentPlan_Search, L("ViewPermission"));
            financeInstalmentPlan.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceInstalmentPlan_Create, L("CreatePermission"));
            financeInstalmentPlan.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceInstalmentPlan_Edit, L("EditPermission"));
            financeInstalmentPlan.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceInstalmentPlan_Delete, L("Delete"));
            #endregion

            #region "Finance Classic Package"
            var financeClassicPackage = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceClassicPackage, L("MstSleFinanceClassicPackagePermission"));
            financeClassicPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceClassicPackage_Search, L("ViewPermission"));
            financeClassicPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceClassicPackage_Create, L("CreatePermission"));
            financeClassicPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceClassicPackage_Edit, L("EditPermission"));
            financeClassicPackage.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceClassicPackage_Delete, L("Delete"));
            #endregion

            #region "Finance Params By Model"
            var financeParamByModel = finance.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceParamByModel, L("MstSleFinanceParamByModelPermission"));
            financeParamByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceParamByModel_Search, L("ViewPermission"));
            financeParamByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceParamByModel_Create, L("CreatePermission"));
            financeParamByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceParamByModel_Edit, L("EditPermission"));
            financeParamByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_FinanceParamByModel_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Delivery"
            var delivery = master.CreateChildPermission(AppPermissions.Pages_Master_Delivery, L("MasterDeliveryPermission"));

            #region "Delivery Place"
            var deliveryPlace = delivery.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryPlace, L("MstSleDeliveryPlacePermission"));
            deliveryPlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryPlace_Create, L("CreatePermission"));
            deliveryPlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryPlace_Edit, L("EditPermission"));
            deliveryPlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryPlace_Delete, L("Delete"));
            deliveryPlace.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryPlace_Search, L("ViewPermission"));
            #endregion

            #region "Delivery Stall"
            var deliveryStall = delivery.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryStall, L("MstSleDeliveryStallPermission"));
            deliveryStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryStall_Create, L("CreatePermission"));
            deliveryStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryStall_Edit, L("EditPermission"));
            deliveryStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryStall_Delete, L("Delete"));
            deliveryStall.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryStall_Search, L("ViewPermission"));
            #endregion

            #region "Delivery Venue"
            var deliveryVenue = delivery.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryVenue, L("MstSleDeliveryVenuePermission"));
            deliveryVenue.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryVenue_Create, L("CreatePermission"));
            deliveryVenue.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryVenue_Edit, L("EditPermission"));
            deliveryVenue.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryVenue_Delete, L("Delete"));
            deliveryVenue.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryVenue_Search, L("ViewPermission"));
            #endregion

            #region "Delivery Date Change Reason"
            var deliveryDateChangeReason = delivery.CreateChildPermission(AppPermissions.Pages_Master_Sales_Delivery_Date_Change_Reason, L("MstSleDeliveryDateChangeReasonPermission"));
            deliveryDateChangeReason.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryDateChangeReason_Create, L("CreatePermission"));
            deliveryDateChangeReason.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryDateChangeReason_Edit, L("EditPermission"));
            deliveryDateChangeReason.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryDateChangeReason_Delete, L("Delete"));
            deliveryDateChangeReason.CreateChildPermission(AppPermissions.Pages_Master_Sales_DeliveryDateChangeReason_Search, L("ViewPermission"));
            #endregion

            #endregion

            #region "Product"
            var product = master.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Product, L("MasterProductPermission"));

            #region "Vehicle Product SaleTalk"
            var veicleProductSaleTalk = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductSaleTalk, L("MstSleVehicleProductSaleTalkBannerPermission"));
            veicleProductSaleTalk.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductSaleTalk_Search, L("ViewPermission"));
            veicleProductSaleTalk.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductSaleTalk_Create, L("CreatePermission"));
            veicleProductSaleTalk.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductSaleTalk_Edit, L("EditPermission"));
            veicleProductSaleTalk.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductSaleTalk_Delete, L("Delete"));
            #endregion



            #region "new Promotion" (tin tức - khuyến mãi)
            var newPromotion = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_NewsPromotion, L("MasterNewsPromotionPermission"));

            #region "Email Register"
            var emailRegister = newPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmailRegister, L("EmailRegister"));
            emailRegister.CreateChildPermission(AppPermissions.Pages_Master_Sales_EmailRegister_Search, L("ViewPermission"));
            #endregion

            #region "SubCategory"
            var subCategory = newPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_SubCategory, L("MstSleSubCategoryPermissionBanner"));
            subCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_SubCategory_Search, L("ViewPermission"));
            subCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_SubCategory_Create, L("CreatePermission"));
            subCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_SubCategory_Edit, L("EditPermission"));
            subCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_SubCategory_Delete, L("Delete"));
            #endregion

            #region "Product Promotion"
            var productPromotion = newPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductPromotion, L("MstSleVehicleProductPromotionPermission"));
            productPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductPromotion_Create, L("CreatePermission"));
            productPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductPromotion_Edit, L("EditPermission"));
            productPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductPromotion_Delete, L("Delete"));
            productPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductPromotion_Search, L("ViewPermission"));
            #endregion

            #region "Hashtag"
            var hashtag = newPromotion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hashtag, L("MstSleVehicleProductHashtagPermission"));
            hashtag.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hashtag_Search, L("ViewPermission"));
            hashtag.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hashtag_Create, L("CreatePermission"));
            hashtag.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hashtag_Edit, L("EditPermission"));
            hashtag.CreateChildPermission(AppPermissions.Pages_Master_Sales_Hashtag_Delete, L("Delete"));
            #endregion

            #endregion

            #region "VehicleSpecifications" (thông số kỹ thuật xe)
            var vehicleSpecifications = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleSpecifications, L("MasterVehicleSpecificationsPermission"));

            #region "MstSleVehicleProductNumberSeat"
            var mstSleVehicleProductNumberSeat = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNumberSeat, L("MstSleVehicleProductNumberSeatPermission"));
            mstSleVehicleProductNumberSeat.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNumberSeat_Search, L("ViewPermission"));
            mstSleVehicleProductNumberSeat.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNumberSeat_Create, L("CreatePermission"));
            mstSleVehicleProductNumberSeat.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNumberSeat_Edit, L("EditPermission"));
            mstSleVehicleProductNumberSeat.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNumberSeat_Delete, L("Delete"));
            #endregion

            #region "MstSleVehicleProductPriceRange"
            var mstSleVehicleProductPriceRange = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductPriceRange, L("MstSleVehicleProductPriceRangePermission"));
            mstSleVehicleProductPriceRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductPriceRange_Search, L("ViewPermission"));
            mstSleVehicleProductPriceRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductPriceRange_Create, L("CreatePermission"));
            mstSleVehicleProductPriceRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductPriceRange_Edit, L("EditPermission"));
            mstSleVehicleProductPriceRange.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductPriceRange_Delete, L("Delete"));
            #endregion

            #region "Product Car Body Style"
            var productCarBodyStyle = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarBodyStyle, L("MstSleProductCarBodyStylePermission"));
            productCarBodyStyle.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarBodyStyle_Search, L("ViewPermission"));
            productCarBodyStyle.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarBodyStyle_Create, L("CreatePermission"));
            productCarBodyStyle.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarBodyStyle_Edit, L("EditPermission"));
            productCarBodyStyle.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarBodyStyle_Delete, L("Delete"));
            #endregion

            #region "Product Car Origin"
            var productCarOrigin = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarOrigin, L("MstSleproductCarOriginPermission"));
            productCarOrigin.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarOrigin_Search, L("ViewPermission"));
            productCarOrigin.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarOrigin_Create, L("CreatePermission"));
            productCarOrigin.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarOrigin_Edit, L("EditPermission"));
            productCarOrigin.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarOrigin_Delete, L("Delete"));
            #endregion

            #region "Product Car Fuel"
            var productCarFuel = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarFuel, L("MstSleproductCarFuelPermission"));
            productCarFuel.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarFuel_Search, L("ViewPermission"));
            productCarFuel.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarFuel_Create, L("CreatePermission"));
            productCarFuel.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarFuel_Edit, L("EditPermission"));
            productCarFuel.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarFuel_Delete, L("Delete"));
            #endregion

            #region "Product Car Engine"
            var productCarEngine = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarEngine, L("MstSleProductCarEnginePermission"));
            productCarEngine.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarEngine_Search, L("ViewPermission"));
            productCarEngine.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarEngine_Create, L("CreatePermission"));
            productCarEngine.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarEngine_Edit, L("EditPermission"));
            productCarEngine.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductCarEngine_Delete, L("Delete"));
            #endregion

            #region "VehicleProductSortBy"
            var SortBy = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sort_By, L("MstSleVehicleProductSortByPermission"));
            SortBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sort_By_Search, L("ViewPermission"));
            SortBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sort_By_Create, L("CreatePermission"));
            SortBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sort_By_Edit, L("EditPermission"));
            SortBy.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sort_By_Delete, L("Delete"));
            #endregion

            #region "Product Tecnical Spec"
            var productTecnicalSpec = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpec, L("MstSleVehicleProductTecnicalSpecPermission"));
            productTecnicalSpec.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpec_Create, L("CreatePermission"));
            productTecnicalSpec.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpec_Edit, L("EditPermission"));
            productTecnicalSpec.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpec_Delete, L("Delete"));
            productTecnicalSpec.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpec_Search, L("ViewPermission"));
            #endregion

            #region "Product Tecnical Spec Big Group"
            var productTecnicalSpecBigGroup = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecBigGroup, L("MstSleVehicleProductTecnicalSpecBigGroupPermission"));
            productTecnicalSpecBigGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecBigGroup_Create, L("CreatePermission"));
            productTecnicalSpecBigGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecBigGroup_Edit, L("EditPermission"));
            productTecnicalSpecBigGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecBigGroup_Delete, L("Delete"));
            productTecnicalSpecBigGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecBigGroup_Search, L("ViewPermission"));
            #endregion

            #region "Product Tecnical Spec  Group"
            var productTecnicalSpecGroup = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecGroup, L("MstSleVehicleProductTecnicalSpecGroupPermission"));
            productTecnicalSpecGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecGroup_Create, L("CreatePermission"));
            productTecnicalSpecGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecGroup_Edit, L("EditPermission"));
            productTecnicalSpecGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecGroup_Delete, L("Delete"));
            productTecnicalSpecGroup.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecGroup_Search, L("ViewPermission"));
            #endregion

            #region "Product Tecnical Spec  Detail"
            var productTecnicalSpecDetail = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecDetail, L("MstSleVehicleProductTecnicalSpecDetailPermission"));
            productTecnicalSpecDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecDetail_Create, L("CreatePermission"));
            productTecnicalSpecDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecDetail_Edit, L("EditPermission"));
            productTecnicalSpecDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecDetail_Delete, L("Delete"));
            productTecnicalSpecDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecDetail_Search, L("ViewPermission"));
            #endregion

            #region "Product Tecnical Spec  Color"
            var productTecnicalSpecColor = vehicleSpecifications.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecColor, L("MstSleVehicleProductTecnicalSpecColorPermission"));
            productTecnicalSpecColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecColor_Create, L("CreatePermission"));
            productTecnicalSpecColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecColor_Edit, L("EditPermission"));
            productTecnicalSpecColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecColor_Delete, L("Delete"));
            productTecnicalSpecColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductTechnicalSpecColor_Search, L("ViewPermission"));
            #endregion

            #endregion

            #region "Image Car" (Ảnh Xe)
            var imagecar = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_ImageCar, L("MasterImageCarPermission"));

            #region "Vehicle Product Category"
            var veicleProductCategory = imagecar.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCategory, L("MstSleVehicleProductCategoryBannerPermission"));
            veicleProductCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCategory_Search, L("ViewPermission"));
            veicleProductCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCategory_Create, L("CreatePermission"));
            veicleProductCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCategory_Edit, L("EditPermission"));
            veicleProductCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCategory_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Image"
            var veicleProductImage = imagecar.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductImage, L("MstSleVehicleProductPermission"));
            veicleProductImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductImage_Search, L("ViewPermission"));
            veicleProductImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductImage_Create, L("CreatePermission"));
            veicleProductImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductImage_Edit, L("EditPermission"));
            veicleProductImage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductImage_Delete, L("Delete"));
            #endregion

            #region " TechnicalSpecInternalColor"
            var technicalSpecInternalColor = imagecar.CreateChildPermission(AppPermissions.Pages_Master_Sales_TechnicalSpecInternalColor, L("SalesContractIColor"));
            technicalSpecInternalColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_TechnicalSpecInternalColor_Search, L("ViewPermission"));
            technicalSpecInternalColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_TechnicalSpecInternalColor_Create, L("CreatePermission"));
            technicalSpecInternalColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_TechnicalSpecInternalColor_Edit, L("EditPermission"));
            technicalSpecInternalColor.CreateChildPermission(AppPermissions.Pages_Master_Sales_TechnicalSpecInternalColor_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Accessory Genuine"
            var genuine = imagecar.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryGenuine, L("AccessoryGenuine"));
            genuine.CreateChildPermission(AppPermissions.Pages_Master_Sales_AccessoryGenuine_Search, L("ViewPermission"));
            #endregion

            #endregion

            #region "Toyota Việt Nam"
            var toyotaVN = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_ToyotaVN, L("MasterToyotaVNPermission"));

            #region "Vehicle Product Introduce"
            var mstSleVehicleProductIntroduce = toyotaVN.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduce, L("MstSleVehicleProductIntroducePermission"));
            mstSleVehicleProductIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduce_Search, L("ViewPermission"));
            mstSleVehicleProductIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduce_Create, L("CreatePermission"));
            mstSleVehicleProductIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduce_Edit, L("EditPermission"));
            mstSleVehicleProductIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduce_Delete, L("Delete"));
            #endregion

            #region "MstSleVehicleProductIntroduceRouter"
            var mstSleVehicleProductIntroduceRouter = toyotaVN.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceRouter, L("MstSleVehicleProductIntroduceRouterPermissionBanner"));
            mstSleVehicleProductIntroduceRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceRouter_Search, L("ViewPermission"));
            mstSleVehicleProductIntroduceRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceRouter_Create, L("CreatePermission"));
            mstSleVehicleProductIntroduceRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceRouter_Edit, L("EditPermission"));
            mstSleVehicleProductIntroduceRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceRouter_Delete, L("Delete"));
            #endregion

            #region "MstSleVehicleProductIntroduceCategory"
            var mstSleVehicleProductIntroduceCategory = toyotaVN.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceCategory, L("MstSleVehicleProductIntroduceCategoryPermissionBanner"));
            mstSleVehicleProductIntroduceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceCategory_Search, L("ViewPermission"));
            mstSleVehicleProductIntroduceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceCategory_Create, L("CreatePermission"));
            mstSleVehicleProductIntroduceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceCategory_Edit, L("EditPermission"));
            mstSleVehicleProductIntroduceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductIntroduceCategory_Delete, L("Delete"));
            #endregion

            #endregion

            #region Bảo hiểm TOYOTA
            var insuranceToyota = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_InsuranceToyota, L("MasterInsuranceToyotaPermission"));

            #region "Vehicle Product TI Question"
            var mstSleVehicleProductTIQuestion = insuranceToyota.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTIQuestion, L("MstSleVehicleProductTIQuestionPermissionBanner"));
            mstSleVehicleProductTIQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTIQuestion_Search, L("ViewPermission"));
            mstSleVehicleProductTIQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTIQuestion_Create, L("CreatePermission"));
            mstSleVehicleProductTIQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTIQuestion_Edit, L("EditPermission"));
            mstSleVehicleProductTIQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTIQuestion_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Ti Vendor"
            var mstSleVehicleProductTiVendor = insuranceToyota.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTiVendor, L("MstSleVehicleProductTiVendorPermissionBanner"));
            mstSleVehicleProductTiVendor.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTiVendor_Search, L("ViewPermission"));
            mstSleVehicleProductTiVendor.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTiVendor_Create, L("CreatePermission"));
            mstSleVehicleProductTiVendor.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTiVendor_Edit, L("EditPermission"));
            mstSleVehicleProductTiVendor.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTiVendor_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Nội địa hóa và Xuất khẩu"
            var localizationAndExportFather = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAndExportFather, L("MasterLocalizationAndExportFatherPermission"));

            #region "MstSleLocalizationAndExport"
            var mstSleLocalizationAndExport = localizationAndExportFather.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAndExport, L("MstSleLocalizationAndExportPermission"));
            mstSleLocalizationAndExport.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAndExport_Search, L("ViewPermission"));
            mstSleLocalizationAndExport.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAndExport_Create, L("CreatePermission"));
            mstSleLocalizationAndExport.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAndExport_Edit, L("EditPermission"));
            mstSleLocalizationAndExport.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAndExport_Delete, L("Delete"));
            #endregion

            #region "MstSleLocalizationCommunicate"
            var mstSleLocalizationCommunicate = localizationAndExportFather.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCommunicate, L("MstSleLocalizationCommunicatePermissionBanner"));
            mstSleLocalizationCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCommunicate_Search, L("ViewPermission"));
            mstSleLocalizationCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCommunicate_Create, L("CreatePermission"));
            mstSleLocalizationCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCommunicate_Edit, L("EditPermission"));
            mstSleLocalizationCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCommunicate_Delete, L("Delete"));
            #endregion

            #region "MstSleLocalizationAccessoryDetail"
            var mstSleLocalizationAccessoryDetail = localizationAndExportFather.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAccessoryDetail, L("MstSleLocalizationAccessoryDetailPermissionBanner"));
            mstSleLocalizationAccessoryDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAccessoryDetail_Search, L("ViewPermission"));
            mstSleLocalizationAccessoryDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAccessoryDetail_Create, L("CreatePermission"));
            mstSleLocalizationAccessoryDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAccessoryDetail_Edit, L("EditPermission"));
            mstSleLocalizationAccessoryDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationAccessoryDetail_Delete, L("Delete"));
            #endregion

            #region "MstSleLocalizationDocumentCategory"
            var mstSleLocalizationDocumentCategory = localizationAndExportFather.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationDocumentCategory, L("MstSleLocalizationDocumentCategoryPermissionBanner"));
            mstSleLocalizationDocumentCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationDocumentCategory_Search, L("ViewPermission"));
            mstSleLocalizationDocumentCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationDocumentCategory_Create, L("CreatePermission"));
            mstSleLocalizationDocumentCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationDocumentCategory_Edit, L("EditPermission"));
            mstSleLocalizationDocumentCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationDocumentCategory_Delete, L("Delete"));
            #endregion

            #region "MstSleLocalizationCategory"
            var mstSleLocalizationCategory = localizationAndExportFather.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCategory, L("MstSleLocalizationCategoryPermissionBanner"));
            mstSleLocalizationCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCategory_Search, L("ViewPermission"));
            mstSleLocalizationCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCategory_Create, L("CreatePermission"));
            mstSleLocalizationCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCategory_Edit, L("EditPermission"));
            mstSleLocalizationCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_LocalizationCategory_Delete, L("Delete"));
            #endregion

            #endregion

            #region CSR/TVF
            var csrAndTvf = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_CsrAndTvf, L("MasterCSRAndTVFPermission"));

            #region "Csr"
            var csr = csrAndTvf.CreateChildPermission(AppPermissions.Pages_Master_Sales_Csr, L("MstSleVehicleProductCsrPermission"));
            csr.CreateChildPermission(AppPermissions.Pages_Master_Sales_Csr_Search, L("ViewPermission"));
            csr.CreateChildPermission(AppPermissions.Pages_Master_Sales_Csr_Create, L("CreatePermission"));
            csr.CreateChildPermission(AppPermissions.Pages_Master_Sales_Csr_Edit, L("EditPermission"));
            csr.CreateChildPermission(AppPermissions.Pages_Master_Sales_Csr_Delete, L("Delete"));
            #endregion

            #region "MstSle Vehicle Product News Category"
            var mstSleVehicleProductNewsCategory = csrAndTvf.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNewsCategory, L("MstSleVehicleProductNewsCategoryPermission"));
            mstSleVehicleProductNewsCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNewsCategory_Search, L("ViewPermission"));
            mstSleVehicleProductNewsCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNewsCategory_Create, L("CreatePermission"));
            mstSleVehicleProductNewsCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNewsCategory_Edit, L("EditPermission"));
            mstSleVehicleProductNewsCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNewsCategory_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product News"
            var mstSleVehicleProductNews = csrAndTvf.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNews, L("MstSleVehicleProductNewsPermission"));
            mstSleVehicleProductNews.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNews_Search, L("ViewPermission"));
            mstSleVehicleProductNews.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNews_Create, L("CreatePermission"));
            mstSleVehicleProductNews.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNews_Edit, L("EditPermission"));
            mstSleVehicleProductNews.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductNews_Delete, L("Delete"));
            #endregion

            #endregion

            #region Bảo dưỡng
            var maintenance = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_Maintenance, L("MasterMaintenancePermission"));

            #region "MstSleVehicleProductMaintenanceLevel"
            var mstSleVehicleProductMaintenanceLevel = maintenance.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceLevel, L("MstSleVehicleProductMaintenanceLevelPermissionBanner"));
            mstSleVehicleProductMaintenanceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceLevel_Search, L("ViewPermission"));
            mstSleVehicleProductMaintenanceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceLevel_Create, L("CreatePermission"));
            mstSleVehicleProductMaintenanceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceLevel_Edit, L("EditPermission"));
            mstSleVehicleProductMaintenanceLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceLevel_Delete, L("Delete"));
            #endregion

            #region "MstSleVehicleProductMaintenanceByModel"
            var MstSleVehicleProductMaintenanceByModel = maintenance.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceByModel, L("MstSleVehicleProductMaintenanceByModelPermissionBanner"));
            MstSleVehicleProductMaintenanceByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceByModel_Search, L("ViewPermission"));
            MstSleVehicleProductMaintenanceByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceByModel_Create, L("CreatePermission"));
            MstSleVehicleProductMaintenanceByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceByModel_Edit, L("EditPermission"));
            MstSleVehicleProductMaintenanceByModel.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductMaintenanceByModel_Delete, L("Delete"));
            #endregion

            #region " MaintenanceDetail"
            var maintenanceDetail = maintenance.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaintenanceDetail, L("MstSleVehicleProductMaintenanceDetail"));
            maintenanceDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaintenanceDetail_Search, L("ViewPermission"));
            maintenanceDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaintenanceDetail_Create, L("CreatePermission"));
            maintenanceDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaintenanceDetail_Edit, L("EditPermission"));
            maintenanceDetail.CreateChildPermission(AppPermissions.Pages_Master_Sales_MaintenanceDetail_Delete, L("Delete"));
            #endregion  

            #region " BeatyCareServices"
            var beatyCareServices = maintenance.CreateChildPermission(AppPermissions.Pages_Master_Sales_BeatyCareServices, L("MstSleVehicleProductBeatyCareServicesPermission"));
            beatyCareServices.CreateChildPermission(AppPermissions.Pages_Master_Sales_BeatyCareServices_Search, L("ViewPermission"));
            beatyCareServices.CreateChildPermission(AppPermissions.Pages_Master_Sales_BeatyCareServices_Create, L("CreatePermission"));
            beatyCareServices.CreateChildPermission(AppPermissions.Pages_Master_Sales_BeatyCareServices_Edit, L("EditPermission"));
            beatyCareServices.CreateChildPermission(AppPermissions.Pages_Master_Sales_BeatyCareServices_Delete, L("Delete"));
            #endregion 

            #endregion

            #region "Trip Request"
            var tripRequest = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_TripRequest, L("MstSleTripRequestPermission"));
            tripRequest.CreateChildPermission(AppPermissions.Pages_Master_Sales_TripRequest_Search, L("ViewPermission"));
            tripRequest.CreateChildPermission(AppPermissions.Pages_Master_Sales_TripRequest_Create, L("CreatePermission"));
            tripRequest.CreateChildPermission(AppPermissions.Pages_Master_Sales_TripRequest_Edit, L("EditPermission"));
            tripRequest.CreateChildPermission(AppPermissions.Pages_Master_Sales_TripRequest_Delete, L("Delete"));
            #endregion

            #region "Price Change"
            var priceChange = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_PriceChange, L("MstSlePriceChangePermission"));
            priceChange.CreateChildPermission(AppPermissions.Pages_Master_Sales_PriceChange_Search, L("ViewPermission"));
            priceChange.CreateChildPermission(AppPermissions.Pages_Master_Sales_PriceChange_Edit, L("EditPermission"));
            #endregion

            #region "Genba"
            var genba = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_Genba, L("MstSleVehicleProductGenbaPermission"));
            genba.CreateChildPermission(AppPermissions.Pages_Master_Sales_Genba_Search, L("ViewPermission"));
            genba.CreateChildPermission(AppPermissions.Pages_Master_Sales_Genba_Create, L("CreatePermission"));
            genba.CreateChildPermission(AppPermissions.Pages_Master_Sales_Genba_Edit, L("EditPermission"));
            genba.CreateChildPermission(AppPermissions.Pages_Master_Sales_Genba_Delete, L("Delete"));
            #endregion


            #region "Recruiment Language"
            var RecruimentLanguage = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruiment_Language, L("MstSleVehicleProductSortByPermission"));
            RecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruiment_Language_Search, L("ViewPermission"));
            RecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruiment_Language_Create, L("CreatePermission"));
            RecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruiment_Language_Edit, L("EditPermission"));
            RecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruiment_Language_Delete, L("Delete"));
            #endregion

            #region "Sustainable Development"
            var sus = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_SustainableDevelopment, L("MstSleSustainableDevelopmentPermission"));
            sus.CreateChildPermission(AppPermissions.Pages_Master_Sales_SustainableDevelopment_Search, L("ViewPermission"));
            sus.CreateChildPermission(AppPermissions.Pages_Master_Sales_SustainableDevelopment_Create, L("CreatePermission"));
            sus.CreateChildPermission(AppPermissions.Pages_Master_Sales_SustainableDevelopment_Edit, L("EditPermission"));
            sus.CreateChildPermission(AppPermissions.Pages_Master_Sales_SustainableDevelopment_Delete, L("Delete"));
            #endregion

            #region "Finance"
            #region " Product Finance Type"
            var financeKnowledge = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_Finance_Knowledge, L("MstSleFinanceKnowledgePermission"));
            var productFinanceType = financeKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceType, L("MstSleProductFinanceTypeBanner"));
            productFinanceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceType_Search, L("ViewPermission"));
            productFinanceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceType_Create, L("CreatePermission"));
            productFinanceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceType_Edit, L("EditPermission"));
            productFinanceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceType_Delete, L("Delete"));
            #endregion






            #region "Vehicle Product Recruitment"
            var recruitment = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruitment, L("Recruitment"));
            #region "danh sách tuyển dụng"
            var vehicleProductRecruitment = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_Vehicle_Product_Recruitment, L("ListVehicleProductRecruitment"));
            vehicleProductRecruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_Vehicle_Product_Recruitment_Search, L("ViewPermission"));
            #endregion
            #region"recruitment software"
            var recruitmentSoftware = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentSoftware, L("Software"));
            recruitmentSoftware.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentSoftware_Search, L("ViewPermission"));
            recruitmentSoftware.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentSoftware_Create, L("CreatePermission"));
            recruitmentSoftware.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentSoftware_Edit, L("EditPermission"));
            recruitmentSoftware.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentSoftware_Delete, L("Delete"));
            #endregion
            #region"skill level"
            var skillLevel = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_SkillLevel, L("SkillLevel"));
            skillLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SkillLevel_Search, L("ViewPermission"));
            skillLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SkillLevel_Create, L("CreatePermission"));
            skillLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SkillLevel_Edit, L("EditPermission"));
            skillLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_SkillLevel_Delete, L("Delete"));
            #endregion
            #region"education level"
            var educationLevel = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_EducationLevel, L("CandidateEducationBackground"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_EducationLevel_Search, L("ViewPermission"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_EducationLevel_Create, L("CreatePermission"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_EducationLevel_Edit, L("EditPermission"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_EducationLevel_Delete, L("Delete"));
            #endregion 

            #region "MstSleRecruitmentDepartmentUnit"
            var mstSleRecruitmentDepartmentUnit = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentDepartmentUnit, L("MstSleRecruitmentDepartmentUnitPermission"));
            mstSleRecruitmentDepartmentUnit.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentDepartmentUnit_Search, L("ViewPermission"));
            mstSleRecruitmentDepartmentUnit.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentDepartmentUnit_Create, L("CreatePermission"));
            mstSleRecruitmentDepartmentUnit.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentDepartmentUnit_Edit, L("EditPermission"));
            mstSleRecruitmentDepartmentUnit.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentDepartmentUnit_Delete, L("Delete"));
            #endregion

            #region "MstSleRecruitmentWeb"
            var mstSleRecruitmentWeb = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentWeb, L("MstSleRecruitmentWebPermission"));
            mstSleRecruitmentWeb.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentWeb_Search, L("ViewPermission"));
            mstSleRecruitmentWeb.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentWeb_Create, L("CreatePermission"));
            mstSleRecruitmentWeb.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentWeb_Edit, L("EditPermission"));
            mstSleRecruitmentWeb.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentWeb_Delete, L("Delete"));
            #endregion

            #region "RecruimentOverview"
            var RecruimentOverview = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruitment_Overview, L("MstSleVehicleProductRecruitmentOverviewPermission"));
            RecruimentOverview.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruitment_Overview_Search, L("ViewPermission"));
            RecruimentOverview.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruitment_Overview_Create, L("CreatePermission"));
            RecruimentOverview.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruitment_Overview_Edit, L("EditPermission"));
            RecruimentOverview.CreateChildPermission(AppPermissions.Pages_Master_Sales_Recruitment_Overview_Delete, L("Delete"));
            #endregion

            #region"recruitment location"
            var recruitmemtLocation = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentLocation, L("MstSleVehicleProductRecruimentLocationInfo"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentLocation_Search, L("ViewPermission"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentLocation_Create, L("CreatePermission"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentLocation_Edit, L("EditPermission"));
            educationLevel.CreateChildPermission(AppPermissions.Pages_Master_Sales_RecruitmentLocation_Delete, L("Delete"));
            #endregion
            #region"Vehicle Product Applied Position"
            var appliedPosition = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductAppliedPosition, L("VehicleProductAppliedPosition"));
            appliedPosition.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductAppliedPosition_Search, L("ViewPermission"));
            appliedPosition.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductAppliedPosition_Create, L("CreatePermission"));
            appliedPosition.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductAppliedPosition_Edit, L("EditPermission"));
            appliedPosition.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductAppliedPosition_Delete, L("Delete"));
            #endregion
            #region "MstSleVehicleProductRecruimentLanguage"
            var mstSleVehicleProductRecruimentLanguage = recruitment.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRecruimentLanguage, L("MstSleVehicleProductRecruimentLanguagePermission"));
            mstSleVehicleProductRecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRecruimentLanguage_Search, L("ViewPermission"));
            mstSleVehicleProductRecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRecruimentLanguage_Create, L("CreatePermission"));
            mstSleVehicleProductRecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRecruimentLanguage_Edit, L("EditPermission"));
            mstSleVehicleProductRecruimentLanguage.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRecruimentLanguage_Delete, L("Delete"));
            #endregion

            #endregion

            #region " Product Finance Category"
            var productFinanceCategory = financeKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceCategory, L("MstSleProductFinanceCategoryBanner"));
            productFinanceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceCategory_Search, L("ViewPermission"));
            productFinanceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceCategory_Create, L("CreatePermission"));
            productFinanceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceCategory_Edit, L("EditPermission"));
            productFinanceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceCategory_Delete, L("Delete"));
            #endregion

            #region " Product Finance Introduce"
            var productFinanceIntroduce = financeKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceIntroduce, L("MstSleProductFinanceIntroduceBanner"));
            productFinanceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceIntroduce_Search, L("ViewPermission"));
            productFinanceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceIntroduce_Create, L("CreatePermission"));
            productFinanceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceIntroduce_Edit, L("EditPermission"));
            productFinanceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceIntroduce_Delete, L("Delete"));
            #endregion

            #region " Product Finance Answer"
            var productFinanceAnswer = financeKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceAnswer, L("MstSleProductFinanceAnswerBanner"));
            productFinanceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceAnswer_Search, L("ViewPermission"));
            productFinanceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceAnswer_Create, L("CreatePermission"));
            productFinanceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceAnswer_Edit, L("EditPermission"));
            productFinanceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductFinanceAnswer_Delete, L("Delete"));
            #endregion

            #region "Product Finance Question"
            var financeQuestion = financeKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Finance_Question, L("MstSleProductFinanceQuestionPermission"));
            financeQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Finance_Question_Create, L("CreatePermission"));
            financeQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Finance_Question_Edit, L("EditPermission"));
            financeQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Finance_Question_Delete, L("Delete"));
            financeQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Finance_Question_Search, L("ViewPermission"));
            #endregion

            #endregion

            #region "Insurance"

            #region "Product Insurance Question"
            var insuranceKnowledge = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_Insurance_Knowledge, L("MstSleInsuranceKnowledgePermission"));
            var insuranceQuestion = insuranceKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Insurance_Question, L("MstSleProductFinanceQuestionPermission"));
            insuranceQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Insurance_Question_Create, L("CreatePermission"));
            insuranceQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Insurance_Question_Edit, L("EditPermission"));
            insuranceQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Insurance_Question_Delete, L("Delete"));
            insuranceQuestion.CreateChildPermission(AppPermissions.Pages_Master_Sales_Product_Insurance_Question_Search, L("ViewPermission"));
            #endregion

            #region " Product Insurance Type"
            var productInsuranceType = insuranceKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceType, L("MstSleProductInsuranceTypeBanner"));
            productInsuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceType_Search, L("ViewPermission"));
            productInsuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceType_Create, L("CreatePermission"));
            productInsuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceType_Edit, L("EditPermission"));
            productInsuranceType.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceType_Delete, L("Delete"));
            #endregion

            #region " Product Insurance Category"
            var productInsuranceCategory = insuranceKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceCategory, L("MstSleProductFinanceCategoryBanner"));
            productInsuranceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceCategory_Search, L("ViewPermission"));
            productInsuranceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceCategory_Create, L("CreatePermission"));
            productInsuranceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceCategory_Edit, L("EditPermission"));
            productInsuranceCategory.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceCategory_Delete, L("Delete"));
            #endregion

            #region " Product Insurance Answer"
            var productInsuranceAnswer = insuranceKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceAnswer, L("MstSleProductFinanceAnswerBanner"));
            productInsuranceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceAnswer_Search, L("ViewPermission"));
            productInsuranceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceAnswer_Create, L("CreatePermission"));
            productInsuranceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceAnswer_Edit, L("EditPermission"));
            productInsuranceAnswer.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceAnswer_Delete, L("Delete"));
            #endregion

            #region " Product Insurance Introduce"
            var productInsuranceIntroduce = insuranceKnowledge.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceIntroduce, L("MstSleProductFinanceIntroduceBanner"));
            productInsuranceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceIntroduce_Search, L("ViewPermission"));
            productInsuranceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceIntroduce_Create, L("CreatePermission"));
            productInsuranceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceIntroduce_Edit, L("EditPermission"));
            productInsuranceIntroduce.CreateChildPermission(AppPermissions.Pages_Master_Sales_ProductInsuranceIntroduce_Delete, L("Delete"));
            #endregion
            #endregion

            #region "Vehicle Product Value Chain"
            var veicleProductValueChain = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductValueChain, L("MstSleVehicleProductValueChainPermissionBanner"));
            veicleProductValueChain.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductValueChain_Search, L("ViewPermission"));
            veicleProductValueChain.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductValueChain_Create, L("CreatePermission"));
            veicleProductValueChain.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductValueChain_Edit, L("EditPermission"));
            veicleProductValueChain.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductValueChain_Delete, L("Delete"));
            #endregion

            #region " Value Chain Source"
            var valueChainSource = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_ValueChainSource, L("MstSleValueChainSourcePermission"));
            valueChainSource.CreateChildPermission(AppPermissions.Pages_Master_Sales_ValueChainSource_Search, L("ViewPermission"));
            valueChainSource.CreateChildPermission(AppPermissions.Pages_Master_Sales_ValueChainSource_Create, L("CreatePermission"));
            valueChainSource.CreateChildPermission(AppPermissions.Pages_Master_Sales_ValueChainSource_Edit, L("EditPermission"));
            valueChainSource.CreateChildPermission(AppPermissions.Pages_Master_Sales_ValueChainSource_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Document"
            var veicleProductDocument = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocument, L("MstSleVehicleProductDocumentBanner"));
            veicleProductDocument.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocument_Search, L("ViewPermission"));
            veicleProductDocument.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocument_Create, L("CreatePermission"));
            veicleProductDocument.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocument_Edit, L("EditPermission"));
            veicleProductDocument.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocument_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Document Parent"
            var veicleProductDocumentPareant = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentParent, L("MstSleVehicleProductDocumentParentPermissionBanner"));
            veicleProductDocumentPareant.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentParent_Search, L("ViewPermission"));
            veicleProductDocumentPareant.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentParent_Create, L("CreatePermission"));
            veicleProductDocumentPareant.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentParent_Edit, L("EditPermission"));
            veicleProductDocumentPareant.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentParent_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Document Son"
            var veicleProductDocumentSon = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentSon, L("MstSleVehicleProductDocumentSonPermissionBanner"));
            veicleProductDocumentSon.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentSon_Search, L("ViewPermission"));
            veicleProductDocumentSon.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentSon_Create, L("CreatePermission"));
            veicleProductDocumentSon.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentSon_Edit, L("EditPermission"));
            veicleProductDocumentSon.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductDocumentSon_Delete, L("Delete"));
            #endregion



            #region "MstSleTestDriveEmail"
            var mstSleTestDriveEmail = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveEmail, L("MstSleTestDriveEmail"));
            mstSleTestDriveEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveEmail_Search, L("ViewPermission"));
            mstSleTestDriveEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveEmail_Create, L("CreatePermission"));
            mstSleTestDriveEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveEmail_Edit, L("EditPermission"));
            mstSleTestDriveEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_TestDriveEmail_Delete, L("Delete"));
            #endregion

            #region "MstSleDuplicatePhoneEmail"
            var mstSleDuplicatePhoneEmail = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_DuplicatePhoneEmail, L("MstSleTestDriveEmail"));
            mstSleDuplicatePhoneEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_DuplicatePhoneEmail_Search, L("ViewPermission"));
            mstSleDuplicatePhoneEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_DuplicatePhoneEmail_Create, L("CreatePermission"));
            mstSleDuplicatePhoneEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_DuplicatePhoneEmail_Edit, L("EditPermission"));
            mstSleDuplicatePhoneEmail.CreateChildPermission(AppPermissions.Pages_Master_Sales_DuplicatePhoneEmail_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product Tecnology Info"
            var mstSleVehicleProductTecnologyInfo = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTecnologyInfo, L("MstSleVehicleProductTecnologyInfoPermissionBanner"));
            mstSleVehicleProductTecnologyInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTecnologyInfo_Search, L("ViewPermission"));
            mstSleVehicleProductTecnologyInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTecnologyInfo_Create, L("CreatePermission"));
            mstSleVehicleProductTecnologyInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTecnologyInfo_Edit, L("EditPermission"));
            mstSleVehicleProductTecnologyInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTecnologyInfo_Delete, L("Delete"));
            #endregion

            #region "Vehicle Product TFS"
            var mstSleVehicleProductTFS = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTFS, L("MstSleVehicleProductTFSPermission"));
            mstSleVehicleProductTFS.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTFS_Search, L("ViewPermission"));
            mstSleVehicleProductTFS.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTFS_Create, L("CreatePermission"));
            mstSleVehicleProductTFS.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTFS_Edit, L("EditPermission"));
            mstSleVehicleProductTFS.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductTFS_Delete, L("Delete"));
            #endregion

            #region "MstSleVehicleProductBanner"
            var mstSleVehicleProductBanner = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBanner, L("MstSleVehicleProductBannerPermissionBanner"));
            mstSleVehicleProductBanner.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBanner_Search, L("ViewPermission"));
            mstSleVehicleProductBanner.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBanner_Create, L("CreatePermission"));
            mstSleVehicleProductBanner.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBanner_Edit, L("EditPermission"));
            mstSleVehicleProductBanner.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductBanner_Delete, L("Delete"));
            #endregion

            #region "MstSleVehicleProductCommunicate"
            var mstSleVehicleProductCommunicate = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCommunicate, L("MstSleVehicleProductCommunicatePermission"));
            mstSleVehicleProductCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCommunicate_Search, L("ViewPermission"));
            mstSleVehicleProductCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCommunicate_Create, L("CreatePermission"));
            mstSleVehicleProductCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCommunicate_Edit, L("EditPermission"));
            mstSleVehicleProductCommunicate.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductCommunicate_Delete, L("Delete"));
            #region "MstSleVehicleProductRouter"
            var MstSleVehicleProductRouter = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRouter, L("MstSleVehicleProductRouterPermission"));
            MstSleVehicleProductRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRouter_Search, L("ViewPermission"));
            MstSleVehicleProductRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRouter_Create, L("CreatePermission"));
            MstSleVehicleProductRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRouter_Edit, L("EditPermission"));
            MstSleVehicleProductRouter.CreateChildPermission(AppPermissions.Pages_Master_Sales_VehicleProductRouter_Delete, L("Delete"));
            #endregion



            #region "MstSleErrorNotiInfomation"
            var MstSleErrorNotiInfomation = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_ErrorNotilnFomation, L("MstSleVehicleProductErrorNotilnFomationPermissionBanner"));
            MstSleErrorNotiInfomation.CreateChildPermission(AppPermissions.Pages_Master_Sales_ErrorNotilnFomation_Search, L("ViewPermission"));
            MstSleErrorNotiInfomation.CreateChildPermission(AppPermissions.Pages_Master_Sales_ErrorNotilnFomation_Create, L("CreatePermission"));
            MstSleErrorNotiInfomation.CreateChildPermission(AppPermissions.Pages_Master_Sales_ErrorNotiInfomation_Edit, L("EditPermission"));
            MstSleErrorNotiInfomation.CreateChildPermission(AppPermissions.Pages_Master_Sales_ErrorNotiInfomation_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Vehicle Transportation"
            var vehicleTransportation = master.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Vehicle_Transportation, L("VehicleTransportationPermission"));

            #region " Logistic Company"
            var logisticCompany = vehicleTransportation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Logistic_Company_Info, L("MstSleLogisticCompanyInfoPermission"));
            logisticCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_Logistic_Company_Info_Create, L("CreatePermission"));
            logisticCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_Logistic_Company_Info_Edit, L("EditPermission"));
            logisticCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_Logistic_Company_Info_Delete, L("Delete"));
            logisticCompany.CreateChildPermission(AppPermissions.Pages_Master_Sales_Logistic_Company_Info_Search, L("ViewPermission"));
            #endregion

            #region "Route"
            var route = vehicleTransportation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Route, L("MstSleRoutePermission"));
            route.CreateChildPermission(AppPermissions.Pages_Master_Sales_Route_Search, L("ViewPermission"));
            route.CreateChildPermission(AppPermissions.Pages_Master_Sales_Route_Create, L("CreatePermission"));
            route.CreateChildPermission(AppPermissions.Pages_Master_Sales_Route_Edit, L("EditPermission"));
            route.CreateChildPermission(AppPermissions.Pages_Master_Sales_Route_Delete, L("Delete"));
            #endregion

            #region "Transportation Type"
            var transportationType = vehicleTransportation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Type, L("MstSleTransportationTypePermission"));
            transportationType.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Type_Search, L("ViewPermission"));
            transportationType.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Type_Create, L("CreatePermission"));
            transportationType.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Type_Edit, L("EditPermission"));
            transportationType.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Type_Delete, L("Delete"));
            #endregion

            #region "Transportation Route"
            var transportationRoute = vehicleTransportation.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Route_Setup, L("MstSleTransportRoutePermission"));
            transportationRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Route_Setup_Search, L("ViewPermission"));
            transportationRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Route_Setup_Create, L("CreatePermission"));
            transportationRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Route_Setup_Edit, L("EditPermission"));
            transportationRoute.CreateChildPermission(AppPermissions.Pages_Master_Sales_Transportation_Route_Setup_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Quantity Expected"
            var quantityExpected = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductQuantityExpected, L("MstSleProductQuantiyExpectedPermission"));
            quantityExpected.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductQuantityExpected_Search, L("ViewPermission"));
            quantityExpected.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductQuantityExpected_Create, L("CreatePermission"));
            quantityExpected.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductQuantityExpected_Edit, L("EditPermission"));
            quantityExpected.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductQuantityExpected_Delete, L("Delete"));
            #endregion

            #region "Quantity Expected"
            var concernProduct = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductConcern, L("MstSleProductConcernPermission"));
            concernProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductConcern_Search, L("ViewPermission"));
            concernProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductConcern_Create, L("CreatePermission"));
            concernProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductConcern_Edit, L("EditPermission"));
            concernProduct.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductConcern_Delete, L("Delete"));
            #endregion

            #region "InstructionalMaterials"
            var instructionalMaterial = product.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductInstructionalMaterial, L("MstSleProductInstructionalMaterialPermission"));
            instructionalMaterial.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductInstructionalMaterial_Search, L("ViewPermission"));
            instructionalMaterial.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductInstructionalMaterial_Create, L("CreatePermission"));
            instructionalMaterial.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductInstructionalMaterial_Edit, L("EditPermission"));
            instructionalMaterial.CreateChildPermission(AppPermissions.Pages_Master_Sales_MstSleProductInstructionalMaterial_Delete, L("Delete"));
            #endregion

            #endregion

            #region "Contract"
            var contractMaster = master.CreateChildPermission(AppPermissions.Pages_Master_Sales_contractMaster, L("ContractMasterPermission"));

            #region "Contract Info"
            var contractInfo = contractMaster.CreateChildPermission(AppPermissions.Pages_Master_Sales_Dealer_Contract_Info, L("MstSleDealerContractInfoPermission"));
            contractInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Dealer_Contract_Info_Create, L("CreatePermission"));
            contractInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Dealer_Contract_Info_Edit, L("EditPermission"));
            contractInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Dealer_Contract_Info_Delete, L("Delete"));
            contractInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Dealer_Contract_Info_Search, L("ViewPermission"));
            contractInfo.CreateChildPermission(AppPermissions.Pages_Master_Sales_Dealer_Contract_Info_Edit_Dealer, L("MstSleDealerContractInfoEditDealer"));
            #endregion

            #region "SalesContractCampaignByGrade"
            var SalesContractCampaignByGrade = contractMaster.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesContractCampaignByGrade, L("SalesContractCampaignByGradePermission"));
            SalesContractCampaignByGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesContractCampaignByGrade_Create, L("CreatePermission"));
            SalesContractCampaignByGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesContractCampaignByGrade_Edit, L("EditPermission"));
            SalesContractCampaignByGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesContractCampaignByGrade_Delete, L("Delete"));
            SalesContractCampaignByGrade.CreateChildPermission(AppPermissions.Pages_Master_Sales_SalesContractCampaignByGrade_Search, L("ViewPermission"));
            #endregion

            #endregion

            #region "ExtendsWarraty"
            var extendsWarraty = master.CreateChildPermission(AppPermissions.Pages_Master_Sales_Extends_Warranty, L("ExtendsWarrantyPermission"));

            #region "Extended Warranty"
            var ExtendedWarranty = extendsWarraty.CreateChildPermission(AppPermissions.Pages_Master_Extended_Warranty, L("MstSleExtendedWarrantyPermission"));
            ExtendedWarranty.CreateChildPermission(AppPermissions.Pages_Master_Extended_Warranty_Search, L("ViewPermission"));
            ExtendedWarranty.CreateChildPermission(AppPermissions.Pages_Master_Extended_Warranty_Create, L("CreatePermission"));
            ExtendedWarranty.CreateChildPermission(AppPermissions.Pages_Master_Extended_Warranty_Edit, L("EditPermission"));
            ExtendedWarranty.CreateChildPermission(AppPermissions.Pages_Master_Extended_Warranty_Delete, L("Delete"));
            #endregion
            #endregion
            #region "ContractWarraty"
            var contractWarraty = master.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sale_Contract_Warranty, L("SaleContractWarranty"));
            contractWarraty.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sale_Contract_Warranty_Search, L("ViewPermission"));
            contractWarraty.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sale_Contract_Warranty_Create, L("CreatePermission"));
            contractWarraty.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sale_Contract_Warranty_Edit, L("EditPermission"));
            contractWarraty.CreateChildPermission(AppPermissions.Pages_Master_Sales_Sale_Contract_Warranty_Delete, L("Delete"));

            #endregion

            #region "SalesOrderGradeMapping"
            var SalesOrderGradeMapping = master.CreateChildPermission(AppPermissions.Pages_Master_Sale_Sales_Order_Grade_Mapping, L("SalesOrderGradeMapping"));
            SalesOrderGradeMapping.CreateChildPermission(AppPermissions.Pages_Master_Sale_Sales_Order_Grade_Mapping_Search, L("ViewPermission"));
            SalesOrderGradeMapping.CreateChildPermission(AppPermissions.Pages_Master_Sale_Sales_Order_Grade_Mapping_Create, L("CreatePermission"));
            SalesOrderGradeMapping.CreateChildPermission(AppPermissions.Pages_Master_Sale_Sales_Order_Grade_Mapping_Edit, L("EditPermission"));
            SalesOrderGradeMapping.CreateChildPermission(AppPermissions.Pages_Master_Sale_Sales_Order_Grade_Mapping_Delete, L("Delete"));

            #endregion


            #region "UsedCar"
            var masterUsedCar = master.CreateChildPermission(AppPermissions.Pages_Master_UsedCar, L("MasterUserCarPermission"));

            #region "UsedCarStatus"
            var mstUsedCarStatus = masterUsedCar.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus, L("MstUsedCarStatusPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_Search, L("ViewStatusPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_Create, L("CreateStatusPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_Edit, L("EditStatusPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_Delete, L("StatusDelete"));

            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Search, L("ViewStatusReasonPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Create, L("CreateStatusReasonPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Edit, L("EditStatusReasonPermission"));
            mstUsedCarStatus.CreateChildPermission(AppPermissions.Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Delete, L("StatusReasonDelete"));
            #endregion
            #endregion

            #region "Sale Target Plan TMV By Day"
            #region "Cấu hình hóa đơn"
            var masterInvoiceDelayFeeConfig = master.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig, L("MasterInvoiceConfig"));

            #region "Email thanh toán"
            var configEmail = masterInvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_EmailPayment, L("PermissionSalesVehicleInvoiceConfigEmail"));
            #endregion

            #region "InvoiceDelayFeeConfig"
            var InvoiceDelayFeeConfig = masterInvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig, L("PermissionSalesInvoiceConfigInvoiceDelayFeeConfig"));
            InvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Create, L("CreatePermission"));
            InvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Edit, L("EditPermission"));
            InvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Delete, L("Delete"));
            InvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Import, L("Import"));
            #endregion

            #region "DocumentExpressVendor"
            var DocumentExpressVendor = masterInvoiceDelayFeeConfig.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_DocumentExpressVendor, L("MstSleDocumentExpressVendorPermission"));
            DocumentExpressVendor.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_DocumentExpressVendor_Search, L("ViewPermission"));
            DocumentExpressVendor.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_DocumentExpressVendor_Create, L("CreatePermission"));
            DocumentExpressVendor.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_DocumentExpressVendor_Edit, L("EditPermission"));
            DocumentExpressVendor.CreateChildPermission(AppPermissions.Pages_Master_InvoiceConfig_DocumentExpressVendor_Delete, L("Delete"));
            #endregion

            

           
            #endregion

            #endregion

            #endregion



 


            //Cấu hình hiển thị dữ liệu
            #region "SalesAdmin"
            var salesAdmin = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Sales_Admin, L("SalesAdminPermission"));
            #region "Admin Column"
            var salesAdminColumn = salesAdmin.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminColumn, L("SalesAdminColumn"));
            salesAdminColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminColumn_Create, L("SalesAdminColumnCreate"));
            salesAdminColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminColumn_Edit, L("SalesAdminColumnEdit"));
            salesAdminColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminColumn_Delete, L("SalesAdminColumnDelete"));
            salesAdminColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminColumn_Search, L("SalesAdminColumnSearch"));
            #endregion

            #region "Admin Form"
            var salesAdminForm = salesAdmin.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminForm, L("SalesAdminForm"));
            salesAdminForm.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminForm_Create, L("SalesAdminFormCreate"));
            salesAdminForm.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminForm_Edit, L("SalesAdminFormEdit"));
            salesAdminForm.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminForm_Delete, L("SalesAdminFormDelete"));
            salesAdminForm.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminForm_Search, L("SalesAdminFormSearch"));
            #endregion

            #region "Admin Group User"
            var salesAdminGroupUser = salesAdmin.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupUser, L("SalesAdminGroupUser"));
            salesAdminGroupUser.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupUser_Create, L("SalesAdminGroupUserCreate"));
            salesAdminGroupUser.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupUser_Edit, L("SalesAdminGroupUserEdit"));
            salesAdminGroupUser.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupUser_Delete, L("SalesAdminGroupUserDelete"));
            salesAdminGroupUser.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupUser_Search, L("SalesAdminGroupUserSearch"));
            #endregion

            #region "Admin Group"
            var salesAdminGroup = salesAdmin.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroup, L("SalesAdminGroup"));
            salesAdminGroup.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroup_Create, L("SalesAdminGroupCreate"));
            salesAdminGroup.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroup_Edit, L("SalesAdminGroupEdit"));
            salesAdminGroup.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroup_Delete, L("SalesAdminGroupDelete"));
            salesAdminGroup.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroup_Search, L("SalesAdminGroupSearch"));
            #endregion

        /*    #region "Admin Group Column"
            var salesAdminGroupColumn = salesAdmin.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupColumn, L("SalesAdminGroupColumn"));
            salesAdminGroupColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupColumn_Create, L("SalesAdminGroupColumnCreate"));
            salesAdminGroupColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupColumn_Edit, L("SalesAdminGroupColumnEdit"));
            salesAdminGroupColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupColumn_Delete, L("SalesAdminGroupColumnDelete"));
            salesAdminGroupColumn.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminGroupColumn_Search, L("SalesAdminGroupColumnSearch"));
            #endregion
*/
            #region "Admin Display Role"
            var salesAdminDisplayRole = salesAdmin.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminRole, L("SalesAdminDisplayRole"));
            salesAdminDisplayRole.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminRole_Edit, L("SalesAdminDisplayRoleEdit"));
            salesAdminDisplayRole.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminRole_Search, L("SalesAdminDisplayRoleSearch"));
            salesAdminDisplayRole.CreateChildPermission(AppPermissions.Pages_Sales_SalesAdminRole_Delete, L("SalesAdminDisplayRoleDelete"));
            #endregion

            #endregion

            //Giao diện mẫu demo
            pages.CreateChildPermission(AppPermissions.Pages_DemoUiComponents, L("DemoUiComponents"));

            // FB leads
            #region FbLead
            var fbLeads = pages.CreateChildPermission(AppPermissions.Pages_Sales_FbLeads, L("FbLeadsPermission"));
            fbLeads.CreateChildPermission(AppPermissions.Pages_Sales_FbDelete, L("Delete"));
            #endregion

            //Báo cáo trực quan
            #region "Sales Report"
            var salesReport = pages.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Report, L("MstSleSalesReport"));
            #endregion

            //DashboardShow
            #region "Dashboard Show"
            var dashboardShow = pages.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show, L("MstSleSalesDashBoardShow"));

            #region "Dashboard Screen"
            var dashboardShowScreen = dashboardShow.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_Screen, L("MstSleSalesDashBoardShowScreen"));
            #endregion
            #region "Dashboard Screen Config"
            var dashboardShowCongfig = dashboardShow.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_Config, L("MstSleSalesDashBoardShowConfig"));
            dashboardShowCongfig.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_Config_Create, L("CreatePermission"));
            dashboardShowCongfig.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_Config_Edit, L("EditPermission"));
            dashboardShowCongfig.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_Config_Delete, L("Delete"));
            dashboardShowCongfig.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_Config_Search, L("ViewPermission"));
            #endregion
            
            #region "Dashboard Screen"
            var dashboardShowDashboardScreenList = dashboardShow.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_DashboardScreenList, L("DashboardShowDashboardScreenList"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_InforDashboardWeb, L("DashboardShowDashboardInforDashboardWeb"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_ListSourceChart, L("DashboardShowDashboardListSourceChart"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_DetailPotentialCustomer, L("DashboardShowDashboardDetailPotentialCustomer"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_MovementInquiryCustomer, L("DashboardShowDashboardMovementInquiryCustomer"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_MovementIMAndCWDCustomer, L("DashboardShowDashboardMovementIMAndCWDCustomer"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_MovementSaleCustomer, L("DashboardShowDashboardMovementSaleCustomer"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_InquiruCustomerByTotalModel, L("DashboardShowDashboardInquiruCustomerByTotalModel"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_FollowActivitySalesPerson, L("DashboardShowDashboardFollowActivitySalesPerson"));
            dashboardShowDashboardScreenList.CreateChildPermission(AppPermissions.Pages_Sales_Dashboard_Show_CustomerHWC, L("DashboardShowDashboardCustomerHWC"));
            #endregion

            #endregion


            var administration = pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            var roles = administration.CreateChildPermission(AppPermissions.Pages_Administration_Roles, L("Roles"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Create, L("CreatingNewRole"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Edit, L("EditingRole"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Delete, L("DeletingRole"));

            var users = administration.CreateChildPermission(AppPermissions.Pages_Administration_Users, L("Users"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Create, L("CreatingNewUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Edit, L("EditingUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Delete, L("DeletingUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_ChangePermissions, L("ChangingPermissions"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Impersonation, L("LoginForUsers"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Unlock, L("Unlock"));

            var languages = administration.CreateChildPermission(AppPermissions.Pages_Administration_Languages, L("Languages"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Create, L("CreatingNewLanguage"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Edit, L("EditingLanguage"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Delete, L("DeletingLanguages"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_ChangeTexts, L("ChangingTexts"));

            administration.CreateChildPermission(AppPermissions.Pages_Administration_AuditLogs, L("AuditLogs"));

            administration.CreateChildPermission(AppPermissions.Pages_Administration_UiCustomization, L("VisualSettings"));

            var webhooks = administration.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription, L("Webhooks"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_Create, L("CreatingWebhooks"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_Edit, L("EditingWebhooks"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_ChangeActivity, L("ChangingWebhookActivity"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_Detail, L("DetailingSubscription"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_Webhook_ListSendAttempts, L("ListingSendAttempts"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_Webhook_ResendWebhook, L("ResendingWebhook"));

         
            var ipAdressLog = administration.CreateChildPermission(AppPermissions.Pages_Administration_IpAdressLog, L("MstSleIPAddressLogPermission"));
            ipAdressLog.CreateChildPermission(AppPermissions.Pages_Administration_IpAdressLog_Create, L("Create"));

            //TENANT-SPECIFIC PERMISSIONS


            administration.CreateChildPermission(AppPermissions.Pages_Administration_Tenant_Settings, L("Settings"), multiTenancySides: MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement, L("Subscription"), multiTenancySides: MultiTenancySides.Tenant);

            //HOST-SPECIFIC PERMISSIONS

            var editions = pages.CreateChildPermission(AppPermissions.Pages_Editions, L("Editions"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Create, L("CreatingNewEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Edit, L("EditingEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Delete, L("DeletingEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_MoveTenantsToAnotherEdition, L("MoveTenantsToAnotherEdition"), multiTenancySides: MultiTenancySides.Host);

            var tenants = pages.CreateChildPermission(AppPermissions.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Create, L("CreatingNewTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Edit, L("EditingTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_ChangeFeatures, L("ChangingFeatures"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Delete, L("DeletingTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Impersonation, L("LoginForTenants"), multiTenancySides: MultiTenancySides.Host);



            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Settings, L("Settings"), multiTenancySides: MultiTenancySides.Host);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Maintenance, L("Maintenance"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_HangfireDashboard, L("HangfireDashboard"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);

            var contractTmssManagementForTMV = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Menu_Contract_Tmss_Management_For_TMV, L("SaleContractTmssManagementForTMVPermission"), multiTenancySides: MultiTenancySides.Host);

            var cancelContractTMV = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Contract_Cancel_For_TMV, L("SaleContractCancelForTMVPermission"), multiTenancySides: MultiTenancySides.Host);

            var changeContractTMV = saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Contract_Change_For_TMV, L("SaleContractChangeForTMVPermission"), multiTenancySides: MultiTenancySides.Host);

            saleContract.CreateChildPermission(AppPermissions.Pages_Sales_Contract_Delivery_For_TMV, L("SaleContractDeliveryForTMVPermission"));
            #region "SalesProposalApprover"
            var salesProposalApprover = pages.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover, L("SalesProposalApprover"));
            salesProposalApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover_InsertProposalApprover, L("InsertProposalApprover"));
            salesProposalApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover_GetSalePersonManagers, L("GetSalePersonManagers"));
            salesProposalApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover_GetSalesProposalApprover, L("GetSalesProposalApprover"));
            salesProposalApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover_Approve, L("Approve"));
            salesProposalApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover_Reject, L("Reject"));
            salesProposalApprover.CreateChildPermission(AppPermissions.Pages_Sales_SalesProposalApprover_GetListForwardTo, L("GetListForwardTo"));
            #endregion

            #region Đề xuất bán hàng
            var salesProposalMenu = pages.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Menu, L("SalesProposalMenu"));
            #region Chính sách BH
            salesProposalMenu.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Policy, L("SalesProposalPolicy"));
            #endregion 

            #region Đề xuất BH 
            var proposalMain = salesProposalMenu.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Main, L("SalesProposalMain"));
            proposalMain.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Menu_Main_Create, L("CreatePermission"));
            proposalMain.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Menu_Main_Edit, L("EditPermission"));
            proposalMain.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Menu_Main_Delete, L("Delete"));
            proposalMain.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Menu_Main_CancelRequest, L("CancelRequest"));
            #endregion

            #region Phê duyệt BH
            var proposapApproval = salesProposalMenu.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Approve, L("SalesProposalApprove"));
            proposapApproval.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Approve_Approve, L("SalesSwapApprove"));
            proposapApproval.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Approve_Reject, L("SalesSwapReject"));
            proposapApproval.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Approve_ApproveCancel, L("FleetTMVApprovedCancel"));
            proposapApproval.CreateChildPermission(AppPermissions.Pages_Sales_Proposal_Approve_RejectCancel, L("RejectCancel"));
            #endregion

            #endregion

            
            #region "Mobile"
            var moblie = context.GetPermissionOrNull(AppPermissions.Mobile) ?? context.CreatePermission(AppPermissions.Mobile, L("Mobile"));
            var generalPermission = moblie.CreateChildPermission(AppPermissions.Mobile_General, L("MobileGeneral"));

            #region "Scan Qr Mobile"
            var mobileQRPermission = moblie.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR, L("MobileVehicleQR"));
            mobileQRPermission.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR_ScanAtDealer, L("ScanAtDealer"));
            mobileQRPermission.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR_ScanAtTMV, L("ScanAtTMV"));
            mobileQRPermission.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR_ScanAtPort, L("ScanAtPort"));
            mobileQRPermission.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR_ListCarArriveAtDealer, L("ListCarArriveAtDealer"));
            mobileQRPermission.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR_ListCarArriveAtTMV, L("ListCarArriveAtTMV"));
            mobileQRPermission.CreateChildPermission(AppPermissions.Mobile_Vehicle_QR_ListCarArriveAtPort, L("ListCarArriveAtPort"));
            #endregion
            #region "ContactReminder"
            var mobileContactReminderPermission = moblie.CreateChildPermission(AppPermissions.Mobile_Contact_Reminder, L("MobileContactReminder"));
            #endregion
            //var mobileCustomer = moblie.CreateChildPermission(AppPermissions.Pages_Administration, L("MobileCustomer"));
            #region "SalesCustomerMobile"
            var mobileSalesCustomer = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCustomer, L("SalesCustomerPermissionMobile"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_View, L("ViewCustomer"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_Create, L("CreateCustomer"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_Delete, L("DeleteCustomer"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_Edit, L("EditCustomer"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_ViewAssignment, L("ViewAssignment"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_EditAssignment, L("EditAssignment"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_DeleteAssignment, L("DeleteAssignment"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_ViewContactResult, L("ViewContactResult"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_EditContactResult, L("EditContactResult"));
            mobileSalesCustomer.CreateChildPermission(AppPermissions.Mobile_SalesCustomer_DeleteContactResult, L("DeleteContactResult"));
            #endregion
            #region "Mobile Sale Contract"
            var mobileSaleContract = moblie.CreateChildPermission(AppPermissions.Mobile_Sales_SaleContract, L("SaleContractPermissionMobile"));
            mobileSaleContract.CreateChildPermission(AppPermissions.Mobile_Sales_SaleContract_GetContractByCustomerId, L("ViewPermission"));
            mobileSaleContract.CreateChildPermission(AppPermissions.Mobile_Sales_SaleContract_CreateOrEditPostSaleContract, L("CreateOrEditPermission"));
            mobileSaleContract.CreateChildPermission(AppPermissions.Mobile_Sales_SaleContract_DeleteContractVehcle, L("Delete"));
            #endregion

            #region "Mobile Sales Quotation"
            var mobileSaleSQuotation = moblie.CreateChildPermission(AppPermissions.Mobile_SalesQuotation, L("SalesQuotation"));
            mobileSaleSQuotation.CreateChildPermission(AppPermissions.Mobile_SalesQuotation_CreateOrEditPost, L("CreateOrEditPermission"));
            mobileSaleSQuotation.CreateChildPermission(AppPermissions.Mobile_SalesQuotation_GetQuotationByCustomer, L("ViewPermission"));
            mobileSaleSQuotation.CreateChildPermission(AppPermissions.Mobile_SalesQuotation_DeleteQuotation, L("Delete"));
            #endregion
            #region "Mobile SalesProposalAccessories"
            #endregion
            #region "Mobile Sales Proposal"
            var mobileSalesProposal = moblie.CreateChildPermission(AppPermissions.Mobile_SalesProposal, L("SalesProposal"));
            mobileSalesProposal.CreateChildPermission(AppPermissions.Mobile_SalesProposal_CreateOrEditPost, L("CreateOrEditPermission"));
            mobileSalesProposal.CreateChildPermission(AppPermissions.Mobile_SalesProposal_GetProposalByCustomer, L("ViewPermission"));
            mobileSalesProposal.CreateChildPermission(AppPermissions.Mobile_SalesProposal_DeleteProposal, L("Delete"));
            #endregion
            #region "Mobile SalesToDoList"
            var mobileSalesToDoList = moblie.CreateChildPermission(AppPermissions.Mobile_SalesToDoList, L("SalesToDoList"));
            mobileSalesToDoList.CreateChildPermission(AppPermissions.Mobile_SalesToDoList_GetToDoList, L("ViewPermission"));
            mobileSalesToDoList.CreateChildPermission(AppPermissions.Mobile_SalesToDoList_Delete, L("Delete"));
            #endregion
            #region "Mobile SalesContact"
            var mobileSalesContact = moblie.CreateChildPermission(AppPermissions.Mobile_SalesContact, L("SalesContact"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_AddSalesCustomerContact, L("AddSalesCustomerContact"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_EditSalesCustomerContact, L("EditSalesCustomerContact"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_DeleteSalesCustomerContact, L("DeleteSalesCustomerContact"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_ListContact, L("ListContact"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_CreateSalesCustomerSupervisor, L("CreateSalesCustomerSupervisor"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_GetSalesCustomerSupervisorList, L("GetSalesCustomerSupervisorList"));
            mobileSalesContact.CreateChildPermission(AppPermissions.Mobile_SalesContact_CreateSalesCustomerTransactionInfo, L("CreateSalesCustomerTransactionInfo"));
            #endregion
            #region "Mobile SalesCarAttention"
            var mobileSalesCarAttention = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCarAttention, L("SalesCustomerCarAttensionPermission"));
            mobileSalesCarAttention.CreateChildPermission(AppPermissions.Mobile_SalesCarAttention_CreateCarAttention, L("CreatePermission"));
            mobileSalesCarAttention.CreateChildPermission(AppPermissions.Mobile_SalesCarAttention_CreateSalesCustomerVehicleInfo, L("EditPermission"));
            mobileSalesCarAttention.CreateChildPermission(AppPermissions.Mobile_SalesCarAttention_Delete, L("Delete"));
            mobileSalesCarAttention.CreateChildPermission(AppPermissions.Mobile_SalesCarAttention_ListCarAttention, L("ViewPermission"));
            #endregion
            #region "Mobile DeliveryActivity"
            var mobileDeliveryActivity = moblie.CreateChildPermission(AppPermissions.Mobile_DeliveryActivity, L("SalesDeliveryActivityPermissionMobile"));
            mobileDeliveryActivity.CreateChildPermission(AppPermissions.Mobile_DeliveryActivity_CreateOrEditDeliveryActivity, L("CreateOrEditPermission"));
            mobileDeliveryActivity.CreateChildPermission(AppPermissions.Mobile_DeliveryActivity_Delete, L("Delete"));
            mobileDeliveryActivity.CreateChildPermission(AppPermissions.Mobile_DeliveryActivity_GetListDeliveryActivityByCustomerId, L("ViewPermission"));
            #endregion
            #region "Mobile SalesContactReminder"
            var mobileSalesContactReminder = moblie.CreateChildPermission(AppPermissions.Mobile_SalesContactReminder, L("ContactReminder"));
            mobileSalesContactReminder.CreateChildPermission(AppPermissions.Mobile_SalesContactReminder_Edit, L("EditPermission"));
            mobileSalesContactReminder.CreateChildPermission(AppPermissions.Mobile_SalesContactReminder_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesCustomerGalleryFolder"
            var mobileSalesCustomerGalleryFolder = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCustomerGalleryFolder, L("SalesCustomerGalleryFolder"));
            mobileSalesCustomerGalleryFolder.CreateChildPermission(AppPermissions.Mobile_SalesCustomerGalleryFolder_CreateSalesCustomerGalleryFolder, L("CreatePermission"));
            mobileSalesCustomerGalleryFolder.CreateChildPermission(AppPermissions.Mobile_SalesCustomerGalleryFolder_EditSalesCustomerGalleryFolderName, L("EditPermission"));
            mobileSalesCustomerGalleryFolder.CreateChildPermission(AppPermissions.Mobile_SalesCustomerGalleryFolder_GetSalesCustomerGalleryFolderById, L("ViewPermission"));
            mobileSalesCustomerGalleryFolder.CreateChildPermission(AppPermissions.Mobile_SalesCustomerGalleryFolder_Delete, L("Delete"));
            #endregion
            #region "Mobile TestDriver"
            var mobileTestDriver = moblie.CreateChildPermission(AppPermissions.Mobile_TestDriver, L("TestDriver"));
            mobileTestDriver.CreateChildPermission(AppPermissions.Mobile_TestDriver_View, L("ViewPermission"));
            mobileTestDriver.CreateChildPermission(AppPermissions.Mobile_TestDriver_CreateOrEdit, L("CreateOrEditPermission"));
            mobileTestDriver.CreateChildPermission(AppPermissions.Mobile_TestDriver_Delete, L("Delete"));
            #endregion
            #region "Mobile SalesCarProduct"
            var mobileSalesCarProduct = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCarProduct, L("SalesCarProductPermissionMobile"));
            mobileSalesCarProduct.CreateChildPermission(AppPermissions.Mobile_SalesCarProduct_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesCarPromotion"
            var mobileSalesCarPromotion = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCarPromotion, L("SalesCarPromotionPermissionMobile"));
            mobileSalesCarPromotion.CreateChildPermission(AppPermissions.Mobile_SalesCarPromotion_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesCarInsurance"
            var mobileSalesCarInsurance = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCarInsurance, L("SalesCarInsurancePermissionMobile"));
            mobileSalesCarInsurance.CreateChildPermission(AppPermissions.Mobile_SalesCarInsurance_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesCarFinance"
            var mobileSalesCarFinance = moblie.CreateChildPermission(AppPermissions.Mobile_SalesCarFinance, L("SalesCarFinancePermissionMobile"));
            mobileSalesCarFinance.CreateChildPermission(AppPermissions.Mobile_SalesCarFinance_View, L("ViewPermission"));
            #endregion 
            #region "Mobile SalesVisualReport"
            var mobileSalesVisualReport = moblie.CreateChildPermission(AppPermissions.Mobile_SalesVisualReport, L("SalesVisualReportPermissonMobile"));
            mobileSalesVisualReport.CreateChildPermission(AppPermissions.Mobile_SalesVisualReport_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesInventoryManagement"
            var mobileSalesInventoryManagement = moblie.CreateChildPermission(AppPermissions.Mobile_SalesInventoryManagement, L("SalesInventoryManagementPermissonMobile"));
            mobileSalesInventoryManagement.CreateChildPermission(AppPermissions.Mobile_SalesInventoryManagement_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesWaitingForApproval"
            var mobileSalesWaitingForApproval = moblie.CreateChildPermission(AppPermissions.Mobile_SalesWaitingForApproval, L("SalesWaitingForApprovalPermissionMobile"));
            mobileSalesWaitingForApproval.CreateChildPermission(AppPermissions.Mobile_SalesWaitingForApproval_ApproveTestDrive, L("SalesWaitingForApprovalApproveTestDrive"));
            mobileSalesWaitingForApproval.CreateChildPermission(AppPermissions.Mobile_SalesWaitingForApproval_ApproveContract, L("SalesWaitingForApprovalApproveContract"));
            mobileSalesWaitingForApproval.CreateChildPermission(AppPermissions.Mobile_SalesWaitingForApproval_ApproveProposal, L("SalesWaitingForApprovalApproveProposal"));
            mobileSalesWaitingForApproval.CreateChildPermission(AppPermissions.Mobile_SalesWaitingForApproval_ApproveFreezeLoss, L("SalesWaitingForApprovalApproveFreezeLoss"));
            #endregion
            #region "Mobile SalesListSaleCar"
            var mobileSalesListSaleCar = moblie.CreateChildPermission(AppPermissions.Mobile_SalesListSaleCar, L("SalesListSaleCarPermissionMobile"));
            mobileSalesListSaleCar.CreateChildPermission(AppPermissions.Mobile_SalesListSaleCar_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesListFreezeCustomer"
            var mobileSalesListFreezeCustomer = moblie.CreateChildPermission(AppPermissions.Mobile_SalesListFreezeCustomer, L("SalesListFreezeCustomerPermissionMobile"));
            mobileSalesListFreezeCustomer.CreateChildPermission(AppPermissions.Mobile_SalesListFreezeCustomer_View, L("ViewPermission"));
            #endregion
            #region "Mobile SalesListLoseCustomer"
            var mobileSalesListLoseCustomer = moblie.CreateChildPermission(AppPermissions.Mobile_SalesListLoseCustomer, L("SalesListLoseCustomerPermissionMobile"));
            mobileSalesListLoseCustomer.CreateChildPermission(AppPermissions.Mobile_SalesListLoseCustomer_View, L("ViewPermission"));
            #endregion
            #endregion
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, tmssConsts.LocalizationSourceName);
        }
    }

}