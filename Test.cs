using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Mastermind
{
    public partial class Test : Form
    {
        Probabilities Probabilities = new Probabilities();

        List<int> globalPermutations = new List<int>();


        public Test()
        {
            InitializeComponent();
        }

        //private bool ContainsNumber(int number, int digit)
        //{
        //    return number.ToString().IndexOf(digit.ToString(), 0, number.ToString().Length) >= 0;
        //}

        ///// <summary>
        ///// Returns if the specified number contains the specified digit or not.
        ///// </summary>
        ///// <param name="number">The number which we will seek for the digit.</param>
        ///// <param name="digit">The digit that we will search for.</param>
        ///// <returns>True or False</returns>
        //private bool ContainsNumber(int startindex, int count, int number, int digit)
        //{
        //    return number.ToString().IndexOf(digit.ToString(), startindex, count) >= 0;
        //}

        ///// <summary>
        ///// Returns the digit with the specified index
        ///// </summary>
        ///// <param name="number">The number that we will get a part of it</param>
        ///// <param name="index">The index of the digit we are looking for.</param>
        ///// <returns>Returns the one length digit.</returns>
        //private int GetDigitAtIndex(int number, int index)
        //{
        //    string num = number.ToString();

        //    return int.Parse(num[index].ToString());
        //}

        ///// <summary>
        ///// Changes the digit of a number
        ///// </summary>
        ///// <param name="number">The number that we are modifying</param>
        ///// <param name="index">The index of the digit.</param>
        ///// <param name="newdigit">New digit value that we will replace with specified index value</param>
        ///// <returns>Returns the modified new number</returns>
        //private int ChangeDigitAtIndex(int number, int index, int newdigit)
        //{
        //    string num1 = number.ToString();
        //    string num2 = "";

        //    for (int i = 0; i < num1.Length; i++)
        //    {
        //        if (i == index)
        //            num2 += newdigit.ToString();
        //        else
        //            num2 += num1[i].ToString();
        //    }

        //    return int.Parse(num2);
        //}

        //private bool TryAndForceIncrease(List<int> usabledigits, int number, Hashtable fixedIndices, out int newnumber)
        //{
        //    int newDigit;

        //    int numberLength = number.ToString().Length;

        //    if (TryIncrease(usabledigits, number, GetDigitAtIndex(number, numberLength - 1), fixedIndices, out newDigit))
        //    {
        //        newnumber = ChangeDigitAtIndex(number, numberLength - 1, newDigit);

        //        newnumber = ResetNumber(usabledigits, newnumber, numberLength - 1, fixedIndices);

        //        return true;
        //    }
        //    else
        //        return ForceIncrease(usabledigits, number, fixedIndices, out newnumber);
        //}

        //private bool ForceIncrease(List<int> usabledigits, int number, Hashtable fixedIndices, out int newnumber)
        //{
        //    int tmpNumber = number;

        //    bool breakfor = false;

        //    string stringNumber = number.ToString();

        //    int currentDigit;
        //    for (int i = stringNumber.Length - 2; i > -1; i--)
        //    {
        //        if (!fixedIndices.Contains(i))
        //        {
        //            currentDigit = int.Parse(stringNumber[i].ToString());

        //            int currentIndex = usabledigits.FindIndex(delegate(int x) { return x == currentDigit; });

        //            for (int j = currentIndex; j < usabledigits.Count; j++)
        //            {
        //                if (usabledigits[j] != currentDigit)
        //                {
        //                    // check if 0....i-1 contains the new digit
        //                    if (!ContainsNumber(0, i, number, usabledigits[j]))
        //                    {
        //                        // check if new digit equals to any fixed values 
        //                        if (!fixedIndices.ContainsValue(usabledigits[j]))
        //                        {
        //                            tmpNumber = ChangeDigitAtIndex(number, i, usabledigits[j]);

        //                            tmpNumber = ResetNumber(usabledigits, tmpNumber, i, fixedIndices);

        //                            breakfor = true;

        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (breakfor)
        //            break;
        //    }

        //    newnumber = tmpNumber;
                
        //    return tmpNumber!=number;
        //}

        ///// <summary>
        ///// Shows if the number[index] can be increased or not
        ///// </summary>
        ///// <param name="usabledigits">Digit pool that we use to generate numbers</param>
        ///// <param name="number">The number</param>
        ///// <param name="currentdigit">Current value of digit</param>
        ///// <param name="nextdigit">If currentdigit can be increased, nextdigit shows the next digit</param>
        ///// <returns>Returns if the number[index] can be increased or not</returns>
        //private bool TryIncrease(List<int> usabledigits, int number, int currentdigit, Hashtable fixedIndices, out int nextdigit)
        //{
        //    nextdigit = -1;

        //    if (usabledigits.Contains(currentdigit))
        //    {
        //        int index = usabledigits.FindIndex(delegate(int x) { return x == currentdigit; });

        //        if (index == usabledigits.Count - 1)
        //            return false;
        //        else
        //        {
        //            if (!ContainsNumber(number, usabledigits[index + 1]) && !fixedIndices.ContainsValue(usabledigits[index + 1]))
        //            {
        //                nextdigit = usabledigits[index + 1];
        //                return true;
        //            }
        //            else
        //                return TryIncrease(usabledigits, number, usabledigits[index + 1], fixedIndices, out nextdigit);
        //        }
        //    }
        //    else
        //        return false;
        //}

        ///// <summary>
        ///// Resets a number (sets the minimum value)
        ///// </summary>
        ///// <param name="usabledigits">Digit pool that we are generating numbers</param>
        ///// <param name="number">The number that will be resetted</param>
        ///// <param name="index">Number will be resetted after this index (index is not included)</param>
        ///// <param name="fixedIndices">Fixed indices</param>
        ///// <returns>Returns the resetted number, if the number cannot be resetted than same same number is returned</returns>
        //private int ResetNumber(List<int> usabledigits, int number, int index, Hashtable fixedIndices)
        //{
        //    int tmpnumber = number;

        //    for (int i = index + 1; i < tmpnumber.ToString().Length; i++)
        //    {
        //        // check if index is fixed or not
        //        if (!fixedIndices.Contains(i))
        //        {
        //            int min = -1;

        //            // find the min value and set it to the current index
        //            for (int j = 0; j < usabledigits.Count; j++)
        //            {
        //                if(!ContainsNumber(tmpnumber, usabledigits[j]))
        //                {
        //                    min = usabledigits[j];
        //                    break;
        //                }
        //            }

        //            // set new value
        //            tmpnumber = ChangeDigitAtIndex(tmpnumber, i, min);
        //        }
        //    }

        //    return tmpnumber;
        //}

        ///// <summary>
        ///// Gets the probable numbers, just set the minimum value and the rest will be returned
        ///// </summary>
        ///// <param name="result">List of probable numbers</param>
        ///// <param name="usabledigits">Digit pool that numbers will be generated from</param>
        ///// <param name="number">Current number</param>
        ///// <param name="index">Number index</param>
        ///// <param name="fixedIndices">Fixed indices of the current number</param>
        ///// <returns>Returns all the possible numbers according to the specified parameters</returns>
        //private void GetProbableNumbers(List<int> result, List<int> usabledigits, int number, Hashtable fixedIndices)
        //{
        //    int newNumber;

        //    // can we increase the current indexed number
        //    while (TryAndForceIncrease(usabledigits, number, fixedIndices, out newNumber))
        //    {
        //        // add it to the result
        //        result.Add(newNumber);

        //        // call it from the beginning
        //        number = newNumber;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.textBox1.Text);

            List<int> UsableDigits = new List<int>();

            UsableDigits.Add(0);
            UsableDigits.Add(1);
            UsableDigits.Add(2);
            UsableDigits.Add(3);
            UsableDigits.Add(4);
            UsableDigits.Add(5);
            UsableDigits.Add(6);
            UsableDigits.Add(7);
            UsableDigits.Add(8);
            UsableDigits.Add(9);

            List<int> result = new List<int>();

            List<int> fix = new List<int>();
            //fix.Add(0);
            //fix.Add(1);
            //fix.Add(2);
            //fix.Add(3);
            this.Probabilities.FixedIndices = fix;

            //this.Probabilities.UseSameDigits = true;

            Probabilities.UsableDigits = UsableDigits;
            result = this.Probabilities.GetProbabilities(number);

            this.listBox1.Items.Clear();
            foreach (int i in result)
                this.listBox1.Items.Add(i);

            this.label2.Text = result.Count.ToString() + "-" + this.listBox1.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.usableDigits_.Add(0);
            //this.usableDigits_.Add(1);
            //this.usableDigits_.Add(2);
            //this.usableDigits_.Add(3);
            //this.usableDigits_.Add(4);
            //this.usableDigits_.Add(5);
            //this.usableDigits_.Add(6);
            //this.usableDigits_.Add(7);
            //this.usableDigits_.Add(8);
            //this.usableDigits_.Add(9);

            //this.usableDigits_.Sort();

            ////for (int i = 1; i < 10; i++)
            ////{
            ////    for (int j = 0; j < 10; j++)
            ////    {
            ////        for (int k = 0; k < 10; k++)
            ////        {
            ////            if (i != j && i != k && j != k)
            ////                Console.WriteLine(i.ToString() + j.ToString() + k.ToString());
            ////        }
            ////    }
            ////}

            ////DynamicNestedLoop(100, 2);
            ////DynamicNestedLoop(1000, 3);
        }

        private void DynamicNestedLoop(int number, int index)
        {
            //// get the current digit
            //// sayıdan index ile belirtilmiş basamağı al
            //int currentdigit = GetDigitAtIndex(number, index);

            //// if the current digit is 9 than we have to reset the number
            //// eğer şu anki basamak 9 ise sayıyı sıfırlamamız gerekiyor
            //if (currentdigit < 9)
            //{
            //    // get the new number. for instance if the current number 1000 
            //    // and index = 3 than new number will be 1001
            //    // yeni sayıyı al, örneğin şu anki sayımız 100 ise
            //    // üretilecek yeni sayımız 1001 olacaktır
            //    int newnumber = ChangeDigitAtIndex(number, index, currentdigit + 1);

            //    Console.WriteLine(newnumber);

            //    // call the method again with the current index
            //    // metodu mevcut index ile yeniden çağır
            //    DynamicNestedLoop(newnumber, index);
            //}
            //else
            //{
            //    // if the current index greater than 0 
            //    // (it means if we are not dealing with the first digit)
            //    // eğer şu anki indeximiz 0'dan büyükse
            //    // yeni sayının ilk basamağı ile uğraşmıyorsak
            //    if (index > 0)
            //    {
            //        // get the previous digit of the number
            //        // because we will increase it
            //        // sayının bir önceki basamağını al
            //        // önceki basamağı arttıracağız çünkü
            //        int prevdigit = GetDigitAtIndex(number, index - 1);

            //        // if the previous digit is less than 9
            //        // eğer bir önceki basamağımız 9'dan küçükse
            //        if (prevdigit < 9)
            //        {
            //            // increase the previous digit
            //            // bir önceki basamağı arttır
            //            int newnumber = ChangeDigitAtIndex(number, index - 1, prevdigit + 1);

            //            int numberlength = number.ToString().Length;

            //            // reset the number to its minimum value
            //            // set every digit to zero beginning from the previous index
            //            // sayıyı bir önceki basamaktan başlayarak sıfırla
            //            // diğer basamakları sıfırla
            //            for (int i = numberlength - 1; i > index - 1; i--)
            //                newnumber = ChangeDigitAtIndex(newnumber, i, 0);

            //            Console.WriteLine(newnumber);

            //            // call method again from the beginning
            //            // metodu en başından yeniden çağır
            //            DynamicNestedLoop(newnumber, numberlength - 1);
            //        }
            //        else
            //        {
            //            // if previous digit is 9 than look for other digits
            //            // eğer bir önceki basamak 9 ise diğer basamakları kontol et
            //            DynamicNestedLoop(number, index - 1);
            //        }
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int next;
            //bool result = TryIncrease(this.usableDigits_, int.Parse(this.textBox4.Text), int.Parse(this.textBox2.Text), new Hashtable(), out next);

            //this.label1.Text = result.ToString();
            //this.textBox3.Text = next.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int number = int.Parse(this.textBox5.Text);

            //Hashtable fix = new Hashtable();

            //int index = int.Parse(this.textBox6.Text);

            //this.textBox7.Text = ResetNumber(this.usableDigits_, number, index, fix).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int newNumber;

            //ForceIncrease(usableDigits_, int.Parse(this.textBox8.Text), new Hashtable(), out newNumber);

            //this.label3.Text = newNumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Combination com = new Combination();

            this.listBox1.Items.Clear();

            int combination = int.Parse(this.textBox10.Text);

            List<string> result = com.GetCombinations(this.textBox9.Text.ToCharArray(), combination);

            foreach (string s in result)
                this.listBox1.Items.Add(s);

            this.label2.Text = this.listBox1.Items.Count.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Permutation per = new Permutation();
            
            this.listBox1.Items.Clear();

            int permutation = int.Parse(this.textBox11.Text);

            List<string> result = per.GetPermutations(this.textBox12.Text.ToCharArray(), permutation);

            foreach (string s in result)
                this.listBox1.Items.Add(s);

            this.label2.Text = this.listBox1.Items.Count.ToString();
        }
    }
}
