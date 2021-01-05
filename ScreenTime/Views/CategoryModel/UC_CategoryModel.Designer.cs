
namespace ScreenTime.Views.CategoryModel
{
    partial class UC_CategoryModel
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
            this.lbl_categoryName = new Guna.UI.WinForms.GunaLabel();
            this.pbox_categoryIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_categoryIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryName.Location = new System.Drawing.Point(55, 11);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(75, 49);
            this.lbl_categoryName.TabIndex = 1;
            this.lbl_categoryName.Text = "Name";
            this.lbl_categoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_categoryName.Click += new System.EventHandler(this.LoadCategory);
            // 
            // pbox_categoryIcon
            // 
            this.pbox_categoryIcon.Location = new System.Drawing.Point(5, 13);
            this.pbox_categoryIcon.Name = "pbox_categoryIcon";
            this.pbox_categoryIcon.ShadowDecoration.Parent = this.pbox_categoryIcon;
            this.pbox_categoryIcon.Size = new System.Drawing.Size(44, 44);
            this.pbox_categoryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_categoryIcon.TabIndex = 2;
            this.pbox_categoryIcon.TabStop = false;
            this.pbox_categoryIcon.Click += new System.EventHandler(this.LoadCategory);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 60);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(130, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // UC_CategoryModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.pbox_categoryIcon);
            this.Controls.Add(this.lbl_categoryName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UC_CategoryModel";
            this.Size = new System.Drawing.Size(130, 70);
            this.Load += new System.EventHandler(this.UC_CategoryModel_Load);
            this.Click += new System.EventHandler(this.LoadCategory);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_categoryIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbl_categoryName;
        private Guna.UI2.WinForms.Guna2PictureBox pbox_categoryIcon;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
