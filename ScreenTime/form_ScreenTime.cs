using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwapUserControl;
using ScreenTime.Views.Settings;
using ScreenTimeBackend.Controller;

namespace ScreenTime
{
    public partial class form_ScreenTime : Form
    {
        public form_ScreenTime()
        {
            InitializeComponent();
            CategoryController.LoadCategories();
        }

        private void pbox_Home_Click(object sender, EventArgs e)
        {
            MoveSideBar(pbox_Home.Location.Y);
        }

        private void MoveSideBar(int ButtonLocationY)
        {
            pnl_sidebar.Location = new Point(pnl_sidebar.Location.X, ButtonLocationY);
        }

        private void pbox_Settings_Click(object sender, EventArgs e)
        {
            MoveSideBar(pbox_Settings.Location.Y);
            UserControls.Swap(pnl_main, new UC_Settings());
        }

        private void btn_CreateCategory_Click(object sender, EventArgs e)
        {
            Form formCreate = new form_createCategory();
            Form formBackground = new Form();
            formBackground.StartPosition = FormStartPosition.Manual;
            formBackground.FormBorderStyle = FormBorderStyle.None;
            formBackground.Opacity = 0.70d;
            formBackground.BackColor = Color.Black;
            formBackground.WindowState = FormWindowState.Normal;
            formBackground.Size = this.Size;
            //formBackground.TopMost = true;
            formBackground.Location = this.Location;
            formBackground.ShowInTaskbar = false;
            formBackground.Show();

            formCreate.Owner = formBackground;
            formCreate.StartPosition = FormStartPosition.Manual;
            formCreate.TopMost = true;
            formCreate.Location = new Point(this.Location.X + (this.Width - formCreate.Width) / 2, this.Location.Y + (this.Height - formCreate.Height) / 2);

            formCreate.ShowDialog();

            formBackground.Dispose();
        }
    }
}
