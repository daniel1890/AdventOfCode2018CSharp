using AdventOfCode2018.Dagen.DagBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018.Dagen
{
    internal class AlleDagen
    {
        private Dag1 dag1;
        private Dag2 dag2;

        public AlleDagen()
        {
            dag1 = new Dag1();
            dag2 = new Dag2();
        }

        public void RunAlleDagen()
        {
            dag1.RunDag();
            dag2.RunDag();
        }
    }
}