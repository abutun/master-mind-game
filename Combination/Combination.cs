using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind
{
    public class Combination
    {
        List<string> innerArray_ = new List<string>();

        public Combination()
        {
            this.Combinations = 0;
            this.ReturnIndices = true;
        }

        public bool ReturnIndices { get; set; }

        public char[] InputSet { get; set; }

        public int Combinations { get; set; }

        public List<string> GetCombinations()
        {
            if (this.InputSet.Length > 0 && this.Combinations > 0)
                GetCombinations("", -1);
            else
                throw new Exception("Input set or combination is not defined!");

            return this.innerArray_;
        }

        public List<string> GetCombinations(char[] inputset, int combinations)
        {
            this.InputSet = inputset;
            this.Combinations = combinations;

            return this.GetCombinations();
        }

        /// <summary>
        /// Kombinasyon hesaplamasını yapar
        /// </summary>
        /// <param name="current">Şu anki işlenen veri</param>
        /// <param name="index">İşlenen veri indexi</param>
        private void GetCombinations(string current, int index)
        {
            for (int i = index + 1; i < this.InputSet.Length; i++)
            {
                string tmp = "";

                if(this.ReturnIndices)
                    tmp = current + i.ToString();
                else
                    tmp = current + this.InputSet[i].ToString();

                GetCombinations(tmp, i);
            }

            if (current.Length == this.Combinations)
                this.innerArray_.Add(current);
        }
    }
}
