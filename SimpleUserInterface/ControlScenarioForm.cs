using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleUserInterface
{
    public partial class ControlScenarioForm : Form
    {
        private OLTP.Scenario _currentScenario;

        public ControlScenarioForm(OLTP.Scenario currentScenario)
        {
            InitializeComponent();
            _currentScenario = currentScenario;
            FormLabel.Text = _currentScenario.Name;
            ChangePasswordPanel.Visible = false;

            if (!_currentScenario.HavePassword)
            {
                ChangePasswordPanel.Visible = false;
                ChangePasswordLabelPanel.Visible = false;
            }
        }

        private void ChangePasswordLabel_Click(object sender, EventArgs e)
        {
            ChangePasswordPanel.Visible = !ChangePasswordPanel.Visible;

            if (ChangePasswordLabel.Text == "Сменить пароль ˅")
            {
                ChangePasswordLabel.Text = "Сменить пароль ˄";
            }
            else
            {
                ChangePasswordLabel.Text = "Сменить пароль ˅";
            }
        }

        private void ConfirmChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (NewPasswoedTextBox.Text != RepitPasswordTextBox.Text)
            {
                MessageBox.Show("Пароль не совпадает!");
            }
            else
            {
                _currentScenario.Password = NewPasswoedTextBox.Text;
                DataBase.DataBaseEntities.SaveChanges();

                if (_currentScenario.Uploaded || _currentScenario.HavePassword)
                    MicrocontollerHandler.Arduino.SendData(_currentScenario.Password.Trim());

                NewPasswoedTextBox.Clear();
                RepitPasswordTextBox.Clear();

                MessageBox.Show("Пароль успешно изменен.");
            }
        }

        private void ControlScenarioBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoreInfoButton_Click(object sender, EventArgs e)
        {
            Process.Start(_currentScenario.Path.Trim() + @"\Instruction.pdf");
        }


        private void ControlScenarioForm_Load(object sender, EventArgs e)
        {
            ChangeUploadStatusMarker();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (!_currentScenario.Uploaded)
            {
                UploadScenarioToArduino();
                ChangeUploadStatusMarker();
            }
            else
            {
                MessageBox.Show("Сценарий уже загружен.");
            }
        }

        private void DeleteScenarioButton_Click(object sender, EventArgs e)
        {
            string defaultScenarioPath = "C:\\Users\\dexte\\Documents\\4 course\\Diploma\\2. Desktop app\\PrototypeUI\\" +
                                         "Default_scenario\\build\\arduino.avr.uno\\Default_scenario.ino.hex";

            OLTP.Device scenarioDependentDevice = DataBase.DataBaseEntities.Device
                .Where(s => s.BehaviorScenario == _currentScenario.ScenarioID)
                .FirstOrDefault();

            if (scenarioDependentDevice == null)
            {
                DataBase.DataBaseEntities.Scenario.Remove(_currentScenario);
                DataBase.DataBaseEntities.SaveChanges();

                if (_currentScenario.Uploaded)
                {
                    try
                    {
                        MicrocontollerHandler.Arduino.UploadScenario(defaultScenarioPath);
                    }
                    catch
                    {
                        MessageBox.Show("Не получилось загрузить дефолтный сценарий.");
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("От этого сценария зависят другие устройства.\nСначало необходимо удалить девайсы.");
            }
        }

        private void ChangeUploadStatusMarker()
        {
            if (_currentScenario.Uploaded)
            {
                UploadSatusLabel.ForeColor = Color.ForestGreen;
                UploadSatusLabel.Text = "Сценарий загружен";
            }
            else
            {
                UploadSatusLabel.ForeColor = Color.Firebrick;
                UploadSatusLabel.Text = "Сценарий не загружен";
            }
        }

        private void UploadScenarioToArduino()
        {
            try
            {
                string scenarioFolderName = _currentScenario.Path.Split('\\').Last().Trim();
                string scenarioPath = _currentScenario.Path.Trim() + @"\build\arduino.avr.uno\" + scenarioFolderName + ".ino.hex";

                MicrocontollerHandler.Arduino.UploadScenario(scenarioPath);

                OLTP.Scenario uploadedScenario = DataBase.DataBaseEntities.Scenario
                .Where(s => s.Uploaded == true)
                .FirstOrDefault();

                if (uploadedScenario != null)
                    uploadedScenario.Uploaded = false;

                _currentScenario.Uploaded = true;

                DataBase.DataBaseEntities.SaveChanges();

                DWH_DM.Scenario scenarioDataMart = DataMart.DataMartEntities.Scenario
                    .Where(s => s.ID_scenario == _currentScenario.ScenarioID).FirstOrDefault();

                scenarioDataMart.Upload_status = _currentScenario.Uploaded;

                DataMart.DataMartEntities.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Не получилось загрузить сценарий.");
            }

            Thread.Sleep(2000);

            if (_currentScenario.Uploaded && _currentScenario.HavePassword)
                MicrocontollerHandler.Arduino.SendData(_currentScenario.Password.Trim());
        }
    }
}
