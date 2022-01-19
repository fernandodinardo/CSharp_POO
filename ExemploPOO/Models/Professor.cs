namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Nome} e tenho {Idade} anos. Eu trabalho como Professor, tenho um Salário de {Salario} reais. Segue os dados do meu Documento {Documento}");
        }
    }
}