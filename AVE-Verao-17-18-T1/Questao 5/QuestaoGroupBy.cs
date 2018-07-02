using System;
using System.Collections.Generic;
using System.Linq;

namespace AVEVerao1718T1.Questao5
{
    public static class ExtensionMethods {
        public static IEnumerable<IEnumerable<T>> GroupBy<T, W>(this IEnumerable<T> seq, Func<T, W> func) 
        {
            Console.WriteLine("GroupBy");
            
            List<W> groups = new List<W>();
            foreach (var item in seq)
            {
                W w = func(item);
                if (!groups.Contains(w))
                {
                    yield return GetGroup(seq, func, w);
                    // Add w to list of criteria already processed
                    groups.Add(w);
                }
            }
        }

        private static IEnumerable<T> GetGroup<T, W>(IEnumerable<T> seq, Func<T, W> func, W w)
        {
            foreach (var item in seq)
            {
                if (func(item).Equals(w))
                {
                    yield return item;
                }
            }
        }
    }

    public class QuestaoGroupBy
    {
        public static void Main()
        {
            IEnumerable<string> words = new string[]
                   { "isel", "k", "ola", "vue", "z", "soup", "kat", "bart" };

            IEnumerable<IEnumerable<string>> res = words.GroupBy(w => w.Length);

            foreach (IEnumerable<string> w in res)
                Console.WriteLine(String.Join(",", w));
        }

    }

}

