using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using XFramework.Models;
using XFramework.Repositories.Interfaces;
namespace XFramework.Repositories.Implementation
{
    public class OrionDbContext : DbContext, IOrionDbContext
    {
        public System.Data.Entity.DbSet<AdvanceFilter> AdvanceFilters { get; set; } // AdvanceFilters
        public System.Data.Entity.DbSet<ApplicationTrackLog> ApplicationTrackLogs { get; set; } // ApplicationTrackLogs
        public System.Data.Entity.DbSet<Attachment> Attachments { get; set; } // Attachments
        public System.Data.Entity.DbSet<ClientAccount> ClientAccounts { get; set; } // ClientAccounts
        public System.Data.Entity.DbSet<ColumnSetting> ColumnSettings { get; set; } // ColumnSettings
        public System.Data.Entity.DbSet<ConfigInfo> ConfigInfoes { get; set; } // ConfigInfo
        public System.Data.Entity.DbSet<Credential> Credentials { get; set; } // Credentials
        public System.Data.Entity.DbSet<CustomerCompany> CustomerCompanies { get; set; } // CustomerCompanies
        public System.Data.Entity.DbSet<CustomerTmsProjectRelation> CustomerTmsProjectRelations { get; set; } // CustomerTMSProjectRelations
        public System.Data.Entity.DbSet<Department> Departments { get; set; } // Departments
        public System.Data.Entity.DbSet<DictData> DictDatas { get; set; } // DictDatas
        public System.Data.Entity.DbSet<DictType> DictTypes { get; set; } // DictTypes
        public System.Data.Entity.DbSet<ExchangeLog> ExchangeLogs { get; set; } // ExchangeLogs
        public System.Data.Entity.DbSet<Field> Fields { get; set; } // Fields
        public System.Data.Entity.DbSet<FieldPermission> FieldPermissions { get; set; } // FieldPermissions
        public System.Data.Entity.DbSet<FreewayOrder> FreewayOrders { get; set; } // FreewayOrders
        public System.Data.Entity.DbSet<Group> Groups { get; set; } // Groups
        public System.Data.Entity.DbSet<GroupWidgetRelation> GroupWidgetRelations { get; set; } // GroupWidgetRelations
        public System.Data.Entity.DbSet<IntegrationCredential> IntegrationCredentials { get; set; } // IntegrationCredentials
        public System.Data.Entity.DbSet<LanguageVendor> LanguageVendors { get; set; } // LanguageVendors
        public System.Data.Entity.DbSet<LanguageVendorsRelation> LanguageVendorsRelations { get; set; } // LanguageVendorsRelations
        public System.Data.Entity.DbSet<MailTemplate> MailTemplates { get; set; } // MailTemplates
        public System.Data.Entity.DbSet<Menu> Menus { get; set; } // Menus
        public System.Data.Entity.DbSet<Message> Messages { get; set; } // Messages
        public System.Data.Entity.DbSet<ModelMapping> ModelMappings { get; set; } // ModelMappings
        public System.Data.Entity.DbSet<ModelMappingsStandard> ModelMappingsStandards { get; set; } // ModelMappings_Standard
        public System.Data.Entity.DbSet<ModelView> ModelViews { get; set; } // ModelViews
        public System.Data.Entity.DbSet<OrderSample> OrderSamples { get; set; } // OrderSamples
        public System.Data.Entity.DbSet<OrderTemplate> OrderTemplates { get; set; } // OrderTemplates
        public System.Data.Entity.DbSet<OrionFwLanguageMap> OrionFwLanguageMaps { get; set; } // OrionFwLanguageMaps
        public System.Data.Entity.DbSet<OrionMessage> OrionMessages { get; set; } // OrionMessages
        public System.Data.Entity.DbSet<OrionMessageConfiguration> OrionMessageConfigurations { get; set; } // OrionMessageConfigurations
        public System.Data.Entity.DbSet<OrionProjectFlowCurrentStatu> OrionProjectFlowCurrentStatus { get; set; } // OrionProjectFlowCurrentStatus
        public System.Data.Entity.DbSet<OrionProjectFlowStatusRecord> OrionProjectFlowStatusRecords { get; set; } // OrionProjectFlowStatusRecords
        public System.Data.Entity.DbSet<OrionProjectStepUserRelation> OrionProjectStepUserRelations { get; set; } // OrionProjectStepUserRelations
        public System.Data.Entity.DbSet<OrionProjectWorkFlowStep> OrionProjectWorkFlowSteps { get; set; } // OrionProjectWorkFlowSteps
        public System.Data.Entity.DbSet<OrionProjectWorkFlowStepTask> OrionProjectWorkFlowStepTasks { get; set; } // OrionProjectWorkFlowStepTasks
        public System.Data.Entity.DbSet<OrionStep> OrionSteps { get; set; } // OrionSteps
        public System.Data.Entity.DbSet<OrionStepFieldRelation> OrionStepFieldRelations { get; set; } // OrionStepFieldRelations
        public System.Data.Entity.DbSet<OrionTransActivity> OrionTransActivities { get; set; } // OrionTransActivities
        public System.Data.Entity.DbSet<OrionTransFlow> OrionTransFlows { get; set; } // OrionTransFlows
        public System.Data.Entity.DbSet<OrionTransFlowActivity> OrionTransFlowActivities { get; set; } // OrionTransFlowActivities
        public System.Data.Entity.DbSet<OrionTransFlowActivityInstance> OrionTransFlowActivityInstances { get; set; } // OrionTransFlowActivityInstances
        public System.Data.Entity.DbSet<OrionTransFlowActivityUser> OrionTransFlowActivityUsers { get; set; } // OrionTransFlowActivityUsers
        public System.Data.Entity.DbSet<OrionTransFlowInstance> OrionTransFlowInstances { get; set; } // OrionTransFlowInstances
        public System.Data.Entity.DbSet<OrionWorkFlow> OrionWorkFlows { get; set; } // OrionWorkFlows
        public System.Data.Entity.DbSet<OrionWorkFlowStep> OrionWorkFlowSteps { get; set; } // OrionWorkFlowSteps
        public System.Data.Entity.DbSet<OrionWorkFlowStepUserRelation> OrionWorkFlowStepUserRelations { get; set; } // OrionWorkFlowStepUserRelations
        public System.Data.Entity.DbSet<Page> Pages { get; set; } // Pages
        public System.Data.Entity.DbSet<PagePermission> PagePermissions { get; set; } // PagePermissions
        public System.Data.Entity.DbSet<PermissionView> PermissionViews { get; set; } // permissionViews
        public System.Data.Entity.DbSet<PmsOrder> PmsOrders { get; set; } // PMSOrders
        public System.Data.Entity.DbSet<PmsOrderTaskVmMetadata> PmsOrderTaskVmMetadatas { get; set; } // PMSOrderTaskVMMetadatas
        public System.Data.Entity.DbSet<PmsTask> PmsTasks { get; set; } // PMSTasks
        public System.Data.Entity.DbSet<ProjectListId> ProjectListIds { get; set; } // ProjectListIds
        public System.Data.Entity.DbSet<ProjectTemplate> ProjectTemplates { get; set; } // ProjectTemplates
        public System.Data.Entity.DbSet<ProjectTemplateItem> ProjectTemplateItems { get; set; } // ProjectTemplateItems
        public System.Data.Entity.DbSet<RelationTableCheck> RelationTableChecks { get; set; } // relationTableChecks
        public System.Data.Entity.DbSet<SecurityLog> SecurityLogs { get; set; } // SecurityLogs
        public System.Data.Entity.DbSet<SmtpServer> SmtpServers { get; set; } // SMTPServers
        public System.Data.Entity.DbSet<TeamAndUser> TeamAndUsers { get; set; } // TeamAndUsers
        //public System.Data.Entity.DbSet<TeamMember> TeamMembers { get; set; } // TeamMembers
        public System.Data.Entity.DbSet<TemplateLanguageRelationShip> TemplateLanguageRelationShips { get; set; } // TemplateLanguageRelationShips
        public System.Data.Entity.DbSet<TemplateMappingRule> TemplateMappingRules { get; set; } // TemplateMappingRules
        public System.Data.Entity.DbSet<TmsConfiguration> TmsConfigurations { get; set; } // TMSConfigurations
        public System.Data.Entity.DbSet<TmsProject> TmsProjects { get; set; } // TMSProjects
        public System.Data.Entity.DbSet<TransactionLog> TransactionLogs { get; set; } // TransactionLogs
        public System.Data.Entity.DbSet<User> Users { get; set; } // Users
        public System.Data.Entity.DbSet<UserApproval> UserApprovals { get; set; } // UserApproval
        public System.Data.Entity.DbSet<UserApprovalRole> UserApprovalRoles { get; set; } // UserApprovalRoles
        public System.Data.Entity.DbSet<UserConfig> UserConfigs { get; set; } // UserConfigs
        public System.Data.Entity.DbSet<UserCustomizedView> UserCustomizedViews { get; set; } // UserCustomizedViews
        public System.Data.Entity.DbSet<UserGroup> UserGroups { get; set; } // UserGroups
        public System.Data.Entity.DbSet<UserGroupEntity> UserGroupEntities { get; set; } // UserGroupEntities
        public System.Data.Entity.DbSet<UserSkill> UserSkills { get; set; } // UserSkills
        public System.Data.Entity.DbSet<UserSkillRelation> UserSkillRelations { get; set; } // UserSkillRelations
        public System.Data.Entity.DbSet<UserTeam> UserTeams { get; set; } // UserTeams
        public System.Data.Entity.DbSet<UserTeamRelation> UserTeamRelations { get; set; } // UserTeamRelations
        public System.Data.Entity.DbSet<UserWorkType> UserWorkTypes { get; set; } // UserWorkTypes
        public System.Data.Entity.DbSet<UserWorkTypeRelation> UserWorkTypeRelations { get; set; } // UserWorkTypeRelations
        public System.Data.Entity.DbSet<ViewAdvanceFilter> ViewAdvanceFilters { get; set; } // View_AdvanceFilter
        public System.Data.Entity.DbSet<ViewMetadataRelationShip> ViewMetadataRelationShips { get; set; } // ViewMetadataRelationShips
        //public System.Data.Entity.DbSet<ViewOrderWorkFlow> ViewOrderWorkFlows { get; set; } // View_OrderWorkFlow
        public System.Data.Entity.DbSet<ViewWfStepList> ViewWfStepLists { get; set; } // View_WFStepList
        public System.Data.Entity.DbSet<ViewWfStepListAll> ViewWfStepListAlls { get; set; } // View_WFStepList_All
        public System.Data.Entity.DbSet<WfActivity> WfActivities { get; set; } // WFActivities
        public System.Data.Entity.DbSet<WfCallbackLog> WfCallbackLogs { get; set; } // WFCallbackLog
        public System.Data.Entity.DbSet<WfFlagConfig> WfFlagConfigs { get; set; } // WFFlagConfig
        public System.Data.Entity.DbSet<WfFlagLog> WfFlagLogs { get; set; } // WFFlagLog
        public System.Data.Entity.DbSet<WfFlowStep> WfFlowSteps { get; set; } // WFFlowSteps
        public System.Data.Entity.DbSet<WfFlowStepLine> WfFlowStepLines { get; set; } // WFFlowStepLines
        public System.Data.Entity.DbSet<WfFlowStepStandardField> WfFlowStepStandardFields { get; set; } // WFFlowStepStandardField
        public System.Data.Entity.DbSet<WfFlowStepUserRelation> WfFlowStepUserRelations { get; set; } // WFFlowStepUserRelations
        public System.Data.Entity.DbSet<WfFlowTemplate> WfFlowTemplates { get; set; } // WFFlowTemplates
        public System.Data.Entity.DbSet<WfInstanceFlow> WfInstanceFlows { get; set; } // WFInstanceFlows
        public System.Data.Entity.DbSet<WfInstanceFlowStep> WfInstanceFlowSteps { get; set; } // WFInstanceFlowSteps
        public System.Data.Entity.DbSet<WfInstanceFlowStepLine> WfInstanceFlowStepLines { get; set; } // WFInstanceFlowStepLines
        public System.Data.Entity.DbSet<WfInstanceFlowStepRun> WfInstanceFlowStepRuns { get; set; } // WFInstanceFlowStepRuns
        public System.Data.Entity.DbSet<WfInstanceFlowStepRunField> WfInstanceFlowStepRunFields { get; set; } // WFInstanceFlowStepRunFields
        public System.Data.Entity.DbSet<WfInstanceFlowStepUserRelation> WfInstanceFlowStepUserRelations { get; set; } // WFInstanceFlowStepUserRelations
        public System.Data.Entity.DbSet<WfStepRunLog> WfStepRunLogs { get; set; } // WFStepRunLog
        public System.Data.Entity.DbSet<Widget> Widgets { get; set; } // Widgets
        public System.Data.Entity.DbSet<WwcCalculator> WwcCalculators { get; set; } // WWCCalculators

        static OrionDbContext()
        {
            System.Data.Entity.Database.SetInitializer<OrionDbContext>(null);
        }

        public OrionDbContext()
            : base("Name=FlexFrameDB")
        {
            // Lazy, Eager, and Explicit Loading of Related Data
            // For more information please see: http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/reading-related-data-with-the-entity-framework-in-an-asp-net-mvc-application
            this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public OrionDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public OrionDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public OrionDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public OrionDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    }
}

