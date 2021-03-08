using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018.Dagen
{
    class Dag1
    {
        private string _filePath;
        private List<string> _lines;

        private int _ans1, _ans2;

        public Dag1()
        {
            // initialiseer de filepath en append elke lijn text aan de _lines list.
            _filePath = @"C:\Users\danie\source\repos\AdventOfCode2018\AdventOfCode2018\TextFiles\Dag1.txt";
            _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
        }
        
        private void calcPart1()
        {
            foreach (string line in _lines)
            {
                _ans1 += int.Parse(line);
            }
        }

        public void runDag1()
        {
            calcPart1();
            Console.WriteLine(_ans1);
        }
    }
}
