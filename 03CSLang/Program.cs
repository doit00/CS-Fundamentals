using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatch();

            DebugTrace();

        }

        private static void DebugTrace()
        {
            Debug.Assert(File.Exists("app.log"));

            TextWriterTraceListener consoleListener =
                new TextWriterTraceListener(Console.Out);
            Debug.Listeners.Add(consoleListener);



            TextWriterTraceListener fileListener =
                new TextWriterTraceListener("app.log");
            Debug.Listeners.Add(fileListener);



            Debug.WriteLine("app started at:{0}", DateTime.Now);
            Trace.WriteLine(
                String.Format("app started at:{0}", DateTime.Now)
                );

            fileListener.Flush();
        }

        private static void TryCatch()
        {
            try
            {
                int x = 2;
                int y = int.MaxValue;
                checked
                {
                    int z = y + 1;
                }
                //int z = x / y;

            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine(dex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }


            FileStream f = null;
            try
            {
                f = File.Open("nonExisting2.txt", FileMode.Open);
            }
            catch (FileNotFoundException fEx)
            {
                Console.WriteLine("File {0} not found", fEx.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (f != null)
                {
                    f.Dispose();
                }
            }
        }
    }
}
