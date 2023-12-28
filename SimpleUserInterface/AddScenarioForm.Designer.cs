namespace SimpleUserInterface
{
    partial class AddScenarioForm
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
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.NewPasswoedLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepitPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepitPasswordLabel = new System.Windows.Forms.Label();
            this.CleanFieldButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SetPasswordPanel = new System.Windows.Forms.Panel();
            this.NameScenarioTextBox = new System.Windows.Forms.TextBox();
            this.PathScenarioLabel = new System.Windows.Forms.Label();
            this.PathScenarioTextBox = new System.Windows.Forms.TextBox();
            this.FileBrowseButton = new System.Windows.Forms.Button();
            this.HavePasswordLabel = new System.Windows.Forms.Label();
            this.HavePasswordYesCheckBox = new System.Windows.Forms.CheckBox();
            this.HavePasswordNoCheckBox = new System.Windows.Forms.CheckBox();
            this.NameScenarioLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.LabelPanel.SuspendLayout();
            this.SetPasswordPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.FormLabel.Size = new System.Drawing.Size(255, 45);
            this.FormLabel.TabIndex = 1;
            this.FormLabel.Text = "Добавление сценария";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.Color.Black;
            this.LabelPanel.Controls.Add(this.FormLabel);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(744, 60);
            this.LabelPanel.TabIndex = 2;
            // 
            // NewPasswoedLabel
            // 
            this.NewPasswoedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPasswoedLabel.AutoSize = true;
            this.NewPasswoedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswoedLabel.Location = new System.Drawing.Point(20, 4);
            this.NewPasswoedLabel.Name = "NewPasswoedLabel";
            this.NewPasswoedLabel.Size = new System.Drawing.Size(122, 20);
            this.NewPasswoedLabel.TabIndex = 11;
            this.NewPasswoedLabel.Text = "Новый пароль:";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(24, 27);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(700, 26);
            this.NewPasswordTextBox.TabIndex = 12;
            this.NewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RepitPasswordTextBox
            // 
            this.RepitPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepitPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepitPasswordTextBox.Location = new System.Drawing.Point(24, 85);
            this.RepitPasswordTextBox.Name = "RepitPasswordTextBox";
            this.RepitPasswordTextBox.Size = new System.Drawing.Size(700, 26);
            this.RepitPasswordTextBox.TabIndex = 14;
            this.RepitPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RepitPasswordLabel
            // 
            this.RepitPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepitPasswordLabel.AutoSize = true;
            this.RepitPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepitPasswordLabel.Location = new System.Drawing.Point(20, 62);
            this.RepitPasswordLabel.Name = "RepitPasswordLabel";
            this.RepitPasswordLabel.Size = new System.Drawing.Size(156, 20);
            this.RepitPasswordLabel.TabIndex = 13;
            this.RepitPasswordLabel.Text = "Повторить пароль:";
            // 
            // CleanFieldButton
            // 
            this.CleanFieldButton.FlatAppearance.BorderSize = 2;
            this.CleanFieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanFieldButton.Location = new System.Drawing.Point(24, 444);
            this.CleanFieldButton.Name = "CleanFieldButton";
            this.CleanFieldButton.Size = new System.Drawing.Size(347, 30);
            this.CleanFieldButton.TabIndex = 15;
            this.CleanFieldButton.Text = "Очистить поля";
            this.CleanFieldButton.UseVisualStyleBackColor = true;
            this.CleanFieldButton.Click += new System.EventHandler(this.CleanFieldButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(377, 444);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(347, 30);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SetPasswordPanel
            // 
            this.SetPasswordPanel.Controls.Add(this.NewPasswoedLabel);
            this.SetPasswordPanel.Controls.Add(this.NewPasswordTextBox);
            this.SetPasswordPanel.Controls.Add(this.RepitPasswordLabel);
            this.SetPasswordPanel.Controls.Add(this.RepitPasswordTextBox);
            this.SetPasswordPanel.Location = new System.Drawing.Point(0, 276);
            this.SetPasswordPanel.Name = "SetPasswordPanel";
            this.SetPasswordPanel.Size = new System.Drawing.Size(744, 117);
            this.SetPasswordPanel.TabIndex = 17;
            // 
            // NameScenarioTextBox
            // 
            this.NameScenarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameScenarioTextBox.Location = new System.Drawing.Point(24, 133);
            this.NameScenarioTextBox.Name = "NameScenarioTextBox";
            this.NameScenarioTextBox.Size = new System.Drawing.Size(700, 26);
            this.NameScenarioTextBox.TabIndex = 4;
            // 
            // PathScenarioLabel
            // 
            this.PathScenarioLabel.AutoSize = true;
            this.PathScenarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathScenarioLabel.Location = new System.Drawing.Point(20, 165);
            this.PathScenarioLabel.Name = "PathScenarioLabel";
            this.PathScenarioLabel.Size = new System.Drawing.Size(185, 20);
            this.PathScenarioLabel.TabIndex = 5;
            this.PathScenarioLabel.Text = "Путь к файлу загрузки:";
            // 
            // PathScenarioTextBox
            // 
            this.PathScenarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathScenarioTextBox.Location = new System.Drawing.Point(24, 188);
            this.PathScenarioTextBox.Name = "PathScenarioTextBox";
            this.PathScenarioTextBox.Size = new System.Drawing.Size(619, 26);
            this.PathScenarioTextBox.TabIndex = 6;
            // 
            // FileBrowseButton
            // 
            this.FileBrowseButton.FlatAppearance.BorderSize = 2;
            this.FileBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileBrowseButton.Location = new System.Drawing.Point(649, 188);
            this.FileBrowseButton.Name = "FileBrowseButton";
            this.FileBrowseButton.Size = new System.Drawing.Size(75, 26);
            this.FileBrowseButton.TabIndex = 7;
            this.FileBrowseButton.Text = "Обзор...";
            this.FileBrowseButton.UseVisualStyleBackColor = true;
            this.FileBrowseButton.Click += new System.EventHandler(this.FileBrowseButton_Click);
            // 
            // HavePasswordLabel
            // 
            this.HavePasswordLabel.AutoSize = true;
            this.HavePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HavePasswordLabel.Location = new System.Drawing.Point(20, 223);
            this.HavePasswordLabel.Name = "HavePasswordLabel";
            this.HavePasswordLabel.Size = new System.Drawing.Size(271, 20);
            this.HavePasswordLabel.TabIndex = 8;
            this.HavePasswordLabel.Text = "В сценарии используется пароль?";
            // 
            // HavePasswordYesCheckBox
            // 
            this.HavePasswordYesCheckBox.AutoSize = true;
            this.HavePasswordYesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HavePasswordYesCheckBox.Location = new System.Drawing.Point(24, 246);
            this.HavePasswordYesCheckBox.Name = "HavePasswordYesCheckBox";
            this.HavePasswordYesCheckBox.Size = new System.Drawing.Size(49, 24);
            this.HavePasswordYesCheckBox.TabIndex = 9;
            this.HavePasswordYesCheckBox.Text = "Да";
            this.HavePasswordYesCheckBox.UseVisualStyleBackColor = true;
            this.HavePasswordYesCheckBox.CheckedChanged += new System.EventHandler(this.HaveScenarioYesCheckBox_CheckedChanged);
            // 
            // HavePasswordNoCheckBox
            // 
            this.HavePasswordNoCheckBox.AutoSize = true;
            this.HavePasswordNoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HavePasswordNoCheckBox.Location = new System.Drawing.Point(79, 246);
            this.HavePasswordNoCheckBox.Name = "HavePasswordNoCheckBox";
            this.HavePasswordNoCheckBox.Size = new System.Drawing.Size(58, 24);
            this.HavePasswordNoCheckBox.TabIndex = 10;
            this.HavePasswordNoCheckBox.Text = "Нет";
            this.HavePasswordNoCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameScenarioLabel
            // 
            this.NameScenarioLabel.AutoSize = true;
            this.NameScenarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameScenarioLabel.Location = new System.Drawing.Point(20, 110);
            this.NameScenarioLabel.Name = "NameScenarioLabel";
            this.NameScenarioLabel.Size = new System.Drawing.Size(162, 20);
            this.NameScenarioLabel.TabIndex = 3;
            this.NameScenarioLabel.Text = "Название сценария:";
            // 
            // BackButton
            // 
            this.BackButton.FlatAppearance.BorderSize = 2;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(24, 70);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 30);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.AddScenarioBackButton_Click);
            // 
            // AddScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SetPasswordPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CleanFieldButton);
            this.Controls.Add(this.NameScenarioLabel);
            this.Controls.Add(this.HavePasswordNoCheckBox);
            this.Controls.Add(this.HavePasswordYesCheckBox);
            this.Controls.Add(this.HavePasswordLabel);
            this.Controls.Add(this.FileBrowseButton);
            this.Controls.Add(this.PathScenarioTextBox);
            this.Controls.Add(this.PathScenarioLabel);
            this.Controls.Add(this.NameScenarioTextBox);
            this.Controls.Add(this.LabelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddScenarioForm";
            this.Text = "addScenarioForm";
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.SetPasswordPanel.ResumeLayout(false);
            this.SetPasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Label NewPasswoedLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.TextBox RepitPasswordTextBox;
        private System.Windows.Forms.Label RepitPasswordLabel;
        private System.Windows.Forms.Button CleanFieldButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel SetPasswordPanel;
        private System.Windows.Forms.TextBox NameScenarioTextBox;
        private System.Windows.Forms.Label PathScenarioLabel;
        private System.Windows.Forms.TextBox PathScenarioTextBox;
        private System.Windows.Forms.Button FileBrowseButton;
        private System.Windows.Forms.Label HavePasswordLabel;
        private System.Windows.Forms.CheckBox HavePasswordYesCheckBox;
        private System.Windows.Forms.CheckBox HavePasswordNoCheckBox;
        private System.Windows.Forms.Label NameScenarioLabel;
        private System.Windows.Forms.Button BackButton;
    }
}