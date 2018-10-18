namespace dynamic_series_lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.chDynamicSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgDataTable = new System.Windows.Forms.DataGridView();
            this.DifferentSignsCriterian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chСorrelogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tBCoefCorr = new System.Windows.Forms.TextBox();
            this.dgRCoefs = new System.Windows.Forms.DataGridView();
            this.RCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Significance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chСorrelogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRCoefs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(587, 389);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(151, 72);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // chDynamicSeries
            // 
            chartArea1.Name = "ChartArea1";
            this.chDynamicSeries.ChartAreas.Add(chartArea1);
            this.chDynamicSeries.Location = new System.Drawing.Point(12, 12);
            this.chDynamicSeries.Name = "chDynamicSeries";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chDynamicSeries.Series.Add(series1);
            this.chDynamicSeries.Size = new System.Drawing.Size(445, 300);
            this.chDynamicSeries.TabIndex = 1;
            this.chDynamicSeries.Text = "chart1";
            // 
            // dgDataTable
            // 
            this.dgDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DifferentSignsCriterian,
            this.RecordValues,
            this.Quantile});
            this.dgDataTable.Location = new System.Drawing.Point(12, 318);
            this.dgDataTable.Name = "dgDataTable";
            this.dgDataTable.Size = new System.Drawing.Size(445, 172);
            this.dgDataTable.TabIndex = 2;
            // 
            // DifferentSignsCriterian
            // 
            this.DifferentSignsCriterian.HeaderText = "Different Signs Criterian";
            this.DifferentSignsCriterian.Name = "DifferentSignsCriterian";
            this.DifferentSignsCriterian.Width = 150;
            // 
            // RecordValues
            // 
            this.RecordValues.HeaderText = "Record Values Criterian";
            this.RecordValues.Name = "RecordValues";
            this.RecordValues.Width = 150;
            // 
            // Quantile
            // 
            this.Quantile.HeaderText = "Quantile";
            this.Quantile.Name = "Quantile";
            this.Quantile.Width = 80;
            // 
            // chСorrelogram
            // 
            chartArea2.Name = "ChartArea1";
            this.chСorrelogram.ChartAreas.Add(chartArea2);
            this.chСorrelogram.Location = new System.Drawing.Point(463, 12);
            this.chСorrelogram.Name = "chСorrelogram";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PointWidth=1";
            series2.Name = "Series1";
            this.chСorrelogram.Series.Add(series2);
            this.chСorrelogram.Size = new System.Drawing.Size(377, 300);
            this.chСorrelogram.TabIndex = 3;
            this.chСorrelogram.Text = "chart1";
            // 
            // tBCoefCorr
            // 
            this.tBCoefCorr.Location = new System.Drawing.Point(562, 335);
            this.tBCoefCorr.Name = "tBCoefCorr";
            this.tBCoefCorr.Size = new System.Drawing.Size(198, 20);
            this.tBCoefCorr.TabIndex = 4;
            // 
            // dgRCoefs
            // 
            this.dgRCoefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRCoefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RCoef,
            this.Significance});
            this.dgRCoefs.Location = new System.Drawing.Point(846, 12);
            this.dgRCoefs.Name = "dgRCoefs";
            this.dgRCoefs.Size = new System.Drawing.Size(258, 478);
            this.dgRCoefs.TabIndex = 5;
            // 
            // RCoef
            // 
            this.RCoef.HeaderText = "R coef";
            this.RCoef.Name = "RCoef";
            // 
            // Significance
            // 
            this.Significance.HeaderText = "Significance";
            this.Significance.Name = "Significance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 502);
            this.Controls.Add(this.dgRCoefs);
            this.Controls.Add(this.tBCoefCorr);
            this.Controls.Add(this.chСorrelogram);
            this.Controls.Add(this.dgDataTable);
            this.Controls.Add(this.chDynamicSeries);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "lab1";
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chСorrelogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRCoefs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDynamicSeries;
        private System.Windows.Forms.DataGridView dgDataTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chСorrelogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferentSignsCriterian;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantile;
        private System.Windows.Forms.TextBox tBCoefCorr;
        private System.Windows.Forms.DataGridView dgRCoefs;
        private System.Windows.Forms.DataGridViewTextBoxColumn RCoef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Significance;
    }
}

