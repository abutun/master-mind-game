using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind
{
    public class ProbabilitiesHash
    {
        public ProbabilitiesHash()
        {
            this.Numbers = new List<int>();
            this.Indices = new List<string>();
            this.DigitPools = new List<List<int>>();
        }

        public List<string> Indices { get; set; }

        public List<int> Numbers { get; set; }

        public List<List<int>> DigitPools { get; set; }
    }
}
