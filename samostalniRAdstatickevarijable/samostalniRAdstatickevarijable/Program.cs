using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samostalniRAdstatickevarijable
{
 
    public class PrvaKlasa
    {
        private static int counter;

        public PrvaKlasa()
        {
            counter++;
        }

        public static int Counter
        {
            get { return counter; }
        }
    }

    PrvaKlasa x = new PrvaKlasa();
    PrvaKlasa y = new PrvaKlasa();
    PrvaKlasa z = new PrvaKlasa();

    Console.WriteLine(PrvaKlasa.Counter);

}
