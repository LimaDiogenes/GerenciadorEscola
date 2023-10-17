namespace GerenciadorEscola
{
    internal class Escola
    {
        //  lista de alunos
        internal List<Aluno> listaAlunos {get; set;}

        // lista de cursos
        internal List<Curso> listaCursos { get; set; }

        //  lista de disciplinas
        internal List<Disciplina> listaDisciplinas { get; set; }

        //  lista de professores
        internal List<Professor> listaProfessores { get; set; }

        internal Escola()
        {
            listaAlunos = new();
            listaCursos = new();
            listaDisciplinas = new();
            listaProfessores = new();
        }

        internal void CadastrarAluno(Aluno aluno)
        {
            listaAlunos.Add(aluno);
        }

        internal void CadastrarProfessor(Professor professor)
        {
            listaProfessores.Add(professor);
        }

        internal void CadastrarCurso(Curso curso)
        {
            listaCursos.Add(curso);
        }

        internal void CadastrarDisciplina(Disciplina disc)
        {
            listaDisciplinas.Add(disc);
        }

        internal void ListarAlunos()
        {
            foreach (Aluno aluno in  listaAlunos)
            {                
                aluno.Imprimir();
            }
        }

        internal void ListarProfessores()
        {
            foreach (Professor prof in listaProfessores)
            {
                prof.Imprimir();
            }
        }

        internal void ListarCursos()
        {
            foreach (Curso curso in listaCursos)
            {
                curso.Imprimir();
            }
        }

        internal void ListarDisciplinas()
        {
            foreach (Disciplina disc in listaDisciplinas)
            {
                disc.Imprimir();
            }
        }
    }
}

