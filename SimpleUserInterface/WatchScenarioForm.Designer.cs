namespace SimpleUserInterface
{
    partial class WatchScenarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubFormsPanel = new System.Windows.Forms.Panel();
            this.FormElementsPanel = new System.Windows.Forms.Panel();
            this.RightScenarioListPanel = new System.Windows.Forms.Panel();
            this.CenterScenarioListPanel = new System.Windows.Forms.Panel();
            this.LeftScenariosListPanel = new System.Windows.Forms.Panel();
            this.ControlPanel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.FormLabel = new System.Windows.Forms.Label();
            this.SubFormsPanel.SuspendLayout();
            this.FormElementsPanel.SuspendLayout();
            this.ControlPanel1.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubFormsPanel
            // 
            this.SubFormsPanel.Controls.Add(this.FormElementsPanel);
            this.SubFormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFormsPanel.Location = new System.Drawing.Point(0, 0);
            this.SubFormsPanel.Name = "SubFormsPanel";
            this.SubFormsPanel.Size = new System.Drawing.Size(744, 501);
            this.SubFormsPanel.TabIndex = 0;
            this.SubFormsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.SubFormsPanel_ControlRemoved);
            // 
            // FormElementsPanel
            // 
            this.FormElementsPanel.Controls.Add(this.RightScenarioListPanel);
            this.FormElementsPanel.Controls.Add(this.CenterScenarioListPanel);
            this.FormElementsPanel.Controls.Add(this.LeftScenariosListPanel);
            this.FormElementsPanel.Controls.Add(this.ControlPanel1);
            this.FormElementsPanel.Controls.Add(this.LabelPanel);
            this.FormElementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormElementsPanel.Location = new System.Drawing.Point(0, 0);
            this.FormElementsPanel.Name = "FormElementsPanel";
            this.FormElementsPanel.Size = new System.Drawing.Size(744, 501);
            this.FormElementsPanel.TabIndex = 1;
            // 
            // RightScenarioListPanel
            // 
            this.RightScenarioListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RightScenarioListPanel.Location = new System.Drawing.Point(558, 133);
            this.RightScenarioListPanel.Name = "RightScenarioListPanel";
            this.RightScenarioListPanel.Size = new System.Drawing.Size(186, 368);
            this.RightScenarioListPanel.TabIndex = 28;
            // 
            // CenterScenarioListPanel
            // 
            this.CenterScenarioListPanel.AutoScroll = true;
            this.CenterScenarioListPanel.BackColor = System.Drawing.Color.White;
            this.CenterScenarioListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CenterScenarioListPanel.Location = new System.Drawing.Point(186, 133);
            this.CenterScenarioListPanel.Name = "CenterScenarioListPanel";
            this.CenterScenarioListPanel.Size = new System.Drawing.Size(372, 368);
            this.CenterScenarioListPanel.TabIndex = 27;
            // 
            // LeftScenariosListPanel
            // 
            this.LeftScenariosListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftScenariosListPanel.Location = new System.Drawing.Point(0, 133);
            this.LeftScenariosListPanel.Name = "LeftScenariosListPanel";
            this.LeftScenariosListPanel.Size = new System.Drawing.Size(186, 368);
            this.LeftScenariosListPanel.TabIndex = 26;
            // 
            // ControlPanel1
            // 
            this.ControlPanel1.Controls.Add(this.BackButton);
            this.ControlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel1.Location = new System.Drawing.Point(0, 60);
            this.ControlPanel1.Name = "ControlPanel1";
            this.ControlPanel1.Size = new System.Drawing.Size(744, 73);
            this.ControlPanel1.TabIndex = 23;
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 2;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(24, 10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 30);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.Color.Black;
            this.LabelPanel.Controls.Add(this.FormLabel);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(744, 60);
            this.LabelPanel.TabIndex = 7;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.BackColor = System.Drawing.Color.Black;
            this.FormLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.ForeColor = System.Drawing.Color.White;
            this.FormLabel.Location = new System.Drawing.Point(0, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.FormLabel.Size = new System.Drawing.Size(217, 45);
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Text = "Список сценариев";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WatchScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.SubFormsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WatchScenarioForm";
            this.Text = "WartchScenarioForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WatchScenarioForm_FormClosing);
            this.Load += new System.EventHandler(this.WatchScenarioForm_Load);
            this.SubFormsPanel.ResumeLayout(false);
            this.FormElementsPanel.ResumeLayout(false);
            this.ControlPanel1.ResumeLayout(false);
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubFormsPanel;
        private System.Windows.Forms.Panel FormElementsPanel;
        private System.Windows.Forms.Panel RightScenarioListPanel;
        private System.Windows.Forms.Panel CenterScenarioListPanel;
        private System.Windows.Forms.Panel LeftScenariosListPanel;
        private System.Windows.Forms.Panel ControlPanel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Label FormLabel;
    }
}