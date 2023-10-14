namespace GerenciadorEscola
{
    internal class Janela
    {
        //Variaveis para criação e manipulação da Tela, dividido em 25 linhas.
        internal string Linha1 { get; set; } = "";
        internal string Linha2 { get; set; } = "";
        internal string Linha3 { get; set; } = "";
        internal string Linha4 { get; set; } = "";
        internal string Linha5 { get; set; } = "";
        internal string Linha6 { get; set; } = "";
        internal string Linha7 { get; set; } = "";
        internal string Linha8 { get; set; } = "";
        internal string Linha9 { get; set; } = "";
        internal string Linha10 { get; set; } = "";
        internal string Linha11 { get; set; } = "";
        internal string Linha12 { get; set; } = "";
        internal string Linha13 { get; set; } = "";
        internal string Linha14 { get; set; } = "";
        internal string Linha15 { get; set; } = "";
        internal string Linha16 { get; set; } = "";
        internal string Linha17 { get; set; } = "";
        internal string Linha18 { get; set; } = "";
        internal string Linha19 { get; set; } = "";
        internal string Linha20 { get; set; } = "";
        internal string Linha21 { get; set; } = "";
        internal string Linha22 { get; set; } = "";
        internal string Linha23 { get; set; } = "";
        internal string Linha24 { get; set; } = "";
        internal string Linha25 { get; set; } = "";
        internal int Width { get; set; }
        internal int Height { get; set; }
        private List<string> linhas;
        bool Margens { get; set; }
        /// <summary>
        /// construtor cria janela, em branco, cria margens da tela principal se inicial == true
        /// Altura máxima = 25 (margens superior e inferior não são contabilizadas)
        /// </summary>
        internal Janela(bool margens = false, int width = 100, int height = 25)
        {
            if (margens)
            {
                Margens = true;
                Console.Clear();
                if (height > 25) 
                {
                     height = 25;
                }
                ImprimirJanela(0, 0, boxWidth: width, boxHeight: height);
            }            
            linhas = new();
            Width = width;
            Height = height;
        }

        /// <summary>
        /// cria menu com as opcoes iniciais
        /// </summary>
        /// <returns>char</returns>
        internal char MenuInicial()
        {
            Janela init = new();
            Console.ForegroundColor = ConsoleColor.White; // ajusta cor
            init.Linha3 = "Gerenciador da Escola 'SchoolName'";
            init.Linha7 = SubstituirPalavras(sep:'=', width:Width-4, starter:' ', ends:' ');
            init.Linha10 = "Escolha uma opção abaixo";
            init.Linha15 = "[ ]";
            init.Linha17 = Linha7;
            init.Linha20 = "[A] Cadastrar aluno           [P] Cadastrar professor";
            init.Linha21 = "[C] Cadastrar curso           [D] Cadastrar disciplina";
            init.Linha22 = "[R] Relatórios                  [Q] Sair do programa";
            
            init.ImprimirJanela(1, 1, boxWidth:Width-2, boxHeight:Height-2);
            return RetornarChar(52, 15); // usa este metodo para substituir as linhas, posicionar o cursor, e retornar a opcao do usuario
        }
        
        
        /// <summary>
        /// Imprime uma janela. Usa as propriedades Linhas para imprimir as informações na tela. 
        /// </summary>
        /// <param name="posicaoX">"Ajusta a posição L-O em que o cursor ficará na tela"</param>
        /// <param name="posicaoY">"Ajusta a posição N-S em que o cursor ficará na tela"</param>
        /// <param name="cor">"Seta a cor das informações. Ex. Uso: ConsoleColor.White"</param>
        internal void ImprimirJanela(int posicaoX = 0, int posicaoY = 0, ConsoleColor? corFundo = null, ConsoleColor? corTexto = null, int boxWidth = 94, int boxHeight = 1, int cursorX = 2, int cursorY = 1) // substitui linhas pela informacao necessaria. Usar dentro da classe
        {
            
            ConsoleColor fundoAtual = Console.BackgroundColor;
            ConsoleColor textoAtual = Console.ForegroundColor;
            int OrigPosY = posicaoY;

            Console.SetCursorPosition(posicaoX, posicaoY); // seta a posição do cursor para começar a impressão


            if (corFundo.HasValue) // seta a cor do fundo se o valor for passado como parametro
            {
                Console.BackgroundColor = corFundo.Value;
            }

            if (corTexto.HasValue) // seta a cor do texto se o valor for passado
            {
                Console.ForegroundColor = corTexto.Value;
            }

            if (Margens)
            {
                TextoCentralizado("", starter: '╔', sep: '═', ends: '╗', width: boxWidth);

            for (int i = 1; i <= 25; i++)
            {
                if (boxHeight >= i)
                {
                    posicaoY++;
                    Console.SetCursorPosition(posicaoX, posicaoY);
                    TextoCentralizado("", width:boxWidth);
                    }
                }
                Console.SetCursorPosition(posicaoX, posicaoY+1);
                TextoCentralizado("", starter: '╚', sep: '═', ends: '╝', width: boxWidth);
            }

            posicaoY = OrigPosY;
            //posicaoX++;

            for (int i = 1; i <= 25; i++)
            {
                if (boxHeight >= i)
                {
                    posicaoY++;
                    Console.SetCursorPosition(posicaoX, posicaoY);
                    linhas = new() {"", Linha1, Linha2, Linha3, Linha4, Linha5, Linha6, Linha7, Linha8, Linha9, Linha10, Linha11, Linha12, Linha13, Linha14, Linha15, Linha16, Linha17, Linha18, Linha19, Linha20, Linha21, Linha22, Linha23, Linha24, Linha25};                    
                    TextoCentralizado(SubstituirPalavras(linhas[i], width: boxWidth-2, starter:' ', ends:' '));
                }
            }
            
            

            Console.SetCursorPosition(cursorX, cursorY); // posicionando cursor no final ( padrão no canto esquerdo superior )
            Console.BackgroundColor = fundoAtual; // retorna ao valor default do c# para evitar bugs
            Console.ForegroundColor = textoAtual; // retorna ao valor default do c# para evitar bugs
        }


        /// <summary>
        /// Posiciona cursor na tela, e retorna um 'char'
        /// </summary>
        /// <param name="cursorX">posição do cursor no eixo leste-oeste</param>
        /// <param name="cursorY">posição do cursor no eixo norte-sul</param>
        /// <returns></returns>
        internal char RetornarChar(int cursorX, int cursorY) // posiciona o cursor e retorna o char digitado pelo user
        {               
            Console.SetCursorPosition(cursorX, cursorY); //posicionamento do cursor para input
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
            Console.Write(" " + starter + paddedText + ends + " "); // cria o texto centralizado na tela usando starter e ends como margem

        }
        /// <summary>
        ///SubstituirPalavras é uma versão alterada de TextoCentralizado, imprimindo o que deve ser escrito
        ///para poder utilizar como argumento, dentro de TextoCentralizado(), assim podendo imprimir texto dentro das margens, sem apagá-las
        ///'sep' pode ser usado para substituir espaços pelo char escolhido. Útil para criar linhas.
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
            string replacer = (starter + palavra + ends); // cria o texto centralizado na tela usando os "ends" como margem
            return replacer;
        }
    }
}
