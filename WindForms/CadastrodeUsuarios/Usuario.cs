using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeUsuarios
{
    class Usuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public string Status { get; set; }
        public string Status1 { get; set; }
        public bool ativo { get; set; }
        public bool inativo { get; set; }
        public string Cadastro { get; set; }
      





        public Usuario(string nome, string telefone, string cpf, string senha, string login, string status, string status1, bool ativo, bool inativo, string cadastro)
        {
            this.Login = login;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Senha = senha;
            this.Status = status;
            this.Status1 = status1;
            this.Cadastro = cadastro;
            this.ativo = ativo;
            this.inativo = inativo;
        }

     

        public void Exibir()
        {
            MessageBox.Show(
               $"DADOS DO CADASTRO\n" +
               $"Nome:---------{this.Nome}\n" +
               $"Telefone:-----{this.Telefone}\n" +
               $"Cpf:----------{this.Cpf}\n" +
               $"Login:--------{this.Login}\n" +
               $"Senha:--------{this.Senha}\n" +
               $"Status:-------{this.Cadastro}{Status1}\n" +
               $"Tipo Usuário:-{this.Status}");


        }



    }
}
