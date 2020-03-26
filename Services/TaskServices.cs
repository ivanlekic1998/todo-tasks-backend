using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services
{
    public class TaskServices : ITaskServices
    {
        private readonly List<TaskItem> _taskItems;

        public TaskServices()
        {
            _taskItems = new List<TaskItem>();
        }

        public List<TaskItem> AddTaskItem(TaskItem item)
        {
            _taskItems.Add(item);
            return _taskItems;
        }

        public List<TaskItem> GetTaskItems()
        {
            return _taskItems;
        }
    }
}
