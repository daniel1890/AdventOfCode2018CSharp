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
            this._filePath = @"TextFiles/Dag2.txt";
            _lines = _lines = File.ReadAllLines(_filePath).ToList();

            _ans1 = 0;
            _ans2 = 0;

            aantalTweePerRij = new Boolean[_lines.Count];
            aantalDriePerRij = new Boolean[_lines.Count];

            aantalTwee = 0;
            aantalDrie = 0;
        }

        private Boolean[] aantalTweePerRij;
        private Boolean[] aantalDriePerRij;

        private int aantalTwee;
        private int aantalDrie;

        public void CalcPart1()
        {
            foreach (string line in _lines)
            {
                CountStrings(line, _lines.IndexOf(line));
            }

            _ans1 = aantalTwee * aantalDrie;
        }

        public void CountStrings(string letters, int index)
        {
            string[] lettersList = new string[letters.Length];
            aantalTweePerRij[index] = false;
            aantalDriePerRij[index] = false;

            foreach (char letter in letters)
            {
                lettersList[letters.IndexOf(letter)] = letter.ToString();
            }

            foreach (char letter in letters)
            {
                int count = letters.Split(letter).Length - 1;

                if (count == 2) { aantalTweePerRij[index] = true; }
                if (count == 3) { aantalDriePerRij[index] = true; }
            }

            if (aantalTweePerRij[index] == true) { aantalTwee++; }
            if (aantalDriePerRij[index] == true) { aantalDrie++; }
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