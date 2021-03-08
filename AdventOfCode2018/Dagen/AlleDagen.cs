using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018.Dagen
{
    class AlleDagen
    {
        Dag1 dag1;

        public AlleDagen()
        {
            dag1 = new Dag1();
        }

        public void RunAlleDagen()
        {
            dag1.runDag1();
        }
    }
}
