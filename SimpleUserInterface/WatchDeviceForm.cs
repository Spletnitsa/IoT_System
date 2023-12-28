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
    public partial class WatchDeviceForm : Form
    {
        private List<OLTP.Device> _devices;
        private Form _activeForm = null;

        public WatchDeviceForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeviceButton_Click(object sender, EventArgs e)
        {
            FormElementsPanel.Hide();
            Button deviceButton = (Button)sender;
            OLTP.Device currentDevice = (OLTP.Device)deviceButton.Tag;

            if (currentDevice.Type1.Name.Trim() == "Датчик")
            {
                _activeForm = new SensorDeviceForm(currentDevice);
            }
            else if (currentDevice.Type1.Name.Trim() == "Устройство ввода")
            {
                _activeForm = new InputDeviceForm(currentDevice);
            }
            else if (currentDevice.Type1.Name.Trim() == "Устройство вывода")
            {
                _activeForm = new OutputDeviceForm(currentDevice);
            }
            else if (currentDevice.Type1.Name.Trim() == "Освещение")
            {
                _activeForm = new LightDeviceForm(currentDevice);
            }

            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;
            SubFormsPanel.Controls.Add(_activeForm);
            SubFormsPanel.Tag = _activeForm;
            _activeForm.BringToFront();
            _activeForm.Show();
        }

        private void SubFormsPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            GetDataFromDB();
            FillDeviceListPanel();
            FormElementsPanel.Show();
        }

        private void WatchDeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_activeForm != null)
                _activeForm.Close();
        }

        private void WatchDeviceForm_Load(object sender, EventArgs e)
        {
            GetDataFromDB();
            FillDeviceListPanel();
        }

        private void GetDataFromDB()
        {
            this.CenterDeviceListPanel.Controls.Clear();
            _devices = new List<OLTP.Device>();

            foreach (OLTP.Device device in DataBase.DataBaseEntities.Device)
            {
                _devices.Add(device);
            }
        }

        private void FillDeviceListPanel()
        {
            foreach (OLTP.Device device in _devices)
            {
                string buttonText = $"{device.Name.Trim()}\n" +
                                    $"Сценарий: {device.Scenario.Name.Trim()}\n" +
                                    $"Адрес: {device.Location1.Country.Trim()}, {device.Location1.City.Trim()}," +
                                    $" {device.Location1.Street.Trim()}, {device.Location1.HouseNumber.Trim()}";

                Button newButton = new Button()
                {
                    Text = buttonText,
                    TextAlign = ContentAlignment.TopLeft,
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 12),
                    Tag = device,
                    Dock = DockStyle.Top,
                    Size = new Size(372, 72),
                };
                newButton.FlatAppearance.BorderSize = 2;
                newButton.Click += DeviceButton_Click;

                CenterDeviceListPanel.Controls.Add(newButton);

                Panel newSplitPanel = new Panel()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(372, 10)
                };

                CenterDeviceListPanel.Controls.Add(newSplitPanel);
            }
        }
    }
}
