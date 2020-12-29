
namespace ScreenTime.Views.CreateCategory
{
    partial class UC_ImagePreview
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
            this.components = new System.ComponentModel.Container();
            this.pbox_previewImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_menu = new Guna.UI2.WinForms.Guna2CircleButton();
            this.menu_preview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_previewImage)).BeginInit();
            this.menu_preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_previewImage
            // 
            this.pbox_previewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_previewImage.FillColor = System.Drawing.Color.Transparent;
            this.pbox_previewImage.Location = new System.Drawing.Point(0, 0);
            this.pbox_previewImage.Name = "pbox_previewImage";
            this.pbox_previewImage.ShadowDecoration.Parent = this.pbox_previewImage;
            this.pbox_previewImage.Size = new System.Drawing.Size(200, 200);
            this.pbox_previewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_previewImage.TabIndex = 0;
            this.pbox_previewImage.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.CheckedState.Parent = this.btn_menu;
            this.btn_menu.CustomImages.Parent = this.btn_menu;
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.HoverState.Parent = this.btn_menu;
            this.btn_menu.IndicateFocus = true;
            this.btn_menu.Location = new System.Drawing.Point(160, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_menu.ShadowDecoration.Parent = this.btn_menu;
            this.btn_menu.Size = new System.Drawing.Size(35, 35);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "···";
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // menu_preview
            // 
            this.menu_preview.BackColor = System.Drawing.Color.White;
            this.menu_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu_preview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteImageToolStripMenuItem,
            this.replaceImageToolStripMenuItem});
            this.menu_preview.Name = "contextMenuStrip1";
            this.menu_preview.Size = new System.Drawing.Size(152, 48);
            // 
            // deleteImageToolStripMenuItem
            // 
            this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
            this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteImageToolStripMenuItem.Text = "Delete Image";
            this.deleteImageToolStripMenuItem.Click += new System.EventHandler(this.deleteImageToolStripMenuItem_Click);
            // 
            // replaceImageToolStripMenuItem
            // 
            this.replaceImageToolStripMenuItem.Name = "replaceImageToolStripMenuItem";
            this.replaceImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceImageToolStripMenuItem.Text = "Replace Image";
            this.replaceImageToolStripMenuItem.Click += new System.EventHandler(this.replaceImageToolStripMenuItem_Click);
            // 
            // UC_ImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.pbox_previewImage);
            this.Name = "UC_ImagePreview";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_previewImage)).EndInit();
            this.menu_preview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbox_previewImage;
        private Guna.UI2.WinForms.Guna2CircleButton btn_menu;
        private System.Windows.Forms.ContextMenuStrip menu_preview;
        private System.Windows.Forms.ToolStripMenuItem deleteImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceImageToolStripMenuItem;
    }
}
