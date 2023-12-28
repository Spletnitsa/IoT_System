namespace SimpleUserInterface
{
    partial class VisualizationDataForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.VisualizationDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizationDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.VisualizationDataChart);
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPanel.Location = new System.Drawing.Point(0, 0);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(1008, 681);
            this.ChartPanel.TabIndex = 0;
            // 
            // VisualizationDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.VisualizationDataChart.ChartAreas.Add(chartArea1);
            this.VisualizationDataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisualizationDataChart.Location = new System.Drawing.Point(0, 0);
            this.VisualizationDataChart.Name = "VisualizationDataChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Name = "SensorDataSeries";
            this.VisualizationDataChart.Series.Add(series1);
            this.VisualizationDataChart.Size = new System.Drawing.Size(1008, 681);
            this.VisualizationDataChart.TabIndex = 0;
            this.VisualizationDataChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "DataNameTitle";
            title1.Text = "Название графика";
            this.VisualizationDataChart.Titles.Add(title1);
            // 
            // VisualizationDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.ChartPanel);
            this.Name = "VisualizationDataForm";
            this.Text = "Visualization data";
            this.Load += new System.EventHandler(this.VisualizationDataForm_Load);
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisualizationDataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart VisualizationDataChart;
    }
}