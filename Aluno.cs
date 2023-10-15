namespace GerenciadorEscola
{
    internal class Aluno : Pessoa
    {
        internal string Turno { get; set; }
        // Status para verificar o status do aluno (ativo/inativo) na institui��o.

        /// <summary>
        /// Obt�m a lista de cursos em que o aluno est� matriculado.
        /// </summary>
        internal List<Curso> Cursos { get; set; }
        internal Aluno(int matricula, string nome, DateTime dataNascimento) : base(matricula, nome, dataNascimento)
        {
            Matricula = matricula;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cursos = new List<Curso>();            
        }
        /// <summary>
        /// Matricula o aluno em um curso e associa o aluno ao curso.
        /// </summary>
        /// <param name="curso">O curso em que o aluno ser� matriculado.</param>
        internal void MatricularEmCurso(Curso curso)
        {
            if (!Cursos.Contains(curso))
            {
                Cursos.Add(curso);               
            }
        }

        /// <summary>
        /// Define o status do aluno como ativo ou inativo.
        /// </summary>
        /// <param name="ativo">Indica se o aluno est� ativo (true) ou inativo (false).</param>
        internal void DefinirStatus(bool ativo)
        {
            Status = ativo;
        }

        internal override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Cursos do aluno:");
            foreach (Curso curso in Cursos)
            {
                curso.Imprimir();

                if (curso.Descontar10(this))
                {
                    Console.WriteLine($"Parab�ns aniversariante {this.Nome}. Voc� ganhou 10% de desconto no curso {curso.Nome}!!!");
                    Console.WriteLine($"O novo valor da sua mensalidade � R$ {Math.Round(curso.Mensalidade, 2)}");                    
                }
            }
            Console.WriteLine("=====================================");
            Console.WriteLine();
        }
    }
}

