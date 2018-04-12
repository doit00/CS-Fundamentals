using System;

namespace ToolsLibrary
{
    public class Context
    {
        public string User => Environment.UserName;
        public string Computer => Environment.MachineName;
        public DateTime Today => DateTime.Today;
    }
}
