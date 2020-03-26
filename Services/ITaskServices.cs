using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services
{
    public interface ITaskServices
    {
        List<TaskItem> AddTaskItem(TaskItem item);
        List<TaskItem> GetTaskItems();
    }
}
