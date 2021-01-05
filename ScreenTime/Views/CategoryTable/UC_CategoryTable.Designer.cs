
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_applicationRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProcessusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_searchProcessus)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.guna2Panel2.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(394, 349);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(430, 217);
            this.guna2Panel2.TabIndex = 7;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.Controls.Add(this.chart1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(394, 62);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(430, 232);
            this.guna2Panel3.TabIndex = 8;
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
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessusName,
            this.UsageTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(13, 18);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(405, 182);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProcessusName
            // 
            this.ProcessusName.HeaderText = "Processus Name";
            this.ProcessusName.Name = "ProcessusName";
            // 
            // UsageTime
            // 
            this.UsageTime.HeaderText = "Usage Time";
            this.UsageTime.Name = "UsageTime";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(26, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(388, 201);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsageTime;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_applicationRecord;
        private System.Windows.Forms.Label label2;
    }
}
