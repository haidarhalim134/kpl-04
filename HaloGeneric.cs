using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmoduil5_1302220152
{
    internal class HaloGeneric
    {
        public static void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }
}
