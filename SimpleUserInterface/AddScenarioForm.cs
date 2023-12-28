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
    public partial class AddScenarioForm : Form
    {
        public AddScenarioForm()
        {
            InitializeComponent();
            SetPasswordPanel.Visible = false;
        }

        private void HaveScenarioYesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(HavePasswordYesCheckBox.Checked)
            {
                SetPasswordPanel.Visible = true;
            }
            else
            { 
                SetPasswordPanel.Visible = false; 
            }
        }

        private void CleanFieldButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddScenarioBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text != RepitPasswordTextBox.Text)
                MessageBox.Show("Пароль не совпадает!");
            else
            {
                OLTP.Scenario scenario = new OLTP.Scenario();
                scenario.Name = NameScenarioTextBox.Text;
                scenario.Path = PathScenarioTextBox.Text;
                scenario.Uploaded = false;
                if (HavePasswordYesCheckBox.Checked)
                {
                    scenario.HavePassword = true;
                    scenario.Password = NewPasswordTextBox.Text;
                }
                else if (HavePasswordNoCheckBox.Checked)
                {
                    scenario.HavePassword = false;
                }

                try
                {
                    DataBase.DataBaseEntities.Scenario.Add(scenario);
                    DataBase.DataBaseEntities.SaveChanges();

                    scenario = DataBase.DataBaseEntities.Scenario
                                          .OrderByDescending(l => l.ScenarioID)
                                          .FirstOrDefault();

                    DWH_DM.Scenario scenarioDataMart = new DWH_DM.Scenario();
                    scenarioDataMart.ID_scenario = scenario.ScenarioID;
                    scenarioDataMart.Name = scenario.Name;
                    scenarioDataMart.Upload_status = scenario.Uploaded;

                    DataMart.DataMartEntities.Scenario.Add(scenarioDataMart);
                    DataMart.DataMartEntities.SaveChanges();

                    ClearFields();
                    MessageBox.Show("Сценарий успешно добавлен.");
                }
                catch
                {
                    MessageBox.Show("Не получилось добавить сценарий.");
                }
            }
        }

        private void FileBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog= new FolderBrowserDialog();

            folderBrowserDialog.Description = "Укажите путь к файлу загрузки сценария.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK )
                PathScenarioTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void ClearFields()
        {
            NameScenarioTextBox.Clear();
            PathScenarioTextBox.Clear();
            HavePasswordYesCheckBox.Checked = false;
            HavePasswordNoCheckBox.Checked = false;
            NewPasswordTextBox.Clear();
            RepitPasswordTextBox.Clear();
        }
    }
}
