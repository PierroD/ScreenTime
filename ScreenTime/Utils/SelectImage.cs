using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectImage
{
    class SelectImage
    {
        private static string filepath;

        public static bool OpenImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file| *.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                return true;
            }
            return false;
        }

        public static string GetFilePath()
        {
            return filepath;
        }
    }
}
