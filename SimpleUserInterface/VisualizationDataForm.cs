using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleUserInterface
{
    public partial class VisualizationDataForm : Form
    {
        private DateTime[] _dateTime;
        private int[] _data;
        private string _dataName;

        public VisualizationDataForm(DateTime[] dateTime, int[] data, string dataName)
        {
            InitializeComponent();
            _dateTime = dateTime;
            _data = data;
            _dataName = dataName;
        }

        private void VisualizationDataForm_Load(object sender, EventArgs e)
        {
            VisualizationDataChart.Titles.First().Font = new Font("Microsoft Sans Serif", 18);
            VisualizationDataChart.Series[0].ChartType = SeriesChartType.Spline;
            VisualizationDataChart.Series[0].BorderWidth = 3;

            switch (_dataName)
            {
                case "Movement":
                    VisualizationDataChart.Titles[0].Text = "График изменения стостояния датчика движения";
                    VisualizationDataChart.Series[0].ChartType = SeriesChartType.StepLine;
                    VisualizationDataChart.Series[0].BorderWidth = 3;
                    break;
                case "Brightness":
                    VisualizationDataChart.Titles[0].Text = "График изменения яркости света";
                    break;
                case "Temperature":
                    VisualizationDataChart.Titles[0].Text = "График изменения температуры C";
                    break;
                default:
                    VisualizationDataChart.Titles[0].Text = "?";
                    break;
            }

            for (int i = 0; i < _dateTime.Length; i++)
            {
                VisualizationDataChart.Series[0].Points.AddXY(_dateTime[i], _data[i]);
            }
        }
    }
}
