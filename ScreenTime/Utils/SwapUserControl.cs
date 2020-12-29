using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SwapUserControl
{
    public static class UserControls
    {
        public static void Swap(Panel pnl, UserControl uc)
        {
            if (!pnl.Controls.Contains(uc))
            {
                pnl.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }
    }
}

