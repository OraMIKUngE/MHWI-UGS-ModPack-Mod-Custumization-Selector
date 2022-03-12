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
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector
{
    public partial class Form1 : Form
    {
        // Bool
        bool sideBarExpand = true;
        bool mouseEnter;

        // Dragable window
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Active object setup
        private Form activeForm = null;

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
        private string hud_UGS_Clock_tex_OFF = "hud00_ID_off.tex";

        // WP EFX files' name
        private string WP_EFX_LS_Trail_EFX_efx_OFF = "wp03_off";
        private string WP_EFX_LS_Trail_EFX_wp_epv_OFF = "hm_wp03_off.epv3";

        private string WP_EFX_Lan_RedShield_EFX_efx_OFF = "wp01_01_off";

        private string WP_EFX_Hue_Beat_EFX_wp_epv_OFF = "hm_wp05_off.epv3";

        private string WP_EFX_Ham_Blossom_EFX_wp_epv_OFF = "hm_wp04_off.epv3";

        private string WP_EFX_CB_SakuraSAED_EFX_wp_epv_OFF = "hm_wp09_off.epv3";

        // WP SFX files' name
        private string WP_SFX_Hue_Lust_sound_OFF = "wp_hue_026_off.nbnk";

        // For cheking quest board custom on or off
        private string quest_paper01_ID_OFF = "quest_paper01_ID_off.tex";
        private string quest_paper02_ID_OFF = "quest_paper02_ID_off.tex";

        // Plugins' name
        private string BehemothDamage = "BehemothDamage.dll";
        private string MantleRemover = "MantleRemover.dll";
        //// Directories

        // Fields
        private Button currentBtn;
        private Panel panel_SideBtnEdgeLine;

        // Strings
        private string MHexe = "MonsterHunterWorld.exe";
        private string MH_Folder = "Monster Hunter World";
        private string NativePcFolder = "NativePc";

        // Constructor
        public Form1()
        {
            Opacity = 0;

            InitializeComponent();

            timer_FormFadeIn.Start();

            //// Custom button highlight panel
            // Side sliding bar
            panel_SideBtnEdgeLine = new Panel();
            panel_SideBtnEdgeLine.Size = new Size(7, 80);
            panel_SideForm.Controls.Add(panel_SideBtnEdgeLine);

        }



        ////// Mouse events
        //// Mouse enter / leave
        // Side form
        private void panel_SideForm_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter = false;
            timer_panel_SideForm.Start();
        }

        private void panel_SideForm_MouseLeave(object sender, EventArgs e)
        {
            mouseEnter = true;
            timer_panel_SideForm.Start();
        }

        // Close back color
        private void pictureBox_Close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Close.BackColor = Color.FromArgb(75, 142, 238);
        }

        private void pictureBox_Close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Close.BackColor = Color.Black;
        }

        // Restart back color
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Reset.BackColor = Color.FromArgb(75, 142, 238);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Reset.BackColor = Color.Black;
        }

        // Minimize back color
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Mnimize.BackColor = Color.FromArgb(75, 142, 238);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Mnimize.BackColor = Color.Black;
        }

        //// Btn click
        // For opening child form
        private void Plugins_Btn_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Forms.form_Plugins());
        }

        //// Glow btn
        private void glowBtn_Console_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Forms.form_Console());
        }

        private void glowBtn_GUI_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Forms.form_GUI());
        }

        private void glowBtn_WP_EFX_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Forms.form_WP_EFX());
        }

        private void glowBtn_WP_SFX_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Forms.form_WP_SFX());
        }

        private void glowBtn_Plugins_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Forms.form_Plugins());
        }

        // Initialize
        private void glowBtn_Initialize_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.InitialEntry = true;
            Properties.Settings.Default.Save();

            Forms.CustomMessageBox.CustomMessageBox.ShowMessage("確定要還原預設設定嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        // Drag window
        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Minimize window
        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Exit program
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Exit = true;
            Properties.Settings.Default.Save();

            Forms.CustomMessageBox.CustomMessageBox.ShowMessage("確定要關閉應用程式嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        // Minimize window
        private void pictureBox_Mnimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Restart program
        private void pictureBox_Reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Restart = true;
            Properties.Settings.Default.Save();

            Forms.CustomMessageBox.CustomMessageBox.ShowMessage("確定要重開應用程式嗎?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        ////// Mouse events



        // Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check MHWI running or not
            timer_MHWI_RunningChecker.Start();

            // Strings
            string MH_FolderPath = Path.GetDirectoryName(Path.GetDirectoryName(localNaivePcPath)) + "\\";

            // Local NativePc precheck (Debug)
            if (Directory.Exists(localNaivePcPath) == true && localNaivePcPath.Contains(NativePcFolder) == true)
            {
                Properties.Settings.Default.NativePcChecker = true;
                Properties.Settings.Default.Save();

                glowBtn_GUI.Enabled = true;
                glowBtn_WP_EFX.Enabled = true;
                glowBtn_WP_SFX.Enabled = true;
                glowBtn_Plugins.Enabled = true;
            }

            if (Directory.Exists(localNaivePcPath) == false || localNaivePcPath.Contains(NativePcFolder) == false)
            {
                Properties.Settings.Default.NativePcChecker = false;
                Properties.Settings.Default.Save();

                glowBtn_GUI.Enabled = false;
                glowBtn_WP_EFX.Enabled = false;
                glowBtn_WP_SFX.Enabled = false;
                glowBtn_Plugins.Enabled = false;
            }

            //// Local NativePc precheck (Origin)
            //if (File.Exists(Path.Combine(MH_FolderPath + MHexe)) == true && Directory.Exists(localNaivePcPath) == true && localNaivePcPath.Contains(NativePcFolder) == true && localNaivePcPath.Contains(MH_Folder) == true)
            //{
            //    Properties.Settings.Default.NativePcChecker = true;
            //    Properties.Settings.Default.Save();

            //    glowBtn_GUI.Enabled = true;
            //    glowBtn_WP_EFX.Enabled = true;
            //    glowBtn_WP_SFX.Enabled = true;
            //    glowBtn_Plugins.Enabled = true;
            //}

            //if (File.Exists(Path.Combine(MH_FolderPath + MHexe)) == false || Directory.Exists(localNaivePcPath) == false || localNaivePcPath.Contains(NativePcFolder) == false || localNaivePcPath.Contains(MH_Folder) == false)
            //{
            //    Properties.Settings.Default.NativePcChecker = false;
            //    Properties.Settings.Default.Save();

            //    glowBtn_GUI.Enabled = false;
            //    glowBtn_WP_EFX.Enabled = false;
            //    glowBtn_WP_SFX.Enabled = false;
            //    glowBtn_Plugins.Enabled = false;
            //}

            //////// Analyze existing files
            ////// GUI
            //// Quest board for checking quest board on or off
            // quest_paper01_ID & quest_paper02_ID
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper01_ID_OFF)) == true &&
                File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper02_ID_OFF)) == true)
            {
                Properties.Settings.Default.QuestBoardBool = false;
                Properties.Settings.Default.Save();
            }
            //// Quest board for checking quest board on or off


            //// Quest board
            // Boosette
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Boosette)))
            {
                Properties.Settings.Default.Boosette = false;
                Properties.Settings.Default.Save();
            }

            // Ina
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Ina)))
            {
                Properties.Settings.Default.Ina = false;
                Properties.Settings.Default.Save();
            }

            // Laid-Back-Camp
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + QBT_LBC)))
            {
                Properties.Settings.Default.LBC = false;
                Properties.Settings.Default.Save();
            }

            // MHWI Trailer IMG
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MHWI_Trailer_IMG)))
            {
                Properties.Settings.Default.MHWI_Trailer_IMG = false;
                Properties.Settings.Default.Save();
            }

            // MAH V1
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_01)))
            {
                Properties.Settings.Default.MAH_V1 = false;
                Properties.Settings.Default.Save();
            }

            // MAH V2
            if (File.Exists(Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_02)))
            {
                Properties.Settings.Default.MAH_V2 = false;
                Properties.Settings.Default.Save();
            }
            //// Quest board

            //// Hud
            // UGS clock
            if (File.Exists(Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_EFX_tex_OFF)) == true &&
                File.Exists(Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_tex_OFF)))
            {
                Properties.Settings.Default.UGSClockBool = false;
                Properties.Settings.Default.Save();
            }
            //// Hud

            //// WP EFX
            // Lan red shield
            if (Directory.Exists(Path.Combine(localNaivePcPath + wpLanEfxPath + WP_EFX_Lan_RedShield_EFX_efx_OFF)))
            {
                Properties.Settings.Default.LanRedShieldEFXBool = false;
                Properties.Settings.Default.Save();
            }

            // LS trail EFX
            if (Directory.Exists(Path.Combine(localNaivePcPath + wpSwoEfxPath + WP_EFX_LS_Trail_EFX_efx_OFF)) == true &&
                File.Exists(Path.Combine(localNaivePcPath + wpSwoEpvPath + WP_EFX_LS_Trail_EFX_wp_epv_OFF)) == true)
            {
                Properties.Settings.Default.LSTrailEFXBool = false;
                Properties.Settings.Default.Save();
            }

            // Hue beat EFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpHueEpvPath + WP_EFX_Hue_Beat_EFX_wp_epv_OFF)))
            {
                Properties.Settings.Default.HueBeatEFXBool = false;
                Properties.Settings.Default.Save();
            }

            // Ham blossom EFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpHamEpvPath + WP_EFX_Ham_Blossom_EFX_wp_epv_OFF)))
            {
                Properties.Settings.Default.HamBlossomEFXBool = false;
                Properties.Settings.Default.Save();
            }

            // CB sakura SAED EFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpCBEpvPath + WP_EFX_CB_SakuraSAED_EFX_wp_epv_OFF)))
            {
                Properties.Settings.Default.CBSakuraSAEDEFXBool = false;
                Properties.Settings.Default.Save();
            }
            //// WP EFX
            ////// GUI

            ////// WP SFX
            //// Hue SFX
            if (File.Exists(Path.Combine(localNaivePcPath + wpHueSFXPath + WP_SFX_Hue_Lust_sound_OFF)))
            {
                Properties.Settings.Default.HueLustSFXBool = false;
                Properties.Settings.Default.Save();
            }
            //// WP EFX

            ////// Plugins
            //// Behemoth damage diaplay
            if (File.Exists(Path.Combine(localNaivePcPath + controlPluginsPath + BehemothDamage)))
            {
                Properties.Settings.Default.BeheBool = false;
                Properties.Settings.Default.Save();
            }

            if (File.Exists(Path.Combine(localNaivePcPath + pluginsPath + BehemothDamage)))
            {
                Properties.Settings.Default.BeheBool = true;
                Properties.Settings.Default.Save();
            }

            //// Disable mantles
            if (File.Exists(Path.Combine(localNaivePcPath + controlPluginsPath + MantleRemover)))
            {
                Properties.Settings.Default.MantleBool = false;
                Properties.Settings.Default.Save();
            }

            if (File.Exists(Path.Combine(localNaivePcPath + pluginsPath + MantleRemover)))
            {
                Properties.Settings.Default.MantleBool = true;
                Properties.Settings.Default.Save();
            }
            ////// Plugins
            //////// Analyze existing files



            // Establish console page
            openChildForm(new Forms.form_Console());

            panel_SideBtnEdgeLine.BackColor = Color.FromArgb(75, 142, 238);
            panel_SideBtnEdgeLine.Location = new Point(0, glowBtn_Console.Location.Y);
            panel_SideBtnEdgeLine.Visible = true;
            panel_SideBtnEdgeLine.BringToFront();
        }



        //// Functions
        // Open child form
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Activate btn color section + disable previous activated btn
        private void activateBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    disableBtn();

                    currentBtn = (Button)btnSender;

                    panel_SideBtnEdgeLine.BackColor = Color.FromArgb(75, 142, 238);
                    panel_SideBtnEdgeLine.Location = new Point(0, currentBtn.Location.Y);
                    panel_SideBtnEdgeLine.Visible = true;
                    panel_SideBtnEdgeLine.BringToFront();
                }
            }
        }

        // Disable activated btn
        private void disableBtn()
        {
            foreach (Control previousBtn in panel_SideForm.Controls)
            {
                previousBtn.BackColor = Color.Black;
            }
        }

        // Run form
        private void formRun()
        {
            Application.Run(new Forms.form_Splash());
        }
        //// Functions



        //// Timer
        // Side Panel timer tick
        private void timer_panel_SideForm_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand == true && mouseEnter == true)
            {
                // If side bar is expand, minimize size of side bar panel
                panel_SideForm.Width -= 10;
                if (panel_SideForm.Width == panel_SideForm.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timer_panel_SideForm.Stop();
                }
            }

            else
            {
                panel_SideForm.Width += 10;
                if (panel_SideForm.Width == panel_SideForm.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timer_panel_SideForm.Stop();
                }
            }
        }

        // Fade in timer
        private void timer_FormFadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity < 0.9)
                Opacity += 0.1;
            else
                timer_FormFadeIn.Stop();
        }

        // MHWI running check timer
        private void timer_MHWI_RunningChecker_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("MonsterHunterWorld");
            if (processes.Length == 0)
            {
                // Not running
                glowBtn_GUI.Enabled = true;
                glowBtn_WP_EFX.Enabled = true;
                glowBtn_WP_SFX.Enabled = true;
                glowBtn_Plugins.Enabled = true;
                glowBtn_Initialize.Enabled = true;
            }
            else
            {
                // Running
                glowBtn_GUI.Enabled = false;
                glowBtn_WP_EFX.Enabled = false;
                glowBtn_WP_SFX.Enabled = false;
                glowBtn_Plugins.Enabled = false;
                glowBtn_Initialize.Enabled = false;
            }
        }
    }
}