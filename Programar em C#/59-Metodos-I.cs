﻿// Programar em C# #59 - Métodos I

using System;
using System.Text.RegularExpressions;

namespace Base {
    class MetodosI {
        private string umDoisTres = "UmDoisTrês", nome = "Nelson Gomes da Silva";

        public void Run() {
            // Substring()
            Console.WriteLine($"1: {umDoisTres.Substring(0, 2)}");
            Console.WriteLine($"2: {umDoisTres.Substring(2, 4)}");
            Console.WriteLine($"3: {umDoisTres.Substring(6)}");

            // Split()
            var palavras = nome.Split(' ');

            foreach (var palavra in palavras)
                Console.WriteLine($"Palavra: {palavra}");

            var _palavras = Regex.Split(nome, " Gomes da ");
            Console.WriteLine($"Nome: {_palavras[0]} {_palavras[1]}");
        }
    }
}