
namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms
{
    partial class form_WP_SFX
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
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.toggleBtn_Hue_Lust_SFX = new MHWI_UGS_ModPack_Mod_Custumization_Selector.CustomControls.ToggleBtn();
            this.panel_Labels = new System.Windows.Forms.Panel();
            this.label_Hue_Lust_SFX = new System.Windows.Forms.Label();
            this.panel_Controls.SuspendLayout();
            this.panel_Labels.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Controls
            // 
            this.panel_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_Controls.Controls.Add(this.toggleBtn_Hue_Lust_SFX);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Controls.Location = new System.Drawing.Point(1063, 0);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(163, 712);
            this.panel_Controls.TabIndex = 26;
            // 
            // toggleBtn_Hue_Lust_SFX
            // 
            this.toggleBtn_Hue_Lust_SFX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleBtn_Hue_Lust_SFX.FlatAppearance.BorderSize = 0;
            this.toggleBtn_Hue_Lust_SFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleBtn_Hue_Lust_SFX.Location = new System.Drawing.Point(60, 19);
            this.toggleBtn_Hue_Lust_SFX.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleBtn_Hue_Lust_SFX.Name = "toggleBtn_Hue_Lust_SFX";
            this.toggleBtn_Hue_Lust_SFX.OffBackColor = System.Drawing.Color.DimGray;
            this.toggleBtn_Hue_Lust_SFX.OffToggleColor = System.Drawing.Color.Black;
            this.toggleBtn_Hue_Lust_SFX.OnBackColor = System.Drawing.Color.White;
            this.toggleBtn_Hue_Lust_SFX.OnToggleColor = System.Drawing.Color.Gray;
            this.toggleBtn_Hue_Lust_SFX.Size = new System.Drawing.Size(91, 43);
            this.toggleBtn_Hue_Lust_SFX.TabIndex = 20;
            this.toggleBtn_Hue_Lust_SFX.Text = "toggleBtn1";
            this.toggleBtn_Hue_Lust_SFX.UseVisualStyleBackColor = true;
            this.toggleBtn_Hue_Lust_SFX.CheckedChanged += new System.EventHandler(this.toggleBtn_Hue_Lust_SFX_CheckedChanged);
            // 
            // panel_Labels
            // 
            this.panel_Labels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel_Labels.Controls.Add(this.label_Hue_Lust_SFX);
            this.panel_Labels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Labels.Location = new System.Drawing.Point(0, 0);
            this.panel_Labels.Name = "panel_Labels";
            this.panel_Labels.Size = new System.Drawing.Size(1226, 712);
            this.panel_Labels.TabIndex = 25;
            // 
            // label_Hue_Lust_SFX
            // 
            this.label_Hue_Lust_SFX.AutoSize = true;
            this.label_Hue_Lust_SFX.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Hue_Lust_SFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Hue_Lust_SFX.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hue_Lust_SFX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Hue_Lust_SFX.Location = new System.Drawing.Point(0, 0);
            this.label_Hue_Lust_SFX.Name = "label_Hue_Lust_SFX";
            this.label_Hue_Lust_SFX.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label_Hue_Lust_SFX.Size = new System.Drawing.Size(322, 65);
            this.label_Hue_Lust_SFX.TabIndex = 23;
            this.label_Hue_Lust_SFX.Text = "笛子特殊音效";
            // 
            // form_WP_SFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1226, 712);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.panel_Labels);
            this.MaximizeBox = false;
            this.Name = "form_WP_SFX";
            this.Text = "WP_SFX_Form";
            this.Load += new System.EventHandler(this.form_WP_SFX_Load);
            this.panel_Controls.ResumeLayout(false);
            this.panel_Labels.ResumeLayout(false);
            this.panel_Labels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Panel panel_Labels;
        private System.Windows.Forms.Label label_Hue_Lust_SFX;
        public CustomControls.ToggleBtn toggleBtn_Hue_Lust_SFX;
    }
}