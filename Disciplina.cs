using GerenciadorEscola;

internal class Disciplina
{
    internal string Titulo { get; set; }
    internal int CargaHoraria { get; set; }
    internal string Ementa { get; set; }
    internal List<Professor> Professores { get; set; }
    internal List<Curso> Cursos { get; set; }

    internal Disciplina()
    {
        Professores = new List<Professor>();
        Cursos = new List<Curso>();
    }

    /// <summary>
    /// Associa um professor a esta disciplina, estabelecendo uma relação bidirecional entre ambos.
    /// </summary>
    /// <param name="professor">O professor a ser associado a esta disciplina.</param>

    internal void AtribuirProfessor(Professor professor)
    {
        if (!Professores.Contains(professor))
        {
            Professores.Add(professor);
            professor.AdicionarDisciplina(this);
            
            foreach (Curso curso in professor.Escola.listaCursos)
            {
                if (curso.Disciplinas.Contains(this))
                {
                    professor.AdicionarCurso(curso);
                }
            }
        }
    }
   
    /// <summary>
    /// Obtém o nome do primeiro professor associado a esta disciplina, se houver algum.
    /// </summary>
    /// <returns>O nome do professor ou "Nenhum Professor" se não houver professores associados.</returns>
   
    public string ObterNomeDoProfessor()
    {
        if (Professores.Count > 0)
        {
            return Professores[0].Nome;
        }
        return "Nenhum Professor";
    }

    internal void Imprimir()
    {
        Console.WriteLine($"Título: {Titulo}, Carga horária: {CargaHoraria}");
        Console.WriteLine($"Ementa: {Ementa}");
        
        foreach (Professor p in Professores)
        {
            Console.WriteLine($"Professor(a): {p.Nome}");
        }

        Console.WriteLine("=====================================");
        Console.WriteLine();
    }
}