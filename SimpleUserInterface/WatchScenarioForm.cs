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
    public partial class WatchScenarioForm : Form
    {
        private List<OLTP.Scenario> _scenarios;
        private Form _activeForm = null;

        public WatchScenarioForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScenarioButton_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;

            FormElementsPanel.Hide();

            _activeForm = new ControlScenarioForm((OLTP.Scenario)ClickedButton.Tag);

            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;
            SubFormsPanel.Controls.Add(_activeForm);
            SubFormsPanel.Tag = _activeForm; 
            _activeForm.BringToFront();
            _activeForm.Show();
        }

        private void WatchScenarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_activeForm != null)
                _activeForm.Close();
        }

        private void SubFormsPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            GetDataFromDB();
            FillScenarioListPanel();
            FormElementsPanel.Show();
        }

        private void WatchScenarioForm_Load(object sender, EventArgs e)
        {
            GetDataFromDB();
            FillScenarioListPanel();
        }

        private void GetDataFromDB()
        {
            this.CenterScenarioListPanel.Controls.Clear();
            _scenarios = new List<OLTP.Scenario>();

            foreach (OLTP.Scenario scenario in DataBase.DataBaseEntities.Scenario)
            {
                _scenarios.Add(scenario);
            }
        }

        private void FillScenarioListPanel()
        {
            foreach (OLTP.Scenario scenario in _scenarios)
            {
                Button newButton = new Button()
                {
                    Text = scenario.Name.Trim(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 12),
                    Tag = scenario,
                    Dock = DockStyle.Top,
                    Size = new Size(372, 60),
                };
                newButton.FlatAppearance.BorderSize = 2;
                newButton.Click += ScenarioButton_Click;

                CenterScenarioListPanel.Controls.Add(newButton);

                Panel newSplitPanel = new Panel()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(372, 10)
                };

                CenterScenarioListPanel.Controls.Add(newSplitPanel);
            }
        }
    }
}
