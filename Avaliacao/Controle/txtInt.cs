using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao.Controle
{
    internal class txtInt: TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == 8)
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
