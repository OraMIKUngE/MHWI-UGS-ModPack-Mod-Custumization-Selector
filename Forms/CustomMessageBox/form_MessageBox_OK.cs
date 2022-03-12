using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms.CustomMessageBox
{
    public partial class form_MessageBox_OK : Form
    {
        public form_MessageBox_OK()
        {
            InitializeComponent();
        }

        public string MessageString
        {
            get { return label_MessageString.Text; }
            set { label_MessageString.Text = value; }
        }

        private void pictureBox_Close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Close.BackColor = Color.FromArgb(75, 142, 238);
        }

        private void pictureBox_Close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Close.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();

            Properties.Settings.Default.Exit = false;
            Properties.Settings.Default.Restart = false;
            Properties.Settings.Default.Save();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
