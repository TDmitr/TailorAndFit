using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TailorAndFit
{
    public static class Controling
    {
        public static void ClearTextBoxes(Control c)
        {
            foreach (Control item in c.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
