using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Mastermind
{
    public class Probabilities
    {
        private Hashtable fixedIndices_ = new Hashtable();

        private Utilities innerUtils = new Utilities();

        public Probabilities()
        {
            this.UsableDigits = new List<int>();

            this.FixedIndices = new List<int>();

            this.UseSameDigits = false;

            this.Correct = 0;

            this.InCorrect = 0;
        }

        public int Correct { get; set; }

        public int InCorrect { get; set; }

        public List<int> UsableDigits { get; set; }

        public bool UseSameDigits { get; set; }

        public List<int> FixedIndices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usabledigits"></param>
        /// <param name="number"></param>
        /// <param name="fixedIndices"></param>
        /// <param name="newnumber"></param>
        /// <returns></returns>
        private bool TryAndForceIncrease(int number, int index, out int newnumber)
        {
            int newDigit;

            int numberLength = number.ToString().Length;

            if (TryIncrease(number, innerUtils.GetDigitAtIndex(number, index), out newDigit))
            {
                newnumber = innerUtils.ChangeDigitAtIndex(number, index, newDigit);

                newnumber = ResetNumber(newnumber, index);

                return true;
            }
            else
                return ForceIncrease(number, out newnumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="newnumber"></param>
        /// <returns></returns>
        private bool ForceIncrease(int number, out int newnumber)
        {
            int tmpNumber = number;

            bool breakfor = false;

            string stringNumber = number.ToString();

            int currentDigit;
            for (int i = stringNumber.Length - 2; i > -1; i--)
            {
                if (!this.fixedIndices_.Contains(i))
                {
                    currentDigit = int.Parse(stringNumber[i].ToString());

                    int currentIndex = this.UsableDigits.FindIndex(delegate(int x) { return x == currentDigit; });

                    if (currentIndex >= 0)
                    {
                        for (int j = currentIndex; j < this.UsableDigits.Count; j++)
                        {
                            if (this.UsableDigits[j] != currentDigit)
                            {
                                // check if 0....i-1 contains the new digit
                                if (!innerUtils.ContainsNumber(0, i, number, this.UsableDigits[j]) || this.UseSameDigits)
                                {
                                    // check if new digit equals to any fixed values 
                                    if (!this.fixedIndices_.ContainsValue(this.UsableDigits[j]) || this.UseSameDigits)
                                    {
                                        tmpNumber = innerUtils.ChangeDigitAtIndex(number, i, this.UsableDigits[j]);

                                        tmpNumber = ResetNumber(tmpNumber, i);

                                        breakfor = true;

                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (breakfor)
                    break;
            }

            newnumber = tmpNumber;

            return tmpNumber != number;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="currentdigit"></param>
        /// <param name="nextdigit"></param>
        /// <returns></returns>
        private bool TryIncrease(int number, int currentdigit, out int nextdigit)
        {
            nextdigit = -1;

            if (this.UsableDigits.Contains(currentdigit))
            {
                int index = this.UsableDigits.FindIndex(delegate(int x) { return x == currentdigit; });

                if (index >= 0)
                {
                    if (index == this.UsableDigits.Count - 1)
                        return false;
                    else
                    {
                        if ((!innerUtils.ContainsNumber(number, this.UsableDigits[index + 1]) &&
                            !this.fixedIndices_.ContainsValue(this.UsableDigits[index + 1])) ||
                            this.UseSameDigits
                            )
                        {
                            nextdigit = this.UsableDigits[index + 1];
                            return true;
                        }
                        else
                            return TryIncrease(number, this.UsableDigits[index + 1], out nextdigit);
                    }
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private int ResetNumber(int number, int index)
        {
            int tmpnumber = number;

            for (int i = index + 1; i < tmpnumber.ToString().Length; i++)
            {
                // check if index is fixed or not
                if (!this.fixedIndices_.Contains(i))
                {
                    int min = -1;

                    // find the min value and set it to the current index
                    for (int j = 0; j < this.UsableDigits.Count; j++)
                    {
                        if (!innerUtils.ContainsNumber(0, i, tmpnumber, this.UsableDigits[j]) || this.UseSameDigits)
                        {
                            if ((i == 0 && this.UsableDigits[j] != 0) || (i > 0))
                            {
                                min = this.UsableDigits[j];
                                break;
                            }
                        }
                    }

                    // set new value
                    tmpnumber = innerUtils.ChangeDigitAtIndex(tmpnumber, i, min);
                }
            }

            return tmpnumber;
        }

        public List<int> GetPossibleNumbersFromDigits(int digitCount)
        {
            List<int> result = new List<int>();

            if (digitCount > 3)
            {
                if (digitCount > 9)
                    digitCount = 9;

                this.UsableDigits.Sort();

                if (this.UsableDigits[0] > 0)
                    result = this.GetProbabilities(int.Parse(this.UsableDigits[0].ToString().PadRight(digitCount, '0')));
                else
                    result = this.GetProbabilities(int.Parse(this.UsableDigits[1].ToString().PadRight(digitCount, '0')));
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<int> GetProbabilities(int currentNumber)
        {
            List<int> result = new List<int>();

            if (this.UsableDigits != null)
            {
                if (this.UsableDigits.Count > 0)
                {
                    if (currentNumber.ToString().Length <= this.UsableDigits.Count + this.Correct + this.InCorrect)
                    {
                        // sort digits first
                        this.UsableDigits.Sort();

                        // init fixed indices
                        this.fixedIndices_.Clear();
                        foreach (int i in this.FixedIndices)
                            this.fixedIndices_.Add(i, innerUtils.GetDigitAtIndex(currentNumber, i));

                        // reset the number
                        currentNumber = this.ResetNumber(currentNumber, -1);

                        // add the minimum value to the result
                        result.Add(currentNumber);

                        // get last usable index
                        int usableLastIndex = -1;
                        for (int i = currentNumber.ToString().Length - 1; i > -1; i--)
                        {
                            if (!this.FixedIndices.Contains(i))
                            {
                                usableLastIndex = i;
                                break;
                            }
                        }

                        if (usableLastIndex > -1)
                        {
                            int newNumber = 0;

                            // can we increase the current indexed number
                            while (TryAndForceIncrease(currentNumber, usableLastIndex, out newNumber))
                            {
                                if (newNumber != 0)
                                {
                                    // add it to the result
                                    result.Add(newNumber);

                                    // call it from the beginning
                                    currentNumber = newNumber;
                                }
                            }
                        }
                    }
                    else
                        throw new Exception("Not enough digits to generate new numbers!\r\nPool Size : " + 
                            this.UsableDigits.Count.ToString() + "\r\nCorrect : " + this.Correct.ToString() + 
                            "\r\nInCorrect : " + this.InCorrect.ToString() + "\r\nNumber : " + currentNumber.ToString());
                }
                else
                    throw new Exception("Digit pool length cannot be zero!");
            }
            else
                throw new Exception("Digit pool cannot be null!");

            return result;
        }

    }
}
