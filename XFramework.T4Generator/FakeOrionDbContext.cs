

namespace XFramework.Models
{

    using System.Linq;

    
    public class FakeOrionDbContext : IOrionDbContext
    {
        public System.Data.Entity.DbSet<AdvanceFilter> AdvanceFilters { get; set; }
        public System.Data.Entity.DbSet<ApplicationTrackLog> ApplicationTrackLogs { get; set; }
        public System.Data.Entity.DbSet<Attachment> Attachments { get; set; }
        public System.Data.Entity.DbSet<ClientAccount> ClientAccounts { get; set; }
        public System.Data.Entity.DbSet<ColumnSetting> ColumnSettings { get; set; }
        public System.Data.Entity.DbSet<ConfigInfo> ConfigInfoes { get; set; }
        public System.Data.Entity.DbSet<Credential> Credentials { get; set; }
        public System.Data.Entity.DbSet<CustomerCompany> CustomerCompanies { get; set; }
        public System.Data.Entity.DbSet<CustomerTmsProjectRelation> CustomerTmsProjectRelations { get; set; }
        public System.Data.Entity.DbSet<Department> Departments { get; set; }
        public System.Data.Entity.DbSet<DictData> DictDatas { get; set; }
        public System.Data.Entity.DbSet<DictType> DictTypes { get; set; }
        public System.Data.Entity.DbSet<ExchangeLog> ExchangeLogs { get; set; }
        public System.Data.Entity.DbSet<Field> Fields { get; set; }
        public System.Data.Entity.DbSet<FieldPermission> FieldPermissions { get; set; }
        public System.Data.Entity.DbSet<FreewayOrder> FreewayOrders { get; set; }
        public System.Data.Entity.DbSet<Group> Groups { get; set; }
        public System.Data.Entity.DbSet<GroupWidgetRelation> GroupWidgetRelations { get; set; }
        public System.Data.Entity.DbSet<IntegrationCredential> IntegrationCredentials { get; set; }
        public System.Data.Entity.DbSet<LanguageVendor> LanguageVendors { get; set; }
        public System.Data.Entity.DbSet<LanguageVendorsRelation> LanguageVendorsRelations { get; set; }
        public System.Data.Entity.DbSet<MailTemplate> MailTemplates { get; set; }
        public System.Data.Entity.DbSet<Menu> Menus { get; set; }
        public System.Data.Entity.DbSet<Message> Messages { get; set; }
        public System.Data.Entity.DbSet<ModelMapping> ModelMappings { get; set; }
        public System.Data.Entity.DbSet<ModelMappingsStandard> ModelMappingsStandards { get; set; }
        public System.Data.Entity.DbSet<ModelView> ModelViews { get; set; }
        public System.Data.Entity.DbSet<OrderSample> OrderSamples { get; set; }
        public System.Data.Entity.DbSet<OrderTemplate> OrderTemplates { get; set; }
        public System.Data.Entity.DbSet<OrionFwLanguageMap> OrionFwLanguageMaps { get; set; }
        public System.Data.Entity.DbSet<OrionMessage> OrionMessages { get; set; }
        public System.Data.Entity.DbSet<OrionMessageConfiguration> OrionMessageConfigurations { get; set; }
        public System.Data.Entity.DbSet<OrionProjectFlowCurrentStatu> OrionProjectFlowCurrentStatus { get; set; }
        public System.Data.Entity.DbSet<OrionProjectFlowStatusRecord> OrionProjectFlowStatusRecords { get; set; }
        public System.Data.Entity.DbSet<OrionProjectStepUserRelation> OrionProjectStepUserRelations { get; set; }
        public System.Data.Entity.DbSet<OrionProjectWorkFlowStep> OrionProjectWorkFlowSteps { get; set; }
        public System.Data.Entity.DbSet<OrionProjectWorkFlowStepTask> OrionProjectWorkFlowStepTasks { get; set; }
        public System.Data.Entity.DbSet<OrionStep> OrionSteps { get; set; }
        public System.Data.Entity.DbSet<OrionStepFieldRelation> OrionStepFieldRelations { get; set; }
        public System.Data.Entity.DbSet<OrionTransActivity> OrionTransActivities { get; set; }
        public System.Data.Entity.DbSet<OrionTransFlow> OrionTransFlows { get; set; }
        public System.Data.Entity.DbSet<OrionTransFlowActivity> OrionTransFlowActivities { get; set; }
        public System.Data.Entity.DbSet<OrionTransFlowActivityInstance> OrionTransFlowActivityInstances { get; set; }
        public System.Data.Entity.DbSet<OrionTransFlowActivityUser> OrionTransFlowActivityUsers { get; set; }
        public System.Data.Entity.DbSet<OrionTransFlowInstance> OrionTransFlowInstances { get; set; }
        public System.Data.Entity.DbSet<OrionWorkFlow> OrionWorkFlows { get; set; }
        public System.Data.Entity.DbSet<OrionWorkFlowStep> OrionWorkFlowSteps { get; set; }
        public System.Data.Entity.DbSet<OrionWorkFlowStepUserRelation> OrionWorkFlowStepUserRelations { get; set; }
        public System.Data.Entity.DbSet<Page> Pages { get; set; }
        public System.Data.Entity.DbSet<PagePermission> PagePermissions { get; set; }
        public System.Data.Entity.DbSet<PermissionView> PermissionViews { get; set; }
        public System.Data.Entity.DbSet<PmsOrder> PmsOrders { get; set; }
        public System.Data.Entity.DbSet<PmsOrderTaskVmMetadata> PmsOrderTaskVmMetadatas { get; set; }
        public System.Data.Entity.DbSet<PmsTask> PmsTasks { get; set; }
        public System.Data.Entity.DbSet<ProjectListId> ProjectListIds { get; set; }
        public System.Data.Entity.DbSet<ProjectTemplate> ProjectTemplates { get; set; }
        public System.Data.Entity.DbSet<ProjectTemplateItem> ProjectTemplateItems { get; set; }
        public System.Data.Entity.DbSet<RelationTableCheck> RelationTableChecks { get; set; }
        public System.Data.Entity.DbSet<SecurityLog> SecurityLogs { get; set; }
        public System.Data.Entity.DbSet<SmtpServer> SmtpServers { get; set; }
        public System.Data.Entity.DbSet<TeamAndUser> TeamAndUsers { get; set; }
        public System.Data.Entity.DbSet<TeamMember> TeamMembers { get; set; }
        public System.Data.Entity.DbSet<TemplateLanguageRelationShip> TemplateLanguageRelationShips { get; set; }
        public System.Data.Entity.DbSet<TemplateMappingRule> TemplateMappingRules { get; set; }
        public System.Data.Entity.DbSet<TmsConfiguration> TmsConfigurations { get; set; }
        public System.Data.Entity.DbSet<TmsProject> TmsProjects { get; set; }
        public System.Data.Entity.DbSet<TransactionLog> TransactionLogs { get; set; }
        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<UserApproval> UserApprovals { get; set; }
        public System.Data.Entity.DbSet<UserApprovalRole> UserApprovalRoles { get; set; }
        public System.Data.Entity.DbSet<UserConfig> UserConfigs { get; set; }
        public System.Data.Entity.DbSet<UserCustomizedView> UserCustomizedViews { get; set; }
        public System.Data.Entity.DbSet<UserGroup> UserGroups { get; set; }
        public System.Data.Entity.DbSet<UserGroupEntity> UserGroupEntities { get; set; }
        public System.Data.Entity.DbSet<UserSkill> UserSkills { get; set; }
        public System.Data.Entity.DbSet<UserSkillRelation> UserSkillRelations { get; set; }
        public System.Data.Entity.DbSet<UserTeam> UserTeams { get; set; }
        public System.Data.Entity.DbSet<UserTeamRelation> UserTeamRelations { get; set; }
        public System.Data.Entity.DbSet<UserWorkType> UserWorkTypes { get; set; }
        public System.Data.Entity.DbSet<UserWorkTypeRelation> UserWorkTypeRelations { get; set; }
        public System.Data.Entity.DbSet<ViewAdvanceFilter> ViewAdvanceFilters { get; set; }
        public System.Data.Entity.DbSet<ViewMetadataRelationShip> ViewMetadataRelationShips { get; set; }
        public System.Data.Entity.DbSet<ViewOrderWorkFlow> ViewOrderWorkFlows { get; set; }
        public System.Data.Entity.DbSet<ViewWfStepList> ViewWfStepLists { get; set; }
        public System.Data.Entity.DbSet<ViewWfStepListAll> ViewWfStepListAlls { get; set; }
        public System.Data.Entity.DbSet<WfActivity> WfActivities { get; set; }
        public System.Data.Entity.DbSet<WfCallbackLog> WfCallbackLogs { get; set; }
        public System.Data.Entity.DbSet<WfFlagConfig> WfFlagConfigs { get; set; }
        public System.Data.Entity.DbSet<WfFlagLog> WfFlagLogs { get; set; }
        public System.Data.Entity.DbSet<WfFlowStep> WfFlowSteps { get; set; }
        public System.Data.Entity.DbSet<WfFlowStepLine> WfFlowStepLines { get; set; }
        public System.Data.Entity.DbSet<WfFlowStepStandardField> WfFlowStepStandardFields { get; set; }
        public System.Data.Entity.DbSet<WfFlowStepUserRelation> WfFlowStepUserRelations { get; set; }
        public System.Data.Entity.DbSet<WfFlowTemplate> WfFlowTemplates { get; set; }
        public System.Data.Entity.DbSet<WfInstanceFlow> WfInstanceFlows { get; set; }
        public System.Data.Entity.DbSet<WfInstanceFlowStep> WfInstanceFlowSteps { get; set; }
        public System.Data.Entity.DbSet<WfInstanceFlowStepLine> WfInstanceFlowStepLines { get; set; }
        public System.Data.Entity.DbSet<WfInstanceFlowStepRun> WfInstanceFlowStepRuns { get; set; }
        public System.Data.Entity.DbSet<WfInstanceFlowStepRunField> WfInstanceFlowStepRunFields { get; set; }
        public System.Data.Entity.DbSet<WfInstanceFlowStepUserRelation> WfInstanceFlowStepUserRelations { get; set; }
        public System.Data.Entity.DbSet<WfStepRunLog> WfStepRunLogs { get; set; }
        public System.Data.Entity.DbSet<Widget> Widgets { get; set; }
        public System.Data.Entity.DbSet<WwcCalculator> WwcCalculators { get; set; }

        public FakeOrionDbContext()
        {
            AdvanceFilters = new FakeDbSet<AdvanceFilter>("Id");
            ApplicationTrackLogs = new FakeDbSet<ApplicationTrackLog>("Id");
            Attachments = new FakeDbSet<Attachment>("Id");
            ClientAccounts = new FakeDbSet<ClientAccount>("Id");
            ColumnSettings = new FakeDbSet<ColumnSetting>("Id");
            ConfigInfoes = new FakeDbSet<ConfigInfo>("Id");
            Credentials = new FakeDbSet<Credential>("Id");
            CustomerCompanies = new FakeDbSet<CustomerCompany>("Id");
            CustomerTmsProjectRelations = new FakeDbSet<CustomerTmsProjectRelation>("Id");
            Departments = new FakeDbSet<Department>("Id");
            DictDatas = new FakeDbSet<DictData>("Id");
            DictTypes = new FakeDbSet<DictType>("Id");
            ExchangeLogs = new FakeDbSet<ExchangeLog>("Id");
            Fields = new FakeDbSet<Field>("Id");
            FieldPermissions = new FakeDbSet<FieldPermission>("Id");
            FreewayOrders = new FakeDbSet<FreewayOrder>("Id");
            Groups = new FakeDbSet<Group>("Id");
            GroupWidgetRelations = new FakeDbSet<GroupWidgetRelation>("Id");
            IntegrationCredentials = new FakeDbSet<IntegrationCredential>("Id");
            LanguageVendors = new FakeDbSet<LanguageVendor>("Id");
            LanguageVendorsRelations = new FakeDbSet<LanguageVendorsRelation>("Id");
            MailTemplates = new FakeDbSet<MailTemplate>("Id");
            Menus = new FakeDbSet<Menu>("Id");
            Messages = new FakeDbSet<Message>("Id");
            ModelMappings = new FakeDbSet<ModelMapping>("Id");
            ModelMappingsStandards = new FakeDbSet<ModelMappingsStandard>("Id", "ClientId", "IsRequired", "IsExtended", "FieldLevel", "IsDeleted", "ModelId", "FieldProperty", "SortNum", "EnableForTemplate", "ControlType", "IsReadOnly", "EnableForColumnSetting");
            ModelViews = new FakeDbSet<ModelView>("Id");
            OrderSamples = new FakeDbSet<OrderSample>("Id");
            OrderTemplates = new FakeDbSet<OrderTemplate>("Id");
            OrionFwLanguageMaps = new FakeDbSet<OrionFwLanguageMap>("Id");
            OrionMessages = new FakeDbSet<OrionMessage>("Id");
            OrionMessageConfigurations = new FakeDbSet<OrionMessageConfiguration>("Id");
            OrionProjectFlowCurrentStatus = new FakeDbSet<OrionProjectFlowCurrentStatu>("Id");
            OrionProjectFlowStatusRecords = new FakeDbSet<OrionProjectFlowStatusRecord>("Id");
            OrionProjectStepUserRelations = new FakeDbSet<OrionProjectStepUserRelation>("Id");
            OrionProjectWorkFlowSteps = new FakeDbSet<OrionProjectWorkFlowStep>("Id");
            OrionProjectWorkFlowStepTasks = new FakeDbSet<OrionProjectWorkFlowStepTask>("Id");
            OrionSteps = new FakeDbSet<OrionStep>("Id");
            OrionStepFieldRelations = new FakeDbSet<OrionStepFieldRelation>("Id");
            OrionTransActivities = new FakeDbSet<OrionTransActivity>("Id");
            OrionTransFlows = new FakeDbSet<OrionTransFlow>("Id");
            OrionTransFlowActivities = new FakeDbSet<OrionTransFlowActivity>("Id");
            OrionTransFlowActivityInstances = new FakeDbSet<OrionTransFlowActivityInstance>("Id");
            OrionTransFlowActivityUsers = new FakeDbSet<OrionTransFlowActivityUser>("Id");
            OrionTransFlowInstances = new FakeDbSet<OrionTransFlowInstance>("Id");
            OrionWorkFlows = new FakeDbSet<OrionWorkFlow>("Id");
            OrionWorkFlowSteps = new FakeDbSet<OrionWorkFlowStep>("Id");
            OrionWorkFlowStepUserRelations = new FakeDbSet<OrionWorkFlowStepUserRelation>("Id");
            Pages = new FakeDbSet<Page>("Id");
            PagePermissions = new FakeDbSet<PagePermission>("Id");
            PermissionViews = new FakeDbSet<PermissionView>("CustomerId", "ProgramId", "RoleId", "UserId", "PageId");
            PmsOrders = new FakeDbSet<PmsOrder>("Id");
            PmsOrderTaskVmMetadatas = new FakeDbSet<PmsOrderTaskVmMetadata>("Id");
            PmsTasks = new FakeDbSet<PmsTask>("Id");
            ProjectListIds = new FakeDbSet<ProjectListId>("Id");
            ProjectTemplates = new FakeDbSet<ProjectTemplate>("Id");
            ProjectTemplateItems = new FakeDbSet<ProjectTemplateItem>("Id");
            RelationTableChecks = new FakeDbSet<RelationTableCheck>("Id");
            SecurityLogs = new FakeDbSet<SecurityLog>("Id");
            SmtpServers = new FakeDbSet<SmtpServer>("Id");
            TeamAndUsers = new FakeDbSet<TeamAndUser>("Id", "UserName", "Type");
            TeamMembers = new FakeDbSet<TeamMember>("UserId", "Pmid", "ProjectName");
            TemplateLanguageRelationShips = new FakeDbSet<TemplateLanguageRelationShip>("Id");
            TemplateMappingRules = new FakeDbSet<TemplateMappingRule>("Id");
            TmsConfigurations = new FakeDbSet<TmsConfiguration>("Id");
            TmsProjects = new FakeDbSet<TmsProject>("Id");
            TransactionLogs = new FakeDbSet<TransactionLog>("Id");
            Users = new FakeDbSet<User>("Id");
            UserApprovals = new FakeDbSet<UserApproval>("Id");
            UserApprovalRoles = new FakeDbSet<UserApprovalRole>("Id");
            UserConfigs = new FakeDbSet<UserConfig>("Id");
            UserCustomizedViews = new FakeDbSet<UserCustomizedView>("Id");
            UserGroups = new FakeDbSet<UserGroup>("Id");
            UserGroupEntities = new FakeDbSet<UserGroupEntity>("Id");
            UserSkills = new FakeDbSet<UserSkill>("Id");
            UserSkillRelations = new FakeDbSet<UserSkillRelation>("Id");
            UserTeams = new FakeDbSet<UserTeam>("Id");
            UserTeamRelations = new FakeDbSet<UserTeamRelation>("Id");
            UserWorkTypes = new FakeDbSet<UserWorkType>("Id");
            UserWorkTypeRelations = new FakeDbSet<UserWorkTypeRelation>("Id");
            ViewAdvanceFilters = new FakeDbSet<ViewAdvanceFilter>("Id", "OrderName", "ProdStatus", "HoDate", "HbDate", "CreatedDateTime", "CreatedBy", "Expr15", "IsTemplate", "Discriminator", "IsShowTaskList", "SourceLanguage", "StepRunStatus", "FlowFlag", "Flowflagorder", "StepFlag", "StepFlagOrder", "Percentage");
            ViewMetadataRelationShips = new FakeDbSet<ViewMetadataRelationShip>("Id");
            ViewOrderWorkFlows = new FakeDbSet<ViewOrderWorkFlow>("Status", "WorkFlowId", "OrderId", "HbDate", "HoDate");
            ViewWfStepLists = new FakeDbSet<ViewWfStepList>("Id", "OrderName", "ProdStatus", "HoDate", "HbDate", "CreatedDateTime", "CreatedBy", "Expr15", "IsTemplate", "Discriminator", "IsShowTaskList", "SourceLanguage", "OrderProjectStatus", "FlowId", "ProjectStatus", "ProcessObject", "AccountId", "WorkFlowType", "FlowStatus", "IsDeleted", "FlowObjectId", "StepId", "WfInstanceFlowId", "WfActivityId", "RunId", "StepFlag", "StepFlagOrder");
            ViewWfStepListAlls = new FakeDbSet<ViewWfStepListAll>("Id", "OrderName", "ProdStatus", "HoDate", "HbDate", "CreatedDateTime", "CreatedBy", "Expr15", "IsTemplate", "Discriminator", "IsShowTaskList", "SourceLanguage", "OrderProjectStatus", "FlowId", "ProjectStatus", "ProcessObject", "AccountId", "WorkFlowType", "FlowStatus", "IsDeleted", "FlowObjectId", "StepId", "WfInstanceFlowId", "WfActivityId", "RunId", "StepFlag", "StepFlagOrder");
            WfActivities = new FakeDbSet<WfActivity>("Id");
            WfCallbackLogs = new FakeDbSet<WfCallbackLog>("Id");
            WfFlagConfigs = new FakeDbSet<WfFlagConfig>("Id");
            WfFlagLogs = new FakeDbSet<WfFlagLog>("Id");
            WfFlowSteps = new FakeDbSet<WfFlowStep>("Id");
            WfFlowStepLines = new FakeDbSet<WfFlowStepLine>("Id");
            WfFlowStepStandardFields = new FakeDbSet<WfFlowStepStandardField>("Id");
            WfFlowStepUserRelations = new FakeDbSet<WfFlowStepUserRelation>("Id");
            WfFlowTemplates = new FakeDbSet<WfFlowTemplate>("Id");
            WfInstanceFlows = new FakeDbSet<WfInstanceFlow>("Id");
            WfInstanceFlowSteps = new FakeDbSet<WfInstanceFlowStep>("Id");
            WfInstanceFlowStepLines = new FakeDbSet<WfInstanceFlowStepLine>("Id");
            WfInstanceFlowStepRuns = new FakeDbSet<WfInstanceFlowStepRun>("Id");
            WfInstanceFlowStepRunFields = new FakeDbSet<WfInstanceFlowStepRunField>("Id");
            WfInstanceFlowStepUserRelations = new FakeDbSet<WfInstanceFlowStepUserRelation>("Id");
            WfStepRunLogs = new FakeDbSet<WfStepRunLog>("Id");
            Widgets = new FakeDbSet<Widget>("Id");
            WwcCalculators = new FakeDbSet<WwcCalculator>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}

