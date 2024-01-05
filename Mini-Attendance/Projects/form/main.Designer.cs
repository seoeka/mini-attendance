namespace Mini_Attendance.form
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelIkon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelActive = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonLapor = new System.Windows.Forms.Button();
            this.buttonAcara = new System.Windows.Forms.Button();
            this.buttonHadir = new System.Windows.Forms.Button();
            this.buttonKelas = new System.Windows.Forms.Button();
            this.buttonMhs = new System.Windows.Forms.Button();
            this.buttonDosen = new System.Windows.Forms.Button();
            this.buttonBeranda = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.userControlLaporan1 = new Mini_Attendance.Projects.user_controls.UserControlLaporan();
            this.userControlEvent1 = new Mini_Attendance.Projects.user_controls.UserControlEvent();
            this.userControlHadir1 = new Mini_Attendance.Projects.user_controls.UserControlHadir();
            this.userControlKelas1 = new Mini_Attendance.Projects.user_controls.UserControlKelas();
            this.userControlMahasiswa1 = new Mini_Attendance.Projects.user_controls.UserControlMahasiswa();
            this.userControlDo1 = new Mini_Attendance.Projects.user_controls.UserControlDo();
            this.userControlBeranda1 = new Mini_Attendance.Projects.user_controls.UserControlBeranda();
            this.panelIkon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIkon
            // 
            this.panelIkon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIkon.Controls.Add(this.pictureBox1);
            this.panelIkon.Controls.Add(this.label1);
            this.panelIkon.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIkon.Location = new System.Drawing.Point(0, 0);
            this.panelIkon.Name = "panelIkon";
            this.panelIkon.Size = new System.Drawing.Size(182, 180);
            this.panelIkon.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Mini_Attendance.Properties.Resources.university;
            this.pictureBox1.Location = new System.Drawing.Point(35, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistem Absensi\r\nUniversitas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.labelUserName.Location = new System.Drawing.Point(353, 19);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(165, 19);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "{-}";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.panel2);
            this.panelInfo.Controls.Add(this.labelUserName);
            this.panelInfo.Controls.Add(this.label10);
            this.panelInfo.Controls.Add(this.pictureBoxMin);
            this.panelInfo.Controls.Add(this.panelIkon);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1200, 180);
            this.panelInfo.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelBottom);
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(182, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 114);
            this.panel2.TabIndex = 8;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.panelActive);
            this.panelBottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 110);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1018, 4);
            this.panelBottom.TabIndex = 6;
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.Color.Silver;
            this.panelActive.Location = new System.Drawing.Point(0, 0);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(110, 4);
            this.panelActive.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.buttonKeluar);
            this.panelMenu.Controls.Add(this.buttonLapor);
            this.panelMenu.Controls.Add(this.buttonAcara);
            this.panelMenu.Controls.Add(this.buttonHadir);
            this.panelMenu.Controls.Add(this.buttonKelas);
            this.panelMenu.Controls.Add(this.buttonMhs);
            this.panelMenu.Controls.Add(this.buttonDosen);
            this.panelMenu.Controls.Add(this.buttonBeranda);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1018, 110);
            this.panelMenu.TabIndex = 5;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonKeluar.FlatAppearance.BorderSize = 0;
            this.buttonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeluar.Image = global::Mini_Attendance.Properties.Resources.iconLogout;
            this.buttonKeluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKeluar.Location = new System.Drawing.Point(770, 0);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonKeluar.Size = new System.Drawing.Size(110, 110);
            this.buttonKeluar.TabIndex = 15;
            this.buttonKeluar.Text = "\r\nKeluar";
            this.buttonKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonLapor
            // 
            this.buttonLapor.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLapor.FlatAppearance.BorderSize = 0;
            this.buttonLapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLapor.Image = global::Mini_Attendance.Properties.Resources.iconReport;
            this.buttonLapor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLapor.Location = new System.Drawing.Point(660, 0);
            this.buttonLapor.Name = "buttonLapor";
            this.buttonLapor.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonLapor.Size = new System.Drawing.Size(110, 110);
            this.buttonLapor.TabIndex = 14;
            this.buttonLapor.Text = "\r\nLaporan";
            this.buttonLapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLapor.UseVisualStyleBackColor = true;
            this.buttonLapor.Click += new System.EventHandler(this.buttonLapor_Click);
            // 
            // buttonAcara
            // 
            this.buttonAcara.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAcara.FlatAppearance.BorderSize = 0;
            this.buttonAcara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcara.Image = global::Mini_Attendance.Properties.Resources.iconEvent;
            this.buttonAcara.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAcara.Location = new System.Drawing.Point(550, 0);
            this.buttonAcara.Name = "buttonAcara";
            this.buttonAcara.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonAcara.Size = new System.Drawing.Size(110, 110);
            this.buttonAcara.TabIndex = 13;
            this.buttonAcara.Text = "\r\nAcara";
            this.buttonAcara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAcara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAcara.UseVisualStyleBackColor = true;
            this.buttonAcara.Click += new System.EventHandler(this.buttonAcara_Click);
            // 
            // buttonHadir
            // 
            this.buttonHadir.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHadir.FlatAppearance.BorderSize = 0;
            this.buttonHadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHadir.Image = global::Mini_Attendance.Properties.Resources.iconAttend;
            this.buttonHadir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHadir.Location = new System.Drawing.Point(440, 0);
            this.buttonHadir.Name = "buttonHadir";
            this.buttonHadir.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonHadir.Size = new System.Drawing.Size(110, 110);
            this.buttonHadir.TabIndex = 12;
            this.buttonHadir.Text = "\r\nKehadiran";
            this.buttonHadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHadir.UseVisualStyleBackColor = true;
            this.buttonHadir.Click += new System.EventHandler(this.buttonHadir_Click);
            // 
            // buttonKelas
            // 
            this.buttonKelas.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonKelas.FlatAppearance.BorderSize = 0;
            this.buttonKelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKelas.Image = global::Mini_Attendance.Properties.Resources.iconClass;
            this.buttonKelas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonKelas.Location = new System.Drawing.Point(330, 0);
            this.buttonKelas.Name = "buttonKelas";
            this.buttonKelas.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonKelas.Size = new System.Drawing.Size(110, 110);
            this.buttonKelas.TabIndex = 11;
            this.buttonKelas.Text = "\r\nKelas";
            this.buttonKelas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonKelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonKelas.UseVisualStyleBackColor = true;
            this.buttonKelas.Click += new System.EventHandler(this.buttonKelas_Click);
            // 
            // buttonMhs
            // 
            this.buttonMhs.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMhs.FlatAppearance.BorderSize = 0;
            this.buttonMhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMhs.Image = ((System.Drawing.Image)(resources.GetObject("buttonMhs.Image")));
            this.buttonMhs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMhs.Location = new System.Drawing.Point(220, 0);
            this.buttonMhs.Name = "buttonMhs";
            this.buttonMhs.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonMhs.Size = new System.Drawing.Size(110, 110);
            this.buttonMhs.TabIndex = 10;
            this.buttonMhs.Text = "\r\nMahasiswa";
            this.buttonMhs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMhs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMhs.UseVisualStyleBackColor = true;
            this.buttonMhs.Click += new System.EventHandler(this.buttonMhs_Click);
            // 
            // buttonDosen
            // 
            this.buttonDosen.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDosen.FlatAppearance.BorderSize = 0;
            this.buttonDosen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDosen.Image = ((System.Drawing.Image)(resources.GetObject("buttonDosen.Image")));
            this.buttonDosen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDosen.Location = new System.Drawing.Point(110, 0);
            this.buttonDosen.Name = "buttonDosen";
            this.buttonDosen.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonDosen.Size = new System.Drawing.Size(110, 110);
            this.buttonDosen.TabIndex = 9;
            this.buttonDosen.Text = "\r\nDosen";
            this.buttonDosen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDosen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDosen.UseVisualStyleBackColor = true;
            this.buttonDosen.Click += new System.EventHandler(this.buttonDosen_Click);
            // 
            // buttonBeranda
            // 
            this.buttonBeranda.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBeranda.FlatAppearance.BorderSize = 0;
            this.buttonBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeranda.Image = ((System.Drawing.Image)(resources.GetObject("buttonBeranda.Image")));
            this.buttonBeranda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBeranda.Location = new System.Drawing.Point(0, 0);
            this.buttonBeranda.Name = "buttonBeranda";
            this.buttonBeranda.Padding = new System.Windows.Forms.Padding(0, 15, 0, 8);
            this.buttonBeranda.Size = new System.Drawing.Size(110, 110);
            this.buttonBeranda.TabIndex = 8;
            this.buttonBeranda.Text = "\r\nBeranda";
            this.buttonBeranda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBeranda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBeranda.UseVisualStyleBackColor = true;
            this.buttonBeranda.Click += new System.EventHandler(this.buttonBeranda_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Selamat Datang";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMin.Image = global::Mini_Attendance.Properties.Resources.minimizeWindow;
            this.pictureBoxMin.Location = new System.Drawing.Point(1158, 7);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMin.TabIndex = 3;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            this.pictureBoxMin.MouseHover += new System.EventHandler(this.pictureBoxMin_MouseHover);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.userControlLaporan1);
            this.panelMain.Controls.Add(this.userControlEvent1);
            this.panelMain.Controls.Add(this.userControlHadir1);
            this.panelMain.Controls.Add(this.userControlKelas1);
            this.panelMain.Controls.Add(this.userControlMahasiswa1);
            this.panelMain.Controls.Add(this.userControlDo1);
            this.panelMain.Controls.Add(this.userControlBeranda1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 180);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 520);
            this.panelMain.TabIndex = 6;
            // 
            // userControlLaporan1
            // 
            this.userControlLaporan1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlLaporan1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlLaporan1.Location = new System.Drawing.Point(0, 21);
            this.userControlLaporan1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlLaporan1.Name = "userControlLaporan1";
            this.userControlLaporan1.Size = new System.Drawing.Size(1200, 480);
            this.userControlLaporan1.TabIndex = 6;
            this.userControlLaporan1.Visible = false;
            // 
            // userControlEvent1
            // 
            this.userControlEvent1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlEvent1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlEvent1.Location = new System.Drawing.Point(0, 21);
            this.userControlEvent1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlEvent1.Name = "userControlEvent1";
            this.userControlEvent1.Size = new System.Drawing.Size(1200, 480);
            this.userControlEvent1.TabIndex = 5;
            this.userControlEvent1.Visible = false;
            // 
            // userControlHadir1
            // 
            this.userControlHadir1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlHadir1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlHadir1.Location = new System.Drawing.Point(0, 21);
            this.userControlHadir1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlHadir1.Name = "userControlHadir1";
            this.userControlHadir1.Size = new System.Drawing.Size(1200, 480);
            this.userControlHadir1.TabIndex = 4;
            this.userControlHadir1.UserID = 0;
            this.userControlHadir1.UserRole = null;
            this.userControlHadir1.Visible = false;
            // 
            // userControlKelas1
            // 
            this.userControlKelas1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlKelas1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlKelas1.Location = new System.Drawing.Point(0, 21);
            this.userControlKelas1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlKelas1.Name = "userControlKelas1";
            this.userControlKelas1.Size = new System.Drawing.Size(1200, 480);
            this.userControlKelas1.TabIndex = 3;
            this.userControlKelas1.Visible = false;
            // 
            // userControlMahasiswa1
            // 
            this.userControlMahasiswa1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlMahasiswa1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlMahasiswa1.Location = new System.Drawing.Point(0, 21);
            this.userControlMahasiswa1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlMahasiswa1.Name = "userControlMahasiswa1";
            this.userControlMahasiswa1.Size = new System.Drawing.Size(1200, 480);
            this.userControlMahasiswa1.TabIndex = 2;
            this.userControlMahasiswa1.Visible = false;
            // 
            // userControlDo1
            // 
            this.userControlDo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlDo1.AutoSize = true;
            this.userControlDo1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDo1.Location = new System.Drawing.Point(0, 21);
            this.userControlDo1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDo1.Name = "userControlDo1";
            this.userControlDo1.Size = new System.Drawing.Size(1200, 480);
            this.userControlDo1.TabIndex = 1;
            this.userControlDo1.Visible = false;
            // 
            // userControlBeranda1
            // 
            this.userControlBeranda1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlBeranda1.Location = new System.Drawing.Point(0, 21);
            this.userControlBeranda1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlBeranda1.Name = "userControlBeranda1";
            this.userControlBeranda1.Size = new System.Drawing.Size(1200, 450);
            this.userControlBeranda1.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelIkon.ResumeLayout(false);
            this.panelIkon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelIkon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBeranda;
        private System.Windows.Forms.Button buttonDosen;
        private System.Windows.Forms.Button buttonKelas;
        private System.Windows.Forms.Button buttonMhs;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonLapor;
        private System.Windows.Forms.Button buttonAcara;
        private System.Windows.Forms.Button buttonHadir;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelActive;
        private Projects.user_controls.UserControlBeranda userControlBeranda1;
        private Projects.user_controls.UserControlDo userControlDo1;
        private Projects.user_controls.UserControlMahasiswa userControlMahasiswa1;
        private Projects.user_controls.UserControlKelas userControlKelas1;
        private Projects.user_controls.UserControlHadir userControlHadir1;
        private Projects.user_controls.UserControlEvent userControlEvent1;
        private Projects.user_controls.UserControlLaporan userControlLaporan1;
    }
}