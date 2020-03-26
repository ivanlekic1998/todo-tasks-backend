using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Models
{
    public class TaskItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Boolean Status { get; set; }
    }
}
