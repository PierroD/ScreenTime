
namespace ScreenTime.Views.CategoryTable
{
    partial class UC_CategoryTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_processusList = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_add5More = new System.Windows.Forms.Label();
            this.lbl_processusStatus = new Guna.UI.WinForms.GunaLabel();
            this.pnl_processus = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_searchProcessus = new FontAwesome.Sharp.IconPictureBox();
            this.tbox_seachProcessus = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.grid_Applications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_since = new Guna.UI.WinForms.GunaLabel();
            this.cbox_since = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chart_Applications = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_applicationRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_searchProcessus)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Applications)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Applications)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_processusList
            // 
            this.lbl_processusList.AutoSize = true;
            this.lbl_processusList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_processusList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lbl_processusList.Location = new System.Drawing.Point(118, 29);
            this.lbl_processusList.Name = "lbl_processusList";
            this.lbl_processusList.Size = new System.Drawing.Size(169, 30);
            this.lbl_processusList.TabIndex = 3;
            this.lbl_processusList.Text = "PROCESSUS LIST";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.lbl_add5More);
            this.guna2Panel1.Controls.Add(this.lbl_processusStatus);
            this.guna2Panel1.Controls.Add(this.pnl_processus);
            this.guna2Panel1.Controls.Add(this.btn_searchProcessus);
            this.guna2Panel1.Controls.Add(this.tbox_seachProcessus);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(36, 62);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(333, 504);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lbl_add5More
            // 
            this.lbl_add5More.AutoSize = true;
            this.lbl_add5More.BackColor = System.Drawing.Color.White;
            this.lbl_add5More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_add5More.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.lbl_add5More.Location = new System.Drawing.Point(249, 472);
            this.lbl_add5More.Name = "lbl_add5More";
            this.lbl_add5More.Size = new System.Drawing.Size(61, 13);
            this.lbl_add5More.TabIndex = 6;
            this.lbl_add5More.Text = "+ See more";
            this.lbl_add5More.Click += new System.EventHandler(this.lbl_add5More_Click);
            // 
            // lbl_processusStatus
            // 
            this.lbl_processusStatus.AutoSize = true;
            this.lbl_processusStatus.BackColor = System.Drawing.Color.White;
            this.lbl_processusStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_processusStatus.Location = new System.Drawing.Point(11, 471);
            this.lbl_processusStatus.Name = "lbl_processusStatus";
            this.lbl_processusStatus.Size = new System.Drawing.Size(113, 15);
            this.lbl_processusStatus.TabIndex = 0;
            this.lbl_processusStatus.Text = "No processus found";
            this.lbl_processusStatus.Visible = false;
            // 
            // pnl_processus
            // 
            this.pnl_processus.AutoScroll = true;
            this.pnl_processus.Location = new System.Drawing.Point(14, 72);
            this.pnl_processus.Name = "pnl_processus";
            this.pnl_processus.Size = new System.Drawing.Size(305, 396);
            this.pnl_processus.TabIndex = 5;
            // 
            // btn_searchProcessus
            // 
            this.btn_searchProcessus.BackColor = System.Drawing.Color.White;
            this.btn_searchProcessus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_searchProcessus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_searchProcessus.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_searchProcessus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.btn_searchProcessus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_searchProcessus.IconSize = 26;
            this.btn_searchProcessus.Location = new System.Drawing.Point(41, 28);
            this.btn_searchProcessus.Name = "btn_searchProcessus";
            this.btn_searchProcessus.Size = new System.Drawing.Size(26, 28);
            this.btn_searchProcessus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_searchProcessus.TabIndex = 4;
            this.btn_searchProcessus.TabStop = false;
            this.btn_searchProcessus.Click += new System.EventHandler(this.SearchProcessus);
            // 
            // tbox_seachProcessus
            // 
            this.tbox_seachProcessus.AutoRoundedCorners = true;
            this.tbox_seachProcessus.BackColor = System.Drawing.Color.White;
            this.tbox_seachProcessus.BorderColor = System.Drawing.Color.Black;
            this.tbox_seachProcessus.BorderRadius = 17;
            this.tbox_seachProcessus.BorderThickness = 0;
            this.tbox_seachProcessus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_seachProcessus.DefaultText = "";
            this.tbox_seachProcessus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_seachProcessus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_seachProcessus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_seachProcessus.DisabledState.Parent = this.tbox_seachProcessus;
            this.tbox_seachProcessus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_seachProcessus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.tbox_seachProcessus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_seachProcessus.FocusedState.Parent = this.tbox_seachProcessus;
            this.tbox_seachProcessus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_seachProcessus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_seachProcessus.HoverState.Parent = this.tbox_seachProcessus;
            this.tbox_seachProcessus.Location = new System.Drawing.Point(73, 23);
            this.tbox_seachProcessus.Name = "tbox_seachProcessus";
            this.tbox_seachProcessus.PasswordChar = '\0';
            this.tbox_seachProcessus.PlaceholderText = "Search process...";
            this.tbox_seachProcessus.SelectedText = "";
            this.tbox_seachProcessus.ShadowDecoration.Parent = this.tbox_seachProcessus;
            this.tbox_seachProcessus.Size = new System.Drawing.Size(222, 36);
            this.tbox_seachProcessus.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel2.BorderRadius = 25;
            this.guna2Panel2.Controls.Add(this.grid_Applications);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(394, 349);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(430, 217);
            this.guna2Panel2.TabIndex = 7;
            // 
            // grid_Applications
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_Applications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Applications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Applications.BackgroundColor = System.Drawing.Color.White;
            this.grid_Applications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Applications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_Applications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Applications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Applications.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Applications.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Applications.EnableHeadersVisualStyles = false;
            this.grid_Applications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_Applications.Location = new System.Drawing.Point(13, 18);
            this.grid_Applications.Name = "grid_Applications";
            this.grid_Applications.RowHeadersVisible = false;
            this.grid_Applications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Applications.Size = new System.Drawing.Size(405, 182);
            this.grid_Applications.TabIndex = 0;
            this.grid_Applications.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grid_Applications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_Applications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_Applications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_Applications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_Applications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_Applications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_Applications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_Applications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_Applications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_Applications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grid_Applications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_Applications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grid_Applications.ThemeStyle.HeaderStyle.Height = 21;
            this.grid_Applications.ThemeStyle.ReadOnly = false;
            this.grid_Applications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_Applications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_Applications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grid_Applications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_Applications.ThemeStyle.RowsStyle.Height = 22;
            this.grid_Applications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_Applications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.Controls.Add(this.lbl_since);
            this.guna2Panel3.Controls.Add(this.cbox_since);
            this.guna2Panel3.Controls.Add(this.chart_Applications);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(394, 62);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(430, 232);
            this.guna2Panel3.TabIndex = 8;
            // 
            // lbl_since
            // 
            this.lbl_since.AutoSize = true;
            this.lbl_since.BackColor = System.Drawing.Color.White;
            this.lbl_since.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_since.Location = new System.Drawing.Point(239, 10);
            this.lbl_since.Name = "lbl_since";
            this.lbl_since.Size = new System.Drawing.Size(54, 21);
            this.lbl_since.TabIndex = 2;
            this.lbl_since.Text = "Since :";
            // 
            // cbox_since
            // 
            this.cbox_since.BackColor = System.Drawing.Color.Transparent;
            this.cbox_since.BorderRadius = 5;
            this.cbox_since.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_since.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_since.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_since.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_since.FocusedState.Parent = this.cbox_since;
            this.cbox_since.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_since.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbox_since.HoverState.Parent = this.cbox_since;
            this.cbox_since.ItemHeight = 30;
            this.cbox_since.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month"});
            this.cbox_since.ItemsAppearance.Parent = this.cbox_since;
            this.cbox_since.Location = new System.Drawing.Point(299, 3);
            this.cbox_since.Name = "cbox_since";
            this.cbox_since.ShadowDecoration.Parent = this.cbox_since;
            this.cbox_since.Size = new System.Drawing.Size(103, 36);
            this.cbox_since.StartIndex = 1;
            this.cbox_since.TabIndex = 1;
            this.cbox_since.SelectedIndexChanged += new System.EventHandler(this.cbox_since_SelectedIndexChanged);
            // 
            // chart_Applications
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Applications.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Applications.Legends.Add(legend1);
            this.chart_Applications.Location = new System.Drawing.Point(26, 45);
            this.chart_Applications.Name = "chart_Applications";
            this.chart_Applications.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Hours";
            series1.YValuesPerPoint = 4;
            this.chart_Applications.Series.Add(series1);
            this.chart_Applications.Size = new System.Drawing.Size(388, 184);
            this.chart_Applications.TabIndex = 0;
            // 
            // lbl_applicationRecord
            // 
            this.lbl_applicationRecord.AutoSize = true;
            this.lbl_applicationRecord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applicationRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.lbl_applicationRecord.Location = new System.Drawing.Point(496, 316);
            this.lbl_applicationRecord.Name = "lbl_applicationRecord";
            this.lbl_applicationRecord.Size = new System.Drawing.Size(227, 30);
            this.lbl_applicationRecord.TabIndex = 9;
            this.lbl_applicationRecord.Text = "APPLICATION RECORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(557, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "GRAPH";
            // 
            // UC_CategoryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_applicationRecord);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lbl_processusList);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_CategoryTable";
            this.Size = new System.Drawing.Size(859, 595);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_searchProcessus)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Applications)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Applications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_processusList;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconPictureBox btn_searchProcessus;
        private Guna.UI2.WinForms.Guna2TextBox tbox_seachProcessus;
        private System.Windows.Forms.FlowLayoutPanel pnl_processus;
        private Guna.UI.WinForms.GunaLabel lbl_processusStatus;
        private System.Windows.Forms.Label lbl_add5More;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView grid_Applications;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Applications;
        private System.Windows.Forms.Label lbl_applicationRecord;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel lbl_since;
        private Guna.UI2.WinForms.Guna2ComboBox cbox_since;
    }
}
