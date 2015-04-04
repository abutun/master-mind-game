using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mastermind
{
    public partial class AddGuess : Form
    {
        private ListBox box = null;

        public AddGuess(ListBox lst, int maxlen)
        {
            InitializeComponent();

            this.box = lst;
            this.textBox1.MaxLength = maxlen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text != "")
                {
                    if (this.textBox1.Text.Length == this.textBox1.MaxLength)
                    {
                        if (this.box != null)
                            this.box.Items.Add(this.textBox1.Text);

                        this.DialogResult = DialogResult.OK;

                        this.Close();
                    }
                    else
                        MessageBox.Show("Number length must be " + this.textBox1.MaxLength.ToString());
                }
                else
                    MessageBox.Show("Enter number!");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
