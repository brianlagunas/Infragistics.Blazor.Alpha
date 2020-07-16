using IgBlazorSamples.Data.Business;
using System.Collections.Generic;

namespace IgBlazorSamples.Data.Services
{
    public class ChartItemService
    {
        public List<ChartItem> Months { get; set; }
        public List<ChartItem> Seasons { get; set; }
        public List<ChartItem> MarketShare { get; set; }

        public List<ChartItem> SparklineData { get; set; }

        public ChartItemService()
        {
            Months = new List<ChartItem>();
            foreach (var month in System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames)
            {
                if (!string.IsNullOrWhiteSpace(month))
                    Months.Add(new ChartItem() { Value = 1, Label = month });
            }

            Seasons = new List<ChartItem>();
            Seasons.Add(new ChartItem() { Value = 4, Label = "Winter" });
            Seasons.Add(new ChartItem() { Value = 4, Label = "Spring" });
            Seasons.Add(new ChartItem() { Value = 4, Label = "Summer" });
            Seasons.Add(new ChartItem() { Value = 4, Label = "Fall" });

            MarketShare = new List<ChartItem>();
            MarketShare.Add(new ChartItem() { Value = 30, Label = "Google" });
            MarketShare.Add(new ChartItem() { Value = 30, Label = "Apple" });
            MarketShare.Add(new ChartItem() { Value = 15, Label = "Microsoft" });
            MarketShare.Add(new ChartItem() { Value = 15, Label = "Samsung" });
            MarketShare.Add(new ChartItem() { Value = 10, Label = "Other" });

            SparklineData = new List<ChartItem>();
            SparklineData.Add(new ChartItem() { Label = "4", Value = 4 });
            SparklineData.Add(new ChartItem() { Label = "5", Value = 5 });
            SparklineData.Add(new ChartItem() { Label = "2", Value = 2 });
            SparklineData.Add(new ChartItem() { Label = "7", Value = 7 });
            SparklineData.Add(new ChartItem() { Label = "-1", Value = -1 });
            SparklineData.Add(new ChartItem() { Label = "3", Value = 3 });
            SparklineData.Add(new ChartItem() { Label = "-2", Value = -2 });
            SparklineData.Add(new ChartItem() { Label = "5", Value = 5 });
            SparklineData.Add(new ChartItem() { Label = "2", Value = 2 });
            SparklineData.Add(new ChartItem() { Label = "6", Value = 6 });
        }
    }
}
