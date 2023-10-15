namespace GerenciadorEscola
{
    static internal class Escola
    {
        //  lista de alunos
        internal static List<Aluno> listaAlunos {get; set;}

        // lista de cursos
        internal static List<Curso> listaCursos { get; set; }

        //  lista de disciplinas
        internal static List<Disciplina> listaDisciplinas { get; set; }

        //  lista de professores
        internal static List<Professor> listaProfessores { get; set; }

        internal static void Init()
        {
            listaAlunos = new();
            listaCursos = new();
            listaDisciplinas = new();
            listaProfessores = new();
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

        internal static void ListarAlunos()
        {
            foreach (Aluno aluno in  listaAlunos)
            {                
                aluno.Imprimir();
            }
        }

        internal static void ListarProfessores()
        {
            foreach (Professor prof in listaProfessores)
            {
                prof.Imprimir();
            }
        }



    }
}

