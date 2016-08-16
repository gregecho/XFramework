using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFramework.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public TodoStatus Status { get; set; }
        public virtual User User { get; set; }
    }
}
