using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3
{
    public partial class Form1 : Form
    {
        Akun akun1 = new Akun(20000, "hiyahiyahiya"); //ganti Akun menjadi AkunPremium LAB 3.3
        public Form1()
        {
            InitializeComponent();
            lblSaldo.Text = akun1.Saldo.ToString();
        }
        private void TarikSaldo(int total)
        {
            akun1.Tarik(total);
            lblSaldo.Text = akun1.Saldo.ToString();
        }
        private void SetorSaldo(int total)
        {
            akun1.Setor(total);
            lblSaldo.Text = akun1.Saldo.ToString();
        }

        private void BtnLanjut_Click(object sender, EventArgs e)
        {
            if (akun1.PasswordTervalidasi(tbPassword.Text))
            {
                if (rbSetor.Checked)
                    SetorSaldo(int.Parse(tbUang.Text));
                else if (rbTarik.Checked)
                    TarikSaldo(int.Parse(tbUang.Text));
            }
            else
            {
                MessageBox.Show("Password salah");
            }
        }
    }
}