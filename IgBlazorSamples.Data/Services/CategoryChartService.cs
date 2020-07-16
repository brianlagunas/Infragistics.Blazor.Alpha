using IgBlazorSamples.Data.Business;
using System;
using System.Collections.Generic;

namespace IgBlazorSamples.Data.Services
{
    public class CategoryChartService
    {
        public List<SixDataValueItem> SmallSixDataPtCollection { get; private set; }
        public List<SixDataValueItem> LargeSixDataPtCollection { get; private set; }
        public List<List<SingleDataValueItem>> CompoundCollection { get; private set; }

        public CategoryChartService()
        {
            CreateDataCollections();
        }

        private void CreateDataCollections()
        {
            Random random = new Random();
            int year = 2014;
            int month = 10;
            SmallSixDataPtCollection = new List<SixDataValueItem>();
            LargeSixDataPtCollection = new List<SixDataValueItem>();

            CompoundCollection = new List<List<SingleDataValueItem>>();

            for (int i = 0; i < 40; i++)
            {
                string label = GetLabel(ref year, ref month);
                LargeSixDataPtCollection.Add(
                           new SixDataValueItem(label, random.Next(0, 20), random.Next(10, 30),
                            random.Next(20, 40), random.Next(30, 50), random.Next(40, 60), random.Next(0, 50)));

            }
            year = 2015;
            month = 10;
            for (int i = 0; i < 15; i++)
            {
                string label = GetLabel(ref year, ref month);
                SmallSixDataPtCollection.Add(new SixDataValueItem(label, random.Next(0, 20), random.Next(10, 30),
                        random.Next(20, 40), random.Next(30, 50), random.Next(40, 60), random.Next(0, 50)));

            }

            CompoundCollection = new List<List<SingleDataValueItem>>();
            var collection = new List<SingleDataValueItem>();
            year = 2014;
            month = 10;
            for (int i = 0; i < 40; i++)
            {
                string label = GetLabel(ref year, ref month);
                collection.Add(new SingleDataValueItem(label, random.Next(0, 50)));

            }
            CompoundCollection.Add(collection);
            year = 2013;
            month = 12;
            collection = new List<SingleDataValueItem>();
            for (int i = 0; i < 20; i++)
            {
                string label = GetLabel(ref year, ref month);
                collection.Add(new SingleDataValueItem(label, random.Next(0, 50)));

            }
            CompoundCollection.Add(collection);
            year = 2013;
            month = 12;
            collection = new List<SingleDataValueItem>();
            for (int i = 0; i < 35; i++)
            {
                string label = GetLabel(ref year, ref month);
                collection.Add(new SingleDataValueItem(label, random.Next(0, 50)));

            }
            CompoundCollection.Add(collection);
        }

        private string GetLabel(ref int year, ref int month)
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
                month++;
            string label = String.Format("{0}{1:00}", year, month);
            return label;
        }
    }
}
