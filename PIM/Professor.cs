using System;
using System.Collections.Generic;
using System.Text;

namespace PIM
{
    public class Professor : Usuário
    {
        // --- Atributo privado próprio da classe Professor ---
        private string disciplina;

        // --- Propriedade com get/set ---
        public string Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        // --- Construtor: chama o construtor da classe mãe com "base" ---
        public Professor(string nome, string disciplina) : base(nome)
        {
            this.disciplina = disciplina;
        }

        // --- Método de exemplo próprio da classe Professor ---
        public void LancarNota()
        {
            Console.WriteLine($"Professor {Nome} lançando nota para a disciplina: {disciplina}");
        }

        // --- Sobrescrita do método herdado da classe mãe ---
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Disciplina: {disciplina}");
        }
    }
}
