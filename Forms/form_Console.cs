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
    public partial class form_Console : Form
    {
        // Strings

        //Debug
        private string _selectedPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\NativePc\\";

        //// Origin
        //private string _selectedPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Monster Hunter World\\NativePc\\";
        private string system = "[SYSTEM]";
        private string custom = "[CUSTOM]";
        private string gui = "[GUI]";
        private string wp_efx = "[WP_EFX]";
        private string wp_sfx = "[WP_SFX]";
        private string plugins = "[PLUSGINS]";
        private string initialize = "[INITIALIZE]";

        // Constructor
        public form_Console()
        {
            InitializeComponent();
        }

        // Form load
        private void form_Console_Load(object sender, EventArgs e)
        {
            // Strings
            string MHexe = "MonsterHunterWorld.exe";
            string MH_Folder = "Monster Hunter World";
            string NativePcFolder = "NativePc";
            string NativePcPath = _selectedPath;
            string MH_FolderPath = Path.GetDirectoryName(Path.GetDirectoryName(NativePcPath)) + "\\";

            //// Origin
            //if (File.Exists(Path.Combine(MH_FolderPath + MHexe)) == true && Directory.Exists(Path.Combine(NativePcPath)) == true && NativePcPath.Contains(NativePcFolder) == true && NativePcPath.Contains(MH_Folder) == true)
            //{
            //    Properties.Settings.Default.NativePcChecker = true;
            //    Properties.Settings.Default.Save();

            //    label_BrowsePath.Text = _selectedPath;
            //}

            // Debug
            if (Directory.Exists(Path.Combine(NativePcPath)) == true && NativePcPath.Contains(NativePcFolder) == true)
            {
                Properties.Settings.Default.NativePcChecker = true;
                Properties.Settings.Default.Save();

                label_BrowsePath.Text = _selectedPath;
            }

            else
            {
                Properties.Settings.Default.NativePcChecker = false;
                Properties.Settings.Default.Save();

                Forms.CustomMessageBox.CustomMessageBox.ShowMessage("請將此程式放進魔物根目錄裡。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //////// File infos
            ////// System
            //// NativePc
            label_FileInfo.Text += system + " NativePc Path ... " + Properties.Settings.Default.NativePcChecker.ToString() + Environment.NewLine;

            //// Exit
            label_FileInfo.Text += system + " Exit state ... " + Properties.Settings.Default.Exit.ToString() + Environment.NewLine;

            //// Restart
            label_FileInfo.Text += system + " Restart state ... " + Properties.Settings.Default.Restart.ToString() + Environment.NewLine;

            ////// Initialization
            //// Initial entry
            label_FileInfo.Text += system + initialize + " Initialization state ... " + Properties.Settings.Default.InitialEntry.ToString() + Environment.NewLine;

            //////Customization
            //// GUI
            // Quest board
            label_FileInfo.Text += custom + gui + " Quest board state ... " + Properties.Settings.Default.QuestBoardBool.ToString() + Environment.NewLine;
           
            //// Quest board IMG
            // Boosette quest board
            label_FileInfo.Text += custom + gui + " Boosette quest board state ... " + Properties.Settings.Default.Boosette.ToString() + Environment.NewLine;

            // Ina quest board
            label_FileInfo.Text += custom + gui + " Ina quest board state ... " + Properties.Settings.Default.Ina.ToString() + Environment.NewLine;

            // LBC quest board
            label_FileInfo.Text += custom + gui + " LBC quest board state ... " + Properties.Settings.Default.LBC.ToString() + Environment.NewLine;

            // MHWI trailer IMG quest board
            label_FileInfo.Text += custom + gui + " MHWI trailer IMG quest board state ... " + Properties.Settings.Default.MHWI_Trailer_IMG.ToString() + Environment.NewLine;

            // MAH V1 quest board
            label_FileInfo.Text += custom + gui + " MAH V1 quest board state ... " + Properties.Settings.Default.MAH_V1.ToString() + Environment.NewLine;

            // MAH V2 quest board
            label_FileInfo.Text += custom + gui + " MAH V2 quest board state ... " + Properties.Settings.Default.MAH_V2.ToString() + Environment.NewLine;

            // UGS clock
            label_FileInfo.Text += custom + gui + " UGS clock state ... " + Properties.Settings.Default.UGSClockBool.ToString() + Environment.NewLine;

            //// WP EFX
            // Lan red shield EFX
            label_FileInfo.Text += custom + wp_efx + " Lan red shield EFX state ... " + Properties.Settings.Default.LanRedShieldEFXBool.ToString() + Environment.NewLine;

            // LS trail EFX
            label_FileInfo.Text += custom + wp_efx + " LS trail EFX state ... " + Properties.Settings.Default.LSTrailEFXBool.ToString() + Environment.NewLine;

            // Hue lust beats EFX
            label_FileInfo.Text += custom + wp_efx + " Hue lust beats EFX state ... " + Properties.Settings.Default.HueBeatEFXBool.ToString() + Environment.NewLine;

            // CB sakura SAED EFX
            label_FileInfo.Text += custom + wp_efx + " CB sakura SAED EFX state ... " + Properties.Settings.Default.CBSakuraSAEDEFXBool.ToString() + Environment.NewLine;

            //// WP SFX
            // Hue lust SFX
            label_FileInfo.Text += custom + wp_sfx + " Hue lust SFX state ... " + Properties.Settings.Default.HueLustSFXBool.ToString() + Environment.NewLine;

            //// Plugins
            // Behemoth damage fore style
            label_FileInfo.Text += custom + plugins + " Behemoth damage fore style state ... " + Properties.Settings.Default.BeheBool.ToString() + Environment.NewLine;

            // Disable mantles
            label_FileInfo.Text += custom + plugins + " Disable mantle state ... " + Properties.Settings.Default.MantleBool.ToString() + Environment.NewLine;
        }
    }
}
