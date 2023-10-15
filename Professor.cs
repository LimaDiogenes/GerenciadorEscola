namespace GerenciadorEscola
{
    internal class Professor : Pessoa
    {
        internal double Salario { get; private set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Professor(int matricula, string nome, DateTime dataNascimento, double salario)
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
            }
        }
    }


}

