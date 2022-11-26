namespace tmss.Authorization
{
    /// <summary>
    /// Defines string constants for application's permission names.
    /// <see cref="AppAuthorizationProvider"/> for permission definitions.
    /// </summary>
    public static class AppPermissions
    {

        public const string Pages_Sales_FbLeads = "Pages.Sales.FbLeads";
        public const string Pages_Sales_FbDelete = "Pages.Sales.FbLeads.Delete";

        public const string Pages_SalesCustomerVehicleInfo = "Pages.SalesCustomerVehicleInfo";
        public const string Pages_SalesCustomerVehicleInfo_Create = "Pages.SalesCustomerVehicleInfo.Create";
        public const string Pages_SalesCustomerVehicleInfo_Edit = "Pages.SalesCustomerVehicleInfo.Edit";
        public const string Pages_SalesCustomerVehicleInfo_Delete = "Pages.SalesCustomerVehicleInfo.Delete";

        public const string Pages_SalesCustomerTransactionInfo = "Pages.SalesCustomerTransactionInfo";
        public const string Pages_SalesCustomerTransactionInfo_ApproveTransaction = "Pages.SalesCustomerTransactionInfo.GetListCustomerTranferLossFreezeApprover";
        public const string Pages_SalesCustomerTransactionInfo_GetListCustomerTranferLossFreezeApprover = "Pages.SalesCustomerTransactionInfo.ApproveTransaction";

        public const string Pages_SalesCustomerTestDrive = "Pages.SalesCustomerTestDrive";
        public const string Pages_SalesCustomerTestDrive_Create = "Pages.SalesCustomerTestDrive.Create";
        public const string Pages_SalesCustomerTestDrive_Edit = "Pages.SalesCustomerTestDrive.Edit";
        public const string Pages_SalesCustomerTestDrive_Delete = "Pages.SalesCustomerTestDrive.Delete";

        public const string Pages_SalesCustomerManagerComment = "Pages.SalesCustomerManagerComment";
        public const string Pages_SalesCustomerManagerComment_Create = "Pages.SalesCustomerManagerComment.Create";
        public const string Pages_SalesCustomerManagerComment_Edit = "Pages.SalesCustomerManagerComment.Edit";
        public const string Pages_SalesCustomerManagerComment_Delete = "Pages.SalesCustomerManagerComment.Delete";

        public const string Pages_SalesCustomerAppointment = "Pages.SalesCustomerAppointment";
        public const string Pages_SalesCustomerAppointment_Get = "Pages.SalesCustomerAppointment.Get";
        public const string Pages_SalesCustomerAppointment_Create = "Pages.SalesCustomerAppointment.Create";
        public const string Pages_SalesCustomerAppointment_Edit = "Pages.SalesCustomerAppointment.Edit";
        public const string Pages_SalesCustomerAppointment_Delete = "Pages.SalesCustomerAppointment.Delete";

        public const string Pages_SalesCustomer = "Pages.SalesCustomer";
        public const string Pages_SalesCustomer_View = "Pages.SalesCustomer.View";
        public const string Pages_SalesCustomer_Create = "Pages.SalesCustomer.Create";
        public const string Pages_SalesCustomer_Edit = "Pages.SalesCustomer.Edit";
        public const string Pages_SalesCustomer_Delete = "Pages.SalesCustomer.Delete";
        public const string Pages_SalesCustomer_View_Duplicate_Customer = "Pages.SalesCustomer.ViewDuplicateCustomer";
        public const string Pages_SalesCustomer_Import_Encode_Customer_Phone = "Pages.SalesCustomer.ImportEncodeCustomerPhone";

        public const string Pages_SalesCustomerSellUsedCar = "Pages.SalesCustomerSellUsedCar";
        public const string Pages_SalesCustomerSellUsedCar_View = "Pages.SalesCustomerSellUsedCar.View";
        public const string Pages_SalesCustomerSellUsedCar_Edit = "Pages.SalesCustomerSellUsedCar.Edit";

        public const string Pages_SalesCustomer_ChangeStatus = "Pages.SalesCustomer.ChangeStatus";
        public const string Pages_SalesCustomer_RequestApprove = "Pages.SalesCustomer.RequestApprove";
        public const string Pages_SalesCustomer_IsView = "Pages.SalesCustomer.IsView";

        public const string Pages_SalesToDoList = "Pages.SalesToDoList";
        public const string Pages_SalesToDoList_Create = "Pages.SalesToDoList.Create";
        public const string Pages_SalesToDoList_Edit = "Pages.SalesToDoList.Edit";
        public const string Pages_SalesToDoList_Delete = "Pages.SalesToDoList.Delete";

        public const string Pages_SalesVehicleUIO = "Pages.SalesVehicleUio";
        public const string Pages_SalesVehicleUIO_Search = "Pages.SalesVehicleUio.Search";
        public const string Pages_SalesVehicleUIO_Create = "Pages.SalesVehicleUio.Create";
        public const string Pages_SalesVehicleUIO_Edit = "Pages.SalesBehicleUio.Edit";
        public const string Pages_SalesVehicleUIO_Delete = "Pages.SalesVehicleUio.Delete";

        public const string Pages_SalesDriveTest = "Pages.SalesDriveTest";


        //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

        public const string Pages = "Pages";
        public const string Mobile = "Mobile";
        public const string WebsiteApi = "WebsiteApi";


        public const string Pages_API_Dealers = "Pages.APIDealers";
        public const string Pages_API_Dealers_GetCustomerInformation = "Pages.APIDealers.GetCustomerInfo";
        public const string Pages_API_Dealers_UpdateCustomerStatus = "Pages.APIDealers.UpdateCustomerStatus";
        public const string Pages_API_Dealers_GetContractInformation = "Pages.APIDealers.GetContractInformation";
        public const string Pages_API_Dealers_UpdateContractInformation = "Pages.APIDealers.UpdateContractInformation";
        public const string Pages_API_Dealers_CreateNewLeadCustomer = "Pages.APIDealers.CreateNewLeadCustomer";

        public const string Pages_DemoUiComponents = "Pages.DemoUiComponents";
        public const string Pages_Administration = "Pages.Administration";

        public const string Pages_Administration_Roles = "Pages.Administration.Roles";
        public const string Pages_Administration_Roles_Create = "Pages.Administration.Roles.Create";
        public const string Pages_Administration_Roles_Edit = "Pages.Administration.Roles.Edit";
        public const string Pages_Administration_Roles_Delete = "Pages.Administration.Roles.Delete";

        public const string Pages_Administration_Users = "Pages.Administration.Users";
        public const string Pages_Administration_Users_Create = "Pages.Administration.Users.Create";
        public const string Pages_Administration_Users_Edit = "Pages.Administration.Users.Edit";
        public const string Pages_Administration_Users_Delete = "Pages.Administration.Users.Delete";
        public const string Pages_Administration_Users_ChangePermissions = "Pages.Administration.Users.ChangePermissions";
        public const string Pages_Administration_Users_Impersonation = "Pages.Administration.Users.Impersonation";
        public const string Pages_Administration_Users_Unlock = "Pages.Administration.Users.Unlock";

        public const string Pages_Administration_Languages = "Pages.Administration.Languages";
        public const string Pages_Administration_Languages_Create = "Pages.Administration.Languages.Create";
        public const string Pages_Administration_Languages_Edit = "Pages.Administration.Languages.Edit";
        public const string Pages_Administration_Languages_Delete = "Pages.Administration.Languages.Delete";
        public const string Pages_Administration_Languages_ChangeTexts = "Pages.Administration.Languages.ChangeTexts";

        public const string Pages_Administration_AuditLogs = "Pages.Administration.AuditLogs";


        public const string Pages_Administration_HangfireDashboard = "Pages.Administration.HangfireDashboard";

        public const string Pages_Administration_UiCustomization = "Pages.Administration.UiCustomization";

        public const string Pages_Administration_WebhookSubscription = "Pages.Administration.WebhookSubscription";
        public const string Pages_Administration_WebhookSubscription_Create = "Pages.Administration.WebhookSubscription.Create";
        public const string Pages_Administration_WebhookSubscription_Edit = "Pages.Administration.WebhookSubscription.Edit";
        public const string Pages_Administration_WebhookSubscription_ChangeActivity = "Pages.Administration.WebhookSubscription.ChangeActivity";
        public const string Pages_Administration_WebhookSubscription_Detail = "Pages.Administration.WebhookSubscription.Detail";
        public const string Pages_Administration_Webhook_ListSendAttempts = "Pages.Administration.Webhook.ListSendAttempts";
        public const string Pages_Administration_Webhook_ResendWebhook = "Pages.Administration.Webhook.ResendWebhook";

        public const string Pages_Administration_DynamicParameterValue = "Pages.Administration.DynamicParameterValue";
        public const string Pages_Administration_DynamicParameterValue_Create = "Pages.Administration.DynamicParameterValue.Create";
        public const string Pages_Administration_DynamicParameterValue_Edit = "Pages.Administration.DynamicParameterValue.Edit";
        public const string Pages_Administration_DynamicParameterValue_Delete = "Pages.Administration.DynamicParameterValue.Delete";

      
    

        public const string Pages_Administration_IpAdressLog = "Pages.Administration.IpAdressLog";
        public const string Pages_Administration_IpAdressLog_Create = "Pages.Administration.IpAdressLog.Create";



     

        //TENANT-SPECIFIC PERMISSIONS

        public const string Pages_Tenant_Dashboard = "Pages.Tenant.Dashboard";

        public const string Pages_Administration_Tenant_Settings = "Pages.Administration.Tenant.Settings";

        public const string Pages_Administration_Tenant_SubscriptionManagement = "Pages.Administration.Tenant.SubscriptionManagement";

        //HOST-SPECIFIC PERMISSIONS

        public const string Pages_Editions = "Pages.Editions";
        public const string Pages_Editions_Create = "Pages.Editions.Create";
        public const string Pages_Editions_Edit = "Pages.Editions.Edit";
        public const string Pages_Editions_Delete = "Pages.Editions.Delete";
        public const string Pages_Editions_MoveTenantsToAnotherEdition = "Pages.Editions.MoveTenantsToAnotherEdition";

        public const string Pages_Tenants = "Pages.Tenants";
        public const string Pages_Tenants_Create = "Pages.Tenants.Create";
        public const string Pages_Tenants_Edit = "Pages.Tenants.Edit";
        public const string Pages_Tenants_ChangeFeatures = "Pages.Tenants.ChangeFeatures";
        public const string Pages_Tenants_Delete = "Pages.Tenants.Delete";
        public const string Pages_Tenants_Impersonation = "Pages.Tenants.Impersonation";

        public const string Pages_Administration_Host_Maintenance = "Pages.Administration.Host.Maintenance";
        public const string Pages_Administration_Host_Settings = "Pages.Administration.Host.Settings";
        public const string Pages_Administration_Host_Dashboard = "Pages.Administration.Host.Dashboard";
        public const string Pages_Sales_Menu_Contract_Tmss_Management_For_TMV = "Pages.Sales.Menu.Tmss.Mannagement.For.TMV";
        public const string Pages_Sales_Contract_Cancel_For_TMV = "Pages.Sales.Contract.Cancel.For.TMV";
        public const string Pages_Sales_Contract_Change_For_TMV = "Pages.Sales.Contract.Change.For.TMV";
        public const string Pages_Sales_Contract_Delivery_For_TMV = "Pages.Sales.Contract.Delivery.For.TMV";



        #region "Course"
        public const string Pages_Master_Sales_Course = "Pages.Master.Sales.MstSleCourse";
        public const string Pages_Master_Sales_Course_Search = "Pages.Master.Sales.MstSleCourse.Search";
        public const string Pages_Master_Sales_Course_Create = "Pages.Master.Sales.MstSleCourse.Create";
        public const string Pages_Master_Sales_Course_Edit = "Pages.Master.Sales.MstSleCourse.Edit";
        public const string Pages_Master_Sales_Course_Delete = "Pages.Master.Sales.MstSleCourse.Delete";
        #endregion
        #region "Teacher"
        public const string Pages_Master_Sales_Teacher = "Pages.Master.Sales.MstSleTeacher";
        public const string Pages_Master_Sales_Teacher_Search = "Pages.Master.Sales.MstSleTeacher.Search";
        public const string Pages_Master_Sales_Teacher_Create = "Pages.Master.Sales.MstSleTeacher.Create";
        public const string Pages_Master_Sales_Teacher_Edit = "Pages.Master.Sales.MstSleTeacher.Edit";
        public const string Pages_Master_Teacher_Delete = "Pages.Master.Sales.MstSleTeacher.Delete";
        #endregion
        #region Sales Person
        public const string Pages_Sales_SalesPerson = "Pages.Sales.SalesPerson";
        public const string Pages_Sales_SalesPerson_Search = "Pages.Sales.SalesPerson.Search";
        public const string Pages_Sales_SalesPerson_Create = "Pages.Sales.SalesPerson.Create";
        public const string Pages_Sales_SalesPerson_Edit = "Pages.Sales.SalesPerson.Edit";
        public const string Pages_Sales_SalesPerson_Delete = "Pages.Sales.SalesPerson.Delete";
        #endregion

        #region SalesCustomerPhoneDuplicateDealer
        public const string Pages_Sales_SalesCustomerPhoneDuplicateDealer = "Pages.Sales.SalesCustomerPhoneDuplicateDealer";
        public const string Pages_Sales_SalesCustomerPhoneDuplicateDealer_Search = "Pages.Sales.SalesCustomerPhoneDuplicateDealer.Search";
        public const string Pages_Sales_SalesCustomerPhoneDuplicateDealer_Create = "Pages.Sales.SalesCustomerPhoneDuplicateDealer.Create";
        public const string Pages_Sales_SalesCustomerPhoneDuplicateDealer_Edit = "Pages.Sales.SalesCustomerPhoneDuplicateDealer.Edit";
        public const string Pages_Sales_SalesCustomerPhoneDuplicateDealer_Delete = "Pages.Sales.SalesCustomerPhoneDuplicateDealer.Delete";
        #endregion
        
        #region DashboardChartGroupConfig
        public const string Pages_Sales_DashboardChartGroupConfig = "Pages.Sales.DashboardChartGroupConfig";

        #region DashboardChartList
        public const string Pages_Sales_DashboardChartList = "Pages.Sales.DashboardChartGroupConfig.DashboardChartList";
        public const string Pages_Sales_DashboardChartListView = "Pages.Sales.DashboardChartGroupConfig.DashboardChartList.View";
        public const string Pages_Sales_DashboardChartListEdit = "Pages.Sales.DashboardChartGroupConfig.DashboardChartList.Edit";
        #endregion

        #region DashboardChartGroup
        public const string Pages_Sales_DashboardChartGroup = "Pages.Sales.DashboardChartGroupConfig.DashboardChartGroup";
        public const string Pages_Sales_DashboardChartGroupView = "Pages.Sales.DashboardChartGroupConfig.DashboardChartGroup.View";
        public const string Pages_Sales_DashboardChartGroupEdit = "Pages.Sales.DashboardChartGroupConfig.DashboardChartGroup.Edit";

        public const string Pages_Sales_DashboardChartGroupDetailView = "Pages.Sales.DashboardChartGroupConfig.DashboardChartGroupDetail.View";
        public const string Pages_Sales_DashboardChartGroupDetailEdit = "Pages.Sales.DashboardChartGroupConfig.DashboardChartGroupDetail.Edit";
        #endregion

        #endregion

        #region "Master"
        public const string Pages_Master = "Pages.Master";

        #region "Common"
        public const string Pages_Master_Common = "Pages.Master.Common";

        #endregion

        #region "Vehicle Info"
        public const string Pages_Master_Vehicle_Info = "Pages.Master.VehicleInfo";

        #endregion

        #region "Accessories"
        public const string Pages_Master_Accessories = "Pages.Master.Accessories";
        #endregion

        #region "Test Driver"
        public const string Pages_Master_TestDriver = "Pages.Master.TestDriver";
        #endregion

        #region "Insurance"
        public const string Pages_Master_Insurance = "Pages.Master.Insurance";
        #endregion

        #region "Finance"
        public const string Pages_Master_Finance = "Pages.Master.Finance";
        #endregion

        #region "Delivery"
        public const string Pages_Master_Delivery = "Pages.Master.Delivery";
        #endregion

        #region "Report Config"
        public const string Pages_Master_Sales_Report = "Pages.Master.Report";
        public const string Pages_Master_Sales_Report_Search = "Pages.Master.Report.Search";
        public const string Pages_Master_Sales_Report_Create = "Pages.Master.Report.Create";
        public const string Pages_Master_Sales_Report_Edit = "Pages.Master.Report.Edit";
        public const string Pages_Master_Sales_Report_Delete = "Pages.Master.Report.Delete";
        #endregion

        #region " Report Category"
        public const string Pages_Master_Sales_ReportCategory = "Pages.Master.ReportCategory";
        public const string Pages_Master_Sales_ReportCategory_Search = "Pages.Master.ReportCategory.Search";
        public const string Pages_Master_Sales_ReportCategory_Create = "Pages.Master.ReportCategory.Create";
        public const string Pages_Master_Sales_ReportCategory_Edit = "Pages.Master.ReportCategory.Edit";
        public const string Pages_Master_Sales_ReportCategory_Delete = "Pages.Master.ReportCategory.Delete";
        #endregion

        #region " Report Proposal"
        public const string Pages_Master_Sales_ReportProposal_Create = "Pages.Master.ReportProposal.Create";
        public const string Pages_Master_Sales_ReportProposal_Edit = "Pages.Master.ReportProposal.Edit";
        #endregion

        #region "Report Config Define"
        public const string Pages_Master_Sales_Report_Definition = "Pages.Master.ReportDefinition";
        public const string Pages_Master_Sales_Report_Definition_Search = "Pages.Master.ReportDefinition.Search";
        public const string Pages_Master_Sales_Report_Definition_Create = "Pages.Master.ReportDefinition.Create";
        public const string Pages_Master_Sales_Report_Definition_Edit = "Pages.Master.ReportDefinition.Edit";
        public const string Pages_Master_Sales_Report_Definition_Delete = "Pages.Master.ReportDefinition.Delete";
        #endregion

        #region "Ip Management"
        public const string Pages_Master_Sales_IP_Managemnet = "Pages.Master.IpManagement";
        public const string Pages_Master_Sales_IP_Managemnet_Search = "Pages.Master.IpManagement.Search";
        public const string Pages_Master_Sales_IP_Managemnet_Create = "Pages.Master.IpManagement.Create";
        public const string Pages_Master_Sales_IP_Managemnet_Edit = "Pages.Master.IpManagement.Edit";
        public const string Pages_Master_Sales_IP_Managemnet_Delete = "Pages.Master.IpManagement.Delete";
        #endregion
        
        #region "Tỉ lệ chi phí"
        public const string Pages_Master_Sales_Ratio_Cost = "Pages.Master.RatioCost";
        public const string Pages_Master_Sales_Ratio_Cost_Search = "Pages.Master.RatioCost.Search";
        public const string Pages_Master_Sales_Ratio_Cost_Create = "Pages.Master.RatioCost.Create";
        public const string Pages_Master_Sales_Ratio_Cost_Edit = "Pages.Master.RatioCost.Edit";
        public const string Pages_Master_Sales_Ratio_Cost_Delete = "Pages.Master.RatioCost.Delete";
        #endregion 
        #region "mẫu báo cáo đề xuất bh"
        public const string Pages_Master_Sales_Proposal_Report = "Pages.Master.ReportProposal";
        public const string Pages_Master_Sales_Proposal_Report_Search = "Pages.Master.ReportProposal.Search";
        public const string Pages_Master_Sales_Proposal_Report_Create = "Pages.Master.ReportProposal.Create";
        public const string Pages_Master_Sales_Proposal_Report_Edit = "Pages.Master.ReportProposal.Edit";
        public const string Pages_Master_Sales_Proposal_Report_Delete = "Pages.Master.ReportProposal.Delete";
        #endregion
        
        #region "Chi phí bảo dưỡng"
        public const string Pages_Master_Sales_Maintenance_Price = "Pages.Master.MaintenancePrice";
        public const string Pages_Master_Sales_Maintenance_Price_Search = "Pages.Master.MaintenancePrice.Search";
        public const string Pages_Master_Sales_Maintenance_Price_Create = "Pages.Master.MaintenancePrice.Create";
        public const string Pages_Master_Sales_Maintenance_Price_Edit = "Pages.Master.MaintenancePrice.Edit";
        public const string Pages_Master_Sales_Maintenance_Price_Delete = "Pages.Master.MaintenancePrice.Delete";
        #endregion

        #region "MstSleProductFinanceQuesstion"
        public const string Pages_Master_Sales_Finance_Knowledge = "Pages.Master.FinanceKnowledge";
        public const string Pages_Master_Sales_Insurance_Knowledge = "Pages.Master.InsuranceKnowledge";
        public const string Pages_Master_Sales_Product_Finance_Question = "Pages.Master.ProductFinanceQuestion";
        public const string Pages_Master_Sales_Product_Finance_Question_Search = "Pages.Master.ProductFinanceQuestion.Search";
        public const string Pages_Master_Sales_Product_Finance_Question_Create = "Pages.Master.ProductFinanceQuestion.Create";
        public const string Pages_Master_Sales_Product_Finance_Question_Edit = "Pages.Master.ProductFinanceQuestion.Edit";
        public const string Pages_Master_Sales_Product_Finance_Question_Delete = "Pages.Master.ProductFinanceQuestion.Delete";
        #endregion

        #region "MstSleProductInsuranceQuesstion"
        public const string Pages_Master_Sales_Product_Insurance_Question = "Pages.Master.ProductInsuranceQuestion";
        public const string Pages_Master_Sales_Product_Insurance_Question_Search = "Pages.Master.ProductInsuranceQuestion.Search";
        public const string Pages_Master_Sales_Product_Insurance_Question_Create = "Pages.Master.ProductInsuranceQuestion.Create";
        public const string Pages_Master_Sales_Product_Insurance_Question_Edit = "Pages.Master.ProductInsuranceQuestion.Edit";
        public const string Pages_Master_Sales_Product_Insurance_Question_Delete = "Pages.Master.ProductInsuranceQuestion.Delete";
        #endregion

        #region "Product Finance Type"
        public const string Pages_Master_Sales_ProductFinanceType = "Pages.Master.Sales.MstSleProductFinanceType";
        public const string Pages_Master_Sales_ProductFinanceType_Search = "Pages.Master.Sales.MstSleProductFinanceType.Search";
        public const string Pages_Master_Sales_ProductFinanceType_Create = "Pages.Master.Sales.MstSleProductFinanceType.Create";
        public const string Pages_Master_Sales_ProductFinanceType_Edit = "Pages.Master.Sales.MstSleProductFinanceType.Edit";
        public const string Pages_Master_Sales_ProductFinanceType_Delete = "Pages.Master.Sales.MstSleProductFinanceType.Delete";
        #endregion

        #region "Product Insurance Type"
        public const string Pages_Master_Sales_ProductInsuranceType = "Pages.Master.Sales.MstSleProductInsuranceType";
        public const string Pages_Master_Sales_ProductInsuranceType_Search = "Pages.Master.Sales.MstSleProductInsuranceType.Search";
        public const string Pages_Master_Sales_ProductInsuranceType_Create = "Pages.Master.Sales.MstSleProductInsuranceType.Create";
        public const string Pages_Master_Sales_ProductInsuranceType_Edit = "Pages.Master.Sales.MstSleProductInsuranceType.Edit";
        public const string Pages_Master_Sales_ProductInsuranceType_Delete = "Pages.Master.Sales.MstSleProductInsuranceType.Delete";
        #endregion

        #region "Product Finance Category"
        public const string Pages_Master_Sales_ProductFinanceCategory = "Pages.Master.Sales.MstSleProductFinanceCategory";
        public const string Pages_Master_Sales_ProductFinanceCategory_Search = "Pages.Master.Sales.MstSleProductFinanceCategory.Search";
        public const string Pages_Master_Sales_ProductFinanceCategory_Create = "Pages.Master.Sales.MstSleProductFinanceCategory.Create";
        public const string Pages_Master_Sales_ProductFinanceCategory_Edit = "Pages.Master.Sales.MstSleProductFinanceCategory.Edit";
        public const string Pages_Master_Sales_ProductFinanceCategory_Delete = "Pages.Master.Sales.MstSleProductFinanceCategory.Delete";
        #endregion

        #region "Product Insurance Category"
        public const string Pages_Master_Sales_ProductInsuranceCategory = "Pages.Master.Sales.MstSleProductInsuranceCategory";
        public const string Pages_Master_Sales_ProductInsuranceCategory_Search = "Pages.Master.Sales.MstSleProductInsuranceCategory.Search";
        public const string Pages_Master_Sales_ProductInsuranceCategory_Create = "Pages.Master.Sales.MstSleProductInsuranceCategory.Create";
        public const string Pages_Master_Sales_ProductInsuranceCategory_Edit = "Pages.Master.Sales.MstSleProductInsuranceCategory.Edit";
        public const string Pages_Master_Sales_ProductInsuranceCategory_Delete = "Pages.Master.Sales.MstSleProductInsuranceCategory.Delete";
        #endregion

        #region "Insurance Level"
        public const string Pages_Master_Sales_InsuranceLevel = "Pages.Master.Sales.MstSleInsuranceLevel";
        public const string Pages_Master_Sales_InsuranceLevel_Search = "Pages.Master.Sales.MstSleInsuranceLevel.Search";
        public const string Pages_Master_Sales_InsuranceLevel_Create = "Pages.Master.Sales.MstSleInsuranceLevel.Create";
        public const string Pages_Master_Sales_InsuranceLevel_Edit = "Pages.Master.Sales.MstSleInsuranceLevel.Edit";
        public const string Pages_Master_Sales_InsuranceLevel_Delete = "Pages.Master.Sales.MstSleInsuranceLevel.Delete";
        #endregion

        #region "Product Finance Answer"
        public const string Pages_Master_Sales_ProductFinanceAnswer = "Pages.Master.Sales.MstSleProductFinanceAnswer";
        public const string Pages_Master_Sales_ProductFinanceAnswer_Search = "Pages.Master.Sales.MstSleProductFinanceAnswer.Search";
        public const string Pages_Master_Sales_ProductFinanceAnswer_Create = "Pages.Master.Sales.MstSleProductFinanceAnswer.Create";
        public const string Pages_Master_Sales_ProductFinanceAnswer_Edit = "Pages.Master.Sales.MstSleProductFinanceAnswer.Edit";
        public const string Pages_Master_Sales_ProductFinanceAnswer_Delete = "Pages.Master.Sales.MstSleProductFinanceAnswer.Delete";
        #endregion

        #region "Product Insurance Answer"
        public const string Pages_Master_Sales_ProductInsuranceAnswer = "Pages.Master.Sales.MstSleProductInsuranceAnswer";
        public const string Pages_Master_Sales_ProductInsuranceAnswer_Search = "Pages.Master.Sales.MstSleProductInsuranceAnswer.Search";
        public const string Pages_Master_Sales_ProductInsuranceAnswer_Create = "Pages.Master.Sales.MstSleProductInsuranceAnswer.Create";
        public const string Pages_Master_Sales_ProductInsuranceAnswer_Edit = "Pages.Master.Sales.MstSleProductInsuranceAnswer.Edit";
        public const string Pages_Master_Sales_ProductInsuranceAnswer_Delete = "Pages.Master.Sales.MstSleProductInsuranceAnswer.Delete";
        #endregion

        #region "Product Finance Introduce"
        public const string Pages_Master_Sales_ProductFinanceIntroduce = "Pages.Master.Sales.MstSleProductFinanceIntroduce";
        public const string Pages_Master_Sales_ProductFinanceIntroduce_Search = "Pages.Master.Sales.MstSleProductFinanceIntroduce.Search";
        public const string Pages_Master_Sales_ProductFinanceIntroduce_Create = "Pages.Master.Sales.MstSleProductFinanceIntroduce.Create";
        public const string Pages_Master_Sales_ProductFinanceIntroduce_Edit = "Pages.Master.Sales.MstSleProductFinanceIntroduce.Edit";
        public const string Pages_Master_Sales_ProductFinanceIntroduce_Delete = "Pages.Master.Sales.MstSleProductFinanceIntroduce.Delete";
        #endregion

        #region "Product Insurance Introduce"
        public const string Pages_Master_Sales_ProductInsuranceIntroduce = "Pages.Master.Sales.MstSleProductInsuranceIntroduce";
        public const string Pages_Master_Sales_ProductInsuranceIntroduce_Search = "Pages.Master.Sales.MstSleProductInsuranceIntroduce.Search";
        public const string Pages_Master_Sales_ProductInsuranceIntroduce_Create = "Pages.Master.Sales.MstSleProductInsuranceIntroduce.Create";
        public const string Pages_Master_Sales_ProductInsuranceIntroduce_Edit = "Pages.Master.Sales.MstSleProductInsuranceIntroduce.Edit";
        public const string Pages_Master_Sales_ProductInsuranceIntroduce_Delete = "Pages.Master.Sales.MstSleProductInsuranceIntroduce.Delete";
        #endregion

        #region "Value Chain Source"
        public const string Pages_Master_Sales_ValueChainSource = "Pages.Master.Sales.ValueChainSource";
        public const string Pages_Master_Sales_ValueChainSource_Search = "Pages.Master.Sales.ValueChainSource.Search";
        public const string Pages_Master_Sales_ValueChainSource_Create = "Pages.Master.Sales.ValueChainSource.Create";
        public const string Pages_Master_Sales_ValueChainSource_Edit = "Pages.Master.Sales.ValueChainSource.Edit";
        public const string Pages_Master_Sales_ValueChainSource_Delete = "Pages.Master.Sales.ValueChainSource.Delete";
        #endregion

        #region "SalesContractCampaignByGrade"
        public const string Pages_Master_Sales_contractMaster = "Pages.Master.Sales.contractMaster";
        public const string Pages_Master_Sales_SalesContractCampaignByGrade = "Pages.Master.Sales.SalesContractCampaignByGrade";
        public const string Pages_Master_Sales_SalesContractCampaignByGrade_Search = "Pages.Master.Sales.SalesContractCampaignByGrade.Search";
        public const string Pages_Master_Sales_SalesContractCampaignByGrade_Create = "Pages.Master.Sales.SalesContractCampaignByGrade.Create";
        public const string Pages_Master_Sales_SalesContractCampaignByGrade_Edit = "Pages.Master.Sales.SalesContractCampaignByGrade.Edit";
        public const string Pages_Master_Sales_SalesContractCampaignByGrade_Delete = "Pages.Master.Sales.SalesContractCampaignByGrade.Delete";
        #endregion

        #region "SalesContractExtendsWarranty"
        public const string Pages_Master_Sales_Extends_Warranty = "Pages.Master.Sales.ExtendsWarranty";
        #endregion
        #region "SalesContractWarranty"
        public const string Pages_Master_Sales_Sale_Contract_Warranty = "Pages.Master.Sales.ContractWarranty";
        public const string Pages_Master_Sales_Sale_Contract_Warranty_Search = "Pages.Master.Sales.ContractWarranty.Search";
        public const string Pages_Master_Sales_Sale_Contract_Warranty_Create = "Pages.Master.Sales.ContractWarranty.Create";
        public const string Pages_Master_Sales_Sale_Contract_Warranty_Edit = "Pages.Master.Sales.ContractWarranty.Edit";
        public const string Pages_Master_Sales_Sale_Contract_Warranty_Delete = "Pages.Master.Sales.ContractWarranty.Delete";

        #endregion

        #region "SalesOrderGradeMapping"
        public const string Pages_Master_Sale_Sales_Order_Grade_Mapping = "Pages.Master.Sales.SalesOrderGradeMapping";
        public const string Pages_Master_Sale_Sales_Order_Grade_Mapping_Search = "Pages.Master.Sales.SalesOrderGradeMapping.Search";
        public const string Pages_Master_Sale_Sales_Order_Grade_Mapping_Create = "Pages.Master.Sales.SalesOrderGradeMapping.Create";
        public const string Pages_Master_Sale_Sales_Order_Grade_Mapping_Edit = "Pages.Master.Sales.SalesOrderGradeMapping.Edit";
        public const string Pages_Master_Sale_Sales_Order_Grade_Mapping_Delete = "Pages.Master.Sales.SalesOrderGradeMapping.Delete";


        #endregion


        #region "Used Car Status"
        public const string Pages_Master_UsedCar = "Pages.Master.UserCar";
        public const string Pages_Master_UsedCar_UsedCarStatus = "Pages.Master.UserCar.UsedCarStatus";
        public const string Pages_Master_UsedCar_UsedCarStatus_Search = "Pages.Master.UserCar.UsedCarStatus.Search";
        public const string Pages_Master_UsedCar_UsedCarStatus_Create = "Pages.Master.UserCar.UsedCarStatus.Create";
        public const string Pages_Master_UsedCar_UsedCarStatus_Edit = "Pages.Master.UserCar.UsedCarStatus.Edit";
        public const string Pages_Master_UsedCar_UsedCarStatus_Delete = "Pages.Master.UserCar.UsedCarStatus.Delete";

        public const string Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Search = "Pages.Master.UserCar.UsedCarStatus.UsedCarStatusReason.Search";
        public const string Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Create = "Pages.Master.UserCar.UsedCarStatus.UsedCarStatusReason.Create";
        public const string Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Edit = "Pages.Master.UserCar.UsedCarStatus.UsedCarStatusReason.Edit";
        public const string Pages_Master_UsedCar_UsedCarStatus_UsedCarStatusReason_Delete = "Pages.Master.UserCar.UsedCarStatus.UsedCarStatusReason.Delete";
        #endregion

        #region "Cấu hình hóa đơn"
        public const string Pages_Master_InvoiceConfig = "Pages.Master.InvoiceConfig";

        #region "Email thanh toán"
        public const string Pages_Master_InvoiceConfig_EmailPayment = "Pages.Master.InvoiceConfig.EmailPayment";
        #endregion

        #region "InvoiceDelayFeeConfig"
        public const string Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig = "Pages.Master.InvoiceConfig.InvoiceDelayFeeConfig";
        public const string Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Create = "Pages.Master.InvoiceConfig.InvoiceDelayFeeConfig.Create";
        public const string Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Edit = "Pages.Master.InvoiceConfig.InvoiceDelayFeeConfig.Edit";
        public const string Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Delete = "Pages.Master.InvoiceConfig.InvoiceDelayFeeConfig.Delete";
        public const string Pages_Master_InvoiceConfig_InvoiceDelayFeeConfig_Import = "Pages.Master.InvoiceConfig.InvoiceDelayFeeConfig.Import";

        #endregion

        #region "DocumentExpressVendor"
        public const string Pages_Master_InvoiceConfig_DocumentExpressVendor = "Pages.Master.InvoiceConfig.DocumentExpressVendor";
        public const string Pages_Master_InvoiceConfig_DocumentExpressVendor_Search = "Pages.Master.InvoiceConfig.DocumentExpressVendor.Search";
        public const string Pages_Master_InvoiceConfig_DocumentExpressVendor_Create = "Pages.Master.InvoiceConfig.DocumentExpressVendor.Create";
        public const string Pages_Master_InvoiceConfig_DocumentExpressVendor_Edit = "Pages.Master.InvoiceConfig.DocumentExpressVendor.Edit";
        public const string Pages_Master_InvoiceConfig_DocumentExpressVendor_Delete = "Pages.Master.InvoiceConfig.DocumentExpressVendor.Delete";
        #endregion
      
        #endregion
        #endregion

      

        #region "Common Master"

        #region "Master Dealer"
        public const string Pages_Master_Common_MstGenDealers = "Pages.Master.Common.MstGenDealers";
        public const string Pages_Master_Sales_MstGenDealers_Search = "Pages.Master.Common.MstGenDealers.Search";
        public const string Pages_Master_Sales_MstGenDealers_Create = "Pages.Master.Common.MstGenDealers.Create";
        public const string Pages_Master_Sales_MstGenDealers_Edit = "Pages.Master.Common.MstGenDealers.Edit";
        public const string Pages_Master_Sales_MstGenDealers_Delete = "Pages.Master.Common.MstGenDealers.Delete";
        #endregion



        #region "Master District"
        public const string Pages_Master_Sales_District = "Pages.Master.Common.MstSleDistrict";
        public const string Pages_Master_Sales_District_Search = "Pages.Master.Common.MstSleDistrict.Search";
        public const string Pages_Master_Sales_District_Create = "Pages.Master.Common.MstSleDistrict.Create";
        public const string Pages_Master_Sales_District_Edit = "Pages.Master.Common.MstSleDistrict.Edit";
        public const string Pages_Master_Sales_District_Delete = "Pages.Master.Common.MstSleDistrict.Delete";
        #endregion

        #region "Master Province"
        public const string Pages_Master_Sales_MstGenProvinces = "Pages.Master.Sales.MstGenProvinces";
        public const string Pages_Master_Sales_MstGenProvinces_Search = "Pages.Master.Sales.MstGenProvinces.Search";
        public const string Pages_Master_Sales_MstGenProvinces_Create = "Pages.Master.Sales.MstGenProvinces.Create";
        public const string Pages_Master_Sales_MstGenProvinces_Edit = "Pages.Master.Sales.MstGenProvinces.Edit";
        public const string Pages_Master_Sales_MstGenProvinces_Delete = "Pages.Master.Sales.MstGenProvinces.Delete";
        #endregion

        #region "Master Group Dealer"
        public const string Pages_Master_Sales_MstSleDealerGroups = "Pages.Master.Sales.MstSleDealerGroups";
        public const string Pages_Master_Sales_MstSleDealerGroups_Search = "Pages.Master.Sales.MstSleDealerGroups.Search";
        public const string Pages_Master_Sales_MstSleDealerGroups_Create = "Pages.Master.Sales.MstSleDealerGroups.Create";
        public const string Pages_Master_Sales_MstSleDealerGroups_Edit = "Pages.Master.Sales.MstSleDealerGroups.Edit";
        public const string Pages_Master_Sales_MstSleDealerGroups_Delete = "Pages.Master.Sales.MstSleDealerGroups.Delete";

        #endregion

        #endregion

        #region "Sales Master"
        #region "Setup Parameter"
        public const string Pages_Setup_Parameter = "Pages.Setup.Parameter";

        #region "Target Setting"
        public const string Pages_Master_Sale_TargetSetting = "Pages.Master.Sale.TargetSetting";
        public const string Pages_Master_Sale_TargetSetting_Create = "Pages.Master.Sale.TargetSetting.Create";
        public const string Pages_Master_Sale_TargetSetting_Edit = "Pages.Master.Sale.TargetSetting.Edit";
        public const string Pages_Master_Sale_TargetSetting_Search = "Pages.Master.Sale.TargetSetting.Search";
        public const string Pages_Master_Sale_TargetSetting_Delete = "Pages.Master.Sale.TargetSetting.Delete";
        #endregion

        #region "Config"
        public const string Pages_Master_Sales_Config = "Pages.Master.Sales.Config";
        public const string Pages_Master_Sales_Config_Create = "Pages.Master.Sales.Config.Create";
        public const string Pages_Master_Sales_Config_Edit = "Pages.Master.Sales.Config.Edit";
        public const string Pages_Master_Sales_Config_Search = "Pages.Master.Sales.Config.Search";
        #endregion

        #region "Mobile Version"
        public const string Pages_Administration_Mobile_Version = "Pages.Administration.Mobile.Version";
        public const string Pages_Administration_Mobile_Version_Create = "Pages.Administration.Mobile.Version.Create";
        public const string Pages_Administration_Mobile_Version_Search = "Pages.Administration.Mobile.Version.Search";
        #endregion

        #region "Master Lookup"
        public const string Pages_Master_Sales_Lookup = "Pages.Master.Sales.MstSleLookup";
        public const string Pages_Master_Sales_Lookup_Create = "Pages.Master.Sales.MstSleLookup.Create";
        public const string Pages_Master_Sales_Lookup_Edit = "Pages.Master.Sales.MstSleLookup.Edit";
        public const string Pages_Master_Sales_Lookup_Delete = "Pages.Master.Sales.MstSleLookup.Delete";
        public const string Pages_Master_Sales_Lookup_Search = "Pages.Master.Sales.MstSleLookup.Search";
        #endregion

        #endregion

        #region "Master Supporter"
        public const string Pages_Master_Sales_MstSleSupporter = "Pages.Master.Sales.MstSleSupporter";
        public const string Pages_Master_Sales_MstSleSupporter_Search = "Pages.Master.Sales.MstSleSupporter.Search";
        public const string Pages_Master_Sales_MstSleSupporter_Create = "Pages.Master.Sales.MstSleSupporter.Create";
        public const string Pages_Master_Sales_MstSleSupporter_Edit = "Pages.Master.Sales.MstSleSupporter.Edit";
        public const string Pages_Master_Sales_MstSleSupporter_Delete = "Pages.Master.Sales.MstSleSupporter.Delete";
        #endregion

        #region "Master InsuranceDriverPassengerFee"
        public const string Pages_Master_Sales_MstSleInsuranceDriverPassengerFee = "Pages.Master.Sales.MstSleInsuranceDriverPassengerFee";
        public const string Pages_Master_Sales_MstSleInsuranceDriverPassengerFee_Search = "Pages.Master.Sales.MstSleInsuranceDriverPassengerFee.Search";
        public const string Pages_Master_Sales_MstSleInsuranceDriverPassengerFee_Edit = "Pages.Master.Sales.MstSleInsuranceDriverPassengerFee.Edit";
        #endregion
        #region "Master Test Drive Place"
        public const string Pages_Master_Sales_MstSleTestDrivePlace = "Pages.Master.Sales.MstSleTestDrivePlace";
        public const string Pages_Master_Sales_MstSleTestDrivePlace_Search = "Pages.Master.Sales.MstSleTestDrivePlace.Search";
        public const string Pages_Master_Sales_MstSleTestDrivePlace_Create = "Pages.Master.Sales.MstSleTestDrivePlace.Create";
        public const string Pages_Master_Sales_MstSleTestDrivePlace_Edit = "Pages.Master.Sales.MstSleTestDrivePlace.Edit";
        public const string Pages_Master_Sales_MstSleTestDrivePlace_Delete = "Pages.Master.Sales.MstSleTestDrivePlace.Delete";

        #endregion

        #region "Delivery Place"
        public const string Pages_Master_Sales_DeliveryPlace = "Pages.Master.Sales.MstSleDeliveryPlace";
        public const string Pages_Master_Sales_DeliveryPlace_Create = "Pages.Master.Sales.MstSleDeliveryPlace.Create";
        public const string Pages_Master_Sales_DeliveryPlace_Edit = "Pages.Master.Sales.MstSleDeliveryPlace.Edit";
        public const string Pages_Master_Sales_DeliveryPlace_Delete = "Pages.Master.Sales.MstSleDeliveryPlace.Delete";
        public const string Pages_Master_Sales_DeliveryPlace_Search = "Pages.Master.Sales.MstSleDeliveryPlace.Search";
        #endregion

        #region "Delivery Stall"
        public const string Pages_Master_Sales_DeliveryStall = "Pages.Master.Sales.MstSleDeliveryStall";
        public const string Pages_Master_Sales_DeliveryStall_Create = "Pages.Master.Sales.MstSleDeliveryStall.Create";
        public const string Pages_Master_Sales_DeliveryStall_Edit = "Pages.Master.Sales.MstSleDeliveryStall.Edit";
        public const string Pages_Master_Sales_DeliveryStall_Delete = "Pages.Master.Sales.MstSleDeliveryStall.Delete";
        public const string Pages_Master_Sales_DeliveryStall_Search = "Pages.Master.Sales.MstSleDeliveryStall.Search";
        #endregion

        #region "Company"
        public const string Pages_Master_Sales_Company = "Pages.Master.Sales.MstSleCompany";
        public const string Pages_Master_Sales_Company_Create = "Pages.Master.Sales.MstSleCompany.Create";
        public const string Pages_Master_Sales_Company_Edit = "Pages.Master.Sales.MstSleCompany.Edit";
        public const string Pages_Master_Sales_Company_Delete = "Pages.Master.Sales.MstSleCompany.Delete";
        public const string Pages_Master_Sales_Company_Search = "Pages.Master.Sales.MstSleCompany.Search";
        #endregion

        #region "Purpose"
        public const string Pages_Master_Sales_Purpose = "Pages.Master.Sales.MstSlePurpose";
        public const string Pages_Master_Sales_Purpose_Create = "Pages.Master.Sales.MstSlePurpose.Create";
        public const string Pages_Master_Sales_Purpose_Edit = "Pages.Master.Sales.MstSlePurpose.Edit";
        public const string Pages_Master_Sales_Purpose_Delete = "Pages.Master.Sales.MstSlePurpose.Delete";
        public const string Pages_Master_Sales_Purpose_Search = "Pages.Master.Sales.MstSlePurpose.Search";
        #endregion

        #region "FAR"
        public const string Pages_Master_Sales_FAR = "Pages.Master.Sales.MstSleFAR";
        public const string Pages_Master_Sales_FAR_Create = "Pages.Master.Sales.MstSleFAR.Create";
        public const string Pages_Master_Sales_FAR_Edit = "Pages.Master.Sales.MstSleFAR.Edit";
        public const string Pages_Master_Sales_FAR_Delete = "Pages.Master.Sales.MstSleFAR.Delete";
        public const string Pages_Master_Sales_FAR_Search = "Pages.Master.Sales.MstSleFAR.Search";
        #endregion

        #region "ReasonOfChange"
        public const string Pages_Master_Sales_ReasonOfChange = "Pages.Master.Sales.MstSleReasonOfChange";
        public const string Pages_Master_Sales_ReasonOfChange_Create = "Pages.Master.Sales.MstSleReasonOfChange.Create";
        public const string Pages_Master_Sales_ReasonOfChange_Edit = "Pages.Master.Sales.MstSleReasonOfChange.Edit";
        public const string Pages_Master_Sales_ReasonOfChange_Delete = "Pages.Master.Sales.MstSleReasonOfChange.Delete";
        public const string Pages_Master_Sales_ReasonOfChange_Search = "Pages.Master.Sales.MstSleReasonOfChange.Search";
        #endregion

        #region "ReasonOfFreeze"
        public const string Pages_Master_Sales_ReasonOfFreeze = "Pages.Master.Sales.MstSleReasonOfFreeze";
        public const string Pages_Master_Sales_ReasonOfFreeze_Create = "Pages.Master.Sales.MstSleReasonOfFreeze.Create";
        public const string Pages_Master_Sales_ReasonOfFreeze_Edit = "Pages.Master.Sales.MstSleReasonOfFreeze.Edit";
        public const string Pages_Master_Sales_ReasonOfFreeze_Delete = "Pages.Master.Sales.MstSleReasonOfFreeze.Delete";
        public const string Pages_Master_Sales_ReasonOfFreeze_Search = "Pages.Master.Sales.MstSleReasonOfFreeze.Search";
        #endregion

        #region "SalesStage"
        public const string Pages_Master_Sales_SalesStage = "Pages.Master.Sales.MstSleSalesStage";
        public const string Pages_Master_Sales_SalesStage_Create = "Pages.Master.Sales.MstSleSalesStage.Create";
        public const string Pages_Master_Sales_SalesStage_Edit = "Pages.Master.Sales.MstSleSalesStage.Edit";
        public const string Pages_Master_Sales_SalesStage_Delete = "Pages.Master.Sales.MstSleSalesStage.Delete";
        public const string Pages_Master_Sales_SalesStage_Search = "Pages.Master.Sales.MstSleSalesStage.Search";
        #endregion

        #region "ReasonOfLost"
        public const string Pages_Master_Sales_ReasonOfLost = "Pages.Master.Sales.MstSleReasonOfLost";
        public const string Pages_Master_Sales_ReasonOfLost_Create = "Pages.Master.Sales.MstSleReasonOfLost.Create";
        public const string Pages_Master_Sales_ReasonOfLost_Edit = "Pages.Master.Sales.MstSleReasonOfLost.Edit";
        public const string Pages_Master_Sales_ReasonOfLost_Delete = "Pages.Master.Sales.MstSleReasonOfLost.Delete";
        public const string Pages_Master_Sales_ReasonOfLost_Search = "Pages.Master.Sales.MstSleReasonOfLost.Search";
        #endregion

        #region "Delivery Venue"
        public const string Pages_Master_Sales_DeliveryVenue = "Pages.Master.Sales.MstSleDeliveryVenue";
        public const string Pages_Master_Sales_DeliveryVenue_Create = "Pages.Master.Sales.MstSleDeliveryVenue.Create";
        public const string Pages_Master_Sales_DeliveryVenue_Edit = "Pages.Master.Sales.MstSleDeliveryVenue.Edit";
        public const string Pages_Master_Sales_DeliveryVenue_Delete = "Pages.Master.Sales.MstSleDeliveryVenue.Delete";
        public const string Pages_Master_Sales_DeliveryVenue_Search = "Pages.Master.Sales.MstSleDeliveryVenue.Search";
        #endregion
        #region "Source"
        public const string Pages_Master_Sales_Source = "Pages.Master.Sales.MstSleSource";
        public const string Pages_Master_Sales_Source_Create = "Pages.Master.Sales.MstSleSource.Create";
        public const string Pages_Master_Sales_Source_Edit = "Pages.Master.Sales.MstSleSource.Edit";
        public const string Pages_Master_Sales_Source_Delete = "Pages.Master.Sales.MstSleSource.Delete";
        public const string Pages_Master_Sales_Source_Search = "Pages.Master.Sales.MstSleSource.Search";
        #endregion
        #region "ConfigNumericalNo"
        public const string Pages_Master_Config_Numberical_No = "Pages.Master.Sales.MstConfigNumericalNo";
        public const string Pages_Master_Config_Numberical_No_Create = "Pages.Master.Sales.MstConfigNumericalNo.Create";
        public const string Pages_Master_Config_Numberical_No_Edit = "Pages.Master.Sales.MstConfigNumericalNo.Edit";
        public const string Pages_Master_Config_Numberical_No_Delete = "Pages.Master.Sales.MstConfigNumericalNo.Delete";
        public const string Pages_Master_Config_Numberical_No_Search = "Pages.Master.Sales.MstConfigNumericalNo.Search";
        #endregion
        #region "ColorByGrade"
        public const string Pages_Master_Sales_Color_By_Grade = "Pages.Master.Sales.MstSleColorByGrade";
        public const string Pages_Master_Sales_Color_By_Grade_Delete = "Pages.Master.Sales.MstSleColorByGrade.Delete";
        public const string Pages_Master_Sales_Color_By_Grade_Create = "Pages.Master.Sales.MstSleColorByGrade.Create";
        public const string Pages_Master_Sales_Color_By_Grade_Edit = "Pages.Master.Sales.MstSleColorByGrade.Edit";
        public const string Pages_Master_Sales_Color_By_Grade_Search = "Pages.Master.Sales.MstSleColorByGrade.Search";
        #endregion
        #region "Make Competitor"
        public const string Pages_Master_Sales_Make_Competitor = "Pages.Master.Sales.MstSleMakeCompetitor";
        public const string Pages_Master_Sales_Make_Competitor_Create = "Pages.Master.Sales.MstSleMakeCompetitor.Create";
        public const string Pages_Master_Sales_Make_Competitor_Edit = "Pages.Master.Sales.MstSleMakeCompetitor.Edit";
        public const string Pages_Master_Sales_Make_Competitor_Delete = "Pages.Master.Sales.MstSleMakeCompetitor.Delete";
        public const string Pages_Master_Sales_Make_Competitor_Search = "Pages.Master.Sales.MstSleMakeCompetitor.Search";
        #endregion
        #region "Colors"
        public const string Pages_Master_Sales_MstSleColors = "Pages.Master.Sales.MstSleColor";
        public const string Pages_Master_Sales_MstSleColors_Create = "Pages.Master.Sales.MstSleColor.Create";
        public const string Pages_Master_Sales_MstSleColors_Edit = "Pages.Master.Sales.MstSleColor.Edit";
        public const string Pages_Master_Sales_MstSleColors_Delete = "Pages.Master.Sales.MstSleColor.Delete";
        public const string Pages_Master_Sales_MstSleColors_Search = "Pages.Master.Sales.MstSleColor.Search";
        #endregion
        #region "Role"
        public const string Pages_Master_Sales_Role = "Pages.Master.Sales.MstSleRole";
        public const string Pages_Master_Sales_Role_Create = "Pages.Master.Sales.MstSleRole.Create";
        public const string Pages_Master_Sales_Role_Edit = "Pages.Master.Sales.MstSleRole.Edit";
        public const string Pages_Master_Sales_Role_Delete = "Pages.Master.Sales.MstSleRole.Delete";
        public const string Pages_Master_Sales_Role_Search = "Pages.Master.Sales.MstSleRole.Search";
        #endregion
        #region "Business Type"
        public const string Pages_Master_Sales_BusinessType = "Pages.Master.Sales.MstSleBusinessType";
        public const string Pages_Master_Sales_BusinessType_Create = "Pages.Master.Sales.MstSleBusinessType.Create";
        public const string Pages_Master_Sales_BusinessType_Edit = "Pages.Master.Sales.MstSleBusinessType.Edit";
        public const string Pages_Master_Sales_BusinessType_Delete = "Pages.Master.Sales.MstSleBusinessType.Delete";
        public const string Pages_Master_Sales_BusinessType_Search = "Pages.Master.Sales.MstSleBusinessType.Search";
        #endregion
        #region "Test Drive Stall"
        public const string Pages_Master_Sales_TestDriveStall = "Pages.Master.Sales.MstSleTestDriveStall";
        public const string Pages_Master_Sales_TestDriveStall_Search = "Pages.Master.Sales.MstSleTestDriveStall.Search";
        public const string Pages_Master_Sales_TestDriveStall_Create = "Pages.Master.Sales.MstSleTestDriveStall.Create";
        public const string Pages_Master_Sales_TestDriveStall_Edit = "Pages.Master.Sales.MstSleTestDriveStall.Edit";
        public const string Pages_Master_Sales_TestDriveStall_Delete = "Pages.Master.Sales.MstSleTestDriveStall.Delete";
        #endregion
        #region "Test Drive Vehicle"
        public const string Pages_Master_Sales_TestDriveVehicle = "Pages.Master.Sales.MstSleTestDriveVehicle";
        public const string Pages_Master_Sales_TestDriveVehicle_Search = "Pages.Master.Sales.MstSleTestDriveVehicle.Search";
        public const string Pages_Master_Sales_TestDriveVehicle_Create = "Pages.Master.Sales.MstSleTestDriveVehicle.Create";
        public const string Pages_Master_Sales_TestDriveVehicle_Edit = "Pages.Master.Sales.MstSleTestDriveVehicle.Edit";
        public const string Pages_Master_Sales_TestDriveVehicle_Delete = "Pages.Master.Sales.MstSleTestDriveVehicle.Delete";
        #endregion
        #region "Test Drive Route"
        public const string Pages_Master_Sales_TestDriveRoute = "Pages.Master.Sales.MstSleTestDriveRoute";
        public const string Pages_Master_Sales_TestDriveRoute_Search = "Pages.Master.Sales.MstSleTestDriveRoute.Search";
        public const string Pages_Master_Sales_TestDriveRoute_Create = "Pages.Master.Sales.MstSleTestDriveRoute.Create";
        public const string Pages_Master_Sales_TestDriveRoute_Edit = "Pages.Master.Sales.MstSleTestDriveRoute.Edit";
        public const string Pages_Master_Sales_TestDriveRoute_Delete = "Pages.Master.Sales.MstSleTestDriveRoute.Delete";
        #endregion
        #region "Excepted Delivery Timing"
        public const string Pages_Master_Sales_ExceptedDeliveryTiming = "Pages.Master.Sales.MstSleExpectedDelTiming";
        public const string Pages_Master_Sales_ExceptedDeliveryTiming_Search = "Pages.Master.Sales.MstSleExpectedDelTiming.Search";
        public const string Pages_Master_Sales_ExceptedDeliveryTiming_Create = "Pages.Master.Sales.MstSleExpectedDelTiming.Create";
        public const string Pages_Master_Sales_ExceptedDeliveryTiming_Edit = "Pages.Master.Sales.MstSleExpectedDelTiming.Edit";
        public const string Pages_Master_Sales_ExceptedDeliveryTiming_Delete = "Pages.Master.Sales.MstSleExpectedDelTiming.Delete";
        #endregion
        #region "Hotness"
        public const string Pages_Master_Sales_Hotness = "Pages.Master.Sales.MstSleHotness";
        public const string Pages_Master_Sales_Hotness_Search = "Pages.Master.Sales.MstSleHotness.Search";
        public const string Pages_Master_Sales_Hotness_Create = "Pages.Master.Sales.MstSleHotness.Create";
        public const string Pages_Master_Sales_Hotness_Edit = "Pages.Master.Sales.MstSleHotness.Edit";
        public const string Pages_Master_Sales_Hotness_Delete = "Pages.Master.Sales.MstSleHotness.Delete";
        #endregion

        #region "Payment Type"
        public const string Pages_Master_Sales_PaymentType = "Pages.Master.Sales.MstSlePaymentType";
        public const string Pages_Master_Sales_PaymentType_Search = "Pages.Master.Sales.MstSlePaymentType.Search";
        public const string Pages_Master_Sales_PaymentType_Create = "Pages.Master.Sales.MstSlePaymentType.Create";
        public const string Pages_Master_Sales_PaymentType_Edit = "Pages.Master.Sales.MstSlePaymentType.Edit";
        public const string Pages_Master_Sales_PaymentType_Delete = "Pages.Master.Sales.MstSlePaymentType.Delete";
        #endregion
        #region "Occupation"
        public const string Pages_Master_Sales_Occupation = "Pages.Master.Sales.MstSleOccupation";
        public const string Pages_Master_Sales_Occupation_Search = "Pages.Master.Sales.MstSleOccupation.Search";
        public const string Pages_Master_Sales_Occupation_Create = "Pages.Master.Sales.MstSleOccupation.Create";
        public const string Pages_Master_Sales_Occupation_Edit = "Pages.Master.Sales.MstSleOccupation.Edit";
        public const string Pages_Master_Sales_Occupation_Delete = "Pages.Master.Sales.MstSleOccupation.Delete";
        #endregion
        #region "Hobby"
        public const string Pages_Master_Sales_Hobby = "Pages.Master.Sales.MstSleHobby";
        public const string Pages_Master_Sales_Hobby_Search = "Pages.Master.Sales.MstSleHobby.Search";
        public const string Pages_Master_Sales_Hobby_Create = "Pages.Master.Sales.MstSleHobby.Create";
        public const string Pages_Master_Sales_Hobby_Edit = "Pages.Master.Sales.MstSleHobby.Edit";
        public const string Pages_Master_Sales_Hobby_Delete = "Pages.Master.Sales.MstSleHobby.Delete";
        #endregion
        #region "Source Of Info"
        public const string Pages_Master_Sales_SourceOfInfo = "Pages.Master.Sales.MstSleSourceOfInfo";
        public const string Pages_Master_Sales_SourceOfInfo_Search = "Pages.Master.Sales.MstSleSourceOfInfo.Search";
        public const string Pages_Master_Sales_SourceOfInfo_Create = "Pages.Master.Sales.MstSleSourceOfInfo.Create";
        public const string Pages_Master_Sales_SourceOfInfo_Edit = "Pages.Master.Sales.MstSleSourceOfInfo.Edit";
        public const string Pages_Master_Sales_SourceOfInfo_Delete = "Pages.Master.Sales.MstSleSourceOfInfo.Delete";
        #endregion
        #region "Social Channel"
        public const string Pages_Master_Sales_SocialChannel = "Pages.Master.Sales.MstSleSocialChannel";
        public const string Pages_Master_Sales_SocialChannel_Search = "Pages.Master.Sales.MstSleSocialChannel.Search";
        public const string Pages_Master_Sales_SocialChannel_Create = "Pages.Master.Sales.MstSleSocialChannel.Create";
        public const string Pages_Master_Sales_SocialChannel_Edit = "Pages.Master.Sales.MstSleSocialChannel.Edit";
        public const string Pages_Master_Sales_SocialChannel_Delete = "Pages.Master.Sales.MstSleSocialChannel.Delete";
        #endregion

        #region "Customer Social Channel"
        public const string Pages_Master_CustomerSocialChannel = "Pages.Master.Sales.MstSleCustomerSocialChannel";
        public const string Pages_Master_CustomerSocialChannel_Search = "Pages.Master.Sales.MstSleCustomerSocialChannel.Search";
        public const string Pages_Master_CustomerSocialChannel_Create = "Pages.Master.Sales.MstSleCustomerSocialChannel.Create";
        public const string Pages_Master_CustomerSocialChannel_Edit = "Pages.Master.Sales.MstSleCustomerSocialChannel.Edit";
        public const string Pages_Master_CustomerSocialChannel_Delete = "Pages.Master.Sales.MstSleCustomerSocialChannel.Delete";
        #endregion

        #region "Finance Instalment Plan"
        public const string Pages_Master_Sales_FinanceInstalmentPlan = "Pages.Master.Sales.MstSleFinanceInstalmentPlan";
        public const string Pages_Master_Sales_FinanceInstalmentPlan_Search = "Pages.Master.Sales.MstSleFinanceInstalmentPlan.Search";
        public const string Pages_Master_Sales_FinanceInstalmentPlan_Create = "Pages.Master.Sales.MstSleFinanceInstalmentPlan.Create";
        public const string Pages_Master_Sales_FinanceInstalmentPlan_Edit = "Pages.Master.Sales.MstSleFinanceInstalmentPlan.Edit";
        public const string Pages_Master_Sales_FinanceInstalmentPlan_Delete = "Pages.Master.Sales.MstSleFinanceInstalmentPlan.Delete";
        public const string Pages_Master_Sales_CustomApi = "Pages.Master.Sales.CustomApi";
        #endregion

        #region "Finance TFS Package"
        public const string Pages_Master_Sales_FinanceTFSPackage = "Pages.Master.Sales.MstSleFinanceTFSPackage";
        public const string Pages_Master_Sales_FinanceTFSPackage_Search = "Pages.Master.Sales.MstSleFinanceTFSPackage.Search";
        public const string Pages_Master_Sales_FinanceTFSPackage_Create = "Pages.Master.Sales.MstSleFinanceTFSPackage.Create";
        public const string Pages_Master_Sales_FinanceTFSPackage_Edit = "Pages.Master.Sales.MstSleFinanceTFSPackage.Edit";
        public const string Pages_Master_Sales_FinanceTFSPackage_Delete = "Pages.Master.Sales.MstSleFinanceTFSPackage.Delete";

        #endregion
        #region "Finance Loan Value"
        public const string Pages_Master_Sales_FinanceLoanValue = "Pages.Master.Sales.MstSleFinanceLoanValue";
        public const string Pages_Master_Sales_FinanceLoanValue_Search = "Pages.Master.Sales.MstSleFinanceLoanValue.Search";
        public const string Pages_Master_Sales_FinanceLoanValue_Create = "Pages.Master.Sales.MstSleFinanceLoanValue.Create";
        public const string Pages_Master_Sales_FinanceLoanValue_Edit = "Pages.Master.Sales.MstSleFinanceLoanValue.Edit";
        public const string Pages_Master_Sales_FinanceLoanValue_Delete = "Pages.Master.Sales.MstSleFinanceLoanValue.Delete";

        #endregion
        #region "Finance Interest Rate"
        public const string Pages_Master_Sales_FinanceInterestRate = "Pages.Master.Sales.MstSleFinanceInterestRate";
        public const string Pages_Master_Sales_FinanceInterestRate_Search = "Pages.Master.Sales.MstSleFinanceInterestRate.Search";
        public const string Pages_Master_Sales_FinanceInterestRate_Create = "Pages.Master.Sales.MstSleFinanceInterestRate.Create";
        public const string Pages_Master_Sales_FinanceInterestRate_Edit = "Pages.Master.Sales.MstSleFinanceInterestRate.Edit";
        public const string Pages_Master_Sales_FinanceInterestRate_Delete = "Pages.Master.Sales.MstSleFinanceInterestRate.Delete";

        #endregion
        #region "Finance Params By Model"
        public const string Pages_Master_Sales_FinanceParamByModel = "Pages.Master.Sales.MstSleFinanceParamByModel";
        public const string Pages_Master_Sales_FinanceParamByModel_Search = "Pages.Master.Sales.MstSleFinanceParamByModel.Search";
        public const string Pages_Master_Sales_FinanceParamByModel_Create = "Pages.Master.Sales.MstSleFinanceParamByModel.Create";
        public const string Pages_Master_Sales_FinanceParamByModel_Edit = "Pages.Master.Sales.MstSleFinanceParamByModel.Edit";
        public const string Pages_Master_Sales_FinanceParamByModel_Delete = "Pages.Master.Sales.MstSleFinanceParamByModel.Delete";
        #endregion
        #region "Education"
        public const string Pages_Master_Sales_Education = "Pages.Master.Sales.MstSleEducation";
        public const string Pages_Master_Sales_Education_Search = "Pages.Master.Sales.MstSleEducation.Search";
        public const string Pages_Master_Sales_Education_Create = "Pages.Master.Sales.MstSleEducation.Create";
        public const string Pages_Master_Sales_Education_Edit = "Pages.Master.Sales.MstSleEducation.Edit";
        public const string Pages_Master_Sales_Education_Delete = "Pages.Master.Sales.MstSleEducation.Delete";
        #endregion
        #region "Jobs"
        public const string Pages_Master_Sales_Jobs = "Pages.Master.Sales.MstSleJobs";
        public const string Pages_Master_Sales_Jobs_Search = "Pages.Master.Sales.MstSleJobs.Search";
        public const string Pages_Master_Sales_Jobs_Create = "Pages.Master.Sales.MstSleJobs.Create";
        public const string Pages_Master_Sales_Jobs_Edit = "Pages.Master.Sales.MstSleJobs.Edit";
        public const string Pages_Master_Sales_Jobs_Delete = "Pages.Master.Sales.MstSleJobs.Delete";
        #endregion
        #region "Job Title"
        public const string Pages_Master_Sales_JobTitle = "Pages.Master.Sales.MstSleJobTitle";
        public const string Pages_Master_Sales_JobTitle_Search = "Pages.Master.Sales.MstSleJobTitle.Search";
        public const string Pages_Master_Sales_JobTitle_Create = "Pages.Master.Sales.MstSleJobTitle.Create";
        public const string Pages_Master_Sales_JobTitle_Edit = "Pages.Master.Sales.MstSleJobTitle.Edit";
        public const string Pages_Master_Sales_JobTitle_Delete = "Pages.Master.Sales.MstSleJobTitle.Delete";
        #endregion
        #region "Dealer Organization Chart"
        public const string Pages_Master_Sales_DealerOrganizationChart = "Pages.Master.Sales.MstDealerOrganizationChart";
        public const string Pages_Master_Sales_DealerOrganizationChart_Search = "Pages.Master.Sales.MstDealerOrganizationChart.Search";
        #endregion
        #region "Vehicle Product Image"
        public const string Pages_Master_Sales_VehicleProductImage = "Pages.Master.Sales.MstSleVehicleProductImage";
        public const string Pages_Master_Sales_VehicleProductImage_Search = "Pages.Master.Sales.MstSleVehicleProductImage.Search";
        public const string Pages_Master_Sales_VehicleProductImage_Create = "Pages.Master.Sales.MstSleVehicleProductImage.Create";
        public const string Pages_Master_Sales_VehicleProductImage_Edit = "Pages.Master.Sales.MstSleVehicleProductImage.Edit";
        public const string Pages_Master_Sales_VehicleProductImage_Delete = "Pages.Master.Sales.MstSleVehicleProductImage.Delete";
        #endregion
        #region "Vehicle Product accessory genuine"
        public const string Pages_Master_Sales_AccessoryGenuine = "Pages.Master.Sales.AccessoryGenuine";
        public const string Pages_Master_Sales_AccessoryGenuine_Search = "Pages.Master.Sales.AccessoryGenuine.Search";
        public const string Pages_Master_Sales_AccessoryGenuine_Edit = "Pages.Master.Sales.AccessoryGenuine.Edit";
        #endregion
        #region "Vehicle Product maintenance detail"
        public const string Pages_Master_Sales_MaintenanceDetail = "Pages.Master.Sales.MaintenanceDetail";
        public const string Pages_Master_Sales_MaintenanceDetail_Search = "Pages.Master.Sales.MaintenanceDetail.Search";
        public const string Pages_Master_Sales_MaintenanceDetail_Create = "Pages.Master.Sales.MaintenanceDetail.Create";
        public const string Pages_Master_Sales_MaintenanceDetail_Delete = "Pages.Master.Sales.MaintenanceDetail.Delete";
        public const string Pages_Master_Sales_MaintenanceDetail_Edit = "Pages.Master.Sales.MaintenanceDetail.Edit";
        #endregion

        #region "Vehicle Product BeatyCareServices "
        public const string Pages_Master_Sales_BeatyCareServices = "Pages.Master.Sales.BeatyCareServices";
        public const string Pages_Master_Sales_BeatyCareServices_Search = "Pages.Master.Sales.BeatyCareServices.Search";
        public const string Pages_Master_Sales_BeatyCareServices_Create = "Pages.Master.Sales.BeatyCareServices.Create";
        public const string Pages_Master_Sales_BeatyCareServices_Delete = "Pages.Master.Sales.BeatyCareServices.Delete";
        public const string Pages_Master_Sales_BeatyCareServices_Edit = "Pages.Master.Sales.BeatyCareServices.Edit";
        #endregion 
        #region "Vehicle Product TechnicalSpecInternalColor "
        public const string Pages_Master_Sales_TechnicalSpecInternalColor = "Pages.Master.Sales.TechnicalSpecInternalColor";
        public const string Pages_Master_Sales_TechnicalSpecInternalColor_Search = "Pages.Master.Sales.TechnicalSpecInternalColor.Search";
        public const string Pages_Master_Sales_TechnicalSpecInternalColor_Create = "Pages.Master.Sales.TechnicalSpecInternalColor.Create";
        public const string Pages_Master_Sales_TechnicalSpecInternalColor_Delete = "Pages.Master.Sales.TechnicalSpecInternalColor.Delete";
        public const string Pages_Master_Sales_TechnicalSpecInternalColor_Edit = "Pages.Master.Sales.TechnicalSpecInternalColor.Edit";
        #endregion

        #region "Vehicle Product Recruitment"
        public const string Pages_Master_Sales_Recruitment = "Pages.Master.Recruitment";
        #region "danh sách ứng viên"
        public const string Pages_Master_Sales_Vehicle_Product_Recruitment = "Pages.Master.Sales.VehicleProductRecruitment";
        public const string Pages_Master_Sales_Vehicle_Product_Recruitment_Search = "Pages.Master.Sales.VehicleProductRecruitment.Search";
        #endregion

        #region "Vehicle Product Recruitment Software"
        public const string Pages_Master_Sales_RecruitmentSoftware = "Pages.Master.Sales.Software";
        public const string Pages_Master_Sales_RecruitmentSoftware_Search = "Pages.Master.Sales.Software.Search";
        public const string Pages_Master_Sales_RecruitmentSoftware_Create = "Pages.Master.Sales.Software.Create";
        public const string Pages_Master_Sales_RecruitmentSoftware_Edit = "Pages.Master.Sales.Software.Edit";
        public const string Pages_Master_Sales_RecruitmentSoftware_Delete = "Pages.Master.Sales.Software.Delete";
        #endregion
        #region "Vehicle Product Skill Level"
        public const string Pages_Master_Sales_SkillLevel = "Pages.Master.Sales.SkillLevel";
        public const string Pages_Master_Sales_SkillLevel_Search = "Pages.Master.Sales.SkillLevel.Search";
        public const string Pages_Master_Sales_SkillLevel_Create = "Pages.Master.Sales.SkillLevel.Create";
        public const string Pages_Master_Sales_SkillLevel_Edit = "Pages.Master.Sales.SkillLevel.Edit";
        public const string Pages_Master_Sales_SkillLevel_Delete = "Pages.Master.Sales.SkillLevel.Delete";
        #endregion
        #region "Vehicle Product Applied Position"
        public const string Pages_Master_Sales_VehicleProductAppliedPosition = "Pages.Master.Sales.VehicleProductAppliedPosition";
        public const string Pages_Master_Sales_VehicleProductAppliedPosition_Search = "Pages.Master.Sales.VehicleProductAppliedPosition.Search";
        public const string Pages_Master_Sales_VehicleProductAppliedPosition_Create = "Pages.Master.Sales.VehicleProductAppliedPosition.Create";
        public const string Pages_Master_Sales_VehicleProductAppliedPosition_Edit = "Pages.Master.Sales.VehicleProductAppliedPosition.Edit";
        public const string Pages_Master_Sales_VehicleProductAppliedPosition_Delete = "Pages.Master.Sales.VehicleProductAppliedPosition.Delete";
        #endregion
        #region "Vehicle Product Education Level"
        public const string Pages_Master_Sales_EducationLevel = "Pages.Master.Sales.EducationLevel";
        public const string Pages_Master_Sales_EducationLevel_Search = "Pages.Master.Sales.EducationLevel.Search";
        public const string Pages_Master_Sales_EducationLevel_Create = "Pages.Master.Sales.EducationLevel.Create";
        public const string Pages_Master_Sales_EducationLevel_Edit = "Pages.Master.Sales.EducationLevel.Edit";
        public const string Pages_Master_Sales_EducationLevel_Delete = "Pages.Master.Sales.EducationLevel.Delete";
        #endregion

        #region "Vehicle Product Recruitment Location"
        public const string Pages_Master_Sales_RecruitmentLocation = "Pages.Master.Sales.RecruitmentLocation";
        public const string Pages_Master_Sales_RecruitmentLocation_Search = "Pages.Master.Sales.RecruitmentLocation.Search";
        public const string Pages_Master_Sales_RecruitmentLocation_Create = "Pages.Master.Sales.RecruitmentLocation.Create";
        public const string Pages_Master_Sales_RecruitmentLocation_Edit = "Pages.Master.Sales.RecruitmentLocation.Edit";
        public const string Pages_Master_Sales_RecruitmentLocation_Delete = "Pages.Master.Sales.RecruitmentLocation.Delete";
        #endregion

        #region " Mst Sle Employee Leave Temporary Approve"
        public const string Pages_Master_Sales_EmployeeLeaveTemporaryApprove = "Pages.Master.Sales.EmployeeLeaveTemporaryApprove";
        public const string Pages_Master_Sales_EmployeeLeaveTemporaryApprove_Search = "Pages.Master.Sales.EmployeeLeaveTemporaryApprove.Search";

        #endregion

        #region " MstSle Employee Contract Approve"
        public const string Pages_Master_Sales_EmployeeContractApprove = "Pages.Master.Sales.EmployeeContractApprove";
        public const string Pages_Master_Sales_EmployeeContractApprove_Search = "Pages.Master.Sales.EmployeeContractApprove.Search";

        #endregion
        #endregion
        #region "Vehicle Product Category"
        public const string Pages_Master_Sales_VehicleProductCategory = "Pages.Master.Sales.MstSleVehicleProductCategory";
        public const string Pages_Master_Sales_VehicleProductCategory_Search = "Pages.Master.Sales.MstSleVehicleProductCategory.Search";
        public const string Pages_Master_Sales_VehicleProductCategory_Create = "Pages.Master.Sales.MstSleVehicleProductCategory.Create";
        public const string Pages_Master_Sales_VehicleProductCategory_Edit = "Pages.Master.Sales.MstSleVehicleProductCategory.Edit";
        public const string Pages_Master_Sales_VehicleProductCategory_Delete = "Pages.Master.Sales.MstSleVehicleProductCategory.Delete";
        #endregion
        #region "Vehicle Product SaleTalk"
        public const string Pages_Master_Sales_VehicleProductSaleTalk = "Pages.Master.Sales.MstSleVehicleProductSaleTalk";
        public const string Pages_Master_Sales_VehicleProductSaleTalk_Search = "Pages.Master.Sales.MstSleVehicleProductSaleTalk.Search";
        public const string Pages_Master_Sales_VehicleProductSaleTalk_Create = "Pages.Master.Sales.MstSleVehicleProductSaleTalk.Create";
        public const string Pages_Master_Sales_VehicleProductSaleTalk_Edit = "Pages.Master.Sales.MstSleVehicleProductSaleTalk.Edit";
        public const string Pages_Master_Sales_VehicleProductSaleTalk_Delete = "Pages.Master.Sales.MstSleVehicleProductSaleTalk.Delete";
        #endregion
        #region "Vehicle Product Document"
        public const string Pages_Master_Sales_VehicleProductDocument = "Pages.Master.Sales.MstSleVehicleProductDocument";
        public const string Pages_Master_Sales_VehicleProductDocument_Search = "Pages.Master.Sales.MstSleVehicleProductDocument.Search";
        public const string Pages_Master_Sales_VehicleProductDocument_Create = "Pages.Master.Sales.MstSleVehicleProductDocument.Create";
        public const string Pages_Master_Sales_VehicleProductDocument_Edit = "Pages.Master.Sales.MstSleVehicleProductDocument.Edit";
        public const string Pages_Master_Sales_VehicleProductDocument_Delete = "Pages.Master.Sales.MstSleVehicleProductDocument.Delete";
        #endregion

        #region "Product Car Body Style"
        public const string Pages_Master_Sales_ProductCarBodyStyle = "Pages.Master.Sales.MstSleProductCarBodyStyle";
        public const string Pages_Master_Sales_ProductCarBodyStyle_Search = "Pages.Master.Sales.MstSleProductCarBodyStyle.Search";
        public const string Pages_Master_Sales_ProductCarBodyStyle_Create = "Pages.Master.Sales.MstSleProductCarBodyStyle.Create";
        public const string Pages_Master_Sales_ProductCarBodyStyle_Edit = "Pages.Master.Sales.MstSleProductCarBodyStyle.Edit";
        public const string Pages_Master_Sales_ProductCarBodyStyle_Delete = "Pages.Master.Sales.MstSleProductCarBodyStyle.Delete";
        #endregion


        #region "Product Car Body Style"
        public const string Pages_Master_Sales_ProductCarEngine = "Pages.Master.Sales.MstSleProductCarEngine";
        public const string Pages_Master_Sales_ProductCarEngine_Search = "Pages.Master.Sales.MstSleProductCarEngine.Search";
        public const string Pages_Master_Sales_ProductCarEngine_Create = "Pages.Master.Sales.MstSleProductCarEngine.Create";
        public const string Pages_Master_Sales_ProductCarEngine_Edit = "Pages.Master.Sales.MstSleProductCarEngine.Edit";
        public const string Pages_Master_Sales_ProductCarEngine_Delete = "Pages.Master.Sales.MstSleProductCarEngine.Delete";
        #endregion

        #region "Trip Request"
        public const string Pages_Master_Sales_TripRequest = "Pages.Master.Sales.MstSleTripRequest";
        public const string Pages_Master_Sales_TripRequest_Search = "Pages.Master.Sales.MstSleTripRequest.Search";
        public const string Pages_Master_Sales_TripRequest_Create = "Pages.Master.Sales.MstSleTripRequest.Create";
        public const string Pages_Master_Sales_TripRequest_Edit = "Pages.Master.Sales.MstSleTripRequest.Edit";
        public const string Pages_Master_Sales_TripRequest_Delete = "Pages.Master.Sales.MstSleTripRequest.Delete";
        #endregion

        #region "Price Change"
        public const string Pages_Master_Sales_PriceChange = "Pages.Master.Sales.MstSlePriceChange";
        public const string Pages_Master_Sales_PriceChange_Search = "Pages.Master.Sales.MstSlePriceChange.Search";
        public const string Pages_Master_Sales_PriceChange_Edit = "Pages.Master.Sales.MstSlePriceChange.Edit";
        #endregion

        #region "Genba"
        public const string Pages_Master_Sales_Genba = "Pages.Master.Sales.MstSleVehicleProductGenba";
        public const string Pages_Master_Sales_Genba_Search = "Pages.Master.Sales.MstSleVehicleProductGenba.Search";
        public const string Pages_Master_Sales_Genba_Create = "Pages.Master.Sales.MstSleVehicleProductGenba.Create";
        public const string Pages_Master_Sales_Genba_Edit = "Pages.Master.Sales.MstSleVehicleProductGenba.Edit";
        public const string Pages_Master_Sales_Genba_Delete = "Pages.Master.Sales.MstSleVehicleProductGenba.Delete";
        #endregion

        #region "Test Drive"
        public const string Pages_Master_Sales_VehicleProductTestDrive = "Pages.Master.Sales.MstSleVehicleProductTestDrive";
        public const string Pages_Master_Sales_VehicleProductTestDrive_Search = "Pages.Master.Sales.MstSleVehicleProductTestDrive.Search";
        public const string Pages_Master_Sales_VehicleProductTestDrive_Create = "Pages.Master.Sales.MstSleVehicleProductTestDrive.Create";
        public const string Pages_Master_Sales_VehicleProductTestDrive_Edit = "Pages.Master.Sales.MstSleVehicleProductTestDrive.Edit";
        public const string Pages_Master_Sales_VehicleProductTestDrive_Delete = "Pages.Master.Sales.MstSleVehicleProductTestDrive.Delete";
        #endregion

        #region "Csr"
        public const string Pages_Master_Sales_Csr = "Pages.Master.Sales.MstSleVehicleProductCsr";
        public const string Pages_Master_Sales_Csr_Search = "Pages.Master.Sales.MstSleVehicleProductCsr.Search";
        public const string Pages_Master_Sales_Csr_Create = "Pages.Master.Sales.MstSleVehicleProductCsr.Create";
        public const string Pages_Master_Sales_Csr_Edit = "Pages.Master.Sales.MstSleVehicleProductCsr.Edit";
        public const string Pages_Master_Sales_Csr_Delete = "Pages.Master.Sales.MstSleVehicleProductCsr.Delete";
        #endregion

        #region "RecruimentOverview"
        public const string Pages_Master_Sales_Recruitment_Overview = "Pages.Master.Sales.MstSleVehicleProductRecruitmentOverview";
        public const string Pages_Master_Sales_Recruitment_Overview_Search = "Pages.Master.Sales.MstSleVehicleProductRecruitmentOverview.Search";
        public const string Pages_Master_Sales_Recruitment_Overview_Create = "Pages.Master.Sales.MstSleVehicleProductRecruitmentOverview.Create";
        public const string Pages_Master_Sales_Recruitment_Overview_Edit = "Pages.Master.Sales.MstSleVehicleProductRecruitmentOverview.Edit";
        public const string Pages_Master_Sales_Recruitment_Overview_Delete = "Pages.Master.Sales.MstSleVehicleProductRecruitmentOverview.Delete";
        #endregion

        #region "VehicleProductSortBy"
        public const string Pages_Master_Sales_Sort_By = "Pages.Master.Sales.MstSleVehicleProductSortBy";
        public const string Pages_Master_Sales_Sort_By_Search = "Pages.Master.Sales.MstSleVehicleProductSortBy.Search";
        public const string Pages_Master_Sales_Sort_By_Create = "Pages.Master.Sales.MstSleVehicleProductSortBy.Create";
        public const string Pages_Master_Sales_Sort_By_Edit = "Pages.Master.Sales.MstSleVehicleProductSortBy.Edit";
        public const string Pages_Master_Sales_Sort_By_Delete = "Pages.Master.Sales.MstSleVehicleProductSortBy.Delete";
        #endregion

        #region "Recruiment Language"
        public const string Pages_Master_Sales_Recruiment_Language = "Pages.Master.Sales.MstSleVehicleProductRecruimentLanguage";
        public const string Pages_Master_Sales_Recruiment_Language_Search = "Pages.Master.Sales.MstSleVehicleProductRecruimentLanguage.Search";
        public const string Pages_Master_Sales_Recruiment_Language_Create = "Pages.Master.Sales.MstSleVehicleProductRecruimentLanguage.Create";
        public const string Pages_Master_Sales_Recruiment_Language_Edit = "Pages.Master.Sales.MstSleVehicleProductRecruimentLanguage.Edit";
        public const string Pages_Master_Sales_Recruiment_Language_Delete = "Pages.Master.Sales.MstSleVehicleProductRecruimentLanguage.Delete";
        #endregion

        #region "Hashtag"
        public const string Pages_Master_Sales_Hashtag = "Pages.Master.Sales.MstSleVehicleProductHashtag";
        public const string Pages_Master_Sales_Hashtag_Search = "Pages.Master.Sales.MstSleVehicleProductHashtag.Search";
        public const string Pages_Master_Sales_Hashtag_Create = "Pages.Master.Sales.MstSleVehicleProductHashtag.Create";
        public const string Pages_Master_Sales_Hashtag_Edit = "Pages.Master.Sales.MstSleVehicleProductHashtag.Edit";
        public const string Pages_Master_Sales_Hashtag_Delete = "Pages.Master.Sales.MstSleVehicleProductHashtag.Delete";
        #endregion

        #region "Sustainable Development"
        public const string Pages_Master_Sales_SustainableDevelopment = "Pages.Master.Sales.MstSleSustainableDevelopment";
        public const string Pages_Master_Sales_SustainableDevelopment_Search = "Pages.Master.Sales.MstSleSustainableDevelopment.Search";
        public const string Pages_Master_Sales_SustainableDevelopment_Create = "Pages.Master.Sales.MstSleSustainableDevelopment.Create";
        public const string Pages_Master_Sales_SustainableDevelopment_Edit = "Pages.Master.Sales.MstSleSustainableDevelopment.Edit";
        public const string Pages_Master_Sales_SustainableDevelopment_Delete = "Pages.Master.Sales.MstSleSustainableDevelopment.Delete";
        #endregion

        #region "Road tax Period"
        public const string Pages_Master_Sales_Road_Tax_Period = "Pages.Master.Sales.MstsleRoadTaxPeriod";
        public const string Pages_Master_Sales_Road_Tax_Period_Search = "Pages.Master.Sales.MstsleRoadTaxPeriod.Search";
        public const string Pages_Master_Sales_Road_Tax_Period_Create = "Pages.Master.Sales.MstsleRoadTaxPeriod.Create";
        public const string Pages_Master_Sales_Road_Tax_Period_Edit = "Pages.Master.Sales.MstsleRoadTaxPeriod.Edit";
        public const string Pages_Master_Sales_Road_Tax_Period_Delete = "Pages.Master.Sales.MstsleRoadTaxPeriod.Delete";
        #endregion

        #region "Road tax Amount"
        public const string Pages_Master_Sales_Road_Tax_Amount = "Pages.Master.Sales.MstsleRoadTaxAmount";
        public const string Pages_Master_Sales_Road_Tax_Amount_Search = "Pages.Master.Sales.MstsleRoadTaxAmount.Search";
        public const string Pages_Master_Sales_Road_Tax_Amount_Create = "Pages.Master.Sales.MstsleRoadTaxAmount.Create";
        public const string Pages_Master_Sales_Road_Tax_Amount_Edit = "Pages.Master.Sales.MstsleRoadTaxAmount.Edit";
        public const string Pages_Master_Sales_Road_Tax_Amount_Delete = "Pages.Master.Sales.MstsleRoadTaxAmount.Delete";
        #endregion

        #region "Vehicle Transportation"
        public const string Pages_Sales_Menu_Vehicle_Transportation = "Pages.Vehicle.Transportation";
        #region "Route"
        public const string Pages_Master_Sales_Route = "Pages.Master.Sales.MstSleRoute";
        public const string Pages_Master_Sales_Route_Search = "Pages.Master.Sales.MstSleRoute.Search";
        public const string Pages_Master_Sales_Route_Create = "Pages.Master.Sales.MstSleRoute.Create";
        public const string Pages_Master_Sales_Route_Edit = "Pages.Master.Sales.MstSleRoute.Edit";
        public const string Pages_Master_Sales_Route_Delete = "Pages.Master.Sales.MstSleRoute.Delete";
        #endregion

        #region "Transportation Type"
        public const string Pages_Master_Sales_Transportation_Type = "Pages.Master.Sales.MstSleTransporationType";
        public const string Pages_Master_Sales_Transportation_Type_Search = "Pages.Master.Sales.MstSleTransporationType.Search";
        public const string Pages_Master_Sales_Transportation_Type_Create = "Pages.Master.Sales.MstSleTransporationType.Create";
        public const string Pages_Master_Sales_Transportation_Type_Edit = "Pages.Master.Sales.MstSleTransporationType.Edit";
        public const string Pages_Master_Sales_Transportation_Type_Delete = "Pages.Master.Sales.MstSleTransporationType.Delete";
        #endregion

        #region "Transportation Route Setup"
        public const string Pages_Master_Sales_Transportation_Route_Setup = "Pages.Master.Sales.MstSleTransportationRouteSetup";
        public const string Pages_Master_Sales_Transportation_Route_Setup_Search = "Pages.Master.Sales.MstSleTransportationRouteSetup.Search";
        public const string Pages_Master_Sales_Transportation_Route_Setup_Create = "Pages.Master.Sales.MstSleTransportationRouteSetup.Create";
        public const string Pages_Master_Sales_Transportation_Route_Setup_Edit = "Pages.Master.Sales.MstSleTransportationRouteSetup.Edit";
        public const string Pages_Master_Sales_Transportation_Route_Setup_Delete = "Pages.Master.Sales.MstSleTransportationRouteSetup.Delete";
        #endregion

        #endregion


        #region "Product Car Fuel"
        public const string Pages_Master_Sales_ProductCarFuel = "Pages.Master.Sales.MstSleProductCarFuel";
        public const string Pages_Master_Sales_ProductCarFuel_Search = "Pages.Master.Sales.MstSleProductCarFuel.Search";
        public const string Pages_Master_Sales_ProductCarFuel_Create = "Pages.Master.Sales.MstSleProductCarFuel.Create";
        public const string Pages_Master_Sales_ProductCarFuel_Edit = "Pages.Master.Sales.MstSleProductCarFuel.Edit";
        public const string Pages_Master_Sales_ProductCarFuel_Delete = "Pages.Master.Sales.MstSleProductCarFuel.Delete";
        #endregion

        #region "Product Car Origin"
        public const string Pages_Master_Sales_ProductCarOrigin = "Pages.Master.Sales.MstSleProductCarOrigin";
        public const string Pages_Master_Sales_ProductCarOrigin_Search = "Pages.Master.Sales.MstSleProductCarOrigin.Search";
        public const string Pages_Master_Sales_ProductCarOrigin_Create = "Pages.Master.Sales.MstSleProductCarOrigin.Create";
        public const string Pages_Master_Sales_ProductCarOrigin_Edit = "Pages.Master.Sales.MstSleProductCarOrigin.Edit";
        public const string Pages_Master_Sales_ProductCarOrigin_Delete = "Pages.Master.Sales.MstSleProductCarOrigin.Delete";

        #endregion

        #region "Vehicle Product Document Son"
        public const string Pages_Master_Sales_VehicleProductDocumentSon = "Pages.Master.Sales.MstSleVehicleProductDocumentSon";
        public const string Pages_Master_Sales_VehicleProductDocumentSon_Search = "Pages.Master.Sales.MstSleVehicleProductDocumentSon.Search";
        public const string Pages_Master_Sales_VehicleProductDocumentSon_Create = "Pages.Master.Sales.MstSleVehicleProductDocumentSon.Create";
        public const string Pages_Master_Sales_VehicleProductDocumentSon_Edit = "Pages.Master.Sales.MstSleVehicleProductDocumentSon.Edit";
        public const string Pages_Master_Sales_VehicleProductDocumentSon_Delete = "Pages.Master.Sales.MstSleVehicleProductDocumentSon.Delete";
        #endregion

        #region "Loyalty"
        public const string Pages_Sales_Menu_Loyalty = "Pages.Loyalty";

        #region "LoyaltyCustomer"
        public const string Pages_Sales_Menu_Loyalty_Customer = "Pages.Loyalty.LoyaltyCustomer";
        public const string Pages_Sales_Menu_Loyalty_Customer_Search = "Pages.Loyalty.LoyaltyCustomer.Search";
        public const string Pages_Sales_Menu_Loyalty_Customer_Create = "Pages.Loyalty.LoyaltyCustomer.Create";
        public const string Pages_Sales_Menu_Loyalty_Customer_Edit = "Pages.Loyalty.LoyaltyCustomer.Edit";
        public const string Pages_Sales_Menu_Loyalty_Customer_Delete = "Pages.Loyalty.LoyaltyCustomer.Delete";
        #endregion


        #region "LoyaltyGift"
        public const string Pages_Sales_Menu_Loyalty_Gift = "Pages.Loyalty.MstSleLoyaltyGift";
        public const string Pages_Sales_Menu_Loyalty_Gift_Search = "Pages.Loyalty.MstSleLoyaltyGift.Search";
        public const string Pages_Sales_Menu_Loyalty_Gift_Create = "Pages.Loyalty.MstSleLoyaltyGift.Create";
        public const string Pages_Sales_Menu_Loyalty_Gift_Edit = "Pages.Loyalty.MstSleLoyaltyGift.Edit";
        public const string Pages_Sales_Menu_Loyalty_Gift_Delete = "Pages.Loyalty.MstSleLoyaltyGift.Delete";
        public const string Pages_Sales_Menu_Loyalty_Gift_TMV = "Pages.Loyalty.MstSleLoyaltyGiftTMV";
        #endregion

        #region "LoyaltyGiftItem"
        public const string Pages_Sales_Menu_Loyalty_Gift_Item = "Pages.Loyalty.MstSleLoyaltyGiftItem";
        public const string Pages_Sales_Menu_Loyalty_Gift_Item_Search = "Pages.Loyalty.MstSleLoyaltyGiftItem.Search";
        public const string Pages_Sales_Menu_Loyalty_Gift_Item_Create = "Pages.Loyalty.MstSleLoyaltyGiftItem.Create";
        public const string Pages_Sales_Menu_Loyalty_Gift_Item_Edit = "Pages.Loyalty.MstSleLoyaltyGiftItem.Edit";
        public const string Pages_Sales_Menu_Loyalty_Gift_Item_Delete = "Pages.Loyalty.MstSleLoyaltyGiftItem.Delete";

        #endregion

        #region "LoyaltRank"
        public const string Pages_Sales_Menu_Loyalty_Rank = "Pages.Loyalty.MstSleLoyaltyRank";
        public const string Pages_Sales_Menu_Loyalty_Rank_Search = "Pages.Loyalty.MstSleLoyaltyRank.Search";
        public const string Pages_Sales_Menu_Loyalty_Rank_Create = "Pages.Loyalty.MstSleLoyaltyRank.Create";
        public const string Pages_Sales_Menu_Loyalty_Rank_Edit = "Pages.Loyalty.MstSleLoyaltyRank.Edit";
        public const string Pages_Sales_Menu_Loyalty_Rank_Delete = "Pages.Loyalty.MstSleLoyaltyRank.Delete";
        #endregion

        #region "LoyaltGain"
        public const string Pages_Sales_Menu_Loyalty_Gain = "Pages.Loyalty.MstSleLoyaltyGain";
        public const string Pages_Sales_Menu_Loyalty_Gain_Search = "Pages.Loyalty.MstSleLoyaltyGain.Search";
        //public const string Pages_Sales_Menu_Loyalty_Gain_Create = "Pages.Loyalty.MstSleLoyaltyGain.Create";
        //public const string Pages_Sales_Menu_Loyalty_Gain_Edit = "Pages.Loyalty.MstSleLoyaltyGain.Edit";
        //public const string Pages_Sales_Menu_Loyalty_Gain_Delete = "Pages.Loyalty.MstSleLoyaltyGain.Delete";
        #endregion

        #region "LoyaltGain"
        public const string Pages_Sales_Menu_Loyalty_Gain_Rank = "Pages.Loyalty.MstSleLoyaltyGainRank";
        public const string Pages_Sales_Menu_Loyalty_Gain_Rank_Search = "Pages.Loyalty.MstSleLoyaltyGainRank.Search";
        //public const string Pages_Sales_Menu_Loyalty_Gain_Create = "Pages.Loyalty.MstSleLoyaltyGain.Create";
        //public const string Pages_Sales_Menu_Loyalty_Gain_Edit = "Pages.Loyalty.MstSleLoyaltyGain.Edit";
        //public const string Pages_Sales_Menu_Loyalty_Gain_Delete = "Pages.Loyalty.MstSleLoyaltyGain.Delete";
        #endregion

        #region "LoyaltScheme"
        public const string Pages_Sales_Menu_Loyalty_Scheme = "Pages.Loyalty.MstSleLoyaltyScheme";
        public const string Pages_Sales_Menu_Loyalty_Scheme_Search = "Pages.Loyalty.MstSleLoyaltyScheme.Search";
        public const string Pages_Sales_Menu_Loyalty_Scheme_Create = "Pages.Loyalty.MstSleLoyaltyScheme.Create";
        public const string Pages_Sales_Menu_Loyalty_Scheme_Edit = "Pages.Loyalty.MstSleLoyaltyScheme.Edit";
        public const string Pages_Sales_Menu_Loyalty_Scheme_Delete = "Pages.Loyalty.MstSleLoyaltyScheme.Delete";
        #endregion

        #region "MstLoyaltyRank"
        public const string Pages_Sales_Menu_Mst_Loyalty_Rank = "Pages.Loyalty.MstLoyaltyRank";
        public const string Pages_Sales_Menu_Mst_Loyalty_Rank_Search = "Pages.Loyalty.MstLoyaltyRank.Search";
        public const string Pages_Sales_Menu_Mst_Loyalty_Rank_Create = "Pages.Loyalty.MstLoyaltyRank.Create";
        public const string Pages_Sales_Menu_Mst_Loyalty_Rank_Edit = "Pages.Loyalty.MstLoyaltyRank.Edit";
        public const string Pages_Sales_Menu_Mst_Loyalty_Rank_Delete = "Pages.Loyalty.MstLoyaltyRank.Delete";
        #endregion

        #region "Loyalty Redeem"
        public const string Pages_Sales_Menu_Loyalty_Redeem = "Pages.Loyalty.MstLoyaltyRedeem";
        public const string Pages_Sales_Menu_Loyalty_Redeem_Search = "Pages.Loyalty.MstLoyaltyRedeem.Search";
        public const string Pages_Sales_Menu_Loyalty_Redeem_Create = "Pages.Loyalty.MstLoyaltyRedeem.Create";
        public const string Pages_Sales_Menu_Loyalty_Redeem_Edit = "Pages.Loyalty.MstLoyaltyRedeem.Edit";
        public const string Pages_Sales_Menu_Loyalty_Redeem_Delete = "Pages.Loyalty.MstLoyaltyRedeem.Delete";
        #endregion

        #region "Loyalty Transaction"
        public const string Pages_Sales_Menu_Loyalty_Transaction = "Pages.Loyalty.MstLoyaltyTransaction";
        public const string Pages_Sales_Menu_Loyalty_Transaction_Search = "Pages.Loyalty.MstLoyaltyTransaction.Search";
        public const string Pages_Sales_Menu_Loyalty_Transaction_Create = "Pages.Loyalty.MstLoyaltyTransaction.Create";
        public const string Pages_Sales_Menu_Loyalty_Transaction_Edit = "Pages.Loyalty.MstLoyaltyTransaction.Edit";
        public const string Pages_Sales_Menu_Loyalty_Transaction_Delete = "Pages.Loyalty.MstLoyaltyTransaction.Delete";
        #endregion

        #region "Loyalty Question"
        public const string Pages_Sales_Menu_Loyalty_Question = "Pages.Loyalty.MstLoyaltyQuestion";
        public const string Pages_Sales_Menu_Loyalty_Question_Search = "Pages.Loyalty.MstLoyaltyQuestion.Search";
        public const string Pages_Sales_Menu_Loyalty_Question_Create = "Pages.Loyalty.MstLoyaltyQuestion.Create";
        public const string Pages_Sales_Menu_Loyalty_Question_Edit = "Pages.Loyalty.MstLoyaltyQuestion.Edit";
        public const string Pages_Sales_Menu_Loyalty_Question_Delete = "Pages.Loyalty.MstLoyaltyQuestion.Delete";
        #endregion

        #region "Loyalty Claim"
        public const string Pages_Sales_Menu_Loyalty_Claim = "Pages.Loyalty.MstLoyaltyClaim";
        public const string Pages_Sales_Menu_Loyalty_Claim_Search = "Pages.Loyalty.MstLoyaltyClaim.Search";
        public const string Pages_Sales_Menu_Loyalty_Claim_Create = "Pages.Loyalty.MstLoyaltyClaim.Create";
        public const string Pages_Sales_Menu_Loyalty_Claim_Edit = "Pages.Loyalty.MstLoyaltyClaim.Edit";
        public const string Pages_Sales_Menu_Loyalty_Claim_Delete = "Pages.Loyalty.MstLoyaltyClaim.Delete";
        #endregion

        #region "Loyalty Job Controlers"
        public const string Pages_Sales_Menu_Loyalty_Config = "Pages.Loyalty.MstLoyaltyConfig";
        public const string Pages_Sales_Menu_Loyalty_Config_Search = "Pages.Loyalty.MstLoyaltyConfig.Search";
        public const string Pages_Sales_Menu_Loyalty_Config_Create = "Pages.Loyalty.MstLoyaltyConfig.Create";
        public const string Pages_Sales_Menu_Loyalty_Config_Edit = "Pages.Loyalty.MstLoyaltyConfig.Edit";
        public const string Pages_Sales_Menu_Loyalty_Config_Delete = "Pages.Loyalty.MstLoyaltyConfig.Delete";
        #endregion


        #endregion

        #region "Vehicle Product Document Parent"
        public const string Pages_Master_Sales_VehicleProductDocumentParent = "Pages.Master.Sales.MstSleVehicleProductDocumentParent";
        public const string Pages_Master_Sales_VehicleProductDocumentParent_Search = "Pages.Master.Sales.MstSleVehicleProductDocumentParent.Search";
        public const string Pages_Master_Sales_VehicleProductDocumentParent_Create = "Pages.Master.Sales.MstSleVehicleProductDocumentParent.Create";
        public const string Pages_Master_Sales_VehicleProductDocumentParent_Edit = "Pages.Master.Sales.MstSleVehicleProductDocumentParent.Edit";
        public const string Pages_Master_Sales_VehicleProductDocumentParent_Delete = "Pages.Master.Sales.MstSleVehicleProductDocumentParent.Delete";
        #endregion
        #region "Vehicle Product Ti Vendor"
        public const string Pages_Master_Sales_VehicleProductTiVendor = "Pages.Master.Sales.MstSleVehicleProductTiVendor";
        public const string Pages_Master_Sales_VehicleProductTiVendor_Search = "Pages.Master.Sales.MstSleVehicleProductTiVendor.Search";
        public const string Pages_Master_Sales_VehicleProductTiVendor_Create = "Pages.Master.Sales.MstSleVehicleProductTiVendor.Create";
        public const string Pages_Master_Sales_VehicleProductTiVendor_Edit = "Pages.Master.Sales.MstSleVehicleProductTiVendor.Edit";
        public const string Pages_Master_Sales_VehicleProductTiVendor_Delete = "Pages.Master.Sales.MstSleVehicleProductTiVendor.Delete";
        #endregion

        #region "Vehicle Product Tecnology Info"
        public const string Pages_Master_Sales_VehicleProductTecnologyInfo = "Pages.Master.Sales.MstSleVehicleProductTecnologyInfo";
        public const string Pages_Master_Sales_VehicleProductTecnologyInfo_Search = "Pages.Master.Sales.MstSleVehicleProductTecnologyInfo.Search";
        public const string Pages_Master_Sales_VehicleProductTecnologyInfo_Create = "Pages.Master.Sales.MstSleVehicleProductTecnologyInfo.Create";
        public const string Pages_Master_Sales_VehicleProductTecnologyInfo_Edit = "Pages.Master.Sales.MstSleVehicleProductTecnologyInfo.Edit";
        public const string Pages_Master_Sales_VehicleProductTecnologyInfo_Delete = "Pages.Master.Sales.MstSleVehicleProductTecnologyInfo.Delete";
        #endregion

        #region "SubCategory"
        public const string Pages_Master_Sales_SubCategory = "Pages.Master.Sales.MstSleSubCategory";
        public const string Pages_Master_Sales_SubCategory_Search = "Pages.Master.Sales.MstSleSubCategory.Search";
        public const string Pages_Master_Sales_SubCategory_Create = "Pages.Master.Sales.MstSleSubCategory.Create";
        public const string Pages_Master_Sales_SubCategory_Edit = "Pages.Master.Sales.MstSleSubCategory.Edit";
        public const string Pages_Master_Sales_SubCategory_Delete = "Pages.Master.Sales.MstSleSubCategory.Delete";
        #endregion

        #region "Vehicle Product TI Question"
        public const string Pages_Master_Sales_VehicleProductTIQuestion = "Pages.Master.Sales.MstSleVehicleProductTIQuestion";
        public const string Pages_Master_Sales_VehicleProductTIQuestion_Search = "Pages.Master.Sales.MstSleVehicleProductTIQuestion.Search";
        public const string Pages_Master_Sales_VehicleProductTIQuestion_Create = "Pages.Master.Sales.MstSleVehicleProductTIQuestion.Create";
        public const string Pages_Master_Sales_VehicleProductTIQuestion_Edit = "Pages.Master.Sales.MstSleVehicleProductTIQuestion.Edit";
        public const string Pages_Master_Sales_VehicleProductTIQuestion_Delete = "Pages.Master.Sales.MstSleVehicleProductTIQuestion.Delete";
        #endregion

        #region "Vehicle Product Introduce"
        public const string Pages_Master_Sales_VehicleProductIntroduce = "Pages.Master.Sales.MstSleVehicleProductIntroduce";
        public const string Pages_Master_Sales_VehicleProductIntroduce_Search = "Pages.Master.Sales.MstSleVehicleProductIntroduce.Search";
        public const string Pages_Master_Sales_VehicleProductIntroduce_Create = "Pages.Master.Sales.MstSleVehicleProductIntroduce.Create";
        public const string Pages_Master_Sales_VehicleProductIntroduce_Edit = "Pages.Master.Sales.MstSleVehicleProductIntroduce.Edit";
        public const string Pages_Master_Sales_VehicleProductIntroduce_Delete = "Pages.Master.Sales.MstSleVehicleProductIntroduce.Delete";
        #endregion

        #region "Vehicle Product TFS"
        public const string Pages_Master_Sales_VehicleProductTFS = "Pages.Master.Sales.MstSleVehicleProductTFS";
        public const string Pages_Master_Sales_VehicleProductTFS_Search = "Pages.Master.Sales.MstSleVehicleProductTFS.Search";
        public const string Pages_Master_Sales_VehicleProductTFS_Create = "Pages.Master.Sales.MstSleVehicleProductTFS.Create";
        public const string Pages_Master_Sales_VehicleProductTFS_Edit = "Pages.Master.Sales.MstSleVehicleProductTFS.Edit";
        public const string Pages_Master_Sales_VehicleProductTFS_Delete = "Pages.Master.Sales.MstSleVehicleProductTFS.Delete";
        #endregion

        #region "MstSleTradeSchool"
        public const string Pages_Master_Sales_TradeSchool = "Pages.Master.Sales.MstSleTradeSchool";
        public const string Pages_Master_Sales_TradeSchool_Search = "Pages.Master.Sales.MstSleTradeSchool.Search";
        public const string Pages_Master_Sales_TradeSchool_Create = "Pages.Master.Sales.MstSleTradeSchool.Create";
        public const string Pages_Master_Sales_TradeSchool_Edit = "Pages.Master.Sales.MstSleTradeSchool.Edit";
        public const string Pages_Master_Sales_TradeSchool_Delete = "Pages.Master.Sales.MstSleTradeSchool.Delete";
        #endregion

        #region "MstSleExamConditions"
        public const string Pages_Master_Sales_ExamConditions = "Pages.Master.Sales.MstSleExamConditions";
        public const string Pages_Master_Sales_ExamConditions_Search = "Pages.Master.Sales.MstSleExamConditions.Search";
        public const string Pages_Master_Sales_ExamConditions_Create = "Pages.Master.Sales.MstSleExamConditions.Create";
        public const string Pages_Master_Sales_ExamConditions_Edit = "Pages.Master.Sales.MstSleExamConditions.Edit";
        public const string Pages_Master_Sales_ExamConditions_Delete = "Pages.Master.Sales.MstSleExamConditions.Delete";
        #endregion

        #region "Vehicle Product News"
        public const string Pages_Master_Sales_VehicleProductNews = "Pages.Master.Sales.MstSleVehicleProductNews";
        public const string Pages_Master_Sales_VehicleProductNews_Search = "Pages.Master.Sales.MstSleVehicleProductNews.Search";
        public const string Pages_Master_Sales_VehicleProductNews_Create = "Pages.Master.Sales.MstSleVehicleProductNews.Create";
        public const string Pages_Master_Sales_VehicleProductNews_Edit = "Pages.Master.Sales.MstSleVehicleProductNews.Edit";
        public const string Pages_Master_Sales_VehicleProductNews_Delete = "Pages.Master.Sales.MstSleVehicleProductNews.Delete";
        #endregion

        #region "Vehicle Product News Category"
        public const string Pages_Master_Sales_VehicleProductNewsCategory = "Pages.Master.Sales.MstSleVehicleProductNewsCategory";
        public const string Pages_Master_Sales_VehicleProductNewsCategory_Search = "Pages.Master.Sales.MstSleVehicleProductNewsCategory.Search";
        public const string Pages_Master_Sales_VehicleProductNewsCategory_Create = "Pages.Master.Sales.MstSleVehicleProductNewsCategory.Create";
        public const string Pages_Master_Sales_VehicleProductNewsCategory_Edit = "Pages.Master.Sales.MstSleVehicleProductNewsCategory.Edit";
        public const string Pages_Master_Sales_VehicleProductNewsCategory_Delete = "Pages.Master.Sales.MstSleVehicleProductNewsCategory.Delete";
        #endregion

        #region "MstSleLocalizationAndExport"
        public const string Pages_Master_Sales_LocalizationAndExport = "Pages.Master.Sales.MstSleLocalizationAndExport";
        public const string Pages_Master_Sales_LocalizationAndExport_Search = "Pages.Master.Sales.MstSleLocalizationAndExport.Search";
        public const string Pages_Master_Sales_LocalizationAndExport_Create = "Pages.Master.Sales.MstSleLocalizationAndExport.Create";
        public const string Pages_Master_Sales_LocalizationAndExport_Edit = "Pages.Master.Sales.MstSleLocalizationAndExport.Edit";
        public const string Pages_Master_Sales_LocalizationAndExport_Delete = "Pages.Master.Sales.MstSleLocalizationAndExport.Delete";
        #endregion

        #region "MstSleVehicleProductNumberSeat"
        public const string Pages_Master_Sales_VehicleProductNumberSeat = "Pages.Master.Sales.MstSleVehicleProductNumberSeat";
        public const string Pages_Master_Sales_VehicleProductNumberSeat_Search = "Pages.Master.Sales.MstSleVehicleProductNumberSeat.Search";
        public const string Pages_Master_Sales_VehicleProductNumberSeat_Create = "Pages.Master.Sales.MstSleVehicleProductNumberSeat.Create";
        public const string Pages_Master_Sales_VehicleProductNumberSeat_Edit = "Pages.Master.Sales.MstSleVehicleProductNumberSeat.Edit";
        public const string Pages_Master_Sales_VehicleProductNumberSeat_Delete = "Pages.Master.Sales.MstSleVehicleProductNumberSeat.Delete";
        #endregion

        #region "MstSleServiceBookingEmail"
        public const string Pages_Master_Sales_ServiceBookingEmail = "Pages.Master.Sales.MstSleServiceBookingEmail";
        public const string Pages_Master_Sales_ServiceBookingEmail_Search = "Pages.Master.Sales.MstSleServiceBookingEmail.Search";
        public const string Pages_Master_Sales_ServiceBookingEmail_Create = "Pages.Master.Sales.MstSleServiceBookingEmail.Create";
        public const string Pages_Master_Sales_ServiceBookingEmail_Edit = "Pages.Master.Sales.MstSleServiceBookingEmail.Edit";
        public const string Pages_Master_Sales_ServiceBookingEmail_Delete = "Pages.Master.Sales.MstSleServiceBookingEmail.Delete";
        #endregion

        #region "MstSleTestDriveEmail"
        public const string Pages_Master_Sales_TestDriveEmail = "Pages.Master.Sales.MstSleTestDriveEmail";
        public const string Pages_Master_Sales_TestDriveEmail_Search = "Pages.Master.Sales.MstSleTestDriveEmail.Search";
        public const string Pages_Master_Sales_TestDriveEmail_Create = "Pages.Master.Sales.MstSleTestDriveEmail.Create";
        public const string Pages_Master_Sales_TestDriveEmail_Edit = "Pages.Master.Sales.MstSleTestDriveEmail.Edit";
        public const string Pages_Master_Sales_TestDriveEmail_Delete = "Pages.Master.Sales.MstSleTestDriveEmail.Delete";
        #endregion

        #region "MstsleDuplicatePhoneEmail"
        public const string Pages_Master_Sales_DuplicatePhoneEmail = "Pages.Master.Sales.MstsleDuplicatePhoneEmail";
        public const string Pages_Master_Sales_DuplicatePhoneEmail_Search = "Pages.Master.Sales.MstsleDuplicatePhoneEmail.Search";
        public const string Pages_Master_Sales_DuplicatePhoneEmail_Create = "Pages.Master.Sales.MstsleDuplicatePhoneEmail.Create";
        public const string Pages_Master_Sales_DuplicatePhoneEmail_Edit = "Pages.Master.Sales.MstsleDuplicatePhoneEmail.Edit";
        public const string Pages_Master_Sales_DuplicatePhoneEmail_Delete = "Pages.Master.Sales.MstsleDuplicatePhoneEmail.Delete";
        #endregion


        #region "MstSleVehicleProductPriceRange"
        public const string Pages_Master_Sales_VehicleProductPriceRange = "Pages.Master.Sales.MstSleVehicleProductPriceRange";
        public const string Pages_Master_Sales_VehicleProductPriceRange_Search = "Pages.Master.Sales.MstSleVehicleProductPriceRange.Search";
        public const string Pages_Master_Sales_VehicleProductPriceRange_Create = "Pages.Master.Sales.MstSleVehicleProductPriceRange.Create";
        public const string Pages_Master_Sales_VehicleProductPriceRange_Edit = "Pages.Master.Sales.MstSleVehicleProductPriceRange.Edit";
        public const string Pages_Master_Sales_VehicleProductPriceRange_Delete = "Pages.Master.Sales.MstSleVehicleProductPriceRange.Delete";
        #endregion

        #region "MstSleVehicleProductBanner"
        public const string Pages_Master_Sales_VehicleProductBanner = "Pages.Master.Sales.MstSleVehicleProductBanner";
        public const string Pages_Master_Sales_VehicleProductBanner_Search = "Pages.Master.Sales.MstSleVehicleProductBanner.Search";
        public const string Pages_Master_Sales_VehicleProductBanner_Create = "Pages.Master.Sales.MstSleVehicleProductBanner.Create";
        public const string Pages_Master_Sales_VehicleProductBanner_Edit = "Pages.Master.Sales.MstSleVehicleProductBanner.Edit";
        public const string Pages_Master_Sales_VehicleProductBanner_Delete = "Pages.Master.Sales.MstSleVehicleProductBanner.Delete";
        #endregion

        #region "MstSleVehicleProductRouter"
        public const string Pages_Master_Sales_VehicleProductRouter = "Pages.Master.Sales.MstSleVehicleProductRouter";
        public const string Pages_Master_Sales_VehicleProductRouter_Search = "Pages.Master.Sales.MstSleVehicleProductRouter.Search";
        public const string Pages_Master_Sales_VehicleProductRouter_Create = "Pages.Master.Sales.MstSleVehicleProductRouter.Create";
        public const string Pages_Master_Sales_VehicleProductRouter_Edit = "Pages.Master.Sales.MstSleVehicleProductRouter.Edit";
        public const string Pages_Master_Sales_VehicleProductRouter_Delete = "Pages.Master.Sales.MstSleVehicleProductRouter.Delete";
        #endregion

        #region "MstSleVehicleProductBooking"
        public const string Pages_Master_Sales_VehicleProductBooking = "Pages.Master.Sales.MstSleVehicleProductBooking";
        public const string Pages_Master_Sales_VehicleProductBooking_Search = "Pages.Master.Sales.MstSleVehicleProductBooking.Search";
        #endregion

        #region "MstSleCitizenIdentificationOriginal"
        public const string Pages__Master_Sales_CitizenIdentificationOriginal = "Pages.Master.Sales.MstSleCitizenIdentificationOriginal";
        #endregion

        #region "MstSleErrorNotiInfomation"
        public const string Pages_Master_Sales_ErrorNotilnFomation = "Pages.Master.Sales.MstSleErrorNotilnFomation";
        public const string Pages_Master_Sales_ErrorNotilnFomation_Search = "Pages.Master.Sales.MstSleErrorNotilnFomation.Search";
        public const string Pages_Master_Sales_ErrorNotilnFomation_Create = "Pages.Master.Sales.MstSleErrorNotilnFomation.Create";
        public const string Pages_Master_Sales_ErrorNotiInfomation_Edit = "Pages.Master.Sales.MstSleErrorNotilnFomation.Edit";
        public const string Pages_Master_Sales_ErrorNotiInfomation_Delete = "Pages.Master.Sales.MstSleErrorNotilnFomation.Delete";
        #endregion

        #region "MstSleLocalizationCommunicate"
        public const string Pages_Master_Sales_LocalizationCommunicate = "Pages.Master.Sales.MstSleLocalizationCommunicate";
        public const string Pages_Master_Sales_LocalizationCommunicate_Search = "Pages.Master.Sales.MstSleLocalizationCommunicate.Search";
        public const string Pages_Master_Sales_LocalizationCommunicate_Create = "Pages.Master.Sales.MstSleLocalizationCommunicate.Create";
        public const string Pages_Master_Sales_LocalizationCommunicate_Edit = "Pages.Master.Sales.MstSleLocalizationCommunicate.Edit";
        public const string Pages_Master_Sales_LocalizationCommunicate_Delete = "Pages.Master.Sales.MstSleLocalizationCommunicate.Delete";
        #endregion

        #region "MstSleLocalizationAccessoryDetail"
        public const string Pages_Master_Sales_LocalizationAccessoryDetail = "Pages.Master.Sales.MstSleLocalizationAccessoryDetail";
        public const string Pages_Master_Sales_LocalizationAccessoryDetail_Search = "Pages.Master.Sales.MstSleLocalizationAccessoryDetail.Search";
        public const string Pages_Master_Sales_LocalizationAccessoryDetail_Create = "Pages.Master.Sales.MstSleLocalizationAccessoryDetail.Create";
        public const string Pages_Master_Sales_LocalizationAccessoryDetail_Edit = "Pages.Master.Sales.MstSleLocalizationAccessoryDetail.Edit";
        public const string Pages_Master_Sales_LocalizationAccessoryDetail_Delete = "Pages.Master.Sales.MstSleLocalizationAccessoryDetail.Delete";
        #endregion

        #region "MstSleLocalizationDocumentCategory"
        public const string Pages_Master_Sales_LocalizationDocumentCategory = "Pages.Master.Sales.MstSleLocalizationDocumentCategory";
        public const string Pages_Master_Sales_LocalizationDocumentCategory_Search = "Pages.Master.Sales.MstSleLocalizationDocumentCategory.Search";
        public const string Pages_Master_Sales_LocalizationDocumentCategory_Create = "Pages.Master.Sales.MstSleLocalizationDocumentCategory.Create";
        public const string Pages_Master_Sales_LocalizationDocumentCategory_Edit = "Pages.Master.Sales.MstSleLocalizationDocumentCategory.Edit";
        public const string Pages_Master_Sales_LocalizationDocumentCategory_Delete = "Pages.Master.Sales.MstSleLocalizationDocumentCategory.Delete";
        #endregion

        #region "MstSleLocalizationCategory"
        public const string Pages_Master_Sales_LocalizationCategory = "Pages.Master.Sales.MstSleLocalizationCategory";
        public const string Pages_Master_Sales_LocalizationCategory_Search = "Pages.Master.Sales.MstSleLocalizationCategory.Search";
        public const string Pages_Master_Sales_LocalizationCategory_Create = "Pages.Master.Sales.MstSleLocalizationCategory.Create";
        public const string Pages_Master_Sales_LocalizationCategory_Edit = "Pages.Master.Sales.MstSleLocalizationCategory.Edit";
        public const string Pages_Master_Sales_LocalizationCategory_Delete = "Pages.Master.Sales.MstSleLocalizationCategory.Delete";
        #endregion

        #region "MstSleVehicleProductIntroduceRouter"
        public const string Pages_Master_Sales_VehicleProductIntroduceRouter = "Pages.Master.Sales.MstSleVehicleProductIntroduceRouter";
        public const string Pages_Master_Sales_VehicleProductIntroduceRouter_Search = "Pages.Master.Sales.MstSleVehicleProductIntroduceRouter.Search";
        public const string Pages_Master_Sales_VehicleProductIntroduceRouter_Create = "Pages.Master.Sales.MstSleVehicleProductIntroduceRouter.Create";
        public const string Pages_Master_Sales_VehicleProductIntroduceRouter_Edit = "Pages.Master.Sales.MstSleVehicleProductIntroduceRouter.Edit";
        public const string Pages_Master_Sales_VehicleProductIntroduceRouter_Delete = "Pages.Master.Sales.MstSleVehicleProductIntroduceRouter.Delete";
        #endregion

        #region "MstSleVehicleProductIntroduceCategory"
        public const string Pages_Master_Sales_VehicleProductIntroduceCategory = "Pages.Master.Sales.MstSleVehicleProductIntroduceCategory";
        public const string Pages_Master_Sales_VehicleProductIntroduceCategory_Search = "Pages.Master.Sales.MstSleVehicleProductIntroduceCategory.Search";
        public const string Pages_Master_Sales_VehicleProductIntroduceCategory_Create = "Pages.Master.Sales.MstSleVehicleProductIntroduceCategory.Create";
        public const string Pages_Master_Sales_VehicleProductIntroduceCategory_Edit = "Pages.Master.Sales.MstSleVehicleProductIntroduceCategory.Edit";
        public const string Pages_Master_Sales_VehicleProductIntroduceCategory_Delete = "Pages.Master.Sales.MstSleVehicleProductIntroduceCategory.Delete";
        #endregion

        #region "MstSleVehicleProductCommunicate"
        public const string Pages_Master_Sales_VehicleProductCommunicate = "Pages.Master.Sales.MstSleVehicleProductCommunicate";
        public const string Pages_Master_Sales_VehicleProductCommunicate_Search = "Pages.Master.Sales.MstSleVehicleProductCommunicate.Search";
        public const string Pages_Master_Sales_VehicleProductCommunicate_Create = "Pages.Master.Sales.MstSleVehicleProductCommunicate.Create";
        public const string Pages_Master_Sales_VehicleProductCommunicate_Edit = "Pages.Master.Sales.MstSleVehicleProductCommunicate.Edit";
        public const string Pages_Master_Sales_VehicleProductCommunicate_Delete = "Pages.Master.Sales.MstSleVehicleProductCommunicate.Delete";
        #endregion

        #region "MstSleRecruitmentDepartmentUnit"
        public const string Pages_Master_Sales_RecruitmentDepartmentUnit = "Pages.Master.Sales.MstSleRecruitmentDepartmentUnit";
        public const string Pages_Master_Sales_RecruitmentDepartmentUnit_Search = "Pages.Master.Sales.MstSleRecruitmentDepartmentUnit.Search";
        public const string Pages_Master_Sales_RecruitmentDepartmentUnit_Create = "Pages.Master.Sales.MstSleRecruitmentDepartmentUnit.Create";
        public const string Pages_Master_Sales_RecruitmentDepartmentUnit_Edit = "Pages.Master.Sales.MstSleRecruitmentDepartmentUnit.Edit";
        public const string Pages_Master_Sales_RecruitmentDepartmentUnit_Delete = "Pages.Master.Sales.MstSleRecruitmentDepartmentUnit.Delete";
        #endregion

        #region "MstSleRecruitmentWeb"
        public const string Pages_Master_Sales_RecruitmentWeb = "Pages.Master.Sales.MstSleRecruitmentWeb";
        public const string Pages_Master_Sales_RecruitmentWeb_Search = "Pages.Master.Sales.MstSleRecruitmentWeb.Search";
        public const string Pages_Master_Sales_RecruitmentWeb_Create = "Pages.Master.Sales.MstSleRecruitmentWeb.Create";
        public const string Pages_Master_Sales_RecruitmentWeb_Edit = "Pages.Master.Sales.MstSleRecruitmentWeb.Edit";
        public const string Pages_Master_Sales_RecruitmentWeb_Delete = "Pages.Master.Sales.MstSleRecruitmentWeb.Delete";
        #endregion

        #region "Vehicle Product Value Chain"
        public const string Pages_Master_Sales_VehicleProductValueChain = "Pages.Master.Sales.MstSleVehicleProductValueChain";
        public const string Pages_Master_Sales_VehicleProductValueChain_Search = "Pages.Master.Sales.MstSleVehicleProductValueChain.Search";
        public const string Pages_Master_Sales_VehicleProductValueChain_Create = "Pages.Master.Sales.MstSleVehicleProductValueChain.Create";
        public const string Pages_Master_Sales_VehicleProductValueChain_Edit = "Pages.Master.Sales.MstSleVehicleProductValueChain.Edit";
        public const string Pages_Master_Sales_VehicleProductValueChain_Delete = "Pages.Master.Sales.MstSleVehicleProductValueChain.Delete";
        #endregion
        #region "Accessory Types"
        public const string Pages_Master_Sales_AccessoryTypes = "Pages.Master.Sales.MstSleAccessoryTypes";
        public const string Pages_Master_Sales_AccessoryTypes_Search = "Pages.Master.Sales.MstSleAccessoryTypes.Search";
        public const string Pages_Master_Sales_AccessoryTypes_Create = "Pages.Master.Sales.MstSleAccessoryTypes.Create";
        public const string Pages_Master_Sales_AccessoryTypes_Edit = "Pages.Master.Sales.MstSleAccessoryTypes.Edit";
        public const string Pages_Master_Sales_AccessoryTypes_Delete = "Pages.Master.Sales.MstSleAccessoryTypes.Delete";
        #endregion

        #region "Delivery Date Change Reason"
        public const string Pages_Master_Sales_Delivery_Date_Change_Reason = "Pages.Master.Sales.MstSleDeliveryDateChangeReason";
        public const string Pages_Master_Sales_DeliveryDateChangeReason_Search = "Pages.Master.Sales.MstSleDeliveryDateChangeReason.Search";
        public const string Pages_Master_Sales_DeliveryDateChangeReason_Create = "Pages.Master.Sales.MstSleDeliveryDateChangeReason.Create";
        public const string Pages_Master_Sales_DeliveryDateChangeReason_Edit = "Pages.Master.Sales.MstSleDeliveryDateChangeReason.Edit";
        public const string Pages_Master_Sales_DeliveryDateChangeReason_Delete = "Pages.Master.Sales.MstSleDeliveryDateChangeReason.Delete";
        #endregion

        #region "Accessories Manufactor"
        public const string Pages_Master_Sales_Accessory_Manufactor = "Pages.Master.Sales.MstSleAccessoryManufactor";
        public const string Pages_Master_Sales_Accessory_Manufactor_Search = "Pages.Master.Sales.MstSleAccessoryManufactor.Search";
        public const string Pages_Master_Sales_Accessory_Manufactor_Create = "Pages.Master.Sales.MstSleAccessoryManufactor.Create";
        public const string Pages_Master_Sales_Accessory_Manufactor_Edit = "Pages.Master.Sales.MstSleAccessoryManufactor.Edit";
        public const string Pages_Master_Sales_Accessory_Manufactor_Delete = "Pages.Master.Sales.MstSleAccessoryManufactor.Delete";
        #endregion

        #region "Finance Classic Package"
        public const string Pages_Master_Sales_FinanceClassicPackage = "Pages.Master.Sales.MstSleFinanceClassicPackage";
        public const string Pages_Master_Sales_FinanceClassicPackage_Search = "Pages.Master.Sales.MstSleFinanceClassicPackage.Search";
        public const string Pages_Master_Sales_FinanceClassicPackage_Create = "Pages.Master.Sales.MstSleFinanceClassicPackage.Create";
        public const string Pages_Master_Sales_FinanceClassicPackage_Edit = "Pages.Master.Sales.MstSleFinanceClassicPackage.Edit";
        public const string Pages_Master_Sales_FinanceClassicPackage_Delete = "Pages.Master.Sales.MstSleFinanceClassicPackage.Delete";

        #endregion
        #region "Master InSurance Company"
        public const string Pages_Master_Sales_MstSleInsuranceCompany = "Pages.Master.Sales.MstSleInsuranceCompany";
        public const string Pages_Master_Sales_MstSleInsuranceCompany_Search = "Pages.Master.Sales.MstSleInsuranceCompany.Search";
        public const string Pages_Master_Sales_MstSleInsuranceCompany_Create = "Pages.Master.Sales.MstSleInsuranceCompany.Create";
        public const string Pages_Master_Sales_MstSleInsuranceCompany_Edit = "Pages.Master.Sales.MstSleInsuranceCompany.Edit";
        public const string Pages_Master_Sales_MstSleInsuranceCompany_Delete = "Pages.Master.Sales.MstSleInsuranceCompany.Delete";
        #endregion

        #region "Master Vehicle Price"
        public const string Pages_Master_Sales_VehiclePrice = "Pages.Master.Sales.MstSleVehiclePrice";
        public const string Pages_Master_Sales_VehiclePrice_Search = "Pages.Master.Sales.MstSleVehiclePrice.Search";
        public const string Pages_Master_Sales_VehiclePrice_Create = "Pages.Master.Sales.MstSleVehiclePrice.Create";
        public const string Pages_Master_Sales_VehiclePrice_Edit = "Pages.Master.Sales.MstSleVehiclePrice.Edit";
        public const string Pages_Master_Sales_VehiclePrice_Delete = "Pages.Master.Sales.MstSleVehiclePrice.Delete";

        public const string Pages_Master_Sales_VehiclePrice_Submit = "Pages.Master.Sales.MstSleVehiclePrice.Submit";
        public const string Pages_Master_Sales_VehiclePrice_Reject = "Pages.Master.Sales.MstSleVehiclePrice.Reject";
        public const string Pages_Master_Sales_VehiclePrice_Approve = "Pages.Master.Sales.MstSleVehiclePrice.Approve";
        public const string Pages_Master_Sales_VehiclePrice_CreateVehiclePriceChange = "Pages.Master.Sales.MstSleVehiclePrice.CreateVehiclePriceChange";

        public const string Pages_Master_Sales_VehiclePrice_ImportVehiclePrice = "Pages.Master.Sales.MstSleVehiclePrice.ImportVehiclePrice";

        #endregion

        #region "Master Fleet Vehicle Price"
        public const string Pages_Master_Sales_FleetVehiclePrice = "Pages.Master.Sales.MstSleFleetVehiclePrice";
        public const string Pages_Master_Sales_FleetVehiclePrice_Search = "Pages.Master.Sales.MstSleFleetVehiclePrice.Search";
        public const string Pages_Master_Sales_FleetVehiclePrice_Create = "Pages.Master.Sales.MstSleFleetVehiclePrice.Create";
        public const string Pages_Master_Sales_FleetVehiclePrice_Edit = "Pages.Master.Sales.MstSleFleetVehiclePrice.Edit";
        public const string Pages_Master_Sales_FleetVehiclePrice_Delete = "Pages.Master.Sales.MstSleFleetVehiclePrice.Delete";
        #endregion
        #region "Master Fleet Range"
        public const string Pages_Master_Sales_FleetRange = "Pages.Master.Sales.MstSleFleetRange";
        public const string Pages_Master_Sales_FleetRange_Search = "Pages.Master.Sales.MstSleFleetRange.Search";
        public const string Pages_Master_Sales_FleetRange_Create_Or_Edit = "Pages.Master.Sales.MstSleFleetRange.CreateOrEdit";
        public const string Pages_Master_Sales_FleetRange_Delete = "Pages.Master.Sales.MstSleFleetRange.Delete";
        #endregion
        #region "Master Vehicle Image"
        public const string Pages_Master_Sales_VehicleImage = "Pages.Master.Sales.MstSleVehicleImage";
        public const string Pages_Master_Sales_VehicleImage_Search = "Pages.Master.Sales.MstSleVehicleImage.Search";
        public const string Pages_Master_Sales_VehicleImage_Create = "Pages.Master.Sales.MstSleVehicleImage.Create";
        public const string Pages_Master_Sales_VehicleImage_Edit = "Pages.Master.Sales.MstSleVehicleImage.Edit";
        public const string Pages_Master_Sales_VehicleImage_Delete = "Pages.Master.Sales.MstSleVehicleImage.Delete";
        #endregion
        #region "Master Engien Type"
        public const string Pages_Master_Sales_EngineType = "Pages.Master.Sales.MstSleEngineType";
        public const string Pages_Master_Sales_EngineType_Search = "Pages.Master.Sales.MstSleEngineType.Search";
        public const string Pages_Master_Sales_EngineType_Create = "Pages.Master.Sales.MstSleEngineType.Create";
        public const string Pages_Master_Sales_EngineType_Edit = "Pages.Master.Sales.MstSleEngineType.Edit";
        public const string Pages_Master_Sales_EngineType_Delete = "Pages.Master.Sales.MstSleEngineType.Delete";
        #endregion

        #region "Master Insurance TI Product"
        public const string Pages_Master_Sales_MstSleInsuranceTIProduct = "Pages.Master.Sales.MstSleInsuranceTIProduct";
        public const string Pages_Master_Sales_MstSleInsuranceTIProduct_Search = "Pages.Master.Sales.MstSleInsuranceTIProduct.Search";
        public const string Pages_Master_Sales_MstSleInsuranceTIProduct_Create = "Pages.Master.Sales.MstSleInsuranceTIProduct.Create";
        public const string Pages_Master_Sales_MstSleInsuranceTIProduct_Edit = "Pages.Master.Sales.MstSleInsuranceTIProduct.Edit";
        public const string Pages_Master_Sales_MstSleInsuranceTIProduct_Delete = "Pages.Master.Sales.MstSleInsuranceTIProduct.Delete";

        #endregion
        #region "Master Insurance Non TI Product"
        public const string Pages_Master_Sales_MstSleInsuranceNonTIProduct = "Pages.Master.Sales.MstSleInsuranceNonTIProduct";
        public const string Pages_Master_Sales_MstSleInsuranceNonTIProduct_Search = "Pages.Master.Sales.MstSleInsuranceNonTIProduct.Search";
        public const string Pages_Master_Sales_MstSleInsuranceNonTIProduct_Create = "Pages.Master.Sales.MstSleInsuranceNonTIProduct.Create";
        public const string Pages_Master_Sales_MstSleInsuranceNonTIProduct_Edit = "Pages.Master.Sales.MstSleInsuranceNonTIProduct.Edit";
        public const string Pages_Master_Sales_MstSleInsuranceNonTIProduct_Delete = "Pages.Master.Sales.MstSleInsuranceNonTIProduct.Delete";
        public const string Pages_Master_Sales_MstSleInsuranceNonTIProduct_GetMstSleInsuranceNonTIProductToExcel = "Pages.Master.Sales.MstSleInsuranceNonTIProduct.GetMstSleInsuranceNonTIProductToExcel";

        #endregion


        #region "Gender"
        public const string Pages_Master_Sales_Gender = "Pages.Master.Sales.MstSleGender";
        public const string Pages_Master_Sales_Gender_Create = "Pages.Master.Sales.MstSleGender.Create";
        public const string Pages_Master_Sales_Gender_Edit = "Pages.Master.Sales.MstSleGender.Edit";
        public const string Pages_Master_Sales_Gender_Delete = "Pages.Master.Sales.MstSleGender.Delete";
        public const string Pages_Master_Sales_Gender_Search = "Pages.Master.Sales.MstSleGender.Search";
        #endregion

        #region "Marital Status"
        public const string Pages_Master_Sales_MaritalStatus = "Pages.Master.Sales.MstSleMaritalStatus";
        public const string Pages_Master_Sales_MaritalStatus_Create = "Pages.Master.Sales.MstSleMaritalStatus.Create";
        public const string Pages_Master_Sales_MaritalStatus_Edit = "Pages.Master.Sales.MstSleMaritalStatus.Edit";
        public const string Pages_Master_Sales_MaritalStatus_Delete = "Pages.Master.Sales.MstSleMaritalStatus.Delete";
        public const string Pages_Master_Sales_MaritalStatus_Search = "Pages.Master.Sales.MstSleMaritalStatus.Search";
        #endregion

        #region "Master Sale Unit"
        public const string Pages_Master_Sales_Unit = "Pages.Master.Sales.MstSleUnit";
        public const string Pages_Master_Sales_Unit_Create = "Pages.Master.Sales.MstSleUnit.Create";
        public const string Pages_Master_Sales_Unit_Edit = "Pages.Master.Sales.MstSleUnit.Edit";
        public const string Pages_Master_Sales_Unit_Delete = "Pages.Master.Sales.MstSleUnit.Delete";
        public const string Pages_Master_Sales_Unit_Search = "Pages.Master.Sales.MstSleUnit.Search";
        #endregion

        #region "Master Insurance Type"
        public const string Pages_Master_Sales_InsuranceType = "Pages.Master.Sales.MstSleInsuranceType";
        public const string Pages_Master_Sales_InsuranceType_Create = "Pages.Master.Sales.MstSleInsuranceType.Create";
        public const string Pages_Master_Sales_InsuranceType_Edit = "Pages.Master.Sales.MstSleInsuranceType.Edit";
        public const string Pages_Master_Sales_InsuranceType_Delete = "Pages.Master.Sales.MstSleInsuranceType.Delete";
        public const string Pages_Master_Sales_InsuranceType_Search = "Pages.Master.Sales.MstSleInsuranceType.Search";

        #endregion

        #region "Master Sale PPM Package"
        public const string Pages_Master_Sales_PPM_Package = "Pages.Master.Sales.MstSlePpmPackage";
        public const string Pages_Master_Sales_PPM_Package_Create = "Pages.Master.Sales.MstSlePpmPackage.Create";
        public const string Pages_Master_Sales_PPM_Package_Edit = "Pages.Master.Sales.MstSlePpmPackage.Edit";
        public const string Pages_Master_Sales_PPM_Package_Delete = "Pages.Master.Sales.MstSlePpmPackage.Delete";
        public const string Pages_Master_Sales_PPM_Package_Search = "Pages.Master.Sales.MstSlePpmPackage.Search";
        #endregion

        #region "Master Sale Dealer Contract Info"
        public const string Pages_Master_Sales_Dealer_Contract_Info = "Pages.Master.Sales.MstSleDealerContractInfo";
        public const string Pages_Master_Sales_Dealer_Contract_Info_Create = "Pages.Master.Sales.MstSleDealerContractInfo.Create";
        public const string Pages_Master_Sales_Dealer_Contract_Info_Edit = "Pages.Master.Sales.MstSleDealerContractInfo.Edit";
        public const string Pages_Master_Sales_Dealer_Contract_Info_Delete = "Pages.Master.Sales.MstSleDealerContractInfo.Delete";
        public const string Pages_Master_Sales_Dealer_Contract_Info_Search = "Pages.Master.Sales.MstSleDealerContractInfo.Search";
        public const string Pages_Master_Sales_Dealer_Contract_Info_Edit_Dealer = "Pages.Master.Sales.MstSleDealerContractInfo.Edit.Dealer";
        #endregion

        #region "Delivery Plan Lead Time"
        public const string Pages_Master_Sales_Delivery_Plan_Lead_Time_Info = "Pages.Master.Sales.MstSleDeliveryPlanLeadTimeInfo";
        public const string Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Create = "Pages.Master.Sales.MstSleDeliveryPlanLeadTimeInfo.Create";
        public const string Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Edit = "Pages.Master.Sales.MstSleDeliveryPlanLeadTimeInfo.Edit";
        public const string Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Delete = "Pages.Master.Sales.MstSleDeliveryPlanLeadTimeInfo.Delete";
        public const string Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Search = "Pages.Master.Sales.MstSleDeliveryPlanLeadTimeInfo.Search";
        public const string Pages_Master_Sales_Delivery_Plan_Lead_Time_Info_Dealer = "Pages.Master.Sales.MstSleDeliveryPlanLeadTimeInfo.Edit.Dealer";
        #endregion

        #region "Day Off"
        public const string Pages_Master_Sales_Day_Off_Info = "Pages.Master.Sales.MstSleDayOffInfo";
        public const string Pages_Master_Sales_Day_Off_Info_Create = "Pages.Master.Sales.MstSleDayOffInfo.Create";
        public const string Pages_Master_Sales_Day_Off_Info_Edit = "Pages.Master.Sales.MstSleDayOffInfo.Edit";
        public const string Pages_Master_Sales_Day_Off_Info_Delete = "Pages.Master.Sales.MstSleDayOffInfo.Delete";
        public const string Pages_Master_Sales_Day_Off_Info_Search = "Pages.Master.Sales.MstSleDayOffInfo.Search";
        public const string Pages_Master_Sales_Day_Off_Info_Dealer = "Pages.Master.Sales.MstSleDayOffInfo.Edit.Dealer";
        #endregion

        #region "Logistic Company"
        public const string Pages_Master_Sales_Logistic_Company_Info = "Pages.Master.Sales.MstSleLogisticCompanyInfo";
        public const string Pages_Master_Sales_Logistic_Company_Info_Create = "Pages.Master.Sales.MstSleLogisticCompanyInfo.Create";
        public const string Pages_Master_Sales_Logistic_Company_Info_Edit = "Pages.Master.Sales.MstSleLogisticCompanyInfo.Edit";
        public const string Pages_Master_Sales_Logistic_Company_Info_Delete = "Pages.Master.Sales.MstSleLogisticCompanyInfo.Delete";
        public const string Pages_Master_Sales_Logistic_Company_Info_Search = "Pages.Master.Sales.MstSleLogisticCompanyInfo.Search";
        #endregion

        #region " Yard"
        public const string Pages_Master_Sales_Yard = "Pages.Master.Sales.MstSleYard";
        public const string Pages_Master_Sales_Yard_Create = "Pages.Master.Sales.MstSleYard.Create";
        public const string Pages_Master_Sales_Yard_Edit = "Pages.Master.Sales.MstSleYard.Edit";
        public const string Pages_Master_Sales_Yard_Delete = "Pages.Master.Sales.MstSleYard.Delete";
        public const string Pages_Master_Sales_Yard_Search = "Pages.Master.Sales.MstSleYard.Search";
        #endregion

        #region " Extends Warrty Master"
        public const string Pages_Master_Extended_Warranty = "Pages.Master.Sales.MstSleExtendedWarranty";
        public const string Pages_Master_Extended_Warranty_Create = "Pages.Master.Sales.MstSleExtendedWarranty.Create";
        public const string Pages_Master_Extended_Warranty_Edit = "Pages.Master.Sales.MstSleExtendedWarranty.Edit";
        public const string Pages_Master_Extended_Warranty_Delete = "Pages.Master.Sales.MstSleExtendedWarranty.Delete";
        public const string Pages_Master_Extended_Warranty_Search = "Pages.Master.Sales.MstSleExtendedWarranty.Search";
        #endregion



        #region "Master Accessories"
        public const string Pages_Master_Sales_Accessories = "Pages.Master.Sales.MstSleAccessories";
        public const string Pages_Master_Sales_Accessories_Search = "Pages.Master.Sales.MstSleAccessories.Search";
        public const string Pages_Master_Sales_Accessories_Create = "Pages.Master.Sales.MstSleAccessories.Create";
        public const string Pages_Master_Sales_Accessories_Edit = "Pages.Master.Sales.MstSleAccessories.Edit";
        public const string Pages_Master_Sales_Accessories_Delete = "Pages.Master.Sales.MstSleAccessories.Delete";
        #endregion

        #region "MstSleEmployeeCourse"
        public const string Pages_Master_Sales_EmployeeCourse = "Pages.Master.Sales.MstSleEmployeeCourse";
        public const string Pages_Master_Sales_EmployeeCourse_Search = "Pages.Master.Sales.MstSleEmployeeCourse.Search";
        public const string Pages_Master_Sales_EmployeeCourses_Create = "Pages.Master.Sales.MstSleEmployeeCourse.Create";
        public const string Pages_Master_Sales_EmployeeCourse_Edit = "Pages.Master.Sales.MstSleEmployeeCourse.Edit";
        public const string Pages_Master_Sales_EmployeeCourse_Delete = "Pages.Master.Sales.MstSleEmployeeCourse.Delete";
        #endregion

        #region "Master Accessories Package"
        public const string Pages_Master_Sales_Accessories_Package = "Pages.Master.Sales.MstSleAccessoriesPackage";
        public const string Pages_Master_Sales_Accessories_Package_Search = "Pages.Master.Sales.MstSleAccessoriesPackage.Search";
        public const string Pages_Master_Sales_Accessories_Package_Create = "Pages.Master.Sales.MstSleAccessoriesPackage.Create";
        public const string Pages_Master_Sales_Accessories_Package_Edit = "Pages.Master.Sales.MstSleAccessoriesPackage.Edit";
        public const string Pages_Master_Sales_Accessories_Package_Delete = "Pages.Master.Sales.MstSleAccessoriesPackage.Delete";
        #endregion

        #region "Master Model"
        public const string Pages_Master_Sales_Model_Grade = "Pages.Master.Sales.MstSleModelGrade";
        public const string Pages_Master_Sales_Model_Grade_Search = "Pages.Master.Sales.MstSleModelGrade.Search";
        public const string Pages_Master_Sales_Model_Grade_Create = "Pages.Master.Sales.MstSleModelGrade.Create";
        public const string Pages_Master_Sales_Model_Grade_Edit = "Pages.Master.Sales.MstSleModelGrade.Edit";
        public const string Pages_Master_Sales_Model_Grade_Delete = "Pages.Master.Sales.MstSleModelGrade.Delete";
        #endregion

        #region "Master Contract Roles"
        public const string Pages_Master_Sales_Contract_Roles = "Pages.Master.Sales.MstSleSaleContractRoles";
        public const string Pages_Master_Sales_Contract_Roles_Create = "Pages.Master.Sales.MstSleSaleContractRoles.Create";
        public const string Pages_Master_Sales_Contract_Roles_Edit = "Pages.Master.Sales.MstSleSaleContractRoles.Edit";
        public const string Pages_Master_Sales_Contract_Roles_Delete = "Pages.Master.Sales.MstSleSaleContractRoles.Delete";
        public const string Pages_Master_Sales_Contract_Roles_Search = "Pages.Master.Sales.MstSleSaleContractRoles.Search";
        #endregion


        #region "ReasonOfNA"
        public const string Pages_Master_Sales_ReasonOfNA = "Pages.Master.Sales.MstSleReasonOfNA";
        public const string Pages_Master_Sales_ReasonOfNA_Create = "Pages.Master.Sales.MstSleReasonOfNA.Create";
        public const string Pages_Master_Sales_ReasonOfNA_Edit = "Pages.Master.Sales.MstSleReasonOfNA.Edit";
        public const string Pages_Master_Sales_ReasonOfNA_Delete = "Pages.Master.Sales.MstSleReasonOfNA.Delete";
        public const string Pages_Master_Sales_ReasonOfNA_Search = "Pages.Master.Sales.MstSleReasonOfNA.Search";
        #endregion

        #region "InsurancePurpose"
        public const string Pages_Master_Sales_InsurancePurpose = "Pages.Master.Sales.MstSleInsurancePurpose";
        public const string Pages_Master_Sales_InsurancePurpose_Create = "Pages.Master.Sales.MstSleInsurancePurpose.Create";
        public const string Pages_Master_Sales_InsurancePurpose_Edit = "Pages.Master.Sales.MstSleInsurancePurpose.Edit";
        public const string Pages_Master_Sales_InsurancePurpose_Delete = "Pages.Master.Sales.MstSleInsurancePurpose.Delete";
        public const string Pages_Master_Sales_InsurancePurpose_Search = "Pages.Master.Sales.MstSleInsurancePurpose.Search";
        #endregion

        #region "Bank"
        public const string Pages_Master_Sales_Bank = "Pages.Master.Sales.MstSleBank";
        public const string Pages_Master_Sales_Bank_Search = "Pages.Master.Sales.MstSleBank.Search";
        public const string Pages_Master_Sales_Bank_Create = "Pages.Master.Sales.MstSleBank.Create";
        public const string Pages_Master_Sales_Bank_Edit = "Pages.Master.Sales.MstSleBank.Edit";
        public const string Pages_Master_Sales_Bank_Delete = "Pages.Master.Sales.MstSleBank.Delete";
        #endregion

        #region "MstSleActiveAccesoryFinance"
        public const string Pages_Master_Sales_ActiveAccesoryFinance = "Pages.Master.Sales.ActiveAccesoryFinance";
        public const string Pages_Master_Sales_ActiveAccesoryFinance_Search = "Pages.Master.Sales.ActiveAccesoryFinance.Search";
        public const string Pages_Master_Sales_ActiveAccesoryFinance_Create = "Pages.Master.Sales.ActiveAccesoryFinance.Create";
        public const string Pages_Master_Sales_ActiveAccesoryFinance_Delete = "Pages.Master.Sales.ActiveAccesoryFinance.Delete";
        public const string Pages_Master_Sales_ActiveAccesoryFinance_Edit = "Pages.Master.Sales.ActiveAccesoryFinance.Edit";
        #endregion    
        #region "MstSleActiveInsuranceFinance"
        public const string Pages_Master_Sales_ActiveInsuranceFinance = "Pages.Master.Sales.ActiveInsuranceFinance";
        public const string Pages_Master_Sales_ActiveInsuranceFinance_Search = "Pages.Master.Sales.ActiveInsuranceFinance.Search";
        public const string Pages_Master_Sales_ActiveInsuranceFinance_Create = "Pages.Master.Sales.ActiveInsuranceFinance.Create";
        public const string Pages_Master_Sales_ActiveInsuranceFinance_Delete = "Pages.Master.Sales.ActiveInsuranceFinance.Delete";
        public const string Pages_Master_Sales_ActiveInsuranceFinance_Edit = "Pages.Master.Sales.ActiveInsuranceFinance.Edit";
        #endregion

        #region "PaymentTypeCommission"
        public const string Pages_Master_Sales_PaymentTypeCommission = "Pages.Master.Sales.MstSlePaymentTypeCommission";
        public const string Pages_Master_Sales_PaymentTypeCommission_Search = "Pages.Master.Sales.MstSlePaymentTypeCommission.Search";
        public const string Pages_Master_Sales_PaymentTypeCommission_Create = "Pages.Master.Sales.MstSlePaymentTypeCommission.Create";
        public const string Pages_Master_Sales_PaymentTypeCommission_Edit = "Pages.Master.Sales.MstSlePaymentTypeCommission.Edit";
        public const string Pages_Master_Sales_PaymentTypeCommission_Delete = "Pages.Master.Sales.MstSlePaymentTypeCommission.Delete";
        #endregion

        #region "ReasonOfNC"
        public const string Pages_Master_Sales_ReasonOfNC = "Pages.Master.Sales.MstSleReasonOfNC";
        public const string Pages_Master_Sales_ReasonOfNC_Create = "Pages.Master.Sales.MstSleReasonOfNC.Create";
        public const string Pages_Master_Sales_ReasonOfNC_Edit = "Pages.Master.Sales.MstSleReasonOfNC.Edit";
        public const string Pages_Master_Sales_ReasonOfNC_Delete = "Pages.Master.Sales.MstSleReasonOfNC.Delete";
        public const string Pages_Master_Sales_ReasonOfNC_Search = "Pages.Master.Sales.MstSleReasonOfNC.Search";
        #endregion

        #region "Master Finance Customer Type"
        public const string Pages_Master_Sales_FinanceCustomerType = "Pages.Master.Sales.FinanceCustomerType";
        public const string Pages_Master_Sales_FinanceCustomerType_Create = "Pages.Master.Sales.FinanceCustomerType.Create";
        public const string Pages_Master_Sales_FinanceCustomerType_Edit = "Pages.Master.Sales.FinanceCustomerType.Edit";
        public const string Pages_Master_Sales_FinanceCustomerType_Delete = "Pages.Master.Sales.FinanceCustomerType.Delete";
        public const string Pages_Master_Sales_FinanceCustomerType_Search = "Pages.Master.Sales.FinanceCustomerType.Search";
        #endregion

        #region "Insurance Compulsory Third Party Liability Fee"
        public const string Pages_Master_Sales_InsuranceCompulsory = "Pages.Master.Sales.InsuranceCompulsory";
        public const string Pages_Master_Sales_InsuranceCompulsory_Create = "Pages.Master.Sales.InsuranceCompulsory.Create";
        public const string Pages_Master_Sales_InsuranceCompulsory_Edit = "Pages.Master.Sales.InsuranceCompulsory.Edit";
        public const string Pages_Master_Sales_InsuranceCompulsory_Delete = "Pages.Master.Sales.InsuranceCompulsory.Delete";
        public const string Pages_Master_Sales_InsuranceCompulsory_Search = "Pages.Master.Sales.InsuranceCompulsory.Search";

        #endregion

        #region "Insurance Physical Damage Fee"
        public const string Pages_Master_Sales_InsurancePhysical = "Pages.Master.Sales.InsurancePhysical";
        public const string Pages_Master_Sales_InsurancePhysical_Create = "Pages.Master.Sales.InsurancePhysical.Create";
        public const string Pages_Master_Sales_InsurancePhysical_Edit = "Pages.Master.Sales.InsurancePhysical.Edit";
        public const string Pages_Master_Sales_InsurancePhysical_Delete = "Pages.Master.Sales.InsurancePhysical.Delete";
        public const string Pages_Master_Sales_InsurancePhysical_Search = "Pages.Master.Sales.InsurancePhysical.Search";

        #endregion

        #region "Insurance Voluntarily Third Party Liability Fee"
        public const string Pages_Master_Sales_InsuranceVoluntarily = "Pages.Master.Sales.InsuranceVoluntarily";
        public const string Pages_Master_Sales_InsuranceVoluntarily_Create = "Pages.Master.Sales.InsuranceVoluntarily.Create";
        public const string Pages_Master_Sales_InsuranceVoluntarily_Edit = "Pages.Master.Sales.InsuranceVoluntarily.Edit";
        public const string Pages_Master_Sales_InsuranceVoluntarily_Delete = "Pages.Master.Sales.InsuranceVoluntarily.Delete";
        public const string Pages_Master_Sales_InsuranceVoluntarily_Search = "Pages.Master.Sales.InsuranceVoluntarily.Search";

        #endregion

        #region "Insurance Term"
        public const string Pages_Master_Sales_InsuranceTerm = "Pages.Master.Sales.InsuranceTerm";
        public const string Pages_Master_Sales_InsuranceTerm_Create = "Pages.Master.Sales.InsuranceTerm.Create";
        public const string Pages_Master_Sales_InsuranceTerm_Edit = "Pages.Master.Sales.InsuranceTerm.Edit";
        public const string Pages_Master_Sales_InsuranceTerm_Delete = "Pages.Master.Sales.InsuranceTerm.Delete";
        public const string Pages_Master_Sales_InsuranceTerm_Search = "Pages.Master.Sales.InsuranceTerm.Search";

        #endregion

        #region "Product Tecnical Spec"
        public const string Pages_Master_Sales_ProductTechnicalSpec = "Pages.Master.Sales.ProductTechnicalSpec";
        public const string Pages_Master_Sales_ProductTechnicalSpec_Create = "Pages.Master.Sales.ProductTechnicalSpec.Create";
        public const string Pages_Master_Sales_ProductTechnicalSpec_Edit = "Pages.Master.Sales.ProductTechnicalSpec.Edit";
        public const string Pages_Master_Sales_ProductTechnicalSpec_Delete = "Pages.Master.Sales.ProductTechnicalSpec.Delete";
        public const string Pages_Master_Sales_ProductTechnicalSpec_Search = "Pages.Master.Sales.ProductTechnicalSpec.Search";
        #endregion

        #region "Product Tecnical Spec BigGroup"
        public const string Pages_Master_Sales_ProductTechnicalSpecBigGroup = "Pages.Master.Sales.ProductTechnicalSpecBigGroup";
        public const string Pages_Master_Sales_ProductTechnicalSpecBigGroup_Create = "Pages.Master.Sales.ProductTechnicalSpecBigGroup.Create";
        public const string Pages_Master_Sales_ProductTechnicalSpecBigGroup_Edit = "Pages.Master.Sales.ProductTechnicalSpecBigGroup.Edit";
        public const string Pages_Master_Sales_ProductTechnicalSpecBigGroup_Delete = "Pages.Master.Sales.ProductTechnicalSpecBigGroup.Delete";
        public const string Pages_Master_Sales_ProductTechnicalSpecBigGroup_Search = "Pages.Master.Sales.ProductTechnicalSpecBigGroup.Search";
        #endregion

        #region "Product Tecnical Spec Group"
        public const string Pages_Master_Sales_ProductTechnicalSpecGroup = "Pages.Master.Sales.ProductTechnicalSpecGroup";
        public const string Pages_Master_Sales_ProductTechnicalSpecGroup_Create = "Pages.Master.Sales.ProductTechnicalSpecGroup.Create";
        public const string Pages_Master_Sales_ProductTechnicalSpecGroup_Edit = "Pages.Master.Sales.ProductTechnicalSpecGroup.Edit";
        public const string Pages_Master_Sales_ProductTechnicalSpecGroup_Delete = "Pages.Master.Sales.ProductTechnicalSpecGroup.Delete";
        public const string Pages_Master_Sales_ProductTechnicalSpecGroup_Search = "Pages.Master.Sales.ProductTechnicalSpecGroup.Search";
        #endregion

        #region "Product Tecnical Spec Detail"
        public const string Pages_Master_Sales_ProductTechnicalSpecDetail = "Pages.Master.Sales.ProductTechnicalSpecDetail";
        public const string Pages_Master_Sales_ProductTechnicalSpecDetail_Create = "Pages.Master.Sales.ProductTechnicalSpecDetail.Create";
        public const string Pages_Master_Sales_ProductTechnicalSpecDetail_Edit = "Pages.Master.Sales.ProductTechnicalSpecDetail.Edit";
        public const string Pages_Master_Sales_ProductTechnicalSpecDetail_Delete = "Pages.Master.Sales.ProductTechnicalSpecDetail.Delete";
        public const string Pages_Master_Sales_ProductTechnicalSpecDetail_Search = "Pages.Master.Sales.ProductTechnicalSpecDetail.Search";
        #endregion

        #region "Product Tecnical Spec Color"
        public const string Pages_Master_Sales_ProductTechnicalSpecColor = "Pages.Master.Sales.ProductTechnicalSpecColor";
        public const string Pages_Master_Sales_ProductTechnicalSpecColor_Create = "Pages.Master.Sales.ProductTechnicalSpecColor.Create";
        public const string Pages_Master_Sales_ProductTechnicalSpecColor_Edit = "Pages.Master.Sales.ProductTechnicalSpecColor.Edit";
        public const string Pages_Master_Sales_ProductTechnicalSpecColor_Delete = "Pages.Master.Sales.ProductTechnicalSpecColor.Delete";
        public const string Pages_Master_Sales_ProductTechnicalSpecColor_Search = "Pages.Master.Sales.ProductTechnicalSpecColor.Search";
        #endregion
        #region "vehicle product email register"
        public const string Pages_Master_Sales_EmailRegister = "Pages.Master.Sales.EmailRegister";
        public const string Pages_Master_Sales_EmailRegister_Search = "Pages.Master.Sales.EmailRegister.Search";
        #endregion

        #region "vehicle product promotion"

        public const string Pages_Master_Sales_ProductPromotion = "Pages.Master.Sales.ProductPromotion";
        public const string Pages_Master_Sales_ProductPromotion_Create = "Pages.Master.Sales.ProductPromotion.Create";
        public const string Pages_Master_Sales_ProductPromotion_Edit = "Pages.Master.Sales.ProductPromotion.Edit";
        public const string Pages_Master_Sales_ProductPromotion_Delete = "Pages.Master.Sales.ProductPromotion.Delete";
        public const string Pages_Master_Sales_ProductPromotion_Search = "Pages.Master.Sales.ProductPromotion.Search";
        #endregion


        #region "vehicle product recruiment language "
        public const string Pages_Master_Sales_VehicleProductRecruimentLanguage = "Pages.Master.Sales.VehicleProductRecruimentLanguage";
        public const string Pages_Master_Sales_VehicleProductRecruimentLanguage_Create = "Pages.Master.Sales.VehicleProductRecruimentLanguage.Create";
        public const string Pages_Master_Sales_VehicleProductRecruimentLanguage_Edit = "Pages.Master.Sales.VehicleProductRecruimentLanguage.Edit";
        public const string Pages_Master_Sales_VehicleProductRecruimentLanguage_Delete = "Pages.Master.Sales.VehicleProductRecruimentLanguage.Delete";
        public const string Pages_Master_Sales_VehicleProductRecruimentLanguage_Search = "Pages.Master.Sales.VehicleProductRecruimentLanguage.Search";
        #endregion
        #region "father perrmissions"
        public const string Pages_Master_Sales_NewsPromotion = "Pages.Master.Sales.NewsPromotion";
        public const string Pages_Master_Sales_VehicleSpecifications = "Pages.Master.Sales.VehicleSpecifications";
        public const string Pages_Master_Sales_ImageCar = "Pages.Master.Sales.ImageCar";
        public const string Pages_Master_Sales_ToyotaVN = "Pages.Master.Sales.ToyotaVN";
        public const string Pages_Master_Sales_InsuranceToyota = "Pages.Master.Sales.InsuranceToyota";
        public const string Pages_Master_Sales_LocalizationAndExportFather = "Pages.Master.Sales.LocalizationAndExportFather";
        public const string Pages_Master_Sales_CsrAndTvf = "Pages.Master.Sales.CsrAndTvf";
        public const string Pages_Master_Sales_Maintenance = "Pages.Master.Sales.Maintenance";

        #endregion

        #region "Contact By"
        public const string Pages_Master_Sales_ContactBy = "Pages.Master.Sales.ContactBy";
        public const string Pages_Master_Sales_ContactBy_Create = "Pages.Master.Sales.ContactBy.Create";
        public const string Pages_Master_Sales_ContactBy_Edit = "Pages.Master.Sales.ContactBy.Edit";
        public const string Pages_Master_Sales_ContactBy_Delete = "Pages.Master.Sales.ContactBy.Delete";
        public const string Pages_Master_Sales_ContactBy_Search = "Pages.Master.Sales.ContactBy.Search";
        #endregion

        #region "Department"
        public const string Pages_Master_Sales_Department = "Pages.Master.Sales.MstSleDepartment";
        public const string Pages_Master_Sales_Department_Create = "Pages.Master.Sales.MstSleDepartment.Create";
        public const string Pages_Master_Sales_Department_Edit = "Pages.Master.Sales.MstSleDepartment.Edit";
        public const string Pages_Master_Sales_Department_Delete = "Pages.Master.Sales.MstSleDepartment.Delete";
        public const string Pages_Master_Sales_Department_Search = "Pages.Master.Sales.MstSleDepartment.Search";
        #endregion

        #region "Certificate"
        public const string Pages_Master_Sales_MstSleCertificate = "Pages.Master.Sales.MstSleCertificate";
        public const string Pages_Master_Sales_MstSleCertificate_Create = "Pages.Master.Sales.MstSleCertificate.Create";
        public const string Pages_Master_Sales_MstSleCertificate_Edit = "Pages.Master.Sales.MstSleCertificate.Edit";
        public const string Pages_Master_Sales_MstSleCertificate_Delete = "Pages.Master.Sales.MstSleCertificate.Delete";
        public const string Pages_Master_Sales_MstSleCertificate_Search = "Pages.Master.Sales.MstSleCertificate.Search";
        #endregion

        #region "ScoringRules"
        public const string Pages_Master_Sales_MstSleScoringRules = "Pages.Master.Sales.MstSleScoringRules";
        public const string Pages_Master_Sales_MstSleScoringRules_Create = "Pages.Master.Sales.MstSleScoringRules.Create";
        public const string Pages_Master_Sales_MstSleScoringRules_Edit = "Pages.Master.Sales.MstSleScoringRules.Edit";
        public const string Pages_Master_Sales_MstSleScoringRules_Delete = "Pages.Master.Sales.MstSleScoringRules.Delete";
        public const string Pages_Master_Sales_MstSleScoringRules_Search = "Pages.Master.Sales.MstSleScoringRules.Search";
        #endregion

        #region "Regulation"
        public const string Pages_Master_Sales_MstSleRegulation = "Pages.Master.Sales.MstSleRegulation";
        public const string Pages_Master_Sales_MstSleRegulation_Create = "Pages.Master.Sales.MstSleRegulation.Create";
        public const string Pages_Master_Sales_MstSleRegulation_Edit = "Pages.Master.Sales.MstSleRegulation.Edit";
        public const string Pages_Master_Sales_MstSleRegulation_Delete = "Pages.Master.Sales.MstSleRegulation.Delete";
        public const string Pages_Master_Sales_MstSleRegulation_Search = "Pages.Master.Sales.MstSleRegulation.Search";
        #endregion

        #region "ServiceLocation"
        public const string Pages_Master_Sales_MstSleServiceLocation = "Pages.Master.Sales.MstSleServiceLocation";
        public const string Pages_Master_Sales_MstSleServiceLocation_Create = "Pages.Master.Sales.MstSleServiceLocation.Create";
        public const string Pages_Master_Sales_MstSleServiceLocation_Edit = "Pages.Master.Sales.MstSleServiceLocation.Edit";
        public const string Pages_Master_Sales_MstSleServiceLocation_Delete = "Pages.Master.Sales.MstSleServiceLocation.Delete";
        public const string Pages_Master_Sales_MstSleServiceLocation_Search = "Pages.Master.Sales.MstSleServiceLocation.Search";
        #endregion

        #region "Master Insurance People In Car"
        public const string Pages_Master_Sales_InsurancePeopleInCar = "Pages.Master.Sales.MstSleInsurancePeopleInCar";
        public const string Pages_Master_Sales_InsurancePeopleInCar_Search = "Pages.Master.Sales.MstSleInsurancePeopleInCar.Search";
        public const string Pages_Master_Sales_InsurancePeopleInCar_Create = "Pages.Master.Sales.MstSleInsurancePeopleInCar.Create";
        public const string Pages_Master_Sales_InsurancePeopleInCar_Edit = "Pages.Master.Sales.MstSleInsurancePeopleInCar.Edit";
        public const string Pages_Master_Sales_InsurancePeopleInCar_Delete = "Pages.Master.Sales.MstSleInsurancePeopleInCar.Delete";
        #endregion

        #region "Master Vehicle Product Maintenance Level"
        public const string Pages_Master_Sales_VehicleProductMaintenanceLevel = "Pages.Master.Sales.MstSleVehicleProductMaintenanceLevel";
        public const string Pages_Master_Sales_VehicleProductMaintenanceLevel_Search = "Pages.Master.Sales.MstSleVehicleProductMaintenanceLevel.Search";
        public const string Pages_Master_Sales_VehicleProductMaintenanceLevel_Create = "Pages.Master.Sales.MstSleVehicleProductMaintenanceLevel.Create";
        public const string Pages_Master_Sales_VehicleProductMaintenanceLevel_Edit = "Pages.Master.Sales.MstSleVehicleProductMaintenanceLevel.Edit";
        public const string Pages_Master_Sales_VehicleProductMaintenanceLevel_Delete = "Pages.Master.Sales.MstSleVehicleProductMaintenanceLevel.Delete";
        #endregion

        #region "Master Vehicle Product Maintenance By Model"
        public const string Pages_Master_Sales_VehicleProductMaintenanceByModel = "Pages.Master.Sales.MstSleVehicleProductMaintenanceByModel";
        public const string Pages_Master_Sales_VehicleProductMaintenanceByModel_Search = "Pages.Master.Sales.MstSleVehicleProductMaintenanceByModel.Search";
        public const string Pages_Master_Sales_VehicleProductMaintenanceByModel_Create = "Pages.Master.Sales.MstSleVehicleProductMaintenanceByModel.Create";
        public const string Pages_Master_Sales_VehicleProductMaintenanceByModel_Edit = "Pages.Master.Sales.MstSleVehicleProductMaintenanceByModel.Edit";
        public const string Pages_Master_Sales_VehicleProductMaintenanceByModel_Delete = "Pages.Master.Sales.MstSleVehicleProductMaintenanceByModel.Delete";
        #endregion

        #region "Cert Type"
        public const string Pages_Master_Sales_MstSleCertType = "Pages.Master.Sales.MstSleCertType";
        public const string Pages_Master_Sales_MstSleCertType_Create = "Pages.Master.Sales.MstSleCertType.Create";
        public const string Pages_Master_Sales_MstSleCertType_Edit = "Pages.Master.Sales.MstSleCertType.Edit";
        public const string Pages_Master_Sales_MstSleCertType_Delete = "Pages.Master.Sales.MstSleCertType.Delete";
        public const string Pages_Master_Sales_MstSleCertType_Search = "Pages.Master.Sales.MstSleCertType.Search";
        #endregion

        #region "Cert"
        public const string Pages_Master_Sales_MstSleCert = "Pages.Master.Sales.MstSleCert";
        public const string Pages_Master_Sales_MstSleCert_Create = "Pages.Master.Sales.MstSleCert.Create";
        public const string Pages_Master_Sales_MstSleCert_Edit = "Pages.Master.Sales.MstSleCert.Edit";
        public const string Pages_Master_Sales_MstSleCert_Delete = "Pages.Master.Sales.MstSleCert.Delete";
        public const string Pages_Master_Sales_MstSleCert_Search = "Pages.Master.Sales.MstSleCert.Search";
        #endregion

        #region "Quantity Expected"
        public const string Pages_Master_Sales_MstSleProductQuantityExpected = "Pages.Master.Sales.MstSleProductQuantityExpected";
        public const string Pages_Master_Sales_MstSleProductQuantityExpected_Create = "Pages.Master.Sales.MstSleProductQuantityExpected.Create";
        public const string Pages_Master_Sales_MstSleProductQuantityExpected_Edit = "Pages.Master.Sales.MstSleProductQuantityExpected.Edit";
        public const string Pages_Master_Sales_MstSleProductQuantityExpected_Delete = "Pages.Master.Sales.MstSleProductQuantityExpected.Delete";
        public const string Pages_Master_Sales_MstSleProductQuantityExpected_Search = "Pages.Master.Sales.MstSleProductQuantityExpected.Search";
        #endregion

        #region "Concern Product"
        public const string Pages_Master_Sales_MstSleProductConcern = "Pages.Master.Sales.MstSleProductConcern";
        public const string Pages_Master_Sales_MstSleProductConcern_Create = "Pages.Master.Sales.MstSleProductConcern.Create";
        public const string Pages_Master_Sales_MstSleProductConcern_Edit = "Pages.Master.Sales.MstSleProductConcern.Edit";
        public const string Pages_Master_Sales_MstSleProductConcern_Delete = "Pages.Master.Sales.MstSleProductConcern.Delete";
        public const string Pages_Master_Sales_MstSleProductConcern_Search = "Pages.Master.Sales.MstSleProductConcern.Search";
        #endregion

        #endregion

        #region Fuction
        #region SalesProposalApprover
        public const string Pages_Sales_SalesProposalApprover = "Pages.Sales.SalesProposalApprover";
        public const string Pages_Sales_SalesProposalApprover_InsertProposalApprover = "Pages.Sales.SalesProposalApprover.InsertProposalApprover";
        public const string Pages_Sales_SalesProposalApprover_GetSalePersonManagers = "Pages.Sales.SalesProposalApprover.GetSalePersonManagers";
        public const string Pages_Sales_SalesProposalApprover_GetSalesProposalApprover = "Pages.Sales.SalesProposalApprover.GetSalesProposalApprover";
        public const string Pages_Sales_SalesProposalApprover_Approve = "Pages.Sales.SalesProposalApprover.Approve";
        public const string Pages_Sales_SalesProposalApprover_Reject = "Pages.Sales.SalesProposalApprover.Reject";
        public const string Pages_Sales_SalesProposalApprover_GetListForwardTo = "Pages.Sales.SalesProposalApprover.GetListForwardTo";
        public const string Pages_Sales_SalesProposalApprover_GetNameCustomerWithmodeProposal = "Pages.Sales.SalesProposalApprover.GetNameCustomerWithmodeProposal";
        public const string Pages_Sales_SalesProposalApprover_GetUserId = "Pages.Sales.SalesProposalApprover.GetUserId";

        #endregion
        #region ChartDashBoard
        public const string Pages_Sales_ChartDashBoard = "Pages.Sales.ChartDashBoard";
        public const string Pages_Sales_ChartDashBoard_GetDataChartProvince = "Pages.Sales.ChartDashBoard.GetDataChartProvince";
        public const string Pages_Sales_ChartDashBoard_GetDataChartDistrict = "Pages.Sales.ChartDashBoard.GetDataChartDistrict";
        public const string Pages_Sales_ChartDashBoard_GetDataChartCustomerType = "Pages.Sales.ChartDashBoard.GetDataChartCustomerType";
        public const string Pages_Sales_ChartDashBoard_GetDataChartCustomerStatus = "Pages.Sales.ChartDashBoard.GetDataChartCustomerStatus";
        public const string Pages_Sales_ChartDashBoard_GetDataChartModel = "Pages.Sales.ChartDashBoard.GetDataChartModel";
        public const string Pages_Sales_ChartDashBoard_GetDataChartSource = "Pages.Sales.ChartDashBoard.GetDataChartSource";
        #endregion
        #region SaleContract
        public const string Pages_Sales_SaleContract = "Pages.Sales.SaleContract";
        public const string Pages_Sales_SaleContract_Dealer = "Pages.Sales.SaleContractDealer";
        public const string Pages_Sales_SaleContract_GetAllContract = "Pages.Sales.SaleContract.GetAllContract";
        public const string Pages_Sales_SaleContract_GetContractForView = "Pages.Sales.SaleContract.GetContractForView";
        public const string Pages_Sales_SaleContract_GetAll = "Pages.Sales.SaleContract.GetAll";
        public const string Pages_Sales_SaleContract_GetAllAdvanceFIlter = "Pages.Sales.SaleContract.GetAllAdvanceFIlter";
        public const string Pages_Sales_SaleContract_GetProposalByContractId = "Pages.Sales.SaleContract.GetProposalByContractId";
        public const string Pages_Sales_SaleContract_GetProposalByContractByPersionId = "Pages.Sales.SaleContract.GetProposalByContractByPersionId";
        public const string Pages_Sales_SaleContract_GetContractByCustomerId = "Pages.Sales.SaleContract.GetContractByCustomerId";
        public const string Pages_Sales_SaleContract_GetContractByPersionId = "Pages.Sales.SaleContract.GetContractByPersionId";
        public const string Pages_Sales_SaleContract_GetContractInfoInput = "Pages.Sales.SaleContract.GetContractInfoInput";
        public const string Pages_Sales_SaleContract_GetCustomerInfo = "Pages.Sales.SaleContract.GetCustomerInfo";
        public const string Pages_Sales_SaleContract_GetCommon = "Pages.Sales.SaleContract.GetCommon";
        public const string Pages_Sales_SaleContract_CreateOrEditPostSaleContract = "Pages.Sales.SaleContract.CreateOrEditPostSaleContract";
        public const string Pages_Sales_SaleContract_GetAllContractById = "Pages.Sales.SaleContract.GetAllContractById";
        public const string Pages_Sales_SaleContract_DeleteContractVehcle = "Pages.Sales.SaleContract.DeleteContractVehcle";
        public const string Pages_Sales_SaleContract_GetNameCustomerWithmodeContract = "Pages.Sales.SaleContract.GetNameCustomerWithmodeContract";
        public const string Pages_Sales_SaleContract_GetListProposalApproveForCustomer = "Pages.Sales.SaleContract.GetListProposalApproveForCustomer";
        public const string Pages_Sales_SaleContract_GetContractForPDF = "Pages.Sales.SaleContract.GetContractForPDF";
        public const string Pages_Sales_SaleContract_DeleteContract = "Pages.Sales.SaleContract.DeleteContract";
        public const string Pages_Sales_SaleContract_Report = "Pages.Sales.SaleContract.Report";
        public const string Pages_Sales_SaleContract_DocumentForm = "Pages.Sales.SaleContract.DocumentForm";
        public const string Pages_Sales_ContractDetail_CreateOrEditContractDetail = "Pages.Sales.SaleContract.CreateOrEditContractDetail";
        public const string Pages_Sales_SaleContract_ImportContract = "Pages.Sales.SaleContract.ImportContract";


        #region SalesContractVehicle
        public const string Pages_Sales_SalesContractVehicle = "Pages.Sales.SalesContractVehicle";
        public const string Pages_Sales_SalesContractVehicle_CreateOrEditSalesContractVehicle = "Pages.Sales.SalesContractVehicle.CreateOrEdit";

        #endregion
        #region SalesContractAccessories
        public const string Pages_Sales_SalesContractAccessories = "Pages.Sales.SalesContractAccessories";
        public const string Pages_Sales_SalesContractAccessories_GetAccessoriesAndPackage = "Pages.Sales.SalesContractAccessories.GetAccessoriesAndPackage";
        public const string Pages_Sales_SalesContractAccessories_GetAccessoryDetailById = "Pages.Sales.SalesContractAccessories.GetAccessoryDetailById";
        public const string Pages_Sales_SalesContractAccessories_CreateOrEditSalesContractAccessories = "Pages.Sales.SalesContractAccessories.CreateOrEditSalesContractAccessories";
        #endregion

        #region SalesContractApprover
        public const string Pages_Sales_SalesContractApprover = "Pages.Sales.SalesContractApprover";
        public const string Pages_Sales_SalesContractApprover_GetListForwardToSalesContractApprover = "Pages.Sales.SalesContractApprover.GetListForwardToSalesContractApprover";
        public const string Pages_Sales_SalesContractApprover_InsertContractApprover = "Pages.Sales.SalesContractApprover.InsertContractApprover";
        public const string Pages_Sales_SalesContractApprover_ApproveSalesContract = "Pages.Sales.SalesContractApprover.ApproveSalesContract";
        public const string Pages_Sales_SalesContractApprover_RejectSalesContract = "Pages.Sales.SalesContractApprover.RejectSalesContract";
        public const string Pages_Sales_SalesContractApprover_Forward = "Pages.Sales.SalesContractApprover.Forward";
        public const string Pages_Sales_SalesContractApprover_GetNameCustomerWithmodeContract = "Pages.Sales.SalesContractApprover.GetNameCustomerWithmodeContract";
        public const string Pages_Sales_SalesContractApprover_CreateSalesCustomerTransactionInfo = "Pages.Sales.SalesContractApprover.CreateSalesCustomerTransactionInfo";

        #endregion
        #region SalesContractCommission
        public const string Pages_Sales_SalesContractCommission = "Pages.Sales.SalesContractCommission";
        public const string Pages_Sales_SalesContractCommission_GetInputForContractCommission = "Pages.Sales.SalesContractCommission.GetInputForContractCommission";
        public const string Pages_Sales_SalesContractCommission_CreateOrEditSalesContractCommission = "Pages.Sales.SalesContractCommission.CreateOrEditSalesContractCommission";

        #endregion
        #region SalesContractFinance
        public const string Pages_Sales_SalesContractFinance = "Pages.Sales.SalesContractFinance";
        public const string Pages_Sales_SalesContractFinance_GetInputForContractFinance = "Pages.Sales.SalesContractFinance.GetInputForContractFinance";
        public const string Pages_Sales_SalesContractFinance_CreateOrEditSalesContractFinance = "Pages.Sales.SalesContractFinance.CreateOrEditSalesContractFinance";
        #endregion
        #region SalesContractInsurance
        public const string Pages_Sales_SalesContractInsurance = "Pages.Sales.SalesContractInsurance";
        public const string Pages_Sales_SalesContractInsurance_GetInputForContractInsurance = "Pages.Sales.SalesContractInsurance.GetInputForContractInsurance";
        public const string Pages_Sales_SalesContractInsurance_CreateOrEditSalesContractInsurance = "Pages.Sales.SalesContractInsurance.CreateOrEditSalesContractInsurance";

        #endregion
        #region SalesContractPPM
        public const string Pages_Sales_SalesContractPPM = "Pages.Sales.SalesContractPPM";
        public const string Pages_Sales_SalesContractPPM_GetAllContractPPMByDealerId = "Pages.Sales.SalesContractInsurance.GetAllContractPPMByDealerId";
        public const string Pages_Sales_SalesContractPPM_CreateOrEditSalesContractPPM = "Pages.Sales.SalesContractInsurance.CreateOrEditSalesContractPPM";
        #endregion

        #region SalesCustomerAnniversary
        public const string Pages_Sales_SalesCustomerAnniversary = "Pages.Sales.SalesCustomerAnniversary";
        public const string Pages_Sales_SalesCustomerAnniversary_CreateSalesCustomerAnniversary = "Pages.Sales.SalesCustomerAnniversary.CreateSalesCustomerAnniversary";
        #endregion

        #region SalesCustomerGallery
        public const string Pages_Sales_SalesCustomerGallery = "Pages.Sales.SalesCustomerGallery";
        public const string Pages_Sales_SalesCustomerGallery_Create = "Pages.Sales.SalesCustomerGallery.CreateSalesCustomerAnniversary";
        public const string Pages_Sales_SalesCustomerGallery_View = "Pages.Sales.SalesCustomerGallery.ViewSalesCustomerAnniversary";
        public const string Pages_Sales_SalesCustomerGallery_Delete = "Pages.Sales.SalesCustomerGallery.DeleteSalesCustomerAnniversary";
        #endregion

        #region SalesCustomerGalleryFolder
        public const string Pages_Sales_SalesCustomerGalleryFolder = "Pages.Sales.SalesCustomerGalleryFolder";
        public const string Pages_Sales_SalesCustomerGalleryFolder_Create = "Pages.Sales.SalesCustomerGalleryFolder.CreateSalesCustomerGalleryFolder";
        public const string Pages_Sales_SalesCustomerGalleryFolder_View = "Pages.Sales.SalesCustomerGalleryFolder.ViewSalesCustomerGalleryFolder";
        public const string Pages_Sales_SalesCustomerGalleryFolder_Delete = "Pages.Sales.SalesCustomerGalleryFolder.DeleteSalesCustomerGalleryFolder";
        #endregion
        #region SalesCustomerSupervisor
        public const string Pages_Sales_SalesCustomerSupervisor = "Pages.Sales.SalesCustomerSupervisor";
        public const string Pages_Sales_SalesCustomerSupervisor_Create = "Pages.Sales.SalesCustomerGalleryFolder.CreateSalesCustomerSupervisor";
        public const string Pages_Sales_SalesCustomerSupervisor_View = "Pages.Sales.SalesCustomerGalleryFolder.ViewSalesCustomerSupervisor";
        public const string Pages_Sales_SalesCustomerSupervisor_Delete = "Pages.Sales.SalesCustomerGalleryFolder.DeleteSalesCustomerSupervisor";
        #endregion


        #endregion
        #endregion

        #region "Sales Business"

        #region "Admin Column"
        public const string Pages_Sales_SalesAdminColumn = "Pages.Sales.SalesAdminColumn";
        public const string Pages_Sales_SalesAdminColumn_Create = "Pages.Sales.SalesAdminColumn.Create";
        public const string Pages_Sales_SalesAdminColumn_Edit = "Pages.Sales.SalesAdminColumn.Edit";
        public const string Pages_Sales_SalesAdminColumn_Delete = "Pages.Sales.SalesAdminColumn.Delete";
        public const string Pages_Sales_SalesAdminColumn_Search = "Pages.Sales.SalesAdminColumn.Search";
        #endregion

        #region "Admin Form"
        public const string Pages_Sales_SalesAdminForm = "Pages.Sales.SalesAdminForm";
        public const string Pages_Sales_SalesAdminForm_Create = "Pages.Sales.SalesAdminForm.Create";
        public const string Pages_Sales_SalesAdminForm_Edit = "Pages.Sales.SalesAdminForm.Edit";
        public const string Pages_Sales_SalesAdminForm_Delete = "Pages.Sales.SalesAdminForm.Delete";
        public const string Pages_Sales_SalesAdminForm_Search = "Pages.Sales.SalesAdminForm.Search";
        #endregion

        #region "Admin Group User"
        public const string Pages_Sales_SalesAdminGroupUser = "Pages.Sales.SalesAdminGroupUser";
        public const string Pages_Sales_SalesAdminGroupUser_Create = "Pages.Sales.SalesAdminGroupUser.Create";
        public const string Pages_Sales_SalesAdminGroupUser_Edit = "Pages.Sales.SalesAdminGroupUser.Edit";
        public const string Pages_Sales_SalesAdminGroupUser_Delete = "Pages.Sales.SalesAdminGroupUser.Delete";
        public const string Pages_Sales_SalesAdminGroupUser_Search = "Pages.Sales.SalesAdminGroupUser.Search";
        #endregion

        #region "Admin Group"
        public const string Pages_Sales_SalesAdminGroup = "Pages.Sales.SalesAdminGroup";
        public const string Pages_Sales_SalesAdminGroup_Create = "Pages.Sales.SalesAdminGroup.Create";
        public const string Pages_Sales_SalesAdminGroup_Edit = "Pages.Sales.SalesAdminGroup.Edit";
        public const string Pages_Sales_SalesAdminGroup_Delete = "Pages.Sales.SalesAdminGroup.Delete";
        public const string Pages_Sales_SalesAdminGroup_Search = "Pages.Sales.SalesAdminGroup.Search";
        #endregion

  /*      #region "Admin Group Column"
        public const string Pages_Sales_SalesAdminGroupColumn = "Pages.Sales.SalesAdminGroupColumn";
        public const string Pages_Sales_SalesAdminGroupColumn_Create = "Pages.Sales.SalesAdminGroupColumn.Create";
        public const string Pages_Sales_SalesAdminGroupColumn_Edit = "Pages.Sales.SalesAdminGroupColumn.Edit";
        public const string Pages_Sales_SalesAdminGroupColumn_Delete = "Pages.Sales.SalesAdminGroupColumn.Delete";
        public const string Pages_Sales_SalesAdminGroupColumn_Search = "Pages.Sales.SalesAdminGroupColumn.Search";
        #endregion*/

        #region "Admin Display Role"
        public const string Pages_Sales_SalesAdminRole = "Pages.Sales.SalesAdminDisplayRole";
        public const string Pages_Sales_SalesAdminRole_Edit = "Pages.Sales.SalesAdminDisplayRole.Edit";
        public const string Pages_Sales_SalesAdminRole_Search = "Pages.Sales.SalesAdminDisplayRole.Search";
        public const string Pages_Sales_SalesAdminRole_Delete = "Pages.Sales.SalesAdminDisplayRole.Delete";
        #endregion

        #endregion

        #region "Sale Contract"
        public const string Pages_Sales_Menu_Contract = "Pages.Sales.Contract";
        #endregion

        #region "Sale Customer"
        public const string Pages_Sales_Menu_Customer = "Pages.Sales.Customer";
        #endregion

        #region "Sale Product"
        public const string Pages_Sales_Menu_Product = "Pages.Master.Product";
        #endregion


        #region "Sale Instructiona lMaterials"
        public const string Pages_Master_Sales_MstSleProductInstructionalMaterial = "Pages.Master.Sales.MstSleProductInstructionalMaterial";
        public const string Pages_Master_Sales_MstSleProductInstructionalMaterial_Create = "Pages.Master.Sales.MstSleProductInstructionalMaterial.Create";
        public const string Pages_Master_Sales_MstSleProductInstructionalMaterial_Edit = "Pages.Master.Sales.MstSleProductInstructionalMaterial.Edit";
        public const string Pages_Master_Sales_MstSleProductInstructionalMaterial_Delete = "Pages.Master.Sales.MstSleProductInstructionalMaterial.Delete";
        public const string Pages_Master_Sales_MstSleProductInstructionalMaterial_Search = "Pages.Master.Sales.MstSleProductInstructionalMaterial.Search";
        #endregion


        #region "Sale Vehicle Stock"
        public const string Pages_Sales_SalesVehicleStock = "Pages.Sales.Vehicle.SalesVehicleStock";
        public const string Pages_Sales_SalesVehicleStock_CreateOrEdit = "Pages.Sales.Vehicle.SalesVehicleStock.CreateOrEdit";
        public const string Pages_Sales_SalesVehicleStock_Search = "Pages.Sales.Vehicle.SalesVehicleStock.Search";
        #endregion
        #region "Mst Sle Audio"
        public const string Pages_Sales_MstSleAudio = "Pages.Sales.Vehicle.MstSleAudio";
        public const string Pages_Sales_MstSleAudio_Create = "Pages.Sales.Vehicle.MstSleAudio.Create";
        public const string Pages_Sales_MstSleAudio_Edit = "Pages.Sales.Vehicle.MstSleAudio.Edit";
        public const string Pages_Sales_MstSleAudio_Delete = "Pages.Sales.Vehicle.MstSleAudio.Delete";
        public const string Pages_Sales_MstSleAudio_Search = "Pages.Sales.Vehicle.MstSleAudio.Search";
        #endregion

        #region "Sale Vehicle"
        public const string Pages_Sales_SalesVehicle = "Pages.Sales.Vehicle.SalesVehicle";
        public const string Pages_Sales_SalesVehicle_TMV = "Pages.Sales.Vehicle.SalesVehicleTMV";
        #endregion

        #region "Sale Vehicle Change Request"
        public const string Pages_Sales_SalesVehicleChangeRequest = "Pages.Sales.Vehicle.SalesVehicleChangeRequest";
        public const string Pages_Sales_SalesVehicleChangeRequest_Search = "Pages.Sales.Vehicle.SalesVehicleChangeRequest.Search";
        public const string Pages_Sales_SalesVehicleChangeRequest_Approve = "Pages.Sales.Vehicle.SalesVehicleChangeRequest.Approve";
        #endregion

        #region "Sale CBU Vehicle"
        public const string Pages_Sales_SalesCbuVehicle = "Pages.Sales.Vehicle.SalesCbuVehicle";
        #endregion
        #region "Sale CKD Vehicle"
        public const string Pages_Sales_SalesCkdVehicle = "Pages.Sales.Vehicle.SalesCkdVehicle";
        #endregion

        #region "Sales Vehicle Import"
        //color request. Code = 001
        public const string Pages_Sales_SalesVehicleImport = "Pages.Sales.Vehicle.SalesVehicleImport";
        public const string Pages_Sales_SalesVehicleImport_001 = "Pages.Sales.Vehicle.SalesVehicleImport.001";
        public const string Pages_Sales_SalesVehicleImport_001_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.001.Upload";
        public const string Pages_Sales_SalesVehicleImport_001_Download = "Pages.Sales.Vehicle.SalesVehicleImport.001.Download";
        public const string Pages_Sales_SalesVehicleImport_001_Import = "Pages.Sales.Vehicle.SalesVehicleImport.001.Import";
        public const string Pages_Sales_SalesVehicleImport_001_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.001.ImportHistory";

        //Invoice Discount. Code = 003
        public const string Pages_Sales_SalesVehicleImport_003 = "Pages.Sales.Vehicle.SalesVehicleImport.003";
        public const string Pages_Sales_SalesVehicleImport_003_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.003.Upload";
        public const string Pages_Sales_SalesVehicleImport_003_Download = "Pages.Sales.Vehicle.SalesVehicleImport.003.Download";
        public const string Pages_Sales_SalesVehicleImport_003_Import = "Pages.Sales.Vehicle.SalesVehicleImport.003.Import";
        public const string Pages_Sales_SalesVehicleImport_003_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.003.ImportHistory";
        //truck location. Code = 002
        public const string Pages_Sales_SalesVehicleImport_002 = "Pages.Sales.Vehicle.SalesVehicleImport.002";
        public const string Pages_Sales_SalesVehicleImport_002_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.002.Upload";
        public const string Pages_Sales_SalesVehicleImport_002_Download = "Pages.Sales.Vehicle.SalesVehicleImport.002.Download";
        public const string Pages_Sales_SalesVehicleImport_002_Import = "Pages.Sales.Vehicle.SalesVehicleImport.002.Import";
        public const string Pages_Sales_SalesVehicleImport_002_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.002.ImportHistory";


        //Plan Install Time. Code = 004
        public const string Pages_Sales_SalesVehicleImport_004 = "Pages.Sales.Vehicle.SalesVehicleImport.004";
        public const string Pages_Sales_SalesVehicleImport_004_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.004.Upload";
        public const string Pages_Sales_SalesVehicleImport_004_Download = "Pages.Sales.Vehicle.SalesVehicleImport.004.Download";
        public const string Pages_Sales_SalesVehicleImport_004_Import = "Pages.Sales.Vehicle.SalesVehicleImport.004.Import";
        public const string Pages_Sales_SalesVehicleImport_004_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.004.ImportHistory";


        //Fix Payment Deadline. Code = 005
        public const string Pages_Sales_SalesVehicleImport_005 = "Pages.Sales.Vehicle.SalesVehicleImport.005";
        public const string Pages_Sales_SalesVehicleImport_005_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.005.Upload";
        public const string Pages_Sales_SalesVehicleImport_005_Download = "Pages.Sales.Vehicle.SalesVehicleImport.005.Download";
        public const string Pages_Sales_SalesVehicleImport_005_Import = "Pages.Sales.Vehicle.SalesVehicleImport.005.Import";
        public const string Pages_Sales_SalesVehicleImport_005_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.005.ImportHistory";

        //Defer Payment. Code = 006
        public const string Pages_Sales_SalesVehicleImport_006 = "Pages.Sales.Vehicle.SalesVehicleImport.006";
        public const string Pages_Sales_SalesVehicleImport_006_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.006.Upload";
        public const string Pages_Sales_SalesVehicleImport_006_Download = "Pages.Sales.Vehicle.SalesVehicleImport.006.Download";
        public const string Pages_Sales_SalesVehicleImport_006_Import = "Pages.Sales.Vehicle.SalesVehicleImport.006.Import";
        public const string Pages_Sales_SalesVehicleImport_006_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.006.ImportHistory";
        //Maintenance Actual Date. Code = 007
        public const string Pages_Sales_SalesVehicleImport_007 = "Pages.Sales.Vehicle.SalesVehicleImport.007";
        public const string Pages_Sales_SalesVehicleImport_007_Upload = "Pages.Sales.Vehicle.SalesVehicleImport.007.Upload";
        public const string Pages_Sales_SalesVehicleImport_007_Download = "Pages.Sales.Vehicle.SalesVehicleImport.007.Download";
        public const string Pages_Sales_SalesVehicleImport_007_Import = "Pages.Sales.Vehicle.SalesVehicleImport.007.Import";
        public const string Pages_Sales_SalesVehicleImport_007_ImportHistory = "Pages.Sales.Vehicle.SalesVehicleImport.007.ImportHistory";
        #endregion


        #region "Sales Vehicle Report"
        //color request. Code = 001
        public const string Pages_Sales_SalesVehicleReport = "Pages.Sales.Vehicle.SalesVehicleReport";
        //public const string Pages_Sales_SalesVehicleReport_001 = "Pages.Sales.Vehicle.SalesVehicleReport.001";
        #endregion

        #region "Sales Vehicle Invoice"
        public const string Pages_Sales_SalesVehicleInvoice = "Pages.Sales.Vehicle.SalesVehicleInvoice";
        #endregion

        #region "Sales Vehicle Invoice TMV"
        public const string Pages_Sales_SalesVehicleInvoiceTMV = "Pages.Sales.Vehicle.SalesVehicleInvoiceTMV";
        #endregion

        #region TestDriveCampaign
        public const string Pages_Sales_TestDriveCampaign = "Pages.Sales.Vehicle.TestDriveCampaign";
        public const string Pages_Sales_TestDriveCampaign_CreateOrEdit = "Pages.Sales.Vehicle.TestDriveCampaign.CreateOrEdit";
        public const string Pages_Sales_TestDriveCampaign_Search = "Pages.Sales.Vehicle.TestDriveCampaign.Search";
        public const string Pages_Sales_TestDriveCampaign_Delete = "Pages.Sales.Vehicle.TestDriveCampaign.Delete";

        #endregion
        #region "Sales Vehicle SendingDailyPaymentEmail"
        public const string Pages_Sales_Sending_Daily_Payment_Email_History = "Pages.Sales.Vehicle.SendingDailyPaymentEmailHistory";

        #endregion
        #region "Sales Vehicle SendingDailyPaymentEmail"
        public const string Pages_Master_InvoiceConfig_SendingDailyPaymentEmail = "Pages.Sales.Vehicle.SendingDailyPaymentEmail";
        public const string Pages_Master_InvoiceConfig_SendingDailyPaymentEmail_Search = "Pages.Sales.Vehicle.SendingDailyPaymentEmail.Search";

        #endregion


        /*#region "Email thanh toán"
        public const string Pages_Sales_SalesVehicleInvoice_Email_Config = "Pages.Sales.Vehicle.SalesVehicleInvoiceEmailConfig";
        #endregion*/

        #region "Import Permisson Grid"
        public const string Pages_Sales_SalesVehicleImportGrid = "Pages.Sales.Vehicle.SalesVehicleImportGrid";
        public const string Pages_Sales_SalesVehicleImportGrid_Save = "Pages.Sales.Vehicle.SalesVehicleImportGrid.Save";
        public const string Pages_Sales_SalesVehicleImportGrid_View = "Pages.Sales.Vehicle.SalesVehicleImportGrid.View";
        #endregion


        #region "Mobile"
        public const string Mobile_General = "Mobile.General";

        #region "Mobile SalesCustomer"
        public const string Mobile_SalesCustomer = "Mobile.SalesCustomer";
        public const string Mobile_SalesCustomer_View = "Mobile.SalesCustomer.View";
        public const string Mobile_SalesCustomer_Create = "Mobile.SalesCustomer.Create";
        public const string Mobile_SalesCustomer_Delete = "Mobile.SalesCustomer.Delete";
        public const string Mobile_SalesCustomer_Edit = "Mobile.SalesCustomer.Edit";
        public const string Mobile_SalesCustomer_ViewAssignment = "Mobile.SalesCustomer.ViewAssignment";
        public const string Mobile_SalesCustomer_EditAssignment = "Mobile.SalesCustomer.EditAssignment";
        public const string Mobile_SalesCustomer_DeleteAssignment = "Mobile.SalesCustomer.DeleteAssignment";
        public const string Mobile_SalesCustomer_ViewContactResult = "Mobile.SalesCustomer.ViewContactResult";
        public const string Mobile_SalesCustomer_EditContactResult = "Mobile.SalesCustomer.EditContactResult";
        public const string Mobile_SalesCustomer_DeleteContactResult = "Mobile.SalesCustomer.DeleteContactResult";
        #endregion
        #region "Mobile Sale Contract"
        public const string Mobile_Sales_SaleContract = "Mobile.Sales.SaleContract";
        public const string Mobile_Sales_SaleContract_GetContractByCustomerId = "Mobile.Sales.SaleContract.GetContractByCustomerId";
        public const string Mobile_Sales_SaleContract_CreateOrEditPostSaleContract = "Mobile.Sales.SaleContract.CreateOrEditPostSaleContract";
        public const string Mobile_Sales_SaleContract_DeleteContractVehcle = "Mobile.Sales.SaleContract.DeleteContractVehcle";
        #endregion

        #region "Mobile SalesContractAccessories "
        public const string Mobile_Sales_SalesContractAccessories = "Mobile.Sales.SalesContractAccessories";
        public const string Mobile_Sales_SalesContractAccessories_GetAccessoryDetailById = "Mobile.Sales.SalesContractAccessories.GetAccessoryDetailById";
        public const string Mobile_Sales_SalesContractAccessories_CreateOrEditSalesContractAccessories = "Mobile.Sales.SalesContractAccessories.CreateOrEditSalesContractAccessories";
        #endregion
        #region "Mobile Master Accessories Package"
        public const string Mobile_Master_Sales_Accessories_Package = "Mobile.Master.Sales.MstSleAccessoriesPackage";
        public const string Mobile_Master_Sales_Accessories_Package_Search = "Mobile.Master.Sales.MstSleAccessoriesPackage.Search";
        public const string Mobile_Master_Sales_Accessories_Package_Create = "Mobile.Master.Sales.MstSleAccessoriesPackage.Create";
        public const string Mobile_Master_Sales_Accessories_Package_Edit = "Mobile.Master.Sales.MstSleAccessoriesPackage.Edit";
        public const string Mobile_Master_Sales_Accessories_Package_Delete = "Mobile.Master.Sales.MstSleAccessoriesPackage.Delete";
        #endregion
        #region "Mobile SalesContractInsurance"
        public const string Mobile_Sales_SalesContractInsurance = "Mobile.Sales.SalesContractInsurance";
        public const string Mobile_Sales_SalesContractInsurance_CreateOrEditSalesContractInsurance = "Mobile.Sales.SalesContractInsurance.CreateOrEditSalesContractInsurance";

        #endregion
        #region "Mobile SalesContractFinance"
        public const string Mobile_Sales_SalesContractFinance = "Mobile.Sales.SalesContractFinance";
        public const string Mobile_Sales_SalesContractFinance_CreateOrEditSalesContractFinance = "Mobile.Sales.SalesContractFinance.CreateOrEditSalesContractFinance";
        #endregion
        #region "Mobile Vehicle"
        public const string Mobile_Vehicle = "Mobile.Vehicle";
        public const string Mobile_Vehicle_GetListColorProduct = "Mobile.Vehicle.GetListColorProduct";
        #endregion
        #region "Mobile Vehicle"
        public const string Mobile_Vehicle_QR = "Mobile.VehicleQR";
        public const string Mobile_Vehicle_QR_ScanAtDealer = "Mobile.VehicleQR.ScanAtDealer";
        public const string Mobile_Vehicle_QR_ScanAtTMV = "Mobile.VehicleQR.ScanAtTMV";
        public const string Mobile_Vehicle_QR_ScanAtPort = "Mobile.VehicleQR.ScanAtPort";
        public const string Mobile_Vehicle_QR_ListCarArriveAtDealer = "Mobile.VehicleQR.ListCarArriveAtDealer";
        public const string Mobile_Vehicle_QR_ListCarArriveAtTMV = "Mobile.VehicleQR.ListCarArriveAtTMV";
        public const string Mobile_Vehicle_QR_ListCarArriveAtPort = "Mobile.VehicleQR.ListCarArriveAtPort";
        #endregion
        #region "Mobile Contact Reminder"
        public const string Mobile_Contact_Reminder = "Mobile.ContactReminder";
        #endregion
        #region "Mobile Sales Proposal Commisions"
        public const string Mobile_Proposal_Commission = "Mobile.ProposalCommission";
        public const string Mobile_Proposal_Commission_GetProposalCommissionByInput = "Mobile.ProposalCommission.GetProposalCommissionByInput";
        public const string Mobile_Proposal_Commission_CreateOrEdit = "Mobile.ProposalCommission.CreateOrEdit";
        #endregion
        #region "Mobile Sales Proposal PPM"
        public const string Mobile_Proposal_PPM = "Mobile.ProposalPPM";
        public const string Mobile_Proposal_PPM_GetProposalPPMByInput = "Mobile.ProposalPPM.GetProposalCommissionByInput";
        public const string Mobile_Proposal_PPM_CreateOrEdit = "Mobile.ProposalPPM.CreateOrEdit";
        public const string Mobile_Proposal_PPM_GetAllProposalPPMByDealerId = "Mobile.ProposalPPM.getInputForProposalCommission";
        #endregion
        #region "Mobile Sale Customer Vehicle Infor"
        public const string Mobile_SalesCustomerVehicleInfo = "Mobile.SalesCustomerVehicleInfo";
        public const string Mobile_SalesCustomerVehicleInfo_Create = "Mobile.SalesCustomerVehicleInfo.Create";
        public const string Mobile_SalesCustomerVehicleInfo_Edit = "Mobile.SalesCustomerVehicleInfo.Edit";
        public const string Mobile_SalesCustomerVehicleInfo_Delete = "Mobile.SalesCustomerVehicleInfo.Delete";
        #endregion
        #region "Mobile MstSlePromotion"
        public const string Mobile_MstSlePromotion = "Mobile.MstSlePromotion";
        #endregion
        #region "Mobile MstSleInsurance"
        public const string Mobile_MstSleInsurance = "Mobile.MstSleInsurance";

        #endregion
        #region "Mobile SalesContractApprover"
        public const string Mobile_Sales_SalesContractApprover = "Mobile.Sales.SalesContractApprover";
        public const string Mobile_Sales_SalesContractApprover_InsertContractApprover = "Mobile.Sales.SalesContractApprover.InsertContractApprover";
        public const string Mobile_Sales_SalesContractApprover_ApproveSalesContract = "Mobile.Sales.SalesContractApprover.ApproveSalesContract";
        public const string Mobile_Sales_SalesContractApprover_RejectSalesContract = "Mobile.Sales.SalesContractApprover.RejectSalesContract";
        public const string Mobile_Sales_SalesContractApprover_GetNameCustomerWithmodeContract = "Mobile.Sales.SalesContractApprover.GetNameCustomerWithmodeContract";
        public const string Mobile_Sales_SalesContractApprover_CreateSalesCustomerTransactionInfo = "Mobile.Sales.SalesContractApprover.CreateSalesCustomerTransactionInfo";
        #endregion


        #region "Mobile InSurance Company"
        public const string Mobile_Master_Sales_MstSleInsuranceCompany = "Mobile.Master.Sales.MstSleInsuranceCompany";
        public const string Mobile_Master_Sales_MstSleInsuranceCompany_Create_Edit = "Mobile.Master.Sales.MstSleInsuranceCompany.CreateEdit";
        public const string Mobile_Master_Sales_MstSleInsuranceCompany_Delete = "Mobile.Master.Sales.MstSleInsuranceCompany.Delete";
        #endregion

        #region "Mobile DashBoard"
        public const string Mobile_DashBoard = "Mobile.DashBoard.MstSleInsuranceCompany";
        public const string Mobile_DashBoard_CreateOrEditTargetSetting = "Mobile.DashBoard.CreateOrEdit";
        public const string Mobile_DashBoard_UpdateTargetDaily = "Mobile.DashBoard.UpdateTargetDaily";
        #endregion
        #region "Mobile Hotness"
        public const string Mobile_Master_Sales_Hotness = "Mobile.Master.Sales.MstSleHotness";
        public const string Mobile_Master_Sales_Hotness_Create = "Mobile.Master.Sales.MstSleHotness.Create";
        public const string Mobile_Master_Sales_Hotness_Edit = "Mobile.Master.Sales.MstSleHotness.Edit";
        public const string Mobile_Master_Sales_Hotness_Delete = "Mobile.Master.Sales.MstSleHotness.Delete";
        #endregion
        #region "Mobile Model"
        public const string Mobile_Master_Sales_Model = "Mobile.Master.Sales.MstSleModel";
        public const string Mobile_Master_Sales_Model_Search = "Mobile.Master.Sales.MstSleModel.Search";
        public const string Mobile_Master_Sales_Model_Create = "Mobile.Master.Sales.MstSleModel.Create";
        public const string Mobile_Master_Sales_Model_Edit = "Mobile.Master.Sales.MstSleModel.Edit";
        public const string Mobile_Master_Sales_Model_Delete = "Mobile.Master.Sales.MstSleModel.Delete";
        #endregion
        #region "Mobile Delivery Stall"
        public const string Mobile_Master_Sales_DeliveryStall = "Mobile.Master.Sales.MstSleDeliveryStall";
        public const string Mobile_Master_Sales_DeliveryStall_Create = "Mobile.Master.Sales.MstSleDeliveryStall.Create";
        public const string Mobile_Master_Sales_DeliveryStall_Edit = "Mobile.Master.Sales.MstSleDeliveryStall.Edit";
        public const string Mobile_Master_Sales_DeliveryStall_Delete = "Mobile.Master.Sales.MstSleDeliveryStall.Delete";
        public const string Mobile_Master_Sales_DeliveryStall_Search = "Mobile.Master.Sales.MstSleDeliveryStall.Search";
        #endregion
        #region "Mobile ReasonOfNA"
        public const string Mobile_Master_Sales_ReasonOfNA = "Mobile.Master.Sales.MstSleReasonOfNA";
        public const string Mobile_Master_Sales_ReasonOfNA_Create = "Mobile.Master.Sales.MstSleReasonOfNA.Create";
        public const string Mobile_Master_Sales_ReasonOfNA_Edit = "Mobile.Master.Sales.MstSleReasonOfNA.Edit";
        public const string Mobile_Master_Sales_ReasonOfNA_Delete = "Mobile.Master.Sales.MstSleReasonOfNA.Delete";
        #endregion
        #region "Mobile Delivery Place"
        public const string Mobile_Master_Sales_DeliveryPlace = "Mobile.Master.Sales.MstSleDeliveryPlace";
        public const string Mobile_Master_Sales_DeliveryPlace_Create = "Mobile.Master.Sales.MstSleDeliveryPlace.Create";
        public const string Mobile_Master_Sales_DeliveryPlace_Edit = "Mobile.Master.Sales.MstSleDeliveryPlace.Edit";
        public const string Mobile_Master_Sales_DeliveryPlace_Delete = "Mobile.Master.Sales.MstSleDeliveryPlace.Delete";
        public const string Mobile_Master_Sales_DeliveryPlace_Search = "Mobile.Master.Sales.MstSleDeliveryPlace.Search";
        #endregion
        #region "Mobile Delivery Venue"
        public const string Mobile_Master_Sales_DeliveryVenue = "Mobile.Master.Sales.MstSleDeliveryVenue";
        public const string Mobile_Master_Sales_DeliveryVenue_Create = "Mobile.Master.Sales.MstSleDeliveryVenue.Create";
        public const string Mobile_Master_Sales_DeliveryVenue_Edit = "Mobile.Master.Sales.MstSleDeliveryVenue.Edit";
        public const string Mobile_Master_Sales_DeliveryVenue_Delete = "Mobile.Master.Sales.MstSleDeliveryVenue.Delete";
        public const string Mobile_Master_Sales_DeliveryVenue_Search = "Mobile.Master.Sales.MstSleDeliveryVenue.Search";
        #endregion
        #region "Mobile Master Supporter"
        public const string Mobile_Master_Sales_MstSleSupporter = "Mobile.Master.Sales.MstSleSupporter";
        public const string Mobile_Master_Sales_MstSleSupporter_Search = "Mobile.Master.Sales.MstSleSupporter.Search";
        public const string Mobile_Master_Sales_MstSleSupporter_Create_Edit = "Mobile.Master.Sales.MstSleSupporter.CreateEdit";
        public const string Mobile_Master_Sales_MstSleSupporter_Delete = "Mobile.Master.Sales.MstSleSupporter.Delete";
        #endregion
        #region "Mobile DeliveryActivity"
        public const string Mobile_DeliveryActivity = "Mobile.DeliveryActivity";
        public const string Mobile_DeliveryActivity_CreateOrEditDeliveryActivity = "Mobile.DeliveryActivity.CreateOrEditDeliveryActivity";
        public const string Mobile_DeliveryActivity_Delete = "Mobile.DeliveryActivity.Delete";
        public const string Mobile_DeliveryActivity_GetListDeliveryActivityByCustomerId = "Mobile.DeliveryActivity.GetListDeliveryActivityByCustomerId";
        #endregion
        #region "Mobile SalesCustomerGallery"
        public const string Mobile_Sales_SalesCustomerGallery = "Mobile.Sales.SalesCustomerGallery";
        public const string Mobile_Sales_SalesCustomerGallery_Create = "Mobile.Sales.SalesCustomerGallery.CreateSalesCustomerAnniversary";
        public const string Mobile_Sales_SalesCustomerGallery_View = "Mobile.Sales.SalesCustomerGallery.ViewSalesCustomerAnniversary";
        public const string Mobile_Sales_SalesCustomerGallery_Delete = "Mobile.Sales.SalesCustomerGallery.DeleteSalesCustomerAnniversary";
        #endregion
        #region "Mobile Finance"
        public const string Mobile_Finance = "Mobile.Finance.DeleteSalesCustomerAnniversary";
        #endregion
        #region "Mobile Excepted Delivery Timing"
        public const string Mobile_Master_Sales_ExceptedDeliveryTiming = "Mobile.Master.Sales.MstSleExpectedDelTiming";
        public const string Mobile_Master_Sales_ExceptedDeliveryTiming_Search = "Mobile.Master.Sales.MstSleExpectedDelTiming.Search";
        public const string Mobile_Master_Sales_ExceptedDeliveryTiming_Create = "Mobile.Master.Sales.MstSleExpectedDelTiming.Create";
        public const string Mobile_Master_Sales_ExceptedDeliveryTiming_Edit = "Mobile.Master.Sales.MstSleExpectedDelTiming.Edit";
        public const string Mobile_Master_Sales_ExceptedDeliveryTiming_Delete = "Mobile.Master.Sales.MstSleExpectedDelTiming.Delete";
        #endregion
        #region "Mobile SaleQuotation"
        public const string Mobile_SalesQuotation = "Mobile.SalesQuotation.Delete";
        public const string Mobile_SalesQuotation_CreateOrEditPost = "Mobile.SalesQuotation.CreateOrEditPost";
        public const string Mobile_SalesQuotation_GetQuotationByCustomer = "Mobile.SalesQuotation.GetQuotationByCustomer";
        public const string Mobile_SalesQuotation_DeleteQuotation = "Mobile.SalesQuotation.DeleteQuotation";
        #endregion
        #region "Mobile SalesProposalAccessories"
        public const string Mobile_SalesProposalAccessories = "Mobile.SalesQuotation";
        public const string Mobile_SalesProposalAccessories_CreateOrEdit = "Mobile.SalesQuotation.CreateOrEdit";
        public const string Mobile_SalesProposalAccessories_GetAccessoryDetailById = "Mobile.SalesQuotation.GetAccessoryDetailById";
        #endregion
        #region "Mobile Master Accessories"
        public const string Mobile_Master_Sales_Accessories = "Mobile.Master.Sales.MstSleAccessories";
        public const string Mobile_Master_Sales_Accessories_Search = "Mobile.Master.Sales.MstSleAccessories.Search";
        public const string Mobile_Master_Sales_Accessories_Create = "Mobile.Master.Sales.MstSleAccessories.Create";
        public const string Mobile_Master_Sales_Accessories_Edit = "Mobile.Master.Sales.MstSleAccessories.Edit";
        public const string Mobile_Master_Sales_Accessories_Delete = "Mobile.Master.Sales.MstSleAccessories.Delete";
        #endregion
        #region "Mobile SalesProposalFinance"
        public const string Mobile_SalesProposalFinance = "Mobile.SalesProposalFinance";
        public const string Mobile_SalesProposalFinance_GetProposalFinanceByInput = "Mobile.SalesProposalFinance.GetProposalFinanceByInput";
        public const string Mobile_SalesProposalFinance_CreateOrEdit = "Mobile.SalesProposalFinance.CreateOrEdit";
        #endregion
        #region "Mobile Sales Proposal"
        public const string Mobile_SalesProposal = "Mobile.SalesProposal";
        public const string Mobile_SalesProposal_CreateOrEditPost = "Mobile.SalesProposal.CreateOrEditPost";
        public const string Mobile_SalesProposal_GetProposalByCustomer = "Mobile.SalesProposal.GetProposalByCustomer";
        public const string Mobile_SalesProposal_DeleteProposal = "Mobile.SalesProposal.DeleteProposal";
        #endregion
        #region "Mobile SalesCustomerManagerComment"
        public const string Mobile_SalesCustomerManagerComment = "Mobile.SalesCustomerManagerComment";
        public const string Mobile_SalesCustomerManagerComment_Create = "Mobile.SalesCustomerManagerComment.Create";
        public const string Mobile_SalesCustomerManagerComment_Edit = "Mobile.SalesCustomerManagerComment.Edit";
        public const string Mobile_SalesCustomerManagerComment_Delete = "Mobile.SalesCustomerManagerComment.Delete";
        #endregion
        #region"Mobile SalesProposalApprover"
        public const string Mobile_Sales_SalesProposalApprover = "Mobile.Sales.SalesProposalApprover";
        public const string Mobile_Sales_SalesProposalApprover_InsertProposalApprover = "Mobile.Sales.SalesProposalApprover.InsertProposalApprover";
        public const string Mobile_Sales_SalesProposalApprover_GetSalesProposalApprover = "Mobile.Sales.SalesProposalApprover.GetSalesProposalApprover";
        public const string Mobile_Sales_SalesProposalApprover_GetNameCustomerWithmodeProposal = "Mobile.Sales.SalesProposalApprover.GetNameCustomerWithmodeProposal";
        public const string Mobile_Sales_SalesProposalApprover_GetUserId = "Mobile.Sales.SalesProposalApprover.GetUserId";

        #endregion
        #region "Mobile SalesCustomerSupervisor"
        public const string Mobile_Sales_SalesCustomerSupervisor = "Mobile.Sales.SalesCustomerSupervisor";
        public const string Mobile_Sales_SalesCustomerSupervisor_Create = "Mobile.Sales.SalesCustomerGalleryFolder.CreateSalesCustomerSupervisor";
        public const string Mobile_Sales_SalesCustomerSupervisor_View = "Mobile.Sales.SalesCustomerGalleryFolder.ViewSalesCustomerSupervisor";
        public const string Mobile_Sales_SalesCustomerSupervisor_Delete = "Mobile.Sales.SalesCustomerGalleryFolder.DeleteSalesCustomerSupervisor";
        #endregion
        #region "Mobile Sales Transaction Infor"
        public const string Mobile_SalesCustomerTransactionInfo = "Mobile.SalesCustomerTransactionInfo";
        public const string Mobile_SalesCustomerTransactionInfo_Create = "Mobile.SalesCustomerTransactionInfo.Create";
        public const string Mobile_SalesCustomerTransactionInfo_Edit = "Mobile.SalesCustomerTransactionInfo.Edit";
        public const string Mobile_SalesCustomerTransactionInfo_Delete = "Mobile.SalesCustomerTransactionInfo.Delete";
        public const string Mobile_SalesCustomerTransactionInfo_View = "Mobile.SalesCustomerTransactionInfo.View";
        #endregion
        #region "Mobile SalesPesonNotification"
        public const string Mobile_SalesPesonNotification = "Mobile.SalesPesonNotification.ApproveTransaction";
        public const string Mobile_SalesPesonNotification_CreateNotification = "Mobile.SalesPesonNotification.CreateNotification";
        public const string Mobile_SalesPesonNotification_GetListNotification = "Mobile.SalesPesonNotification.GetListNotification";
        public const string Mobile_SalesPesonNotification_GetNumberOfNotice = "Mobile.SalesPesonNotification.GetNumberOfNotice";
        public const string Mobile_SalesPesonNotification_SetAllReadNotification = "Mobile.SalesPesonNotification.SetAllReadNotification";
        public const string Mobile_SalesPesonNotification_SetReadNotification = "Mobile.SalesPesonNotification.SetReadNotification";

        #endregion
        #region "Mobile ReasonOfNC"
        public const string Mobile_Master_Sales_ReasonOfNC = "Mobile.Master.Sales.MstSleReasonOfNC";
        public const string Mobile_Master_Sales_ReasonOfNC_Create = "Mobile.Master.Sales.MstSleReasonOfNC.Create";
        public const string Mobile_Master_Sales_ReasonOfNC_Edit = "Mobile.Master.Sales.MstSleReasonOfNC.Edit";
        public const string Mobile_Master_Sales_ReasonOfNC_Delete = "Mobile.Master.Sales.MstSleReasonOfNC.Delete";
        #endregion
        #region "Mobile Sales Stock"
        public const string Mobile_SalesVehicleStock = "Mobile.SalesVehicleStock.MstSleReasonOfNC";
        public const string Mobile_SalesVehicleStock_GetStockCheckingInModel = "Mobile.SalesVehicleStock.GetStockCheckingInModel";
        public const string Mobile_SalesVehicleStock_GetStockCheckingInGrade = "Mobile.SalesVehicleStock.GetStockCheckingInGrade";
        public const string Mobile_SalesVehicleStock_GetAll = "Mobile.SalesVehicleStock.GetAll";
        #endregion
        #region "Mobile SalesCustomerTestDrive"
        public const string Mobile_SalesCustomerTestDrive = "Mobile.SalesCustomerTestDrive";
        public const string Mobile_SalesCustomerTestDrive_Create = "Mobile.SalesCustomerTestDrive.Create";
        public const string Mobile_SalesCustomerTestDrive_Edit = "Mobile.SalesCustomerTestDrive.Edit";
        public const string Mobile_SalesCustomerTestDrive_Delete = "Mobile.SalesCustomerTestDrive.Delete";
        #endregion
        #region "Mobile SalesToDoApprover"
        public const string Mobile_SalesToDoApprover = "Mobile.SalesToDoApprover";
        public const string Mobile_SalesToDoApprover_InsertToDoApprover = "Mobile.SalesToDoApprover.InsertToDoApprover";
        public const string Mobile_SalesToDoApprover_Approve = "Mobile.SalesToDoApprover.Approve";
        public const string Mobile_SalesToDoApprover_Reject = "Mobile.SalesToDoApprover.Reject";
        #endregion
        #region "Mobile TestDriver"
        public const string Mobile_TestDriver = "Mobile.TestDriver";
        public const string Mobile_TestDriver_View = "Mobile.TestDriver.View";
        public const string Mobile_TestDriver_CreateOrEdit = "Mobile.TestDriver.CreateOrEdit";
        public const string Mobile_TestDriver_Delete = "Mobile.TestDriver.Delete";
        #endregion
        #region "Mobile Test Drive Vehicle"
        public const string Mobile_Master_Sales_TestDriveVehicle = "Mobile.Master.Sales.MstSleTestDriveVehicle";
        public const string Mobile_Master_Sales_TestDriveVehicle_Create = "Mobile.Master.Sales.MstSleTestDriveVehicle.Create";
        public const string Mobile_Master_Sales_TestDriveVehicle_Edit = "Mobile.Master.Sales.MstSleTestDriveVehicle.Edit";
        public const string Mobile_Master_Sales_TestDriveVehicle_Delete = "Mobile.Master.Sales.MstSleTestDriveVehicle.Delete";
        #endregion
        #region "Mobile Test Drive Route"
        public const string Mobile_Master_Sales_TestDriveRoute = "Mobile.Master.Sales.MstSleTestDriveRoute";
        public const string Mobile_Master_Sales_TestDriveRoute_Create = "Mobile.Master.Sales.MstSleTestDriveRoute.Create";
        public const string Mobile_Master_Sales_TestDriveRoute_Edit = "Mobile.Master.Sales.MstSleTestDriveRoute.Edit";
        public const string Mobile_Master_Sales_TestDriveRoute_Delete = "Mobile.Master.Sales.MstSleTestDriveRoute.Delete";
        #endregion
        #region "Mobile SalesToDoList"
        public const string Mobile_SalesToDoList = "Mobile.SalesToDoList";
        public const string Mobile_SalesToDoList_GetToDoList = "Mobile.SalesToDoList.GetToDoList";
        public const string Mobile_SalesToDoList_Delete = "Mobile.SalesToDoList.Delete";
        #endregion
        #region "Mobile SalesContact"
        public const string Mobile_SalesContact = "Mobile.SalesContact";
        public const string Mobile_SalesContact_AddSalesCustomerContact = "Mobile.SalesContact.AddSalesCustomerContact";
        public const string Mobile_SalesContact_EditSalesCustomerContact = "Mobile.SalesContact.EditSalesCustomerContact";
        public const string Mobile_SalesContact_DeleteSalesCustomerContact = "Mobile.SalesContact.DeleteSalesCustomerContact";
        public const string Mobile_SalesContact_ListContact = "Mobile.SalesContact.ListContact";
        public const string Mobile_SalesContact_CreateSalesCustomerSupervisor = "Mobile.SalesContact.CreateSalesCustomerSupervisor";
        public const string Mobile_SalesContact_GetSalesCustomerSupervisorList = "Mobile.SalesContact.GetSalesCustomerSupervisorList";
        public const string Mobile_SalesContact_CreateSalesCustomerTransactionInfo = "Mobile.SalesContact.CreateSalesCustomerTransactionInfo";
        #endregion
        #region "Mobile SalesCarAttention"
        public const string Mobile_SalesCarAttention = "Mobile.SalesCarAttention";
        public const string Mobile_SalesCarAttention_CreateCarAttention = "Mobile.SalesCarAttention.CreateCarAttention";
        public const string Mobile_SalesCarAttention_CreateSalesCustomerVehicleInfo = "Mobile.SalesCarAttention.CreateSalesCustomerVehicleInfo";
        public const string Mobile_SalesCarAttention_Delete = "Mobile.SalesCarAttention.Delete";
        public const string Mobile_SalesCarAttention_ListCarAttention = "Mobile.SalesCarAttention.ListCarAttention";
        #endregion
        #region "Mobile SalesContactReminder"
        public const string Mobile_SalesContactReminder = "Mobile.SalesContactReminder";
        public const string Mobile_SalesContactReminder_View = "Mobile.SalesContactReminder.View";
        public const string Mobile_SalesContactReminder_Edit = "Mobile.SalesContactReminder.Edit";
        #endregion
        #region "Mobile SalesCustomerGalleryFolder"
        public const string Mobile_SalesCustomerGalleryFolder = "Mobile.SalesCustomerGalleryFolder";
        public const string Mobile_SalesCustomerGalleryFolder_CreateSalesCustomerGalleryFolder = "Mobile.SalesCustomerGalleryFolder.CreateSalesCustomerGalleryFolder";
        public const string Mobile_SalesCustomerGalleryFolder_EditSalesCustomerGalleryFolderName = "Mobile.SalesCustomerGalleryFolder.EditSalesCustomerGalleryFolderName";
        public const string Mobile_SalesCustomerGalleryFolder_GetSalesCustomerGalleryFolderById = "Mobile.SalesCustomerGalleryFolder.GetSalesCustomerGalleryFolderById";
        public const string Mobile_SalesCustomerGalleryFolder_Delete = "Mobile.SalesCustomerGalleryFolder.Delete";
        #endregion
        #region "Mobile Insurance"
        public const string Mobile_Insurance = "Mobile.Insurance";
        public const string Mobile_Insurance_GetListProductInsuranceFormDto = "Mobile.Insurance.GetListProductInsuranceFormDto";
        public const string Mobile_Insurance_GetListProductInsurancePackageDto = "Mobile.Insurance.GetListProductInsurancePackageDto";
        public const string Mobile_Insurance_GetListProductInsurancePurposeDto = "Mobile.Insurance.GetListProductInsurancePurposeDto";
        public const string Mobile_Insurance_GetListProductInsuranceTermDto = "Mobile.Insurance.GetListProductInsuranceTermDto";
        #endregion
        #region "Mobile Master Test Drive Place"
        public const string Mobile_Master_Sales_MstSleTestDrivePlace = "Mobile.Master.Sales.MstSleTestDrivePlace";
        public const string Mobile_Master_Sales_MstSleTestDrivePlace_Create_Edit = "Mobile.Master.Sales.MstSleTestDrivePlace.CreateEdit";
        public const string Mobile_Master_Sales_MstSleTestDrivePlace_Delete = "Mobile.Master.Sales.MstSleTestDrivePlace.Delete";

        #endregion
        #region "Mobile Test Drive Stall"
        public const string Mobile_Master_Sales_TestDriveStall = "Mobile.Master.Sales.MstSleTestDriveStall";
        public const string Mobile_Master_Sales_TestDriveStall_Create = "Mobile.Master.Sales.MstSleTestDriveStall.Create";
        public const string Mobile_Master_Sales_TestDriveStall_Edit = "Mobile.Master.Sales.MstSleTestDriveStall.Edit";
        public const string Mobile_Master_Sales_TestDriveStall_Delete = "Mobile.Master.Sales.MstSleTestDriveStall.Delete";
        #endregion
        #region "Mobile SalesCarProduct"
        public const string Mobile_SalesCarProduct = "Mobile.SalesCarProduct";
        public const string Mobile_SalesCarProduct_View = "Mobile.SalesCarProduct.View";
        #endregion
        #region "Mobile SalesCarPromotion"
        public const string Mobile_SalesCarPromotion = "Mobile.SalesCarPromotion";
        public const string Mobile_SalesCarPromotion_View = "Mobile.SalesCarPromotion.View";
        #endregion
        #region "Mobile SalesCarInsurance"
        public const string Mobile_SalesCarInsurance = "Mobile.SalesCarInsurance";
        public const string Mobile_SalesCarInsurance_View = "Mobile.SalesCarInsurance.View";
        #endregion
        #region "Mobile SalesCarFinance"
        public const string Mobile_SalesCarFinance = "Mobile.SalesCarFinance";
        public const string Mobile_SalesCarFinance_View = "Mobile.SalesCarFinance.View";
        #endregion
        #region "Mobile SalesVisualReport"
        public const string Mobile_SalesVisualReport = "Mobile.SalesVisualReport";
        public const string Mobile_SalesVisualReport_View = "Mobile.SalesVisualReport.View";
        #endregion
        #region "Mobile SalesInventoryManagement"
        public const string Mobile_SalesInventoryManagement = "Mobile.SalesInventoryManagement";
        public const string Mobile_SalesInventoryManagement_View = "Mobile.SalesInventoryManagement.View";
        #endregion
        #region "Mobile SalesWaitingForApproval"
        public const string Mobile_SalesWaitingForApproval = "Mobile.SalesWaitingForApproval";
        public const string Mobile_SalesWaitingForApproval_ApproveTestDrive = "Mobile.SalesWaitingForApproval.ApproveTestDrive";
        public const string Mobile_SalesWaitingForApproval_ApproveContract = "Mobile.SalesWaitingForApproval.ApproveContract";
        public const string Mobile_SalesWaitingForApproval_ApproveProposal = "Mobile.SalesWaitingForApproval.ApproveProposal";
        public const string Mobile_SalesWaitingForApproval_ApproveFreezeLoss = "Mobile.SalesWaitingForApproval.ApproveFreezeLoss";
        #endregion
        #region "Mobile SalesListSaleCar"
        public const string Mobile_SalesListSaleCar = "Mobile.SalesListSaleCar";
        public const string Mobile_SalesListSaleCar_View = "Mobile.SalesListSaleCar.View";
        #endregion
        #region "Mobile SalesListFreezeCustomer"
        public const string Mobile_SalesListFreezeCustomer = "Mobile.SalesListFreezeCustomer";
        public const string Mobile_SalesListFreezeCustomer_View = "Mobile.SalesListFreezeCustomer.View";
        #endregion
        #region "Mobile SalesListLoseCustomer"
        public const string Mobile_SalesListLoseCustomer = "Mobile.SalesListLoseCustomer";
        public const string Mobile_SalesListLoseCustomer_View = "Mobile.SalesListLoseCustomer.View";
        #endregion

        #endregion

        #region "Employee"
        public const string Pages_Sales_Menu_Employee = "Pages.Employee";
        public const string Pages_Sales_Menu_Human_Resource = "Pages.HumanResource";
        public const string Pages_Sales_Menu_Human_Resource_Category = "Pages.HumanResource.Category";
        public const string Pages_Sales_Menu_Employee_Role = "Pages.Employee.Role";
        public const string Pages_Sales_Employee_Approve = "Pages.EmployeeApprove";

        #region "Dealer Organization Chart"
        public const string Pages_Sales_Menu_OrganizationalStructure = "Pages.Employee.OrganizationalStructure";
        public const string Pages_Sales_Menu_OrganizationalStructure_ManageRoles = "Pages.Employee.OrganizationalStructure.ManageRoles";
        public const string Pages_Sales_Menu_OrganizationalStructure_ManageMembers = "Pages.Employee.OrganizationalStructure.ManageMembers";
        public const string Pages_Sales_Menu_OrganizationalStructure_ManageGroupDashboard = "Pages.Employee.OrganizationalStructure.ManageGroupDashboard";



        #endregion
        #region "Information about Workers"
        public const string Pages_Sales_Information_About_Workers = "Pages.Employee.InformationAboutWorkers";

        #region "Employee infomation"
        public const string Pages_Master_Sales_Employee = "Pages.Master.Sales.Employee";
        public const string Pages_Master_Sales_Employee_Search = "Pages.Master.Sales.Employee.Search";
        public const string Pages_Master_Sales_Employee_Create = "Pages.Master.Sales.Employee.Create";
        public const string Pages_Master_Sales_Employee_Edit = "Pages.Master.Sales.Employee.Edit";
        public const string Pages_Master_Sales_Employee_Delete = "Pages.Master.Sales.Employee.Delete";
        #endregion

        #region "EmployeeContract "
        public const string Pages_Master_Sales_EmployeeContract = "Pages.Master.Sales.EmployeeContract";
        public const string Pages_Master_Sales_EmployeeContract_Search = "Pages.Master.Sales.EmployeeContract.Search";
        public const string Pages_Master_Sales_EmployeeContract_Create = "Pages.Master.Sales.EmployeeContract.Create";
        public const string Pages_Master_Sales_EmployeeContract_Edit = "Pages.Master.Sales.EmployeeContract.Edit";
        public const string Pages_Master_Sales_EmployeeContract_Delete = "Pages.Master.Sales.EmployeeContract.Delete";
        #endregion

        #region "EmployeeRotation"
        public const string Pages_Master_Sales_EmployeeRotation = "Pages.Master.Sales.EmployeeRotation";
        public const string Pages_Master_Sales_EmployeeRotation_Search = "Pages.Master.Sales.EmployeeRotation.Search";
        public const string Pages_Master_Sales_EmployeeRotation_Create = "Pages.Master.Sales.EmployeeRotation.Create";
        public const string Pages_Master_Sales_EmployeeRotation_Edit = "Pages.Master.Sales.EmployeeRotation.Edit";
        public const string Pages_Master_Sales_EmployeeRotation_Delete = "Pages.Master.Sales.EmployeeRotation.Delete";
        #endregion
        #region
        public const string Pages_Master_Sales_EmployeeRotationAprrove = "Pages.Master.Sales.EmployeeRotationApprove";
        public const string Pages_Master_Sales_EmployeeRotationApprove_View = "Pages.Master.Sales.EmployeeRotationApprove.View";
        #endregion

        #region "EmployeeLeaveTemporary"
        public const string Pages_Master_Sales_EmployeeLeaveTemporary = "Pages.Master.Sales.EmployeeLeaveTemporary";
        public const string Pages_Master_Sales_EmployeeLeaveTemporary_Search = "Pages.Master.Sales.EmployeeLeaveTemporary.Search";
        public const string Pages_Master_Sales_EmployeeLeaveTemporary_Create = "Pages.Master.Sales.EmployeeLeaveTemporary.Create";
        public const string Pages_Master_Sales_EmployeeLeaveTemporary_Edit = "Pages.Master.Sales.EmployeeLeaveTemporary.Edit";
        public const string Pages_Master_Sales_EmployeeLeaveTemporary_Delete = "Pages.Master.Sales.EmployeeLeaveTemporary.Delete";
        #endregion

        #region "EmployeeLeaveJob"
        public const string Pages_Master_Sales_EmployeeLeaveJob = "Pages.Master.Sales.EmployeeLeaveJob";
        public const string Pages_Master_Sales_EmployeeLeaveJob_Search = "Pages.Master.Sales.EmployeeLeaveJob.Search";
        public const string Pages_Master_Sales_EmployeeLeaveJob_Create = "Pages.Master.Sales.EmployeeLeaveJob.Create";
        public const string Pages_Master_Sales_EmployeeLeaveJob_Edit = "Pages.Master.Sales.EmployeeLeaveJob.Edit";
        public const string Pages_Master_Sales_EmployeeLeaveJob_Delete = "Pages.Master.Sales.EmployeeLeaveJob.Delete";
        #endregion

        #region "EmployeeJobTitle"
        public const string Pages_Master_Sales_EmployeeJobTitle = "Pages.Master.Sales.EmployeeJobTitle";
        public const string Pages_Master_Sales_EmployeeJobTitle_Search = "Pages.Master.Sales.EmployeeJobTitle.Search";
        public const string Pages_Master_Sales_EmployeeJobTitle_Create = "Pages.Master.Sales.EmployeeJobTitle.Create";
        public const string Pages_Master_Sales_EmployeeJobTitle_Edit = "Pages.Master.Sales.EmployeeJobTitle.Edit";
        public const string Pages_Master_Sales_EmployeeJobTitle_Delete = "Pages.Master.Sales.EmployeeJobTitle.Delete";
        #endregion

        #region "EmployeeEducation"
        public const string Pages_Master_Sales_EmployeeEducation = "Pages.Master.Sales.EmployeeEducation";
        public const string Pages_Master_Sales_EmployeeEducation_Search = "Pages.Master.Sales.EmployeeEducation.Search";
        public const string Pages_Master_Sales_EmployeeEducation_Create = "Pages.Master.Sales.EmployeeEducation.Create";
        public const string Pages_Master_Sales_EmployeeEducation_Edit = "Pages.Master.Sales.EmployeeEducation.Edit";
        public const string Pages_Master_Sales_EmployeeEducation_Delete = "Pages.Master.Sales.EmployeeEducation.Delete";
        #endregion


        #region "EmployeeAccount"
        public const string Pages_Master_Sales_EmployeeAccount = "Pages.Master.Sales.EmployeeAccount";
        public const string Pages_Master_Sales_EmployeeAccount_Search = "Pages.Master.Sales.EmployeeAccount.Search";
        public const string Pages_Master_Sales_EmployeeAccount_Create = "Pages.Master.Sales.EmployeeAccount.Create";
        public const string Pages_Master_Sales_EmployeeAccount_Edit = "Pages.Master.Sales.EmployeeAccount.Edit";
        public const string Pages_Master_Sales_EmployeeAccount_Delete = "Pages.Master.Sales.EmployeeAccount.Delete";
        #endregion

        #region "UserClickToCall"
        public const string Pages_Master_Sales_UserClickToCall = "Pages.Master.Sales.UserClickToCall";
        public const string Pages_Master_Sales_UserClickToCall_Search = "Pages.Master.Sales.UserClickToCall.Search";
        public const string Pages_Master_Sales_UserClickToCall_Create = "Pages.Master.Sales.UserClickToCall.Create";
        public const string Pages_Master_Sales_UserClickToCall_Edit = "Pages.Master.Sales.UserClickToCall.Edit";
        public const string Pages_Master_Sales_UserClickToCall_Delete = "Pages.Master.Sales.UserClickToCall.Delete";
        #endregion

        #region "General Function Role"
        public const string Pages_Sales_General_Function_Role = "Pages.General.Function.Role";
        public const string Pages_Sales_General_Function_Role_Search = "Pages.General.Function.Role.Search";
        public const string Pages_Sales_General_Function_Role_Create = "Pages.General.Function.Role.Create";
        public const string Pages_Sales_General_Function_Role_Edit = "Pages.General.Function.Role.Edit";
        public const string Pages_Sales_General_Function_Role_Delete = "Pages.General.Function.Role.Delete";
        #endregion

        #region "Update Person Infor"
        public const string Pages_Sales_Update_Person_Infor = "Pages.Employee.MstSleEmployeeCertificate";

        #region "MstSleEmployeeCertificate"
        public const string Pages_Master_Sales_MstSleEmployeeCertificate = "Pages.Master.Sales.MstSleEmployeeCertificate";
        public const string Pages_Master_Sales_MstSleEmployeeCertificate_Create = "Pages.Master.Sales.MstSleEmployeeCertificate.Create";
        public const string Pages_Master_Sales_MstSleEmployeeCertificate_Edit = "Pages.Master.Sales.MstSleEmployeeCertificate.Edit";
        public const string Pages_Master_Sales_MstSleEmployeeCertificate_Delete = "Pages.Master.Sales.MstSleEmployeeCertificate.Delete";
        public const string Pages_Master_Sales_MstSleEmployeeCertificate_Search = "Pages.Master.Sales.MstSleEmployeeCertificate.Search";
        public const string Pages_Master_Sales_MstSleEmployeeCertificate_Import = "Pages.Master.Sales.MstSleEmployeeCertificate.Import";
        #endregion
        #endregion
        #region "Employee Leave Job Approve"
        public const string Page_Sales_Employee_Leave_Job_Approve = "Pages.Employee.MstSleEmployeeLeaveJobApprove";
        #region
        public const string Page_Sales_Employee_Leave_Job_Approve_Search = "Pages.Employee.MstSleEmployeeLeaveJobApprove.Search";
        #endregion
        #endregion
        #endregion

        #region "EmployeeReport"
        public const string Pages_Sales_Menu_Employee_Report = "Pages.Employee.Report";
        #endregion

        #region "EmployeeEducation"
        public const string Pages_Sales_Menu_Employee_Education = "Pages.Employee.Education";
        public const string Pages_Sales_Menu_Employee_Education_Modify = "Pages.Employee.Education.Modify";
        public const string Pages_Sales_Menu_Employee_Education_Search = "Pages.Employee.Education.Search";
        #endregion
        public const string Pages_Sales_Menu_Report = "Pages.Sales.Report";

        public const string Pages_Sales_Dashboard_Show = "Pages.Sales.DashboardShow";
        #region BackDateConfig
        public const string Pages_Sales_Back_Date_Config = "Page.Sales.Back.Date.Config";
        public const string Pages_Sales_Back_Date_Config_Create = "Page.Sales.Back.Date.Config.Create";
        public const string Pages_Sales_Back_Date_Config_Edit = "Page.Sales.Back.Date.Config.Edit";
        public const string Pages_Sales_Back_Date_Config_Delete = "Page.Sales.Back.Date.Config.Delete";
        #endregion

        #region "Dashboard Screen" 
        public const string Pages_Sales_Dashboard_Show_Screen = "Pages.Sales.DashboardShow.Screen";
        #endregion
        
        #region "Dashboard Screen Config" 
        public const string Pages_Sales_Dashboard_Show_Config = "Pages.Sales.DashboardShow.Config";
        public const string Pages_Sales_Dashboard_Show_Config_Create = "Pages.Sales.DashboardShow.Config.Create";
        public const string Pages_Sales_Dashboard_Show_Config_Edit = "Pages.Sales.DashboardShow.Config.Edit";
        public const string Pages_Sales_Dashboard_Show_Config_Delete = "Pages.Sales.DashboardShow.Config.Delete";
        public const string Pages_Sales_Dashboard_Show_Config_Search = "Pages.Sales.DashboardShow.Config.Search";
        #endregion  
        
        #region "Dashboard Screen" 
        public const string Pages_Sales_Dashboard_Show_DashboardScreenList = "Pages.Sales.DashboardShow.DashboardScreenList";
        public const string Pages_Sales_Dashboard_Show_InforDashboardWeb = "Pages.Sales.DashboardShow.InforDashboardWeb";
        public const string Pages_Sales_Dashboard_Show_ListSourceChart = "Pages.Sales.DashboardShow.ListSourceChart";
        public const string Pages_Sales_Dashboard_Show_DetailPotentialCustomer = "Pages.Sales.DashboardShow.DetailPotentialCustomer";
        public const string Pages_Sales_Dashboard_Show_MovementInquiryCustomer = "Pages.Sales.DashboardShow.MovementInquiryCustomer";
        public const string Pages_Sales_Dashboard_Show_MovementIMAndCWDCustomer = "Pages.Sales.DashboardShow.MovementIMAndCWDCustomer";
        public const string Pages_Sales_Dashboard_Show_MovementSaleCustomer = "Pages.Sales.DashboardShow.MovementSaleCustomer";
        public const string Pages_Sales_Dashboard_Show_InquiruCustomerByTotalModel = "Pages.Sales.DashboardShow.InquiruCustomerByTotalModel";
        public const string Pages_Sales_Dashboard_Show_FollowActivitySalesPerson = "Pages.Sales.DashboardShow.FollowActivitySalesPerson";
        public const string Pages_Sales_Dashboard_Show_CustomerHWC = "Pages.Sales.DashboardShow.CustomerHWC";
        #endregion

        #region "Swap"
        public const string Pages_Sales_Menu_Swap = "Pages.Sales.Swapping";

        #region "Swap Dealer"
        public const string Pages_Sales_Menu_Dealer_Swap = "Pages.Sales.DealerSwapping";

        #region "Dealer Vehicle Info"
        public const string Pages_Sales_Menu_Dealer_Vehicle_Info = "Pages.Sales.MstSleDealerVehicleInfo";
        public const string Pages_Sales_Menu_Dealer_Vehicle_Info_Create = "Pages.Sales.MstSleDealerVehicleInfo.Create";
        public const string Pages_Sales_Menu_Dealer_Vehicle_Info_Search = "Pages.Sales.MstSleDealerVehicleInfo.Search";
        public const string Pages_Sales_Menu_Dealer_Vehicle_Info_Edit = "Pages.Sales.MstSleDealerVehicleInfo.Edit";
        #endregion

        #region "Swapping Vehicle Sell"
        public const string Pages_Sales_Menu_Swapping_Vehicle_Sell = "Pages.Sales.MstSleSwappingVehicleSell";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Sell_Create = "Pages.Sales.MstSleSwappingVehicleSell.Create";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Sell_Search = "Pages.Sales.MstSleSwappingVehicleSell.Search";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Sell_Delete = "Pages.Sales.MstSleSwappingVehicleSell.Delete";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Sell_Edit = "Pages.Sales.MstSleSwappingVehicleSell.Edit";
        #endregion

        #region "Swapping Vehicle Buy"
        public const string Pages_Sales_Menu_Swapping_Vehicle_Buy = "Pages.Sales.MstSleSwappingVehicleBuy";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Buy_Create = "Pages.Sales.MstSleSwappingVehicleBuy.Create";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Buy_Search = "Pages.Sales.MstSleSwappingVehicleBuy.Search";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Buy_Delete = "Pages.Sales.MstSleSwappingVehicleBuy.Delete";
        public const string Pages_Sales_Menu_Swapping_Vehicle_Buy_Edit = "Pages.Sales.MstSleSwappingVehicleBuy.Edit";
        #endregion

        #region "Swapping Vehicle Search"
        public const string Pages_Sales_Menu_Search_Vehicle = "Pages.Sales.MstSleSearchVehicle";
        public const string Pages_Sales_Menu_Search_Vehicle_Search = "Pages.Sales.MstSleSearchVehicle.Search";
        #endregion

        #region "Dealer Swapping Report"
        public const string Pages_Sales_Menu_Swapping_Report = "Pages.Sales.MstSleDealerSwappingReport";
        public const string Pages_Sales_Menu_Swapping_Report_Search = "Pages.Sales.MstSleDealerSwappingReport.Search";
        #endregion





        #endregion

        #region "Swap TMV"
        public const string Pages_Sales_Menu_Swap_TMV = "Pages.Sales.TMVSwapping";

        #region " TMV Swapping Vhehicle "
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle = "Pages.Sales.MstSleTMVSwappingVehicle";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Create = "Pages.Sales.MstSleTMVSwappingVehicle.Create";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Search = "Pages.Sales.MstSleTMVSwappingVehicle.Search";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Delete = "Pages.Sales.MstSleTMVSwappingVehicle.Delete";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Edit = "Pages.Sales.MstSleTMVSwappingVehicle.Edit";
        #endregion

        #region " TMV Vehicle Info "
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Info = "Pages.Sales.MstSleTMVSwappingVehicleInfo";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Create = "Pages.Sales.MstSleTMVSwappingVehicleInfo.Create";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Search = "Pages.Sales.MstSleTMVSwappingVehicleInfo.Search";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Delete = "Pages.Sales.MstSleTMVSwappingVehicleInfo.Delete";
        public const string Pages_Sales_Menu_TMV_Swapping_Vehicle_Info_Edit = "Pages.Sales.MstSleTMVSwappingVehicleInfo.Edit";
        #endregion

        #region " Dispatch Change Request "
        public const string Pages_Sales_Menu_TMV_Dispatch_Change_Request = "Pages.Sales.MstSleDispatchChangeRequest";
        public const string Pages_Sales_Menu_TMV_Dispatch_Change_Request_Create = "Pages.Sales.MstSleDispatchChangeRequest.Create";
        public const string Pages_Sales_Menu_TMV_Dispatch_Change_Request_Search = "Pages.Sales.MstSleDispatchChangeRequest.Search";
        public const string Pages_Sales_Menu_TMV_Dispatch_Change_Request_Delete = "Pages.Sales.MstSleDispatchChangeRequest.Delete";
        public const string Pages_Sales_Menu_TMV_Dispatch_Change_Request_Edit = "Pages.Sales.MstSleDispatchChangeRequest.Edit";
        #endregion

        #region " Sell-Buy Matching "
        public const string Pages_Sales_Menu_TMV_Sell_Buy_Matching = "Pages.Sales.MstSleSellBuyMatching";
        public const string Pages_Sales_Menu_TMV_Sell_Buy_Matching_Create = "Pages.Sales.MstSleSellBuyMatching.Create";
        public const string Pages_Sales_Menu_TMV_Sell_Buy_Matching_Search = "Pages.Sales.MstSleSellBuyMatching.Search";
        public const string Pages_Sales_Menu_TMV_Sell_Buy_Matching_Edit = "Pages.Sales.MstSleSellBuyMatching.Delete";
        public const string Pages_Sales_Menu_TMV_Sell_Buy_Matching_Delete = "Pages.Sales.MstSleSellBuyMatching.Edit";
        #endregion

        #region " Dealer Swapping Vehicle "
        public const string Pages_Sales_Menu_Dealer_Swapping_Vehicle = "Pages.Sales.MstSleDealerSwappingVehicle";
        public const string Pages_Sales_Menu_Dealer_Swapping_Vehicle_Create = "Pages.Sales.MstSleDealerSwappingVehicle.Create";
        public const string Pages_Sales_Menu_Dealer_Swapping_Vehicle_Search = "Pages.Sales.MstSleDealerSwappingVehicle.Search";
        public const string Pages_Sales_Menu_Dealer_Swapping_Vehicle_Edit = "Pages.Sales.MstSleDealerSwappingVehicle.Delete";
        public const string Pages_Sales_Menu_Dealer_Swapping_Vehicle_Delete = "Pages.Sales.MstSleDealerSwappingVehicle.Edit";
        #endregion

        #region "TMV Swapping Report "
        public const string Pages_Sales_Menu_TMV_Swapping_Report = "Pages.Sales.MstSleTMVSwappingReport";
        public const string Pages_Sales_Menu_TMV_Swapping_Report_Create = "Pages.Sales.MstSleTMVSwappingReport.Create";
        public const string Pages_Sales_Menu_TMV_Swapping_Report_Search = "Pages.Sales.MstSleTMVSwappingReport.Search";
        public const string Pages_Sales_Menu_TMV_Swapping_Report_Edit = "Pages.Sales.MstSleTMVSwappingReport.Delete";
        public const string Pages_Sales_Menu_TMV_Swapping_Report_Delete = "Pages.Sales.MstSleTMVSwappingReport.Edit";
        #endregion

        #region "Swapping Advance Report "
        public const string Pages_Sales_Menu_Swapping_Advance_Report = "Pages.Sales.MstSleSwappingAdvanceReport";
        public const string Pages_Sales_Menu_Swapping_Advance_Report_Create = "Pages.Sales.MstSleSwappingAdvanceReport.Create";
        public const string Pages_Sales_Menu_Swapping_Advance_Report_Search = "Pages.Sales.MstSleSwappingAdvanceReport.Search";
        public const string Pages_Sales_Menu_Swapping_Advance_Report_Edit = "Pages.Sales.MstSleSwappingAdvanceReport.Delete";
        public const string Pages_Sales_Menu_Swapping_Advance_Report_Delete = "Pages.Sales.MstSleSwappingAdvanceReport.Edit";
        #endregion
        #endregion

        #endregion
        #region "Send Info"
        public const string Pages_Sales_Menu_Send_Info = "Pages.Sales.SendInfo";

        #region "Send Info Company Customer"
        public const string Pages_Sales_Menu_Send_Info_Customer_Company = "Pages.Sales.MstSleProductCompanyLead";
        public const string Pages_Sales_Menu_Send_Info_Customer_Company_Search = "Pages.Sales.MstSleProductCompanyLead.Search";
        #endregion

        #endregion


        public const string Pages_Sales_Menu_Sales_Admin = "Pages.Sales.Admin";

        public const string Pages_Sales_Menu_Sales_Vehicle = "Pages.Sales.Vehicle";

        #endregion

        #region "Contract Admin"
        public const string Pages_Sales_Menu_Contract_Admin = "Pages.Sales.Contract.ContractAdmin";
        #endregion

        #region "Contract Approval"
        public const string Pages_Sales_Menu_Contract_Approval = "Pages.Sales.Contract.ContractApproval";
        #endregion

        #region "Contract Tmss Management"
        public const string Pages_Sales_Menu_Contract_Tmss_Management = "Pages.Sales.Contract.ContractTmssManagement";
        #endregion

        #region "Fleet Sale Customer"
        public const string Pages_Sales_FleetCustomers = "Pages.Sales.FleetSale";
        public const string Pages_Sales_FleetCustomers_Create_Edit = "Pages.Sales.FleetSale.CreateEdit";
        public const string Pages_Sales_FleetCustomers_Delete = "Pages.Sales.FleetSale.Delete";
        public const string Pages_Sales_FleetCustomers_IsComplied = "Pages.Sales.Order.Plan.SalesTargetFleet.IsComplied";
        public const string Pages_Sales_FleetCustomers_QtyMoreThan50 = "Pages.Sales.Order.Plan.SalesTargetFleet.QtyMoreThan50";
        public const string Pages_Sales_FleetCustomers_AddOrUpdateFleetDealerInformation = "Pages.Sales.Order.Plan.SalesTargetFleet.AddOrUpdateFleetDealerInformation";
        public const string Pages_Sales_FleetCustomers_OnlyView = "Pages.Sales.Order.Plan.SalesTargetFleet.OnlyView";
        #endregion

        #region "Sales PPM TMV"
        public const string Pages_Sales_SalesPPM = "Pages.Sales.SalesPPM";
        public const string Pages_Sales_SalesPPM_Create_Edit = "Pages.Sales.SalesPPM.CreateEdit";

        #endregion



        #region "Sales Order Plan"
        public const string Pages_Sales_Menu_Order_Plan = "Pages.Sales.OrderPlan.Menu";
        #region "Nenkei"
        public const string Pages_Sales_Order_Plan_Nenkei = "Pages.Sales.Order.Plan.Nenkei";
        public const string Pages_Sales_Order_Plan_Nenkei_Search = "Pages.Sales.Order.Plan.Nenkei.Search";
        public const string Pages_Sales_Order_Plan_Nenkei_Create = "Pages.Sales.Order.Plan.Nenkei.Create";
        public const string Pages_Sales_Order_Plan_Nenkei_Edit = "Pages.Sales.Order.Plan.Nenkei.Edit";
        public const string Pages_Sales_Order_Plan_Nenkei_Delete = "Pages.Sales.Order.Plan.Nenkei.Delete";
        #endregion

        #region "Version Type"
        public const string Pages_Sales_Order_Plan_VersionType = "Pages.Sales.Order.Plan.VersionType";
        public const string Pages_Sales_Order_Plan_VersionType_Search = "Pages.Sales.Order.Plan.VersionType.Search";
        public const string Pages_Sales_Order_Plan_VersionType_Create = "Pages.Sales.Order.Plan.VersionType.Create";
        public const string Pages_Sales_Order_Plan_VersionType_Edit = "Pages.Sales.Order.Plan.VersionType.Edit";
        public const string Pages_Sales_Order_Plan_VersionType_Delete = "Pages.Sales.Order.Plan.VersionType.Delete";
        #endregion

        #region "Order Config"
        public const string Pages_Sales_Order_Plan_OrderConfig = "Pages.Sales.Order.Plan.OrderConfig";
        public const string Pages_Sales_Order_Plan_OrderConfig_Search = "Pages.Sales.Order.Plan.OrderConfig.Search";
        public const string Pages_Sales_Order_Plan_OrderConfig_Create = "Pages.Sales.Order.Plan.OrderConfig.Create";
        public const string Pages_Sales_Order_Plan_OrderConfig_Edit = "Pages.Sales.Order.Plan.OrderConfig.Edit";
        public const string Pages_Sales_Order_Plan_OrderConfig_Delete = "Pages.Sales.Order.Plan.OrderConfig.Delete";
        #endregion

        #region "Contract Target"
        public const string Pages_Sales_Order_Plan_ContractTarget = "Pages.Sales.Order.Plan.ContractTarget";
        public const string Pages_Sales_Order_Plan_ContractTarget_Search = "Pages.Sales.Order.Plan.ContractTarget.Search";
        public const string Pages_Sales_Order_Plan_ContractTarget_Create = "Pages.Sales.Order.Plan.ContractTarget.Create";
        public const string Pages_Sales_Order_Plan_ContractTarget_Edit = "Pages.Sales.Order.Plan.ContractTarget.Edit";
        public const string Pages_Sales_Order_Plan_ContractTarget_Delete = "Pages.Sales.Order.Plan.ContractTarget.Delete";
        #endregion

        #region "Sales Target"
        public const string Pages_Sales_Order_Plan_SalesTarget = "Pages.Sales.Order.Plan.SalesTarget";
        public const string Pages_Sales_Order_Plan_SalesTarget_Search = "Pages.Sales.Order.Plan.SalesTarget.Search";
        public const string Pages_Sales_Order_Plan_SalesTarget_Create = "Pages.Sales.Order.Plan.SalesTarget.Create";
        public const string Pages_Sales_Order_Plan_SalesTarget_Edit = "Pages.Sales.Order.Plan.SalesTarget.Edit";
        public const string Pages_Sales_Order_Plan_SalesTarget_Delete = "Pages.Sales.Order.Plan.SalesTarget.Delete";
        #endregion

        #region "Sales Target Fleet"
        public const string Pages_Sales_Order_Plan_SalesTargetFleet = "Pages.Sales.Order.Plan.SalesTargetFleet";
        public const string Pages_Sales_Order_Plan_SalesTargetFleet_Search = "Pages.Sales.Order.Plan.SalesTargetFleet.Search";
        public const string Pages_Sales_Order_Plan_SalesTargetFleet_Create = "Pages.Sales.Order.Plan.SalesTargetFleet.Create";
        public const string Pages_Sales_Order_Plan_SalesTargetFleet_Edit = "Pages.Sales.Order.Plan.SalesTargetFleet.Edit";
        public const string Pages_Sales_Order_Plan_SalesTargetFleet_Delete = "Pages.Sales.Order.Plan.SalesTargetFleet.Delete";
        #endregion

        #region "Data Rundown"
        public const string Pages_Sales_Order_Plan_DataRundown = "Pages.Sales.Order.Plan.DataRundown";
        public const string Pages_Sales_Order_Plan_DataRundown_Search = "Pages.Sales.Order.Plan.DataRundown.Search";
        public const string Pages_Sales_Order_Plan_DataRundown_Create = "Pages.Sales.Order.Plan.DataRundown.Create";
        public const string Pages_Sales_Order_Plan_DataRundown_Edit = "Pages.Sales.Order.Plan.DataRundown.Edit";
        public const string Pages_Sales_Order_Plan_DataRundown_Delete = "Pages.Sales.Order.Plan.DataRundown.Delete";
        #endregion

        #region "Contract Plan"
        public const string Pages_Sales_Order_Plan_ContractPlan = "Pages.Sales.Order.Plan.ContractPlan";
        public const string Pages_Sales_Order_Plan_ContractPlan_Search = "Pages.Sales.Order.Plan.ContractPlan.Search";
        public const string Pages_Sales_Order_Plan_ContractPlan_Create = "Pages.Sales.Order.Plan.ContractPlan.Create";
        public const string Pages_Sales_Order_Plan_ContractPlan_Edit = "Pages.Sales.Order.Plan.ContractPlan.Edit";
        public const string Pages_Sales_Order_Plan_ContractPlan_Delete = "Pages.Sales.Order.Plan.ContractPlan.Delete";
        #endregion

        #region "Sales Plan"
        public const string Pages_Sales_Order_Plan_SalesPlan = "Pages.Sales.Order.Plan.SalesPlan";
        public const string Pages_Sales_Order_Plan_SalesPlan_Search = "Pages.Sales.Order.Plan.SalesPlan.Search";
        public const string Pages_Sales_Order_Plan_SalesPlan_Create = "Pages.Sales.Order.Plan.SalesPlan.Create";
        public const string Pages_Sales_Order_Plan_SalesPlan_Edit = "Pages.Sales.Order.Plan.SalesPlan.Edit";
        public const string Pages_Sales_Order_Plan_SalesPlan_Delete = "Pages.Sales.Order.Plan.SalesPlan.Delete";
        #endregion

        #region "Dealer Order"
        public const string Pages_Sales_Order_Plan_DealerOrder = "Pages.Sales.Order.Plan.DealerOrder";
        public const string Pages_Sales_Order_Plan_DealerOrder_Search = "Pages.Sales.Order.Plan.DealerOrder.Search";
        public const string Pages_Sales_Order_Plan_DealerOrder_Create = "Pages.Sales.Order.Plan.DealerOrder.Create";
        public const string Pages_Sales_Order_Plan_DealerOrder_Edit = "Pages.Sales.Order.Plan.DealerOrder.Edit";
        public const string Pages_Sales_Order_Plan_DealerOrder_Delete = "Pages.Sales.Order.Plan.DealerOrder.Delete";
        #endregion

        #region "Vehicle Allocation"
        public const string Pages_Sales_Order_Plan_VehicleAllocation = "Pages.Sales.Order.Plan.VehicleAllocation";
        public const string Pages_Sales_Order_Plan_VehicleAllocation_Search = "Pages.Sales.Order.Plan.VehicleAllocation.Search";
        public const string Pages_Sales_Order_Plan_VehicleAllocation_Create = "Pages.Sales.Order.Plan.VehicleAllocation.Create";
        public const string Pages_Sales_Order_Plan_VehicleAllocation_Edit = "Pages.Sales.Order.Plan.VehicleAllocation.Edit";
        public const string Pages_Sales_Order_Plan_VehicleAllocation_Delete = "Pages.Sales.Order.Plan.VehicleAllocation.Delete";
        #endregion

        #region "Cbu Color Order"
        public const string Pages_Sales_Order_Plan_CbuColorOrder = "Pages.Sales.Order.Plan.CbuColorOrder";
        public const string Pages_Sales_Order_Plan_CbuColorOrder_Search = "Pages.Sales.Order.Plan.CbuColorOrder.Search";
        public const string Pages_Sales_Order_Plan_CbuColorOrder_Create = "Pages.Sales.Order.Plan.CbuColorOrder.Create";
        public const string Pages_Sales_Order_Plan_CbuColorOrder_Edit = "Pages.Sales.Order.Plan.CbuColorOrder.Edit";
        public const string Pages_Sales_Order_Plan_CbuColorOrder_Delete = "Pages.Sales.Order.Plan.CbuColorOrder.Delete";
        #endregion

        #region "Ckd Color Order"
        public const string Pages_Sales_Order_Plan_CkdColorOrder = "Pages.Sales.Order.Plan.CkdColorOrder";
        public const string Pages_Sales_Order_Plan_CkdColorOrder_Search = "Pages.Sales.Order.Plan.CkdColorOrder.Search";
        #endregion

        #region "Order Dealer Request"
        public const string Pages_Sales_Order_Dealer_Request = "Pages.Sales.Order.Dealer.Request";
        public const string Pages_Sales_Order_Dealer_Request_Search = "Pages.Sales.Order.Dealer.Request.Search";
        public const string Pages_Sales_Order_Dealer_Request_Create = "Pages.Sales.Order.Dealer.Request.Create";
        #endregion

        #region "Sales Target Plan TMV By Day"
        public const string Pages_Sales_Target_Plan_TMV_ByDay = "Pages.Sales.Target.Plan_TMV.ByDay";
        public const string Pages_Sales_Target_Plan_TMV_ByDay_Edit = "Pages.Sales.Target.Plan_TMV.ByDay.Edit";
        public const string Pages_Sales_Target_Plan_TMV_ByDay_Import = "Pages.Sales.Target.Plan_TMV.ByDay.Import";
        public const string Pages_Sales_Target_Plan_TMV_ByDay_Delete = "Pages.Sales.Target.Plan_TMV.ByDay.Delete";

        #endregion

        #region "CWD Target Plan TMV By Day"
        public const string Pages_Cwd_Target_Plan_TMV_ByDay = "Pages.Cwd.Target.Plan_TMV.ByDay";
        public const string Pages_Cwd_Target_Plan_TMV_ByDay_Import = "Pages.Cwd.Target.Plan_TMV.ByDay.Import";
        public const string Pages_Cwd_Target_Plan_TMV_ByDay_Edit = "Pages.Cwd.Target.Plan_TMV.ByDay.Edit";
        public const string Pages_Cwd_Target_Plan_TMV_ByDay_Delete = "Pages.Cwd.Target.Plan_TMV.ByDay.Delete";

        #endregion

        #endregion

        #region "Sales Order Plan TMAP"
        public const string Pages_Sales_Menu_Order_Plan_TMAP = "Pages.Sales.OrderPlan.TMAP.Menu";
        #region "FSO Grade Submit Config"
        public const string Pages_Sales_FSO_Grade_Submit_Config = "Pages.Sales.FSO.Grade.Submit.Config";
        public const string Pages_Sales_FSO_Grade_Submit_Config_Search = "Pages.Sales.FSO.Grade.Submit.Config.Search";
        public const string Pages_Sales_FSO_Grade_Submit_Config_Create = "Pages.Sales.FSO.Grade.Submit.Config.Create";
        public const string Pages_Sales_FSO_Grade_Submit_Config_Edit = "Pages.Sales.FSO.Grade.Submit.Config.Edit";
        public const string Pages_Sales_FSO_Grade_Submit_Config_Delete = "Pages.Sales.FSO.Grade.Submit.Config.Delete";
        #endregion

        #region "FSO Config"
        public const string Pages_Sales_FSO_Config = "Pages.Sales.FSO.Config";
        public const string Pages_Sales_FSO_Config_Search = "Pages.Sales.FSO.Config.Search";
        public const string Pages_Sales_FSO_Config_Create = "Pages.Sales.FSO.Config.Create";
        public const string Pages_Sales_FSO_Config_Edit = "Pages.Sales.FSO.Config.Edit";
        public const string Pages_Sales_FSO_Config_Delete = "Pages.Sales.FSO.Config.Delete";
        #endregion

        #region "FSO Config Type"
        public const string Pages_Sales_FSO_Config_Type = "Pages.Sales.FSO.Config.Type";
        public const string Pages_Sales_FSO_Config_Type_Search = "Pages.Sales.FSO.Config.Type.Search";
        public const string Pages_Sales_FSO_Config_Type_Create = "Pages.Sales.FSO.Config.Type.Create";
        public const string Pages_Sales_FSO_Config_Type_Edit = "Pages.Sales.FSO.Config.Type.Edit";
        public const string Pages_Sales_FSO_Config_Type_Delete = "Pages.Sales.FSO.Config.Type.Delete";
        #endregion

        #region "FSO Allocation"
        public const string Pages_Sales_FSO_Allocation = "Pages.Sales.FSO.Allocation";
        public const string Pages_Sales_FSO_Allocation_Search = "Pages.Sales.FSO.Allocation.Search";
        public const string Pages_Sales_FSO_Allocation_Create = "Pages.Sales.FSO.Allocation.Create";
        public const string Pages_Sales_FSO_Allocation_Edit = "Pages.Sales.FSO.Allocation.Edit";
        public const string Pages_Sales_FSO_Allocation_Delete = "Pages.Sales.FSO.Allocation.Delete";
        #endregion
        #endregion

        #region "Dashboard"
        public const string Pages_Dashboard_Permission_Menu = "Pages.Dashboard.Permission.Menu";
        public const string Pages_Dashboard_Permission_Search = "Pages.Dashboard.Permission.Search";
        public const string Pages_Dashboard_Permission_Save = "Pages.Dashboard.Permission.Save";

        #region "Dashboard for Tenant"
        public const string Pages_Tenant_Dashboard_WidgetOverTable = "Pages.Tenant.Dashboard.WidgetOverTable";
        public const string Pages_Tenant_Dashboard_WidgetTransitionStatus = "Pages.Tenant.Dashboard.WidgetTransitionStatus";
        public const string Pages_Tenant_Dashboard_WidgetTargetActualQty = "Pages.Tenant.Dashboard.WidgetTargetActualQty";
        public const string Pages_Tenant_Dashboard_WidgetConversionRate = "Pages.Tenant.Dashboard.WidgetConversionRate";
        public const string Pages_Tenant_Dashboard_WidgetReasonOfLost = "Pages.Tenant.Dashboard.WidgetReasonOfLost";
        public const string Pages_Tenant_Dashboard_WidgetLocateSalesPerson = "Pages.Tenant.Dashboard.WidgetLocateSalesPerson";
        public const string Pages_Tenant_Dashboard_WidgetConversionRateSalesPerson = "Pages.Tenant.Dashboard.WidgetConversionRateSalesPerson";
        public const string Pages_Tenant_Dashboard_WidgetFollowActivitySalesPerson = "Pages.Tenant.Dashboard.WidgetFollowActivitySalesPerson";
        public const string Pages_Tenant_Dashboard_WidgetListSoldCar = "Pages.Tenant.Dashboard.WidgetListSoldCar";
        public const string Pages_Tenant_Dashboard_WidgetNumberOfConversions = "Pages.Tenant.Dashboard.WidgetNumberOfConversions";
        public const string Pages_Tenant_Dashboard_WidgetNumberInquiryOverMonthForDealer = "Pages.Tenant.Dashboard.WidgetNumberInquiryOverMonthForDealer";
        public const string Pages_Tenant_Dashboard_WidgetResultConversionOverMonthForDealer = "Pages.Tenant.Dashboard.WidgetResultConversionOverMonthForDealer";
        public const string Pages_Tenant_Dashboard_WidgetStatisticsInquiryOverGroupForDealer = "Pages.Tenant.Dashboard.WidgetStatisticsInquiryOverGroupForDealer";
        public const string Pages_Tenant_Dashboard_WidgetListInquiryFromTMVForDealer = "Pages.Tenant.Dashboard.WidgetListInquiryFromTMVForDealer";
        public const string Pages_Tenant_Dashboard_WidgetStructureGeneralCustomer = "Pages.Tenant.Dashboard.WidgetStructureGeneralCustomer";
        public const string Pages_Tenant_Dashboard_WidgetGereralCustomerByDept = "Pages.Tenant.Dashboard.WidgetGereralCustomerByDept";
        public const string Pages_Tenant_Dashboard_WidgetGereralCustomerByWeek = "Pages.Tenant.Dashboard.WidgetGereralCustomerByWeek";
        public const string Pages_Tenant_Dashboard_WidgetGereralCustomerByMonth = "Pages.Tenant.Dashboard.WidgetGereralCustomerByMonth";
        public const string Pages_Tenant_Dashboard_WidgetStructureSourceCustomer = "Pages.Tenant.Dashboard.WidgetStructureSourceCustomer";
        public const string Pages_Tenant_Dashboard_WidgetSummarySourceCustomer = "Pages.Tenant.Dashboard.WidgetSummarySourceCustomer";
        public const string Pages_Tenant_Dashboard_WidgetSummaryVehicleCustomer = "Pages.Tenant.Dashboard.WidgetSummaryVehicleCustomer";
        public const string Pages_Tenant_Dashboard_WidgetLostVehicleCustomer = "Pages.Tenant.Dashboard.WidgetLostVehicleCustomer";
        public const string Pages_Tenant_Dashboard_WidgetGroupCustomerDRA = "Pages.Tenant.Dashboard.WidgetGroupCustomerDRA";
        public const string Pages_Tenant_Dashboard_WidgetGroupCustomerProvince = "Pages.Tenant.Dashboard.WidgetGroupCustomerProvince";
        public const string Pages_Tenant_Dashboard_WidgetCustomerPRMSource = "Pages.Tenant.Dashboard.WidgetCustomerPRMSource";
        public const string Pages_Tenant_Dashboard_WidgetCustomerPRMModel = "Pages.Tenant.Dashboard.WidgetCustomerPRMModel";
        public const string Pages_Tenant_Dashboard_WidgetCustomerPRMSourceModel = "Pages.Tenant.Dashboard.WidgetCustomerPRMSourceModel";
        public const string Pages_Tenant_Dashboard_WidgetContactDetailHwc = "Pages.Tenant.Dashboard.WidgetContactDetailHwc";
        public const string Pages_Tenant_Dashboard_WidgetContactGeneralHwc = "Pages.Tenant.Dashboard.WidgetContactGeneralHwc";
        public const string Pages_Tenant_Dashboard_WidgetMovementImCwd = "Pages.Tenant.Dashboard.WidgetMovementImCwD";
        public const string Pages_Tenant_Dashboard_WidgetMovementSale = "Pages.Tenant.Dashboard.WidgetMovementSale";
        public const string Pages_Tenant_Dashboard_WidgetCwdPlanByModel = "Pages.Tenant.Dashboard.WidgetCwdPlanByModel";
        public const string Pages_Tenant_Dashboard_WidgetSaleActualPlanByModel = "Pages.Tenant.Dashboard.WidgetSaleActualPlanByModel";
        public const string Pages_Tenant_Dashboard_WidgetSource = "Pages.Tenant.Dashboard.WidgetSource";
        public const string Pages_Tenant_Dashboard_WidgetGrade = "Pages.Tenant.Dashboard.WidgetGrade";
        public const string Pages_Tenant_Dashboard_WidgetDetailPotentialCustomer = "Pages.Tenant.Dashboard.WidgetDetailPotentialCustomer";
        public const string Pages_Tenant_Dashboard_WidgetSaleProcess = "Pages.Tenant.Dashboard.WidgetSaleProcess";
        public const string Pages_Tenant_Dashboard_WidgetProvince = "Pages.Tenant.Dashboard.WidgetProvince";
        public const string Pages_Tenant_Dashboard_WidgetDistrict = "Pages.Tenant.Dashboard.WidgetDistric";
        public const string Pages_Tenant_Dashboard_WidgetSourceInfo = "Pages.Tenant.Dashboard.WidgetSourceInfo";
        public const string Pages_Tenant_Dashboard_WidgetPaymentMethod = "Pages.Tenant.Dashboard.WidgetPaymentMethod";
        public const string Pages_Tenant_Dashboard_WidgetCustomerSold = "Pages.Tenant.Dashboard.WidgetCustomerSold";
        public const string Pages_Tenant_Dashboard_WidgetPaymentMethodOfCustomer = "Pages.Tenant.Dashboard.WidgetPaymentMethodOfCustomer";
        public const string Pages_Tenant_Dashboard_WidgetDistrictOfCustomer = "Pages.Tenant.Dashboard.WidgetDistrictOfCustomer";
        public const string Pages_Tenant_Dashboard_WidgetProvinceOfCutomer = "Pages.Tenant.Dashboard.WidgetProvinceOfCutomer";
        public const string Pages_Tenant_Dashboard_WidgetProcessOfCustomer = "Pages.Tenant.Dashboard.WidgetProcessOfCustomer";
        public const string Pages_Tenant_Dashboard_WidgetSourceOfCustomer = "Pages.Tenant.Dashboard.WidgetSourceOfCustomer";
        public const string Pages_Tenant_Dashboard_WidgetVehicleOfCustomer = "Pages.Tenant.Dashboard.WidgetVehicleOfCustomer";
        public const string Pages_Tenant_Dashboard_WidgetAverageConversiontime = "Pages.Tenant.Dashboard.WidgetAverageConversiontime";
        public const string Pages_Tenant_Dashboard_WidgetAveragecontacttime = "Pages.Tenant.Dashboard.WidgetAveragecontacttime";
        public const string Pages_Tenant_Dashboard_WidgetSourceInforOfCustomer = "Pages.Tenant.Dashboard.WidgetSourceInforOfCustomer";
        public const string Pages_Tenant_Dashboard_WidgetVehicleSalesPerson = "Pages.Tenant.Dashboard.WidgetVehicleSalesPerson";
        public const string Pages_Tenant_Dashboard_WidgetCwdPlanByDayOrWeekly = "Pages.Tenant.Dashboard.WidgetCwdPlanByDayOrWeekly";
        public const string Pages_Tenant_Dashboard_WidgetSalePlanByDayOrWeekly = "Pages.Tenant.Dashboard.WidgetSalePlanByDayOrWeekly";
        public const string Pages_Tenant_Dashboard_WidgetDetailByModelGrade = "Pages.Tenant.Dashboard.WidgetDetailByModelGrade";
        public const string Pages_Tenant_Dashboard_WidgetImConversionTotalByHotness = "Pages.Tenant.Dashboard.WidgetImConversionTotalByHotness";
        public const string Pages_Tenant_Dashboard_WidgetConversionCwdByHotness = "Pages.Tenant.Dashboard.WidgetConversionCwdByHotness";
        public const string Pages_Tenant_Dashboard_WidgetConvesionRateByHotness = "Pages.Tenant.Dashboard.WidgetConvesionRateByHotness";
        public const string Pages_Tenant_Dashboard_WidgetTotalLossReason = "Pages.Tenant.Dashboard.WidgetTotalLossReason";
        public const string Pages_Tenant_Dashboard_WidgetLossByModel = "Pages.Tenant.Dashboard.WidgetLossByModel";
        public const string Pages_Tenant_Dashboard_WidgetLossByPrivateReasons = "Pages.Tenant.Dashboard.WidgetLossByPrivateReasons";
        public const string Pages_Tenant_Dashboard_WidgetLossByOtherDlrsReasons = "Pages.Tenant.Dashboard.WidgetLossByOtherDlrsReasons";
        public const string Pages_Tenant_Dashboard_WidgetLossByOtherMakerReasons = "Pages.Tenant.Dashboard.WidgetLossByOtherMakerReasons";
        public const string Pages_Tenant_Dashboard_WidgetCustomerBySourceTotal = "Pages.Tenant.Dashboard.WidgetCustomerBySourceTotal";
        public const string Pages_Tenant_Dashboard_WidgetCustomerBySalepersonSource = "Pages.Tenant.Dashboard.WidgetCustomerBySalepersonSource";
        public const string Pages_Tenant_Dashboard_WidgetCustomerByDealerSource = "Pages.Tenant.Dashboard.WidgetCustomerByDealerSource";
        public const string Pages_Tenant_Dashboard_WidgetCustomerByTmvSource = "Pages.Tenant.Dashboard.WidgetCustomerByTmvSource";
        public const string Pages_Tenant_Dashboard_WidgetCustomerByTotalModels = "Pages.Tenant.Dashboard.WidgetCustomerByTotalModels";
        public const string Pages_Tenant_Dashboard_WidgetNewCustomerByGrade = "Pages.Tenant.Dashboard.WidgetNewCustomerByGrade";
        public const string Pages_Tenant_Dashboard_WidgetRemainingCustomerByGrade = "Pages.Tenant.Dashboard.WidgetRemainingCustomerByGrade";
        public const string Pages_Tenant_Dashboard_WidgetAllCustomerByHotness = "Pages.Tenant.Dashboard.WidgetAllCustomerByHotness";
        public const string Pages_Tenant_Dashboard_WidgetAllOfCustomerByModel = "Pages.Tenant.Dashboard.WidgetAllOfCustomerByModel";
        public const string Pages_Tenant_Dashboard_WidgetSalesActualAndCWDPlanByModel = "Pages.Tenant.Dashboard.WidgetSalesActualAndCWDPlanByModel";
        #endregion

        #region "Dashboard for Host"
        public const string Pages_Administration_Host_Dashboard_WidgetOverTable = "Pages.Host.Dashboard.WidgetOverTable";
        public const string Pages_Administration_Host_Dashboard_WidgetTransitionStatus = "Pages.Host.Dashboard.WidgetTransitionStatus";
        public const string Pages_Administration_Host_Dashboard_WidgetTargetActualQty = "Pages.Host.Dashboard.WidgetTargetActualQty";
        public const string Pages_Administration_Host_Dashboard_WidgetReasonOfLost = "Pages.Host.Dashboard.WidgetReasonOfLost";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionRate = "Pages.Host.Dashboard.WidgetConversionRate";
        public const string Pages_Administration_Host_Dashboard_WidgetNumberInquiryOfMonth = "Pages.Host.Dashboard.WidgetNumberInquiryOfMonth";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionRateOverMonth = "Pages.Host.Dashboard.WidgetConversionRateOverMonth";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionSourceOverMonth = "Pages.Host.Dashboard.WidgetConversionSourceOverMonth";
        public const string Pages_Administration_Host_Dashboard_WidgetStatisticsInquiryOverDealer = "Pages.Host.Dashboard.WidgetStatisticsInquiryOverDealer";
        public const string Pages_Administration_Host_Dashboard_WidgetResultConversionOverMonth = "Pages.Host.Dashboard.WidgetResultConversionOverMonth";
        public const string Pages_Administration_Host_Dashboard_WidgetListInquiryFromTMV = "Pages.Host.Dashboard.WidgetListInquiryFromTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetInquiryTMVReasonOfNC = "Pages.Host.Dashboard.WidgetInquiryTMVReasonOfNC";
        public const string Pages_Administration_Host_Dashboard_WidgetLeadByAge = "Pages.Host.Dashboard.WidgetLeadByAge";
        public const string Pages_Administration_Host_Dashboard_WidgetWeeklyTrackingByAge = "Pages.Host.Dashboard.WidgetWeeklyTrackingByAge";
        public const string Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusBySource = "Pages.Host.Dashboard.WidgetNewlyAddedLeadStatusBySource";
        public const string Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusByRegion = "Pages.Host.Dashboard.WidgetNewlyAddedLeadStatusByRegion";
        public const string Pages_Administration_Host_Dashboard_WidgetNewlyAddedLeadStatusByRegionAndSource = "Pages.Host.Dashboard.WidgetNewlyAddedLeadStatusByRegionAndSource";
        public const string Pages_Administration_Host_Dashboard_WidgetViewContactedBySource = "Pages.Host.Dashboard.WidgetViewContactedBySource";
        public const string Pages_Administration_Host_Dashboard_WidgetViewSuccessContactedBySource = "Pages.Host.Dashboard.WidgetViewSuccessContactedBySource";
        public const string Pages_Administration_Host_Dashboard_WidgetContactAndContactSuccessRate = "Pages.Host.Dashboard.WidgetContactAndContactSuccessRate";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionRateOfInquiryToSR = "Pages.Host.Dashboard.WidgetConversionRateOfInquiryToSR";
        public const string Pages_Administration_Host_Dashboard_WidgetRankingByDealers = "Pages.Host.Dashboard.WidgetRankingByDealers";
        public const string Pages_Administration_Host_Dashboard_WidgetAverageLeadTimeFromGeneration = "Pages.Host.Dashboard.WidgetAverageLeadTimeFromGeneration";
        public const string Pages_Administration_Host_Dashboard_WidgetLeadTimeByDealersFromGeneration = "Pages.Host.Dashboard.WidgetLeadTimeByDealersFromGeneration";
        public const string Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsCWD = "Pages.Host.Dashboard.WidgetDeepDiveAnalysisListOfSelectedLeadsCWD";
        public const string Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsInquiry = "Pages.Host.Dashboard.WidgetDeepDiveAnalysisListOfSelectedLeadsInquiry";
        public const string Pages_Administration_Host_Dashboard_WidgetDeepDiveAnalysisListOfSelectedLeadsContactedFailed = "Pages.Host.Dashboard.WidgetDeepDiveAnalysisListOfSelectedLeadsContactedFailed";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionRateForTMV = "Pages.Host.Dashboard.WidgetConversionRateForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetLocateDealerForTMV = "Pages.Host.Dashboard.WidgetLocateDealerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetStatisticsInquiryOverMonthForTmv = "Pages.Host.Dashboard.WidgetStatisticsInquiryOverMonthForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetMovementImCwdForTmv = "Pages.Host.Dashboard.WidgetMovementImCwdForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetAllOfCustomerByModelForTmv = "Pages.Host.Dashboard.WidgetAllOfCustomerByModelForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetAllCustomerByHotnessForTmv = "Pages.Host.Dashboard.WidgetAllCustomerByHotnessForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetCustomerBySourceTotalForTmv = "Pages.Host.Dashboard.WidgetCustomerBySourceTotalForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetCustomerBySalepersonSourceForTmv = "Pages.Host.Dashboard.WidgetCustomerBySalepersonSourceForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetCustomerByDealerSourceForTmv = "Pages.Host.Dashboard.WidgetCustomerByDealerSourceForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetCustomerByTmvSourceForTmv = "Pages.Host.Dashboard.WidgetCustomerByTmvSourceForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetTotalLossReasonForTmv = "Pages.Host.Dashboard.WidgetTotalLossReasonForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetLossByPrivateReasonsForTmv = "Pages.Host.Dashboard.WidgetLossByPrivateReasonsForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetLossOtherDlrsReasonForTmv = "Pages.Host.Dashboard.WidgetLossOtherDlrsReasonForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetLossByOttherMakerReasonsForTmv = "Pages.Host.Dashboard.WidgetLossByOttherMakerReasonsForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetLossByModelForTmv = "Pages.Host.Dashboard.WidgetLossByModelForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetContractGeneralHwcForTmv = "Pages.Host.Dashboard.WidgetContractGeneralHwcForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetFollowActivitySalesPrsonForTmv = "Pages.Host.Dashboard.WidgetFollowActivitySalesPrsonForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetCustomerByTotalModelForTmv = "Pages.Host.Dashboard.WidgetCustomerByTotalModelForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetRemainingCustomerByGradeForTmv = "Pages.Host.Dashboard.WidgetRemainingCustomerByGradeForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetNewCustomerByGradeForTmv = "Pages.Host.Dashboard.WidgetNewCustomerByGradeForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetImConversionTotalByHotnessForTmv = "Pages.Host.Dashboard.WidgetImConversionTotalByHotnessForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionCwdByHotnessForTmv = "Pages.Host.Dashboard.WidgetConversionCwdByHotnessForTmv";
        public const string Pages_Administration_Host_Dashboard_WidgetConversionRateByHotnessForTmv = "Pages.Host.Dashboard.WidgetConversionRateByHotnessForTmv";

        public const string Pages_Administration_Host_Dashboard_WidgetCustomersSoldForTMV = "Pages.Host.Dashboard.WidgetCustomersSoldForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetDetailPotentialCustomerForTMV = "Pages.Host.Dashboard.WidgetDetailPotentialCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetSourceChartForTMV = "Pages.Host.Dashboard.WidgetSourceChartForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetSourceOfCustomerForTMV = "Pages.Host.Dashboard.WidgetSourceOfCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetGradeChartForTMV = "Pages.Host.Dashboard.WidgetGradeChartForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetProvinceForTMV = "Pages.Host.Dashboard.WidgetProvinceForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetDistrictForTMV = "Pages.Host.Dashboard.WidgetDistrictForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetSourceInforForTMV = "Pages.Host.Dashboard.WidgetSourceInforForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetProcessForTMV = "Pages.Host.Dashboard.WidgetProcessForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetPaymentMethodForTMV = "Pages.Host.Dashboard.WidgetPaymentMethodForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetVehicleOfCustomerForTMV = "Pages.Host.Dashboard.WidgetVehicleOfCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetProvinceOfCutomerForTMV = "Pages.Host.Dashboard.WidgetProvinceOfCutomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetDistrictOfCustomerForTMV = "Pages.Host.Dashboard.WidgetDistrictOfCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetPaymentMethodOfCustomerForTMV = "Pages.Host.Dashboard.WidgetPaymentMethodOfCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetProcessOfCustomerForTMV = "Pages.Host.Dashboard.WidgetProcessOfCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetSourceInforOfCustomerForTMV = "Pages.Host.Dashboard.WidgetSourceInforOfCustomerForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetAverageConversiontimeForTMV = "Pages.Host.Dashboard.WidgetAverageConversiontimeForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetAveragecontacttimeForTMV = "Pages.Host.Dashboard.WidgetAveragecontacttimeForTMV";
        public const string Pages_Administration_Host_Dashboard_WidgetVehicleSalesPersonForTMV = "Pages.Host.Dashboard.WidgetVehicleSalesPersonForTMV";
        #endregion


        #endregion

        #region "Datahub API"
        public const string Pages_Datahub_Permission = "Pages.Datahub.Permission";
        public const string Pages_Datahub_Permission_Product = "Pages.Datahub.Permission.Product";
        public const string Pages_Datahub_Permission_Finance = "Pages.Datahub.Permission.Finance";
        public const string Pages_Datahub_Permission_Insurance = "Pages.Datahub.Permission.Insurance";
        public const string Pages_Datahub_Permission_News = "Pages.Datahub.Permission.News";
        public const string Pages_Datahub_Permission_Loyalty = "Pages.Datahub.Permission.Loyalty";
        #endregion

        #region "Datahub Website API"
        public const string Pages_Datahub_Website_Permission = "Pages.Datahub.Website.Permission";
        public const string Pages_Datahub_Website_Permission_Product = "Pages.Datahub.Website.Permission.Product";
        public const string Pages_Datahub_Website_Permission_Finance = "Pages.Datahub.Website.Permission.Finance";
        public const string Pages_Datahub_Website_Permission_Insurance = "Pages.Datahub.Website.Permission.Insurance";
        public const string Pages_Datahub_Website_Permission_News = "Pages.Datahub.Website.Permission.News";
        public const string Pages_Datahub_Website_Permission_Loyalty = "Pages.Datahub.Permission.Website.Loyalty";
        #endregion

        #region Loyalty API
        public const string Pages_LoyaltyAPI_Permission = "Pages.LoyaltyAPI.Permission";
        #endregion

        #region Đề xuất bán hàng
        #region Báo giá
        public const string Pages_Sales_Proposal_Quotation = "Pages.Sales.Proposal.Quotation";

        #endregion
        #region Đề xuất BH
        public const string Pages_Sales_Proposal_Menu = "Pages.Sales.Proposal.Menu";
        public const string Pages_Sales_Proposal_Main = "Pages.Sales.Proposal.Menu.Main";
        public const string Pages_Sales_Proposal_Menu_Main_Create = "Pages.Sales.Proposal.Menu.Main.Create";
        public const string Pages_Sales_Proposal_Menu_Main_Edit = "Pages.Sales.Proposal.Menu.Main.Edit";
        public const string Pages_Sales_Proposal_Menu_Main_Delete = "Pages.Sales.Proposal.Menu.Main.Delete";
        public const string Pages_Sales_Proposal_Menu_Main_CancelRequest = "Pages.Sales.Proposal.Menu.Main.CancelRequest";
        #endregion

        #region Phê duyệt BH
        public const string Pages_Sales_Proposal_Approve = "Pages.Sales.Proposal.Menu.Approve";

        public const string Pages_Sales_Proposal_Approve_Approve = "Pages.Sales.Proposal.Menu.Approve.Approve";
        public const string Pages_Sales_Proposal_Approve_Reject = "Pages.Sales.Proposal.Menu.Approve.Reject";
        public const string Pages_Sales_Proposal_Approve_ApproveCancel = "Pages.Sales.Proposal.Menu.Approve.ApproveCancel";
        public const string Pages_Sales_Proposal_Approve_RejectCancel = "Pages.Sales.Proposal.Menu.Approve.RejectCancel";
        #endregion
        public const string Pages_Sales_Proposal_Policy = "Pages.Sales.Proposal.Menu.Policy";
        public const string Pages_Sales_Tmv_Msig = "Pages.Msig";
        #endregion


    }
}