using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishKana;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EnglishKanaDictionary e2k = new EnglishKanaDictionary();
            while (true)
            {
                string readString = Console.ReadLine();
                Console.WriteLine(e2k.ReplaceEnglishToKana(readString));
                if (readString == "exit")
                {
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
            }
        }
    }
}
