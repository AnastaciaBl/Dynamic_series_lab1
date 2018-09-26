using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_series_lab1
{
    public class DynamicSeries
    {
        public List<string> Index { get; private set; }
        public List<double> Value { get; private set; }
        public double K_statistic_difSigns { get; private set; }
        public int AmountOfElements { get; }
        public const double U = 1.96;

        public DynamicSeries()
        {
            Index = new List<string>();
            Value = new List<double>();
        }

        public DynamicSeries(string fields, List<string> data):this()
        {
            FillData(data);
            AmountOfElements = Value.Count;
        }

        private void FillData(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var temp = data[i].Split(',');
                try
                {
                    temp[1] = temp[1].Replace('.', ',');
                    Value.Add(Convert.ToDouble(temp[1]));
                    Index.Add(temp[0]);
                }
                catch
                { }
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
            K_statistic_difSigns = (amountOfGrowthPoint - M) / Math.Sqrt(D);
            if (Math.Abs(K_statistic_difSigns) <= U)
                return 0; //ряд случайный
            else if (K_statistic_difSigns < -1 * U)
                return -1; //тенденция к спаданию
            else return 1; //тенденция к возрастанию
        }

        public void CriterionOfRecordValues()
        {
            List<double> maximums, minimums;
            FindRecordValues(out maximums, out minimums);
            int L = minimums.Count;
            int M = maximums.Count;
            int D = M - L; //first criterian Foster-Stuart
            int S = M + L; //second criterian Foster-Stuart

            if(D == 0) //основная гипотеза для первой пары правильная
            {
                double M2 = 0, D2 = 0;
                for (int i = 1; i < AmountOfElements; i++)
                {
                    M2 += 2 / i;
                    D2 += 2 / i - 4 / (i * i);
                }
                //double T1 = (D-
            }
        }

        public void FindRecordValues(out List<double> maximums, out List<double> minimums)
        {
            maximums = new List<double>();
            minimums = new List<double>();
            double max = Value[0];
            double min = Value[0];
            for(int i=1;i<Value.Count;i++)
            {
                if (Value[i] < min)
                {
                    minimums.Add(Value[i]);
                    min = Value[i];
                }
                if (Value[i] > max)
                {
                    maximums.Add(Value[i]);
                    max = Value[i];
                }
            }
        }
    }
}
