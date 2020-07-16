namespace IgBlazorSamples.Data.Business
{
    public class SingleDataValueItem
    {
        public string Label { get; set; }
        public double Value { get; set; }
        public SingleDataValueItem(string label, double value)
        {
            Label = label; Value = value;
        }

    }
}
