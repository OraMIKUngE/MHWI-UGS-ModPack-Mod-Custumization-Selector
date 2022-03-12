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
    public partial class form_WP_EFX : Form
    {
        //// Directories

        //Debug
        private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\NativePc\\";

        //// Local NativePc path
        //private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Monster Hunter World\\NativePc\\";

        // Custom Path
        private string wpSwoEpvPath = "wp\\swo\\epv\\";
        private string wpSwoEfxPath = "vfx\\efx\\wp\\";

        private string wpLanEfxPath = "vfx\\efx\\mod\\wp_TU\\";

        private string wpHueEpvPath = "wp\\hue\\epv\\";

        private string wpCBEpvPath = "wp\\caxe\\epv\\";

        private string wpHamEpvPath = "wp\\ham\\epv\\";

        // WP EFX files' name
        private string WP_EFX_LS_Trail_EFX_efx_OFF = "wp03_off";
        private string WP_EFX_LS_Trail_EFX_efx_ON = "wp03";

        private string WP_EFX_LS_Trail_EFX_wp_epv_OFF = "hm_wp03_off.epv3";
        private string WP_EFX_LS_Trail_EFX_wp_epv_ON = "hm_wp03.epv3";

        private string WP_EFX_Lan_RedShield_EFX_efx_OFF = "wp01_01_off";
        private string WP_EFX_Lan_RedShield_EFX_efx_ON = "wp01_01";

        private string WP_EFX_Hue_Beat_EFX_wp_epv_OFF = "hm_wp05_off.epv3";
        private string WP_EFX_Hue_Beat_EFX_wp_epv_ON = "hm_wp05.epv3";

        private string WP_EFX_Ham_Blossom_EFX_wp_epv_OFF = "hm_wp04_off.epv3";
        private string WP_EFX_Ham_Blossom_EFX_wp_epv_ON = "hm_wp04.epv3";

        private string WP_EFX_CB_SakuraSAED_EFX_wp_epv_OFF = "hm_wp09_off.epv3";
        private string WP_EFX_CB_SakuraSAED_EFX_wp_epv_ON = "hm_wp09.epv3";
        //// Directories
        


        // Constructor
        public form_WP_EFX()
        {
            InitializeComponent();
        }

        // Form load
        private void form_WP_EFX_Load(object sender, EventArgs e)
        {
            // Properties
            toggleBtn_Lan_RedShield_EFX.Checked = Properties.Settings.Default.LanRedShieldEFXBool;
            toggleBtn_LS_Trail_EFX.Checked = Properties.Settings.Default.LSTrailEFXBool;
            toggleBtn_CB_SakuraSAED_EFX.Checked = Properties.Settings.Default.CBSakuraSAEDEFXBool;
            toggleBtn_Ham_Blossom_EFX.Checked = Properties.Settings.Default.HamBlossomEFXBool;
            toggleBtn_Hue_Beats_EFX.Checked = Properties.Settings.Default.HueBeatEFXBool;
        }

        //// Toggle buttons
        // Lan red shield EFX
        private void toggleBtn_Lan_RedShield_EFX_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string wpLanEfxDir_OFF = Path.Combine(localNaivePcPath + wpLanEfxPath + WP_EFX_Lan_RedShield_EFX_efx_OFF);
            string wpLanEfxDir_ON = Path.Combine(localNaivePcPath + wpLanEfxPath + WP_EFX_Lan_RedShield_EFX_efx_ON);

            // Rename(Move)
            switch (toggleBtn_Lan_RedShield_EFX.Checked)
            {
                case true:
                    if (Directory.Exists(wpLanEfxDir_OFF))
                    {
                        Directory.Move(wpLanEfxDir_OFF, wpLanEfxDir_ON);
                    }
                    break;

                case false:
                    if (Directory.Exists(wpLanEfxDir_ON))
                    {
                        Directory.Move(wpLanEfxDir_ON, wpLanEfxDir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.LanRedShieldEFXBool = toggleBtn_Lan_RedShield_EFX.Checked;
            Properties.Settings.Default.Save();
        }

        // LS trail EFX
        private void toggleBtn_LS_Trail_EFX_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string wpSwoEpvDir_OFF = Path.Combine(localNaivePcPath + wpSwoEpvPath + WP_EFX_LS_Trail_EFX_wp_epv_OFF);
            string wpSwoEfxDir_OFF = Path.Combine(localNaivePcPath + wpSwoEfxPath + WP_EFX_LS_Trail_EFX_efx_OFF);
            string wpSwoEpvDir_ON = Path.Combine(localNaivePcPath + wpSwoEpvPath + WP_EFX_LS_Trail_EFX_wp_epv_ON);
            string wpSwoEfxDir_ON = Path.Combine(localNaivePcPath + wpSwoEfxPath + WP_EFX_LS_Trail_EFX_efx_ON);

            // Rename(Move)
            switch (toggleBtn_LS_Trail_EFX.Checked)
            {
                case true:
                    if (File.Exists(wpSwoEpvDir_OFF) == true && Directory.Exists(wpSwoEfxDir_OFF) == true)
                    {
                        File.Move(wpSwoEpvDir_OFF, wpSwoEpvDir_ON);
                        Directory.Move(wpSwoEfxDir_OFF, wpSwoEfxDir_ON);
                    }
                    break;

                case false:
                    if (File.Exists(wpSwoEpvDir_ON) == true && Directory.Exists(wpSwoEfxDir_ON) == true)
                    {
                        File.Move(wpSwoEpvDir_ON, wpSwoEpvDir_OFF);
                        Directory.Move(wpSwoEfxDir_ON, wpSwoEfxDir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.LSTrailEFXBool = toggleBtn_LS_Trail_EFX.Checked;
            Properties.Settings.Default.Save();
        }

        // Hue beats EFX
        private void toggleBtn_Hue_Beats_EFX_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string wpHueEfxDir_OFF = Path.Combine(localNaivePcPath + wpHueEpvPath + WP_EFX_Hue_Beat_EFX_wp_epv_OFF);
            string wpHueEfxDir_ON = Path.Combine(localNaivePcPath + wpHueEpvPath + WP_EFX_Hue_Beat_EFX_wp_epv_ON);

            // Rename(Move)
            switch (toggleBtn_Hue_Beats_EFX.Checked)
            {
                case true:
                    if (File.Exists(wpHueEfxDir_OFF))
                    {
                        File.Move(wpHueEfxDir_OFF, wpHueEfxDir_ON);
                    }
                    break;

                case false:
                    if (File.Exists(wpHueEfxDir_ON))
                    {
                        File.Move(wpHueEfxDir_ON, wpHueEfxDir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.HueBeatEFXBool = toggleBtn_Hue_Beats_EFX.Checked;
            Properties.Settings.Default.Save();
        }

        // Ham blossom EFX
        private void toggleBtn_Ham_Blossom_EFX_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string wpHamEfxDir_OFF = Path.Combine(localNaivePcPath + wpHamEpvPath + WP_EFX_Ham_Blossom_EFX_wp_epv_OFF);
            string wpHamEfxDir_ON = Path.Combine(localNaivePcPath + wpHamEpvPath + WP_EFX_Ham_Blossom_EFX_wp_epv_ON);

            // Rename(Move)
            switch (toggleBtn_Ham_Blossom_EFX.Checked)
            {
                case true:
                    if (File.Exists(wpHamEfxDir_OFF))
                    {
                        File.Move(wpHamEfxDir_OFF, wpHamEfxDir_ON);
                    }
                    break;

                case false:
                    if (File.Exists(wpHamEfxDir_ON))
                    {
                        File.Move(wpHamEfxDir_ON, wpHamEfxDir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.HamBlossomEFXBool = toggleBtn_Ham_Blossom_EFX.Checked;
            Properties.Settings.Default.Save();
        }

        // CB sakura SAED EFX
        private void toggleBtn_CB_SakuraSAED_EFX_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string wpCBEfxDir_OFF = Path.Combine(localNaivePcPath + wpCBEpvPath + WP_EFX_CB_SakuraSAED_EFX_wp_epv_OFF);
            string wpCBEfxDir_ON = Path.Combine(localNaivePcPath + wpCBEpvPath + WP_EFX_CB_SakuraSAED_EFX_wp_epv_ON);

            // Rename(Move)
            switch (toggleBtn_CB_SakuraSAED_EFX.Checked)
            {
                case true:
                    if (File.Exists(wpCBEfxDir_OFF))
                    {
                        File.Move(wpCBEfxDir_OFF, wpCBEfxDir_ON);
                    }
                    break;

                case false:
                    if (File.Exists(wpCBEfxDir_ON))
                    {
                        File.Move(wpCBEfxDir_ON, wpCBEfxDir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.CBSakuraSAEDEFXBool = toggleBtn_CB_SakuraSAED_EFX.Checked;
            Properties.Settings.Default.Save();
        }
        //// Toggle buttons
    }
}
