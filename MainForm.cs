using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Mastermind
{
    public partial class MainForm : Form
    {
        // number pool that the numbers will be created from
        private List<int> usableDigits = new List<int>();

        private List<int> tmpUsableDigits = new List<int>();

        private bool repaintPool = false;

        // length of the number
        private int numberLength = 4;

        // computer creates the number, human guesses it
        private bool computerBaseGame = true;

        // the number that is created randomly by the computer
        private int computerBasedNumber = 0;        

        // hash for storing probable numbers
        private List<int> probableNumbers = new List<int>();

        private Thread sendButtonThread;

        private Utilities mainUtils = new Utilities();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDigitPool();

            this.numberLengthCombo.SelectedIndex = 0;
        }

        private void newGuessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.computerBaseGame)
            {
                AddGuess form = new AddGuess(this.guessesListBox, this.numberLength);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (this.guessesListBox.Items.Count > 0)
                    {
                        // get last object
                        int newGuess = int.Parse(this.guessesListBox.Items[this.guessesListBox.Items.Count - 1].ToString());

                        if (newGuess - this.computerBasedNumber == 0)
                        {
                            // WIN!!!
                            MessageBox.Show("You win!");

                            ResetGame();
                        }
                        else
                        {
                            // Check correct and incorrect number counts
                            TrueFalsePair tf = new TrueFalsePair(newGuess, this.computerBasedNumber);

                            this.trueTextbox.Text = tf.CorrectCount.ToString();
                            this.falseTextbox.Text = tf.InCorrectCount.ToString();

                            this.trueFalseListBox.Items.Add(tf.CorrectCount.ToString() + "          -          " + tf.InCorrectCount.ToString());
                        }
                    }
                }
            }
        }

        private void PaintDigitPoolItems()
        {
            this.repaintPool = true;

            this.digit0CheckBox.Checked = false;
            this.digit1Check.Checked = false;
            this.digit2Check.Checked = false;
            this.digit3Check.Checked = false;
            this.digit4Check.Checked = false;
            this.digit5Check.Checked = false;
            this.digit6Check.Checked = false;
            this.digit7Check.Checked = false;
            this.digit8Check.Checked = false;
            this.digit9Check.Checked = false;

            this.InitializeDigitPool();

            foreach(int i in this.usableDigits)
            {
                switch (i)
                {
                    case 0: this.digit0CheckBox.Checked = true;
                        break;
                    case 1: this.digit1Check.Checked = true;
                        break;
                    case 2: this.digit2Check.Checked = true;
                        break;
                    case 3: this.digit3Check.Checked = true;
                        break;
                    case 4: this.digit4Check.Checked = true;
                        break;
                    case 5: this.digit5Check.Checked = true;
                        break;
                    case 6: this.digit6Check.Checked = true;
                        break;
                    case 7: this.digit7Check.Checked = true;
                        break;
                    case 8: this.digit8Check.Checked = true;
                        break;
                    case 9: this.digit9Check.Checked = true;
                        break;
                    default:
                        break;
                }
            }

            this.repaintPool = false;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.numberLength = int.Parse(this.numberLengthCombo.SelectedItem.ToString());

                if (this.computerVSHumanRadio.Checked)
                    this.computerBaseGame = false;
                else
                    this.computerBaseGame = true;

                // sort numbers
                this.usableDigits.Sort();

                if (this.computerBaseGame) // computer creates, human guesses
                {
                    // create a random number
                    this.computerBasedNumber = GenerateRandomNumber(this.numberLength);

                    this.numberTextBox.PasswordChar = '*';
                    this.numberTextBox.Text = this.computerBasedNumber.ToString();

                    this.sendInfoButton.Enabled = false;
                    this.trueTextbox.Enabled = false;
                    this.falseTextbox.Enabled = false;
                    this.newGuessToolStripMenuItem.Enabled = true;

                    this.statusStripStatusLabel.Text = "It is your turn...Guess the number!";
                }
                else // human creates, computer guesses
                {
                    this.numberTextBox.PasswordChar = '\0';

                    this.sendInfoButton.Enabled = true;
                    this.trueTextbox.Enabled = true;
                    this.falseTextbox.Enabled = true;
                    this.newGuessToolStripMenuItem.Enabled = false;

                    this.statusStripStatusLabel.Text = "Here is my first guess...Please give me some information!";

                    // make a guess and send it to the user
                    this.guessesListBox.Items.Add(GenerateRandomNumber(this.numberLength).ToString());
                }

                this.startGameButton.Enabled = false;
                this.gamePropertiesGroupBox.Enabled = false;
                this.gameActivityGroupBox.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.repaintPool)
            {
                CheckBox chk = (CheckBox)sender;

                if (chk != null)
                {
                    int number = int.Parse(chk.Text);

                    if (chk.Checked)
                    {
                        if (!this.usableDigits.Contains(number))
                            this.usableDigits.Add(number);
                    }
                    else
                    {
                        if (this.usableDigits.Count > this.numberLength)
                            this.usableDigits.Remove(number);
                        else
                        {
                            chk.Checked = true;
                            MessageBox.Show("Pool size cannot be less than the object length!");
                        }
                    }

                    this.tmpUsableDigits = this.usableDigits.ToList();
                }
            }
        }

        private void sendInfoButton_Click(object sender, EventArgs e)
        {
            //this.sendButtonThread = new Thread(new ThreadStart(this.SendButtonThreadMethod));
            //this.sendButtonThread.Start();

            this.SendButtonThreadMethod();
        }

        private void SendButtonThreadMethod()
        {
            try
            {
                this.statusStripStatusLabel.Text = "Thinking...";

                this.gameActivityGroupBox.Enabled = false;

                if (!this.computerBaseGame)
                {
                    // human creates the number, computer guesses
                    int t = int.Parse(this.trueTextbox.Text);
                    int f = int.Parse(this.falseTextbox.Text);

                    if (t == this.numberLength)
                    {
                        // WIN!!!
                        MessageBox.Show("I won!");

                        ResetGame();

                        return;
                    }

                    if (this.guessesListBox.Items.Count > 0)
                    {
                        // get last object
                        int newGuess = int.Parse(this.guessesListBox.Items[this.guessesListBox.Items.Count - 1].ToString());

                        int p = this.usableDigits.Count;
                        int n = newGuess.ToString().Length;

                        if (p - n >= n - t - f)
                        {
                            Random rnd = new Random();

                            List<int> generetedNumberPool = GenerateProbableNumbers(newGuess, t, f);

                            this.statusStripStatusLabel.Text = "Dumping results...";

                            AddList2Listbox(this.probableNumbers, this.prevProbableItemsListBox);
                            AddList2Listbox(generetedNumberPool, this.currProbableItemsListBox);

                            if (this.guessesListBox.Items.Count == 1)
                                this.probableNumbers = generetedNumberPool;
                            else
                            {
                                // re-generate global object pool
                                List<int> tmpNumberList = new List<int>();
                                foreach (int num in generetedNumberPool)
                                {
                                    if (this.probableNumbers.Contains(num))
                                        tmpNumberList.Add(num);
                                }

                                this.probableNumbers = tmpNumberList;
                            }

                            AddList2Listbox(this.probableNumbers, this.probableItemsListBox);

                            if (this.probableNumbers.Count > 0)
                            {
                                this.trueFalseListBox.Items.Add(t.ToString() + "          -          " + f.ToString());

                                this.trueTextbox.Text = "0";
                                this.falseTextbox.Text = "0";

                                this.statusStripStatusLabel.Text = probableNumbers.Count.ToString() + " number(s) found...";

                                if (this.probableNumbers.Count > 1)
                                {
                                    // select a random number from the pool
                                    this.guessesListBox.Items.Add(this.probableNumbers[rnd.Next(0, this.probableNumbers.Count - 1)]);
                                }
                                else
                                {
                                    // one possible result is returned so pick it up
                                    this.guessesListBox.Items.Add(this.probableNumbers[0]);

                                    MessageBox.Show("One possible solution found! I won!\r\nYour number is : " + this.probableNumbers[0].ToString());

                                    this.ResetGame();
                                }
                            }
                            else
                            {
                                MessageBox.Show("You must have made some mistake! I can not find the number! Sorry!\r\nGame will be resetted now! Please try again!");
                            }
                        }
                        else
                            MessageBox.Show("This is not possible! Please try again!");
                    }
                }

                this.gameActivityGroupBox.Enabled = true;

                PaintDigitPoolItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddList2Listbox(List<int> list, ListBox box)
        {
            if (list.Count > 0)
            {
                box.Items.Clear();

                foreach (int i in list)
                    box.Items.Add(i);

                if (box.Equals(this.probableItemsListBox))
                    this.resultCountLabel.Text = this.probableItemsListBox.Items.Count.ToString();
                else if (box.Equals(this.prevProbableItemsListBox))
                    this.previousCountLabel.Text = this.prevProbableItemsListBox.Items.Count.ToString();
                else if (box.Equals(this.currProbableItemsListBox))
                    this.currentCountLabel.Text = this.currProbableItemsListBox.Items.Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test form = new Test();

            form.ShowDialog();
        }

        /// <summary>
        /// Finds the probable numbers according to the specified params
        /// </summary>
        /// <param name="newGuess">Base number</param>
        /// <param name="t">Correct digit count</param>
        /// <param name="f">Incorrect digit count</param>
        /// <returns></returns>
        private List<int> GenerateProbableNumbers(int newGuess, int t, int f)
        {
            List<int> result = new List<int>();

            char[] numberCharArray = newGuess.ToString().ToCharArray();

            if (t == 0 && f == 0)
            {
                Probabilities probabilities = new Probabilities();

                // so we found nothing, remove all the guessed numbers from the digit pool
                foreach (char digit in numberCharArray)
                    this.usableDigits.Remove(int.Parse(digit.ToString()));

                probabilities.UsableDigits = this.usableDigits;

                // make a new guess
                result = probabilities.GetPossibleNumbersFromDigits(numberCharArray.Length);
            }
            else
            {
                ProbabilitiesHash probabilitiesHash = new ProbabilitiesHash();

                // get true combinations
                Combination com1 = new Combination();
                List<string> combinations1 = new List<string>();

                if (t == 0)
                    combinations1.Add("");
                else
                    combinations1 = com1.GetCombinations(numberCharArray, t);

                foreach (string combination1 in combinations1)
                {
                    if (f > 0)
                    {
                        Combination com2 = new Combination();
                        com2.ReturnIndices = false;

                        char[] falseIndexArray = GetOtherIndices(combination1, newGuess.ToString().Length);

                        // get false combinations
                        List<string> combinations2 = com2.GetCombinations(falseIndexArray, f);
                        foreach (string combination2 in combinations2)
                        {
                            Permutation per = new Permutation();
                            per.ReturnIndices = false;

                            // get false permutations
                            List<string> permutations = per.GetPermutations(falseIndexArray, f);
                            foreach (string permutation in permutations)
                            {
                                bool add2result = true;
                                for (int i = 0; i < combination2.Length; i++)
                                {
                                    if (combination2[i] == permutation[i])
                                    {
                                        add2result = false;
                                        break;
                                    }
                                }

                                if (add2result)
                                {
                                    // add the number
                                    bool addCurrentNumber = true;
                                    int newNumber = newGuess;
                                    for (int i = 0; i < combination2.Length; i++)
                                    {
                                        int comDigit = mainUtils.GetDigitAtIndex(newGuess, int.Parse(combination2[i].ToString()));
                                        int perIndex = int.Parse(permutation[i].ToString());

                                        if (comDigit == 0 && perIndex == 0)
                                        {
                                            addCurrentNumber = false;
                                            break;
                                        }

                                        newNumber = mainUtils.ChangeDigitAtIndex(newNumber, perIndex, comDigit);
                                    }

                                    if (addCurrentNumber)
                                    {
                                        // add fixed indices
                                        probabilitiesHash.Indices.Add(combination1 + permutation);

                                        // add number
                                        probabilitiesHash.Numbers.Add(newNumber);

                                        char[] otherIndexArray = GetOtherIndices("", newGuess.ToString().Length);

                                        List<int> digitPool = this.usableDigits.ToList();

                                        for (int i = 0; i < otherIndexArray.Length; i++)
                                        {
                                            int currentIndex = int.Parse(otherIndexArray[i].ToString());
                                            int currentDigit = mainUtils.GetDigitAtIndex(newGuess, currentIndex);

                                            if (digitPool.Contains(currentDigit))
                                                digitPool.Remove(currentDigit);
                                        }

                                        // add digit pool
                                        probabilitiesHash.DigitPools.Add(digitPool);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        probabilitiesHash.Indices.Add(combination1);
                        probabilitiesHash.Numbers.Add(newGuess);

                        char[] otherIndexArray = GetOtherIndices("", newGuess.ToString().Length);

                        List<int> digitPool = this.usableDigits.ToList();

                        for (int i = 0; i < otherIndexArray.Length; i++)
                        {
                            int currentIndex = int.Parse(otherIndexArray[i].ToString());
                            int currentDigit = mainUtils.GetDigitAtIndex(newGuess, currentIndex);

                            if (digitPool.Contains(currentDigit))
                                digitPool.Remove(currentDigit);
                        }

                        probabilitiesHash.DigitPools.Add(digitPool);
                    }
                }

                this.generatorProgressBar.Minimum = 0;
                this.generatorProgressBar.Maximum = probabilitiesHash.Indices.Count;

                this.statusStripStatusLabel.Text = "Generating possible numbers...";

                // Generate probable numbers
                for (int k = 0; k < probabilitiesHash.Indices.Count; k++)
                {
                    Probabilities probabilities = new Probabilities();

                    // set correct and incorrect values
                    probabilities.Correct = t;
                    probabilities.InCorrect = f;

                    // set usable digits
                    probabilities.UsableDigits = probabilitiesHash.DigitPools[k];

                    // set fixed indices
                    foreach (char digit in probabilitiesHash.Indices[k])
                        probabilities.FixedIndices.Add(int.Parse(digit.ToString()));

                    // get probabilities
                    List<int> tmpResult = probabilities.GetProbabilities(probabilitiesHash.Numbers[k]);
                    foreach (int number in tmpResult)
                    {
                        if (!result.Contains(number))
                            result.Add(number);
                    }

                    this.generatorProgressBar.Value += 1;
                }

                this.generatorProgressBar.Value = 0;
            }

            return result;
        }

        private char[] GetOtherIndices(string selectedindices, int numberlength)
        {
            string result = "";

            for (int i = 0; i < numberlength;i++ )
            {
                bool add2result = true;
                foreach (char c2 in selectedindices)
                {
                    if (c2.ToString() == i.ToString())
                        add2result = false;
                }

                if (add2result)
                    result += i.ToString();
            }

            return result.Trim().ToCharArray();
        }

        /// <summary>
        /// Resets the game to its starting position
        /// </summary>
        private void ResetGame()
        {
            this.startGameButton.Enabled = true;
            this.gamePropertiesGroupBox.Enabled = true;
            this.gameActivityGroupBox.Enabled = false;

            this.probableItemsListBox.Items.Clear();
            this.prevProbableItemsListBox.Items.Clear();
            this.currProbableItemsListBox.Items.Clear();

            this.numberTextBox.Text = "";

            this.trueTextbox.Text = "0";
            this.falseTextbox.Text = "0";

            this.trueFalseListBox.Items.Clear();
            this.guessesListBox.Items.Clear();

            this.probableNumbers.Clear();
            this.tmpUsableDigits.Clear();

            this.InitializeDigitPool();
            this.PaintDigitPoolItems();

            this.statusStripStatusLabel.Text = "Ready...";
        }

        /// <summary>
        /// Gets a random number.
        /// </summary>
        /// <param name="isfirst">If it is the first digit then ignore zero.</param>
        /// <returns>Random number</returns>
        private int GetRandomNumber(bool isfirst)
        {
            Random rnd = new Random();

            // Get pool count
            int poolCount = this.usableDigits.Count;

            int index = rnd.Next(0, poolCount);

            int r = int.Parse(this.usableDigits[index].ToString());

            if (isfirst && r == 0)
                r = GetRandomNumber(isfirst);

            return r;
        }

        /// <summary>
        /// Generates a random number with the specified length.
        /// </summary>
        /// <param name="length">The length of the number.</param>
        /// <returns>Randomly created number, if nothing is created then -1 returned.</returns>
        private int GenerateRandomNumber(int length)
        {
            StringBuilder tmp = new StringBuilder();

            Hashtable hash = new Hashtable();

            if (this.usableDigits.Count > length)
            {
                for (int i = 0; i < length; i++)
                {
                    int r = GetRandomNumber(i == 0);

                    while (hash.Contains(r))
                        r = GetRandomNumber(i == 0);

                    hash.Add(r, 0);
                    tmp.Append(r.ToString());
                }
            }

            if (tmp.Length > 0)
                return int.Parse(tmp.ToString());
            else
                return -1;
        }

        /// <summary>
        /// Initialize the object pool item. Objects will be created according to this item pool.
        /// </summary>
        private void InitializeDigitPool()
        {
            if (this.tmpUsableDigits.Count == 0)
            {
                this.usableDigits.Add(0);
                this.usableDigits.Add(1);
                this.usableDigits.Add(2);
                this.usableDigits.Add(3);
                this.usableDigits.Add(4);
                this.usableDigits.Add(5);
                this.usableDigits.Add(6);
                this.usableDigits.Add(7);
                this.usableDigits.Add(8);
                this.usableDigits.Add(9);

                this.tmpUsableDigits = this.usableDigits.ToList();
            }
            else
                this.usableDigits = this.tmpUsableDigits.ToList();
        }

        private void numberLengthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.numberLength = this.numberTextBox.MaxLength = int.Parse(this.numberLengthCombo.SelectedItem.ToString());
            }
            catch
            {
                // NOP
            }
        }
    }
    
    /// <summary>
    /// Represents the correct and incorrect items in an object
    /// </summary>
    public class TrueFalsePair
    {
        int number1, number2;
        int t = 0;
        int f = 0;

        public TrueFalsePair(int num1, int num2)
        {
            // reset
            t = 0;
            f = 0;

            this.number1 = num1;
            this.number2 = num2;

            this.CheckDigits();
        }

        private void CheckDigits()
        {
            string num1 = this.number1.ToString();
            string num2 = this.number2.ToString();

            if (num1.Length != num2.Length)
                return;

            // check numbers
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == num2[i])
                    this.t++;
                else
                {
                    int k = num2.IndexOf(num1[i]);
                    if (k != -1 && k != i)
                        this.f++;
                }
            }
        }

        public int CorrectCount
        {
            get
            {
                return t;
            }
        }

        public int InCorrectCount
        {
            get
            {
                return f;
            }
        }
    }
}
