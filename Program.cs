using System;
using System.Collections.Generic ;

namespace generic_list
{
    class Program
    {
        static void Main (string [] args)
        {
            //List<T> class
            // System.Collections.Generic
            //T-> object turundedir.

            List<int> numberlist = new List<int>() ;
            numberlist.Add(23);
            numberlist.Add(10);
            numberlist.Add(4);
            numberlist.Add(5);
            numberlist.Add(92);
            numberlist.Add(34) ;

            List<string> colorlist = new List<string>() ;
            colorlist.Add("Red");
            colorlist.Add("Blue");
            colorlist.Add("Orange");
            colorlist.Add("Yellow");
            colorlist.Add("Green");

            //Count
            Console.WriteLine(colorlist.Count);
            Console.WriteLine(numberlist.Count);


            //Foreach ve List.ForEach ine elemanlara erisim
            foreach (var number in numberlist)
                    Console.WriteLine(number) ;
            foreach (var color in colorlist)
                    Console.WriteLine(color) ;
            numberlist.ForEach(number=> Console.WriteLine(number));
            colorlist.ForEach(color=> Console.WriteLine(color));

            // Listeden eleman cikarma

            numberlist.Remove(4);
            colorlist.Remove("Green") ;

            numberlist.ForEach(number=> Console.WriteLine(number));
            colorlist.ForEach(color=> Console.WriteLine(color));

            numberlist.RemoveAt(0) ;
            colorlist.RemoveAt(1) ;

            numberlist.ForEach(number=> Console.WriteLine(number));
            colorlist.ForEach(color=> Console.WriteLine(color));

            //Liste icerisinde arama
            if (numberlist.Contains(10))
                {
                    Console.WriteLine("10 liste icerisinde bulundu") ;

                }

            //Eleman ile index'e erisme

            Console.WriteLine(colorlist.BinarySearch("Orange"));

            







            
        }
        }
        }

