using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            MainConfigFile cf1 = MainConfigFile.Get();
            MainConfigFile cf2 = MainConfigFile.Get();
        }
    }

    class MainConfigFile
    {
        static readonly MainConfigFile mainConfig = new MainConfigFile();
        private MainConfigFile()
        {
        }
        public static MainConfigFile Get()
        {

            return mainConfig;
        }


    }

}
