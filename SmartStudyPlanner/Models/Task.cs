using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStudyPlanner.Core.Models
{
    public enum PriorityLevel { Low, Medium, High }
    public enum TaskStatus { Pending, Completed }

    internal class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public DateTime DueDate { get; set; }
        public PriorityLevel Priority { get; set; }
        public TaskStatus Status { get; set; }

        public void MarkComplete() => Status = TaskStatus.Completed;

        public bool IsOverdue(DateTime now) => DueDate < now && Status == TaskStatus.Pending;

        public int DaysRemaining(DateTime now) => (DueDate - now).Days;
    }
}
