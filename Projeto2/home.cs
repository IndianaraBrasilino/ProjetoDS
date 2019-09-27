using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Projeto2;

namespace UI_Projeto2
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            //metodo construdor
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;//pega a hora atual
            if(HoraAtual < tarde)
            {
                label1.Text = "Bom dia";
            }
            else if (HoraAtual < noite)
            {
                label1.Text = "Boa Tarde";
            }
            else
            {
                label1.Text = "Boa Noite";
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaDTO obj = new PessoaDTO();
                obj.nome = txtnome.Text;
                obj.cpf = txtcpf.Text;
                obj.rg = txtrg.Text;
                obj.dtnascimento = txtdatanasc.Text;
                obj.telfixo = txtfixo.Text;
                obj.telcelular = txtcelular.Text;
                obj.cargo = txtcargo.Text;
                obj.endereco = txtend.Text;
                obj.numero = txtnum.Text;
            }
            catch
                {
                throw;
            }
        }
    }
}
