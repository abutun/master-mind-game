using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mastermind
{
    public class Utilities
    {
        public Utilities()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="digit"></param>
        /// <returns></returns>
        public bool ContainsNumber(int number, int digit)
        {
            return number.ToString().IndexOf(digit.ToString(), 0, number.ToString().Length) >= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startindex"></param>
        /// <param name="count"></param>
        /// <param name="number"></param>
        /// <param name="digit"></param>
        /// <returns></returns>
        public bool ContainsNumber(int startindex, int count, int number, int digit)
        {
            return number.ToString().IndexOf(digit.ToString(), startindex, count) >= 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetDigitAtIndex(int number, int index)
        {
            string strNumber = number.ToString();

            if (index < strNumber.Length)
                return int.Parse(strNumber[index].ToString());
            else
                return -1;
        }

        /// <summary>
        /// Changes the digit of a number
        /// </summary>
        /// <param name="number">The number that we are modifying</param>
        /// <param name="index">The index of the digit.</param>
        /// <param name="newdigit">New digit value that we will replace with specified index value</param>
        /// <returns>Returns the modified new number</returns>
        public int ChangeDigitAtIndex(int number, int index, int newdigit)
        {
            if (newdigit >= 0)
            {
                string num1 = number.ToString();
                string num2 = "";

                for (int i = 0; i < num1.Length; i++)
                {
                    if (i == index)
                        num2 += newdigit.ToString();
                    else
                        num2 += num1[i].ToString();
                }

                return int.Parse(num2);
            }
            else
                throw new Exception("New digit cannot be negative!\r\nNumber : " + number.ToString() + "\r\nIndex" + index.ToString() +
                    "\r\nNew Digit : " + newdigit.ToString());
        }
    }
}
