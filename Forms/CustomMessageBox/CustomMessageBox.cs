using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHWI_UGS_ModPack_Mod_Custumization_Selector.Forms.CustomMessageBox
{
    public static class CustomMessageBox
    {
        public static DialogResult ShowMessage(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult dlgResult = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.YesNo:
                    using (form_MessageBox_YesNo msgYesNo = new form_MessageBox_YesNo())
                    {
                        msgYesNo.Text = caption;
                        msgYesNo.MessageString = message;

                        dlgResult = msgYesNo.ShowDialog();
                    }

                    break;

                case MessageBoxButtons.OK:
                    using (form_MessageBox_OK msgOK = new form_MessageBox_OK())
                    {
                        msgOK.Text = caption;
                        msgOK.MessageString = message;

                        dlgResult = msgOK.ShowDialog();
                    }

                    break;
            }
            return dlgResult;
        }
    }
}
