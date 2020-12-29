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

namespace ScreenTime
{
    public partial class form_createCategory : Form
    {
        public form_createCategory()
        {
            InitializeComponent();
        }

        private void btn_CreateCategory_Click(object sender, EventArgs e)
        {

        }

        private void ChooseImage(object sender, EventArgs e)
        {
            if (SelectImage.SelectImage.OpenImage())
                SwapUserControl.UserControls.Swap(pnl_chooseImage, new UC_ImagePreview());
        }
    }
}
