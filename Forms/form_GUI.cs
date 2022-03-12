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
using System.Threading;

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms
{
    public partial class form_GUI : Form
    {
        //// Directories

        //Debug
        private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\NativePc\\";

        //// Local NativePc path
        //private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Monster Hunter World\\NativePc\\";

        // Custom Path
        private string questBoardTexPath = "ui\\quest\\tex\\";

        private string hudPath = "ui\\hud\\tex\\";

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

        // For cheking quest board custom on or off
        private string quest_paper00_ID_OFF = "quest_paper00_ID_off.tex";
        private string quest_paper00_ID_ON = "quest_paper00_ID.tex";
        private string quest_paper01_ID_OFF = "quest_paper01_ID_off.tex";
        private string quest_paper01_ID_ON = "quest_paper01_ID.tex";
        private string quest_paper02_ID_OFF = "quest_paper02_ID_off.tex";
        private string quest_paper02_ID_ON = "quest_paper02_ID.tex";
        //// Directories



        // Constructor
        public form_GUI()
        {
            InitializeComponent();
        }

        // Form load
        private void form_GUI_Load(object sender, EventArgs e)
        {
            // ComboBoxes
            comboBox_QuestBoard_IMG.Items.Add("幽靈姬");
            comboBox_QuestBoard_IMG.Items.Add("Ina");
            comboBox_QuestBoard_IMG.Items.Add("搖曳露營");
            comboBox_QuestBoard_IMG.Items.Add("冰原魔物宣傳圖");
            comboBox_QuestBoard_IMG.Items.Add("火芽與水藝_01");
            comboBox_QuestBoard_IMG.Items.Add("火芽與水藝_02");

            // Properties
            toggleBtn_QuestBoard_IMG.Checked = Properties.Settings.Default.QuestBoardBool;
            toggleBtn_UGS_Clock.Checked = Properties.Settings.Default.UGSClockBool;
        }

        // Btn click
        // Quest board
        private void roundedBtn_QuestBoard_IMG_Click(object sender, EventArgs e)
        {
            movePreviousSelectedItem();

            comboBoxSelectCheck();

            moveSelectedItem();
        }


        //// Toggle buttons
        // Quest board
        private void toggleBtn_QuestBoard_IMG_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string quest_paper00_ID_Dir_OFF = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper00_ID_OFF);
            string quest_paper00_ID_Dir_ON = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper00_ID_ON);
            string quest_paper01_ID_Dir_OFF = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper01_ID_OFF);
            string quest_paper01_ID_Dir_ON = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper01_ID_ON);
            string quest_paper02_ID_Dir_OFF = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper02_ID_OFF);
            string quest_paper02_ID_Dir_ON = Path.Combine(localNaivePcPath + questBoardTexPath + quest_paper02_ID_ON);

            //Rename(Move)
            switch (toggleBtn_QuestBoard_IMG.Checked)
            {
                case true:
                    if (File.Exists(quest_paper01_ID_Dir_OFF) == true && File.Exists(quest_paper02_ID_Dir_OFF) == true)
                    {
                        File.Move(quest_paper01_ID_Dir_OFF, quest_paper01_ID_Dir_ON);
                        File.Move(quest_paper02_ID_Dir_OFF, quest_paper02_ID_Dir_ON);
                    }

                    if (File.Exists(quest_paper00_ID_Dir_OFF) == true)
                    {
                        File.Move(quest_paper00_ID_Dir_OFF, quest_paper00_ID_Dir_ON);
                    }

                    this.comboBox_QuestBoard_IMG.Enabled = true;
                    this.roundedBtn_QuestBoard_IMG.Enabled = true;
                    break;

                case false:
                    if (File.Exists(quest_paper01_ID_Dir_ON) == true && File.Exists(quest_paper02_ID_Dir_ON) == true)
                    {
                        File.Move(quest_paper01_ID_Dir_ON, quest_paper01_ID_Dir_OFF);
                        File.Move(quest_paper02_ID_Dir_ON, quest_paper02_ID_Dir_OFF);
                    }

                    if (File.Exists(quest_paper00_ID_Dir_ON) == true)
                    {
                        File.Move(quest_paper00_ID_Dir_ON, quest_paper00_ID_Dir_OFF);
                    }

                    this.comboBox_QuestBoard_IMG.Enabled = false;
                    this.roundedBtn_QuestBoard_IMG.Enabled = false;
                    break;
            }

            // Property save
            Properties.Settings.Default.QuestBoardBool = toggleBtn_QuestBoard_IMG.Checked;
            Properties.Settings.Default.Save();
        }

        // UGS clock
        private void toggleBtn_UGS_Clock_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string hud_UGS_Clock_EFX_tex_Dir_OFF = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_EFX_tex_OFF);
            string hud_UGS_Clock_EFX_tex_Dir_ON = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_EFX_tex_ON);
            string hud_UGS_Clock_tex_Dir_OFF = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_tex_OFF);
            string hud_UGS_Clock_tex_Dir_ON = Path.Combine(localNaivePcPath + hudPath + hud_UGS_Clock_tex_ON);

            // Rename(Move)
            switch (toggleBtn_UGS_Clock.Checked)
            {
                case true:
                    if (File.Exists(hud_UGS_Clock_EFX_tex_Dir_OFF) == true && File.Exists(hud_UGS_Clock_tex_Dir_OFF) == true)
                    {
                        File.Move(hud_UGS_Clock_EFX_tex_Dir_OFF, hud_UGS_Clock_EFX_tex_Dir_ON);
                        File.Move(hud_UGS_Clock_tex_Dir_OFF, hud_UGS_Clock_tex_Dir_ON);
                    }
                    break;

                case false:
                    if (File.Exists(hud_UGS_Clock_EFX_tex_Dir_ON) == true && File.Exists(hud_UGS_Clock_tex_Dir_ON) == true)
                    {
                        File.Move(hud_UGS_Clock_EFX_tex_Dir_ON, hud_UGS_Clock_EFX_tex_Dir_OFF);
                        File.Move(hud_UGS_Clock_tex_Dir_ON, hud_UGS_Clock_tex_Dir_OFF);
                    }
                    break;
            }

            // Property save
            Properties.Settings.Default.UGSClockBool = toggleBtn_UGS_Clock.Checked;
            Properties.Settings.Default.Save();
        }
        //// Toggle buttons



        //// Functions
        // Combo box selection
        private void comboBoxSelectCheck()
        {
            string selectedFileText = comboBox_QuestBoard_IMG.Text;

            switch (selectedFileText)
            {
                case "幽靈姬":
                    Properties.Settings.Default.Boosette = true;
                    Properties.Settings.Default.Ina = false;
                    Properties.Settings.Default.LBC = false;
                    Properties.Settings.Default.MHWI_Trailer_IMG = false;
                    Properties.Settings.Default.MAH_V1 = false;
                    Properties.Settings.Default.MAH_V2 = false;
                    Properties.Settings.Default.Save();
                    break;

                case "Ina":
                    Properties.Settings.Default.Boosette = false;
                    Properties.Settings.Default.Ina = true;
                    Properties.Settings.Default.LBC = false;
                    Properties.Settings.Default.MHWI_Trailer_IMG = false;
                    Properties.Settings.Default.MAH_V1 = false;
                    Properties.Settings.Default.MAH_V2 = false;
                    Properties.Settings.Default.Save();
                    break;

                case "搖曳露營":
                    Properties.Settings.Default.Boosette = false;
                    Properties.Settings.Default.Ina = false;
                    Properties.Settings.Default.LBC = true;
                    Properties.Settings.Default.MHWI_Trailer_IMG = false;
                    Properties.Settings.Default.MAH_V1 = false;
                    Properties.Settings.Default.MAH_V2 = false;
                    Properties.Settings.Default.Save();
                    break;

                case "冰原魔物宣傳圖":
                    Properties.Settings.Default.Boosette = false;
                    Properties.Settings.Default.Ina = false;
                    Properties.Settings.Default.LBC = false;
                    Properties.Settings.Default.MHWI_Trailer_IMG = true;
                    Properties.Settings.Default.MAH_V1 = false;
                    Properties.Settings.Default.MAH_V2 = false;
                    Properties.Settings.Default.Save();
                    break;

                case "火芽與水藝_01":
                    Properties.Settings.Default.Boosette = false;
                    Properties.Settings.Default.Ina = false;
                    Properties.Settings.Default.LBC = false;
                    Properties.Settings.Default.MHWI_Trailer_IMG = false;
                    Properties.Settings.Default.MAH_V1 = true;
                    Properties.Settings.Default.MAH_V2 = false;
                    Properties.Settings.Default.Save();
                    break;

                case "火芽與水藝_02":
                    Properties.Settings.Default.Boosette = false;
                    Properties.Settings.Default.Ina = false;
                    Properties.Settings.Default.LBC = false;
                    Properties.Settings.Default.MHWI_Trailer_IMG = false;
                    Properties.Settings.Default.MAH_V1 = false;
                    Properties.Settings.Default.MAH_V2 = true;
                    Properties.Settings.Default.Save();
                    break;
            }
        }

        // Move previous selected item
        private void movePreviousSelectedItem()
        {
            // Strings
            string destFile = Path.Combine(localNaivePcPath + questBoardTexPath + "quest_paper00_ID.tex");

            string boosetteDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Boosette);
            string inaDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Ina);
            string lbcDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_LBC);
            string MHWI_Trailer_IMG_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MHWI_Trailer_IMG);
            string MAH_V1_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_01);
            string MAH_V2_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_02);

            //// Move previous selected file
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

            // MHWI Trailer IMG
            if (Properties.Settings.Default.MHWI_Trailer_IMG == true)
            {
                File.Move(destFile, MHWI_Trailer_IMG_Dir);
            }

            // MAH V1
            if (Properties.Settings.Default.MAH_V1 == true)
            {
                File.Move(destFile, MAH_V1_Dir);
            }

            // MAH V2
            if (Properties.Settings.Default.MAH_V2 == true)
            {
                File.Move(destFile, MAH_V2_Dir);
            }
        }

        // Move file
        private void moveFile(string currentSelectedFile)
        {
            string destFile = Path.Combine(localNaivePcPath + questBoardTexPath + "quest_paper00_ID.tex");

            if (File.Exists(destFile))
            {
                //// Bool checking state
                // Boosette
                if (Properties.Settings.Default.Boosette == true)
                {
                    try
                    {
                        File.Move(currentSelectedFile, destFile);
                    }
                    catch
                    {

                    }
                }

                // Ina
                if (Properties.Settings.Default.Ina == true)
                {
                    try
                    {
                        File.Move(currentSelectedFile, destFile);
                    }
                    catch
                    {

                    }
                }

                // Laid-Bacj-Camp
                if (Properties.Settings.Default.LBC == true)
                {
                    try
                    {
                        File.Move(currentSelectedFile, destFile);
                    }
                    catch
                    {

                    }
                }

                // MHWI Trailer IMG
                if (Properties.Settings.Default.MHWI_Trailer_IMG == true)
                {
                    try
                    {
                        File.Move(currentSelectedFile, destFile);
                    }
                    catch
                    {

                    }
                }

                // MAH V1
                if (Properties.Settings.Default.MAH_V1 == true)
                {
                    try
                    {
                        File.Move(currentSelectedFile, destFile);
                    }
                    catch
                    {

                    }
                }

                // MAH V2
                if (Properties.Settings.Default.MAH_V2 == true)
                {
                    try
                    {
                        File.Move(currentSelectedFile, destFile);
                    }
                    catch
                    {

                    }
                }
            }

            else
            {
                File.Move(currentSelectedFile, destFile);
            }
        }

        // Move selected file
        private void moveSelectedItem()
        {
            // Strings
            string boosetteDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Boosette);
            string inaDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_Ina);
            string lbcDir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_LBC);
            string MHWI_Trailer_IMG_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MHWI_Trailer_IMG);
            string MAH_V1_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_01);
            string MAH_V2_Dir = Path.Combine(localNaivePcPath + questBoardTexPath + QBT_MAH_02);

            // Boosette
            if (Properties.Settings.Default.Boosette == true)
            {
                moveFile(boosetteDir);
            }

            // Ina
            if (Properties.Settings.Default.Ina == true)
            {
                moveFile(inaDir);
            }

            // Laid-Back-Camp
            if (Properties.Settings.Default.LBC == true)
            {
                moveFile(lbcDir);
            }

            // MHWI Trailer IMG
            if (Properties.Settings.Default.MHWI_Trailer_IMG == true)
            {
                moveFile(MHWI_Trailer_IMG_Dir);
            }

            // MAH V1
            if (Properties.Settings.Default.MAH_V1 == true)
            {
                moveFile(MAH_V1_Dir);
            }

            // MAH V2
            if (Properties.Settings.Default.MAH_V2 == true)
            {
                moveFile(MAH_V2_Dir);
            }

        }
        //// Functions
    }
}
