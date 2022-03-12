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

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms.CustomMessageBox
{
    public partial class form_MessageBox_YesNo : Form
    {
        //// Directories
        // Local NativePc debug path
        private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\NativePc\\";

        //// Local NativePc path
        //private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Monster Hunter World\\NativePc\\";

        // Custom Path
        private string questBoardTexPath = "ui\\quest\\tex\\";

        private string hudPath = "ui\\hud\\tex\\";

        private string wpSwoEpvPath = "wp\\swo\\epv\\";
        private string wpSwoEfxPath = "vfx\\efx\\wp\\";

        private string wpLanEfxPath = "vfx\\efx\\mod\\wp_TU\\";

        private string wpHueEpvPath = "wp\\hue\\epv\\";
        private string wpHueSFXPath = "sound\\wwise\\Windows\\";

        private string wpCBEpvPath = "wp\\caxe\\epv\\";

        private string wpHamEpvPath = "wp\\ham\\epv\\";

        private string controlPluginsPath = "plugins\\ControlFolder\\";
        private string pluginsPath = "plugins\\";

        // Quest board files' name
        private string QBT_Boosette = "Boosette\\quest_paper00_ID.tex";
        private string QBT_Ina = "Ina\\quest_paper00_ID.tex";
        private string QBT_LBC = "LBC\\quest_paper00_ID.tex";
        private string QBT_MAH_01 = "MAH_V1\\quest_paper00_ID.tex";
        private string QBT_MAH_02 = "MAH_V2\\quest_paper00_ID.tex";
        private string QBT_MHWI_Trailer_IMG = "MHWI_Trailer_IMG\\quest_paper00_ID.tex";

        // Hud file' name
        private string hud_UGS_Clock_EFX_tex_OFF = "hud_eff00_ID_off.tex";
        private string hud_UGS_Clock_EFX_tex_ON = "hud_eff00_ID.tex";
        private string hud_UGS_Clock_tex_OFF = "hud00_ID_off.tex";
        private string hud_UGS_Clock_tex_ON = "hud00_ID.tex";

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

        // WP SFX files' name
        private string WP_SFX_Hue_Lust_sound_OFF = "wp_hue_026_off.nbnk";
        private string WP_SFX_Hue_Lust_sound_ON = "wp_hue_026.nbnk";

        // For cheking quest board custom on or off
        private string quest_paper00_ID_OFF = "quest_paper00_ID_off.tex";
        private string quest_paper00_ID_ON = "quest_paper00_ID.tex";
        private string quest_paper01_ID_OFF = "quest_paper01_ID_off.tex";
        private string quest_paper01_ID_ON = "quest_paper01_ID.tex";
        private string quest_paper02_ID_OFF = "quest_paper02_ID_off.tex";
        private string quest_paper02_ID_ON = "quest_paper02_ID.tex";

        // Plugins' name
        private string BehemothDamage = "BehemothDamage.dll";
        private string MantleRemover = "MantleRemover.dll";
        //// Directories

        // Constructor
        public form_MessageBox_YesNo()
        {
            InitializeComponent();
        }

        // Properties
        public string MessageString
        {
            get { return label_MessageString.Text; }
            set { label_MessageString.Text = value; }
        }

        // Btn Click
        private void button_Yes_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Exit == true)
            {
                Properties.Settings.Default.Exit = false;
                Properties.Settings.Default.Save();

                Application.Exit();
            }

            if (Properties.Settings.Default.Restart == true)
            {
                Properties.Settings.Default.Restart = false;
                Properties.Settings.Default.Save();

                Application.Restart();
            }

            if (Properties.Settings.Default.InitialEntry == true)
            {
                Properties.Settings.Default.InitialEntry = false;
                Properties.Settings.Default.Save();

                initialize();
                Application.Restart();
            }

            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Exit = false;
            Properties.Settings.Default.Restart = false;
            Properties.Settings.Default.InitialEntry = false;
            Properties.Settings.Default.Save();

            this.Close();
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
            Properties.Settings.Default.InitialEntry = false;
            Properties.Settings.Default.Save();
        }

        // Initialize method
        private void initialize()
        {
            // Strings
            string quest_paper00_ID_Dir_OFF = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper00_ID_OFF);
            string quest_paper00_ID_Dir_ON = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper00_ID_ON);

            string quest_paper01_ID_Dir_OFF = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper01_ID_OFF);
            string quest_paper01_ID_Dir_ON = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper01_ID_ON);

            string quest_paper02_ID_Dir_OFF = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper02_ID_OFF);
            string quest_paper02_ID_Dir_ON = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper02_ID_ON);

            string destFile = Path.Combine(localNaivePcPath + questBoardTexPath + "quest_paper00_ID.tex");
            string destOffFile = Path.Combine(localNaivePcPath + questBoardTexPath + "quest_paper00_ID_off.tex");

            string boosetteDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Boosette);
            string inaDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Ina);
            string lbcDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_LBC);
            string MHWI_Trailer_IMG_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MHWI_Trailer_IMG);
            string MAH_V1_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_01);
            string MAH_V2_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_02);

            string hud_UGS_Clock_EFX_tex_Dir_OFF = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_EFX_tex_OFF);
            string hud_UGS_Clock_EFX_tex_Dir_ON = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_EFX_tex_ON);

            string hud_UGS_Clock_tex_Dir_OFF = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_tex_OFF);
            string hud_UGS_Clock_tex_Dir_ON = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_tex_ON);

            string WP_EFX_Lan_RedShield_EFX_efx_Dir_OFF = Path.Combine(localNaivePcPath + wpLanEfxPath + WP_EFX_Lan_RedShield_EFX_efx_OFF);
            string WP_EFX_Lan_RedShield_EFX_efx_Dir_ON = Path.Combine(localNaivePcPath + wpLanEfxPath + WP_EFX_Lan_RedShield_EFX_efx_ON);

            string WP_EFX_LS_Trail_EFX_efx_Dir_OFF = Path.Combine(localNaivePcPath + wpSwoEfxPath + WP_EFX_LS_Trail_EFX_efx_OFF);
            string WP_EFX_LS_Trail_EFX_efx_Dir_ON = Path.Combine(localNaivePcPath + wpSwoEfxPath + WP_EFX_LS_Trail_EFX_efx_ON);

            string WP_EFX_LS_Trail_EFX_wp_epv_Dir_OFF = Path.Combine(localNaivePcPath + wpSwoEpvPath + WP_EFX_LS_Trail_EFX_wp_epv_OFF);
            string WP_EFX_LS_Trail_EFX_wp_epv_Dir_ON = Path.Combine(localNaivePcPath + wpSwoEpvPath + WP_EFX_LS_Trail_EFX_wp_epv_ON);

            string WP_EFX_Hue_Beat_EFX_wp_epv_Dir_OFF = Path.Combine(localNaivePcPath + wpHueEpvPath + WP_EFX_Hue_Beat_EFX_wp_epv_OFF);
            string WP_EFX_Hue_Beat_EFX_wp_epv_Dir_ON = Path.Combine(localNaivePcPath + wpHueEpvPath + WP_EFX_Hue_Beat_EFX_wp_epv_ON);

            string WP_EFX_Ham_Blossom_EFX_wp_epv_Dir_OFF = Path.Combine(localNaivePcPath + wpHamEpvPath + WP_EFX_Ham_Blossom_EFX_wp_epv_OFF);
            string WP_EFX_Ham_Blossom_EFX_wp_epv_Dir_ON = Path.Combine(localNaivePcPath + wpHamEpvPath + WP_EFX_Ham_Blossom_EFX_wp_epv_ON);

            string WP_EFX_CB_SakuraSAED_EFX_wp_epv_Dir_OFF = Path.Combine(localNaivePcPath + wpCBEpvPath + WP_EFX_CB_SakuraSAED_EFX_wp_epv_OFF);
            string WP_EFX_CB_SakuraSAED_EFX_wp_epv_Dir_ON = Path.Combine(localNaivePcPath + wpCBEpvPath + WP_EFX_CB_SakuraSAED_EFX_wp_epv_ON);

            string WP_SFX_Hue_Lust_sound_Dir_OFF = Path.Combine(localNaivePcPath + wpHueSFXPath + WP_SFX_Hue_Lust_sound_OFF);
            string WP_SFX_Hue_Lust_sound_Dir_ON = Path.Combine(localNaivePcPath + wpHueSFXPath + WP_SFX_Hue_Lust_sound_ON);

            string ON_BeheDir = Path.Combine(localNaivePcPath + pluginsPath, BehemothDamage);

            string ON_MantleDir = Path.Combine(localNaivePcPath + pluginsPath, MantleRemover);

            //// Default properties
            // GUI
            Properties.Settings.Default.QuestBoardBool = false;
            Properties.Settings.Default.UGSClockBool = false;

            //////// Initialize files' name or path
            ////// GUI
            //// Quest board on or off
            if (File.Exists(quest_paper01_ID_Dir_ON))
            {
                File.Move(quest_paper01_ID_Dir_ON, quest_paper01_ID_Dir_OFF);
            }

            if (File.Exists(quest_paper02_ID_Dir_ON))
            {
                File.Move(quest_paper02_ID_Dir_ON, quest_paper02_ID_Dir_OFF);
            }

            //// Quest board
            // Quest board IMG OFF
            switch (File.Exists(quest_paper00_ID_Dir_OFF))
            {
                case true:
                    // Boosette
                    if (Properties.Settings.Default.Boosette == true)
                    {
                        File.Move(destOffFile, boosetteDir);
                    }

                    // Ina
                    if (Properties.Settings.Default.Ina == true)
                    {
                        File.Move(destOffFile, inaDir);
                    }

                    // Laid-Back-Camp
                    if (Properties.Settings.Default.LBC == true)
                    {
                        File.Move(destOffFile, lbcDir);
                    }

                    // MHWI trailer IMG
                    if (Properties.Settings.Default.MHWI_Trailer_IMG == true)
                    {
                        File.Move(destOffFile, MHWI_Trailer_IMG_Dir);
                    }

                    // MAH_V1
                    if (Properties.Settings.Default.MAH_V1 == true)
                    {
                        File.Move(destOffFile, MAH_V1_Dir);
                    }

                    // MAH_V2
                    if (Properties.Settings.Default.MAH_V2 == true)
                    {
                        File.Move(destOffFile, MAH_V2_Dir);
                    }


                    break;
            }

            // Quest board IMG ON
            switch (File.Exists(quest_paper00_ID_Dir_ON))
            {
                case true:
                    // Boosette
                    if (Properties.Settings.Default.Boosette == true)
                    {
                        File.Move(destFile, boosetteDir);
                    }

                    // Ina
                    if (Properties.Settings.Default.Ina == true)
                    {
                        File.Move(destFile, inaDir);
                    }

                    // Laid-Back-Camp
                    if (Properties.Settings.Default.LBC == true)
                    {
                        File.Move(destFile, lbcDir);
                    }

                    // MHWI trailer IMG
                    if (Properties.Settings.Default.MHWI_Trailer_IMG == true)
                    {
                        File.Move(destFile, MHWI_Trailer_IMG_Dir);
                    }

                    // MAH_V1
                    if (Properties.Settings.Default.MAH_V1 == true)
                    {
                        File.Move(destFile, MAH_V1_Dir);
                    }

                    // MAH_V2
                    if (Properties.Settings.Default.MAH_V2 == true)
                    {
                        File.Move(destFile, MAH_V2_Dir);
                    }

                    break;
            }
            //// Quest board

            //// UGS clock
            if (File.Exists(Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_EFX_tex_ON)))
            {
                File.Move(hud_UGS_Clock_EFX_tex_Dir_ON, hud_UGS_Clock_EFX_tex_Dir_OFF);
            }

            if (File.Exists(Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_tex_ON)))
            {
                File.Move(hud_UGS_Clock_tex_Dir_ON, hud_UGS_Clock_tex_Dir_OFF);
            }
            //// UGS clock

            ////// WP EFX
            //// Lan red shield EFX
            if (Directory.Exists(Path.Combine(localNaivePcPath + wpLanEfxPath + WP_EFX_Lan_RedShield_EFX_efx_ON)))
            {
                Directory.Move(WP_EFX_Lan_RedShield_EFX_efx_Dir_ON, WP_EFX_Lan_RedShield_EFX_efx_Dir_OFF);
            }

            //// LS Trail EFX
            if (Directory.Exists(Path.Combine(localNaivePcPath + wpSwoEfxPath + WP_EFX_LS_Trail_EFX_efx_ON)))
            {
                Directory.Move(WP_EFX_LS_Trail_EFX_efx_Dir_ON, WP_EFX_LS_Trail_EFX_efx_Dir_OFF);
            }

            if (File.Exists(Path.Combine(localNaivePcPath + wpSwoEpvPath + WP_EFX_LS_Trail_EFX_wp_epv_ON)))
            {
                File.Move(WP_EFX_LS_Trail_EFX_wp_epv_Dir_ON, WP_EFX_LS_Trail_EFX_wp_epv_Dir_OFF);
            }

            //// Hue beats EFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpHueEpvPath + WP_EFX_Hue_Beat_EFX_wp_epv_ON)))
            {
                File.Move(WP_EFX_Hue_Beat_EFX_wp_epv_Dir_ON, WP_EFX_Hue_Beat_EFX_wp_epv_Dir_OFF);
            }

            //// Ham blossom EFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpHamEpvPath + WP_EFX_Ham_Blossom_EFX_wp_epv_ON)))
            {
                File.Move(WP_EFX_Ham_Blossom_EFX_wp_epv_Dir_ON, WP_EFX_Ham_Blossom_EFX_wp_epv_Dir_OFF);
            }

            //// CB sakura SAED EFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpCBEpvPath + WP_EFX_CB_SakuraSAED_EFX_wp_epv_ON)))
            {
                File.Move(WP_EFX_CB_SakuraSAED_EFX_wp_epv_Dir_ON, WP_EFX_CB_SakuraSAED_EFX_wp_epv_Dir_OFF);
            }
            ////// WP EFX

            ////// WP SFX
            //// Hue Lust SFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpHueSFXPath + WP_SFX_Hue_Lust_sound_ON)))
            {
                File.Move(WP_SFX_Hue_Lust_sound_Dir_ON, WP_SFX_Hue_Lust_sound_Dir_OFF);
            }
            ////// WP SFX

            ////// Plugins
            //// Behemoth damage display
            if (File.Exists(Path.Combine(localNaivePcPath + pluginsPath + BehemothDamage)))
            {
                File.Move(ON_BeheDir, Path.Combine(localNaivePcPath + controlPluginsPath + BehemothDamage));
            }

            //// Disable Mantles
            if (File.Exists(Path.Combine(localNaivePcPath + pluginsPath + MantleRemover)))
            {
                File.Move(ON_MantleDir, Path.Combine(localNaivePcPath + controlPluginsPath + MantleRemover));
            }
            ////// Plugins
            //////// Initialize files' name or path

            // Quest board IMG
            Properties.Settings.Default.Boosette = false;
            Properties.Settings.Default.Ina = false;
            Properties.Settings.Default.LBC = false;
            Properties.Settings.Default.MHWI_Trailer_IMG = false;
            Properties.Settings.Default.MAH_V1 = false;
            Properties.Settings.Default.MAH_V2 = false;

            // WP_EFX
            Properties.Settings.Default.LanRedShieldEFXBool = false;
            Properties.Settings.Default.LSTrailEFXBool = false;
            Properties.Settings.Default.CBSakuraSAEDEFXBool = false;
            Properties.Settings.Default.HueBeatEFXBool = false;
            Properties.Settings.Default.HamBlossomEFXBool = false;

            // WP_SFX
            Properties.Settings.Default.HueLustSFXBool = false;

            // Plugins
            Properties.Settings.Default.BeheBool = false;
            Properties.Settings.Default.MantleBool = false;

            // NativePc checker
            Properties.Settings.Default.NativePcChecker = false;

            // Exit program
            Properties.Settings.Default.Exit = false;

            // Restart program
            Properties.Settings.Default.Restart = false;

            // Initial
            Properties.Settings.Default.InitialEntry = false;

            // Properties save
            Properties.Settings.Default.Save();
            //// Properties section
        }
    }
}
