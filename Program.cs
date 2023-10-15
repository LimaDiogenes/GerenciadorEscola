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
            // Criando três alunos
            Aluno aluno1 = new Aluno { Nome = "João", Idade = 20, Matricula = 123456 };
            aluno1.DefinirStatus(false);

            Aluno aluno2 = new Aluno { Nome = "Maria", Idade = 22, Matricula = 654321 };
            aluno2.DefinirStatus(true);

            Aluno aluno3 = new Aluno { Nome = "Pedro", Idade = 19, Matricula = 789012 };
            aluno3.DefinirStatus(true);

            aluno1.Imprimir(); aluno2.Imprimir(); aluno3.Imprimir();


        }
  }
}