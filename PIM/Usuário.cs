using System;
using System.Collections.Generic;
using System.Text;

namespace PIM
{
    public class Usuário
    {
        // --- Atributo privado (encapsulamento) ---
        private string login;
        private string senha;
        private string id;
        private string nome;
        private string dtnascimento;
        
        // --- Propriedade com get/set ---
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Dtnascimento
        {
            get { return dtnascimento; }
            set { dtnascimento = value; }
        }

        // --- Construtor: permite instanciar fora da própria classe ---
        public Usuário(string nome)
        {
            this.nome = nome;
        }

        // --- Método de exemplo (virtual: pode ser sobrescrito pelas filhas) ---
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Usuário: {nome}");
        }
    }
}
