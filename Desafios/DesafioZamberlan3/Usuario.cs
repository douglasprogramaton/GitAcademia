using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioZamberlan2
{
    class Usuario
    {
        string nomeCompleto;
        string email;
        /// <summary>
        /// Gerador de email ele pega o ultimo nome e passa a frente do primeiro nome 
        /// e adiciona o dominio (length-1 pra pegar o ultimo nome do usuário)
        /// split para separar os dados.
        /// </summary>
        private void gerarEmail()
        {
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }
        /// <summary>
        /// construtor usado no cadastro de um usuario
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// parâmetro de entrada
        
        public Usuario(string nome)
        {
            this.nomeCompleto = nome;
            //this.gerarEmail() faz mensao ao metodo gerarEmail.
            this.gerarEmail();
        }

        //construtor usado para popular a lista a partir do arquivo (banco)
        public Usuario(string nome, string email)
        {
            this.nomeCompleto = nome;
            this.email = email;
        }
        /// <summary>
        /// (get , e set) get= ler, set= escrever
        /// </summary>
        public string Nome { get => nomeCompleto; set => nomeCompleto = value; }

        public string Email { get => email; }
    }
}
