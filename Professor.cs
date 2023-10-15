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
        }
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            if (!Disciplinas.Contains(disciplina))
            {
                Disciplinas.Add(disciplina);
                disciplina.AtribuirProfessor(this);

                if ()
            }
        }

        internal override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Disciplinas do Professor:");
            foreach (Disciplina d in Disciplinas)
            {
                Console.WriteLine(d.Titulo);
            }
            foreach (Empresa.C)
            Console.WriteLine("=====================================");
            Console.WriteLine();
        }
    }


}

