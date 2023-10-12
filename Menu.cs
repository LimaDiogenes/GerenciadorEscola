﻿namespace GerenciadorEscola
{
    internal class Menu
    {
        //Variaveis para criação e manipulação da Tela, dividido em 25 linhas.
        private string Linha1 { get; set; } = "";
        private string Linha2 { get; set; } = "";
        private string Linha3 { get; set; } = "";
        private string Linha4 { get; set; } = "";
        private string Linha5 { get; set; } = "";
        private string Linha6 { get; set; } = "";
        private string Linha7 { get; set; } = "";
        private string Linha8 { get; set; } = "";
        private string Linha9 { get; set; } = "";
        private string Linha10 { get; set; } = "";
        private string Linha11 { get; set; } = "";
        private string Linha12 { get; set; } = "";
        private string Linha13 { get; set; } = "";
        private string Linha14 { get; set; } = "";
        private string Linha15 { get; set; } = "";
        private string Linha16 { get; set; } = "";
        private string Linha17 { get; set; } = "";
        private string Linha18 { get; set; } = "";
        private string Linha19 { get; set; } = "";
        private string Linha20 { get; set; } = "";
        private string Linha21 { get; set; } = "";
        private string Linha22 { get; set; } = "";
        private string Linha23 { get; set; } = "";
        private string Linha24 { get; set; } = "";
        private string Linha25 { get; set; } = "";
        /// <summary>
        /// construtor chama tela inicial, em branco, cria apenas margens da tela
        /// </summary>
        internal Menu()
        {
            Console.Clear();
            ImprimirMenuVoid(52, 15, ConsoleColor.White);
        }
        /// <summary>
        /// cria menu com as opcoes iniciais
        /// </summary>
        /// <returns>char</returns>
        internal char MenuInicial()
        {
            Console.ForegroundColor = ConsoleColor.White; // ajusta cor
            Linha3 = "Gerenciador de Empregados";
            Linha7 = "══════════════════════════════════════════════════════════════════════════════════════════════";
            Linha10 = "Escolha uma opção abaixo";
            Linha15 = "[ ]";
            Linha17 = Linha7;
            Linha20 = "[C] Cadastrar empregado       [L] Listar empregados";
            Linha21 = "[P] Promover empregado        [D] Demitir Empregado";
            Linha22 = "[S] Listar salário anual      [Q] Encerrar programa";

            return MenuRetornaChar(52, 15); // usa este metodo para substituir as linhas, posicionar o cursor, e retornar a opcao do usuario
        }
        /// <summary>
        /// Lista todos os Empregados, apresentando até 6 Empregados por vez
        /// </summary>
        internal void MenuListarEmpregados()
        {
            List<Empregado> empregadosOrdenados = Empresa.empregados.OrderBy(empregado => empregado.Matricula).ToList(); // cria uma nova lista ordenada por matriculas
            int NumeroFunc = empregadosOrdenados.Count;
            int indice1 = 0; //Tela apresenta até 6 empregados por vez
            int indice2 = 1;
            int indice3 = 2;
            int indice4 = 3;
            int indice5 = 4;
            int indice6 = 5;

            try
            {
                Menu telaConsulta = new();
            labelInicioConsulta:
                telaConsulta.Linha1 = $"Relatório de Funcionários. Quantidade de pessoas cadastradas: {NumeroFunc}";
                telaConsulta.Linha3 = "===================================================================================";
                // Apresenta informações do empregado indicado no Indice1 (1º empregado listado na tela)
                telaConsulta.Linha4 = $"Matrícula: {empregadosOrdenados[indice1].Matricula}, Nome: {empregadosOrdenados[indice1].Nome} {empregadosOrdenados[indice1].Sobrenome}, Nascimento: {empregadosOrdenados[indice1].DataNascimento}";
                telaConsulta.Linha5 = $"Idade: {empregadosOrdenados[indice1].Idade} anos, Salário: R${empregadosOrdenados[indice1].Salario:F2}, Contratação: {empregadosOrdenados[indice1].DataContratacao}";
                telaConsulta.Linha6 = telaConsulta.Linha3;
                if (NumeroFunc >= 2)
                {
                    // Apresenta informações do empregado indicado no Indice2 (2º empregado listado na tela)
                    telaConsulta.Linha7 = $"Matrícula: {empregadosOrdenados[indice2].Matricula}, Nome: {empregadosOrdenados[indice2].Nome} {empregadosOrdenados[indice2].Sobrenome}, Nascimento: {empregadosOrdenados[indice2].DataNascimento}";
                    telaConsulta.Linha8 = $"Idade: {empregadosOrdenados[indice2].Idade} anos, Salário: R${empregadosOrdenados[indice2].Salario:F2}, Contratação: {empregadosOrdenados[indice2].DataContratacao}";
                    telaConsulta.Linha9 = telaConsulta.Linha3;
                }
                if (NumeroFunc >= 3)
                {
                    // Apresenta informações do empregado indicado no Indice3 (3º empregado listado na tela)
                    telaConsulta.Linha10 = $"Matrícula: {empregadosOrdenados[indice3].Matricula}, Nome: {empregadosOrdenados[indice3].Nome} {empregadosOrdenados[indice3].Sobrenome}, Nascimento: {empregadosOrdenados[indice3].DataNascimento}";
                    telaConsulta.Linha11 = $"Idade: {empregadosOrdenados[indice3].Idade} anos, Salário: R${empregadosOrdenados[indice3].Salario:F2}, Contratação: {empregadosOrdenados[indice3].DataContratacao}";
                    telaConsulta.Linha12 = telaConsulta.Linha3;
                }
                if (NumeroFunc >= 4)
                {
                    // Apresenta informações do empregado indicado no Indice4 (4º empregado listado na tela)
                    telaConsulta.Linha13 = $"Matrícula: {empregadosOrdenados[indice4].Matricula}, Nome: {empregadosOrdenados[indice4].Nome} {empregadosOrdenados[indice4].Sobrenome}, Nascimento: {empregadosOrdenados[indice4].DataNascimento}";
                    telaConsulta.Linha14 = $"Idade: {empregadosOrdenados[indice4].Idade} anos, Salário: R${empregadosOrdenados[indice4].Salario:F2}, Contratação: {empregadosOrdenados[indice4].DataContratacao}";
                    telaConsulta.Linha15 = telaConsulta.Linha3;
                }
                if (NumeroFunc >= 5)
                {
                    // Apresenta informações do empregado indicado no Indice5 (5º empregado listado na tela)
                    telaConsulta.Linha16 = $"Matrícula: {empregadosOrdenados[indice5].Matricula}, Nome: {empregadosOrdenados[indice5].Nome} {empregadosOrdenados[indice5].Sobrenome}, Nascimento: {empregadosOrdenados[indice5].DataNascimento}";
                    telaConsulta.Linha17 = $"Idade: {empregadosOrdenados[indice5].Idade} anos, Salário: R${empregadosOrdenados[indice5].Salario:F2}, Contratação: {empregadosOrdenados[indice5].DataContratacao}";
                    telaConsulta.Linha18 = telaConsulta.Linha3;
                }

                if (NumeroFunc >= 6)
                {
                    // Apresenta informações do empregado indicado no Indice6 (6º empregado listado na tela)
                    telaConsulta.Linha19 = $"Matrícula: {empregadosOrdenados[indice6].Matricula}, Nome: {empregadosOrdenados[indice6].Nome} {empregadosOrdenados[indice6].Sobrenome}, Nascimento: {empregadosOrdenados[indice6].DataNascimento}";
                    telaConsulta.Linha20 = $"Idade: {empregadosOrdenados[indice6].Idade} anos, Salário: R${empregadosOrdenados[indice6].Salario:F2}, Contratação: {empregadosOrdenados[indice6].DataContratacao}";
                    telaConsulta.Linha21 = telaConsulta.Linha3;
                }
                telaConsulta.Linha24 = "[ ]";
                telaConsulta.Linha25 = "[D] DESCER LISTA     |     [Q] SAIR     |     [S] SUBIR LISTA"; //"DESCER LISTA" apresenta proximo empregado no Indice 6, "SUBIR LISTA" faz o processo inverso.

                telaConsulta.ImprimirMenuVoid(52, 24);
                char opcao = char.ToUpper(Console.ReadKey().KeyChar);

                if (opcao == 'D') // adiciona 1 aos indices, para "rolar a tela" para baixo
                {
                    if (indice6 < (NumeroFunc - 1))
                    {
                        indice1++; indice2++; indice3++; indice4++; indice5++; indice6++;
                    }
                    goto labelInicioConsulta;
                }
                else if (opcao == 'S') // Oposto da de cima. Retorna ao começo da tela para recomeçar a impressão
                {
                    if (indice1 > 0)
                    {
                        indice1--; indice2--; indice3--; indice4--; indice5--; indice6--;
                    }
                    goto labelInicioConsulta;
                }
                else if (opcao == 'Q') // Sair
                {
                    return;
                }
                else
                {
                    goto labelInicioConsulta; // mantem tela ativa caso outra tecla seja apertada, retornando ao inicio 
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Menu consultar = new();
                consultar.Linha1 = "Relatório de Funcionários";
                consultar.Linha4 = "=================================================================================";
                consultar.Linha5 = "Não há empregados cadastrados!";
                consultar.Linha6 = consultar.Linha4;
                consultar.Linha20 = "Esta tela fechará automaticamente";
                consultar.ImprimirMenuVoid(52, 2);
                Thread.Sleep(3000);

            }
        } // menu para listar todos os empregados
        /// <summary>
        /// cria menu para demitir Empregado, excluindo-o da Base De Dados
        /// </summary>
        internal void MenuDemitir()
        {

            Menu demitir = new();
        labelInicioDemissao: // Marcador De Retorno, em caso de erro na busca o metodo volta até este ponto do código
            demitir.Linha2 = "DEMISSÃO - DIGITE O NOME DO EMPREGADO A SER DEMITIDO";
            demitir.Linha5 = "PRIMEIRO NOME:       [                                   ]";
            demitir.Linha6 = "SOBRENOME:           [                                   ]";

            demitir.ImprimirMenuVoid(46, 5);
            string nome = Console.ReadLine().ToUpper().Trim();
            Console.SetCursorPosition(46, 6);
            string sobrenome = Console.ReadLine().ToUpper().Trim();

            foreach (Empregado empregado in Empresa.empregados) //Busca Empregado na Base De Dados
            {
                if (nome != empregado.Nome || sobrenome != empregado.Sobrenome)
                {
                    continue;
                }
                else
                {

                    while (true)
                    {
                        Menu confirma = new();

                        confirma.Linha4 = $"|||   ATENÇÂO: EMPREGADO(A) SERÁ EXCLUÍDO DA BASE DE DADOS!   |||";

                        confirma.Linha10 = $"DESEJA DEMITIR O(A) EMPREGADO(A) {empregado.Nome} {empregado.Sobrenome}?";
                        confirma.Linha13 = $"|||   ESTA AÇÃO NÃO PODERÁ SER DESFEITA!   |||";
                        confirma.Linha15 = "[ ]";
                        confirma.Linha17 = "[C] CONFIRMAR ||| [Q] SAIR";

                        char confirmacao = confirma.MenuRetornaChar(52, 15, ConsoleColor.Yellow);

                        switch (confirmacao)
                        {
                            case 'C':
                                {
                                    Empresa.Demitir(empregado);

                                    Linha4 = "  _____  ______ __  __ _____ _______ _____ _____   ____  _ ";
                                    Linha5 = " |  __ \\|  ____|  \\/  |_   _|__   __|_   _|  __ \\ / __ \\| |";
                                    Linha6 = " | |  | | |__  | \\  / | | |    | |    | | | |  | | |  | | |";
                                    Linha7 = " | |  | |  __| | |\\/| | | |    | |    | | | |  | | |  | | |";
                                    Linha8 = " | |__| | |____| |  | |_| |_   | |   _| |_| |__| | |__| |_|";
                                    Linha9 = " |_____/|______|_|  |_|_____|  |_|  |_____|_____/ \\____/(_)";

                                    Linha14 = $"{empregado.Nome} {empregado.Sobrenome}, matrícula {empregado.Matricula} foi demitido com sucesso!";


                                    Linha20 = "Aperte qualquer tecla para retornar ao menu principal";
                                    ImprimirMenuVoid(52, 21, ConsoleColor.DarkRed);
                                    Console.ReadLine();
                                    return; // retorno void para sair da tela
                                }
                            case 'Q':
                                {
                                    return;
                                }
                            default:
                                {
                                    continue;
                                }

                        }

                    }
                }
            }
            demitir.Linha10 = "Empregado não encontrado!"; // Caso não encontre empregado, retorna mensagem de erro ao usuario e pergunta se quer tentar encontrar novamente
            demitir.Linha15 = "[C] CONTINUAR       [Q] SAIR";
            demitir.Linha14 = "[ ]";
            while (true)
            {
                char opcao = demitir.MenuRetornaChar(52, 14);

                switch (opcao)
                {
                    case 'C':
                        {
                            demitir.Linha10 = "";
                            goto labelInicioDemissao; //Retorna ao inicio da tela, no Marcador De Retorno
                        }
                    case 'Q':
                        {
                            return;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }


        }
        /// <summary>
        /// Gera a tela para promover o Empregado e aumentar seu salario
        /// </summary>
        internal void MenuPromover()
        {

            Menu promover = new();
        labelInicioPromocao: // Marcador De Retorno, em caso de erro na busca o metodo volta até este ponto do código
            promover.Linha2 = "PROMOÇÃO - DIGITE O NOME DO EMPREGADO A SER PROMOVIDO";
            promover.Linha5 = "PRIMEIRO NOME:       [                                   ]";
            promover.Linha6 = "SOBRENOME:           [                                   ]";

            promover.ImprimirMenuVoid(46, 5);
            string nome = Console.ReadLine().ToUpper().Trim();
            Console.SetCursorPosition(46, 6);
            string sobrenome = Console.ReadLine().ToUpper().Trim();

            foreach (Empregado empregado in Empresa.empregados) //Busca pelo Empregado na Base De Dados
            {
                if (nome != empregado.Nome || sobrenome != empregado.Sobrenome)
                {
                    continue;
                }
                else
                {

                    while (true)
                    {
                        Menu confirma = new();

                        confirma.Linha10 = $"DESEJA PROMOVER O(A) EMPREGADO(A) {empregado.Nome} {empregado.Sobrenome}?";
                        confirma.Linha15 = "[ ]";
                        confirma.Linha17 = "[C] CONFIRMAR ||| [Q] SAIR";

                        char confirmacao = confirma.MenuRetornaChar(52, 15);

                        switch (confirmacao)
                        {
                            case 'C':
                                {
                                    Linha4 = "  _____  _____   ____  __  __  ______      _______ _____   ____  _ ";
                                    Linha5 = " |  __ \\|  __ \\ / __ \\|  \\/  |/ __ \\ \\    / /_   _|  __ \\ / __ \\| |";
                                    Linha6 = " | |__) | |__) | |  | | \\  / | |  | \\ \\  / /  | | | |  | | |  | | |";
                                    Linha7 = " |  ___/|  _  /| |  | | |\\/| | |  | |\\ \\/ /   | | | |  | | |  | | |";
                                    Linha8 = " | |    | | \\ \\| |__| | |  | | |__| | \\  /   _| |_| |__| | |__| |_|";
                                    Linha9 = " |_|    |_|  \\_\\\\____/|_|  |_|\\____/   \\/   |_____|_____/ \\____/(_)";

                                    Linha13 = $"Salário atual de {empregado.Nome} {empregado.Sobrenome}, matrícula {empregado.Matricula} era de R${empregado.Salario:F2}";
                                    Linha15 = $"O novo salário será de R${Empresa.Promover(empregado):F2}";

                                    Linha20 = "Aperte qualquer tecla para retornar ao menu principal";
                                    ImprimirMenuVoid(52, 21, ConsoleColor.DarkGreen);
                                    Console.ReadLine();
                                    return; // retorno void para sair da tela
                                }
                            case 'Q':
                                {
                                    return;
                                }
                            default:
                                {
                                    continue;
                                }

                        }

                    }
                }
            }
            promover.Linha10 = "Empregado não encontrado!"; // Caso não encontre empregado, retorna mensagem de erro ao usuario e pergunta se quer tentar encontrar novamente
            promover.Linha15 = "[C] CONTINUAR       [Q] SAIR";
            promover.Linha14 = "[ ]";
            while (true)
            {
                char opcao = promover.MenuRetornaChar(52, 14);

                switch (opcao)
                {
                    case 'C':
                        {
                            promover.Linha10 = "";
                            goto labelInicioPromocao; //Retorna até o inicio da tela, no Marcador De Retorno
                        }
                    case 'Q':
                        {
                            return;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }

        }
        /// <summary>
        /// Gera tela em que mostra os ganhos anuais de  um empregado 
        /// </summary>
        internal void MenuSalarioAnual()
        {

            Menu consultar = new();
        labelInicioConsulta: // Marcador De Retorno, em caso de erro na busca o metodo volta até este ponto do código
            consultar.Linha2 = "PESQUISA DE FUNCIONÁRIOS";
            consultar.Linha5 = "PRIMEIRO NOME:       [                                   ]";
            consultar.Linha6 = "SOBRENOME:           [                                   ]";

            consultar.ImprimirMenuVoid(46, 5);
            string nome = Console.ReadLine().ToUpper().Trim();
            Console.SetCursorPosition(46, 6);
            string sobrenome = Console.ReadLine().ToUpper().Trim();

            foreach (Empregado empregado in Empresa.empregados)
            {
                if (nome != empregado.Nome || sobrenome != empregado.Sobrenome)
                {
                    continue;
                }
                else
                {

                    Linha4 = "   _____         _               _____  _____ ____             _   _ _    _         _      ";
                    Linha5 = "  / ____|  /\\   | |        /\\   |  __ \\|_   _/ __ \\      /\\   | \\ | | |  | |  /\\   | |     ";
                    Linha6 = " | (___   /  \\  | |       /  \\  | |__) | | || |  | |    /  \\  |  \\| | |  | | /  \\  | |     ";
                    Linha7 = "  \\___ \\ / /\\ \\ | |      / /\\ \\ |  _  /  | || |  | |   / /\\ \\ | . ` | |  | |/ /\\ \\ | |     ";
                    Linha8 = "  ____) / ____ \\| |____ / ____ \\| | \\ \\ _| || |__| |  / ____ \\| |\\  | |__| / ____ \\| |____ ";
                    Linha9 = " |_____/_/    \\_\\______/_/    \\_\\_|  \\_\\_____\\____/  /_/    \\_\\_| \\_|\\____/_/    \\_\\______|";

                    Linha15 = $"Salário anual de {empregado.Nome} {empregado.Sobrenome}, matrícula {empregado.Matricula} é de R${empregado.SalarioAnual():F2}";
                    Linha20 = "Aperte qualquer tecla para retornar ao menu principal";
                    ImprimirMenuVoid(52, 21);
                    Console.ReadLine();
                    return; // retorno void para sair da tela
                }
            }
            consultar.Linha10 = "Empregado não encontrado!"; // Caso não encontre empregado, retorna mensagem de erro ao usuario e pergunta se quer tentar encontrar novamente
            consultar.Linha15 = "[C] CONTINUAR       [Q] SAIR";
            consultar.Linha14 = "[ ]";
            while (true)
            {
                char opcao = consultar.MenuRetornaChar(52, 14);

                switch (opcao)
                {
                    case 'C':
                        {
                            goto labelInicioConsulta; //Retorna até o inicio da tela, no Marcador De Retorno
                        }
                    case 'Q':
                        {
                            return;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }
        } 
        /// <summary>
        ///  Gera tela para cadastrar novos Empregados
        /// </summary>
        internal void MenuCadastrar()
        {
            Empregado novoEmpregado;
            bool loopCadastro = true;


            while (loopCadastro)
            {
                Menu cadastrar = new();

                cadastrar.Linha2 = "[C] CADASTRO COMPLETO    |  [ ]  |    [S] CADASTRO SIMPLES";

                cadastrar.Linha5 = "PRIMEIRO NOME:       [                                   ]";
                cadastrar.Linha6 = "SOBRENOME:           [                                   ]";
                cadastrar.Linha7 = "DATA NASCIMENTO      [                  ] [  dd/mm/aaaa  ]";
                cadastrar.Linha12 = "|||   ATENÇÃO! NÃO USAR ACENTOS!   |||";

                cadastrar.Linha19 = "[ ]";
                cadastrar.Linha20 = "[C] CONFIRMAR     |     [ESC] VOLTAR AO MENU PRINCIPAL     |     [R] CORRIGIR";
                cadastrar.Linha21 = "PREENCHA TODOS OS CAMPOS PARA PODER SELECIONAR UMA OPÇÃO";

                cadastrar.ImprimirMenuVoid(52, 3); // imprime o menu com as linhas acima

                try
                {
                    Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress); // event listener - ativado caso o usuario use ctrl+c - gera exceção

                    Console.SetCursorPosition(53, 2);
                    char tipoCadastro = char.ToUpper(Console.ReadKey().KeyChar);

                    switch (tipoCadastro)
                    {
                        case 'C':
                            {
                                cadastrar.Linha8 = "DATA CONTRATAÇÃO:    [                  ] [  dd/mm/aaaa  ]";
                                cadastrar.Linha9 = "SALÁRIO:             [                  ] [   00000,00   ]";
                                cadastrar.ImprimirMenuVoid(46, 5); // imprime as linhas acima

                                string nome = Console.ReadLine();
                                Console.SetCursorPosition(46, 6);
                                string sobrenome = Console.ReadLine();
                                Console.SetCursorPosition(46, 7);
                                DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());
                                Console.SetCursorPosition(46, 8);
                                DateOnly dataContratacao = DateOnly.Parse(Console.ReadLine());
                                Console.SetCursorPosition(46, 9);
                                double salario = double.Parse(Console.ReadLine());
                                novoEmpregado = new(nome, sobrenome, dataNascimento, dataContratacao, salario);
                                break;


                            }
                        case 'S':
                            {
                                Console.SetCursorPosition(46, 5);
                                string nome = Console.ReadLine();
                                Console.SetCursorPosition(46, 6);
                                string sobrenome = Console.ReadLine();
                                Console.SetCursorPosition(46, 7);
                                DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());
                                Console.SetCursorPosition(46, 8);
                                novoEmpregado = new(nome, sobrenome, dataNascimento);
                                break;
                            }
                        case '\u001B': // ESC
                            {
                                loopCadastro = false;
                                return;
                            }

                        default:
                            {
                                continue;
                            }
                    }

                    Console.SetCursorPosition(52, 19);
                    char opcao = char.ToUpper(Console.ReadKey().KeyChar);

                    switch (opcao)
                    {
                        case 'C':
                            {
                                Empresa.Cadastrar(novoEmpregado);
                                while (true)
                                {

                                    Menu sucesso = new(); // cria nova tela para mensagem de sucesso
                                    sucesso.Linha12 = "Cadastrado com sucesso";
                                    sucesso.Linha16 = "Esta tela fechará automaticamente";
                                    sucesso.ImprimirMenuVoid(52, 19, ConsoleColor.DarkGreen); // imprime tela acima
                                    Thread.Sleep(3000); // segura a tela por 3 segundos

                                    loopCadastro = false; // finaliza o loop para voltar a tela inicial
                                    break;

                                }
                                break;
                            }
                        case '\u001B': // ESC
                            {
                                loopCadastro = false;
                                break;
                            }
                        case 'R':
                            {
                                break; //apenas volta ao menu para digitação
                            }

                        default:
                            {
                                throw new Exception();
                            }

                    }


                    void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e) // método do event listener (bloqueia ctrl+c)
                    {
                        e.Cancel = true;
                    }

                }
                catch (Exception)
                {

                    Menu default1 = new();
                    default1.Linha12 = "Opção inválida, digite novamente!";
                    default1.Linha16 = "Esta tela fechará automaticamente";
                    default1.ImprimirMenuVoid(52, 19, ConsoleColor.DarkRed);
                    Thread.Sleep(3000);
                    continue;
                }


            }


        }
        /// <summary>
        /// menu para exibir erro caso não exista arquivo de BD
        /// </summary>
        internal void NaoEncontrado()
        {
            Linha10 = "Arquivo Base de Dados não encontrado!";
            Linha15 = "Não existem funcionários cadastrados!";
            ImprimirMenuVoid(52, 20, ConsoleColor.Red);
            Thread.Sleep(2500);
        }

        /// <summary>
        /// Imprime um menu, por padrão em branco. Usa as propriedades Linhas para imprimir as informações na tela.
        /// Para ser usado com os demais metodos de menus, como TelaInicial, MenuCadastrar, Etc.
        /// </summary>
        /// <param name="posicaoX">"Ajusta a posição L-O em que o cursor ficará na tela"</param>
        /// <param name="posicaoY">"Ajusta a posição N-S em que o cursor ficará na tela"</param>
        /// <param name="cor">"Seta a cor das informações. Ex. Uso: ConsoleColor.White"</param>
        internal void ImprimirMenuVoid(int posicaoX, int posicaoY, ConsoleColor cor = ConsoleColor.White) // substitui linhas pela informacao necessaria. Usar dentro da classe
        {
            Console.SetCursorPosition(0, 0); // seta a posição do cursor para começar a impressão
            Console.ForegroundColor = cor; // ajusta a cor
            TextoCentralizado("", starter: '╔', sep: '═', ends: '╗');
            TextoCentralizado(SubstituirPalavras(Linha1, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha2, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha3, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha4, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha5, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha6, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha7, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha8, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha9, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha10, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha11, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha12, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha13, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha14, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha15, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha16, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha17, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha18, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha19, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha20, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha21, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha22, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha23, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha24, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha25, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado("", starter: '╚', sep: '═', ends: '╝');

            Console.SetCursorPosition(posicaoX, posicaoY); // posiciona do cursor para input

        }

        /// <summary>
        /// Imprime um menu, por padrão em branco. Retorna um 'char'. Usa as propriedades Linhas para imprimir as informações na tela.
        /// </summary>
        /// <param name="posicaoX">"Ajusta a posição L-O em que o cursor ficará na tela"</param>
        /// <param name="posicaoY">"Ajusta a posição N-S em que o cursor ficará na tela"</param>
        /// <param name="cor">"Seta a cor das informações. Ex. Uso: ConsoleColor.White"</param>
        /// <returns></returns>
        internal char MenuRetornaChar(int posicaoX, int posicaoY, ConsoleColor cor = ConsoleColor.White) // substituir linhas pela informacao necessaria. Usar dentro da classe
        {
            Console.SetCursorPosition(0, 0); // seta a posição do cursor para começar a impressão

            Console.ForegroundColor = cor; // ajusta a cor
            TextoCentralizado("", starter: '╔', sep: '═', ends: '╗');
            TextoCentralizado(SubstituirPalavras(Linha1, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha2, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha3, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha4, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha5, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha6, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha7, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha8, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha9, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha10, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha11, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha12, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha13, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha14, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha15, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha16, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha17, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha18, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha19, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha20, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha21, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha22, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha23, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha24, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado(SubstituirPalavras(Linha25, starter: ' ', ends: ' ', width: 94));
            TextoCentralizado("", starter: '╚', sep: '═', ends: '╝');


            Console.SetCursorPosition(posicaoX, posicaoY); //posicionamento do cursor para input
            char OpcaoUsuario = char.ToUpper(Console.ReadKey().KeyChar); //variavel com a selecao do usuario. ReadKey aqui serve para receber a primeira tecla do input do usuario,
                                                                         //e KeyChar passa o valor recebido em formato ´char´para a variavel OpcaoUsuario

            return OpcaoUsuario;
        }

        /// <summary>       
        /// cria um texto centralizado, usado para montar a tela no console.        /// 
        /// Todos os parâmetros são opcionais, e com valores padrão criam linhas com margem nas laterais
        /// Caracteres para usar como starter / ends / sep:{ ╔ ╗ ╚ ╝ ═ } Com estes é possível montar linhas do topo e do final
        /// Altura é controlada pelo número de linhas utilizado
        /// </summary>
        /// <param name="text">texto a ser exibido centralizado</param>
        /// <param name="starter">primeiro caractere da linha (margem)</param>
        /// <param name="ends">ultimo caractere da linha (margem)</param>
        /// <param name="sep">caracter para usar como separador, que aparecerá antes e depois do texto até o tamanho da tela</param>
        /// <param name="width">largura</param>                
        internal static void TextoCentralizado(string text = "", char starter = '║', char ends = '║', char sep = ' ', int width = 100)
        {

            int padWidth = (width - text.Length) / 2; // encontra a metade da largura, excluindo o tamanho do texto criado
            string paddedText = text.PadLeft(text.Length + padWidth, sep).PadRight(width, sep); // PadLeft e PadRight criam caracteres de preenchimento "sep" em ambos os lados do texto, deixando centralizado na tela  
            Console.WriteLine("  " + starter + paddedText + ends + "  "); // cria o texto centralizado na tela usando starter e ends como margem

        }
        /// <summary>
        ///SubstituirPalavras é uma versão alterada de TextoCentralizado, imprimindo o que deve ser escrito
        ///para poder utilizar como argumento, dentro de TextoCentralizado(), assim podendo imprimir texto dentro das margens, sem apagá-las
        /// </summary>
        /// <param name="text"></param>
        /// <param name="starter"></param>
        /// <param name="ends"></param>
        /// <param name="sep"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        internal static string SubstituirPalavras(string text = "", char starter = '║', char ends = '║', char sep = ' ', int width = 100) // cria um texto centralizado, aceitando como argumentos "end = primeiro e ultimo caractere da linha", "sep = caracter para usar como separador, que aparecerá antes e depois do texto até o tamanho da tela", "width = largura" todos os parâmetros são opcionais
        {
            int padWidth = (width - text.Length) / 2; // encontra a metada da largura, excluindo o tamanho do texto criado
            string palavra = text.PadLeft(text.Length + padWidth, sep).PadRight(width, sep); // PadLeft e PadRight criam caracteres de preenchimento "sep" em ambos os lados do texto, deixando centralizado na tela  
            string replacer = ("  " + starter + palavra + ends + "  "); // cria o texto centralizado na tela usando os "ends" como margem
            return replacer;
        }

    }
}
