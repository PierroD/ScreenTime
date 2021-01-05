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

        public static void SwapCategories(Panel pnl, UserControl uc, string categoryName)
        {
            if (UserControlExist(uc, categoryName) == null)
            {
                pnl.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                UserControlExist(uc, categoryName).BringToFront();

        }

        private static Dictionary<string, UserControl> allUsercontrols = new Dictionary<string, UserControl>();
        private static UserControl UserControlExist(UserControl uc, string categoryName)
        {
            if (allUsercontrols.ContainsKey(categoryName))
                return allUsercontrols[categoryName];

            allUsercontrols.Add(categoryName, uc);
            return null;
        }

    }
}

