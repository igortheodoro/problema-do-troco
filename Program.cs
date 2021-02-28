using System;
using System.Collections.Generic;

namespace ProblemaDoTroco
{
    class Program
    {
        static void Main(string[] args)
        {
            var moedasTroco = Troco(23);

            foreach (var moeda in moedasTroco)
            {
                Console.Write($" {moeda}");
            }
        }

        static List<int> Troco(int valor)
        {
            var moedas = new int[] { 100, 25, 10, 5, 1 };
            var troco = new List<int>();

            for (int i = 0; i < moedas.Length; i++)
            {
                var divisao = valor / moedas[i];

                if (divisao > 0)
                {
                    var moedasDiv = divisao * moedas[i];
                    valor -= moedasDiv;

                    for (int j = 0; j < divisao; j++)
                    {
                        troco.Add(moedas[i]);
                    }
                }
            }

            return troco;
        }
    }
}
