using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Projeto2;
using System.Data;
using System.Data.SqlClient;


namespace DAL_Projeto2
{
    public class LoginDAL
    {
        public static PessoaDTO vldLogin(LoginDTO obj)
        {
            try
                //inicia o bloco de tratamento de exception
            {
                string script = "SELECT * FROM Pessoa WHERE(userName = @login OR email = @email) AND senha = @senha";
                //cria a string com consulta sql
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //cria o comando para rodar a instrução, passando instrução sql e conexão
                cm.Parameters.AddWithValue("@login", obj.usuario);
                cm.Parameters.AddWithValue("@senha", obj.senha);

                //substitui  as variaveis na instrução SQL pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a instrução sql e atribui resultado no SqlDataReader

                while (dados.Read())
                //lê a proxima linha do resultado da sua instrução
                {
                    if (dados.HasRows)
                //verifica se existe a linha com as credenciais
                    {
                        PessoaDTO user = new PessoaDTO();
                        user.idpessoa = int.Parse(dados["idPessoa"].ToString());
                        //lendo a linha da tabela atraves de dados

                        //pega as informaçoes dos 
                        user.cargo = dados["cargo"].ToString();
                        user.dtnascimento = dados["dtnascimento"].ToString();
                        user.sexo = dados["sexo"].ToString();
                        user.ativo = dados["ativo"].ToString();
                        user.telfixo = dados["telfixo"].ToString();
                        user.telcelular = dados["telefoneCelular"].ToString();
                        user.rg = dados["RG"].ToString();
                        user.cpf = dados["CPF"].ToString();
                        user.nome = dados["nome"].ToString();
                        user.userName = dados["userName"].ToString();
                        user.email = dados["email"].ToString();
                        user.senha = dados["senha"].ToString();

                        return user;
                    }

                }
                
                throw new Exception("Credenciais Inválidas");
            }
            catch (Exception ex)//ex o nome da variavel
            //esse bloco e executado caso aconteça exceção no bloco try
            {
                throw new Exception("Erro de conexâo, contate o suporte!" + ex.Message);
            }
            finally
                //cai no finally independente se fica no try ou no catch
            {
                //linha fecha a conexão
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    //testando o estado da conexao, se é diferente de fechado
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
