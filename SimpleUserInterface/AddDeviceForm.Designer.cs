namespace SimpleUserInterface
{
    partial class AddDeviceForm
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
            this.FormLabel = new System.Windows.Forms.Label();
            this.LablePanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ControlPanel1 = new System.Windows.Forms.Panel();
            this.InfoFieldsPanel = new System.Windows.Forms.Panel();
            this.ExistiongLocationComboBox = new System.Windows.Forms.ComboBox();
            this.DataNameComboBox = new System.Windows.Forms.ComboBox();
            this.ExistiongLocationLabel = new System.Windows.Forms.Label();
            this.DataNameLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.BehavioursScenarioLabel = new System.Windows.Forms.Label();
            this.BehavioursScenarioComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameDeviceLabel = new System.Windows.Forms.Label();
            this.NameDeviceTextBox = new System.Windows.Forms.TextBox();
            this.LocationFieldsPanel = new System.Windows.Forms.Panel();
            this.HouseNumberTextBox = new System.Windows.Forms.TextBox();
            this.HouseNumberLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.RegionTextBox = new System.Windows.Forms.TextBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CleanFieldButton = new System.Windows.Forms.Button();
            this.ControlPanel2 = new System.Windows.Forms.Panel();
            this.LablePanel.SuspendLayout();
            this.ControlPanel1.SuspendLayout();
            this.InfoFieldsPanel.SuspendLayout();
            this.LocationFieldsPanel.SuspendLayout();
            this.ControlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLabel.ForeColor = System.Drawing.Color.White;
            this.FormLabel.Location = new System.Drawing.Point(0, 0);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.FormLabel.Size = new System.Drawing.Size(273, 45);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "Добавление устройства";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LablePanel
            // 
            this.LablePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LablePanel.Controls.Add(this.FormLabel);
            this.LablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LablePanel.Location = new System.Drawing.Point(0, 0);
            this.LablePanel.Name = "LablePanel";
            this.LablePanel.Size = new System.Drawing.Size(744, 60);
            this.LablePanel.TabIndex = 1;
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
            this.BackButton.Click += new System.EventHandler(this.AddDeviceBackButton_Click);
            // 
            // ControlPanel1
            // 
            this.ControlPanel1.Controls.Add(this.BackButton);
            this.ControlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel1.Location = new System.Drawing.Point(0, 60);
            this.ControlPanel1.Name = "ControlPanel1";
            this.ControlPanel1.Size = new System.Drawing.Size(744, 45);
            this.ControlPanel1.TabIndex = 20;
            // 
            // InfoFieldsPanel
            // 
            this.InfoFieldsPanel.Controls.Add(this.ExistiongLocationComboBox);
            this.InfoFieldsPanel.Controls.Add(this.DataNameComboBox);
            this.InfoFieldsPanel.Controls.Add(this.ExistiongLocationLabel);
            this.InfoFieldsPanel.Controls.Add(this.DataNameLabel);
            this.InfoFieldsPanel.Controls.Add(this.LocationLabel);
            this.InfoFieldsPanel.Controls.Add(this.BehavioursScenarioLabel);
            this.InfoFieldsPanel.Controls.Add(this.BehavioursScenarioComboBox);
            this.InfoFieldsPanel.Controls.Add(this.TypeComboBox);
            this.InfoFieldsPanel.Controls.Add(this.TypeLabel);
            this.InfoFieldsPanel.Controls.Add(this.NameDeviceLabel);
            this.InfoFieldsPanel.Controls.Add(this.NameDeviceTextBox);
            this.InfoFieldsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoFieldsPanel.Location = new System.Drawing.Point(0, 105);
            this.InfoFieldsPanel.Name = "InfoFieldsPanel";
            this.InfoFieldsPanel.Size = new System.Drawing.Size(744, 168);
            this.InfoFieldsPanel.TabIndex = 21;
            // 
            // ExistiongLocationComboBox
            // 
            this.ExistiongLocationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistiongLocationComboBox.FormattingEnabled = true;
            this.ExistiongLocationComboBox.Location = new System.Drawing.Point(377, 134);
            this.ExistiongLocationComboBox.Name = "ExistiongLocationComboBox";
            this.ExistiongLocationComboBox.Size = new System.Drawing.Size(347, 28);
            this.ExistiongLocationComboBox.TabIndex = 16;
            // 
            // DataNameComboBox
            // 
            this.DataNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataNameComboBox.FormattingEnabled = true;
            this.DataNameComboBox.Location = new System.Drawing.Point(24, 83);
            this.DataNameComboBox.Name = "DataNameComboBox";
            this.DataNameComboBox.Size = new System.Drawing.Size(347, 28);
            this.DataNameComboBox.TabIndex = 14;
            // 
            // ExistiongLocationLabel
            // 
            this.ExistiongLocationLabel.AutoSize = true;
            this.ExistiongLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistiongLocationLabel.Location = new System.Drawing.Point(373, 111);
            this.ExistiongLocationLabel.Name = "ExistiongLocationLabel";
            this.ExistiongLocationLabel.Size = new System.Drawing.Size(284, 20);
            this.ExistiongLocationLabel.TabIndex = 15;
            this.ExistiongLocationLabel.Text = "Выбрать уже добавленную локацию";
            // 
            // DataNameLabel
            // 
            this.DataNameLabel.AutoSize = true;
            this.DataNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataNameLabel.Location = new System.Drawing.Point(20, 60);
            this.DataNameLabel.Name = "DataNameLabel";
            this.DataNameLabel.Size = new System.Drawing.Size(147, 20);
            this.DataNameLabel.TabIndex = 13;
            this.DataNameLabel.Text = "Название данных:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationLabel.Location = new System.Drawing.Point(20, 142);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(169, 20);
            this.LocationLabel.TabIndex = 12;
            this.LocationLabel.Text = "Место размещения ˅";
            this.LocationLabel.Click += new System.EventHandler(this.AddDeviceLocationLabel_Click);
            // 
            // BehavioursScenarioLabel
            // 
            this.BehavioursScenarioLabel.AutoSize = true;
            this.BehavioursScenarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BehavioursScenarioLabel.Location = new System.Drawing.Point(373, 57);
            this.BehavioursScenarioLabel.Name = "BehavioursScenarioLabel";
            this.BehavioursScenarioLabel.Size = new System.Drawing.Size(249, 20);
            this.BehavioursScenarioLabel.TabIndex = 11;
            this.BehavioursScenarioLabel.Text = "Название сценария поведения:";
            // 
            // BehavioursScenarioComboBox
            // 
            this.BehavioursScenarioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BehavioursScenarioComboBox.FormattingEnabled = true;
            this.BehavioursScenarioComboBox.Location = new System.Drawing.Point(377, 83);
            this.BehavioursScenarioComboBox.Name = "BehavioursScenarioComboBox";
            this.BehavioursScenarioComboBox.Size = new System.Drawing.Size(347, 28);
            this.BehavioursScenarioComboBox.TabIndex = 10;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(377, 28);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(347, 28);
            this.TypeComboBox.TabIndex = 9;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(373, 5);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(40, 20);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Тип:";
            // 
            // NameDeviceLabel
            // 
            this.NameDeviceLabel.AutoSize = true;
            this.NameDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDeviceLabel.Location = new System.Drawing.Point(20, 5);
            this.NameDeviceLabel.Name = "NameDeviceLabel";
            this.NameDeviceLabel.Size = new System.Drawing.Size(177, 20);
            this.NameDeviceLabel.TabIndex = 5;
            this.NameDeviceLabel.Text = "Название устройства:";
            // 
            // NameDeviceTextBox
            // 
            this.NameDeviceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDeviceTextBox.Location = new System.Drawing.Point(24, 28);
            this.NameDeviceTextBox.Name = "NameDeviceTextBox";
            this.NameDeviceTextBox.Size = new System.Drawing.Size(347, 26);
            this.NameDeviceTextBox.TabIndex = 6;
            // 
            // LocationFieldsPanel
            // 
            this.LocationFieldsPanel.AutoScroll = true;
            this.LocationFieldsPanel.Controls.Add(this.HouseNumberTextBox);
            this.LocationFieldsPanel.Controls.Add(this.HouseNumberLabel);
            this.LocationFieldsPanel.Controls.Add(this.StreetTextBox);
            this.LocationFieldsPanel.Controls.Add(this.StreetLabel);
            this.LocationFieldsPanel.Controls.Add(this.CityTextBox);
            this.LocationFieldsPanel.Controls.Add(this.CityLabel);
            this.LocationFieldsPanel.Controls.Add(this.RegionTextBox);
            this.LocationFieldsPanel.Controls.Add(this.RegionLabel);
            this.LocationFieldsPanel.Controls.Add(this.CountryTextBox);
            this.LocationFieldsPanel.Controls.Add(this.CountryLabel);
            this.LocationFieldsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationFieldsPanel.Location = new System.Drawing.Point(0, 273);
            this.LocationFieldsPanel.Name = "LocationFieldsPanel";
            this.LocationFieldsPanel.Size = new System.Drawing.Size(744, 165);
            this.LocationFieldsPanel.TabIndex = 22;
            // 
            // HouseNumberTextBox
            // 
            this.HouseNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumberTextBox.Location = new System.Drawing.Point(24, 135);
            this.HouseNumberTextBox.Name = "HouseNumberTextBox";
            this.HouseNumberTextBox.Size = new System.Drawing.Size(173, 26);
            this.HouseNumberTextBox.TabIndex = 20;
            // 
            // HouseNumberLabel
            // 
            this.HouseNumberLabel.AutoSize = true;
            this.HouseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumberLabel.Location = new System.Drawing.Point(20, 112);
            this.HouseNumberLabel.Name = "HouseNumberLabel";
            this.HouseNumberLabel.Size = new System.Drawing.Size(138, 20);
            this.HouseNumberLabel.TabIndex = 21;
            this.HouseNumberLabel.Text = "Номер строения:";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(377, 80);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(347, 26);
            this.StreetTextBox.TabIndex = 18;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetLabel.Location = new System.Drawing.Point(373, 57);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(60, 20);
            this.StreetLabel.TabIndex = 19;
            this.StreetLabel.Text = "Улица:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityTextBox.Location = new System.Drawing.Point(24, 80);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(347, 26);
            this.CityTextBox.TabIndex = 16;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(20, 57);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(60, 20);
            this.CityLabel.TabIndex = 17;
            this.CityLabel.Text = "Город:";
            // 
            // RegionTextBox
            // 
            this.RegionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionTextBox.Location = new System.Drawing.Point(377, 25);
            this.RegionTextBox.Name = "RegionTextBox";
            this.RegionTextBox.Size = new System.Drawing.Size(347, 26);
            this.RegionTextBox.TabIndex = 14;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionLabel.Location = new System.Drawing.Point(373, 2);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(66, 20);
            this.RegionLabel.TabIndex = 15;
            this.RegionLabel.Text = "Регион:";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTextBox.Location = new System.Drawing.Point(24, 25);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(347, 26);
            this.CountryTextBox.TabIndex = 13;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(20, 2);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(69, 20);
            this.CountryLabel.TabIndex = 13;
            this.CountryLabel.Text = "Страна:";
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(377, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(347, 30);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CleanFieldButton
            // 
            this.CleanFieldButton.FlatAppearance.BorderSize = 2;
            this.CleanFieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanFieldButton.Location = new System.Drawing.Point(24, 6);
            this.CleanFieldButton.Name = "CleanFieldButton";
            this.CleanFieldButton.Size = new System.Drawing.Size(347, 30);
            this.CleanFieldButton.TabIndex = 23;
            this.CleanFieldButton.Text = "Очистить поля";
            this.CleanFieldButton.UseVisualStyleBackColor = true;
            this.CleanFieldButton.Click += new System.EventHandler(this.AddDeviceCleanFieldButton_Click);
            // 
            // ControlPanel2
            // 
            this.ControlPanel2.Controls.Add(this.AddButton);
            this.ControlPanel2.Controls.Add(this.CleanFieldButton);
            this.ControlPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel2.Location = new System.Drawing.Point(0, 438);
            this.ControlPanel2.Name = "ControlPanel2";
            this.ControlPanel2.Size = new System.Drawing.Size(744, 63);
            this.ControlPanel2.TabIndex = 25;
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.ControlPanel2);
            this.Controls.Add(this.LocationFieldsPanel);
            this.Controls.Add(this.InfoFieldsPanel);
            this.Controls.Add(this.ControlPanel1);
            this.Controls.Add(this.LablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeviceForm";
            this.Text = "AddDeviceForm";
            this.Load += new System.EventHandler(this.AddDeviceForm_Load);
            this.LablePanel.ResumeLayout(false);
            this.LablePanel.PerformLayout();
            this.ControlPanel1.ResumeLayout(false);
            this.InfoFieldsPanel.ResumeLayout(false);
            this.InfoFieldsPanel.PerformLayout();
            this.LocationFieldsPanel.ResumeLayout(false);
            this.LocationFieldsPanel.PerformLayout();
            this.ControlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Panel LablePanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel ControlPanel1;
        private System.Windows.Forms.Panel InfoFieldsPanel;
        private System.Windows.Forms.Label NameDeviceLabel;
        private System.Windows.Forms.TextBox NameDeviceTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label BehavioursScenarioLabel;
        private System.Windows.Forms.ComboBox BehavioursScenarioComboBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Panel LocationFieldsPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CleanFieldButton;
        private System.Windows.Forms.Panel ControlPanel2;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox HouseNumberTextBox;
        private System.Windows.Forms.Label HouseNumberLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.ComboBox DataNameComboBox;
        private System.Windows.Forms.Label DataNameLabel;
        private System.Windows.Forms.ComboBox ExistiongLocationComboBox;
        private System.Windows.Forms.Label ExistiongLocationLabel;
    }
}