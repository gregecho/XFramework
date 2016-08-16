

namespace XFramework.Models
{

    // Users
    
    public class User
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// UserGroupEntityId
        ///</summary>
        public int UserGroupEntityId { get; set; }

        ///<summary>
        /// UserName (length: 128)
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        /// FirstName (length: 128)
        ///</summary>
        public string FirstName { get; set; }

        ///<summary>
        /// LastName (length: 128)
        ///</summary>
        public string LastName { get; set; }

        ///<summary>
        /// Email (length: 256)
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        /// IsEnabled
        ///</summary>
        public bool IsEnabled { get; set; }

        ///<summary>
        /// Password (length: 128)
        ///</summary>
        public string Password { get; set; }

        ///<summary>
        /// TryCount
        ///</summary>
        public int TryCount { get; set; }

        ///<summary>
        /// Question
        ///</summary>
        public int? Question { get; set; }

        ///<summary>
        /// Answer (length: 128)
        ///</summary>
        public string Answer { get; set; }

        ///<summary>
        /// LastLoginDate
        ///</summary>
        public System.DateTime? LastLoginDate { get; set; }

        ///<summary>
        /// CreatedDate
        ///</summary>
        public System.DateTime CreatedDate { get; set; }

        ///<summary>
        /// PrimaryPhone (length: 32)
        ///</summary>
        public string PrimaryPhone { get; set; }

        ///<summary>
        /// AltPhone (length: 32)
        ///</summary>
        public string AltPhone { get; set; }

        ///<summary>
        /// DepartmentId
        ///</summary>
        public int? DepartmentId { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<OrionMessageConfiguration> OrionMessageConfigurations { get; set; } // OrionMessageConfigurations.FK_dbo.OrionMessageConfigurations_dbo.Users_UserId
        public virtual System.Collections.Generic.ICollection<OrionProjectStepUserRelation> OrionProjectStepUserRelations { get; set; } // OrionProjectStepUserRelations.FK_dbo.OrionProjectStepUserRelations_dbo.Users_UserId
        public virtual System.Collections.Generic.ICollection<OrionTransFlowActivityUser> OrionTransFlowActivityUsers { get; set; } // OrionTransFlowActivityUsers.FK_dbo.OrionTransFlowActivityUsers_dbo.Users_UserId
        public virtual System.Collections.Generic.ICollection<OrionWorkFlowStepUserRelation> OrionWorkFlowStepUserRelations { get; set; } // OrionWorkFlowStepUserRelations.FK_dbo.OrionWorkFlowStepUserRelations_dbo.Users_UserId
        public virtual System.Collections.Generic.ICollection<UserSkillRelation> UserSkillRelations { get; set; } // UserSkillRelations.FK_Users_UserSkillRelations
        public virtual System.Collections.Generic.ICollection<UserTeamRelation> UserTeamRelations { get; set; } // UserTeamRelations.FK_UserTeamRelations_Users
        public virtual System.Collections.Generic.ICollection<UserWorkTypeRelation> UserWorkTypeRelations { get; set; } // UserWorkTypeRelations.FK_UserWorkTypeRelations_Users
        public virtual System.Collections.Generic.ICollection<WfFlowStepUserRelation> WfFlowStepUserRelations { get; set; } // WFFlowStepUserRelations.FK_dbo_WFFlowStepUserRelations_dbo_Users_UserId
        public virtual System.Collections.Generic.ICollection<WfInstanceFlowStepUserRelation> WfInstanceFlowStepUserRelations { get; set; } // WFInstanceFlowStepUserRelations.FK_WFInstanceFlowStepUserRelations_Users
        public virtual System.Collections.Generic.ICollection<WfStepRunLog> WfStepRunLogs { get; set; } // WFStepRunLog.FK_WFStepRunLog_Users
        public virtual System.Collections.Generic.ICollection<Widget> Widgets { get; set; } // Widgets.FK_dbo.Widgets_dbo.Users_UserId

        // Foreign keys
        public virtual Department Department { get; set; } // FK_dbo.Users_dbo.Departments_DepartmentId
        public virtual UserGroupEntity UserGroupEntity { get; set; } // FK_dbo.Users_dbo.UserGroupEntities_UserGroupEntityId

        public User()
        {
            OrionMessageConfigurations = new System.Collections.Generic.List<OrionMessageConfiguration>();
            OrionProjectStepUserRelations = new System.Collections.Generic.List<OrionProjectStepUserRelation>();
            OrionTransFlowActivityUsers = new System.Collections.Generic.List<OrionTransFlowActivityUser>();
            OrionWorkFlowStepUserRelations = new System.Collections.Generic.List<OrionWorkFlowStepUserRelation>();
            UserSkillRelations = new System.Collections.Generic.List<UserSkillRelation>();
            UserTeamRelations = new System.Collections.Generic.List<UserTeamRelation>();
            UserWorkTypeRelations = new System.Collections.Generic.List<UserWorkTypeRelation>();
            WfFlowStepUserRelations = new System.Collections.Generic.List<WfFlowStepUserRelation>();
            WfInstanceFlowStepUserRelations = new System.Collections.Generic.List<WfInstanceFlowStepUserRelation>();
            WfStepRunLogs = new System.Collections.Generic.List<WfStepRunLog>();
            Widgets = new System.Collections.Generic.List<Widget>();
        }
    }

}

