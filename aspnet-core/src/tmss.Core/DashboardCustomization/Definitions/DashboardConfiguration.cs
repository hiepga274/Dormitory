using Abp.MultiTenancy;
using System.Collections.Generic;
using System.Linq;
using tmss.Authorization;

namespace tmss.DashboardCustomization.Definitions
{
    public class DashboardConfiguration : tmssServiceBase
    {
        public List<DashboardDefinition> DashboardDefinitions { get; } = new List<DashboardDefinition>();

        public List<WidgetDefinition> WidgetDefinitions { get; } = new List<WidgetDefinition>();

        public List<WidgetFilterDefinition> WidgetFilterDefinitions { get; } = new List<WidgetFilterDefinition>();

        public DashboardConfiguration()
        {
            #region FilterDefinitions

            // These are global filter which all widgets can use
            var dateRangeFilter = new WidgetFilterDefinition(
                tmssDashboardCustomizationConsts.Filters.FilterDateRangePicker,
                "FilterDateRangePicker"
            );
            var widgetFilter = new WidgetFilterDefinition(
            tmssDashboardCustomizationConsts.Filters.WidgetFilter, "FilterHelloWorld"
            );

            WidgetFilterDefinitions.Add(dateRangeFilter);
            WidgetFilterDefinitions.Add(widgetFilter);

            // Add your filters here

            #endregion

            #region WidgetDefinitions

            // Define Widgets

            #region TenantWidgets

            var tenantWidgetsDefaultPermission = new List<string>
            {
                AppPermissions.Pages_Tenant_Dashboard
            };

            var profitShare = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.ProfitShare,
                L("3.6. WidgetPaymentMethod"),
                side: MultiTenancySides.Tenant);
            profitShare.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetPaymentMethod);

            var overViewDataTable = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.OverviewDataTable,
              L("1. WidgetsOverViewDataTable"),
              side: MultiTenancySides.Tenant);
            overViewDataTable.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetOverTable);

            var detailPotentialCustomers = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.DetailPotentialCustomers,
                L("3.1. WidgetDetailPotentialCustomers"),
                side: MultiTenancySides.Tenant);
            detailPotentialCustomers.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetDetailPotentialCustomer);

            var reasonOfLost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ReasonOfLost,
               L("2.4. WidgetReasonOfLost"),
               side: MultiTenancySides.Tenant);
            reasonOfLost.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetReasonOfLost);

            var source = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.Source,
               L("3.2. WidgetSource"),
               side: MultiTenancySides.Tenant);
            source.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSource);
            var salesProcess = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.SalesProcess,
               L("3.7. WidgetSalesProcess"),
               side: MultiTenancySides.Tenant);
            salesProcess.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSaleProcess);

            var targetAcutalQty = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.TargetActualQty,
                L("2.2. WidgetTargetActualQty"),
                side: MultiTenancySides.Tenant);
            targetAcutalQty.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetTargetActualQty);

            var vehicleModel = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.VehicleModel,
                L("3.3. WidgetVehicleModel"),
                side: MultiTenancySides.Tenant);
            vehicleModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetGrade);
            var conversionRate = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ConversionRate,
                L("2.3. ConversionRate"),
               side: MultiTenancySides.Tenant);
            conversionRate.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetConversionRate);

            var conversionRateSalesPerson = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.ConversionRateSalesPerson,
               L("4.3. ConversionRateSalesPerson"),
              side: MultiTenancySides.Tenant
             );
            conversionRateSalesPerson.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetConversionRateSalesPerson);

            var province = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.Province,
               L("3.4. WidgetProvince"),
               side: MultiTenancySides.Tenant);
            province.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetProvince);
            var district = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.District,
                L("3.5. WidgetDistrict"),
                side: MultiTenancySides.Tenant);
            district.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetDistrict);
            var sourceInfor = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.SourceInfor,
                L("3.8. WidgetSourceInfor"),
                side: MultiTenancySides.Tenant);
            sourceInfor.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSourceInfo);
            var transitionStatus = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.TransitionStatus,
                L("2.1. WidgetTransitionStatus"),
                side: MultiTenancySides.Tenant);
            transitionStatus.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetTransitionStatus);

            var locateSalesPerson = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.LocateSalesPerson,
                L("4.2. WidgetLocateSalesPerson"),
                side: MultiTenancySides.Tenant);
            locateSalesPerson.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetLocateSalesPerson);

            var customersSold = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.CustomersSold,
               L("5.1. WidgetCustomersSold"),
               side: MultiTenancySides.Tenant);
            customersSold.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerSold);

            var paymentMethodOfCustomer = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.PaymentMethodOfCustomer,
              L("5.6. WidgetMethodOfCustomer"),
              side: MultiTenancySides.Tenant);
            paymentMethodOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetPaymentMethodOfCustomer);

            var districOfCustomer = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.DistricOfCustomer,
              L("5.5. WidgetDistricOfCustomer"),
              side: MultiTenancySides.Tenant);
            districOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetDistrictOfCustomer);

            var provinceOfCustomer = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Tenant.ProvinceOfCustomer,
             L("5.4. WidgetProvinceOfCustomer"),
             side: MultiTenancySides.Tenant);
            provinceOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetProvinceOfCutomer);

            var processOfCustomer = new WidgetDefinition(
            tmssDashboardCustomizationConsts.Widgets.Tenant.ProcessOfCustomer,
            L("5.7. WidgetProcessOfCustomer"),
            side: MultiTenancySides.Tenant);
            processOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetProcessOfCustomer);

            var sourceOfCustomer = new WidgetDefinition(
            tmssDashboardCustomizationConsts.Widgets.Tenant.SourceOfCustomer,
            L("5.2. WidgetSourceOfCustomer"),
            side: MultiTenancySides.Tenant);
            sourceOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSourceOfCustomer);

            var vehicleModelOfCustomer = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Tenant.VehicleModelOfCustomer,
           L("5.3. WidgetVehicleModelOfCustomer"),
           side: MultiTenancySides.Tenant);
            vehicleModelOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetVehicleOfCustomer);

            var averageConversionTime = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Tenant.AverageConversionTime,
           L("5.9. WidgetAverageConversionTime"),
           side: MultiTenancySides.Tenant);
            averageConversionTime.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetAverageConversiontime);

            var averageContactTime = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Tenant.AverageContactTime,
           L("5.10. WidgetAverageContactTime"),
           side: MultiTenancySides.Tenant);
            averageContactTime.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetAveragecontacttime);

            var listCustomer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ListCustomer,
               L("6. WidgetListCustomer"),
               side: MultiTenancySides.Tenant,
               permissions: tenantWidgetsDefaultPermission);
            var sourceInforOfCustomer = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Tenant.SourceInforOfCustomer,
                L("5.8. WidgetSourceInforOfCustomer"),
                side: MultiTenancySides.Tenant);
            sourceInforOfCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSourceInforOfCustomer);

            var followActivitySalesPerson = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.FollowActivitySalesPerson,
               L("10. WidgetFollowActivitySalesPerson"),
               side: MultiTenancySides.Tenant);
            followActivitySalesPerson.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetFollowActivitySalesPerson);

            var followActivitySalesPersonFirst = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.FollowActivitySalesPersonFirst,
               L("10. WidgetFollowActivitySalesPersonFirst"),
               side: MultiTenancySides.Tenant);
            followActivitySalesPersonFirst.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetFollowActivitySalesPerson);

            var followActivitySalesPersonSecond = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.FollowActivitySalesPersonSecond,
               L("10. WidgetFollowActivitySalesPersonSecond"),
               side: MultiTenancySides.Tenant);
            followActivitySalesPersonSecond.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetFollowActivitySalesPerson);

            var listSoldCar = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ListSoldCar,
               L("11. WidgetListSoldCar"),
               side: MultiTenancySides.Tenant);
            listSoldCar.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetListSoldCar);

            var numberOfConversions = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.NumberOfConversions,
               L("12. WidgetNumberOfConversions"),
               side: MultiTenancySides.Tenant);
            numberOfConversions.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetNumberOfConversions);

            var numberInquiryOverMonthForDealer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.NumberInquiryOverMonthForDealer,
               L("2.6. WidgetNumberInquiryOverMonthForDealer"),
               side: MultiTenancySides.Tenant);
            numberInquiryOverMonthForDealer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetNumberInquiryOverMonthForDealer);

            var resultConversionOverMonthForDealer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ResultConversionOverMonthForDealer,
               L("WidgetResultConversionOverMonthForDealer"),
               side: MultiTenancySides.Tenant);
            resultConversionOverMonthForDealer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetResultConversionOverMonthForDealer);

            var listInquiryFromTMVForDealer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ListInquiryFromTMVForDealer,
               L("2.7. WidgetListInquiryFromTMVForDealer"),
               side: MultiTenancySides.Tenant);
            listInquiryFromTMVForDealer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetListInquiryFromTMVForDealer);

            var statisticsInquiryOverGroupForDealer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.StatisticsInquiryOverGroupForDealer,
               L("2.8. WidgetStatisticsInquiryOverGroupForDealer"),
               side: MultiTenancySides.Tenant);
            statisticsInquiryOverGroupForDealer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetStatisticsInquiryOverGroupForDealer);

            var structureGeneralCustomer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.StructureGeneralCustomer,
               L("WidgetStructureGeneralCustomer"),
               side: MultiTenancySides.Tenant);
            structureGeneralCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetStructureGeneralCustomer);

            var gereralCustomerByDept = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.GereralCustomerByDept,
               L("WidgetGereralCustomerByDept"),
               side: MultiTenancySides.Tenant);
            gereralCustomerByDept.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetGereralCustomerByDept);

            var gereralCustomerByWeek = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.GereralCustomerByWeek,
               L("WidgetGereralCustomerByWeek"),
               side: MultiTenancySides.Tenant);
            gereralCustomerByWeek.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetGereralCustomerByWeek);

            var gereralCustomerByMonth = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.GereralCustomerByMonth,
               L("WidgetGereralCustomerByMonth"),
               side: MultiTenancySides.Tenant);
            gereralCustomerByMonth.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetGereralCustomerByMonth);

            var structureSourceCustomer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.StructureSourceCustomer,
               L("WidgetStructureSourceCustomer"),
               side: MultiTenancySides.Tenant);
            structureSourceCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetStructureSourceCustomer);

            var summarySourceCustomer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.SummarySourceCustomer,
               L("WidgetSummarySourceCustomer"),
               side: MultiTenancySides.Tenant);
            summarySourceCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSummarySourceCustomer);

            var summaryVehicleCustomer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.SummaryVehicleCustomer,
               L("WidgetSummaryVehicleCustomer"),
               side: MultiTenancySides.Tenant);
            summaryVehicleCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSummaryVehicleCustomer);

            var lostVehicleCustomer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.LostVehicleCustomer,
               L("WidgetLostVehicleCustomer"),
               side: MultiTenancySides.Tenant);
            lostVehicleCustomer.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetLostVehicleCustomer);

            var groupCustomerDRA = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.GroupCustomerDRA,
               L("WidgetGroupCustomerDRA"),
               side: MultiTenancySides.Tenant);
            groupCustomerDRA.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetGroupCustomerDRA);

            var groupCustomerProvince = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.GroupCustomerProvince,
               L("WidgetGroupCustomerProvince"),
               side: MultiTenancySides.Tenant);
            groupCustomerProvince.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetGroupCustomerProvince);

            var customerPRMSource = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerPRMSource,
               L("WidgetCustomerPRMSource"),
               side: MultiTenancySides.Tenant);
            customerPRMSource.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerPRMSource);

            var customerPRMModel = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerPRMModel,
               L("WidgetCustomerPRMModel"),
               side: MultiTenancySides.Tenant);
            customerPRMModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerPRMModel);

            var customerPRMSourceModel = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerPRMSourceModel,
               L("WidgetCustomerPRMSourceModel"),
               side: MultiTenancySides.Tenant);
            customerPRMSourceModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerPRMSourceModel);

            var contactDetailHwc = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.ContactDetailHwc,
              L("WidgetContactDetailHwc"),
              side: MultiTenancySides.Tenant);
            contactDetailHwc.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetContactDetailHwc);
            
            var contactGeneralHwc = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.ContactGeneralHwc,
              L("WidgetContactGeneralHwc"),
              side: MultiTenancySides.Tenant);
            contactGeneralHwc.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetContactGeneralHwc);
            
            var movementImCwd = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.MovementImCwd,
              L("WidgetMovementImCwd"),
              side: MultiTenancySides.Tenant);
            movementImCwd.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetMovementImCwd);
            
            var movementSale = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.MovementSale,
              L("WidgetMovementSale"),
              side: MultiTenancySides.Tenant);
            movementSale.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetMovementSale);

            var cwdPlanByModel = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CwdPlanByModel,
              L("WidgetCwdPlanByModel"),
              side: MultiTenancySides.Tenant);
            cwdPlanByModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCwdPlanByModel);
            
            var saleActualPlanByModel = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.SaleActualPlanByModel,
              L("WidgetSaleActualPlanByModel"),
              side: MultiTenancySides.Tenant);
            saleActualPlanByModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSaleActualPlanByModel);
            
            var cwdPlanByDayOrWeekly = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CwdPlanByDayOrWeekly,
              L("WidgetCwdPlanByDayOrWeekly"),
              side: MultiTenancySides.Tenant);
            cwdPlanByDayOrWeekly.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCwdPlanByDayOrWeekly);

            var salePlanByDayOrWeekly = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.SalePlanByDayOrWeekly,
              L("WidgetSalePlanByDayOrWeekly"),
              side: MultiTenancySides.Tenant);
            salePlanByDayOrWeekly.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSalePlanByDayOrWeekly);
            
            var detailByModelGrade = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.DetailByModelGrade,
              L("WidgetDetailByModelGrade"),
              side: MultiTenancySides.Tenant);
            detailByModelGrade.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetDetailByModelGrade);
            
            var imConversionTotalByHotness = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.ImConversionTotalByHotness,
              L("WidgetImConversionTotalByHotness"),
              side: MultiTenancySides.Tenant);
            imConversionTotalByHotness.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetImConversionTotalByHotness);
            
            var conversionCwdByHotness = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.ConversionCwdByHotness,
              L("WidgetConversionCwdByHotness"),
              side: MultiTenancySides.Tenant);
            conversionCwdByHotness.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetConversionCwdByHotness);
            
            var convesionRateByHotness = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.ConvesionRateByHotness,
              L("WidgetConvesionRateByHotness"),
              side: MultiTenancySides.Tenant);
            convesionRateByHotness.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetConvesionRateByHotness);
            
            var totalLossReason = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.TotalLossReason,
              L("WidgetTotalLossReason"),
              side: MultiTenancySides.Tenant);
            totalLossReason.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetTotalLossReason);
            
            var lossByModel = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.LossByModel,
              L("WidgetLossByModel"),
              side: MultiTenancySides.Tenant);
            lossByModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByModel); 
            
            var lossByPrivateReasons = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.LossByPrivateReasons,
              L("WidgetLossByPrivateReasons"),
              side: MultiTenancySides.Tenant);
            lossByPrivateReasons.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByPrivateReasons);
            
            var lossByOtherDlrsReasons = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.LossByOtherDlrsReasons,
              L("WidgetLossByOtherDlrsReasons"),
              side: MultiTenancySides.Tenant);
            lossByOtherDlrsReasons.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByOtherDlrsReasons);
            
            var lossByOtherMakerReasons = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.LossByOtherMakerReasons,
              L("WidgetLossByOtherMakerReasons"),
              side: MultiTenancySides.Tenant);
            lossByOtherMakerReasons.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetLossByOtherMakerReasons);
            
            var customerBySourceTotal = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerBySourceTotal,
              L("WidgetCustomerBySourceTotal"),
              side: MultiTenancySides.Tenant);
            customerBySourceTotal.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerBySourceTotal);
            
            var customerBySalepersonSource = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerBySalepersonSource,
              L("WidgetCustomerBySalepersonSource"),
              side: MultiTenancySides.Tenant);
            customerBySalepersonSource.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerBySalepersonSource);
            
            var customerByDealerSource = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerByDealerSource,
              L("WidgetCustomerByDealerSource"),
              side: MultiTenancySides.Tenant);
            customerByDealerSource.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerByDealerSource);
            
            var customerByTmvSource = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerByTmvSource,
              L("WidgetCustomerByTmvSource"),
              side: MultiTenancySides.Tenant);
            customerByTmvSource.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerByTmvSource);
            
            var customerByTotalModels = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.CustomerByTotalModels,
              L("WidgetCustomerByTotalModels"),
              side: MultiTenancySides.Tenant);
            customerByTotalModels.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetCustomerByTotalModels);
            
            var newCustomerByGrade = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.NewCustomerByGrade,
              L("WidgetNewCustomerByGrade"),
              side: MultiTenancySides.Tenant);
            newCustomerByGrade.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetNewCustomerByGrade);
            
            var remainingCustomerByGrade = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.RemainingCustomerByGrade,
              L("WidgetRemainingCustomerByGrade"),
              side: MultiTenancySides.Tenant);
            remainingCustomerByGrade.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetRemainingCustomerByGrade);
            
            var allCustomerByHotness = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.AllCustomerByHotness,
              L("WidgetAllCustomerByHotness"),
              side: MultiTenancySides.Tenant);
            allCustomerByHotness.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetAllCustomerByHotness);
            
            var allOfCustomerByModel = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Tenant.AllOfCustomerByModel,
              L("WidgetAllOfCustomerByModel"),
              side: MultiTenancySides.Tenant);
            allOfCustomerByModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetAllOfCustomerByModel);

            var vehicleSalesPerson = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.VehicleSalesPerson,
               L("2.5. WidgetVehicleSalesPerson"),
               side: MultiTenancySides.Tenant);
            vehicleSalesPerson.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetVehicleSalesPerson);


            var actualAndCwdPlanByModel = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Tenant.ActualAndCwdWithPlanByModel,
               L("WidgetActualAndCwdWithPlanByModel"),
               side: MultiTenancySides.Tenant);
            actualAndCwdPlanByModel.Permissions.Add(AppPermissions.Pages_Tenant_Dashboard_WidgetSalesActualAndCWDPlanByModel);
            
            WidgetDefinitions.Add(vehicleSalesPerson);
            WidgetDefinitions.Add(reasonOfLost);
            WidgetDefinitions.Add(source);
            WidgetDefinitions.Add(salesProcess);
            WidgetDefinitions.Add(detailPotentialCustomers);
            WidgetDefinitions.Add(profitShare);
            WidgetDefinitions.Add(overViewDataTable);
            WidgetDefinitions.Add(customersSold);
            WidgetDefinitions.Add(paymentMethodOfCustomer);
            WidgetDefinitions.Add(districOfCustomer);
            WidgetDefinitions.Add(provinceOfCustomer);
            WidgetDefinitions.Add(processOfCustomer);
            WidgetDefinitions.Add(sourceOfCustomer);
            WidgetDefinitions.Add(vehicleModelOfCustomer);
            WidgetDefinitions.Add(averageConversionTime);
            WidgetDefinitions.Add(averageContactTime);
            WidgetDefinitions.Add(sourceInforOfCustomer);
            WidgetDefinitions.Add(followActivitySalesPerson);
            WidgetDefinitions.Add(followActivitySalesPersonFirst);
            WidgetDefinitions.Add(followActivitySalesPersonSecond);

            // Add your tenant side widgets here
            WidgetDefinitions.Add(targetAcutalQty);
            WidgetDefinitions.Add(vehicleModel);
            WidgetDefinitions.Add(conversionRate);
            WidgetDefinitions.Add(conversionRateSalesPerson);
            WidgetDefinitions.Add(district);
            WidgetDefinitions.Add(province);
            WidgetDefinitions.Add(sourceInfor);
            WidgetDefinitions.Add(transitionStatus);
            WidgetDefinitions.Add(locateSalesPerson);
            WidgetDefinitions.Add(listCustomer);
            WidgetDefinitions.Add(listSoldCar);
            WidgetDefinitions.Add(numberOfConversions);
            WidgetDefinitions.Add(numberInquiryOverMonthForDealer);
            WidgetDefinitions.Add(resultConversionOverMonthForDealer);
            WidgetDefinitions.Add(listInquiryFromTMVForDealer);
            WidgetDefinitions.Add(statisticsInquiryOverGroupForDealer); 
            WidgetDefinitions.Add(structureGeneralCustomer);
            WidgetDefinitions.Add(gereralCustomerByDept);
            WidgetDefinitions.Add(gereralCustomerByWeek);
            WidgetDefinitions.Add(gereralCustomerByMonth);
            WidgetDefinitions.Add(structureSourceCustomer); 
            WidgetDefinitions.Add(summarySourceCustomer); 
            WidgetDefinitions.Add(summaryVehicleCustomer);
            WidgetDefinitions.Add(lostVehicleCustomer); 
            WidgetDefinitions.Add(groupCustomerDRA);
            WidgetDefinitions.Add(groupCustomerProvince);
            WidgetDefinitions.Add(customerPRMSource);
            WidgetDefinitions.Add(customerPRMModel);
            WidgetDefinitions.Add(customerPRMSourceModel);
            WidgetDefinitions.Add(contactDetailHwc);
            WidgetDefinitions.Add(contactGeneralHwc);
            WidgetDefinitions.Add(movementImCwd);
            WidgetDefinitions.Add(movementSale);
            WidgetDefinitions.Add(cwdPlanByModel);
            WidgetDefinitions.Add(saleActualPlanByModel);
            WidgetDefinitions.Add(cwdPlanByDayOrWeekly);
            WidgetDefinitions.Add(salePlanByDayOrWeekly);
            WidgetDefinitions.Add(detailByModelGrade);
            WidgetDefinitions.Add(imConversionTotalByHotness);
            WidgetDefinitions.Add(conversionCwdByHotness);
            WidgetDefinitions.Add(convesionRateByHotness);
            WidgetDefinitions.Add(totalLossReason);
            WidgetDefinitions.Add(lossByModel);
            WidgetDefinitions.Add(lossByPrivateReasons);
            WidgetDefinitions.Add(lossByOtherDlrsReasons);
            WidgetDefinitions.Add(lossByOtherMakerReasons);
            WidgetDefinitions.Add(customerBySourceTotal);
            WidgetDefinitions.Add(customerBySalepersonSource);
            WidgetDefinitions.Add(customerByDealerSource);
            WidgetDefinitions.Add(customerByTmvSource);
            WidgetDefinitions.Add(customerByTotalModels);
            WidgetDefinitions.Add(newCustomerByGrade);
            WidgetDefinitions.Add(remainingCustomerByGrade);
            WidgetDefinitions.Add(allCustomerByHotness);
            WidgetDefinitions.Add(allOfCustomerByModel);
            WidgetDefinitions.Add(actualAndCwdPlanByModel);
            #endregion

            #region HostWidgets

            var HostWidgetsDefaultPermission = new List<string>
            {
                AppPermissions.Pages_Administration_Host_Dashboard
            };

            var profitShareHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.ProfitShareHost,
                L("3.6. WidgetPaymentMethod"),
                side: MultiTenancySides.Host);
            profitShareHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetPaymentMethodForTMV);

            var overViewDataTableHost = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.OverviewDataTableHost,
              L("1. WidgetsOverViewDataTable"),
              side: MultiTenancySides.Host);
            overViewDataTableHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetOverTable);

            var detailPotentialCustomersHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.DetailPotentialCustomersHost,
                L("3.1. WidgetDetailPotentialCustomers"),
                side: MultiTenancySides.Host);
            detailPotentialCustomersHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDetailPotentialCustomerForTMV);

            var reasonOfLostHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ReasonOfLostHost,
               L("2.4. WidgetReasonOfLost"),
               side: MultiTenancySides.Host);
            reasonOfLostHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetReasonOfLost);

            var sourceHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.SourceHost,
               L("3.2. WidgetSource"),
               side: MultiTenancySides.Host);
            sourceHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceChartForTMV);
            var salesProcessHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.SalesProcessHost,
               L("3.7. WidgetSalesProcess"),
               side: MultiTenancySides.Host);
            salesProcessHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProcessForTMV);
            var targetAcutalQtyHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.TargetActualQtyHost,
                L("2.2. WidgetTargetActualQty"),
                side: MultiTenancySides.Host);
            targetAcutalQtyHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetTargetActualQty);

            var vehicleModelHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.VehicleModelHost,
                L("3.3. WidgetVehicleModel"),
                side: MultiTenancySides.Host);
            vehicleModelHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetGradeChartForTMV);
            var conversionRateHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ConversionRateHost,
                L("2.3. ConversionRate"),
               side: MultiTenancySides.Host);
            conversionRateHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRate);

            var provinceHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ProvinceHost,
               L("3.4. WidgetProvince"),
               side: MultiTenancySides.Host);
            provinceHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProvinceForTMV);
            var districtHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.DistrictHost,
                L("3.5. WidgetDistrict"),
                side: MultiTenancySides.Host);
            districtHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDistrictForTMV);
            var sourceInforHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.SourceInforHost,
                L("3.8. WidgetSourceInfor"),
                side: MultiTenancySides.Host);
            sourceInforHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceInforForTMV);
            var transitionStatusHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.TransitionStatusHost,
                L("2.1. WidgetTransitionStatus"),
                side: MultiTenancySides.Host);
            transitionStatusHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetTransitionStatus);

            var customersSoldHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.CustomersSoldHost,
               L("5.1. WidgetCustomersSold"),
               side: MultiTenancySides.Host);
            customersSoldHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomersSoldForTMV);

            var paymentMethodOfCustomerHost = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.PaymentMethodOfCustomerHost,
              L("5.6. WidgetMethodOfCustomer"),
              side: MultiTenancySides.Host);
            paymentMethodOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetPaymentMethodOfCustomerForTMV);

            var districOfCustomerHost = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.DistricOfCustomerHost,
              L("5.5. WidgetDistricOfCustomer"),
              side: MultiTenancySides.Host);
            districOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDistrictOfCustomerForTMV);

            var provinceOfCustomerHost = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.ProvinceOfCustomerHost,
             L("5.4. WidgetProvinceOfCustomer"),
             side: MultiTenancySides.Host);
            provinceOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProvinceOfCutomerForTMV);

            var processOfCustomerHost = new WidgetDefinition(
            tmssDashboardCustomizationConsts.Widgets.Host.ProcessOfCustomerHost,
            L("5.7. WidgetProcessOfCustomer"),
            side: MultiTenancySides.Host);
            processOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetProcessOfCustomerForTMV);

            var sourceOfCustomerHost = new WidgetDefinition(
            tmssDashboardCustomizationConsts.Widgets.Host.SourceOfCustomerHost,
            L("5.2. WidgetSourceOfCustomer"),
            side: MultiTenancySides.Host);
            sourceOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceOfCustomerForTMV);

            var vehicleModelOfCustomerHost = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Host.VehicleModelOfCustomerHost,
           L("5.3. WidgetVehicleModelOfCustomer"),
           side: MultiTenancySides.Host);
            vehicleModelOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetVehicleOfCustomerForTMV);

            var averageConversionTimeHost = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Host.AverageConversionTimeHost,
           L("5.9. WidgetAverageConversionTime"),
           side: MultiTenancySides.Host);
            averageConversionTimeHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAverageConversiontimeForTMV);

            var averageContactTimeHost = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Host.AverageContactTimeHost,
           L("5.10. WidgetAverageContactTime"),
           side: MultiTenancySides.Host);
            averageContactTimeHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAveragecontacttimeForTMV);

            var listCustomerHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ListCustomerHost,
               L("6. WidgetListCustomer"),
               side: MultiTenancySides.Host,
               permissions: HostWidgetsDefaultPermission);
            var sourceInforOfCustomerHost = new WidgetDefinition(
                tmssDashboardCustomizationConsts.Widgets.Host.SourceInforOfCustomerHost,
                L("5.8. WidgetSourceInforOfCustomer"),
                side: MultiTenancySides.Host);
            sourceInforOfCustomerHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetSourceInforOfCustomerForTMV);

            var numberOfConversionsHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.NumberOfConversionsHost,
               L("12. WidgetNumberOfConversions"),
               side: MultiTenancySides.Host,
               permissions: HostWidgetsDefaultPermission);
            var numberInquiryOfMonthHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.NumberInquiryOfMonthHost,
               L("WidgetNumberInquiryOfMonth"),
               side: MultiTenancySides.Host);
            numberInquiryOfMonthHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNumberInquiryOfMonth);

            var conversionRateOverMonthHost = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ConversionRateOverMonthHost,
               L("WidgetConversionRateOverMonthHost"),
               side: MultiTenancySides.Host);
            conversionRateOverMonthHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateOverMonth);

            var conversionSourceOverMonth = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ConversionSourceOverMonth,
               L("WidgetConversionSourceOverMonth"),
               side: MultiTenancySides.Host);
            conversionSourceOverMonth.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionSourceOverMonth);

            var statisticsInquiryOverDealer = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.StatisticsInquiryOverDealer,
               L("WidgetStatisticsInquiryOverDealer"),
               side: MultiTenancySides.Host);
            statisticsInquiryOverDealer.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetStatisticsInquiryOverDealer);

            var resultConversionOverMonth = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ResultConversionOverMonth,
               L("WidgetResultConversionOverMonth"),
               side: MultiTenancySides.Host);
            resultConversionOverMonth.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetResultConversionOverMonth);

            var listInquiryFromTMV = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ListInquiryFromTMV,
               L("WidgetListInquiryFromTMV"),
               side: MultiTenancySides.Host);
            listInquiryFromTMV.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetListInquiryFromTMV);

            var inquiryTMVReasonOfNC = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.InquiryTMVReasonOfNC,
               L("WidgetInquiryTMVReasonOfNC"),
               side: MultiTenancySides.Host);
            inquiryTMVReasonOfNC.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetInquiryTMVReasonOfNC);

            var leadByAge = new WidgetDefinition(
           tmssDashboardCustomizationConsts.Widgets.Host.LeadByAge,
           L("WidgetLeadByAge"),
           side: MultiTenancySides.Host);
            leadByAge.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLeadByAge);

            var weeklyTrackingByAge = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.WeeklyTrackingByAge,
               L("WidgetWeeklyTrackingByAge"),
               side: MultiTenancySides.Host);
            weeklyTrackingByAge.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetWeeklyTrackingByAge);

            var newlyAddedLeadStatusBySource = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.NewlyAddedLeadStatusBySource,
               L("WidgetNewlyAddedLeadStatusBySource"),
               side: MultiTenancySides.Host);
            newlyAddedLeadStatusBySource.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusBySource);

            var newlyAddedLeadStatusByRegion = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.NewlyAddedLeadStatusByRegion,
               L("WidgetNewlyAddedLeadStatusByRegion"),
               side: MultiTenancySides.Host);
            newlyAddedLeadStatusByRegion.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusByRegion);

            var newlyAddedLeadStatusByRegionAndSource = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.NewlyAddedLeadStatusByRegionAndSource,
               L("WidgetNewlyAddedLeadStatusByRegionAndSource"),
               side: MultiTenancySides.Host);
            newlyAddedLeadStatusByRegionAndSource.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusByRegionAndSource);

            var viewContactedBySource = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ViewContactedBySource,
               L("WidgetViewContactedBySource"),
               side: MultiTenancySides.Host);
            viewContactedBySource.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetViewContactedBySource);

            var viewSuccessContactedBySource = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ViewSuccessContactedBySource,
               L("WidgetViewSuccessContactedBySource"),
               side: MultiTenancySides.Host);
            viewSuccessContactedBySource.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetViewSuccessContactedBySource);

            var contactAndContactSuccessRate = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ContactAndContactSuccessRate,
               L("WidgetContactAndContactSuccessRate"),
               side: MultiTenancySides.Host);
            contactAndContactSuccessRate.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetContactAndContactSuccessRate);

            var conversionRateOfInquiryToSR = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.ConversionRateOfInquiryToSR,
               L("WidgetConversionRateOfInquiryToSR"),
               side: MultiTenancySides.Host);
            conversionRateOfInquiryToSR.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateOfInquiryToSR);

            var vehicleSalesPersonHost = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.VehicleSalesPersonHost,
              L("13.WidgetVehicleSalesPerson"),
              side: MultiTenancySides.Host);
            vehicleSalesPersonHost.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetVehicleSalesPersonForTMV);

            var rankingByDealers = new WidgetDefinition(
               tmssDashboardCustomizationConsts.Widgets.Host.RankingByDealers,
               L("WidgetRankingByDealers"),
               side: MultiTenancySides.Host);
            rankingByDealers.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetRankingByDealers);

            var averageLeadTimeFromGeneration = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.AverageLeadTimeFromGeneration,
              L("WidgetAverageLeadTimeFromGeneration"),
              side: MultiTenancySides.Host);
            averageLeadTimeFromGeneration.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAverageLeadTimeFromGeneration);

            var leadTimeByDealersFromGeneration = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.LeadTimeByDealersFromGeneration,
              L("WidgetLeadTimeByDealersFromGeneration"),
              side: MultiTenancySides.Host);
            leadTimeByDealersFromGeneration.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLeadTimeByDealersFromGeneration);

            var deepDiveAnalysisListOfSelectedLeadsCWD = new WidgetDefinition(
              tmssDashboardCustomizationConsts.Widgets.Host.DeepDiveAnalysisListOfSelectedLeadsCWD,
              L("WidgetDeepDiveAnalysisListOfSelectedLeadsCWD"),
              side: MultiTenancySides.Host);
            deepDiveAnalysisListOfSelectedLeadsCWD.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsCWD);

            var deepDiveAnalysisListOfSelectedLeadsInquiry = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.DeepDiveAnalysisListOfSelectedLeadsInquiry,
             L("WidgetDeepDiveAnalysisListOfSelectedLeadsInquiry"),
             side: MultiTenancySides.Host);
            deepDiveAnalysisListOfSelectedLeadsInquiry.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsInquiry);

            var deepDiveAnalysisListOfSelectedLeadsContactedFailed = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.DeepDiveAnalysisListOfSelectedLeadsContactedFailed,
             L("WidgetDeepDiveAnalysisListOfSelectedLeadsContactedFailed"),
             side: MultiTenancySides.Host);
            deepDiveAnalysisListOfSelectedLeadsContactedFailed.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsContactedFailed);

            var conversionRateForTMV = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.ConversionRateForTMV,
             L("WidgetConversionRateForTMV"),
             side: MultiTenancySides.Host);
            conversionRateForTMV.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateForTMV);

            var locateDealerForTMV = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.LocateDealerForTMV,
             L("WidgetLocateDealerForTMV"),
             side: MultiTenancySides.Host);
            locateDealerForTMV.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLocateDealerForTMV);
            
            var statisticsInquiryOverMonthForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.StatisticsInquiryOverMonthForTmv,
             L("WidgetStatisticsInquiryOverMonthForTmv"),
             side: MultiTenancySides.Host);
            statisticsInquiryOverMonthForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetStatisticsInquiryOverMonthForTmv);
            
            var movementImCwdForTMV = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.MovementImCwdForTMV,
             L("WidgetMovementImCwd"),
             side: MultiTenancySides.Host);
            movementImCwdForTMV.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetMovementImCwdForTmv);
            
            var allOfCustomerByModelForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.AllOfCustomerByModelForTmv,
             L("WidgetAllOfCustomerByModel"),
             side: MultiTenancySides.Host);
            allOfCustomerByModelForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAllOfCustomerByModelForTmv);
            
            var allCustomerByHotnessForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.AllCustomerByHotnessForTmv,
             L("WidgetAllCustomerByHotness"),
             side: MultiTenancySides.Host);
            allCustomerByHotnessForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetAllCustomerByHotnessForTmv);
            
            var customerBySourceTotalForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.CustomerBySourceTotalForTmv,
             L("WidgetCustomerBySourceTotal"),
             side: MultiTenancySides.Host);
            customerBySourceTotalForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerBySourceTotalForTmv);
            
            var customerBySalepersonSourceForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.CustomerBySalepersonSourceForTmv,
             L("WidgetCustomerBySalepersonSource"),
             side: MultiTenancySides.Host);
            customerBySalepersonSourceForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerBySalepersonSourceForTmv);

            var customerByDealerSourceForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.CustomerByDealerSourceForTmv,
             L("WidgetCustomerByDealerSource"),
             side: MultiTenancySides.Host);
            customerByDealerSourceForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerByDealerSourceForTmv);
            
            var customerByTmvSourceForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.CustomerByTmvSourceForTmv,
             L("WidgetCustomerByTmvSource"),
             side: MultiTenancySides.Host);
            customerByTmvSourceForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerByTmvSourceForTmv);
            
            var totalLossReasonForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.TotalLossReasonForTmv,
             L("WidgetTotalLossReason"),
             side: MultiTenancySides.Host);
            totalLossReasonForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetTotalLossReasonForTmv);
            
            var lossByPrivateReasonsForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.LossByPrivateReasonsForTmv,
             L("WidgetLossByPrivateReasons"),
             side: MultiTenancySides.Host);
            lossByPrivateReasonsForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossByPrivateReasonsForTmv);
            
            var lossOtherDlrsReasonForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.LossOtherDlrsReasonForTmv,
             L("WidgetLossByOtherDlrsReasons"),
             side: MultiTenancySides.Host);
            lossOtherDlrsReasonForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossOtherDlrsReasonForTmv);
            
            var lossByOttherMakerReasonsForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.LossByOttherMakerReasonsForTmv,
             L("WidgetLossByOtherMakerReasons"),
             side: MultiTenancySides.Host);
            lossByOttherMakerReasonsForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossByOttherMakerReasonsForTmv);
            
            var lossByModelForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.LossByModelForTmv,
             L("WidgetLossByModel"),
             side: MultiTenancySides.Host);
            lossByModelForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetLossByModelForTmv);
            
            var contractGeneralHwcForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.ContractGeneralHwcForTmv,
             L("WidgetContactGeneralHwc"),
             side: MultiTenancySides.Host);
            contractGeneralHwcForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetContractGeneralHwcForTmv);
            
            var followActivitySalesPrsonForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.FollowActivitySalesPrsonForTmv,
             L("WidgetFollowActivitySalesPerson"),
             side: MultiTenancySides.Host);
            followActivitySalesPrsonForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetFollowActivitySalesPrsonForTmv);
            
            var followActivitySalesPersonSecondForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.FollowActivitySalesPersonSecondForTmv,
             L("WidgetFollowActivitySalesPersonFirst"),
             side: MultiTenancySides.Host);
            followActivitySalesPersonSecondForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetFollowActivitySalesPrsonForTmv);
            
            var followActivitySalesPersonFirstForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.FollowActivitySalesPersonFirstForTmv,
             L("WidgetFollowActivitySalesPersonSecond"),
             side: MultiTenancySides.Host);
            followActivitySalesPersonFirstForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetFollowActivitySalesPrsonForTmv);
            
            var customerByTotalModelForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.CustomerByTotalModelForTmv,
             L("WidgetCustomerByTotalModels"),
             side: MultiTenancySides.Host);
            customerByTotalModelForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetCustomerByTotalModelForTmv);
            
            var remainingCustomerByGradeForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.RemainingCustomerByGradeForTmv,
             L("WidgetRemainingCustomerByGrade"),
             side: MultiTenancySides.Host);
            remainingCustomerByGradeForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetRemainingCustomerByGradeForTmv);
            
            var newCustomerByGradeForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.NewCustomerByGradeForTmv,
             L("WidgetNewCustomerByGrade"),
             side: MultiTenancySides.Host);
            newCustomerByGradeForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetNewCustomerByGradeForTmv);
            
            var imConversionTotalByHotnessForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.ImConversionTotalByHotnessForTmv,
             L("WidgetImConversionTotalByHotness"),
             side: MultiTenancySides.Host);
            imConversionTotalByHotnessForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetImConversionTotalByHotnessForTmv); 
            
            var conversionCwdByHotnessForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.ConversionCwdByHotnessForTmv,
             L("WidgetConversionCwdByHotness"),
             side: MultiTenancySides.Host);
            conversionCwdByHotnessForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionCwdByHotnessForTmv); 
            
            var conversionRateByHotnessForTmv = new WidgetDefinition(
             tmssDashboardCustomizationConsts.Widgets.Host.ConversionRateByHotnessForTmv,
             L("WidgetConvesionRateByHotness"),
             side: MultiTenancySides.Host);
            conversionRateByHotnessForTmv.Permissions.Add(AppPermissions.Pages_Administration_Host_Dashboard_WidgetConversionRateByHotnessForTmv);

            WidgetDefinitions.Add(reasonOfLostHost);
            WidgetDefinitions.Add(sourceHost);
            WidgetDefinitions.Add(salesProcessHost);
            WidgetDefinitions.Add(detailPotentialCustomersHost);
            WidgetDefinitions.Add(overViewDataTableHost);
            WidgetDefinitions.Add(customersSoldHost);
            WidgetDefinitions.Add(paymentMethodOfCustomerHost);
            WidgetDefinitions.Add(districOfCustomerHost);
            WidgetDefinitions.Add(provinceOfCustomerHost);
            WidgetDefinitions.Add(processOfCustomerHost);
            WidgetDefinitions.Add(sourceOfCustomerHost);
            WidgetDefinitions.Add(vehicleModelOfCustomerHost);
            WidgetDefinitions.Add(averageConversionTimeHost);
            WidgetDefinitions.Add(averageContactTimeHost);
            WidgetDefinitions.Add(sourceInforOfCustomerHost);

            // Add your Host side widgets here
            WidgetDefinitions.Add(vehicleSalesPersonHost);
            WidgetDefinitions.Add(targetAcutalQtyHost);
            WidgetDefinitions.Add(vehicleModelHost);
            WidgetDefinitions.Add(conversionRateHost);
            WidgetDefinitions.Add(districtHost);
            WidgetDefinitions.Add(provinceHost);
            WidgetDefinitions.Add(sourceInforHost);
            WidgetDefinitions.Add(transitionStatusHost);
            WidgetDefinitions.Add(listCustomerHost);
            WidgetDefinitions.Add(numberOfConversionsHost);
            WidgetDefinitions.Add(numberInquiryOfMonthHost);
            WidgetDefinitions.Add(conversionRateOverMonthHost);
            WidgetDefinitions.Add(conversionSourceOverMonth);
            WidgetDefinitions.Add(statisticsInquiryOverDealer);
            WidgetDefinitions.Add(resultConversionOverMonth);
            WidgetDefinitions.Add(listInquiryFromTMV);
            WidgetDefinitions.Add(inquiryTMVReasonOfNC);
            WidgetDefinitions.Add(leadByAge);
            WidgetDefinitions.Add(weeklyTrackingByAge);
            WidgetDefinitions.Add(newlyAddedLeadStatusBySource);
            WidgetDefinitions.Add(newlyAddedLeadStatusByRegion);
            WidgetDefinitions.Add(newlyAddedLeadStatusByRegionAndSource);
            WidgetDefinitions.Add(viewContactedBySource);
            WidgetDefinitions.Add(viewSuccessContactedBySource);
            WidgetDefinitions.Add(contactAndContactSuccessRate);
            WidgetDefinitions.Add(conversionRateOfInquiryToSR);
            WidgetDefinitions.Add(rankingByDealers);
            WidgetDefinitions.Add(averageLeadTimeFromGeneration); 
            WidgetDefinitions.Add(leadTimeByDealersFromGeneration); 
            WidgetDefinitions.Add(deepDiveAnalysisListOfSelectedLeadsCWD); 
            WidgetDefinitions.Add(deepDiveAnalysisListOfSelectedLeadsInquiry);
            WidgetDefinitions.Add(deepDiveAnalysisListOfSelectedLeadsContactedFailed); 
            WidgetDefinitions.Add(conversionRateForTMV);
            WidgetDefinitions.Add(locateDealerForTMV);
            WidgetDefinitions.Add(statisticsInquiryOverMonthForTmv);
            WidgetDefinitions.Add(movementImCwdForTMV);
            WidgetDefinitions.Add(allOfCustomerByModelForTmv);
            WidgetDefinitions.Add(allCustomerByHotnessForTmv);
            WidgetDefinitions.Add(customerBySourceTotalForTmv);
            WidgetDefinitions.Add(customerBySalepersonSourceForTmv);
            WidgetDefinitions.Add(customerByDealerSourceForTmv);
            WidgetDefinitions.Add(customerByTmvSourceForTmv);
            WidgetDefinitions.Add(totalLossReasonForTmv);
            WidgetDefinitions.Add(lossByPrivateReasonsForTmv);
            WidgetDefinitions.Add(lossOtherDlrsReasonForTmv);
            WidgetDefinitions.Add(lossByOttherMakerReasonsForTmv);
            WidgetDefinitions.Add(lossByModelForTmv);
            WidgetDefinitions.Add(contractGeneralHwcForTmv);
            WidgetDefinitions.Add(followActivitySalesPrsonForTmv);
            WidgetDefinitions.Add(followActivitySalesPersonSecondForTmv);
            WidgetDefinitions.Add(followActivitySalesPersonFirstForTmv);
            WidgetDefinitions.Add(customerByTotalModelForTmv);
            WidgetDefinitions.Add(remainingCustomerByGradeForTmv);
            WidgetDefinitions.Add(newCustomerByGradeForTmv);
            WidgetDefinitions.Add(imConversionTotalByHotnessForTmv);
            WidgetDefinitions.Add(conversionCwdByHotnessForTmv);
            WidgetDefinitions.Add(conversionRateByHotnessForTmv);

            // Add your host side widgets here

            #endregion

            #endregion

            #region DashboardDefinitions

            // Create dashboard
            var defaultTenantDashboard = new DashboardDefinition(
                tmssDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard,
                new List<string>
                {
                    overViewDataTable.Id, transitionStatus.Id, targetAcutalQty.Id, conversionRate.Id, reasonOfLost.Id, detailPotentialCustomers.Id, source.Id, vehicleModel.Id, province.Id, district.Id, salesProcess.Id, sourceInfor.Id, locateSalesPerson.Id, conversionRateSalesPerson.Id, customersSold.Id, sourceOfCustomer.Id, vehicleModelOfCustomer.Id, provinceOfCustomer.Id, districOfCustomer.Id, paymentMethodOfCustomer.Id, processOfCustomer.Id, averageConversionTime.Id, averageContactTime.Id,profitShare.Id,sourceInforOfCustomer.Id, followActivitySalesPerson.Id, listSoldCar.Id, numberOfConversions.Id, numberInquiryOverMonthForDealer.Id, vehicleSalesPerson.Id, resultConversionOverMonthForDealer.Id, listInquiryFromTMVForDealer.Id, statisticsInquiryOverGroupForDealer.Id, structureGeneralCustomer.Id, gereralCustomerByDept.Id, gereralCustomerByWeek.Id, gereralCustomerByMonth.Id, structureSourceCustomer.Id, summarySourceCustomer.Id, summaryVehicleCustomer.Id, groupCustomerDRA.Id, lostVehicleCustomer.Id, groupCustomerProvince.Id, customerPRMSource.Id, customerPRMModel.Id, customerPRMSourceModel.Id,contactDetailHwc.Id,contactGeneralHwc.Id,movementImCwd.Id,movementSale.Id,cwdPlanByModel.Id,saleActualPlanByModel.Id,cwdPlanByDayOrWeekly.Id,salePlanByDayOrWeekly.Id,detailByModelGrade.Id,imConversionTotalByHotness.Id,conversionCwdByHotness.Id,convesionRateByHotness.Id,totalLossReason.Id,lossByModel.Id,lossByPrivateReasons.Id,lossByOtherDlrsReasons.Id,lossByOtherMakerReasons.Id,customerBySourceTotal.Id,customerBySalepersonSource.Id,customerByDealerSource.Id,customerByTmvSource.Id,customerByTotalModels.Id,newCustomerByGrade.Id,remainingCustomerByGrade.Id,allCustomerByHotness.Id,allOfCustomerByModel.Id,actualAndCwdPlanByModel.Id,followActivitySalesPersonFirst.Id,followActivitySalesPersonSecond.Id
                });

            DashboardDefinitions.Add(defaultTenantDashboard);

            var defaultHostDashboard = new DashboardDefinition(
                tmssDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard,
                new List<string>
                {
                     overViewDataTableHost.Id, transitionStatusHost.Id, targetAcutalQtyHost.Id, conversionRateHost.Id, reasonOfLostHost.Id, detailPotentialCustomersHost.Id, sourceHost.Id, vehicleModelHost.Id, provinceHost.Id, districtHost.Id, salesProcessHost.Id, sourceInforHost.Id,  customersSoldHost.Id, sourceOfCustomerHost.Id, vehicleModelOfCustomerHost.Id, provinceOfCustomerHost.Id, districOfCustomerHost.Id, paymentMethodOfCustomerHost.Id, processOfCustomerHost.Id, averageConversionTimeHost.Id, averageContactTimeHost.Id,profitShareHost.Id,sourceInforOfCustomerHost.Id, numberInquiryOfMonthHost.Id, conversionRateOverMonthHost.Id, conversionSourceOverMonth.Id, statisticsInquiryOverDealer.Id, resultConversionOverMonth.Id, listInquiryFromTMV.Id, inquiryTMVReasonOfNC.Id, leadByAge.Id, weeklyTrackingByAge.Id, newlyAddedLeadStatusBySource.Id, newlyAddedLeadStatusByRegion.Id, newlyAddedLeadStatusByRegionAndSource.Id, viewContactedBySource.Id, viewSuccessContactedBySource.Id, contactAndContactSuccessRate.Id, conversionRateOfInquiryToSR.Id, vehicleSalesPersonHost.Id, rankingByDealers.Id, averageLeadTimeFromGeneration.Id, leadTimeByDealersFromGeneration.Id, deepDiveAnalysisListOfSelectedLeadsCWD.Id, deepDiveAnalysisListOfSelectedLeadsInquiry.Id, deepDiveAnalysisListOfSelectedLeadsContactedFailed.Id, conversionRateForTMV.Id, locateDealerForTMV.Id,statisticsInquiryOverMonthForTmv.Id,movementImCwdForTMV.Id,allOfCustomerByModelForTmv.Id,allCustomerByHotnessForTmv.Id,customerBySourceTotalForTmv.Id,customerBySalepersonSourceForTmv.Id,customerByDealerSourceForTmv.Id,customerByTmvSourceForTmv.Id,totalLossReasonForTmv.Id,lossByPrivateReasonsForTmv.Id,lossOtherDlrsReasonForTmv.Id,lossByOttherMakerReasonsForTmv.Id,lossByModelForTmv.Id,contractGeneralHwcForTmv.Id,followActivitySalesPrsonForTmv.Id,followActivitySalesPersonSecondForTmv.Id,followActivitySalesPersonFirstForTmv.Id,customerByTotalModelForTmv.Id,remainingCustomerByGradeForTmv.Id,newCustomerByGradeForTmv.Id,imConversionTotalByHotnessForTmv.Id,conversionCwdByHotnessForTmv.Id,conversionRateByHotnessForTmv.Id
                });

            DashboardDefinitions.Add(defaultHostDashboard);

            // Add your dashboard definiton here

            #endregion

        }

    }
}
