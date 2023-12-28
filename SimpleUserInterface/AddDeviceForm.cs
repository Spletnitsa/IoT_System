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
    public partial class AddDeviceForm : Form
    {
        private List<OLTP.Type> _types;
        private List<OLTP.DataName> _dataNames;
        private List<OLTP.Scenario> _scenarios;
        private List<OLTP.Location> _locations;

        public AddDeviceForm()
        {
            InitializeComponent();
        }

        private void AddDeviceBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDeviceLocationLabel_Click(object sender, EventArgs e)
        {
            LocationFieldsPanel.Visible = !LocationFieldsPanel.Visible;

            if (LocationLabel.Text == "Место размещения ˅")
            {
                LocationLabel.Text = "Место размещения ˄";
            }
            else
            {
                LocationLabel.Text = "Место размещения ˅";
            }
        }

        private void AddDeviceCleanFieldButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ExistiongLocationComboBox.Text == "")
                InserLocationDataToDB();

            InsertDeviceDataToDB();
        }


        private void AddDeviceForm_Load(object sender, EventArgs e)
        {
            LocationFieldsPanel.Visible = false;
            GetDataFromDB();
            FillComboBoxes();
        }

        private void ClearFields()
        {
            NameDeviceTextBox.Clear();
            TypeComboBox.ResetText();
            BehavioursScenarioComboBox.ResetText();
            DataNameComboBox.ResetText();
            ExistiongLocationComboBox.ResetText();
            CountryTextBox.Clear();
            RegionTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            HouseNumberTextBox.Clear();
        }

        private void GetDataFromDB()
        {
            _types = new List<OLTP.Type>();
            _dataNames = new List<OLTP.DataName>();
            _scenarios = new List<OLTP.Scenario>();
            _locations = new List<OLTP.Location>();

            foreach (OLTP.Type deviceType in DataBase.DataBaseEntities.Type)
                _types.Add(deviceType);

            foreach (OLTP.DataName dataName in DataBase.DataBaseEntities.DataName)
                _dataNames.Add(dataName);

            foreach (OLTP.Scenario scenario in DataBase.DataBaseEntities.Scenario)
                _scenarios.Add(scenario);

            foreach (OLTP.Location location in DataBase.DataBaseEntities.Location)
                _locations.Add(location);
        }

        private void FillComboBoxes()
        {
            foreach (OLTP.Type type in _types)
                TypeComboBox.Items.Add(type.Name);

            foreach (OLTP.DataName dataName in _dataNames)
                DataNameComboBox.Items.Add(dataName.Name);

            foreach (OLTP.Scenario scenario in _scenarios)
                BehavioursScenarioComboBox.Items.Add(scenario.Name);

            foreach (OLTP.Location location in _locations)
            {
                ExistiongLocationComboBox.Items.Add(GetFullAddress(location));
            }
        }

        private void InserLocationDataToDB()
        {
            OLTP.Location location = new OLTP.Location();

            location.Country = CountryTextBox.Text;
            if (RegionTextBox.Text == "")
            {
                location.Region = null;
            }
            else
            {
                location.Region = RegionTextBox.Text;
            }
            location.City = CityTextBox.Text;
            location.Street = StreetTextBox.Text;
            location.HouseNumber = HouseNumberTextBox.Text;

            try
            {
                DataBase.DataBaseEntities.Location.Add(location);
                DataBase.DataBaseEntities.SaveChanges();

                location = DataBase.DataBaseEntities.Location
                                          .OrderByDescending(l => l.LocationID)
                                          .FirstOrDefault();

                DWH_DM.DeviceLocation locationDataMart = new DWH_DM.DeviceLocation();
                locationDataMart.ID_device_location = location.LocationID;
                locationDataMart.Country = location.Country;
                locationDataMart.City = location.City;
                locationDataMart.Street = location.Street;
                locationDataMart.HouseNumber = location.HouseNumber;

                DataMart.DataMartEntities.DeviceLocation.Add(locationDataMart);
                DataMart.DataMartEntities.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Возникли проблемы с добавдением метсоположения.");
            }
        }

        private void InsertDeviceDataToDB()
        {
            OLTP.Device device = new OLTP.Device();

            foreach (OLTP.Scenario scenarion in _scenarios)
            {
                if (BehavioursScenarioComboBox.Text == scenarion.Name)
                {
                    device.BehaviorScenario = scenarion.ScenarioID;
                    break;
                }
            }

            if (ExistiongLocationComboBox.Text == "")
            {
                device.Location = DataBase.DataBaseEntities.Location
                                          .OrderByDescending(l => l.LocationID)
                                          .FirstOrDefault().LocationID;
            }
            else
            {
                foreach (OLTP.Location location in _locations)
                {
                    if (ExistiongLocationComboBox.Text == GetFullAddress(location))
                    {
                        device.Location = location.LocationID;
                        break;
                    }
                }
            }

            foreach (OLTP.Type type in _types)
            {
                if (TypeComboBox.Text == type.Name)
                {
                    device.Type = type.TypeID;
                    break;
                }
            }

            foreach (OLTP.DataName dataName in _dataNames)
            {
                if (DataNameComboBox.Text == dataName.Name)
                {
                    device.DataName = dataName.DataNameID;
                    break;
                }
            }

            device.Name = NameDeviceTextBox.Text;

            try
            {
                DataBase.DataBaseEntities.Device.Add(device);
                DataBase.DataBaseEntities.SaveChanges();

                ClearFields();
                MessageBox.Show("Устройство успешно добавлено.");
            }
            catch
            {
                MessageBox.Show("Не получилось добавить устройство в базу данных.");
            }
        }

        private string GetFullAddress(OLTP.Location location)
        {
            string fullAddress = $"{location.Country.Trim()}, {location.City.Trim()}," +
                                 $" {location.Street.Trim()}, {location.HouseNumber.Trim()}";

            return fullAddress;
        }
    }
}
