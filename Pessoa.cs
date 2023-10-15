namespace GerenciadorEscola
{
    internal class Pessoa
    {
        internal int Matricula { get; set; } 
        internal string Nome { get; set; }        
        internal DateTime DataNascimento { get; set; }        
        internal int Idade { get; set; }
        internal bool Status { get; set; }

        internal Pessoa(int matricula, string nome, DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
            Matricula = matricula;
            Nome = nome;

            DateTime hoje = DateTime.Now;
            Idade = hoje.Year - dataNascimento.Year; // calcula quantos anos se passaram desde o nascimento                       
            if (hoje.Month < DataNascimento.Month) // compara mes com o aniv. Se não tiver chegado ao mes de aniversario, diminui 1 ano da idade
            {
                Idade--;
            }
            if (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day) // se estiver no mesmo mes, compara os dias para saber se ja fez aniversario
            {
                Idade--; // caso ainda não fez, diminui 1 da idade
            }
        }

        internal virtual void Imprimir()
        {
            Console.WriteLine($"Matrícula: {Matricula}, Nome: {Nome}");            
            Console.WriteLine($"Idade: {Idade}, Data de nascimento: {DataNascimento.Day}/{DataNascimento.Month}/{DataNascimento.Year}");
            if (Status)
            {
                Console.WriteLine($"Status: Ativo");
            }
            else
            {
                Console.WriteLine($"Status: Inativo");
            }
        }

        internal void AlterarDados(int matricula, string nome, DateTime dataNascimento, bool status)
        {
            Matricula = matricula;
            Nome = nome;
            DataNascimento = dataNascimento;
            Status = status;
            DateTime hoje = DateTime.Now;
            Idade = hoje.Year - dataNascimento.Year; // calcula quantos anos se passaram desde o nascimento                       
            if (hoje.Month < DataNascimento.Month) // compara mes com o aniv. Se não tiver chegado ao mes de aniversario, diminui 1 ano da idade
            {
                Idade--;
            }
            if (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day) // se estiver no mesmo mes, compara os dias para saber se ja fez aniversario
            {
                Idade--; // caso ainda não fez, diminui 1 da idade
            }
        }




    }
}
