﻿namespace dynamic_series_lab1
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
            this.NormalDistribution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chСorrelogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chСorrelogram)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(594, 454);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(123, 36);
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
            this.NormalDistribution});
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
            // NormalDistribution
            // 
            this.NormalDistribution.HeaderText = "u";
            this.NormalDistribution.Name = "NormalDistribution";
            this.NormalDistribution.Width = 80;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 502);
            this.Controls.Add(this.chСorrelogram);
            this.Controls.Add(this.dgDataTable);
            this.Controls.Add(this.chDynamicSeries);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chСorrelogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDynamicSeries;
        private System.Windows.Forms.DataGridView dgDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferentSignsCriterian;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalDistribution;
        private System.Windows.Forms.DataVisualization.Charting.Chart chСorrelogram;
    }
}

