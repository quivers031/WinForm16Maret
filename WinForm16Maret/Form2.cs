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
    public partial class Form2 : Form
    {
        public static DataTable dtMahasiswaFiltered = new DataTable();
        
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            dtMahasiswaFiltered.Columns.Add("Nama");
            dtMahasiswaFiltered.Columns.Add("Alamat");
            dtMahasiswaFiltered.Columns.Add("No Telpon");
            int panjangDataTable = FormLatihan.dtMahasiswa.Rows.Count;
            labelContoh.Text = panjangDataTable.ToString();
            for (int i = 0; i <= panjangDataTable - 1; i++)
            {

                if (FormLatihan.dtMahasiswa.Rows[i][1].ToString() == "Surabaya")
                {
                    dtMahasiswaFiltered.Rows.Add(FormLatihan.dtMahasiswa.Rows[i][0], FormLatihan.dtMahasiswa.Rows[i][1], FormLatihan.dtMahasiswa.Rows[i][2]);
                }
            }
            dataGridView1.DataSource = dtMahasiswaFiltered;
        }
    }
}
