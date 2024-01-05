namespace Mini_Attendance.Projects.user_controls
{
    partial class UserControlEvent
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
            this.comboBoxPS = new System.Windows.Forms.ComboBox();
            this.btAdd = new RoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKelas = new System.Windows.Forms.DataGridView();
            this.btDel = new RoundedButton();
            this.btEdi = new RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLK = new System.Windows.Forms.TextBox();
            this.btDel1 = new RoundedButton();
            this.btEdi1 = new RoundedButton();
            this.btAdd1 = new RoundedButton();
            this.choosenEvent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(120, 95);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(229, 27);
            this.dateTimePicker.TabIndex = 103;
            // 
            // comboBoxPS
            // 
            this.comboBoxPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPS.FormattingEnabled = true;
            this.comboBoxPS.Items.AddRange(new object[] {
            "Mahasiswa",
            "Dosen",
            "Umum"});
            this.comboBoxPS.Location = new System.Drawing.Point(121, 161);
            this.comboBoxPS.Name = "comboBoxPS";
            this.comboBoxPS.Size = new System.Drawing.Size(229, 27);
            this.comboBoxPS.TabIndex = 101;
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 10;
            this.btAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btAdd.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.btAdd.Location = new System.Drawing.Point(39, 203);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 33);
            this.btAdd.TabIndex = 100;
            this.btAdd.Text = "Tambah";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 99;
            this.label6.Text = "Peserta :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 98;
            this.label5.Text = "Tanggal :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Nama :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNM
            // 
            this.textBoxNM.Location = new System.Drawing.Point(120, 62);
            this.textBoxNM.Name = "textBoxNM";
            this.textBoxNM.Size = new System.Drawing.Size(229, 27);
            this.textBoxNM.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "Event";
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
            this.dataGridViewKelas.Location = new System.Drawing.Point(367, 31);
            this.dataGridViewKelas.Name = "dataGridViewKelas";
            this.dataGridViewKelas.ReadOnly = true;
            this.dataGridViewKelas.Size = new System.Drawing.Size(788, 423);
            this.dataGridViewKelas.TabIndex = 106;
            // 
            // btDel
            // 
            this.btDel.BorderRadius = 10;
            this.btDel.ButtonColor = System.Drawing.Color.Firebrick;
            this.btDel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btDel.Location = new System.Drawing.Point(250, 203);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 33);
            this.btDel.TabIndex = 105;
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
            this.btEdi.Location = new System.Drawing.Point(144, 203);
            this.btEdi.Name = "btEdi";
            this.btEdi.Size = new System.Drawing.Size(100, 33);
            this.btEdi.TabIndex = 104;
            this.btEdi.Text = "Edit";
            this.btEdi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 108;
            this.label2.Text = "Lokasi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxLK
            // 
            this.textBoxLK.Location = new System.Drawing.Point(120, 128);
            this.textBoxLK.Name = "textBoxLK";
            this.textBoxLK.Size = new System.Drawing.Size(229, 27);
            this.textBoxLK.TabIndex = 107;
            // 
            // btDel1
            // 
            this.btDel1.BorderRadius = 10;
            this.btDel1.ButtonColor = System.Drawing.Color.Firebrick;
            this.btDel1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel1.ForeColor = System.Drawing.Color.White;
            this.btDel1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btDel1.Location = new System.Drawing.Point(251, 421);
            this.btDel1.Name = "btDel1";
            this.btDel1.Size = new System.Drawing.Size(100, 33);
            this.btDel1.TabIndex = 118;
            this.btDel1.Text = "Hapus";
            this.btDel1.UseVisualStyleBackColor = true;
            this.btDel1.Visible = false;
            // 
            // btEdi1
            // 
            this.btEdi1.BorderRadius = 10;
            this.btEdi1.ButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.btEdi1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdi1.ForeColor = System.Drawing.Color.White;
            this.btEdi1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(101)))));
            this.btEdi1.Location = new System.Drawing.Point(145, 421);
            this.btEdi1.Name = "btEdi1";
            this.btEdi1.Size = new System.Drawing.Size(100, 33);
            this.btEdi1.TabIndex = 117;
            this.btEdi1.Text = "Edit";
            this.btEdi1.UseVisualStyleBackColor = true;
            this.btEdi1.Visible = false;
            // 
            // btAdd1
            // 
            this.btAdd1.BorderRadius = 10;
            this.btAdd1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btAdd1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd1.ForeColor = System.Drawing.Color.White;
            this.btAdd1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.btAdd1.Location = new System.Drawing.Point(40, 421);
            this.btAdd1.Name = "btAdd1";
            this.btAdd1.Size = new System.Drawing.Size(100, 33);
            this.btAdd1.TabIndex = 114;
            this.btAdd1.Text = "Tambah";
            this.btAdd1.UseVisualStyleBackColor = true;
            this.btAdd1.Visible = false;
            // 
            // choosenEvent
            // 
            this.choosenEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choosenEvent.Enabled = false;
            this.choosenEvent.Location = new System.Drawing.Point(40, 380);
            this.choosenEvent.Name = "choosenEvent";
            this.choosenEvent.Size = new System.Drawing.Size(309, 27);
            this.choosenEvent.TabIndex = 110;
            this.choosenEvent.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 19);
            this.label10.TabIndex = 109;
            this.label10.Text = "Tertarik Mengikuti Event Apa?";
            this.label10.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 46);
            this.label4.TabIndex = 119;
            this.label4.Text = "klik dua kali pada tabel di samping untuk memilih Event yang kamu sukai!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDel1);
            this.Controls.Add(this.btEdi1);
            this.Controls.Add(this.btAdd1);
            this.Controls.Add(this.choosenEvent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLK);
            this.Controls.Add(this.dataGridViewKelas);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdi);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxPS);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNM);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlEvent";
            this.Size = new System.Drawing.Size(1200, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxPS;
        private RoundedButton btAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKelas;
        private RoundedButton btDel;
        private RoundedButton btEdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLK;
        private RoundedButton btDel1;
        private RoundedButton btEdi1;
        private RoundedButton btAdd1;
        private System.Windows.Forms.TextBox choosenEvent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
    }
}
