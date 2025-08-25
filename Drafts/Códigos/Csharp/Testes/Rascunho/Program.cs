using static System.Console;
using System;
using System.Linq;


namespace Rascunho
{
    class funcoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos -------");

            string empresa = " Microsoft Corporation ";
            WriteLine("TRIM - retira os espaços em breanco antes e após a expressão");
            WriteLine($"Nome sem espaços: {empresa.Trim()}");
        }
    }
}
