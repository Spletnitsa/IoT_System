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
    public partial class OutputDeviceForm : Form
    {
        private OLTP.Device _device;

        public OutputDeviceForm(OLTP.Device device)
        {
            InitializeComponent();
            _device = device;
            FormLabel.Text = _device.Name;

            string fullAddress = $"{_device.Location1.Country.Trim()}, {_device.Location1.City.Trim()}," +
            $" {_device.Location1.Street.Trim()}, {_device.Location1.HouseNumber.Trim()}";

            InfoText.Text = "Тип: Устройство вывода\n" +
                            $"Сценарий поведения: {_device.Scenario.Name}\n" +
                            $"Место размещения: {fullAddress}";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteFieldButton_Click(object sender, EventArgs e)
        {
            DataBase.DataBaseEntities.Device.Remove(_device);
            DataBase.DataBaseEntities.SaveChanges();
            this.Close();
        }
    }
}
