using System;
using System.Collections.Generic;
using System.Text;

namespace PIM
{
    public class Aluno : Usuário
    {
        // --- Atributo privado próprio da classe Aluno ---
        private string matricula;
        private string uf;

        // --- Propriedade com get/set ---
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        // --- Construtor: chama o construtor da classe mãe com "base" ---
        public Aluno(string nome, string matricula, string uf) : base(nome)
        {
            this.matricula = matricula;
            this.uf = uf;
        }

        // --- Método de exemplo próprio da classe Aluno ---
        public void AcessarCurso()
        {
            Console.WriteLine($"Aluno {Nome} acessando o curso. Matrícula: {matricula}");
        }

        // --- Sobrescrita do método herdado da classe mãe ---
        public override void ExibirInfo()
        {
            base.ExibirInfo();   // chama o método da classe mãe
            Console.WriteLine($"Matrícula: {matricula}");
        }
    }
}
