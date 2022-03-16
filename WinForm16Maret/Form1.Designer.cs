namespace WinForm16Maret
{
    partial class FormLatihan
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
            this.dataGridMahasiswa = new System.Windows.Forms.DataGridView();
            this.buttonOpenForm2 = new System.Windows.Forms.Button();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.txtBoxAlamat = new System.Windows.Forms.TextBox();
            this.txtBoxNoTelpon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMahasiswa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMahasiswa
            // 
            this.dataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMahasiswa.Location = new System.Drawing.Point(27, 166);
            this.dataGridMahasiswa.Name = "dataGridMahasiswa";
            this.dataGridMahasiswa.Size = new System.Drawing.Size(333, 263);
            this.dataGridMahasiswa.TabIndex = 0;
            // 
            // buttonOpenForm2
            // 
            this.buttonOpenForm2.Location = new System.Drawing.Point(59, 38);
            this.buttonOpenForm2.Name = "buttonOpenForm2";
            this.buttonOpenForm2.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenForm2.TabIndex = 1;
            this.buttonOpenForm2.Text = "button1";
            this.buttonOpenForm2.UseVisualStyleBackColor = true;
            this.buttonOpenForm2.Click += new System.EventHandler(this.buttonOpenForm2_Click);
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Location = new System.Drawing.Point(323, 24);
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(141, 20);
            this.txtBoxNama.TabIndex = 2;
            // 
            // txtBoxAlamat
            // 
            this.txtBoxAlamat.Location = new System.Drawing.Point(323, 50);
            this.txtBoxAlamat.Name = "txtBoxAlamat";
            this.txtBoxAlamat.Size = new System.Drawing.Size(228, 20);
            this.txtBoxAlamat.TabIndex = 3;
            // 
            // txtBoxNoTelpon
            // 
            this.txtBoxNoTelpon.Location = new System.Drawing.Point(323, 76);
            this.txtBoxNoTelpon.Name = "txtBoxNoTelpon";
            this.txtBoxNoTelpon.Size = new System.Drawing.Size(141, 20);
            this.txtBoxNoTelpon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Telpon";
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(323, 103);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(99, 23);
            this.btnTambahData.TabIndex = 8;
            this.btnTambahData.Text = "Tambah Data";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(544, 354);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 17);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Tidak";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(432, 354);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(38, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ya";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(261, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Questionable";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(41, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Suka Makan";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(393, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 117);
            this.panel1.TabIndex = 16;
            // 
            // FormLatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.btnTambahData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNoTelpon);
            this.Controls.Add(this.txtBoxAlamat);
            this.Controls.Add(this.txtBoxNama);
            this.Controls.Add(this.buttonOpenForm2);
            this.Controls.Add(this.dataGridMahasiswa);
            this.Name = "FormLatihan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLatihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMahasiswa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMahasiswa;
        private System.Windows.Forms.Button buttonOpenForm2;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.TextBox txtBoxAlamat;
        private System.Windows.Forms.TextBox txtBoxNoTelpon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTambahData;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

