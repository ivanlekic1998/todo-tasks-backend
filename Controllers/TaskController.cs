using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Services;

namespace TaskApi.Controllers
{
    [Route("api/v1/tasks")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskServices _services;

        public TaskController(ITaskServices services)
        {
            _services = services;
        }

        [HttpPost]
        public ActionResult<List<TaskItem>> AddTaskItems(TaskItem item)
        {
            return _services.AddTaskItem(item);
        }
        
        public ActionResult<List<TaskItem>> GetTaskItems()
        {
            return _services.GetTaskItems();
        }
    }
}