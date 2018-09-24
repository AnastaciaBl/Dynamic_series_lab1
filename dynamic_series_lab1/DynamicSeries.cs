using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_series_lab1
{
    public class DynamicSeries
    {
        public string[] Index { get; private set; }
        public double?[] Value { get; private set; }
        public int AmountOfElements { get; }
        private const double u = 1.96;

        public DynamicSeries() { }
        public DynamicSeries(string fields, List<string> data)
        {
            Index = new string[data.Count];
            Value = new double?[data.Count];
            AmountOfElements = data.Count;
            FillDataArray(data);
        }

        private void FillDataArray(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var temp = data[i].Split(',');
                Index[i] = temp[0];
                try
                {
                    temp[1] = temp[1].Replace('.', ',');
                    Value[i] = Convert.ToDouble(temp[1]);
                }
                catch
                {
                    Value[i] = null;
                }
            }
        }

        public int CriterionOfDifferenceSigns()
        {
            //find indicators
            int[] indicators = new int[AmountOfElements - 1];
            int amountOfGrowthPoint = 0;
            for(int i=0;i<indicators.Length;i++)
            {
                if (Value[i] < Value[i + 1])
                    indicators[i] = 1;
                else
                    indicators[i] = 0;
                amountOfGrowthPoint += indicators[i];
            }
            double M = (AmountOfElements - 1) / 2;
            double D = (AmountOfElements + 1) / 12;
            double K = (amountOfGrowthPoint - M) / Math.Sqrt(D);
            if (Math.Abs(K) <= u)
                return 0; //ряд случайный
            else if (K < -1 * u)
                return -1; //тенденция к спаданию
            else return 1; //тенденция к возрастанию
        }
    }
}
