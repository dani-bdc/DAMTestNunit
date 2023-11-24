using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNunitLibrary
{
    public class Words
    {
        public static int NumWords(string word)
        {
            return word.Split(" ").Length;
            
        }
    }
}
