using AdventOfCode2018.Dagen.DagBase;
using AdventOfCode2018.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018.Dagen
{
    public class Dag2 : Dag, IDag
    {
        public Dag2()
        {
            this._filePath = @"C:\Users\danie\Source\Repos\AdventOfCode2018CSharp\AdventOfCode2018\TextFiles\Dag2.txt";
            _lines = _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
            _ans2 = 0;
        }

        public void CalcPart1()
        {
            throw new NotImplementedException();
        }

        public void CalcPart2()
        {
            throw new NotImplementedException();
        }

        public void RunDag()
        {
            Console.WriteLine(this.ToString());
        }
    }
}