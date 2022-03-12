using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms
{
    public partial class form_Splash : Form
    {
        private double lblProgressBarMaximumWidth = 661.0;
        private double lblProgressBarCurrentWidthPercentage;

        private bool funStopMethod = true;

        public form_Splash()
        {
            InitializeComponent();
        }

        private void form_Splash_Load(object sender, EventArgs e)
        {
            timer_Progress.Start();
            timer_Loading.Start();
        }

        private void timer_Progress_Tick(object sender, EventArgs e)
        {
            panel_ProgressBar.Width += 8;

            lblProgressBarCurrentWidthPercentage = (panel_ProgressBar.Width / lblProgressBarMaximumWidth) * 100;

            double result = Math.Round(lblProgressBarCurrentWidthPercentage, 0, MidpointRounding.AwayFromZero);

            label_ProgressBar.Text = result.ToString() + " %";

            if (lblProgressBarCurrentWidthPercentage > 10)
            {
                if (funStopMethod == true)
                {
                    funStopMethod = false;
                    Thread.Sleep(1000);
                }

                panel_ProgressBar.Width += 100;
            }

            if (lblProgressBarCurrentWidthPercentage >= 100)
            {
                timer_ClosingFadeOut.Start();
                if (Opacity <= 0.1)
                {
                    timer_Progress.Stop();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
        }

        private void timer_LabelDataInitializing_Tick(object sender, EventArgs e)
        {
            label_Loading.Text += " .";

            if (label_Loading.Text.Contains(" . . . .") == true)
            {
                label_Loading.Text = "Loadiing";
            }

            if (lblProgressBarCurrentWidthPercentage >= 100)
            {
                timer_Loading.Stop();
            }
        }

        private void timer_ClosingFadeOut_Tick(object sender, EventArgs e)
        {
            if (lblProgressBarCurrentWidthPercentage >= 100)
            {
                if (this.Opacity > 0.0)
                    this.Opacity -= 0.1;

                else
                    timer_ClosingFadeOut.Stop();
            }
        }
    }
}
