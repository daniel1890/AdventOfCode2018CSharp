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
        private Boolean test1Dag;

        public AlleDagen()
        {
            dag1 = new Dag1();
            dag2 = new Dag2();

            test1Dag = true;
        }

        public void RunAlleDagen()
        {
            if (test1Dag == false)
            {
                dag1.RunDag();
                dag2.RunDag();
            }
            else
            {
                dag2.RunDag();
            }
        }
    }
}