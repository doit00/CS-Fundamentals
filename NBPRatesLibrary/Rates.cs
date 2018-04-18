using System;

namespace NBPRatesLibrary
{
    public class Rates
    {
        public DateTime GetPreviousWorkingDay(DateTime transactionDate)
        {
            throw new NotImplementedException();
        }
        public int Count
        {
            get
            {
                NBPRates ratesData = new NBPRates();
                return ratesData.GetRatesTableLine().Count;
            }
        }
    }
    
}
