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
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }
        public static int showIndex = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            BoxTampilNama.Text = FormInput.arraynama[showIndex];
            BoxTampilAlamat.Text = FormInput.arrayalamat[showIndex];
            TampilTelp.Text = FormInput.arraytelp[showIndex];
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            FormInput B = new FormInput();
            B.Show();
            this.Visible = false;
        }

        private void BtnPrevData_Click(object sender, EventArgs e)
        {
            showIndex = showIndex - 1;
            if (showIndex<0)
            {
                showIndex = showIndex + 1;
                MessageBox.Show("Tidak Bisa yaa, ini pertama :D");
            }
            BoxTampilNama.Text = FormInput.arraynama[showIndex];
            BoxTampilAlamat.Text = FormInput.arrayalamat[showIndex];
            TampilTelp.Text = FormInput.arraytelp[showIndex];
        }

        private void BtnNextData_Click(object sender, EventArgs e)
        {
            showIndex = showIndex + 1;
            if(showIndex>=10)
            {
                MessageBox.Show("Ini Data terakhir :D");
            }
            if (showIndex > FormInput.indexInputArray - 1)
            {
                showIndex = showIndex - 1;
                MessageBox.Show("Ini Data terakhir :D");
            }
            BoxTampilNama.Text = FormInput.arraynama[showIndex];
            BoxTampilAlamat.Text = FormInput.arrayalamat[showIndex];
            TampilTelp.Text = FormInput.arraytelp[showIndex];
        }

        private void BoxTampilNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxTampilAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void TampilTelp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
