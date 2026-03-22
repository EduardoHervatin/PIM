using System;
using System.Collections.Generic;
using System.Text;

namespace PIM
{
    public class Admin : Usuário
    {
        // --- Atributo privado próprio da classe Admin ---
        private int nivelAcesso;

        // --- Propriedade com get/set ---
        public int NivelAcesso
        {
            get { return nivelAcesso; }
            set { nivelAcesso = value; }
        }

        // --- Construtor: chama o construtor da classe mãe com "base" ---
        public Admin(string nome, int nivelAcesso) : base(nome)
        {
            this.nivelAcesso = nivelAcesso;
        }

        // --- Método de exemplo próprio da classe Admin ---
        public void GerenciarSistema()
        {
            Console.WriteLine($"Admin {Nome} gerenciando o sistema. Nível de acesso: {nivelAcesso}");
        }

        // --- Sobrescrita do método herdado da classe mãe ---
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Nível de acesso: {nivelAcesso}");
        }
    }
}
