namespace IgBlazorSamples.Data.Business
{
    public class SixDataValueItem
    {
        public string Label { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Value3 { get; set; }
        public double Value4 { get; set; }
        public double Value5 { get; set; }
        public double Value6 { get; set; }
        public SixDataValueItem(string label, double value1, double value2,
            double value3, double value4, double value5, double value6)
        {
            Label = label; Value1 = value1; Value2 = value2;
            Value3 = value3; Value4 = value4; Value5 = value5; Value6 = value6;
        }
    }
}
