using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dynamic_series_lab1
{
    public partial class Form1 : Form
    {
        public DynamicSeries Series;

        public Form1()
        {
            InitializeComponent();
            chDynamicSeries.ChartAreas[0].AxisX.Title = "Index";
            chDynamicSeries.ChartAreas[0].AxisY.Title = "Value";
            //chСorrelogram.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.RestoreDirectory = true;
                openFile.Filter = "Text files (*.csv)|*.csv";
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = new StreamReader(openFile.FileName))
                    {
                        var fields = reader.ReadLine();
                        var data = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            data.Add(reader.ReadLine());
                        }
                        Series = new DynamicSeries(fields, data);
                        ShowDynamicSeries();
                        ShowCorrelation();
                        FillData();
                        FillDataGridWithCoefs();
                    }
                }
            }            
        }

        private void ShowDynamicSeries()
        {
            chDynamicSeries.Series[0].Points.Clear();
            for (int i = 0; i < Series.AmountOfElements; i++)
            {
                chDynamicSeries.Series[0].Points.AddXY(Series.Index[i], Series.Value[i]);
            }
        }

        private void ShowCorrelation()
        {
            chСorrelogram.Series[0].Points.Clear();

            for (int i=0;i<Series.Correlation.Count;i++)
            {
                chСorrelogram.Series[0].Points.AddXY(i, Series.Correlation[i]);
            }
        }

        private void FillData()
        {
            dgDataTable.Rows.Clear();
            int amountOfRows = 3;
            for (int i = 0; i < amountOfRows; i++)
                dgDataTable.Rows.Add();
            Series.CriterionOfDifferenceSigns();
            Series.CriterionOfRecordValues();
            dgDataTable.Rows[0].Cells["DifferentSignsCriterian"].Value = $"K = {Series.K_statistic_difSigns.ToString()}";
            dgDataTable.Rows[1].Cells["DifferentSignsCriterian"].Value = $"{ReturnResultInTextForm(Series.CompareWithNormalQuantile(Series.K_statistic_difSigns))}";

            dgDataTable.Rows[0].Cells["RecordValues"].Value = $"T1 = {Series.T1_statistic}";
            dgDataTable.Rows[1].Cells["RecordValues"].Value = $"T1: {ReturnResultInTextForm(Series.CompareWithNormalQuantile(Series.T1_statistic))} среднего уровня";
            dgDataTable.Rows[2].Cells["RecordValues"].Value = $"T2 = {Series.T2_statistic}";
            dgDataTable.Rows[3].Cells["RecordValues"].Value = $"T2: {ReturnResultInTextForm(Series.CompareWithNormalQuantile(Series.T2_statistic))} дисперсии";

            dgDataTable.Rows[0].Cells["Quantile"].Value = $"u = {DynamicSeries.U.ToString()}";

            if(Series.IsCoefCorrSignificant == true)
                tBCoefCorr.Text = $"коэффициенты значимые, есть тренд";
            else
                tBCoefCorr.Text = $"ряд случайный";
        }

        private string ReturnResultInTextForm(int res)
        {
            switch(res)
            {
                case -1:
                    return "тенденция к уменьшению";
                case 0:
                    return "нет изменений";
                case 1:
                    return "тенденция к возрастанию";
                default:
                    return "ошибка";
            }            
        }

        private void FillDataGridWithCoefs()
        {
            dgRCoefs.Rows.Clear();
            for (int i = 0; i < Series.Correlation.Count; i++)
            {
                dgRCoefs.Rows.Add();
                dgRCoefs.Rows[i].Cells["RCoef"].Value = Series.Correlation[i].ToString();
                dgRCoefs.Rows[i].Cells["Significance"].Value = Series.CorCoefSignificance[i].ToString();
            }
        }
    }
}
