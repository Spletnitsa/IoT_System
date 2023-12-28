namespace SimpleUserInterface
{
    partial class PredictionDataForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PredictionDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PredictionDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PredictionDataChart.ChartAreas.Add(chartArea1);
            this.PredictionDataChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionDataChart.Location = new System.Drawing.Point(0, 0);
            this.PredictionDataChart.Name = "PredictionDataChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerSize = 10;
            series1.Name = "SensorDataSeries";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "PredictionDataSeries";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.MarkerSize = 10;
            series3.Name = "PredictionTestDataSeries";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Green;
            series4.MarkerSize = 10;
            series4.Name = "RealTestDataSeries";
            this.PredictionDataChart.Series.Add(series1);
            this.PredictionDataChart.Series.Add(series2);
            this.PredictionDataChart.Series.Add(series3);
            this.PredictionDataChart.Series.Add(series4);
            this.PredictionDataChart.Size = new System.Drawing.Size(1008, 681);
            this.PredictionDataChart.TabIndex = 0;
            this.PredictionDataChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "DataNameTitle";
            title1.Text = "Название графика";
            this.PredictionDataChart.Titles.Add(title1);
            // 
            // PredictionDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.PredictionDataChart);
            this.Name = "PredictionDataForm";
            this.Text = "PridictionDataForm";
            this.Load += new System.EventHandler(this.PredictionDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PredictionDataChart;
    }
}