namespace SimpleUserInterface
{
    partial class LightDeviceForm
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
            this.ControlPanel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.LablePanel = new System.Windows.Forms.Panel();
            this.ControlPanel2 = new System.Windows.Forms.Panel();
            this.DeleteFieldButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoText = new System.Windows.Forms.Label();
            this.ControlPanel1.SuspendLayout();
            this.LablePanel.SuspendLayout();
            this.ControlPanel2.SuspendLayout();
            this.InfoPanel.SuspendLayout();
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
            this.FormLabel.Size = new System.Drawing.Size(271, 45);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "?Название устройства?";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ControlPanel1
            // 
            this.ControlPanel1.Controls.Add(this.BackButton);
            this.ControlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel1.Location = new System.Drawing.Point(0, 60);
            this.ControlPanel1.Name = "ControlPanel1";
            this.ControlPanel1.Size = new System.Drawing.Size(744, 45);
            this.ControlPanel1.TabIndex = 30;
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
            // LablePanel
            // 
            this.LablePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LablePanel.Controls.Add(this.FormLabel);
            this.LablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LablePanel.Location = new System.Drawing.Point(0, 0);
            this.LablePanel.Name = "LablePanel";
            this.LablePanel.Size = new System.Drawing.Size(744, 60);
            this.LablePanel.TabIndex = 29;
            // 
            // ControlPanel2
            // 
            this.ControlPanel2.Controls.Add(this.DeleteFieldButton);
            this.ControlPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel2.Location = new System.Drawing.Point(0, 438);
            this.ControlPanel2.Name = "ControlPanel2";
            this.ControlPanel2.Size = new System.Drawing.Size(744, 63);
            this.ControlPanel2.TabIndex = 31;
            // 
            // DeleteFieldButton
            // 
            this.DeleteFieldButton.FlatAppearance.BorderSize = 2;
            this.DeleteFieldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFieldButton.Location = new System.Drawing.Point(198, 6);
            this.DeleteFieldButton.Name = "DeleteFieldButton";
            this.DeleteFieldButton.Size = new System.Drawing.Size(347, 30);
            this.DeleteFieldButton.TabIndex = 23;
            this.DeleteFieldButton.Text = "Удалить";
            this.DeleteFieldButton.UseVisualStyleBackColor = true;
            this.DeleteFieldButton.Click += new System.EventHandler(this.DeleteFieldButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.InfoText);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 105);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.InfoPanel.Size = new System.Drawing.Size(744, 96);
            this.InfoPanel.TabIndex = 33;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoText.Location = new System.Drawing.Point(20, 5);
            this.InfoText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(491, 60);
            this.InfoText.TabIndex = 0;
            this.InfoText.Text = "Тип: Освещение\r\nСценарий поведения: Систма контроля периметра\r\nМесто размещения: " +
    "Россия, Москва, Проспект Вернадского, 78\r\n";
            // 
            // LightDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.ControlPanel1);
            this.Controls.Add(this.LablePanel);
            this.Controls.Add(this.ControlPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LightDeviceForm";
            this.Text = "LightDeviceForm";
            this.ControlPanel1.ResumeLayout(false);
            this.LablePanel.ResumeLayout(false);
            this.LablePanel.PerformLayout();
            this.ControlPanel2.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Panel ControlPanel1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel LablePanel;
        private System.Windows.Forms.Panel ControlPanel2;
        private System.Windows.Forms.Button DeleteFieldButton;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label InfoText;
    }
}