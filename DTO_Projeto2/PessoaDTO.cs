using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Projeto2
{
    public class PessoaDTO
    {
        public int idpessoa { get; set; }
        public string cargo { get; set; }
        public string dtnascimento { get; set; }
        public string sexo { get; set; }
        public string ativo { get; set; }
        public string telfixo { get; set; }
        public string telcelular { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public string endereco { get; set; }

        public string numero { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }

    }
}
