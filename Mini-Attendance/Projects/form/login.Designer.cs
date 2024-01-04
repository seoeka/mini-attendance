namespace Mini_Attendance
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new Mini_Attendance.RoundedPanel();
            this.pictureBoxUnhide = new System.Windows.Forms.PictureBox();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.btMasuk = new RoundedButton();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.textBoxUN = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistem Kehadiran Universitas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxIcon.Image = global::Mini_Attendance.Properties.Resources.university;
            this.pictureBoxIcon.Location = new System.Drawing.Point(237, 54);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(220, 220);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 6;
            this.pictureBoxIcon.TabStop = false;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMin.Image = global::Mini_Attendance.Properties.Resources.minimizeWindow;
            this.pictureBoxMin.Location = new System.Drawing.Point(628, 12);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMin.TabIndex = 1;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMin.MouseHover += new System.EventHandler(this.pictureBoxMin_MouseHover);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::Mini_Attendance.Properties.Resources.closeWindow;
            this.pictureBoxClose.Location = new System.Drawing.Point(658, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderRadius = 25;
            this.roundedPanel1.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(219)))), ((int)(((byte)(196)))));
            this.roundedPanel1.Controls.Add(this.pictureBoxUnhide);
            this.roundedPanel1.Controls.Add(this.pictureBoxHide);
            this.roundedPanel1.Controls.Add(this.btMasuk);
            this.roundedPanel1.Controls.Add(this.pictureBoxError);
            this.roundedPanel1.Controls.Add(this.labelError);
            this.roundedPanel1.Controls.Add(this.lblUser);
            this.roundedPanel1.Controls.Add(this.textBoxUN);
            this.roundedPanel1.Controls.Add(this.textBoxPW);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.Location = new System.Drawing.Point(94, 353);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(504, 284);
            this.roundedPanel1.TabIndex = 7;
            // 
            // pictureBoxUnhide
            // 
            this.pictureBoxUnhide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxUnhide.Image = global::Mini_Attendance.Properties.Resources.pwUnhide;
            this.pictureBoxUnhide.Location = new System.Drawing.Point(388, 144);
            this.pictureBoxUnhide.Name = "pictureBoxUnhide";
            this.pictureBoxUnhide.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUnhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUnhide.TabIndex = 11;
            this.pictureBoxUnhide.TabStop = false;
            this.pictureBoxUnhide.Click += new System.EventHandler(this.pictureBoxUnhide_Click);
            this.pictureBoxUnhide.MouseHover += new System.EventHandler(this.pictureBoxUnhide_MouseHover);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHide.Image = global::Mini_Attendance.Properties.Resources.pwHide;
            this.pictureBoxHide.Location = new System.Drawing.Point(388, 144);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHide.TabIndex = 10;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            this.pictureBoxHide.MouseHover += new System.EventHandler(this.pictureBoxHide_MouseHover);
            // 
            // btMasuk
            // 
            this.btMasuk.BackColor = System.Drawing.Color.Transparent;
            this.btMasuk.BorderRadius = 10;
            this.btMasuk.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btMasuk.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMasuk.ForeColor = System.Drawing.Color.White;
            this.btMasuk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.btMasuk.Location = new System.Drawing.Point(312, 213);
            this.btMasuk.Name = "btMasuk";
            this.btMasuk.Size = new System.Drawing.Size(106, 37);
            this.btMasuk.TabIndex = 8;
            this.btMasuk.Text = "Masuk";
            this.btMasuk.UseVisualStyleBackColor = false;
            this.btMasuk.Click += new System.EventHandler(this.btMasuk_Click);
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxError.Image = global::Mini_Attendance.Properties.Resources.icons8_exclamation_48;
            this.pictureBoxError.Location = new System.Drawing.Point(84, 179);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 8;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.labelError.Location = new System.Drawing.Point(110, 181);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(265, 18);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Username atau Password Anda salah!";
            this.labelError.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(80, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(108, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username :";
            // 
            // textBoxUN
            // 
            this.textBoxUN.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUN.ForeColor = System.Drawing.Color.Black;
            this.textBoxUN.Location = new System.Drawing.Point(84, 65);
            this.textBoxUN.Name = "textBoxUN";
            this.textBoxUN.Size = new System.Drawing.Size(334, 30);
            this.textBoxUN.TabIndex = 0;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPW.ForeColor = System.Drawing.Color.Black;
            this.textBoxPW.Location = new System.Drawing.Point(84, 144);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(300, 30);
            this.textBoxPW.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMin);
            this.Controls.Add(this.pictureBoxClose);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox textBoxUN;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPW;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private RoundedButton btMasuk;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.PictureBox pictureBoxUnhide;
    }
}

