namespace Mastermind
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.gameActivityGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trueFalseListBox = new System.Windows.Forms.ListBox();
            this.newGuessContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGuessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guessesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendInfoButton = new System.Windows.Forms.Button();
            this.trueTextbox = new System.Windows.Forms.TextBox();
            this.falseTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gamePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.numberLengthCombo = new System.Windows.Forms.ComboBox();
            this.digit8Check = new System.Windows.Forms.CheckBox();
            this.digit9Check = new System.Windows.Forms.CheckBox();
            this.digit4Check = new System.Windows.Forms.CheckBox();
            this.digit5Check = new System.Windows.Forms.CheckBox();
            this.digit6Check = new System.Windows.Forms.CheckBox();
            this.digit7Check = new System.Windows.Forms.CheckBox();
            this.digit3Check = new System.Windows.Forms.CheckBox();
            this.digit2Check = new System.Windows.Forms.CheckBox();
            this.digit1Check = new System.Windows.Forms.CheckBox();
            this.digit0CheckBox = new System.Windows.Forms.CheckBox();
            this.HumanVSComRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computerVSHumanRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentCountLabel = new System.Windows.Forms.Label();
            this.previousCountLabel = new System.Windows.Forms.Label();
            this.resultCountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.generatorProgressBar = new System.Windows.Forms.ProgressBar();
            this.currProbableItemsListBox = new System.Windows.Forms.ListBox();
            this.prevProbableItemsListBox = new System.Windows.Forms.ListBox();
            this.probableItemsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gameActivityGroupBox.SuspendLayout();
            this.newGuessContextMenu.SuspendLayout();
            this.gamePropertiesGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.gameActivityGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.gamePropertiesGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.startGameButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 524);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameActivityGroupBox
            // 
            this.gameActivityGroupBox.Controls.Add(this.label8);
            this.gameActivityGroupBox.Controls.Add(this.label7);
            this.gameActivityGroupBox.Controls.Add(this.trueFalseListBox);
            this.gameActivityGroupBox.Controls.Add(this.guessesListBox);
            this.gameActivityGroupBox.Controls.Add(this.label4);
            this.gameActivityGroupBox.Controls.Add(this.label5);
            this.gameActivityGroupBox.Controls.Add(this.sendInfoButton);
            this.gameActivityGroupBox.Controls.Add(this.trueTextbox);
            this.gameActivityGroupBox.Controls.Add(this.falseTextbox);
            this.gameActivityGroupBox.Controls.Add(this.label6);
            this.gameActivityGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gameActivityGroupBox.Enabled = false;
            this.gameActivityGroupBox.Location = new System.Drawing.Point(0, 231);
            this.gameActivityGroupBox.Name = "gameActivityGroupBox";
            this.gameActivityGroupBox.Size = new System.Drawing.Size(262, 293);
            this.gameActivityGroupBox.TabIndex = 17;
            this.gameActivityGroupBox.TabStop = false;
            this.gameActivityGroupBox.Text = "Game Activity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "False";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "True";
            // 
            // trueFalseListBox
            // 
            this.trueFalseListBox.ContextMenuStrip = this.newGuessContextMenu;
            this.trueFalseListBox.FormattingEnabled = true;
            this.trueFalseListBox.Location = new System.Drawing.Point(158, 38);
            this.trueFalseListBox.Name = "trueFalseListBox";
            this.trueFalseListBox.Size = new System.Drawing.Size(88, 186);
            this.trueFalseListBox.TabIndex = 14;
            // 
            // newGuessContextMenu
            // 
            this.newGuessContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGuessToolStripMenuItem});
            this.newGuessContextMenu.Name = "contextMenuStrip1";
            this.newGuessContextMenu.Size = new System.Drawing.Size(133, 26);
            // 
            // newGuessToolStripMenuItem
            // 
            this.newGuessToolStripMenuItem.Name = "newGuessToolStripMenuItem";
            this.newGuessToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGuessToolStripMenuItem.Text = "New Guess";
            this.newGuessToolStripMenuItem.Click += new System.EventHandler(this.newGuessToolStripMenuItem_Click);
            // 
            // guessesListBox
            // 
            this.guessesListBox.ContextMenuStrip = this.newGuessContextMenu;
            this.guessesListBox.FormattingEnabled = true;
            this.guessesListBox.Location = new System.Drawing.Point(14, 39);
            this.guessesListBox.Name = "guessesListBox";
            this.guessesListBox.Size = new System.Drawing.Size(138, 186);
            this.guessesListBox.TabIndex = 6;
            this.guessesListBox.DoubleClick += new System.EventHandler(this.newGuessToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Guess";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "True";
            // 
            // sendInfoButton
            // 
            this.sendInfoButton.Location = new System.Drawing.Point(94, 230);
            this.sendInfoButton.Name = "sendInfoButton";
            this.sendInfoButton.Size = new System.Drawing.Size(152, 45);
            this.sendInfoButton.TabIndex = 12;
            this.sendInfoButton.Text = "Send Information";
            this.sendInfoButton.UseVisualStyleBackColor = true;
            this.sendInfoButton.Click += new System.EventHandler(this.sendInfoButton_Click);
            // 
            // trueTextbox
            // 
            this.trueTextbox.Location = new System.Drawing.Point(65, 230);
            this.trueTextbox.MaxLength = 1;
            this.trueTextbox.Name = "trueTextbox";
            this.trueTextbox.Size = new System.Drawing.Size(23, 20);
            this.trueTextbox.TabIndex = 9;
            this.trueTextbox.Text = "0";
            this.trueTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // falseTextbox
            // 
            this.falseTextbox.Location = new System.Drawing.Point(65, 255);
            this.falseTextbox.MaxLength = 1;
            this.falseTextbox.Name = "falseTextbox";
            this.falseTextbox.Size = new System.Drawing.Size(23, 20);
            this.falseTextbox.TabIndex = 11;
            this.falseTextbox.Text = "0";
            this.falseTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "False";
            // 
            // gamePropertiesGroupBox
            // 
            this.gamePropertiesGroupBox.Controls.Add(this.numberLengthCombo);
            this.gamePropertiesGroupBox.Controls.Add(this.digit8Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit9Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit4Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit5Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit6Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit7Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit3Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit2Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit1Check);
            this.gamePropertiesGroupBox.Controls.Add(this.digit0CheckBox);
            this.gamePropertiesGroupBox.Controls.Add(this.HumanVSComRadio);
            this.gamePropertiesGroupBox.Controls.Add(this.label1);
            this.gamePropertiesGroupBox.Controls.Add(this.label2);
            this.gamePropertiesGroupBox.Controls.Add(this.computerVSHumanRadio);
            this.gamePropertiesGroupBox.Controls.Add(this.label3);
            this.gamePropertiesGroupBox.Controls.Add(this.numberTextBox);
            this.gamePropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamePropertiesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.gamePropertiesGroupBox.Name = "gamePropertiesGroupBox";
            this.gamePropertiesGroupBox.Size = new System.Drawing.Size(262, 182);
            this.gamePropertiesGroupBox.TabIndex = 16;
            this.gamePropertiesGroupBox.TabStop = false;
            this.gamePropertiesGroupBox.Text = "Game Properties";
            // 
            // numberLengthCombo
            // 
            this.numberLengthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberLengthCombo.FormattingEnabled = true;
            this.numberLengthCombo.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.numberLengthCombo.Location = new System.Drawing.Point(62, 115);
            this.numberLengthCombo.Name = "numberLengthCombo";
            this.numberLengthCombo.Size = new System.Drawing.Size(48, 21);
            this.numberLengthCombo.TabIndex = 26;
            this.numberLengthCombo.SelectedIndexChanged += new System.EventHandler(this.numberLengthCombo_SelectedIndexChanged);
            // 
            // digit8Check
            // 
            this.digit8Check.AutoSize = true;
            this.digit8Check.Checked = true;
            this.digit8Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit8Check.Location = new System.Drawing.Point(18, 83);
            this.digit8Check.Name = "digit8Check";
            this.digit8Check.Size = new System.Drawing.Size(32, 17);
            this.digit8Check.TabIndex = 25;
            this.digit8Check.Text = "8";
            this.digit8Check.UseVisualStyleBackColor = true;
            this.digit8Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit9Check
            // 
            this.digit9Check.AutoSize = true;
            this.digit9Check.Checked = true;
            this.digit9Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit9Check.Location = new System.Drawing.Point(78, 83);
            this.digit9Check.Name = "digit9Check";
            this.digit9Check.Size = new System.Drawing.Size(32, 17);
            this.digit9Check.TabIndex = 24;
            this.digit9Check.Text = "9";
            this.digit9Check.UseVisualStyleBackColor = true;
            this.digit9Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit4Check
            // 
            this.digit4Check.AutoSize = true;
            this.digit4Check.Checked = true;
            this.digit4Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit4Check.Location = new System.Drawing.Point(18, 60);
            this.digit4Check.Name = "digit4Check";
            this.digit4Check.Size = new System.Drawing.Size(32, 17);
            this.digit4Check.TabIndex = 23;
            this.digit4Check.Text = "4";
            this.digit4Check.UseVisualStyleBackColor = true;
            this.digit4Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit5Check
            // 
            this.digit5Check.AutoSize = true;
            this.digit5Check.Checked = true;
            this.digit5Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit5Check.Location = new System.Drawing.Point(78, 60);
            this.digit5Check.Name = "digit5Check";
            this.digit5Check.Size = new System.Drawing.Size(32, 17);
            this.digit5Check.TabIndex = 22;
            this.digit5Check.Text = "5";
            this.digit5Check.UseVisualStyleBackColor = true;
            this.digit5Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit6Check
            // 
            this.digit6Check.AutoSize = true;
            this.digit6Check.Checked = true;
            this.digit6Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit6Check.Location = new System.Drawing.Point(146, 60);
            this.digit6Check.Name = "digit6Check";
            this.digit6Check.Size = new System.Drawing.Size(32, 17);
            this.digit6Check.TabIndex = 21;
            this.digit6Check.Text = "6";
            this.digit6Check.UseVisualStyleBackColor = true;
            this.digit6Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit7Check
            // 
            this.digit7Check.AutoSize = true;
            this.digit7Check.Checked = true;
            this.digit7Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit7Check.Location = new System.Drawing.Point(214, 60);
            this.digit7Check.Name = "digit7Check";
            this.digit7Check.Size = new System.Drawing.Size(32, 17);
            this.digit7Check.TabIndex = 20;
            this.digit7Check.Text = "7";
            this.digit7Check.UseVisualStyleBackColor = true;
            this.digit7Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit3Check
            // 
            this.digit3Check.AutoSize = true;
            this.digit3Check.Checked = true;
            this.digit3Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit3Check.Location = new System.Drawing.Point(214, 37);
            this.digit3Check.Name = "digit3Check";
            this.digit3Check.Size = new System.Drawing.Size(32, 17);
            this.digit3Check.TabIndex = 19;
            this.digit3Check.Text = "3";
            this.digit3Check.UseVisualStyleBackColor = true;
            this.digit3Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit2Check
            // 
            this.digit2Check.AutoSize = true;
            this.digit2Check.Checked = true;
            this.digit2Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit2Check.Location = new System.Drawing.Point(146, 37);
            this.digit2Check.Name = "digit2Check";
            this.digit2Check.Size = new System.Drawing.Size(32, 17);
            this.digit2Check.TabIndex = 18;
            this.digit2Check.Text = "2";
            this.digit2Check.UseVisualStyleBackColor = true;
            this.digit2Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit1Check
            // 
            this.digit1Check.AutoSize = true;
            this.digit1Check.Checked = true;
            this.digit1Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit1Check.Location = new System.Drawing.Point(78, 37);
            this.digit1Check.Name = "digit1Check";
            this.digit1Check.Size = new System.Drawing.Size(32, 17);
            this.digit1Check.TabIndex = 17;
            this.digit1Check.Text = "1";
            this.digit1Check.UseVisualStyleBackColor = true;
            this.digit1Check.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // digit0CheckBox
            // 
            this.digit0CheckBox.AutoSize = true;
            this.digit0CheckBox.Checked = true;
            this.digit0CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digit0CheckBox.Location = new System.Drawing.Point(18, 37);
            this.digit0CheckBox.Name = "digit0CheckBox";
            this.digit0CheckBox.Size = new System.Drawing.Size(32, 17);
            this.digit0CheckBox.TabIndex = 16;
            this.digit0CheckBox.Text = "0";
            this.digit0CheckBox.UseVisualStyleBackColor = true;
            this.digit0CheckBox.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // HumanVSComRadio
            // 
            this.HumanVSComRadio.AutoSize = true;
            this.HumanVSComRadio.Checked = true;
            this.HumanVSComRadio.Location = new System.Drawing.Point(134, 155);
            this.HumanVSComRadio.Name = "HumanVSComRadio";
            this.HumanVSComRadio.Size = new System.Drawing.Size(94, 17);
            this.HumanVSComRadio.TabIndex = 15;
            this.HumanVSComRadio.TabStop = true;
            this.HumanVSComRadio.Text = "Hum. Guesses";
            this.HumanVSComRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pool";
            // 
            // computerVSHumanRadio
            // 
            this.computerVSHumanRadio.AutoSize = true;
            this.computerVSHumanRadio.Location = new System.Drawing.Point(31, 155);
            this.computerVSHumanRadio.Name = "computerVSHumanRadio";
            this.computerVSHumanRadio.Size = new System.Drawing.Size(93, 17);
            this.computerVSHumanRadio.TabIndex = 14;
            this.computerVSHumanRadio.Text = "Com. Guesses";
            this.computerVSHumanRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(166, 115);
            this.numberTextBox.MaxLength = 4;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(83, 20);
            this.numberTextBox.TabIndex = 5;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(23, 189);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(217, 37);
            this.startGameButton.TabIndex = 13;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentCountLabel);
            this.groupBox1.Controls.Add(this.previousCountLabel);
            this.groupBox1.Controls.Add(this.resultCountLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.generatorProgressBar);
            this.groupBox1.Controls.Add(this.currProbableItemsListBox);
            this.groupBox1.Controls.Add(this.prevProbableItemsListBox);
            this.groupBox1.Controls.Add(this.probableItemsListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // currentCountLabel
            // 
            this.currentCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentCountLabel.Location = new System.Drawing.Point(461, 16);
            this.currentCountLabel.Name = "currentCountLabel";
            this.currentCountLabel.Size = new System.Drawing.Size(56, 13);
            this.currentCountLabel.TabIndex = 9;
            this.currentCountLabel.Text = "0";
            this.currentCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // previousCountLabel
            // 
            this.previousCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.previousCountLabel.Location = new System.Drawing.Point(298, 16);
            this.previousCountLabel.Name = "previousCountLabel";
            this.previousCountLabel.Size = new System.Drawing.Size(56, 13);
            this.previousCountLabel.TabIndex = 8;
            this.previousCountLabel.Text = "0";
            this.previousCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resultCountLabel
            // 
            this.resultCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultCountLabel.Location = new System.Drawing.Point(123, 16);
            this.resultCountLabel.Name = "resultCountLabel";
            this.resultCountLabel.Size = new System.Drawing.Size(56, 13);
            this.resultCountLabel.TabIndex = 7;
            this.resultCountLabel.Text = "0";
            this.resultCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(357, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "CURRENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(182, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "PREVIOUS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "RESULT";
            // 
            // generatorProgressBar
            // 
            this.generatorProgressBar.Location = new System.Drawing.Point(7, 495);
            this.generatorProgressBar.Name = "generatorProgressBar";
            this.generatorProgressBar.Size = new System.Drawing.Size(510, 23);
            this.generatorProgressBar.TabIndex = 3;
            // 
            // currProbableItemsListBox
            // 
            this.currProbableItemsListBox.FormattingEnabled = true;
            this.currProbableItemsListBox.Location = new System.Drawing.Point(360, 32);
            this.currProbableItemsListBox.Name = "currProbableItemsListBox";
            this.currProbableItemsListBox.Size = new System.Drawing.Size(157, 459);
            this.currProbableItemsListBox.TabIndex = 2;
            // 
            // prevProbableItemsListBox
            // 
            this.prevProbableItemsListBox.FormattingEnabled = true;
            this.prevProbableItemsListBox.Location = new System.Drawing.Point(185, 32);
            this.prevProbableItemsListBox.Name = "prevProbableItemsListBox";
            this.prevProbableItemsListBox.Size = new System.Drawing.Size(169, 459);
            this.prevProbableItemsListBox.TabIndex = 1;
            // 
            // probableItemsListBox
            // 
            this.probableItemsListBox.FormattingEnabled = true;
            this.probableItemsListBox.Location = new System.Drawing.Point(5, 32);
            this.probableItemsListBox.Name = "probableItemsListBox";
            this.probableItemsListBox.Size = new System.Drawing.Size(174, 459);
            this.probableItemsListBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 524);
            this.panel1.TabIndex = 1;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 531);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(792, 22);
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusStripStatusLabel
            // 
            this.statusStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusStripStatusLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.statusStripStatusLabel.Name = "statusStripStatusLabel";
            this.statusStripStatusLabel.Size = new System.Drawing.Size(52, 17);
            this.statusStripStatusLabel.Text = "Ready...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 553);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "www.bilgisayarkorsani.com";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gameActivityGroupBox.ResumeLayout(false);
            this.gameActivityGroupBox.PerformLayout();
            this.newGuessContextMenu.ResumeLayout(false);
            this.gamePropertiesGroupBox.ResumeLayout(false);
            this.gamePropertiesGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox guessesListBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendInfoButton;
        private System.Windows.Forms.TextBox falseTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trueTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.RadioButton HumanVSComRadio;
        private System.Windows.Forms.RadioButton computerVSHumanRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gamePropertiesGroupBox;
        private System.Windows.Forms.GroupBox gameActivityGroupBox;
        private System.Windows.Forms.ContextMenuStrip newGuessContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newGuessToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.CheckBox digit8Check;
        private System.Windows.Forms.CheckBox digit9Check;
        private System.Windows.Forms.CheckBox digit4Check;
        private System.Windows.Forms.CheckBox digit5Check;
        private System.Windows.Forms.CheckBox digit6Check;
        private System.Windows.Forms.CheckBox digit7Check;
        private System.Windows.Forms.CheckBox digit3Check;
        private System.Windows.Forms.CheckBox digit2Check;
        private System.Windows.Forms.CheckBox digit1Check;
        private System.Windows.Forms.CheckBox digit0CheckBox;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel;
        private System.Windows.Forms.ListBox trueFalseListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox currProbableItemsListBox;
        private System.Windows.Forms.ListBox prevProbableItemsListBox;
        private System.Windows.Forms.ListBox probableItemsListBox;
        private System.Windows.Forms.ProgressBar generatorProgressBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox numberLengthCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label currentCountLabel;
        private System.Windows.Forms.Label previousCountLabel;
        private System.Windows.Forms.Label resultCountLabel;
    }
}

