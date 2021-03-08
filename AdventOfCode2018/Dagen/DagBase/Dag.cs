using AdventOfCode2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018.Dagen.DagBase
{
    public abstract class Dag
    {
        protected string _filePath;
        protected List<string> _lines;

        protected int _ans1, _ans2;

        public override string ToString()
        {
            string typeOf = this.GetType().Name;
            return $"{typeOf}: \nAntwoord deel 1: {_ans1} \nAntwoord deel 2: {_ans2} \n~~~~~~~~~~~~~~~~~~~~";
        }
    }
}