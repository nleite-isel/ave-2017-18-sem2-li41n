using System;
using System.Collections.Generic;

namespace Aula33.Generics
{
    public class ArrayCastToIListGeneric
    {
        public ArrayCastToIListGeneric()
        {
        }

        public static void Main1() {
            int[] arr = { 1, 2, 3, 4, 5 }; // Deriva de Array
            IList<int> list = arr; // Interface generica suportada em tempo de execucao, ou seja, metodos genericos nao sao visiveis na
                                   // API de Array
            list.Add(6); // Excecao, array tem dimensao fixa e e' readonly

            foreach (int i in list) {
                Console.WriteLine(i);
            }

        }
    }
}
