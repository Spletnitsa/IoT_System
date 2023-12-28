using Microsoft.AnalysisServices.AdomdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUserInterface
{
    public partial class SensorDeviceForm : Form
    {
        private OLTP.Device _device;
        private DateTime[] _dateTimes;
        private int[] _data;

        public SensorDeviceForm(OLTP.Device device)
        {
            InitializeComponent();
            _device = device;
            FormLabel.Text = _device.Name;

            string fullAddress = $"{_device.Location1.Country.Trim()}, {_device.Location1.City.Trim()}," +
            $" {_device.Location1.Street.Trim()}, {_device.Location1.HouseNumber.Trim()}";

            InfoText.Text = "Тип: Датчик\n" +
                            $"Сценарий поведения: {_device.Scenario.Name}\n" +
                            $"Место размещения: {fullAddress}";

            InfoText2.Text = $"Данные: {_device.Data}\n" +
                             $"Последнее вермя ответа датчика: {_device.LastReplyTime}";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataVuisualizationButton_Click(object sender, EventArgs e)
        {
            GetDataFromOLAP();

            new VisualizationDataForm(_dateTimes, _data, _device.DataName1.Name.Trim()).Show();
        }

        private void PredictionButton_Click(object sender, EventArgs e)
        {
            GetDataFromOLAP();

            new PredictionDataForm(_dateTimes, _data, _device.DataName1.Name.Trim()).Show();
        }

        private void DeleteFieldButton_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseEntities.Device.Remove(_device);
            DataBase.DataBaseEntities.SaveChanges();
            this.Close();
        }

        private void UpadteDataButton_Click(object sender, EventArgs e)
        {
            _device = DataBase.DataBaseEntities.Device
                .Where(d => d.DeviceID == _device.DeviceID)
                .FirstOrDefault();

            InfoText2.Text = $"Данные: {_device.Data}\n" +
                             $"Последнее вермя ответа датчика: {_device.LastReplyTime}";
        }

        private void GetDataFromOLAP()
        {
            using (AdomdConnection connectionToOLAP = new AdomdConnection())
            {
                connectionToOLAP.ConnectionString = "Data Source=JOPKA-OGURTSA\\MSAS; Catalog=OLAP_for_IoT";

                try
                {
                    connectionToOLAP.Open();
                    AdomdCommand command = connectionToOLAP.CreateCommand();
                    command.CommandText = 
                        "SELECT \r\n\t" +
                            "[Date].[Day].[23] ON COLUMNS,\r\n\t" +
                            "[Date].[Date Time].Members ON ROWS\r\n" +
                        "FROM \r\n\t" +
                            "[OLAP_for_data_system]\r\n" +
                        "WHERE \r\n\t" +
                            "[Measures].[Data]";

                    CellSet cellSet = command.ExecuteCellSet();

                    TupleCollection rows = cellSet.Axes[1].Set.Tuples;
                    CellCollection cells = cellSet.Cells;

                    //Отнимаю еденицу, чтобы убрать значение all
                    _dateTimes = new DateTime[rows.Count - 1];
                    _data = new int[cells.Count - 1];

                    for (int i = 1; i < rows.Count; i++)
                    {
                        _dateTimes[i - 1] = DateTime.Parse(rows[i].Members[0].Caption);
                    }

                    for (int i = 1; i < cells.Count; i++)
                    {
                        _data[i - 1] = Convert.ToInt32(cells[i].Value);
                    }
                }
                catch
                {
                    MessageBox.Show("Не получилось получить данные!");
                }
            }
        }
    }
}
