
namespace ScreenTime
{
    partial class form_ScreenTime
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_left = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_CreateCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.pnl_categories = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.pbox_Settings = new FontAwesome.Sharp.IconPictureBox();
            this.pbox_Home = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_top = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.drag_form = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_main = new Guna.UI2.WinForms.Guna2Panel();
            this.pbox_categoryIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_categoryName = new Guna.UI.WinForms.GunaLabel();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Home)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_categoryIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.White;
            this.pnl_left.BorderRadius = 25;
            this.pnl_left.Controls.Add(this.guna2Separator1);
            this.pnl_left.Controls.Add(this.btn_CreateCategory);
            this.pnl_left.Controls.Add(this.lbl_categories);
            this.pnl_left.Controls.Add(this.pnl_categories);
            this.pnl_left.Controls.Add(this.pnl_sidebar);
            this.pnl_left.Controls.Add(this.pbox_Settings);
            this.pnl_left.Controls.Add(this.pbox_Home);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.ShadowDecoration.Parent = this.pnl_left;
            this.pnl_left.Size = new System.Drawing.Size(165, 640);
            this.pnl_left.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(5, 190);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(155, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // btn_CreateCategory
            // 
            this.btn_CreateCategory.BorderRadius = 5;
            this.btn_CreateCategory.CheckedState.Parent = this.btn_CreateCategory;
            this.btn_CreateCategory.CustomImages.Parent = this.btn_CreateCategory;
            this.btn_CreateCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.btn_CreateCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.btn_CreateCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_CreateCategory.ForeColor = System.Drawing.Color.White;
            this.btn_CreateCategory.HoverState.Parent = this.btn_CreateCategory;
            this.btn_CreateCategory.Location = new System.Drawing.Point(5, 601);
            this.btn_CreateCategory.Name = "btn_CreateCategory";
            this.btn_CreateCategory.ShadowDecoration.Parent = this.btn_CreateCategory;
            this.btn_CreateCategory.Size = new System.Drawing.Size(154, 36);
            this.btn_CreateCategory.TabIndex = 2;
            this.btn_CreateCategory.Text = "Create a category";
            this.btn_CreateCategory.Click += new System.EventHandler(this.btn_CreateCategory_Click);
            // 
            // lbl_categories
            // 
            this.lbl_categories.AutoSize = true;
            this.lbl_categories.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categories.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_categories.Location = new System.Drawing.Point(47, 170);
            this.lbl_categories.Name = "lbl_categories";
            this.lbl_categories.Size = new System.Drawing.Size(71, 17);
            this.lbl_categories.TabIndex = 4;
            this.lbl_categories.Text = "Categories";
            // 
            // pnl_categories
            // 
            this.pnl_categories.Location = new System.Drawing.Point(0, 204);
            this.pnl_categories.Name = "pnl_categories";
            this.pnl_categories.Size = new System.Drawing.Size(165, 391);
            this.pnl_categories.TabIndex = 3;
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.pnl_sidebar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 69);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.ShadowDecoration.Parent = this.pnl_sidebar;
            this.pnl_sidebar.Size = new System.Drawing.Size(3, 26);
            this.pnl_sidebar.TabIndex = 2;
            // 
            // pbox_Settings
            // 
            this.pbox_Settings.BackColor = System.Drawing.Color.White;
            this.pbox_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Settings.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbox_Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.pbox_Settings.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbox_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbox_Settings.Location = new System.Drawing.Point(12, 118);
            this.pbox_Settings.Name = "pbox_Settings";
            this.pbox_Settings.Size = new System.Drawing.Size(147, 32);
            this.pbox_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_Settings.TabIndex = 1;
            this.pbox_Settings.TabStop = false;
            this.pbox_Settings.Click += new System.EventHandler(this.pbox_Settings_Click);
            // 
            // pbox_Home
            // 
            this.pbox_Home.BackColor = System.Drawing.Color.White;
            this.pbox_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_Home.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbox_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.pbox_Home.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbox_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbox_Home.Location = new System.Drawing.Point(12, 69);
            this.pbox_Home.Name = "pbox_Home";
            this.pbox_Home.Size = new System.Drawing.Size(147, 32);
            this.pbox_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_Home.TabIndex = 0;
            this.pbox_Home.TabStop = false;
            this.pbox_Home.Click += new System.EventHandler(this.pbox_Home_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.White;
            this.pnl_top.Controls.Add(this.lbl_categoryName);
            this.pnl_top.Controls.Add(this.pbox_categoryIcon);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(165, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.ShadowDecoration.Parent = this.pnl_top;
            this.pnl_top.Size = new System.Drawing.Size(859, 45);
            this.pnl_top.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FillColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(806, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.PressedColor = System.Drawing.Color.Red;
            this.btn_close.PressedDepth = 50;
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(45, 29);
            this.btn_close.TabIndex = 0;
            // 
            // drag_form
            // 
            this.drag_form.ContainerControl = this;
            this.drag_form.TargetControl = this.pnl_top;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(165, 45);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.ShadowDecoration.Parent = this.pnl_main;
            this.pnl_main.Size = new System.Drawing.Size(859, 595);
            this.pnl_main.TabIndex = 3;
            // 
            // pbox_categoryIcon
            // 
            this.pbox_categoryIcon.Location = new System.Drawing.Point(6, 0);
            this.pbox_categoryIcon.Name = "pbox_categoryIcon";
            this.pbox_categoryIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbox_categoryIcon.ShadowDecoration.Parent = this.pbox_categoryIcon;
            this.pbox_categoryIcon.Size = new System.Drawing.Size(45, 45);
            this.pbox_categoryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_categoryIcon.TabIndex = 1;
            this.pbox_categoryIcon.TabStop = false;
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.lbl_categoryName.Location = new System.Drawing.Point(59, 12);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(0, 21);
            this.lbl_categoryName.TabIndex = 2;
            // 
            // form_ScreenTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_left);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ScreenTime";
            this.Text = "ScreenTime";
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Home)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_categoryIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_left;
        private Guna.UI2.WinForms.Guna2Panel pnl_top;
        private Guna.UI2.WinForms.Guna2GradientButton btn_CreateCategory;
        private Guna.UI2.WinForms.Guna2DragControl drag_form;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private FontAwesome.Sharp.IconPictureBox pbox_Home;
        private FontAwesome.Sharp.IconPictureBox pbox_Settings;
        private Guna.UI2.WinForms.Guna2Panel pnl_sidebar;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.FlowLayoutPanel pnl_categories;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel pnl_main;
        private Guna.UI.WinForms.GunaLabel lbl_categoryName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbox_categoryIcon;
    }
}

