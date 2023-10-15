namespace GerenciadorEscola
{
    static internal class Escola
    {
        //  lista de alunos
        internal static List<Aluno> listaAlunos;

        // lista de cursos
        internal static List<Curso> listaCursos;

        //  lista de disciplinas
        internal static List<Disciplina> listaDisciplinas;

        //  lista de professores
        internal static List<Professor> listaProfessores;

        static Escola()
        {
            List<Aluno> listaAlunos = new();
            List<Curso> listaCursos = new();
            List<Disciplina> listaDisciplinas = new();
            List<Professor> listaProfessor = new();
        }

        internal static void CadastrarAluno(Aluno aluno)
        {
            listaAlunos.Add(aluno);
        }

        internal static void CadastrarProfessor(Professor professor)
        {
            listaProfessores.Add(professor);
        }

        internal static void CadastrarCurso(Curso curso)
        {
            listaCursos.Add(curso);
        }

        internal static void CadastrarDisciplina(Disciplina disc)
        {
            listaDisciplinas.Add(disc);
        }



    }
}

