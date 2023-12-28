using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using ArduinoUploader;
using ArduinoUploader.Hardware;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity;

namespace SimpleUserInterface
{
    public class Microcontroller
    {
        private string _portName;
        private int _baudrate;
        private SerialPort _serialPort;

        public Microcontroller(string portName, int baudrate)
        {
            _portName = portName;
            _baudrate = baudrate;
            _serialPort = new SerialPort(_portName, _baudrate);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
        }

        public void UploadScenario(string scenarioPath)
        {
            ClosePort();

            ArduinoSketchUploader uploader = new ArduinoSketchUploader(new ArduinoSketchUploaderOptions()
            {
                FileName = scenarioPath,
                PortName = _portName,
                ArduinoModel = ArduinoModel.UnoR3
            });

            uploader.UploadSketch();

            OpenPort();
        }

        public void SendData(string Data)
        {
            try
            {
                if(!_serialPort.IsOpen)
                    _serialPort.Open();

                _serialPort.Write(Data);
            }
            catch 
            {
                MessageBox.Show("Не удалось передать данные на Arduino.");
            }
        }

        public void OpenPort()
        {
            try
            {
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение с Arduino.");
            }
        }

        public void ClosePort()
        {
            try
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось закрыть соединение с Arduino.");
            }
        }

        public void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string[] message = _serialPort.ReadLine().Split(':');

                Console.WriteLine(message[0] + ':' +  message[1]);

                if (message[0] == "Data name")
                {
                    string dataName = Regex.Replace(message[1], @"[\r\n\t]", "");

                    OLTP.Device device = DataBase.DataBaseEntities.Device
                        .Where(d => d.DataName1.Name.Trim() == dataName)
                        .FirstOrDefault();

                    if (device != null)
                    {
                        message = _serialPort.ReadLine().Split(':');

                        Console.WriteLine(message[0] + ':' + message[1]);

                        string data = Regex.Replace(message[1], @"[\r\n\t]", "");

                        device.Data = int.Parse(data);
                        device.LastReplyTime = DateTime.Now;

                        DataBase.DataBaseEntities.SaveChanges();

                        DWH_DM.Date date = new DWH_DM.Date();
                        DateTime dateTime = (DateTime)device.LastReplyTime;

                        date.Date_time = dateTime;
                        date.Hour = dateTime.Hour;
                        date.Day = dateTime.Day;
                        date.Month = dateTime.Month;
                        date.Year = dateTime.Year;

                        DataMart.DataMartEntities.Date.Add(date);
                        DataMart.DataMartEntities.SaveChanges();

                        DWH_DM.DataStore dataStore = new DWH_DM.DataStore();

                        dataStore.Scenario_key = device.BehaviorScenario;
                        dataStore.Location_key = device.Location;
                        dataStore.Date_key = DataMart.DataMartEntities.Date
                            .OrderByDescending(d => d.ID_date)
                            .FirstOrDefault().ID_date;
                        dataStore.Device_name = device.Name;
                        dataStore.Data_name = device.DataName1.Name;
                        dataStore.Data = (int)device.Data;

                        DataMart.DataMartEntities.DataStore.Add(dataStore);
                        DataMart.DataMartEntities.SaveChanges();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Данные с Arduino не получены");
            }
        }
    }
}
