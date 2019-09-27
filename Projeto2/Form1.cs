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
using BLL_Projeto2;

namespace UI_Projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO obj = new LoginDTO();
                PessoaDTO pessoa = new PessoaDTO();
                obj.usuario = txtlogin.Text;
                obj.senha = txtsenha.Text;

                pessoa = LoginBLL.ValidarLogin(obj);//chama o metodo validar login

                //recebe pessoa 
                //arrumar o ativo
                //mudar no banco para varchar 5

                if (pessoa.nome != "" && pessoa.ativo == "true")
                {
                    this.Hide();
                    home tela2 = new home(); //tela2 nome da variavel
                    tela2.ShowDialog();
                    this.Close();

                }
                else
                {
                    throw new Exception("Usuario ou senha invalidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK);
            }

        }
    }
}

