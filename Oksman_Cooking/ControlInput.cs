using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oksman_Cooking
{
    class ControlInput
    {
        public bool ControlStringInput(string text, int nchar)
        {

            if (text.Length < nchar && text.Length > 0) return true;
            else { MessageBox.Show("Wrong Input"); return false; }

        }
    }
}
