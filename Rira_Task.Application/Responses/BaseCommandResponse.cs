using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rira_Task.Application.Responses
{
    public class BaseCommandResponse
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
