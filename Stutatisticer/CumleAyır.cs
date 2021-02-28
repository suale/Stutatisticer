using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stutatisticer
{
    class CumleAyır
    {
        public static void ayir(string gelenCumle)
        {
            var punctuation = gelenCumle.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = gelenCumle.Split().Select(x => x.Trim(punctuation));
            int eightCount = 0;
            foreach(string word in words)
            {
                if (word == "8")
                {
                    eightCount++;
                }
               while(eightCount!=0)
                {

                }
            }
        }


    }
}
