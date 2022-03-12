
namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms.CustomMessageBox
{
    partial class form_MessageBox_YesNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MessageBox_YesNo));
            this.panel_YesNo = new System.Windows.Forms.Panel();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Yes = new System.Windows.Forms.Button();
            this.panel_Notification = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Warning = new System.Windows.Forms.Label();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Warning = new System.Windows.Forms.PictureBox();
            this.label_MessageString = new System.Windows.Forms.Label();
            this.panel_YesNo.SuspendLayout();
            this.panel_Notification.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_YesNo
            // 
            this.panel_YesNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_YesNo.Controls.Add(this.button_No);
            this.panel_YesNo.Controls.Add(this.button_Yes);
            this.panel_YesNo.Location = new System.Drawing.Point(3, 141);
            this.panel_YesNo.Name = "panel_YesNo";
            this.panel_YesNo.Size = new System.Drawing.Size(606, 53);
            this.panel_YesNo.TabIndex = 0;
            // 
            // button_No
            // 
            this.button_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.button_No.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_No.Location = new System.Drawing.Point(344, 0);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(102, 37);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Yes
            // 
            this.button_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.button_Yes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Yes.Location = new System.Drawing.Point(173, 0);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(102, 37);
            this.button_Yes.TabIndex = 0;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // panel_Notification
            // 
            this.panel_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_Notification.Controls.Add(this.panel1);
            this.panel_Notification.Controls.Add(this.label_MessageString);
            this.panel_Notification.Location = new System.Drawing.Point(3, 0);
            this.panel_Notification.Name = "panel_Notification";
            this.panel_Notification.Size = new System.Drawing.Size(606, 141);
            this.panel_Notification.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label_Warning);
            this.panel1.Controls.Add(this.pictureBox_Close);
            this.panel1.Controls.Add(this.pictureBox_Warning);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 39);
            this.panel1.TabIndex = 2;
            // 
            // label_Warning
            // 
            this.label_Warning.AutoSize = true;
            this.label_Warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_Warning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Warning.Location = new System.Drawing.Point(45, 3);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(102, 33);
            this.label_Warning.TabIndex = 3;
            this.label_Warning.Text = "警告！";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(568, 2);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 2;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Close_MouseEnter);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            // 
            // pictureBox_Warning
            // 
            this.pictureBox_Warning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Warning.Image")));
            this.pictureBox_Warning.Location = new System.Drawing.Point(7, 2);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Warning.TabIndex = 0;
            this.pictureBox_Warning.TabStop = false;
            // 
            // label_MessageString
            // 
            this.label_MessageString.AutoSize = true;
            this.label_MessageString.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_MessageString.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MessageString.Location = new System.Drawing.Point(95, 65);
            this.label_MessageString.Name = "label_MessageString";
            this.label_MessageString.Size = new System.Drawing.Size(180, 44);
            this.label_MessageString.TabIndex = 0;
            this.label_MessageString.Text = "Message";
            // 
            // form_MessageBox_YesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(612, 196);
            this.Controls.Add(this.panel_Notification);
            this.Controls.Add(this.panel_YesNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_MessageBox_YesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_MessageBox_Exit";
            this.panel_YesNo.ResumeLayout(false);
            this.panel_Notification.ResumeLayout(false);
            this.panel_Notification.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_YesNo;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Panel panel_Notification;
        private System.Windows.Forms.Label label_MessageString;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Warning;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label label_Warning;
    }
}