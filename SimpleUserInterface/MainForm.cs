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
    partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            HideAllSupPanels();

            MicrocontollerHandler.Arduino.OpenPort();
        }

        private void HideAllSupPanels()
        {
            subScenarioPanel.Visible = false;
            subDevicePanel.Visible = false;
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormsPanel.Controls.Add(childForm);
            childFormsPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ScenarioButton_Click(object sender, EventArgs e)
        {
            subScenarioPanel.Visible = !subScenarioPanel.Visible;
        }

        private void AddScenarioButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddScenarioForm());
        }

        private void WatchScenarioButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WatchScenarioForm());
        }

        private void DeviceButton_Click(object sender, EventArgs e)
        {
            subDevicePanel.Visible = !subDevicePanel.Visible;
        }

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddDeviceForm());
        }

        private void WatchDeviceButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WatchDeviceForm());
        }
    }


}
