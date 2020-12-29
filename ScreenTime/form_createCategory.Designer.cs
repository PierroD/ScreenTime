﻿
namespace ScreenTime
{
    partial class form_createCategory
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
            this.elipse_form = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_chooseImage = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_chooseImage = new System.Windows.Forms.Label();
            this.pbox_chooseImage = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Create = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_chooseImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_chooseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_form
            // 
            this.elipse_form.BorderRadius = 25;
            this.elipse_form.TargetControl = this;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(623, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.PressedColor = System.Drawing.Color.Red;
            this.btn_close.PressedDepth = 50;
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(45, 29);
            this.btn_close.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create a category";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(244, 101);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "My category";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(380, 36);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(244, 178);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Description";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(380, 103);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // pnl_chooseImage
            // 
            this.pnl_chooseImage.BackColor = System.Drawing.Color.White;
            this.pnl_chooseImage.Controls.Add(this.lbl_chooseImage);
            this.pnl_chooseImage.Controls.Add(this.pbox_chooseImage);
            this.pnl_chooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_chooseImage.Location = new System.Drawing.Point(21, 81);
            this.pnl_chooseImage.Name = "pnl_chooseImage";
            this.pnl_chooseImage.ShadowDecoration.Parent = this.pnl_chooseImage;
            this.pnl_chooseImage.Size = new System.Drawing.Size(200, 200);
            this.pnl_chooseImage.TabIndex = 7;
            this.pnl_chooseImage.Click += new System.EventHandler(this.ChooseImage);
            // 
            // lbl_chooseImage
            // 
            this.lbl_chooseImage.AutoSize = true;
            this.lbl_chooseImage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chooseImage.Location = new System.Drawing.Point(53, 125);
            this.lbl_chooseImage.Name = "lbl_chooseImage";
            this.lbl_chooseImage.Size = new System.Drawing.Size(95, 17);
            this.lbl_chooseImage.TabIndex = 1;
            this.lbl_chooseImage.Text = "Choose Image";
            this.lbl_chooseImage.Click += new System.EventHandler(this.ChooseImage);
            // 
            // pbox_chooseImage
            // 
            this.pbox_chooseImage.BackColor = System.Drawing.Color.White;
            this.pbox_chooseImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbox_chooseImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.pbox_chooseImage.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbox_chooseImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbox_chooseImage.IconSize = 63;
            this.pbox_chooseImage.Location = new System.Drawing.Point(66, 59);
            this.pbox_chooseImage.Name = "pbox_chooseImage";
            this.pbox_chooseImage.Size = new System.Drawing.Size(68, 63);
            this.pbox_chooseImage.TabIndex = 0;
            this.pbox_chooseImage.TabStop = false;
            this.pbox_chooseImage.Click += new System.EventHandler(this.ChooseImage);
            // 
            // btn_Create
            // 
            this.btn_Create.AutoRoundedCorners = true;
            this.btn_Create.BorderRadius = 17;
            this.btn_Create.CheckedState.Parent = this.btn_Create;
            this.btn_Create.CustomImages.Parent = this.btn_Create;
            this.btn_Create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.btn_Create.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(128)))), ((int)(((byte)(249)))));
            this.btn_Create.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Create.ForeColor = System.Drawing.Color.White;
            this.btn_Create.HoverState.Parent = this.btn_Create;
            this.btn_Create.IndicateFocus = true;
            this.btn_Create.Location = new System.Drawing.Point(269, 303);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.ShadowDecoration.Parent = this.btn_Create;
            this.btn_Create.Size = new System.Drawing.Size(143, 36);
            this.btn_Create.TabIndex = 8;
            this.btn_Create.Text = "Create";
            // 
            // form_createCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(680, 360);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.pnl_chooseImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_createCategory";
            this.Text = "form_createCategory";
            this.pnl_chooseImage.ResumeLayout(false);
            this.pnl_chooseImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_chooseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_form;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel pnl_chooseImage;
        private FontAwesome.Sharp.IconPictureBox pbox_chooseImage;
        private System.Windows.Forms.Label lbl_chooseImage;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Create;
    }
}