using System;
namespace GerenciadorEscola
{
  internal class Program
  {
/***Exercício avaliação final**, em duplas, entrega até 18/10 as 18h, a entrega precisa ser antes do inicio do próximo módulo, ok? sem exceção.
Vocês vão organizar as suas próprias duplas! Quem estiver sem dupla me chama que vejo quem está sozinho, ou se organizem no WhatsApp da turma também! Caso não dê certo, poderá ter um único trio!

Sistema de Gerenciamento de Escola

Imagine que você está desenvolvendo um sistema de gerenciamento de escola.
Crie o cadastro do Aluno com caracteristicas como nome, idade, número de identificação do aluno (matrícula) e uma lista de cursos em que o aluno está matriculado. Abra a possibilidade que um aluno se matricule em um curso. Crie também uma forma de exibir a lista de cursos em que o aluno está matriculado.
Crie o cadastro de Curso com caracteristicas como nome, código do curso, os alunos matriculados no curso e as disciplinas deste curso. Deve-se permitir que um aluno seja adicionado à lista de alunos do curso, assim como as disciplinas. Disponibilize a lista de alunos matriculados no curso. Disponibilize também a lista de disciplinas.
Crie o cadastro de Disciplinas com caracteristicas como titulo, carga horária e ementa. 
Crie o cadastro de Professor com o nome, idade e um conjunto de disciplinas que o professor está lecionando. Permita que uma disciplina seja atribuída a um professor. Disponibilize a lista de cursos + disciplinas que o professor está lecionando.
Gerenciar a atribuição de um aluno a um curso e vice-versa onde ambos serão atribuidos um ao outro portanto não deve ser possível adicionar um curso a um aluno sem adicionar o aluno ao curso e vice-versa.
Comece pela criação do UML. Implemente todo o conteúdo aprendido no curso.
Crie testes na main. Não é necessário criar um menu e sim objetos que acionem todas as classes e métodos criados em uma ordem lógica que faça sentido.
*/
    internal static void Main()
    {
            Escola.Init();
            
            // Criando três alunos
            Aluno aluno1 = new Aluno(123456, "Joao", new DateTime(1999, 7, 5));
            aluno1.DefinirStatus(false);
            Escola.CadastrarAluno(aluno1);

            Aluno aluno2 = new Aluno(758962, "Maria", new DateTime(2005, 5, 12));
            aluno2.DefinirStatus(true);
            Escola.CadastrarAluno(aluno2);

            Aluno aluno3 = new Aluno(123456, "Pedro", new DateTime(2000, 10, 14));
            aluno3.DefinirStatus(true);
            Escola.CadastrarAluno(aluno3);

            // Criando duas disciplinas
            Disciplina disciplina1 = new Disciplina
            {
                Titulo = "Introdução à Programação",
                CargaHoraria = 60,
                Ementa = "Esta disciplina introduz os conceitos básicos de programação, incluindo variáveis, tipos de dados, operadores, instruções de controle e funções."
            };

            Disciplina disciplina2 = new Disciplina
            {
                Titulo = "Banco de Dados",
                CargaHoraria = 45,
                Ementa = "Esta disciplina aborda conceitos de bancos de dados relacionais e SQL."
            };

            Disciplina disciplina3 = new Disciplina
            {
                Titulo = "Programação Avançada",
                CargaHoraria = 75,
                Ementa = "Nesta disciplina, você explorará tópicos avançados de programação, incluindo design de software, padrões de projeto e desenvolvimento orientado a objetos."
            };

            Disciplina disciplina4 = new Disciplina
            {
                Titulo = "Redes de Computadores",
                CargaHoraria = 60,
                Ementa = "Esta disciplina cobre os princípios de redes de computadores, protocolos de comunicação e segurança de rede."
            };

            Disciplina disciplina5 = new Disciplina
            {
                Titulo = "Inteligência Artificial",
                CargaHoraria = 90,
                Ementa = "A disciplina de Inteligência Artificial explora técnicas e algoritmos avançados para criar sistemas inteligentes e aprendizado de máquina."
            };


            // Criando três professores
            Professor professor1 = new Professor(789532, "Maria", new DateTime(1985, 10, 5), 6000.00);
            //professor1.AdicionarDisciplina(disciplina1);
            //professor1.AdicionarDisciplina(disciplina2);

            Professor professor2 = new Professor(586723, "Carlos", new DateTime(1990, 6, 1), 6000.00);
            //professor2.AdicionarDisciplina(disciplina3);
            //professor2.AdicionarDisciplina(disciplina4);

            Professor professor3 = new Professor(586723, "Anna", new DateTime(1999, 12, 5), 15000.00);
            //professor3.AdicionarDisciplina(disciplina5);

            disciplina1.AtribuirProfessor(professor1);          
            disciplina2.AtribuirProfessor(professor2);
            disciplina2.AtribuirProfessor(professor3);
            disciplina3.AtribuirProfessor(professor1);
            disciplina3.AtribuirProfessor(professor2);
            disciplina3.AtribuirProfessor(professor3);
            disciplina4.AtribuirProfessor(professor1);
            disciplina4.AtribuirProfessor(professor2);
            disciplina5.AtribuirProfessor(professor3);            

            // Criando três cursos
            Curso curso1 = new Curso("Ciência da Computação", "CC", 5000);
            curso1.AdicionarAluno(aluno1);
            curso1.AdicionarAluno(aluno2);
            curso1.AdicionarDisciplina(disciplina3);
            curso1.AdicionarDisciplina(disciplina4);
            curso1.AdicionarDisciplina(disciplina5);

            Curso curso2 = new Curso("Engenharia Elétrica", "EE", 4500);
            curso2.AdicionarAluno(aluno2);
            curso2.AdicionarAluno(aluno3);
            curso2.AdicionarDisciplina(disciplina1);

            Curso curso3 = new Curso("Matemática Aplicada",  "MA", 2000);
            curso3.AdicionarAluno(aluno1);
            curso3.AdicionarAluno(aluno3);
            curso3.AdicionarDisciplina(disciplina2);
            curso3.AdicionarDisciplina(disciplina5);

            // Adicionando as disciplinas à lista
            Escola.CadastrarDisciplina(disciplina1);
            Escola.CadastrarDisciplina(disciplina2);
            Escola.CadastrarDisciplina(disciplina3);
            Escola.CadastrarDisciplina(disciplina4);
            Escola.CadastrarDisciplina(disciplina5);

            // cadastrando professores na Escola
            Escola.CadastrarProfessor(professor1);
            Escola.CadastrarProfessor(professor2);
            Escola.CadastrarProfessor(professor3);



            // Imprimindo alunos e disciplinas
            
            //Escola.ListarAlunos();
            Escola.ListarProfessores();

        }
  }
}