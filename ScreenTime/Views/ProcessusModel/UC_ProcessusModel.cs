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
            try
            {
                pbox_processImage.Image = System.Drawing.Icon.ExtractAssociatedIcon(ProcessHelper.GetPathFromProcessId(Process.GetProcessesByName(processus.Name)[0])).ToBitmap();
            }
            catch (Exception ex)
            { }
            }

            private void pbox_delete_Click(object sender, EventArgs e)
            {
                ProcessusController.DeleteProcessus(categoryName, processus.Name);
                this.Dispose();
            }
        }
    }
