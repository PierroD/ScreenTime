
namespace ScreenTime.Views.ProcessusSearch
{
    partial class UC_ProcessusSearch
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
            this.pbox_addProcessus = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_processusName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_processusId = new Guna.UI.WinForms.GunaLabel();
            this.pbox_processImage = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_addProcessus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_processImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_addProcessus
            // 
            this.pbox_addProcessus.BackColor = System.Drawing.SystemColors.Control;
            this.pbox_addProcessus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbox_addProcessus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.pbox_addProcessus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.pbox_addProcessus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.pbox_addProcessus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbox_addProcessus.IconSize = 60;
            this.pbox_addProcessus.Location = new System.Drawing.Point(231, 9);
            this.pbox_addProcessus.Name = "pbox_addProcessus";
            this.pbox_addProcessus.Size = new System.Drawing.Size(32, 32);
            this.pbox_addProcessus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_addProcessus.TabIndex = 3;
            this.pbox_addProcessus.TabStop = false;
            this.pbox_addProcessus.Click += new System.EventHandler(this.pbox_addProcessus_Click);
            // 
            // lbl_processusName
            // 
            this.lbl_processusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_processusName.Location = new System.Drawing.Point(47, 9);
            this.lbl_processusName.Name = "lbl_processusName";
            this.lbl_processusName.Size = new System.Drawing.Size(178, 20);
            this.lbl_processusName.TabIndex = 2;
            this.lbl_processusName.Text = "Name";
            // 
            // lbl_processusId
            // 
            this.lbl_processusId.AutoSize = true;
            this.lbl_processusId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_processusId.ForeColor = System.Drawing.Color.Gray;
            this.lbl_processusId.Location = new System.Drawing.Point(50, 32);
            this.lbl_processusId.Name = "lbl_processusId";
            this.lbl_processusId.Size = new System.Drawing.Size(27, 15);
            this.lbl_processusId.TabIndex = 4;
            this.lbl_processusId.Text = "ID : ";
            // 
            // pbox_processImage
            // 
            this.pbox_processImage.Location = new System.Drawing.Point(8, 9);
            this.pbox_processImage.Name = "pbox_processImage";
            this.pbox_processImage.ShadowDecoration.Parent = this.pbox_processImage;
            this.pbox_processImage.Size = new System.Drawing.Size(33, 33);
            this.pbox_processImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_processImage.TabIndex = 5;
            this.pbox_processImage.TabStop = false;
            // 
            // UC_ProcessusSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbox_processImage);
            this.Controls.Add(this.lbl_processusId);
            this.Controls.Add(this.pbox_addProcessus);
            this.Controls.Add(this.lbl_processusName);
            this.Name = "UC_ProcessusSearch";
            this.Size = new System.Drawing.Size(280, 50);
            this.Load += new System.EventHandler(this.UC_ProcessusSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_addProcessus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_processImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pbox_addProcessus;
        private Guna.UI.WinForms.GunaLabel lbl_processusName;
        private Guna.UI.WinForms.GunaLabel lbl_processusId;
        private Guna.UI2.WinForms.Guna2PictureBox pbox_processImage;
    }
}
