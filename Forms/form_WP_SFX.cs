using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms
{
    public partial class form_WP_SFX : Form
    {
        //// Directories

        //Debug
        private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\NativePc\\";

        //// Local NativePc path
        //private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Monster Hunter World\\NativePc\\";

        // Custom Path
        private string wpHueSFXPath = "sound\\wwise\\Windows\\";

        // WP SFX files' name
        private string WP_SFX_Hue_Lust_sound_OFF = "wp_hue_026_off.nbnk";
        private string WP_SFX_Hue_Lust_sound_ON = "wp_hue_026.nbnk";

        // Constructor
        public form_WP_SFX()
        {
            InitializeComponent();
        }

        // Form load
        private void form_WP_SFX_Load(object sender, EventArgs e)
        {
            // Properties
            toggleBtn_Hue_Lust_SFX.Checked = Properties.Settings.Default.HueLustSFXBool;
        }
        //// Directories
        


        //// Toggle buttons
        // Hue Lust SFX
        private void toggleBtn_Hue_Lust_SFX_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string WP_SFX_Hue_Lust_sound_Dir_OFF = Path.Combine(localNaivePcPath + wpHueSFXPath + WP_SFX_Hue_Lust_sound_OFF);
            string WP_SFX_Hue_Lust_sound_Dir_ON = Path.Combine(localNaivePcPath + wpHueSFXPath + WP_SFX_Hue_Lust_sound_ON);

            // Rename(Move)
            switch (toggleBtn_Hue_Lust_SFX.Checked)
            {
                case true:
                    if (File.Exists(WP_SFX_Hue_Lust_sound_Dir_OFF))
                    {
                        File.Move(WP_SFX_Hue_Lust_sound_Dir_OFF, WP_SFX_Hue_Lust_sound_Dir_ON);
                    }
                    break;

                case false:
                    if (File.Exists(WP_SFX_Hue_Lust_sound_Dir_ON))
                    {
                        File.Move(WP_SFX_Hue_Lust_sound_Dir_ON, WP_SFX_Hue_Lust_sound_Dir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.HueLustSFXBool = toggleBtn_Hue_Lust_SFX.Checked;
            Properties.Settings.Default.Save();
        }
        //// Toggle buttons
    }
}
