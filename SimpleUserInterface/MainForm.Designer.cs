namespace SimpleUserInterface
{
    public partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.subDevicePanel = new System.Windows.Forms.Panel();
            this.WatchDeviceButton = new System.Windows.Forms.Button();
            this.AddDeviceButton = new System.Windows.Forms.Button();
            this.DeviceButton = new System.Windows.Forms.Button();
            this.subScenarioPanel = new System.Windows.Forms.Panel();
            this.WatchScenarioButton = new System.Windows.Forms.Button();
            this.AddScenarioButton = new System.Windows.Forms.Button();
            this.ScenarioButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.childFormsPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.subDevicePanel.SuspendLayout();
            this.subScenarioPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.menuPanel.Controls.Add(this.subDevicePanel);
            this.menuPanel.Controls.Add(this.DeviceButton);
            this.menuPanel.Controls.Add(this.subScenarioPanel);
            this.menuPanel.Controls.Add(this.ScenarioButton);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 501);
            this.menuPanel.TabIndex = 0;
            // 
            // subDevicePanel
            // 
            this.subDevicePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subDevicePanel.Controls.Add(this.WatchDeviceButton);
            this.subDevicePanel.Controls.Add(this.AddDeviceButton);
            this.subDevicePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subDevicePanel.Location = new System.Drawing.Point(0, 220);
            this.subDevicePanel.Name = "subDevicePanel";
            this.subDevicePanel.Size = new System.Drawing.Size(200, 80);
            this.subDevicePanel.TabIndex = 3;
            // 
            // WatchDeviceButton
            // 
            this.WatchDeviceButton.BackColor = System.Drawing.Color.Gray;
            this.WatchDeviceButton.FlatAppearance.BorderSize = 0;
            this.WatchDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchDeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchDeviceButton.ForeColor = System.Drawing.Color.White;
            this.WatchDeviceButton.Location = new System.Drawing.Point(0, 40);
            this.WatchDeviceButton.Name = "WatchDeviceButton";
            this.WatchDeviceButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.WatchDeviceButton.Size = new System.Drawing.Size(200, 40);
            this.WatchDeviceButton.TabIndex = 4;
            this.WatchDeviceButton.Text = "Просмотр устройств";
            this.WatchDeviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WatchDeviceButton.UseVisualStyleBackColor = false;
            this.WatchDeviceButton.Click += new System.EventHandler(this.WatchDeviceButton_Click);
            // 
            // AddDeviceButton
            // 
            this.AddDeviceButton.BackColor = System.Drawing.Color.Gray;
            this.AddDeviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddDeviceButton.FlatAppearance.BorderSize = 0;
            this.AddDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDeviceButton.ForeColor = System.Drawing.Color.White;
            this.AddDeviceButton.Location = new System.Drawing.Point(0, 0);
            this.AddDeviceButton.Name = "AddDeviceButton";
            this.AddDeviceButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AddDeviceButton.Size = new System.Drawing.Size(200, 40);
            this.AddDeviceButton.TabIndex = 5;
            this.AddDeviceButton.Text = "Добавить устройство";
            this.AddDeviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDeviceButton.UseVisualStyleBackColor = false;
            this.AddDeviceButton.Click += new System.EventHandler(this.AddDeviceButton_Click);
            // 
            // DeviceButton
            // 
            this.DeviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeviceButton.FlatAppearance.BorderSize = 0;
            this.DeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceButton.ForeColor = System.Drawing.Color.Black;
            this.DeviceButton.Location = new System.Drawing.Point(0, 180);
            this.DeviceButton.Name = "DeviceButton";
            this.DeviceButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DeviceButton.Size = new System.Drawing.Size(200, 40);
            this.DeviceButton.TabIndex = 2;
            this.DeviceButton.Text = "Устройства";
            this.DeviceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeviceButton.UseVisualStyleBackColor = true;
            this.DeviceButton.Click += new System.EventHandler(this.DeviceButton_Click);
            // 
            // subScenarioPanel
            // 
            this.subScenarioPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subScenarioPanel.Controls.Add(this.WatchScenarioButton);
            this.subScenarioPanel.Controls.Add(this.AddScenarioButton);
            this.subScenarioPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subScenarioPanel.Location = new System.Drawing.Point(0, 100);
            this.subScenarioPanel.Name = "subScenarioPanel";
            this.subScenarioPanel.Size = new System.Drawing.Size(200, 80);
            this.subScenarioPanel.TabIndex = 2;
            // 
            // WatchScenarioButton
            // 
            this.WatchScenarioButton.BackColor = System.Drawing.Color.Gray;
            this.WatchScenarioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WatchScenarioButton.FlatAppearance.BorderSize = 0;
            this.WatchScenarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchScenarioButton.ForeColor = System.Drawing.Color.White;
            this.WatchScenarioButton.Location = new System.Drawing.Point(0, 40);
            this.WatchScenarioButton.Name = "WatchScenarioButton";
            this.WatchScenarioButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.WatchScenarioButton.Size = new System.Drawing.Size(200, 40);
            this.WatchScenarioButton.TabIndex = 3;
            this.WatchScenarioButton.Text = "Просмотр сценариев";
            this.WatchScenarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WatchScenarioButton.UseVisualStyleBackColor = false;
            this.WatchScenarioButton.Click += new System.EventHandler(this.WatchScenarioButton_Click);
            // 
            // AddScenarioButton
            // 
            this.AddScenarioButton.BackColor = System.Drawing.Color.Gray;
            this.AddScenarioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddScenarioButton.FlatAppearance.BorderSize = 0;
            this.AddScenarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddScenarioButton.ForeColor = System.Drawing.Color.White;
            this.AddScenarioButton.Location = new System.Drawing.Point(0, 0);
            this.AddScenarioButton.Name = "AddScenarioButton";
            this.AddScenarioButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AddScenarioButton.Size = new System.Drawing.Size(200, 40);
            this.AddScenarioButton.TabIndex = 4;
            this.AddScenarioButton.Text = "Добавить сценарий";
            this.AddScenarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddScenarioButton.UseVisualStyleBackColor = false;
            this.AddScenarioButton.Click += new System.EventHandler(this.AddScenarioButton_Click);
            // 
            // ScenarioButton
            // 
            this.ScenarioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScenarioButton.FlatAppearance.BorderSize = 0;
            this.ScenarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScenarioButton.ForeColor = System.Drawing.Color.Black;
            this.ScenarioButton.Location = new System.Drawing.Point(0, 60);
            this.ScenarioButton.Name = "ScenarioButton";
            this.ScenarioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ScenarioButton.Size = new System.Drawing.Size(200, 40);
            this.ScenarioButton.TabIndex = 1;
            this.ScenarioButton.Text = "Сценарии";
            this.ScenarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScenarioButton.UseVisualStyleBackColor = true;
            this.ScenarioButton.Click += new System.EventHandler(this.ScenarioButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.menuLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 60);
            this.logoPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.Location = new System.Drawing.Point(48, 20);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(94, 31);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "MENU";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childFormsPanel
            // 
            this.childFormsPanel.BackColor = System.Drawing.Color.White;
            this.childFormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormsPanel.Location = new System.Drawing.Point(200, 0);
            this.childFormsPanel.Name = "childFormsPanel";
            this.childFormsPanel.Size = new System.Drawing.Size(744, 501);
            this.childFormsPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.childFormsPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "MainMenu";
            this.menuPanel.ResumeLayout(false);
            this.subDevicePanel.ResumeLayout(false);
            this.subScenarioPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button ScenarioButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button DeviceButton;
        private System.Windows.Forms.Panel subDevicePanel;
        private System.Windows.Forms.Button AddDeviceButton;
        private System.Windows.Forms.Panel subScenarioPanel;
        private System.Windows.Forms.Button WatchScenarioButton;
        private System.Windows.Forms.Button AddScenarioButton;
        private System.Windows.Forms.Button WatchDeviceButton;
        private System.Windows.Forms.Panel childFormsPanel;
        private System.Windows.Forms.Label menuLabel;
    }
}

