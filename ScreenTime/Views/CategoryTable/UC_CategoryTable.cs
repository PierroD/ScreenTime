using ScreenTime.Models;
using ScreenTime.Utils;
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
            LoadChartAndTable();
        }


        private int maxProcessus;
        private void lbl_add5More_Click(object sender, EventArgs e)
        {
            for (int i = maxProcessus; i < maxProcessus + 5; i++)
                if (category.Applications[i] != null)
                    pnl_processus.Controls.Add(new UC_ProcessusModel(category.Applications[i], category.Name));
            maxProcessus += 5;
        }

        private void cbox_since_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartAndTable();
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

                CheckRunningApplication();
            }
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

        private List<string> allProcessus = new List<string>();
        private void CheckRunningApplication()
        {
            if (category.Applications != null)
                foreach (var processus in category.Applications)
                    if (!allProcessus.Contains(processus.Name) && ProcessHelper.IsRunningProcessusByName(processus.Name))
                    {
                        OpenTimeController.addOpenTime(processus);
                        allProcessus.Add(processus.Name);
                    }
        }

        private void LoadChartAndTable()
        {
            List<Data> datas = GetDatas();
            chart_Applications.DataSource = datas;
            chart_Applications.Series["Hours"].XValueMember = "ProcessusName";
            chart_Applications.Series["Hours"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart_Applications.Series["Hours"].YValueMembers = "TotalHours";
            chart_Applications.Series["Hours"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            grid_Applications.DataSource = datas;
        }

        private List<Data> GetDatas()
        {
            List<Data> datas = new List<Data>();
            DateTime since = GetSinceChoice();
            if (category.Applications != null)
                foreach (var processus in category.Applications)
                {
                    double totalHours = 0.0;
                    if (processus.OpenTimes != null)
                    {
                        foreach (var OpenTime in processus.OpenTimes)
                        {
                            if (OpenTime.Day > since)
                                totalHours += OpenTime.TimeOpen.TotalHours;
                        }
                    }
                    datas.Add(new Data { ProcessusName = processus.Name, TotalHours = totalHours });
                }
            return datas;
        }

        private DateTime GetSinceChoice()
        {
            DateTime dateNow = DateTime.Now;
            switch (cbox_since.SelectedIndex)
            {
                case 0:
                    return new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0).AddDays(-1);
                case 1:
                    return new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0).AddDays(-7);
                case 2:
                    return new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0).AddMonths(-1);
                default:
                    return new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, 0, 0, 0).AddDays(-7);
            }
        }


    }
}
