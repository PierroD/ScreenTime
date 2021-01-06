using ScreenTime.Utils;
using ScreenTimeBackend.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTime.Views.ProcessusModel
{
    public partial class UC_ProcessusModel : UserControl
    {
        dynamic processus;
        string categoryName;
        public UC_ProcessusModel(object processus, string categoryName)
        {
            this.processus = processus;
            this.categoryName = categoryName;
            InitializeComponent();
        }

        private void UC_ProcessusModel_Load(object sender, EventArgs e)
        {
            lbl_processusName.Text = processus.Name;
            string ProcessPath = ProcessHelper.GetPathFromProcessusName(processus.Name);
            if (ProcessPath != String.Empty)
                pbox_processImage.Image = System.Drawing.Icon.ExtractAssociatedIcon(ProcessPath).ToBitmap();

        }
        private void pbox_delete_Click(object sender, EventArgs e)
        {
            ProcessusController.DeleteProcessus(categoryName, processus.Name);
            this.Dispose();
        }
    }
}
