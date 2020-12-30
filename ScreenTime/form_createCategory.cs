using ScreenTime.Views.CreateCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenTimeBackend.Controller;
using System.IO;

namespace ScreenTime
{
    public partial class form_createCategory : Form
    {
        public form_createCategory()
        {
            InitializeComponent();

        }
        UC_ImagePreview imagePreview;

        private void ChooseImage(object sender, EventArgs e)
        {
            if (SelectImage.SelectImage.OpenImage())
            {
                imagePreview = new UC_ImagePreview();
                SwapUserControl.UserControls.Swap(pnl_chooseImage, imagePreview);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (tbox_Name.TextLength != 0)
                if (File.Exists(imagePreview.filepath))
                {
                    CategoryController.CreateCategory(tbox_Name.Text, tbox_Description.Text, imagePreview.filepath);
                    this.Close();
                }
                else
                    MessageBox.Show($"Image called {Path.GetFileName(imagePreview.filepath)} doesn't exist anymore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"Category's name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
