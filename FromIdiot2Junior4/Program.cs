using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromIdiot2Junior4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRINGS!!!ONE!!
            Stopwatch stopwatch = new Stopwatch();
            string misio = TextGen("Komsa misio costam costam cos innego #0 i #1", "kolos", 55);
            Console.WriteLine(misio);
            int x = 100;
            stopwatch.Start();
            Console.WriteLine(TextGenBuilder(x));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Restart();
            //stopwatch.Start();
            Console.WriteLine(TextBuilder(x));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            
        }

 

        private static string TextGenBuilder(int x)
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < x; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }

        private static string TextBuilder(int x)
        {
            string tekst = "";
            for (int i = 0; i < x; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        public static string TextGen(string tekst, params object[] args) //to ciekawe
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#"+i.ToString(), args[i].ToString());
            }
            return tekst;
        }


    }
}
