

namespace XFramework.Models
{

    // Departments
    
    public class Department
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 128)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// ParentId
        ///</summary>
        public int ParentId { get; set; }

        ///<summary>
        /// Description (length: 1024)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// IsDeleted
        ///</summary>
        public bool IsDeleted { get; set; }

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<User> Users { get; set; } // Users.FK_dbo.Users_dbo.Departments_DepartmentId

        public Department()
        {
            Users = new System.Collections.Generic.List<User>();
        }
    }

}

