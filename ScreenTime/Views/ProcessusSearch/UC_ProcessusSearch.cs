using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using ScreenTime.Utils;
using ScreenTimeBackend.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTime.Views.ProcessusSearch
{
    public partial class UC_ProcessusSearch : UserControl
    {
        Process process;
        string categoryName;
        public UC_ProcessusSearch(Process process, string categoryName)
        {
            this.process = process;
            this.categoryName = categoryName;
            InitializeComponent();
        }

        private void UC_ProcessusSearch_Load(object sender, EventArgs e)
        {
            lbl_processusName.Text = process.ProcessName;
            lbl_processusId.Text += process.Id.ToString();
            pbox_processImage.Image = System.Drawing.Icon.ExtractAssociatedIcon(ProcessHelper.GetPathFromProcessId(process)).ToBitmap();
        }



        private void pbox_addProcessus_Click(object sender, EventArgs e)
        {
            ProcessusController.AddProcessus(categoryName, process.ProcessName);
            Guna2TextBox searchTbox = (Guna2TextBox)this.Parent.Parent.Controls.Find("tbox_seachProcessus", true).FirstOrDefault();
            searchTbox.Text = String.Empty;
            this.Dispose();
        }
    }
}
