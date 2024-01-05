namespace Mini_Attendance.Projects.user_controls
{
    partial class UserControlHadir
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewKehadiranKelas = new System.Windows.Forms.DataGridView();
            this.btDel = new RoundedButton();
            this.btEdi = new RoundedButton();
            this.btAdd = new RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKLS = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxMHS1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMHS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSTT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSTT1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKehadiranKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(137, 173);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(229, 27);
            this.dateTimePicker.TabIndex = 114;
            // 
            // dataGridViewKehadiranKelas
            // 
            this.dataGridViewKehadiranKelas.AllowUserToAddRows = false;
            this.dataGridViewKehadiranKelas.AllowUserToDeleteRows = false;
            this.dataGridViewKehadiranKelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKehadiranKelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKehadiranKelas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKehadiranKelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKehadiranKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKehadiranKelas.Location = new System.Drawing.Point(390, 36);
            this.dataGridViewKehadiranKelas.Name = "dataGridViewKehadiranKelas";
            this.dataGridViewKehadiranKelas.ReadOnly = true;
            this.dataGridViewKehadiranKelas.Size = new System.Drawing.Size(759, 408);
            this.dataGridViewKehadiranKelas.TabIndex = 110;
            // 
            // btDel
            // 
            this.btDel.BorderRadius = 10;
            this.btDel.ButtonColor = System.Drawing.Color.Firebrick;
            this.btDel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btDel.Location = new System.Drawing.Point(266, 420);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 33);
            this.btDel.TabIndex = 109;
            this.btDel.Text = "Hapus";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // btEdi
            // 
            this.btEdi.BorderRadius = 10;
            this.btEdi.ButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.btEdi.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdi.ForeColor = System.Drawing.Color.White;
            this.btEdi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(101)))));
            this.btEdi.Location = new System.Drawing.Point(160, 420);
            this.btEdi.Name = "btEdi";
            this.btEdi.Size = new System.Drawing.Size(100, 33);
            this.btEdi.TabIndex = 108;
            this.btEdi.Text = "Edit";
            this.btEdi.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 10;
            this.btAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btAdd.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.btAdd.Location = new System.Drawing.Point(266, 239);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 33);
            this.btAdd.TabIndex = 103;
            this.btAdd.Text = "Tambah";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "Kelas :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Tgl :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "Nama :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Tambah Kehadiran";
            // 
            // comboBoxKLS
            // 
            this.comboBoxKLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKLS.FormattingEnabled = true;
            this.comboBoxKLS.Location = new System.Drawing.Point(137, 53);
            this.comboBoxKLS.Name = "comboBoxKLS";
            this.comboBoxKLS.Size = new System.Drawing.Size(229, 27);
            this.comboBoxKLS.TabIndex = 118;
            this.comboBoxKLS.SelectedIndexChanged += new System.EventHandler(this.comboBoxKLS_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 354);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 27);
            this.dateTimePicker1.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 121;
            this.label8.Text = "Tgl :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 120;
            this.label9.Text = "Nama :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxMHS1
            // 
            this.comboBoxMHS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMHS1.FormattingEnabled = true;
            this.comboBoxMHS1.Location = new System.Drawing.Point(137, 321);
            this.comboBoxMHS1.Name = "comboBoxMHS1";
            this.comboBoxMHS1.Size = new System.Drawing.Size(229, 27);
            this.comboBoxMHS1.TabIndex = 127;
            // 
            // comboBoxMHS
            // 
            this.comboBoxMHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMHS.FormattingEnabled = true;
            this.comboBoxMHS.Location = new System.Drawing.Point(137, 142);
            this.comboBoxMHS.Name = "comboBoxMHS";
            this.comboBoxMHS.Size = new System.Drawing.Size(229, 27);
            this.comboBoxMHS.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 129;
            this.label2.Text = "Edit dan Hapus Kehadiran";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 130;
            this.label6.Text = "Kehadiran Kelas";
            // 
            // comboBoxSTT
            // 
            this.comboBoxSTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSTT.FormattingEnabled = true;
            this.comboBoxSTT.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Sakit",
            "Absen"});
            this.comboBoxSTT.Location = new System.Drawing.Point(137, 206);
            this.comboBoxSTT.Name = "comboBoxSTT";
            this.comboBoxSTT.Size = new System.Drawing.Size(229, 27);
            this.comboBoxSTT.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 131;
            this.label7.Text = "Status :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxSTT1
            // 
            this.comboBoxSTT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSTT1.FormattingEnabled = true;
            this.comboBoxSTT1.Items.AddRange(new object[] {
            "Hadir",
            "Izin",
            "Sakit",
            "Absen"});
            this.comboBoxSTT1.Location = new System.Drawing.Point(137, 387);
            this.comboBoxSTT1.Name = "comboBoxSTT1";
            this.comboBoxSTT1.Size = new System.Drawing.Size(229, 27);
            this.comboBoxSTT1.TabIndex = 134;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 133;
            this.label10.Text = "Status :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserControlHadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSTT1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxSTT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMHS);
            this.Controls.Add(this.comboBoxMHS1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxKLS);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dataGridViewKehadiranKelas);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdi);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlHadir";
            this.Size = new System.Drawing.Size(1200, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKehadiranKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewKehadiranKelas;
        private RoundedButton btDel;
        private RoundedButton btEdi;
        private RoundedButton btAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKLS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxMHS1;
        private System.Windows.Forms.ComboBox comboBoxMHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSTT1;
        private System.Windows.Forms.Label label10;
    }
}
