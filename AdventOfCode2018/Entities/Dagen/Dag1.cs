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
    internal class Dag1 : Dag, IDag
    {
        public Dag1()
        {
            /* initialiseer de filepath en append elke lijn text aan de _lines list.
             * door bij de txt file eigenschappen te gaan en build action "embedded resource" te maken,
             * en door bij copy to output directory "copy if newer" te selecteren
             * wordt de txt file beschikbaar gemaakt aan het programma tijdens de build.
             */

            _filePath = @"TextFiles/Dag1.txt";
            _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
            _ans2 = 0;

            _getallenLijst = new();
            _antwoordGevondenPart2 = false;
        }

        private Boolean _antwoordGevondenPart2;

        private List<int> _getallenLijst;

        public void CalcPart1()
        {
            foreach (string line in _lines)
            {
                _ans1 += int.Parse(line);
            }
        }

        public void CalcPart2()
        {
            while (_antwoordGevondenPart2 == false)
            {
                foreach (string line in _lines)
                {
                    _ans2 += int.Parse(line);

                    if (_getallenLijst.Contains(_ans2))
                    {
                        Console.WriteLine(_ans2);
                        _antwoordGevondenPart2 = true;
                        break;
                    }

                    _getallenLijst.Add(_ans2);
                }
            }
        }

        public void RunDag()
        {
            CalcPart1();
            CalcPart2();
            Console.WriteLine(this.ToString());
        }
    }
}