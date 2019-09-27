using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Projeto2;
using DAL_Projeto2;

namespace BLL_Projeto2
{
    public class LoginBLL
    {

        public static PessoaDTO ValidarLogin(LoginDTO obj)
        {

            if (string.IsNullOrWhiteSpace(obj.usuario))
            //verifica se esta vazio, ou com espaço e se estiver da erro
            {
                throw new Exception("Informe seu nome de Usuário ou E-mail");
                //retorna uma excessao se der erro
            }
            if (string.IsNullOrWhiteSpace(obj.senha))
            {
                throw new Exception("Informe sua Senha");
            }

            return LoginDAL.vldLogin(obj);

        }
    }
}
