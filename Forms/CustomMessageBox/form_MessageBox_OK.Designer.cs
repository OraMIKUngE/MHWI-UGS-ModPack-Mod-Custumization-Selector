
namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms.CustomMessageBox
{
    partial class form_MessageBox_OK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MessageBox_OK));
            this.panel_YesNo = new System.Windows.Forms.Panel();
            this.btn_OK = new System.Windows.Forms.Button();
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
            this.panel_YesNo.Controls.Add(this.btn_OK);
            this.panel_YesNo.Location = new System.Drawing.Point(4, 174);
            this.panel_YesNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_YesNo.Name = "panel_YesNo";
            this.panel_YesNo.Size = new System.Drawing.Size(808, 66);
            this.panel_YesNo.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OK.Location = new System.Drawing.Point(340, 0);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(136, 46);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panel_Notification
            // 
            this.panel_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_Notification.Controls.Add(this.panel1);
            this.panel_Notification.Controls.Add(this.label_MessageString);
            this.panel_Notification.Location = new System.Drawing.Point(4, 0);
            this.panel_Notification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Notification.Name = "panel_Notification";
            this.panel_Notification.Size = new System.Drawing.Size(808, 174);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 48);
            this.panel1.TabIndex = 2;
            // 
            // label_Warning
            // 
            this.label_Warning.AutoSize = true;
            this.label_Warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_Warning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Warning.Location = new System.Drawing.Point(60, 4);
            this.label_Warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Warning.Name = "label_Warning";
            this.label_Warning.Size = new System.Drawing.Size(129, 42);
            this.label_Warning.TabIndex = 3;
            this.label_Warning.Text = "警告！";
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(757, 2);
            this.pictureBox_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(47, 43);
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
            this.pictureBox_Warning.Location = new System.Drawing.Point(9, 2);
            this.pictureBox_Warning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Warning.Name = "pictureBox_Warning";
            this.pictureBox_Warning.Size = new System.Drawing.Size(47, 43);
            this.pictureBox_Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Warning.TabIndex = 0;
            this.pictureBox_Warning.TabStop = false;
            // 
            // label_MessageString
            // 
            this.label_MessageString.AutoSize = true;
            this.label_MessageString.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.325F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_MessageString.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MessageString.Location = new System.Drawing.Point(27, 89);
            this.label_MessageString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MessageString.Name = "label_MessageString";
            this.label_MessageString.Size = new System.Drawing.Size(180, 44);
            this.label_MessageString.TabIndex = 0;
            this.label_MessageString.Text = "Message";
            // 
            // form_MessageBox_OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 241);
            this.Controls.Add(this.panel_Notification);
            this.Controls.Add(this.panel_YesNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_MessageBox_OK";
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
        private System.Windows.Forms.Panel panel_Notification;
        private System.Windows.Forms.Label label_MessageString;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Warning;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label label_Warning;
        public System.Windows.Forms.Button btn_OK;
    }
}