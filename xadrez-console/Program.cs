﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
