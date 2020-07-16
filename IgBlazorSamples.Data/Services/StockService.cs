using IgBlazorSamples.Data.Business;
using System;
using System.Collections.Generic;

namespace IgBlazorSamples.Data.Services
{
    public class StockService
    {
        public List<StockList> StockMultipleSources { get; set; }

        public StockService()
        {
            var includeWeekends = true;
            var interval = TimeSpan.FromDays(1);
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2022, 7, 1);
            var stock1 = new StockList(start, end, "TSLA", interval, 300, 30000, includeWeekends);
            var stock2 = new StockList(start, end, "MSFT", interval, 200, 20000, includeWeekends);

            StockMultipleSources = new List<StockList>();
            StockMultipleSources.Add(stock1);
            StockMultipleSources.Add(stock2);
        }
    }
}
