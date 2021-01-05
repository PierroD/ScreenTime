using ScreenTime.Views.ProcessusModel;
using ScreenTime.Views.ProcessusSearch;
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

namespace ScreenTime.Views.CategoryTable
{
    public partial class UC_CategoryTable : UserControl
    {
        dynamic category;
        public UC_CategoryTable(string categoryName)
        {
            this.category = CategoryController.GetCategory(categoryName);
            InitializeComponent();
            LoadProcessus();
        }

        private void LoadProcessus()
        {
            pnl_processus.Controls.Clear();
            maxProcessus = 10;
            if (category.Applications == null)
                lbl_processusStatus.Visible = true;
            else
            {
                lbl_processusStatus.Visible = false;
                for (int i = 0; i < maxProcessus; i++)
                    if (category.Applications.Count > i)
                        if (category.Applications[i] != null)
                            pnl_processus.Controls.Add(new UC_ProcessusModel(category.Applications[i], category.Name));
            }
        }

        private int maxProcessus;
        private void lbl_add5More_Click(object sender, EventArgs e)
        {
            for (int i = maxProcessus; i < maxProcessus + 5; i++)
                if (category.Applications[i] != null)
                    pnl_processus.Controls.Add(new UC_ProcessusModel(category.Applications[i], category.Name));
            maxProcessus += 5;
        }


        private void SearchProcessus(object sender, EventArgs e)
        {
            if (tbox_seachProcessus.Text.Length == 0)
                LoadProcessus();
            else
            {
                pnl_processus.Controls.Clear();
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName.Contains(tbox_seachProcessus.Text))
                    {
                        if (category.Applications != null)
                        {
                            foreach (var application in category.Applications)
                                if (!application.Name.Equals(process.ProcessName))
                                    pnl_processus.Controls.Add(new UC_ProcessusSearch(process, category.Name));
                        }
                        else
                            pnl_processus.Controls.Add(new UC_ProcessusSearch(process, category.Name));
                    }
                }
            }
        }
    }
}
