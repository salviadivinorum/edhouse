using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfsmajlicimoje
{
    // nahodne vybere dalsi prvek z listu/pole
    // pouzivam to jako "heuristiku" - nelze cekat 3.5 dne na vsechny 9.5 E10 permutace
    public static class ColectionExtension
    {
        // pro Listy
        private static Random rng = new Random();

        public static T RandomElement<T>(this IList<T> list)
        {
            return list[rng.Next(list.Count)];
        }

        // pro Pole
        public static T RandomElement<T>(this T[] array)
        {
            return array[rng.Next(array.Length)];
        }        
    }
}
