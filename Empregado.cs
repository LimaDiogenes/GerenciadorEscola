﻿namespace GerenciadorEscola
{
    internal class Empregado
    {
        internal int Matricula { get; private set; } 
        internal string Nome { get; private set; }
        internal string Sobrenome { get; private set; }
        internal DateOnly DataNascimento { get; private set; }
        internal DateOnly DataContratacao { get; private set; }
        internal int Idade { get; private set; }

        internal double salario = 1320.00d; // valor do salario minimo
        internal double Salario
        {
            get
            { return salario; }
            private set // checando para permitir atribuir o novo valor apenas se for > minimo.
            {
                if (value > salario)
                {
                    salario = value;
                }
            }
        }

        /// <summary>
        /// construtor1 - dados completos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="dataContratacao"></param>
        /// <param name="salario"></param>
        internal Empregado(string nome, string sobrenome, DateOnly dataNascimento, DateOnly dataContratacao, double salario)
        {
            Matricula = Empresa.GerarMatricula(); // método verifica primeiro número disponível e retorna como matrícula
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
            DataNascimento = dataNascimento;
            DataContratacao = dataContratacao;
            Salario = salario;
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
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

        /// <summary>
        /// construtor2 - dados basicos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="dataNascimento"></param>
        internal Empregado(string nome, string sobrenome, DateOnly dataNascimento)
        {
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
            DataNascimento = dataNascimento;
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
            Idade = hoje.Year - DataNascimento.Year; // calcula quantos anos se passaram desde o nascimento
            if (hoje.Month < DataNascimento.Month) // compara mes com o aniv. Se não tiver chegado ao mes de aniversario, diminui 1 ano da idade
            {
                Idade--;
            }
            if (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day) // se estiver no mesmo mes, compara os dias para saber se ja fez aniversario
            {
                Idade--; // caso ainda não fez, diminui 1 da idade
            }
            Matricula = Empresa.GerarMatricula();
            DataContratacao = DateOnly.FromDateTime(DateTime.Now); // Cadastra data de início como dia atual
        }
        /// <summary>
        /// Calcula o salário anual multiplicando o salário mensal por 12
        /// </summary>
        /// <returns></returns>
        internal double SalarioAnual()
        {
            return Salario * 12;
        }
        /// <summary>
        /// usado para passar salario e matricula quando lido da BD. Usado para proteger / manter set privado
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="salario"></param>
        internal void InfoBD(int matricula)
        {
            Matricula = matricula;
        }
    }
}
