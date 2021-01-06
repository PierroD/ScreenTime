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
using ScreenTime.Views.CategoryModel;

namespace ScreenTime
{
    public partial class form_ScreenTime : Form
    {
        public form_ScreenTime()
        {
            InitializeComponent();
            LoadCategories();
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
            openAppWindow.openAppWindow.OpenWindow(this, new form_createCategory());
            LoadCategories();
        }

        private void LoadCategories()
        {
            CategoryController.LoadCategories();
            pnl_categories.Controls.Clear();
            foreach (var category in CategoryController.GetCategories())
                pnl_categories.Controls.Add(new UC_CategoryModel(category.Name));

        }

        private void form_ScreenTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            CategoryController.StepOpenTimeCategories();
        }
    }
}
