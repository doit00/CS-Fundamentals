using System;
using System.Collections.Generic;

namespace NBPRatesLibrary
{
    public class NBPRates
    {
        public List<string> GetRatesTableLine()
        {
            List<string> lines = new List<string>();
            RatesDataSource dataSource = new RatesDataSource();
            try
            {
                lines = dataSource.RatesLines.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return lines;

        }
        
    }




}
