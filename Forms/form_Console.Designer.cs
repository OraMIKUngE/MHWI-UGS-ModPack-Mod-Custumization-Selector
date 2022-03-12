
namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms
{
    partial class form_Console
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
            this.label_BrowsePath = new System.Windows.Forms.Label();
            this.panel_Browser = new System.Windows.Forms.Panel();
            this.label_MH_Root = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_DataAnalyze = new System.Windows.Forms.Panel();
            this.label_FileInfo = new System.Windows.Forms.Label();
            this.panel_Browser.SuspendLayout();
            this.panel_DataAnalyze.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_BrowsePath
            // 
            this.label_BrowsePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_BrowsePath.AutoEllipsis = true;
            this.label_BrowsePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_BrowsePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_BrowsePath.Font = new System.Drawing.Font("Arial", 0.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.label_BrowsePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_BrowsePath.Location = new System.Drawing.Point(250, 35);
            this.label_BrowsePath.Name = "label_BrowsePath";
            this.label_BrowsePath.Size = new System.Drawing.Size(964, 31);
            this.label_BrowsePath.TabIndex = 4;
            this.label_BrowsePath.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel_Browser
            // 
            this.panel_Browser.Controls.Add(this.label_MH_Root);
            this.panel_Browser.Controls.Add(this.label1);
            this.panel_Browser.Controls.Add(this.label_BrowsePath);
            this.panel_Browser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Browser.Location = new System.Drawing.Point(0, 0);
            this.panel_Browser.Name = "panel_Browser";
            this.panel_Browser.Size = new System.Drawing.Size(1226, 99);
            this.panel_Browser.TabIndex = 7;
            // 
            // label_MH_Root
            // 
            this.label_MH_Root.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_MH_Root.Font = new System.Drawing.Font("Arial", 0.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_MH_Root.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MH_Root.Location = new System.Drawing.Point(46, 34);
            this.label_MH_Root.Name = "label_MH_Root";
            this.label_MH_Root.Size = new System.Drawing.Size(198, 31);
            this.label_MH_Root.TabIndex = 10;
            this.label_MH_Root.Text = "魔物根目錄 =>";
            this.label_MH_Root.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // panel_DataAnalyze
            // 
            this.panel_DataAnalyze.AutoScroll = true;
            this.panel_DataAnalyze.Controls.Add(this.label_FileInfo);
            this.panel_DataAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DataAnalyze.Location = new System.Drawing.Point(0, 99);
            this.panel_DataAnalyze.Name = "panel_DataAnalyze";
            this.panel_DataAnalyze.Size = new System.Drawing.Size(1226, 613);
            this.panel_DataAnalyze.TabIndex = 8;
            // 
            // label_FileInfo
            // 
            this.label_FileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_FileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FileInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_FileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(136)));
            this.label_FileInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_FileInfo.Location = new System.Drawing.Point(0, 0);
            this.label_FileInfo.Name = "label_FileInfo";
            this.label_FileInfo.Size = new System.Drawing.Size(1226, 613);
            this.label_FileInfo.TabIndex = 1;
            // 
            // form_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1226, 712);
            this.Controls.Add(this.panel_DataAnalyze);
            this.Controls.Add(this.panel_Browser);
            this.MaximizeBox = false;
            this.Name = "form_Console";
            this.Text = "form_Console";
            this.Load += new System.EventHandler(this.form_Console_Load);
            this.panel_Browser.ResumeLayout(false);
            this.panel_Browser.PerformLayout();
            this.panel_DataAnalyze.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label_BrowsePath;
        private System.Windows.Forms.Panel panel_Browser;
        private System.Windows.Forms.Panel panel_DataAnalyze;
        private System.Windows.Forms.Label label_MH_Root;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FileInfo;
    }
}