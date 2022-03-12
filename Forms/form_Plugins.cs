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
    public partial class form_Plugins : Form
    {
        //// Directories

        //Debug
        private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\NativePc\\";

        //// Local NativePc path
        //private string localNaivePcPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Monster Hunter World\\NativePc\\";

        // Custom Path
        private string pluginsPath = "plugins\\";
        private string controlPluginsPath = "plugins\\ControlFolder\\";

        // Plugins' name
        private string BehemothDamage = "BehemothDamage.dll";
        private string MantleRemover = "MantleRemover.dll";
        //// Directories



        // Constructor
        public form_Plugins()
        {
            InitializeComponent();
        }

        // Form load
        private void form_Plugins_Load(object sender, EventArgs e)
        {
            // Properties
            toggleBtn_Behe_DamageDisplay.Checked = Properties.Settings.Default.BeheBool;
            toggleBtn_Disable_Mantle.Checked = Properties.Settings.Default.MantleBool;
        }

        //// Toggle buttons
        // Behemoth damage display
        private void toggleBtn_Behe_DamageDisplay_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string pluginsDir = Path.Combine(localNaivePcPath + pluginsPath + BehemothDamage);
            string controlPluginsDir = Path.Combine(localNaivePcPath + controlPluginsPath + BehemothDamage);

            // Move
            switch (toggleBtn_Behe_DamageDisplay.Checked)
            {
                case true:
                    if (File.Exists(controlPluginsDir))
                    {
                        File.Move(controlPluginsDir, pluginsDir);
                    }
                    break;

                case false:
                    if (File.Exists(pluginsDir))
                    {
                        File.Move(pluginsDir, controlPluginsDir);
                    }
                    break;
            }

            // Properties save
            Properties.Settings.Default.BeheBool = toggleBtn_Behe_DamageDisplay.Checked;
            Properties.Settings.Default.Save();
        }

        // Disable mantles
        private void toggleBtn_Disable_Mantles_CheckedChanged(object sender, EventArgs e)
        {
            // Strings
            string pluginsDir = Path.Combine(localNaivePcPath + pluginsPath + MantleRemover);
            string controlPluginsDir = Path.Combine(localNaivePcPath + controlPluginsPath + MantleRemover);

            // Move
            switch (toggleBtn_Disable_Mantle.Checked)
            {
                case true:
                    if (File.Exists(controlPluginsDir))
                    {
                        File.Move(controlPluginsDir, pluginsDir);
                    }
                    break;

                case false:
                    if (File.Exists(pluginsDir))
                    {
                        File.Move(pluginsDir, controlPluginsDir);
                    }
                    break;
            }

            // Properties save
            Properties.Settings.Default.MantleBool = toggleBtn_Disable_Mantle.Checked;
            Properties.Settings.Default.Save();
        }
        //// Toggle buttons
    }
}
