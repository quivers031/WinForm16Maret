using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm16Maret
{
    public partial class FormLatihan : Form
    {
        public static int angkaYangDilempar = 2;
        public static DataTable dtMahasiswa = new DataTable();
        
        public FormLatihan()
        {
            InitializeComponent();
        }



        private void FormLatihan_Load(object sender, EventArgs e)
        {
            dtMahasiswa.Columns.Add("Nama"); 
            dtMahasiswa.Columns.Add("Alamat"); 
            dtMahasiswa.Columns.Add("No Telpon");
            dataGridMahasiswa.DataSource = dtMahasiswa;
            
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            dtMahasiswa.Rows.Add(txtBoxNama.Text, txtBoxAlamat.Text, txtBoxNoTelpon.Text);
            txtBoxNama.Text = "";
            txtBoxAlamat.Text = "";
            txtBoxNoTelpon.Text = "";
            txtBoxNama.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
