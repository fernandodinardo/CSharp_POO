namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Nome} e tenho {Idade} anos. Eu sou um Aluno Nota {Nota}. Segue os dados do meu Documento {Documento}");
        }

    }
}