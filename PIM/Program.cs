using PIM;
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando cada classe pelo construtor (fora da própria classe)
        Usuário usuario = new Usuário("Carlos");
        Aluno aluno = new Aluno("Ana", "2024001", "SP");
        Professor prof = new Professor("Roberto", "Matemática");
        Admin admin = new Admin("Fernanda", 3);

        // Chamando métodos
        usuario.ExibirInfo();
        Console.WriteLine("---");

        aluno.ExibirInfo();
        aluno.AcessarCurso();
        Console.WriteLine("---");

        prof.ExibirInfo();
        prof.LancarNota();
        Console.WriteLine("---");

        admin.ExibirInfo();
        admin.GerenciarSistema();
    }
}