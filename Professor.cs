namespace GerenciadorEscola
{
    internal class Professor : Pessoa
    {
        internal double Salario { get; private set; }
        internal List<Disciplina> Disciplinas { get; set; }
        internal List<Curso> Cursos { get; set; }

        public Professor(int matricula, string nome, DateTime dataNascimento, double salario) : base(matricula, nome, dataNascimento)
        {
            Matricula = matricula;
            Nome = nome;
            DataNascimento = dataNascimento;
            Salario = salario;
            Disciplinas = new List<Disciplina>();
            Cursos = new List<Curso>();
        }

        internal void AdicionarDisciplina(Disciplina disciplina)
        {
            if (!Disciplinas.Contains(disciplina))
            {
                Disciplinas.Add(disciplina);
                disciplina.AtribuirProfessor(this);
            }
        }

        internal void AdicionarCurso(Curso curso)
        {
            if (!Cursos.Contains(curso))
            {
                Cursos.Add(curso);                
            }
        }

        internal override void Imprimir()
        {
            Console.WriteLine("Professor(a):");
            base.Imprimir();
            Console.WriteLine();
            Console.WriteLine("Disciplinas do Professor:");
            
            foreach (Disciplina d in Disciplinas)
            {
                Console.WriteLine(d.Titulo);
            }

            Console.WriteLine();
            Console.WriteLine("Cursos do Professor:");

            foreach (Curso curso in Cursos)
            {
                Console.WriteLine(curso.Nome);
            }

            Console.WriteLine("=====================================");
            Console.WriteLine();
        }
    }
}

