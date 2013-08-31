namespace WindowsApplication1
{
    partial class NewWordlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWordlist));
            this.SelectTest = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.flipwords = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Radiobuttopnmulchoice = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.LearnWordList = new System.Windows.Forms.RadioButton();
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBoxLearnWordList = new System.Windows.Forms.GroupBox();
            this.labelLearnWordListStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonLeanWordBack = new System.Windows.Forms.Button();
            this.buttonLearnWordNext = new System.Windows.Forms.Button();
            this.labelLearnWord = new System.Windows.Forms.Label();
            this.groupBoxReverseChallenge = new System.Windows.Forms.GroupBox();
            this.TEXTFORREVCOUNTER = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelReveseChallangeStatus = new System.Windows.Forms.Label();
            this.label3ReversechoiceResult = new System.Windows.Forms.Label();
            this.labelRevereChallengeWord = new System.Windows.Forms.Label();
            this.buttonReverseChallanageNext = new System.Windows.Forms.Button();
            this.reversechoiceoption1 = new System.Windows.Forms.RadioButton();
            this.labelReverseChoice = new System.Windows.Forms.Label();
            this.reversechoiceoption2 = new System.Windows.Forms.RadioButton();
            this.reversechoiceoption5 = new System.Windows.Forms.RadioButton();
            this.reversechoiceoption3 = new System.Windows.Forms.RadioButton();
            this.reversechoiceoption4 = new System.Windows.Forms.RadioButton();
            this.labelMultipleChoiceQuestion = new System.Windows.Forms.Label();
            this.mulChoice1 = new System.Windows.Forms.RadioButton();
            this.mulChoice2 = new System.Windows.Forms.RadioButton();
            this.mulChoice3 = new System.Windows.Forms.RadioButton();
            this.mulChoice4 = new System.Windows.Forms.RadioButton();
            this.mulChoice5 = new System.Windows.Forms.RadioButton();
            this.labelMulchoiceResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMultipleChoice = new System.Windows.Forms.GroupBox();
            this.labelrevtimercounter = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.LabelMulQuesStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SelectTest.SuspendLayout();
            this.groupBoxLearnWordList.SuspendLayout();
            this.groupBoxReverseChallenge.SuspendLayout();
            this.groupBoxMultipleChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectTest
            // 
            this.SelectTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectTest.BackgroundImage = global::WindowsApplication1.Properties.Resources.back_copy;
            this.SelectTest.Controls.Add(this.radioButton2);
            this.SelectTest.Controls.Add(this.flipwords);
            this.SelectTest.Controls.Add(this.radioButton1);
            this.SelectTest.Controls.Add(this.Radiobuttopnmulchoice);
            this.SelectTest.Controls.Add(this.radioButton4);
            this.SelectTest.Controls.Add(this.LearnWordList);
            this.SelectTest.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTest.Location = new System.Drawing.Point(220, 75);
            this.SelectTest.Name = "SelectTest";
            this.SelectTest.Size = new System.Drawing.Size(387, 185);
            this.SelectTest.TabIndex = 0;
            this.SelectTest.TabStop = false;
            this.SelectTest.Text = "Select Test";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.radioButton2.Location = new System.Drawing.Point(40, 148);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 26);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Change Word List";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // flipwords
            // 
            this.flipwords.AutoSize = true;
            this.flipwords.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.flipwords.Location = new System.Drawing.Point(40, 127);
            this.flipwords.Name = "flipwords";
            this.flipwords.Size = new System.Drawing.Size(107, 26);
            this.flipwords.TabIndex = 6;
            this.flipwords.Text = "Flip Words";
            this.flipwords.UseVisualStyleBackColor = true;
            this.flipwords.CheckedChanged += new System.EventHandler(this.flipwords_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.radioButton1.Location = new System.Drawing.Point(40, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 26);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Words Jam";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Radiobuttopnmulchoice
            // 
            this.Radiobuttopnmulchoice.AutoSize = true;
            this.Radiobuttopnmulchoice.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.Radiobuttopnmulchoice.Location = new System.Drawing.Point(41, 55);
            this.Radiobuttopnmulchoice.Name = "Radiobuttopnmulchoice";
            this.Radiobuttopnmulchoice.Size = new System.Drawing.Size(143, 26);
            this.Radiobuttopnmulchoice.TabIndex = 4;
            this.Radiobuttopnmulchoice.Text = "Multiple Choice";
            this.Radiobuttopnmulchoice.UseVisualStyleBackColor = true;
            this.Radiobuttopnmulchoice.CheckedChanged += new System.EventHandler(this.Radiobuttopnmulchoice_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.radioButton4.Location = new System.Drawing.Point(40, 81);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(155, 26);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Reverse Challage";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // LearnWordList
            // 
            this.LearnWordList.AutoSize = true;
            this.LearnWordList.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.LearnWordList.Location = new System.Drawing.Point(40, 33);
            this.LearnWordList.Name = "LearnWordList";
            this.LearnWordList.Size = new System.Drawing.Size(148, 26);
            this.LearnWordList.TabIndex = 0;
            this.LearnWordList.Text = "Learn Word List";
            this.LearnWordList.UseVisualStyleBackColor = true;
            this.LearnWordList.CheckedChanged += new System.EventHandler(this.LearnWordList_CheckedChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(194, 41);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(67, 23);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "label1";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // groupBoxLearnWordList
            // 
            this.groupBoxLearnWordList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxLearnWordList.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.groupBoxLearnWordList.Controls.Add(this.labelLearnWordListStatus);
            this.groupBoxLearnWordList.Controls.Add(this.label2);
            this.groupBoxLearnWordList.Controls.Add(this.richTextBox1);
            this.groupBoxLearnWordList.Controls.Add(this.buttonLeanWordBack);
            this.groupBoxLearnWordList.Controls.Add(this.buttonLearnWordNext);
            this.groupBoxLearnWordList.Controls.Add(this.labelLearnWord);
            this.groupBoxLearnWordList.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLearnWordList.Location = new System.Drawing.Point(48, 343);
            this.groupBoxLearnWordList.Name = "groupBoxLearnWordList";
            this.groupBoxLearnWordList.Size = new System.Drawing.Size(504, 176);
            this.groupBoxLearnWordList.TabIndex = 3;
            this.groupBoxLearnWordList.TabStop = false;
            this.groupBoxLearnWordList.Text = "Learn Word List";
            // 
            // labelLearnWordListStatus
            // 
            this.labelLearnWordListStatus.AutoSize = true;
            this.labelLearnWordListStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelLearnWordListStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLearnWordListStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelLearnWordListStatus.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelLearnWordListStatus.Location = new System.Drawing.Point(227, 30);
            this.labelLearnWordListStatus.Name = "labelLearnWordListStatus";
            this.labelLearnWordListStatus.Size = new System.Drawing.Size(54, 19);
            this.labelLearnWordListStatus.TabIndex = 16;
            this.labelLearnWordListStatus.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Meaning";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox1.Location = new System.Drawing.Point(88, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(363, 36);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // buttonLeanWordBack
            // 
            this.buttonLeanWordBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeanWordBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeanWordBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeanWordBack.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.buttonLeanWordBack.Location = new System.Drawing.Point(24, 115);
            this.buttonLeanWordBack.Name = "buttonLeanWordBack";
            this.buttonLeanWordBack.Size = new System.Drawing.Size(75, 25);
            this.buttonLeanWordBack.TabIndex = 13;
            this.buttonLeanWordBack.Text = "Prev";
            this.buttonLeanWordBack.UseVisualStyleBackColor = true;
            this.buttonLeanWordBack.Click += new System.EventHandler(this.buttonLeanWordBack_Click);
            // 
            // buttonLearnWordNext
            // 
            this.buttonLearnWordNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLearnWordNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLearnWordNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLearnWordNext.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.buttonLearnWordNext.Location = new System.Drawing.Point(138, 114);
            this.buttonLearnWordNext.Name = "buttonLearnWordNext";
            this.buttonLearnWordNext.Size = new System.Drawing.Size(75, 25);
            this.buttonLearnWordNext.TabIndex = 12;
            this.buttonLearnWordNext.Text = "Next";
            this.buttonLearnWordNext.UseVisualStyleBackColor = true;
            this.buttonLearnWordNext.Click += new System.EventHandler(this.buttonLearnWordNext_Click);
            // 
            // labelLearnWord
            // 
            this.labelLearnWord.AutoSize = true;
            this.labelLearnWord.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLearnWord.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelLearnWord.Location = new System.Drawing.Point(13, 26);
            this.labelLearnWord.Name = "labelLearnWord";
            this.labelLearnWord.Size = new System.Drawing.Size(68, 23);
            this.labelLearnWord.TabIndex = 12;
            this.labelLearnWord.Text = "label1";
            // 
            // groupBoxReverseChallenge
            // 
            this.groupBoxReverseChallenge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReverseChallenge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxReverseChallenge.BackgroundImage")));
            this.groupBoxReverseChallenge.Controls.Add(this.TEXTFORREVCOUNTER);
            this.groupBoxReverseChallenge.Controls.Add(this.buttonGo);
            this.groupBoxReverseChallenge.Controls.Add(this.button2);
            this.groupBoxReverseChallenge.Controls.Add(this.labelReveseChallangeStatus);
            this.groupBoxReverseChallenge.Controls.Add(this.label3ReversechoiceResult);
            this.groupBoxReverseChallenge.Controls.Add(this.labelRevereChallengeWord);
            this.groupBoxReverseChallenge.Controls.Add(this.buttonReverseChallanageNext);
            this.groupBoxReverseChallenge.Controls.Add(this.reversechoiceoption1);
            this.groupBoxReverseChallenge.Controls.Add(this.labelReverseChoice);
            this.groupBoxReverseChallenge.Controls.Add(this.reversechoiceoption2);
            this.groupBoxReverseChallenge.Controls.Add(this.reversechoiceoption5);
            this.groupBoxReverseChallenge.Controls.Add(this.reversechoiceoption3);
            this.groupBoxReverseChallenge.Controls.Add(this.reversechoiceoption4);
            this.groupBoxReverseChallenge.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReverseChallenge.Location = new System.Drawing.Point(121, 90);
            this.groupBoxReverseChallenge.Name = "groupBoxReverseChallenge";
            this.groupBoxReverseChallenge.Size = new System.Drawing.Size(711, 216);
            this.groupBoxReverseChallenge.TabIndex = 13;
            this.groupBoxReverseChallenge.TabStop = false;
            this.groupBoxReverseChallenge.Text = "Reverse Challenge";
            this.groupBoxReverseChallenge.Enter += new System.EventHandler(this.groupBoxReverseChallenge_Enter);
            // 
            // TEXTFORREVCOUNTER
            // 
            this.TEXTFORREVCOUNTER.AutoSize = true;
            this.TEXTFORREVCOUNTER.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTFORREVCOUNTER.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.TEXTFORREVCOUNTER.Location = new System.Drawing.Point(242, 106);
            this.TEXTFORREVCOUNTER.Name = "TEXTFORREVCOUNTER";
            this.TEXTFORREVCOUNTER.Size = new System.Drawing.Size(29, 29);
            this.TEXTFORREVCOUNTER.TabIndex = 17;
            this.TEXTFORREVCOUNTER.Text = "\"\"";
            this.TEXTFORREVCOUNTER.Visible = false;
            // 
            // buttonGo
            // 
            this.buttonGo.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(141, 85);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 25);
            this.buttonGo.TabIndex = 15;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(172, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Exit to Options";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelReveseChallangeStatus
            // 
            this.labelReveseChallangeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReveseChallangeStatus.AutoSize = true;
            this.labelReveseChallangeStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelReveseChallangeStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelReveseChallangeStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelReveseChallangeStatus.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelReveseChallangeStatus.Location = new System.Drawing.Point(243, 66);
            this.labelReveseChallangeStatus.Name = "labelReveseChallangeStatus";
            this.labelReveseChallangeStatus.Size = new System.Drawing.Size(54, 19);
            this.labelReveseChallangeStatus.TabIndex = 13;
            this.labelReveseChallangeStatus.Text = "label3";
            this.labelReveseChallangeStatus.Visible = false;
            // 
            // label3ReversechoiceResult
            // 
            this.label3ReversechoiceResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3ReversechoiceResult.AutoSize = true;
            this.label3ReversechoiceResult.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3ReversechoiceResult.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.label3ReversechoiceResult.Location = new System.Drawing.Point(310, 86);
            this.label3ReversechoiceResult.Name = "label3ReversechoiceResult";
            this.label3ReversechoiceResult.Size = new System.Drawing.Size(48, 21);
            this.label3ReversechoiceResult.TabIndex = 11;
            this.label3ReversechoiceResult.Text = "None";
            this.label3ReversechoiceResult.Visible = false;
            this.label3ReversechoiceResult.Click += new System.EventHandler(this.label3ReversechoiceResult_Click);
            // 
            // labelRevereChallengeWord
            // 
            this.labelRevereChallengeWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRevereChallengeWord.AutoSize = true;
            this.labelRevereChallengeWord.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevereChallengeWord.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelRevereChallengeWord.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelRevereChallengeWord.Location = new System.Drawing.Point(12, 25);
            this.labelRevereChallengeWord.Name = "labelRevereChallengeWord";
            this.labelRevereChallengeWord.Size = new System.Drawing.Size(59, 23);
            this.labelRevereChallengeWord.TabIndex = 0;
            this.labelRevereChallengeWord.Text = "label1";
            // 
            // buttonReverseChallanageNext
            // 
            this.buttonReverseChallanageNext.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.buttonReverseChallanageNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReverseChallanageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverseChallanageNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReverseChallanageNext.Location = new System.Drawing.Point(55, 176);
            this.buttonReverseChallanageNext.Name = "buttonReverseChallanageNext";
            this.buttonReverseChallanageNext.Size = new System.Drawing.Size(75, 25);
            this.buttonReverseChallanageNext.TabIndex = 10;
            this.buttonReverseChallanageNext.Text = "Next";
            this.buttonReverseChallanageNext.UseVisualStyleBackColor = true;
            this.buttonReverseChallanageNext.Visible = false;
            this.buttonReverseChallanageNext.Click += new System.EventHandler(this.buttonReverseChallanageNext_Click);
            // 
            // reversechoiceoption1
            // 
            this.reversechoiceoption1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reversechoiceoption1.AutoSize = true;
            this.reversechoiceoption1.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.reversechoiceoption1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversechoiceoption1.Location = new System.Drawing.Point(16, 62);
            this.reversechoiceoption1.Name = "reversechoiceoption1";
            this.reversechoiceoption1.Size = new System.Drawing.Size(14, 13);
            this.reversechoiceoption1.TabIndex = 4;
            this.reversechoiceoption1.UseVisualStyleBackColor = true;
            this.reversechoiceoption1.Visible = false;
            this.reversechoiceoption1.CheckedChanged += new System.EventHandler(this.reversechoiceoption1_CheckedChanged);
            // 
            // labelReverseChoice
            // 
            this.labelReverseChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReverseChoice.AutoSize = true;
            this.labelReverseChoice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReverseChoice.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelReverseChoice.Location = new System.Drawing.Point(242, 84);
            this.labelReverseChoice.Name = "labelReverseChoice";
            this.labelReverseChoice.Size = new System.Drawing.Size(71, 23);
            this.labelReverseChoice.TabIndex = 9;
            this.labelReverseChoice.Text = "Result : ";
            this.labelReverseChoice.Visible = false;
            // 
            // reversechoiceoption2
            // 
            this.reversechoiceoption2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reversechoiceoption2.AutoSize = true;
            this.reversechoiceoption2.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.reversechoiceoption2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversechoiceoption2.Location = new System.Drawing.Point(16, 84);
            this.reversechoiceoption2.Name = "reversechoiceoption2";
            this.reversechoiceoption2.Size = new System.Drawing.Size(14, 13);
            this.reversechoiceoption2.TabIndex = 5;
            this.reversechoiceoption2.UseVisualStyleBackColor = true;
            this.reversechoiceoption2.Visible = false;
            this.reversechoiceoption2.CheckedChanged += new System.EventHandler(this.reversechoiceoption2_CheckedChanged);
            // 
            // reversechoiceoption5
            // 
            this.reversechoiceoption5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reversechoiceoption5.AutoSize = true;
            this.reversechoiceoption5.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.reversechoiceoption5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversechoiceoption5.Location = new System.Drawing.Point(16, 148);
            this.reversechoiceoption5.Name = "reversechoiceoption5";
            this.reversechoiceoption5.Size = new System.Drawing.Size(14, 13);
            this.reversechoiceoption5.TabIndex = 8;
            this.reversechoiceoption5.UseVisualStyleBackColor = true;
            this.reversechoiceoption5.Visible = false;
            this.reversechoiceoption5.CheckedChanged += new System.EventHandler(this.reversechoiceoption5_CheckedChanged);
            // 
            // reversechoiceoption3
            // 
            this.reversechoiceoption3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reversechoiceoption3.AutoSize = true;
            this.reversechoiceoption3.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.reversechoiceoption3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversechoiceoption3.Location = new System.Drawing.Point(16, 106);
            this.reversechoiceoption3.Name = "reversechoiceoption3";
            this.reversechoiceoption3.Size = new System.Drawing.Size(14, 13);
            this.reversechoiceoption3.TabIndex = 6;
            this.reversechoiceoption3.UseVisualStyleBackColor = true;
            this.reversechoiceoption3.Visible = false;
            this.reversechoiceoption3.CheckedChanged += new System.EventHandler(this.reversechoiceoption3_CheckedChanged);
            // 
            // reversechoiceoption4
            // 
            this.reversechoiceoption4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reversechoiceoption4.AutoSize = true;
            this.reversechoiceoption4.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.reversechoiceoption4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reversechoiceoption4.Location = new System.Drawing.Point(16, 128);
            this.reversechoiceoption4.Name = "reversechoiceoption4";
            this.reversechoiceoption4.Size = new System.Drawing.Size(14, 13);
            this.reversechoiceoption4.TabIndex = 7;
            this.reversechoiceoption4.UseVisualStyleBackColor = true;
            this.reversechoiceoption4.Visible = false;
            this.reversechoiceoption4.CheckedChanged += new System.EventHandler(this.reversechoiceoption4_CheckedChanged);
            // 
            // labelMultipleChoiceQuestion
            // 
            this.labelMultipleChoiceQuestion.AutoSize = true;
            this.labelMultipleChoiceQuestion.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultipleChoiceQuestion.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelMultipleChoiceQuestion.Location = new System.Drawing.Point(47, 54);
            this.labelMultipleChoiceQuestion.Name = "labelMultipleChoiceQuestion";
            this.labelMultipleChoiceQuestion.Size = new System.Drawing.Size(68, 23);
            this.labelMultipleChoiceQuestion.TabIndex = 0;
            this.labelMultipleChoiceQuestion.Text = "label1";
            // 
            // mulChoice1
            // 
            this.mulChoice1.AutoSize = true;
            this.mulChoice1.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.mulChoice1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulChoice1.Location = new System.Drawing.Point(44, 82);
            this.mulChoice1.Name = "mulChoice1";
            this.mulChoice1.Size = new System.Drawing.Size(14, 13);
            this.mulChoice1.TabIndex = 4;
            this.mulChoice1.TabStop = true;
            this.mulChoice1.UseVisualStyleBackColor = true;
            this.mulChoice1.CheckedChanged += new System.EventHandler(this.mulChoice1_CheckedChanged);
            // 
            // mulChoice2
            // 
            this.mulChoice2.AutoSize = true;
            this.mulChoice2.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.mulChoice2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulChoice2.Location = new System.Drawing.Point(44, 105);
            this.mulChoice2.Name = "mulChoice2";
            this.mulChoice2.Size = new System.Drawing.Size(14, 13);
            this.mulChoice2.TabIndex = 5;
            this.mulChoice2.TabStop = true;
            this.mulChoice2.UseVisualStyleBackColor = true;
            this.mulChoice2.CheckedChanged += new System.EventHandler(this.mulChoice2_CheckedChanged);
            // 
            // mulChoice3
            // 
            this.mulChoice3.AutoSize = true;
            this.mulChoice3.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.mulChoice3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulChoice3.Location = new System.Drawing.Point(44, 128);
            this.mulChoice3.Name = "mulChoice3";
            this.mulChoice3.Size = new System.Drawing.Size(14, 13);
            this.mulChoice3.TabIndex = 6;
            this.mulChoice3.TabStop = true;
            this.mulChoice3.UseVisualStyleBackColor = true;
            this.mulChoice3.CheckedChanged += new System.EventHandler(this.mulChoice3_CheckedChanged);
            // 
            // mulChoice4
            // 
            this.mulChoice4.AutoSize = true;
            this.mulChoice4.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.mulChoice4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulChoice4.Location = new System.Drawing.Point(44, 151);
            this.mulChoice4.Name = "mulChoice4";
            this.mulChoice4.Size = new System.Drawing.Size(14, 13);
            this.mulChoice4.TabIndex = 7;
            this.mulChoice4.TabStop = true;
            this.mulChoice4.UseVisualStyleBackColor = true;
            this.mulChoice4.CheckedChanged += new System.EventHandler(this.mulChoice4_CheckedChanged);
            // 
            // mulChoice5
            // 
            this.mulChoice5.AutoSize = true;
            this.mulChoice5.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.mulChoice5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulChoice5.Location = new System.Drawing.Point(44, 173);
            this.mulChoice5.Name = "mulChoice5";
            this.mulChoice5.Size = new System.Drawing.Size(14, 13);
            this.mulChoice5.TabIndex = 8;
            this.mulChoice5.TabStop = true;
            this.mulChoice5.UseVisualStyleBackColor = true;
            this.mulChoice5.CheckedChanged += new System.EventHandler(this.mulChoice5_CheckedChanged);
            // 
            // labelMulchoiceResult
            // 
            this.labelMulchoiceResult.AutoSize = true;
            this.labelMulchoiceResult.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMulchoiceResult.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelMulchoiceResult.Location = new System.Drawing.Point(210, 35);
            this.labelMulchoiceResult.Name = "labelMulchoiceResult";
            this.labelMulchoiceResult.Size = new System.Drawing.Size(78, 23);
            this.labelMulchoiceResult.TabIndex = 9;
            this.labelMulchoiceResult.Text = "Result : ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.label1.Location = new System.Drawing.Point(276, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "None";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxMultipleChoice
            // 
            this.groupBoxMultipleChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMultipleChoice.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.groupBoxMultipleChoice.Controls.Add(this.labelrevtimercounter);
            this.groupBoxMultipleChoice.Controls.Add(this.button3);
            this.groupBoxMultipleChoice.Controls.Add(this.LabelMulQuesStatus);
            this.groupBoxMultipleChoice.Controls.Add(this.label1);
            this.groupBoxMultipleChoice.Controls.Add(this.button1);
            this.groupBoxMultipleChoice.Controls.Add(this.labelMulchoiceResult);
            this.groupBoxMultipleChoice.Controls.Add(this.mulChoice5);
            this.groupBoxMultipleChoice.Controls.Add(this.mulChoice4);
            this.groupBoxMultipleChoice.Controls.Add(this.mulChoice3);
            this.groupBoxMultipleChoice.Controls.Add(this.mulChoice2);
            this.groupBoxMultipleChoice.Controls.Add(this.mulChoice1);
            this.groupBoxMultipleChoice.Controls.Add(this.labelMultipleChoiceQuestion);
            this.groupBoxMultipleChoice.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMultipleChoice.Location = new System.Drawing.Point(61, 101);
            this.groupBoxMultipleChoice.Name = "groupBoxMultipleChoice";
            this.groupBoxMultipleChoice.Size = new System.Drawing.Size(740, 264);
            this.groupBoxMultipleChoice.TabIndex = 2;
            this.groupBoxMultipleChoice.TabStop = false;
            this.groupBoxMultipleChoice.Text = "Multiple Choice";
            this.groupBoxMultipleChoice.Enter += new System.EventHandler(this.groupBoxMultipleChoice_Enter_1);
            // 
            // labelrevtimercounter
            // 
            this.labelrevtimercounter.AutoSize = true;
            this.labelrevtimercounter.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrevtimercounter.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.labelrevtimercounter.Location = new System.Drawing.Point(213, 56);
            this.labelrevtimercounter.Name = "labelrevtimercounter";
            this.labelrevtimercounter.Size = new System.Drawing.Size(29, 29);
            this.labelrevtimercounter.TabIndex = 16;
            this.labelrevtimercounter.Text = "\"\"";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(147, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "Exit to Options";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabelMulQuesStatus
            // 
            this.LabelMulQuesStatus.AutoSize = true;
            this.LabelMulQuesStatus.BackColor = System.Drawing.SystemColors.Control;
            this.LabelMulQuesStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelMulQuesStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelMulQuesStatus.Image = global::WindowsApplication1.Properties.Resources.Untitled_1_copy;
            this.LabelMulQuesStatus.Location = new System.Drawing.Point(211, 19);
            this.LabelMulQuesStatus.Name = "LabelMulQuesStatus";
            this.LabelMulQuesStatus.Size = new System.Drawing.Size(54, 19);
            this.LabelMulQuesStatus.TabIndex = 12;
            this.LabelMulQuesStatus.Text = "label3";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
            this.pictureBox2.Image = global::WindowsApplication1.Properties.Resources.help_icon1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(698, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 47);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
            this.pictureBox1.Image = global::WindowsApplication1.Properties.Resources.home_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(658, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 47);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // NewWordlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsApplication1.Properties.Resources.back_copy;
            this.ClientSize = new System.Drawing.Size(844, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBoxReverseChallenge);
            this.Controls.Add(this.groupBoxLearnWordList);
            this.Controls.Add(this.groupBoxMultipleChoice);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.SelectTest);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewWordlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarantula";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewWordlist_Load_1);
            this.SelectTest.ResumeLayout(false);
            this.SelectTest.PerformLayout();
            this.groupBoxLearnWordList.ResumeLayout(false);
            this.groupBoxLearnWordList.PerformLayout();
            this.groupBoxReverseChallenge.ResumeLayout(false);
            this.groupBoxReverseChallenge.PerformLayout();
            this.groupBoxMultipleChoice.ResumeLayout(false);
            this.groupBoxMultipleChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectTest;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBoxLearnWordList;
        private System.Windows.Forms.Button buttonLearnWordNext;
        private System.Windows.Forms.Label labelLearnWord;
        private System.Windows.Forms.Label labelMultipleChoiceQuestion;
        private System.Windows.Forms.RadioButton mulChoice1;
        private System.Windows.Forms.RadioButton mulChoice2;
        private System.Windows.Forms.RadioButton mulChoice3;
        private System.Windows.Forms.RadioButton mulChoice4;
        private System.Windows.Forms.RadioButton mulChoice5;
        private System.Windows.Forms.Label labelMulchoiceResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMultipleChoice;
        private System.Windows.Forms.Button buttonLeanWordBack;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton LearnWordList;
        private System.Windows.Forms.RadioButton Radiobuttopnmulchoice;
        private System.Windows.Forms.GroupBox groupBoxReverseChallenge;
        private System.Windows.Forms.Label label3ReversechoiceResult;
        private System.Windows.Forms.Label labelRevereChallengeWord;
        private System.Windows.Forms.Button buttonReverseChallanageNext;
        private System.Windows.Forms.RadioButton reversechoiceoption1;
        private System.Windows.Forms.Label labelReverseChoice;
        private System.Windows.Forms.RadioButton reversechoiceoption2;
        private System.Windows.Forms.RadioButton reversechoiceoption5;
        private System.Windows.Forms.RadioButton reversechoiceoption3;
        private System.Windows.Forms.RadioButton reversechoiceoption4;
        private System.Windows.Forms.Label LabelMulQuesStatus;
        private System.Windows.Forms.Label labelLearnWordListStatus;
        private System.Windows.Forms.Label labelReveseChallangeStatus;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton flipwords;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelrevtimercounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label TEXTFORREVCOUNTER;
    }
}