

namespace XFramework.Models
{

    public interface IOrionDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AdvanceFilter> AdvanceFilters { get; set; } // AdvanceFilters
        System.Data.Entity.DbSet<ApplicationTrackLog> ApplicationTrackLogs { get; set; } // ApplicationTrackLogs
        System.Data.Entity.DbSet<Attachment> Attachments { get; set; } // Attachments
        System.Data.Entity.DbSet<ClientAccount> ClientAccounts { get; set; } // ClientAccounts
        System.Data.Entity.DbSet<ColumnSetting> ColumnSettings { get; set; } // ColumnSettings
        System.Data.Entity.DbSet<ConfigInfo> ConfigInfoes { get; set; } // ConfigInfo
        System.Data.Entity.DbSet<Credential> Credentials { get; set; } // Credentials
        System.Data.Entity.DbSet<CustomerCompany> CustomerCompanies { get; set; } // CustomerCompanies
        System.Data.Entity.DbSet<CustomerTmsProjectRelation> CustomerTmsProjectRelations { get; set; } // CustomerTMSProjectRelations
        System.Data.Entity.DbSet<Department> Departments { get; set; } // Departments
        System.Data.Entity.DbSet<DictData> DictDatas { get; set; } // DictDatas
        System.Data.Entity.DbSet<DictType> DictTypes { get; set; } // DictTypes
        System.Data.Entity.DbSet<ExchangeLog> ExchangeLogs { get; set; } // ExchangeLogs
        System.Data.Entity.DbSet<Field> Fields { get; set; } // Fields
        System.Data.Entity.DbSet<FieldPermission> FieldPermissions { get; set; } // FieldPermissions
        System.Data.Entity.DbSet<FreewayOrder> FreewayOrders { get; set; } // FreewayOrders
        System.Data.Entity.DbSet<Group> Groups { get; set; } // Groups
        System.Data.Entity.DbSet<GroupWidgetRelation> GroupWidgetRelations { get; set; } // GroupWidgetRelations
        System.Data.Entity.DbSet<IntegrationCredential> IntegrationCredentials { get; set; } // IntegrationCredentials
        System.Data.Entity.DbSet<LanguageVendor> LanguageVendors { get; set; } // LanguageVendors
        System.Data.Entity.DbSet<LanguageVendorsRelation> LanguageVendorsRelations { get; set; } // LanguageVendorsRelations
        System.Data.Entity.DbSet<MailTemplate> MailTemplates { get; set; } // MailTemplates
        System.Data.Entity.DbSet<Menu> Menus { get; set; } // Menus
        System.Data.Entity.DbSet<Message> Messages { get; set; } // Messages
        System.Data.Entity.DbSet<ModelMapping> ModelMappings { get; set; } // ModelMappings
        System.Data.Entity.DbSet<ModelMappingsStandard> ModelMappingsStandards { get; set; } // ModelMappings_Standard
        System.Data.Entity.DbSet<ModelView> ModelViews { get; set; } // ModelViews
        System.Data.Entity.DbSet<OrderSample> OrderSamples { get; set; } // OrderSamples
        System.Data.Entity.DbSet<OrderTemplate> OrderTemplates { get; set; } // OrderTemplates
        System.Data.Entity.DbSet<OrionFwLanguageMap> OrionFwLanguageMaps { get; set; } // OrionFwLanguageMaps
        System.Data.Entity.DbSet<OrionMessage> OrionMessages { get; set; } // OrionMessages
        System.Data.Entity.DbSet<OrionMessageConfiguration> OrionMessageConfigurations { get; set; } // OrionMessageConfigurations
        System.Data.Entity.DbSet<OrionProjectFlowCurrentStatu> OrionProjectFlowCurrentStatus { get; set; } // OrionProjectFlowCurrentStatus
        System.Data.Entity.DbSet<OrionProjectFlowStatusRecord> OrionProjectFlowStatusRecords { get; set; } // OrionProjectFlowStatusRecords
        System.Data.Entity.DbSet<OrionProjectStepUserRelation> OrionProjectStepUserRelations { get; set; } // OrionProjectStepUserRelations
        System.Data.Entity.DbSet<OrionProjectWorkFlowStep> OrionProjectWorkFlowSteps { get; set; } // OrionProjectWorkFlowSteps
        System.Data.Entity.DbSet<OrionProjectWorkFlowStepTask> OrionProjectWorkFlowStepTasks { get; set; } // OrionProjectWorkFlowStepTasks
        System.Data.Entity.DbSet<OrionStep> OrionSteps { get; set; } // OrionSteps
        System.Data.Entity.DbSet<OrionStepFieldRelation> OrionStepFieldRelations { get; set; } // OrionStepFieldRelations
        System.Data.Entity.DbSet<OrionTransActivity> OrionTransActivities { get; set; } // OrionTransActivities
        System.Data.Entity.DbSet<OrionTransFlow> OrionTransFlows { get; set; } // OrionTransFlows
        System.Data.Entity.DbSet<OrionTransFlowActivity> OrionTransFlowActivities { get; set; } // OrionTransFlowActivities
        System.Data.Entity.DbSet<OrionTransFlowActivityInstance> OrionTransFlowActivityInstances { get; set; } // OrionTransFlowActivityInstances
        System.Data.Entity.DbSet<OrionTransFlowActivityUser> OrionTransFlowActivityUsers { get; set; } // OrionTransFlowActivityUsers
        System.Data.Entity.DbSet<OrionTransFlowInstance> OrionTransFlowInstances { get; set; } // OrionTransFlowInstances
        System.Data.Entity.DbSet<OrionWorkFlow> OrionWorkFlows { get; set; } // OrionWorkFlows
        System.Data.Entity.DbSet<OrionWorkFlowStep> OrionWorkFlowSteps { get; set; } // OrionWorkFlowSteps
        System.Data.Entity.DbSet<OrionWorkFlowStepUserRelation> OrionWorkFlowStepUserRelations { get; set; } // OrionWorkFlowStepUserRelations
        System.Data.Entity.DbSet<Page> Pages { get; set; } // Pages
        System.Data.Entity.DbSet<PagePermission> PagePermissions { get; set; } // PagePermissions
        System.Data.Entity.DbSet<PermissionView> PermissionViews { get; set; } // permissionViews
        System.Data.Entity.DbSet<PmsOrder> PmsOrders { get; set; } // PMSOrders
        System.Data.Entity.DbSet<PmsOrderTaskVmMetadata> PmsOrderTaskVmMetadatas { get; set; } // PMSOrderTaskVMMetadatas
        System.Data.Entity.DbSet<PmsTask> PmsTasks { get; set; } // PMSTasks
        System.Data.Entity.DbSet<ProjectListId> ProjectListIds { get; set; } // ProjectListIds
        System.Data.Entity.DbSet<ProjectTemplate> ProjectTemplates { get; set; } // ProjectTemplates
        System.Data.Entity.DbSet<ProjectTemplateItem> ProjectTemplateItems { get; set; } // ProjectTemplateItems
        System.Data.Entity.DbSet<RelationTableCheck> RelationTableChecks { get; set; } // relationTableChecks
        System.Data.Entity.DbSet<SecurityLog> SecurityLogs { get; set; } // SecurityLogs
        System.Data.Entity.DbSet<SmtpServer> SmtpServers { get; set; } // SMTPServers
        System.Data.Entity.DbSet<TeamAndUser> TeamAndUsers { get; set; } // TeamAndUsers
        System.Data.Entity.DbSet<TeamMember> TeamMembers { get; set; } // TeamMembers
        System.Data.Entity.DbSet<TemplateLanguageRelationShip> TemplateLanguageRelationShips { get; set; } // TemplateLanguageRelationShips
        System.Data.Entity.DbSet<TemplateMappingRule> TemplateMappingRules { get; set; } // TemplateMappingRules
        System.Data.Entity.DbSet<TmsConfiguration> TmsConfigurations { get; set; } // TMSConfigurations
        System.Data.Entity.DbSet<TmsProject> TmsProjects { get; set; } // TMSProjects
        System.Data.Entity.DbSet<TransactionLog> TransactionLogs { get; set; } // TransactionLogs
        System.Data.Entity.DbSet<User> Users { get; set; } // Users
        System.Data.Entity.DbSet<UserApproval> UserApprovals { get; set; } // UserApproval
        System.Data.Entity.DbSet<UserApprovalRole> UserApprovalRoles { get; set; } // UserApprovalRoles
        System.Data.Entity.DbSet<UserConfig> UserConfigs { get; set; } // UserConfigs
        System.Data.Entity.DbSet<UserCustomizedView> UserCustomizedViews { get; set; } // UserCustomizedViews
        System.Data.Entity.DbSet<UserGroup> UserGroups { get; set; } // UserGroups
        System.Data.Entity.DbSet<UserGroupEntity> UserGroupEntities { get; set; } // UserGroupEntities
        System.Data.Entity.DbSet<UserSkill> UserSkills { get; set; } // UserSkills
        System.Data.Entity.DbSet<UserSkillRelation> UserSkillRelations { get; set; } // UserSkillRelations
        System.Data.Entity.DbSet<UserTeam> UserTeams { get; set; } // UserTeams
        System.Data.Entity.DbSet<UserTeamRelation> UserTeamRelations { get; set; } // UserTeamRelations
        System.Data.Entity.DbSet<UserWorkType> UserWorkTypes { get; set; } // UserWorkTypes
        System.Data.Entity.DbSet<UserWorkTypeRelation> UserWorkTypeRelations { get; set; } // UserWorkTypeRelations
        System.Data.Entity.DbSet<ViewAdvanceFilter> ViewAdvanceFilters { get; set; } // View_AdvanceFilter
        System.Data.Entity.DbSet<ViewMetadataRelationShip> ViewMetadataRelationShips { get; set; } // ViewMetadataRelationShips
        System.Data.Entity.DbSet<ViewOrderWorkFlow> ViewOrderWorkFlows { get; set; } // View_OrderWorkFlow
        System.Data.Entity.DbSet<ViewWfStepList> ViewWfStepLists { get; set; } // View_WFStepList
        System.Data.Entity.DbSet<ViewWfStepListAll> ViewWfStepListAlls { get; set; } // View_WFStepList_All
        System.Data.Entity.DbSet<WfActivity> WfActivities { get; set; } // WFActivities
        System.Data.Entity.DbSet<WfCallbackLog> WfCallbackLogs { get; set; } // WFCallbackLog
        System.Data.Entity.DbSet<WfFlagConfig> WfFlagConfigs { get; set; } // WFFlagConfig
        System.Data.Entity.DbSet<WfFlagLog> WfFlagLogs { get; set; } // WFFlagLog
        System.Data.Entity.DbSet<WfFlowStep> WfFlowSteps { get; set; } // WFFlowSteps
        System.Data.Entity.DbSet<WfFlowStepLine> WfFlowStepLines { get; set; } // WFFlowStepLines
        System.Data.Entity.DbSet<WfFlowStepStandardField> WfFlowStepStandardFields { get; set; } // WFFlowStepStandardField
        System.Data.Entity.DbSet<WfFlowStepUserRelation> WfFlowStepUserRelations { get; set; } // WFFlowStepUserRelations
        System.Data.Entity.DbSet<WfFlowTemplate> WfFlowTemplates { get; set; } // WFFlowTemplates
        System.Data.Entity.DbSet<WfInstanceFlow> WfInstanceFlows { get; set; } // WFInstanceFlows
        System.Data.Entity.DbSet<WfInstanceFlowStep> WfInstanceFlowSteps { get; set; } // WFInstanceFlowSteps
        System.Data.Entity.DbSet<WfInstanceFlowStepLine> WfInstanceFlowStepLines { get; set; } // WFInstanceFlowStepLines
        System.Data.Entity.DbSet<WfInstanceFlowStepRun> WfInstanceFlowStepRuns { get; set; } // WFInstanceFlowStepRuns
        System.Data.Entity.DbSet<WfInstanceFlowStepRunField> WfInstanceFlowStepRunFields { get; set; } // WFInstanceFlowStepRunFields
        System.Data.Entity.DbSet<WfInstanceFlowStepUserRelation> WfInstanceFlowStepUserRelations { get; set; } // WFInstanceFlowStepUserRelations
        System.Data.Entity.DbSet<WfStepRunLog> WfStepRunLogs { get; set; } // WFStepRunLog
        System.Data.Entity.DbSet<Widget> Widgets { get; set; } // Widgets
        System.Data.Entity.DbSet<WwcCalculator> WwcCalculators { get; set; } // WWCCalculators

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }

}

