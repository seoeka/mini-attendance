namespace Mini_Attendance.Projects.user_controls
{
    partial class UserControlKelas
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
            this.dataGridViewKelas = new System.Windows.Forms.DataGridView();
            this.btDel = new RoundedButton();
            this.btEdi = new RoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNM1 = new System.Windows.Forms.TextBox();
            this.btAdd = new RoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDS = new System.Windows.Forms.ComboBox();
            this.comboBoxDS1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerSet = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxNM = new System.Windows.Forms.TextBox();
            this.dateTimePickerEnd1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSet1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewKelas.TabIndex = 88;
            this.dataGridViewKelas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKelas_CellDoubleClick);
            // 
            // btDel
            // 
            this.btDel.BorderRadius = 10;
            this.btDel.ButtonColor = System.Drawing.Color.Firebrick;
            this.btDel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btDel.Location = new System.Drawing.Point(266, 411);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(100, 33);
            this.btDel.TabIndex = 87;
            this.btDel.Text = "Hapus";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdi
            // 
            this.btEdi.BorderRadius = 10;
            this.btEdi.ButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.btEdi.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdi.ForeColor = System.Drawing.Color.White;
            this.btEdi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(101)))));
            this.btEdi.Location = new System.Drawing.Point(160, 411);
            this.btEdi.Name = "btEdi";
            this.btEdi.Size = new System.Drawing.Size(100, 33);
            this.btEdi.TabIndex = 86;
            this.btEdi.Text = "Edit";
            this.btEdi.UseVisualStyleBackColor = true;
            this.btEdi.Click += new System.EventHandler(this.btEdi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 83;
            this.label8.Text = "Tgl Akhir :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Tgl Mulai :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 79;
            this.label10.Text = "Nama :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNM1
            // 
            this.textBoxNM1.Location = new System.Drawing.Point(137, 279);
            this.textBoxNM1.Name = "textBoxNM1";
            this.textBoxNM1.Size = new System.Drawing.Size(229, 27);
            this.textBoxNM1.TabIndex = 78;
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 10;
            this.btAdd.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(154)))), ((int)(((byte)(240)))));
            this.btAdd.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(131)))), ((int)(((byte)(227)))));
            this.btAdd.Location = new System.Drawing.Point(266, 198);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 33);
            this.btAdd.TabIndex = 77;
            this.btAdd.Text = "Tambah";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "Dosen :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tgl Akhir :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tgl Mulai :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nama :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 68;
            this.label2.Text = "Edit dan Hapus Kelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tambah Kelas";
            // 
            // comboBoxDS
            // 
            this.comboBoxDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDS.FormattingEnabled = true;
            this.comboBoxDS.Location = new System.Drawing.Point(137, 161);
            this.comboBoxDS.Name = "comboBoxDS";
            this.comboBoxDS.Size = new System.Drawing.Size(229, 27);
            this.comboBoxDS.TabIndex = 89;
            // 
            // comboBoxDS1
            // 
            this.comboBoxDS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDS1.FormattingEnabled = true;
            this.comboBoxDS1.Location = new System.Drawing.Point(137, 373);
            this.comboBoxDS1.Name = "comboBoxDS1";
            this.comboBoxDS1.Size = new System.Drawing.Size(229, 27);
            this.comboBoxDS1.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 90;
            this.label7.Text = "Dosen :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePickerSet
            // 
            this.dateTimePickerSet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSet.Location = new System.Drawing.Point(137, 98);
            this.dateTimePickerSet.Name = "dateTimePickerSet";
            this.dateTimePickerSet.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerSet.TabIndex = 92;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(137, 130);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerEnd.TabIndex = 93;
            // 
            // textBoxNM
            // 
            this.textBoxNM.Location = new System.Drawing.Point(137, 67);
            this.textBoxNM.Name = "textBoxNM";
            this.textBoxNM.Size = new System.Drawing.Size(229, 27);
            this.textBoxNM.TabIndex = 69;
            // 
            // dateTimePickerEnd1
            // 
            this.dateTimePickerEnd1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd1.Location = new System.Drawing.Point(137, 342);
            this.dateTimePickerEnd1.Name = "dateTimePickerEnd1";
            this.dateTimePickerEnd1.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerEnd1.TabIndex = 95;
            // 
            // dateTimePickerSet1
            // 
            this.dateTimePickerSet1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSet1.Location = new System.Drawing.Point(137, 310);
            this.dateTimePickerSet1.Name = "dateTimePickerSet1";
            this.dateTimePickerSet1.Size = new System.Drawing.Size(229, 27);
            this.dateTimePickerSet1.TabIndex = 94;
            // 
            // UserControlKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerEnd1);
            this.Controls.Add(this.dateTimePickerSet1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerSet);
            this.Controls.Add(this.comboBoxDS1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDS);
            this.Controls.Add(this.dataGridViewKelas);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxNM1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlKelas";
            this.Size = new System.Drawing.Size(1200, 480);
            this.Load += new System.EventHandler(this.UserControlKelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKelas;
        private RoundedButton btDel;
        private RoundedButton btEdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNM1;
        private RoundedButton btAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDS;
        private System.Windows.Forms.ComboBox comboBoxDS1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerSet;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox textBoxNM;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSet1;
    }
}
