using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace NBPRatesLibrary
{
    public class RatesDataSource
    {
        private readonly string tableUrl = "http://www.nbp.pl/kursy/Archiwum/archiwum_tab_a_2018.csv";
        private string FileName => Path.GetFileName(tableUrl);
        private bool FileExists => File.Exists(FileName);
        private bool IsCurrent => (DateTime.Now - File.GetCreationTime(FileName)).Days == 0;

        public Lazy<List<string>> RatesLines { get
            {
                return new Lazy<List<String>>(() => {
                    if (!FileExists || !IsCurrent)
                    {
                        WebClient cli = new WebClient();
                        cli.DownloadFile(tableUrl, FileName);
                    }
                    var lines = File.ReadAllLines(FileName).ToList();
                    return lines;
                });
            } }


    }




}
