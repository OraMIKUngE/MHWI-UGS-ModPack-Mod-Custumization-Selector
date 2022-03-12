
namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms
{
    partial class form_Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Splash));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.label_ProgressBar = new System.Windows.Forms.Label();
            this.label_Loading = new System.Windows.Forms.Label();
            this.panel_ProgressFrm = new System.Windows.Forms.Panel();
            this.panel_ProgressBar = new System.Windows.Forms.Panel();
            this.pictureBox_P_UGS_Customization = new System.Windows.Forms.PictureBox();
            this.timer_Progress = new System.Windows.Forms.Timer(this.components);
            this.timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.timer_ClosingFadeOut = new System.Windows.Forms.Timer(this.components);
            this.panel_Main.SuspendLayout();
            this.panel_ProgressFrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P_UGS_Customization)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.Black;
            this.panel_Main.Controls.Add(this.label_ProgressBar);
            this.panel_Main.Controls.Add(this.label_Loading);
            this.panel_Main.Controls.Add(this.panel_ProgressFrm);
            this.panel_Main.Controls.Add(this.pictureBox_P_UGS_Customization);
            this.panel_Main.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel_Main.Location = new System.Drawing.Point(1, 1);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(661, 451);
            this.panel_Main.TabIndex = 0;
            // 
            // label_ProgressBar
            // 
            this.label_ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ProgressBar.AutoSize = true;
            this.label_ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_ProgressBar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_ProgressBar.Location = new System.Drawing.Point(589, 394);
            this.label_ProgressBar.Name = "label_ProgressBar";
            this.label_ProgressBar.Size = new System.Drawing.Size(68, 25);
            this.label_ProgressBar.TabIndex = 3;
            this.label_ProgressBar.Text = "100 %";
            // 
            // label_Loading
            // 
            this.label_Loading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Loading.AutoSize = true;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_Loading.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Loading.Location = new System.Drawing.Point(3, 394);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(82, 25);
            this.label_Loading.TabIndex = 2;
            this.label_Loading.Text = "Loading";
            // 
            // panel_ProgressFrm
            // 
            this.panel_ProgressFrm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_ProgressFrm.Controls.Add(this.panel_ProgressBar);
            this.panel_ProgressFrm.Location = new System.Drawing.Point(1, 440);
            this.panel_ProgressFrm.MaximumSize = new System.Drawing.Size(661, 10);
            this.panel_ProgressFrm.Name = "panel_ProgressFrm";
            this.panel_ProgressFrm.Size = new System.Drawing.Size(661, 10);
            this.panel_ProgressFrm.TabIndex = 1;
            // 
            // panel_ProgressBar
            // 
            this.panel_ProgressBar.AutoSize = true;
            this.panel_ProgressBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_ProgressBar.Location = new System.Drawing.Point(1, -1);
            this.panel_ProgressBar.MaximumSize = new System.Drawing.Size(661, 10);
            this.panel_ProgressBar.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel_ProgressBar.Name = "panel_ProgressBar";
            this.panel_ProgressBar.Size = new System.Drawing.Size(10, 10);
            this.panel_ProgressBar.TabIndex = 2;
            // 
            // pictureBox_P_UGS_Customization
            // 
            this.pictureBox_P_UGS_Customization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_P_UGS_Customization.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_P_UGS_Customization.Image")));
            this.pictureBox_P_UGS_Customization.Location = new System.Drawing.Point(203, 63);
            this.pictureBox_P_UGS_Customization.Name = "pictureBox_P_UGS_Customization";
            this.pictureBox_P_UGS_Customization.Size = new System.Drawing.Size(256, 256);
            this.pictureBox_P_UGS_Customization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_P_UGS_Customization.TabIndex = 0;
            this.pictureBox_P_UGS_Customization.TabStop = false;
            // 
            // timer_Progress
            // 
            this.timer_Progress.Enabled = true;
            this.timer_Progress.Tick += new System.EventHandler(this.timer_Progress_Tick);
            // 
            // timer_Loading
            // 
            this.timer_Loading.Enabled = true;
            this.timer_Loading.Interval = 1000;
            this.timer_Loading.Tick += new System.EventHandler(this.timer_LabelDataInitializing_Tick);
            // 
            // timer_ClosingFadeOut
            // 
            this.timer_ClosingFadeOut.Enabled = true;
            this.timer_ClosingFadeOut.Interval = 50;
            this.timer_ClosingFadeOut.Tick += new System.EventHandler(this.timer_ClosingFadeOut_Tick);
            // 
            // form_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(142)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Splash";
            this.Load += new System.EventHandler(this.form_Splash_Load);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            this.panel_ProgressFrm.ResumeLayout(false);
            this.panel_ProgressFrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_P_UGS_Customization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pictureBox_P_UGS_Customization;
        private System.Windows.Forms.Panel panel_ProgressFrm;
        private System.Windows.Forms.Panel panel_ProgressBar;
        private System.Windows.Forms.Label label_Loading;
        private System.Windows.Forms.Timer timer_Progress;
        public System.Windows.Forms.Label label_ProgressBar;
        private System.Windows.Forms.Timer timer_Loading;
        private System.Windows.Forms.Timer timer_ClosingFadeOut;
    }
}