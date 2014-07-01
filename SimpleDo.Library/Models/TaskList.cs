using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDo.Library.Models
{
    public class User : IdentityUser
    {
        public ICollection<TaskList> TaskLists { get; set; }
    }

    public class TaskList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }

    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }
        public DateTime? DueDate { get; set; }
        public TaskPriority Priority { get; set; }
    }

    public enum TaskPriority
    {
        None,
        Low,
        Medium,
        High
    }

    public class TaskNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class TaskFiles
    {
        public int Id { get; set; }
        public string Filename { get; set; }
    }
}
