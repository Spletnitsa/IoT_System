namespace SimpleUserInterface
{
    partial class ControlScenarioForm
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
            this.ControlPanel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.LablePanel = new System.Windows.Forms.Panel();
            this.FormLabel = new System.Windows.Forms.Label();
            this.ControlPanel2 = new System.Windows.Forms.Panel();
            this.UploadButton = new System.Windows.Forms.Button();
            this.DeleteScenarioButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.UploadSatusLabel = new System.Windows.Forms.Label();
            this.MoreInfoButton = new System.Windows.Forms.Button();
            this.InfoText = new System.Windows.Forms.Label();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.ChangePasswordLabelPanel = new System.Windows.Forms.Panel();
            this.ChangePasswordPanel = new System.Windows.Forms.Panel();
            this.ConfirmCahngePasswordButton = new System.Windows.Forms.Button();
            this.NewPasswoedLabel = new System.Windows.Forms.Label();
            this.NewPasswoedTextBox = new System.Windows.Forms.TextBox();
            this.RepitPasswordLabel = new System.Windows.Forms.Label();
            this.RepitPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ControlPanel1.SuspendLayout();
            this.LablePanel.SuspendLayout();
            this.ControlPanel2.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.ChangePasswordLabelPanel.SuspendLayout();
            this.ChangePasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPanel1
            // 
            this.ControlPanel1.Controls.Add(this.BackButton);
            this.ControlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel1.Location = new System.Drawing.Point(0, 60);
            this.ControlPanel1.Name = "ControlPanel1";
            this.ControlPanel1.Size = new System.Drawing.Size(744, 45);
            this.ControlPanel1.TabIndex = 27;
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
            this.BackButton.Click += new System.EventHandler(this.ControlScenarioBackButton_Click);
            // 
            // LablePanel
            // 
            this.LablePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LablePanel.Controls.Add(this.FormLabel);
            this.LablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LablePanel.Location = new System.Drawing.Point(0, 0);
            this.LablePanel.Name = "LablePanel";
            this.LablePanel.Size = new System.Drawing.Size(744, 60);
            this.LablePanel.TabIndex = 26;
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
            this.FormLabel.Size = new System.Drawing.Size(253, 45);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "?Название сценария?";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ControlPanel2
            // 
            this.ControlPanel2.Controls.Add(this.UploadButton);
            this.ControlPanel2.Controls.Add(this.DeleteScenarioButton);
            this.ControlPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel2.Location = new System.Drawing.Point(0, 438);
            this.ControlPanel2.Name = "ControlPanel2";
            this.ControlPanel2.Size = new System.Drawing.Size(744, 63);
            this.ControlPanel2.TabIndex = 28;
            // 
            // UploadButton
            // 
            this.UploadButton.FlatAppearance.BorderSize = 2;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(377, 6);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(347, 30);
            this.UploadButton.TabIndex = 24;
            this.UploadButton.Text = "Загрузить";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // DeleteScenarioButton
            // 
            this.DeleteScenarioButton.FlatAppearance.BorderSize = 2;
            this.DeleteScenarioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteScenarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteScenarioButton.Location = new System.Drawing.Point(24, 6);
            this.DeleteScenarioButton.Name = "DeleteScenarioButton";
            this.DeleteScenarioButton.Size = new System.Drawing.Size(347, 30);
            this.DeleteScenarioButton.TabIndex = 23;
            this.DeleteScenarioButton.Text = "Удалить";
            this.DeleteScenarioButton.UseVisualStyleBackColor = true;
            this.DeleteScenarioButton.Click += new System.EventHandler(this.DeleteScenarioButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.UploadSatusLabel);
            this.InfoPanel.Controls.Add(this.MoreInfoButton);
            this.InfoPanel.Controls.Add(this.InfoText);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 105);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.InfoPanel.Size = new System.Drawing.Size(744, 96);
            this.InfoPanel.TabIndex = 29;
            // 
            // UploadSatusLabel
            // 
            this.UploadSatusLabel.AutoSize = true;
            this.UploadSatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadSatusLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.UploadSatusLabel.Location = new System.Drawing.Point(20, 6);
            this.UploadSatusLabel.Name = "UploadSatusLabel";
            this.UploadSatusLabel.Size = new System.Drawing.Size(198, 20);
            this.UploadSatusLabel.TabIndex = 26;
            this.UploadSatusLabel.Text = "Сценарий не загружен";
            // 
            // MoreInfoButton
            // 
            this.MoreInfoButton.FlatAppearance.BorderSize = 2;
            this.MoreInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreInfoButton.Location = new System.Drawing.Point(24, 59);
            this.MoreInfoButton.Name = "MoreInfoButton";
            this.MoreInfoButton.Size = new System.Drawing.Size(173, 30);
            this.MoreInfoButton.TabIndex = 24;
            this.MoreInfoButton.Text = "Узнать подробнее";
            this.MoreInfoButton.UseVisualStyleBackColor = true;
            this.MoreInfoButton.Click += new System.EventHandler(this.MoreInfoButton_Click);
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoText.Location = new System.Drawing.Point(20, 31);
            this.InfoText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(549, 20);
            this.InfoText.TabIndex = 0;
            this.InfoText.Text = "Перед загрузкой необходимо ознакомиться с инстркуцией к сценарию!";
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordLabel.Location = new System.Drawing.Point(20, 10);
            this.ChangePasswordLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(148, 20);
            this.ChangePasswordLabel.TabIndex = 15;
            this.ChangePasswordLabel.Text = "Сменить пароль ˅";
            this.ChangePasswordLabel.Click += new System.EventHandler(this.ChangePasswordLabel_Click);
            // 
            // ChangePasswordLabelPanel
            // 
            this.ChangePasswordLabelPanel.Controls.Add(this.ChangePasswordLabel);
            this.ChangePasswordLabelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangePasswordLabelPanel.Location = new System.Drawing.Point(0, 201);
            this.ChangePasswordLabelPanel.Name = "ChangePasswordLabelPanel";
            this.ChangePasswordLabelPanel.Size = new System.Drawing.Size(744, 40);
            this.ChangePasswordLabelPanel.TabIndex = 30;
            // 
            // ChangePasswordPanel
            // 
            this.ChangePasswordPanel.Controls.Add(this.ConfirmCahngePasswordButton);
            this.ChangePasswordPanel.Controls.Add(this.NewPasswoedLabel);
            this.ChangePasswordPanel.Controls.Add(this.NewPasswoedTextBox);
            this.ChangePasswordPanel.Controls.Add(this.RepitPasswordLabel);
            this.ChangePasswordPanel.Controls.Add(this.RepitPasswordTextBox);
            this.ChangePasswordPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangePasswordPanel.Location = new System.Drawing.Point(0, 241);
            this.ChangePasswordPanel.Name = "ChangePasswordPanel";
            this.ChangePasswordPanel.Size = new System.Drawing.Size(744, 155);
            this.ChangePasswordPanel.TabIndex = 31;
            // 
            // ConfirmCahngePasswordButton
            // 
            this.ConfirmCahngePasswordButton.FlatAppearance.BorderSize = 2;
            this.ConfirmCahngePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmCahngePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCahngePasswordButton.Location = new System.Drawing.Point(24, 119);
            this.ConfirmCahngePasswordButton.Name = "ConfirmCahngePasswordButton";
            this.ConfirmCahngePasswordButton.Size = new System.Drawing.Size(347, 30);
            this.ConfirmCahngePasswordButton.TabIndex = 25;
            this.ConfirmCahngePasswordButton.Text = "Подтвердить смену пароля";
            this.ConfirmCahngePasswordButton.UseVisualStyleBackColor = true;
            this.ConfirmCahngePasswordButton.Click += new System.EventHandler(this.ConfirmChangePasswordButton_Click);
            // 
            // NewPasswoedLabel
            // 
            this.NewPasswoedLabel.AutoSize = true;
            this.NewPasswoedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswoedLabel.Location = new System.Drawing.Point(20, 4);
            this.NewPasswoedLabel.Name = "NewPasswoedLabel";
            this.NewPasswoedLabel.Size = new System.Drawing.Size(122, 20);
            this.NewPasswoedLabel.TabIndex = 11;
            this.NewPasswoedLabel.Text = "Новый пароль:";
            // 
            // NewPasswoedTextBox
            // 
            this.NewPasswoedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPasswoedTextBox.Location = new System.Drawing.Point(24, 27);
            this.NewPasswoedTextBox.Name = "NewPasswoedTextBox";
            this.NewPasswoedTextBox.Size = new System.Drawing.Size(700, 26);
            this.NewPasswoedTextBox.TabIndex = 12;
            this.NewPasswoedTextBox.UseSystemPasswordChar = true;
            // 
            // RepitPasswordLabel
            // 
            this.RepitPasswordLabel.AutoSize = true;
            this.RepitPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepitPasswordLabel.Location = new System.Drawing.Point(20, 62);
            this.RepitPasswordLabel.Name = "RepitPasswordLabel";
            this.RepitPasswordLabel.Size = new System.Drawing.Size(156, 20);
            this.RepitPasswordLabel.TabIndex = 13;
            this.RepitPasswordLabel.Text = "Повторить пароль:";
            // 
            // RepitPasswordTextBox
            // 
            this.RepitPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepitPasswordTextBox.Location = new System.Drawing.Point(24, 85);
            this.RepitPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.RepitPasswordTextBox.Name = "RepitPasswordTextBox";
            this.RepitPasswordTextBox.Size = new System.Drawing.Size(700, 26);
            this.RepitPasswordTextBox.TabIndex = 14;
            this.RepitPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ControlScenarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.ChangePasswordPanel);
            this.Controls.Add(this.ChangePasswordLabelPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.ControlPanel1);
            this.Controls.Add(this.LablePanel);
            this.Controls.Add(this.ControlPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlScenarioForm";
            this.Text = "ControllScenarioForm";
            this.Load += new System.EventHandler(this.ControlScenarioForm_Load);
            this.ControlPanel1.ResumeLayout(false);
            this.LablePanel.ResumeLayout(false);
            this.LablePanel.PerformLayout();
            this.ControlPanel2.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ChangePasswordLabelPanel.ResumeLayout(false);
            this.ChangePasswordLabelPanel.PerformLayout();
            this.ChangePasswordPanel.ResumeLayout(false);
            this.ChangePasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel LablePanel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Panel ControlPanel2;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button DeleteScenarioButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Button MoreInfoButton;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Panel ChangePasswordLabelPanel;
        private System.Windows.Forms.Panel ChangePasswordPanel;
        private System.Windows.Forms.Label NewPasswoedLabel;
        private System.Windows.Forms.TextBox NewPasswoedTextBox;
        private System.Windows.Forms.Label RepitPasswordLabel;
        private System.Windows.Forms.TextBox RepitPasswordTextBox;
        private System.Windows.Forms.Button ConfirmCahngePasswordButton;
        private System.Windows.Forms.Label UploadSatusLabel;
    }
}