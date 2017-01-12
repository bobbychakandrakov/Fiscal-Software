using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal_Software.Helpers
{
    public static class DirtyChecker
    {
        public static void Check(Control.ControlCollection coll, EventHandler eh)
        {
            foreach (Control c in coll)
            {
                if (c is TextBox)
                {
                    (c as TextBox).TextChanged += new EventHandler(eh);

                }
                else if (c is CheckBox)
                {
                    (c as CheckBox).CheckedChanged += new EventHandler(eh);
                }
                else if (c is NumericUpDown)
                {
                    (c as NumericUpDown).ValueChanged += new EventHandler(eh);
                }
                else if (c is ComboBox)
                {
                    (c as ComboBox).SelectedIndexChanged += new EventHandler(eh);
                }
                // recurively apply to inner collections
                if (c.HasChildren)
                {
                    Check(c.Controls, eh);
                }

            }
        }
    }
}
