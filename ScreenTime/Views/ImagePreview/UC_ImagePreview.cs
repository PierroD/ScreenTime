using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTime.Views.ImagePreview
{
    public partial class UC_ImagePreview : UserControl
    {
        public string filepath { get; set; }

        public UC_ImagePreview()
        {
            InitializeComponent();
            LoadImagePreview();
        }

        void LoadImagePreview()
        {
            filepath = SelectImage.SelectImage.GetFilePath();
            pbox_previewImage.Image = Image.FromFile(filepath);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menu_preview.Show(btn_menu, new Point(0 - (menu_preview.Width - btn_menu.Width) / 2, btn_menu.Height));
        }

        private void deleteImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void replaceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectImage.SelectImage.OpenImage())
                LoadImagePreview();
        }
    }
}
