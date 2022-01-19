using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            System.Console.WriteLine("O resultado é:");
            System.Console.WriteLine(calc.Somar(10, 20));

            System.Console.WriteLine();
            System.Console.WriteLine("---");
            System.Console.WriteLine();

            Aluno p1 = new Aluno();

            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Documento = "123123123";

            p1.Nota = 100;

            p1.Apresentar();

            Professor prof1 = new Professor();

            prof1.Nome = "Fred";
            prof1.Idade = 55;
            prof1.Documento = "987987987";

            prof1.Salario = 55000;

            prof1.Apresentar();

            System.Console.WriteLine();
            System.Console.WriteLine("---");
            System.Console.WriteLine();

            // Valores Válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas (30, 30);

            System.Console.WriteLine($"Área: {r.ObterArea()}");

            //Valores Inválidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas (0, 0);

            System.Console.WriteLine($"Área: {r2.ObterArea()}");

            System.Console.WriteLine();
            System.Console.WriteLine("---");
            System.Console.WriteLine();

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Fernando Di Nardo";
            pessoa1.Idade = 32;

            pessoa1.Apresentar();
        }
    }
}