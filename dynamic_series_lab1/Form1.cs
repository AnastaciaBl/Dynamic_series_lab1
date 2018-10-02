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
                        FillDataGrid();
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

        private void FillDataGrid()
        {
            int amountOfRows = 3;
            for (int i = 0; i < amountOfRows; i++)
                dgDataTable.Rows.Add();
            int difSignsCriterion = Series.CriterionOfDifferenceSigns();
            dgDataTable.Rows[0].Cells["DifferentSignsCriterian"].Value = $"K = {Series.K_statistic_difSigns.ToString()}";
            dgDataTable.Rows[1].Cells["DifferentSignsCriterian"].Value = $"{ReturnResultInTextForm(difSignsCriterion)}";

            dgDataTable.Rows[0].Cells["NormalDistribution"].Value = DynamicSeries.U.ToString();
        }

        private string ReturnResultInTextForm(int res)
        {
            switch(res)
            {
                case -1:
                    return "тенденция к уменьшению";
                case 0:
                    return "ряд случайный";
                case 1:
                    return "тенденция к возрастанию";
                default:
                    return "ошибка";
            }            
        }
    }
}
