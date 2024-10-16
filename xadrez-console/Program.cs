using System;
using xadrez_console.tabuleiro;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new(8, 8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
