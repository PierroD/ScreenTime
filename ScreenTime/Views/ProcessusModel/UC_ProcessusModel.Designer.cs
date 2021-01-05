
namespace ScreenTime.Views.ProcessusModel
{
    partial class UC_ProcessusModel
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
            this.pbox_delete = new FontAwesome.Sharp.IconPictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pbox_processImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_processusName = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_processImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_delete
            // 
            this.pbox_delete.BackColor = System.Drawing.SystemColors.Control;
            this.pbox_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_delete.ForeColor = System.Drawing.Color.Red;
            this.pbox_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.pbox_delete.IconColor = System.Drawing.Color.Red;
            this.pbox_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbox_delete.IconSize = 60;
            this.pbox_delete.Location = new System.Drawing.Point(231, 9);
            this.pbox_delete.Name = "pbox_delete";
            this.pbox_delete.Size = new System.Drawing.Size(32, 32);
            this.pbox_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_delete.TabIndex = 1;
            this.pbox_delete.TabStop = false;
            this.pbox_delete.Click += new System.EventHandler(this.pbox_delete_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 41);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(280, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // pbox_processImage
            // 
            this.pbox_processImage.Location = new System.Drawing.Point(5, 9);
            this.pbox_processImage.Name = "pbox_processImage";
            this.pbox_processImage.ShadowDecoration.Parent = this.pbox_processImage;
            this.pbox_processImage.Size = new System.Drawing.Size(33, 33);
            this.pbox_processImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_processImage.TabIndex = 7;
            this.pbox_processImage.TabStop = false;
            // 
            // lbl_processusName
            // 
            this.lbl_processusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_processusName.Location = new System.Drawing.Point(44, 15);
            this.lbl_processusName.Name = "lbl_processusName";
            this.lbl_processusName.Size = new System.Drawing.Size(166, 20);
            this.lbl_processusName.TabIndex = 5;
            this.lbl_processusName.Text = "Name";
            // 
            // UC_ProcessusModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbox_processImage);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lbl_processusName);
            this.Controls.Add(this.pbox_delete);
            this.Name = "UC_ProcessusModel";
            this.Size = new System.Drawing.Size(280, 50);
            this.Load += new System.EventHandler(this.UC_ProcessusModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_processImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox pbox_delete;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox pbox_processImage;
        private Guna.UI.WinForms.GunaLabel lbl_processusName;
    }
}
