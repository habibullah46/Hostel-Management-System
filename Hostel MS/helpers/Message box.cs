using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_MS.helpers
{
    internal class Message_box
    { 
        public static void Error (string Name)
        {
            MessageBox.Show(Name+"Saved sucessfully","Success Message ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
