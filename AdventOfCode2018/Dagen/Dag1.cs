﻿using AdventOfCode2018.Dagen.DagBase;
using AdventOfCode2018.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018.Dagen
{
    internal class Dag1 : Dag, IDag
    {
        public Dag1()
        {
            // initialiseer de filepath en append elke lijn text aan de _lines list.
            _filePath = @"C:\Users\danie\Source\Repos\AdventOfCode2018CSharp\AdventOfCode2018\TextFiles\Dag1.txt";
            _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
        }

        public void CalcPart1()
        {
            foreach (string line in _lines)
            {
                _ans1 += int.Parse(line);
            }
        }

        public void CalcPart2()
        {
            throw new NotImplementedException();
        }

        public void RunDag()
        {
            CalcPart1();
            Console.WriteLine(this.ToString());
        }
    }
}