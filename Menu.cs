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
