using System;
using System.Collections.Generic;

namespace AVE_T1_SEM_INV_1718.Questao5
{

//    5. [2] Acrescente à interface IEnumerable<T> suporte para a operação lazy Flatten, que recebe uma sequência de
//subsequências(e.g.words) e junta todos os elementos de cada subsequência numa nova sequência.Exemplo:
//IEnumerable<IEnumerable<char>> words = new string[] { "ola", "super", "isel" };
//foreach(char c in words.Flatten()) Console.Write(c); // > olasuperisel


    public static class Questao5_ExtensionMethods
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> seq) {
            foreach (var subSeq in seq)
            {
                foreach (var item in subSeq)
                {
                    yield return item;
                }
            }
        }        
    }

    class MainClass
    {
        public static void Main1(string[] args)
        {
            IEnumerable<IEnumerable<char>> words = new string[] { "ola", "super", "isel" };
            foreach (char c in words.Flatten())
            {
                Console.Write(c); // > olasuperisel
            }
        }
    }
}
