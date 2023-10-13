namespace GerenciadorEscola
{
    internal class Pessoa
    {
        internal int Matricula { get; private set; } 
        internal string Nome { get; private set; }
        internal string Sobrenome { get; private set; }
        internal DateOnly DataNascimento { get; private set; }        
        internal int Idade { get; private set; }


// > professores
        // internal double salario = 1320.00d; // valor do salario minimo
        // internal double Salario
        // {
        //     get
        //     { return salario; }
        //     private set // checando para permitir atribuir o novo valor apenas se for > minimo.
        //     {
        //         if (value > salario)
        //         {
        //             salario = value;
        //         }
        //     }
        // }

        /// <summary>
        /// construtor1 - dados completos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="dataContratacao"></param>
        /// <param name="salario"></param>
        // internal void SetIdade(string nome, string sobrenome, DateOnly dataNascimento)
        // {
        //     Matricula = Escola.GerarMatricula(); // método verifica primeiro número disponível e retorna como matrícula
        //     Nome = nome.ToUpper();
        //     Sobrenome = sobrenome.ToUpper();
        //     DataNascimento = dataNascimento;       
        //     DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
        //     Idade = hoje.Year - dataNascimento.Year; // calcula quantos anos se passaram desde o nascimento                       
        //     if (hoje.Month < DataNascimento.Month) // compara mes com o aniv. Se não tiver chegado ao mes de aniversario, diminui 1 ano da idade
        //     {
        //         Idade--;
        //     }
        //     if (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day) // se estiver no mesmo mes, compara os dias para saber se ja fez aniversario
        //     {
        //         Idade--; // caso ainda não fez, diminui 1 da idade
        //     }            
        // }        
    }
}
