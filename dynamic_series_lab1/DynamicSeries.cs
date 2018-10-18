﻿using System;
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
        public List<double> Correlation { get; private set; }
        public List<bool> CorCoefSignificance { get; private set; }
        public double K_statistic_difSigns { get; private set; }
        public double T1_statistic { get; private set; }
        public double T2_statistic { get; private set; }
        public int AmountOfElements { get; }
        public bool IsCoefCorrSignificant { get; private set; }
        public const double U = 1.96;

        public DynamicSeries()
        {
            Index = new List<string>();
            Value = new List<double>();
            Correlation = new List<double>();
            CorCoefSignificance = new List<bool>();
            IsCoefCorrSignificant = true;
        }

        public DynamicSeries(string fields, List<string> data):this()
        {
            FillData(data);
            AmountOfElements = Value.Count;
            CountCorreletionInSeries();
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

        public void CriterionOfDifferenceSigns()
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
        }

        public void CriterionOfRecordValues()
        {
            List<double> maximums, minimums;
            FindRecordValues(out maximums, out minimums);
            int L = minimums.Count;
            int M = maximums.Count;
            int D = M - L; //first criterian Foster-Stuart
            int S = M + L; //second criterian Foster-Stuart

            //if(D == 0) //основная гипотеза для первой пары правильная
            //{
                double MD = 0, DD = 0;
                double MS = 0, DS = 0;
                for (int i = 1; i < AmountOfElements; i++)
                {
                    DD += 2.0 / i;
                    DS += 2.0 / i - 4.0 / (i * i);
                }
                MS = DD;
                T1_statistic = (D - MD) / Math.Sqrt(DD);
                T2_statistic = (S - MS) / Math.Sqrt(DS);
            //}
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

        public int CompareWithNormalQuantile(double statistic)
        {
            if (Math.Abs(statistic) <= U)
                return 0; //ряд случайный
            else if (statistic < -1 * U)
                return -1; //тенденция к спаданию
            else return 1; //тенденция к возрастанию
        }

        private void CountCorreletionInSeries()
        {
            for (int i = 0; i < AmountOfElements / 2; i++)
            {
                var coef = CountCorreletion(i);
                Correlation.Add(coef);
                if (CheckCoefOfCorr(i, coef) == 0)
                    IsCoefCorrSignificant = false;
            }
        }

        private double CountCorreletion(int index)
        {
            double numerator = 0, denominatorFirstPart = 0, denominatorSecondPart = 0, denominator = 0;
            for(int i = 0; i < AmountOfElements - index; i++)
            {
                double temp = Value[i] - (1.0 / (AmountOfElements - index)) * SumOfElements(index);
                numerator += temp * (Value[i + index] - (1.0 / (AmountOfElements - index)) * SumOfElementsWithShift(index));
                denominatorFirstPart += Math.Pow(Value[i] - (1.0 / (AmountOfElements - index)) * SumOfElements(index), 2);
                denominatorSecondPart += Math.Pow(Value[i + index] - (1.0 / (AmountOfElements - index)) * SumOfElementsWithShift(index), 2);
            }
            double koef = 1.0 / (AmountOfElements - index);
            numerator = koef * numerator;
            denominator = Math.Pow(koef * denominatorFirstPart * koef * denominatorSecondPart, 0.5);
            return numerator / denominator;
        }

        private double SumOfElements(int index)
        {
            double res = 0;
            for (int i = 0; i < AmountOfElements - index; i++)
                res += Value[i];
            return res;
        }

        private double SumOfElementsWithShift(int index)
        {
            double res = 0;
            for (int i = 0; i < AmountOfElements - index; i++)
                res += Value[i + index];
            return res;
        }

        private int CheckCoefOfCorr(int index, double rK)
        {
            var qStudent = Quantile.FindQuantileStudenta(AmountOfElements - index - 2);
            double tK = (rK * Math.Sqrt(AmountOfElements - index - 2)) / Math.Sqrt(1 - rK * rK);
            if (Math.Abs(tK) <= qStudent)
            {
                CorCoefSignificance.Add(false);
                return 0;//не значимый
            }
            CorCoefSignificance.Add(true);
            return 1;//значимый
        }
    }
}
