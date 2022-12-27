﻿using DesignPatternsII.Cap2;
using System;
using System.Collections.Generic;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),
            };

            Piano piano = new Piano();
            piano.Toca(musica);


            Console.ReadKey();
        }
    }
}
