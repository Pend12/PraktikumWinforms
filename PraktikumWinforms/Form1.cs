using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWinforms
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        public static int indexInputArray = 0;
        public static int indexArray = 11;
        public static string[] arraynama = new string[indexArray];
        public static string[] arrayalamat = new string[indexArray];
        public static string[] arraytelp = new string[indexArray];
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonSimpan_Click(object sender, EventArgs e)
        {
            indexInputArray = indexInputArray + 1;
            arraynama[indexInputArray-1] = TxtBoxSimpanNama.Text;
            arrayalamat[indexInputArray - 1] = TxtBoxSimpanAlm.Text;
            arraytelp[indexInputArray - 1] = TxtBoxTelp.Text;
            TxtBoxSimpanNama.Clear();
            TxtBoxSimpanAlm.Clear();
            TxtBoxTelp.Clear();
            if(indexInputArray > 10)
            {
                MessageBox.Show("Data Penuh yaa");
            }

        }

        private void BtnSeeData_Click(object sender, EventArgs e)
        {
            FormData A = new FormData();
            A.Show();
            this.Visible = false;
        }

        private void TxtBoxSimpanNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxSimpanAlm_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
