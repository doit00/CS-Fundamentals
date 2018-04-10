using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class Context
    {
        public string User => Environment.UserName;
        public string Computer => Environment.MachineName;
        public DateTime Today => DateTime.Today;
    }
}
