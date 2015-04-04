using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind
{
    public class Permutation
    {
        List<string> innerArray_ = new List<string>();

        public Permutation()
        {
            this.Permutations = 0;
            this.UseRepeatation = false;
            this.ReturnIndices = true;
        }

        public char[] InputSet { get; set; }

        public bool ReturnIndices { get; set; }

        public bool UseRepeatation { get; set; }

        public int Permutations { get; set; }

        public List<string> GetPermutations()
        {
            List<string> result = new List<string>();

            if (this.InputSet.Length > 0 && this.Permutations > 0)
                GetPermutations("");
            else
                throw new Exception("Input set or permutation is not defined!");

            return this.innerArray_;
        }

        public List<string> GetPermutations(char[] inputset, int permutations)
        {
            this.InputSet = inputset;
            this.Permutations = permutations;

            return this.GetPermutations();
        }

        private void GetPermutations(string current)
        {
            if (current.Length < this.Permutations)
            {
                for (int i = 0; i < this.InputSet.Length; i++)
                {
                    string tmp = "";

                    if (this.ReturnIndices)
                        tmp = i.ToString();
                    else
                        tmp = this.InputSet[i].ToString();

                    if (current.IndexOf(tmp) < 0 || this.UseRepeatation)
                        this.GetPermutations(current + tmp);
                }
            }
            else if (current.Length == this.Permutations)
                this.innerArray_.Add(current);
        }
    }
}
