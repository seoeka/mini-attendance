namespace Mini_Attendance.Projects.user_controls
{
    partial class UserControlLaporan
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
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSet = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewKelas = new System.Windows.Forms.DataGridView();
            this.btPrint = new RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxJD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLihat = new RoundedButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(137, 206);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerEnd.TabIndex = 115;
            // 
            // dateTimePickerSet
            // 
            this.dateTimePickerSet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSet.Location = new System.Drawing.Point(137, 174);
            this.dateTimePickerSet.Name = "dateTimePickerSet";
            this.dateTimePickerSet.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerSet.TabIndex = 114;
            // 
            // dataGridViewKelas
            // 
            this.dataGridViewKelas.AllowUserToAddRows = false;
            this.dataGridViewKelas.AllowUserToDeleteRows = false;
            this.dataGridViewKelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKelas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKelas.Location = new System.Drawing.Point(390, 36);
            this.dataGridViewKelas.Name = "dataGridViewKelas";
            this.dataGridViewKelas.ReadOnly = true;
            this.dataGridViewKelas.Size = new System.Drawing.Size(759, 408);
            this.dataGridViewKelas.TabIndex = 110;
            // 
            // btPrint
            // 
            this.btPrint.BorderRadius = 10;
            this.btPrint.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btPrint.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.btPrint.Location = new System.Drawing.Point(266, 246);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(100, 33);
            this.btPrint.TabIndex = 103;
            this.btPrint.Text = "Cetak";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "Tgl Akhir :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Tgl Mulai :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Laporan Kehadiran";
            // 
            // comboBoxJD
            // 
            this.comboBoxJD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJD.FormattingEnabled = true;
            this.comboBoxJD.Items.AddRange(new object[] {
            "Dosen",
            "Kelas",
            "Mahasiswa",
            "Event"});
            this.comboBoxJD.Location = new System.Drawing.Point(137, 65);
            this.comboBoxJD.Name = "comboBoxJD";
            this.comboBoxJD.Size = new System.Drawing.Size(229, 27);
            this.comboBoxJD.TabIndex = 119;
            this.comboBoxJD.SelectedIndexChanged += new System.EventHandler(this.comboBoxJD_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 118;
            this.label6.Text = "Jenis Data :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxFN
            // 
            this.comboBoxFN.DisplayMember = "Semua";
            this.comboBoxFN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFN.FormattingEnabled = true;
            this.comboBoxFN.Location = new System.Drawing.Point(137, 96);
            this.comboBoxFN.Name = "comboBoxFN";
            this.comboBoxFN.Size = new System.Drawing.Size(229, 27);
            this.comboBoxFN.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 120;
            this.label2.Text = "Saring :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btLihat
            // 
            this.btLihat.BorderRadius = 10;
            this.btLihat.ButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.btLihat.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLihat.ForeColor = System.Drawing.Color.White;
            this.btLihat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(101)))));
            this.btLihat.Location = new System.Drawing.Point(160, 246);
            this.btLihat.Name = "btLihat";
            this.btLihat.Size = new System.Drawing.Size(100, 33);
            this.btLihat.TabIndex = 122;
            this.btLihat.Text = "Lihat";
            this.btLihat.UseVisualStyleBackColor = true;
            this.btLihat.Click += new System.EventHandler(this.btLihat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 23);
            this.checkBox1.TabIndex = 123;
            this.checkBox1.Text = "Rentang Waktu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxRentang1_CheckedChanged);
            // 
            // UserControlLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btLihat);
            this.Controls.Add(this.comboBoxFN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxJD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerSet);
            this.Controls.Add(this.dataGridViewKelas);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlLaporan";
            this.Size = new System.Drawing.Size(1200, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerSet;
        private System.Windows.Forms.DataGridView dataGridViewKelas;
        private RoundedButton btPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxJD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxFN;
        private System.Windows.Forms.Label label2;
        private RoundedButton btLihat;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
