using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace wpfsmajlicimoje
{    
    public static class Permutations
    {
        // Generator vsech permutaci P(9) = 9! = 362.880 moznosti
        // na zaklade Heap algoritmu Wiki: https://en.wikipedia.org/wiki/Heap%27s_algorithm#cite_note-3
        // C# verze: https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer

        public static bool GetAllPermutation<T>(T[] items, Func<T[], bool> funcExecuteAndTellIfShouldStop)
        {
            int countOfItem = items.Length;

            if (countOfItem <= 1)
            {
                return funcExecuteAndTellIfShouldStop(items);
            }

            var indexes = new int[countOfItem];
            for (int i = 0; i < countOfItem; i++)
            {
                indexes[i] = 0;
            }

            if (funcExecuteAndTellIfShouldStop(items))
            {
                return true;
            }

            for (int i = 1; i < countOfItem;)
            {
                if (indexes[i] < i)
                { 
                    if ((i & 1) == 1) 
                    {
                        Swap(ref items[i], ref items[indexes[i]]);
                    }
                    else
                    {
                        Swap(ref items[i], ref items[0]);
                    }

                    if (funcExecuteAndTellIfShouldStop(items))
                    {
                        return true;
                    }

                    indexes[i]++;
                    i = 1;
                }
                else
                {
                    indexes[i++] = 0;
                }
            }

            return false;
        }
        

        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        
        // volam tuto funkci z nadrazene tridy
        public  static List<string> Test(List<string[]> test1 )
        {  
            // vytvorim si pomoczy list pro ulozeni vysledku
            List<string> mojepermy = new List<string>() ;
          
            // pomocne pole jen s ID ctveru - pouze napr. "A1B2C3D1E4F1G2H1I4"
            string[] values = new string[] { test1.ElementAt(0)[0], test1.ElementAt(1)[0], test1.ElementAt(2)[0],
                                test1.ElementAt(3)[0], test1.ElementAt(4)[0], test1.ElementAt(5)[0],
                                test1.ElementAt(6)[0], test1.ElementAt(7)[0], test1.ElementAt(8)[0]};            
           
            // vyrobi a nacpe mi permutace do pomocneho listu
            GetAllPermutation(values, (x) =>
            {                
                mojepermy.Add(String.Join("", x)); 
                return false;
            });          

            return mojepermy;
        }
        
    }

}

