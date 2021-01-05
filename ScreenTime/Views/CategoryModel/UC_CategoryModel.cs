using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using ScreenTime.Views.CategoryTable;
using ScreenTimeBackend.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTime.Views.CategoryModel
{
    public partial class UC_CategoryModel : UserControl
    {
        dynamic category;
        public UC_CategoryModel(string categoryName)
        {
            this.category = CategoryController.GetCategory(categoryName);
            InitializeComponent();
        }

        private void UC_CategoryModel_Load(object sender, EventArgs e)
        {
            pbox_categoryIcon.Image = Image.FromFile(category.Image);
            lbl_categoryName.Text = category.Name;
        }

        private void LoadCategory(object sender, EventArgs e)
        {
            Control parent = Parent;
            while (!(parent is Form))
                parent = parent.Parent;

            // load icon and tile
            Guna2CirclePictureBox pbox_categoryIcon = (Guna2CirclePictureBox)parent.Controls["pnl_top"].Controls.Find("pbox_categoryIcon", true).FirstOrDefault();
            pbox_categoryIcon.Image = Image.FromFile(category.Image);
            GunaLabel lbl_categoryName = (GunaLabel)parent.Controls.Find("lbl_categoryName", true).FirstOrDefault();
            lbl_categoryName.Text = category.Name;
            //change UC
            Guna2Panel pnl_main = (Guna2Panel)parent.Controls.Find("pnl_main", true).FirstOrDefault();
            SwapUserControl.UserControls.SwapCategories(pnl_main, new UC_CategoryTable(category.Name), category.Name);
        }
    }
}
