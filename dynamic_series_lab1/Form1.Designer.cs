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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.chDynamicSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DifferentSignsCriterian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalDistribution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(709, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(123, 36);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // chDynamicSeries
            // 
            chartArea2.Name = "ChartArea1";
            this.chDynamicSeries.ChartAreas.Add(chartArea2);
            this.chDynamicSeries.Location = new System.Drawing.Point(12, 12);
            this.chDynamicSeries.Name = "chDynamicSeries";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chDynamicSeries.Series.Add(series2);
            this.chDynamicSeries.Size = new System.Drawing.Size(445, 300);
            this.chDynamicSeries.TabIndex = 1;
            this.chDynamicSeries.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DifferentSignsCriterian,
            this.RecordValues,
            this.NormalDistribution});
            this.dataGridView1.Location = new System.Drawing.Point(12, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 172);
            this.dataGridView1.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chDynamicSeries);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chDynamicSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDynamicSeries;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferentSignsCriterian;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalDistribution;
    }
}

