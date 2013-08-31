using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace WindowsApplication1
{
    public partial class NewWordlist : Form
    {
        commonclass cml = new commonclass();
        public int scorecalculator = 0;
        public bool rightAns;
        public int wordlistnumber;
        public string wordlistIdentity;
        public string[] word = new string[10000];
        public string[] meaning = new string[10000];
        public int count;
        public int global_count;
        public int mulChoiceCounter = 0;
        public int revmulChoiceCounter = 0;
        public int[] word_status = new int[10000];
        public int[] meaning_status = new int[10000];
        public int mulchoiceAns_Index;
        public int RevchallangeAns_Index;
        public int i = 0;
       // public int revmulChoiceCounter = 0;
        public int revtimerCounter = 0;
        public int mullchoicetimerCounter = 0;
        public int[] questionsAnswer_status = new int[10000];
        public int rightAnsCounter = 0;

        public NewWordlist()
        {
            InitializeComponent();

        }

        //reverse Challenge Starts
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            for (int k = 0; k <global_count; k++) questionsAnswer_status[k] = 0;
            rightAnsCounter = 0;
            TEXTFORREVCOUNTER.Visible = false;
            TEXTFORREVCOUNTER.Text = "0";
            mullchoicetimerCounter = 0;
            
            buttonGo.Visible = true;
            reversechoiceoption1.Visible =false;
            reversechoiceoption2.Visible = false;
            reversechoiceoption3.Visible = false;
            reversechoiceoption4.Visible = false;
            reversechoiceoption5.Visible = false;
            labelRevereChallengeWord.Visible = false;
            buttonReverseChallanageNext.Visible = false;
            button2.Visible = false;
            labelReveseChallangeStatus.Visible = false;
            labelReverseChoice.Visible = false;
            label3ReversechoiceResult.Visible = false;
            for (int k = 0; k <= 100; k++) meaning_status[k] = 0;

            LearnWordList.Checked = false;
            Radiobuttopnmulchoice.Checked = false;        
            radioButton4.Checked = false;


            labelReveseChallangeStatus.Text = "";
            labelReverseChoice.Visible = false;
            scorecalculator = 0;
            rightAns = false;
            groupBoxLearnWordList.Visible = false;
            SelectTest.Visible = false;
            groupBoxMultipleChoice.Visible = false;

            groupBoxReverseChallenge.Visible = true;
            label3ReversechoiceResult.Text = "";
            buttonReverseChallanageNext.Text = "Next";
            rightAns = false;
            count = global_count;
            revmulChoiceCounter = 0;
            reversechoiceoption1.Checked = false;
            reversechoiceoption2.Checked = false;
            reversechoiceoption3.Checked = false;
            reversechoiceoption4.Checked = false;
            reversechoiceoption5.Checked = false;

            
            labelReveseChallangeStatus.Text = "Count: "+(revmulChoiceCounter + 1) + "/" + global_count;
            //MessageBox.Show("ffffffffff"+i.ToString());
           // if (i == 0) { newRevMultipleChoiceQuestion(); i = 1; }




                      
        }

        private void MultipleChoice_CheckedChanged(object sender, EventArgs e)
        {
           
            groupBoxLearnWordList.Visible = false;


            label1.Text = "";
            button1.Text = "Next";
            rightAns = false;
            count = global_count;
            mulChoiceCounter = 0;
            mulChoice1.Checked = false;
            mulChoice2.Checked = false;
            mulChoice3.Checked = false;
            mulChoice4.Checked = false;
            mulChoice5.Checked = false;
            newMultipleChoiceQuestion();
            
        }

      
        public int find_duplicity(string str) {
            if (mulChoice1.Text == str) return 1;
            else if (mulChoice2.Text == str) return 1;
            else if (mulChoice3.Text == str) return 1;
            else if (mulChoice4.Text == str) return 1;
            else if (mulChoice5.Text == str) return 1;
            else
                return 0;
        }
        public int find_revduplicity(string str)
        {
            if (reversechoiceoption1.Text == str) return 1;
            else if (reversechoiceoption2.Text == str) return 1;
            else if (reversechoiceoption3.Text == str) return 1;
            else if (reversechoiceoption4.Text == str) return 1;
            else if (reversechoiceoption5.Text == str) return 1;
            else
                return 0;
        }
        public int randMulchoiceGenerator(string[] word)
        {
            Random random = new Random();

            while (true)
            {
                int random_number = random.Next(0, 100);
                random_number = random_number % global_count;
                if (word_status[random_number] == 0)
                {
                    word_status[random_number] = 1;
                    return random_number;
                }
            }
        }
        public int randRevhoiceGenerator(string[] meaning)
        {
            Random random = new Random();

            while (true)
            {
                int random_number = random.Next(0, 100);
                random_number = random_number % global_count;
                if (meaning_status[random_number] == 0)
                {
                   // MessageBox.Show("aaaa");
                    meaning_status[random_number] = 1;
                    return random_number;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                //MessageBox.Show("aaaaaaaaaa");
                //labelReveseChallangeStatus.Text = labelReveseChallangeStatus.Text +(revtimerCounter++);
                int mm = (int)revtimerCounter;
                //MessageBox.Show(revtimerCounter.ToString()); 
                labelrevtimercounter.Text = mm.ToString();
                
                ++revtimerCounter;

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sender == timer2)
            {
                //MessageBox.Show("aaaaaaaaaa");
                //labelReveseChallangeStatus.Text = labelReveseChallangeStatus.Text +(revtimerCounter++);
                int mm = (int)mullchoicetimerCounter;
                //MessageBox.Show(revtimerCounter.ToString()); 
                //labelmulchoicetimercounterstatus.Text = mm.ToString();
                TEXTFORREVCOUNTER.Text = mm.ToString();
                ++mullchoicetimerCounter;

            }
        }
        
        public void newMultipleChoiceQuestion(){
            
            LabelMulQuesStatus.Text="Count: "+(mulChoiceCounter+1)+"/"+global_count;
            mulChoice1.Text = ""; mulChoice2.Text = ""; mulChoice3.Text = ""; mulChoice4.Text = ""; mulChoice5.Text = "";
            int[] nonrepeater = { 0,0,0,0,0,0};
            groupBoxMultipleChoice.Visible = true;

            int index = randMulchoiceGenerator(word);
            mulchoiceAns_Index = index;
            labelMultipleChoiceQuestion.Text = word[index];
            
            Random random = new Random();
            int random_number= random.Next(0, 100);
            if ((random_number % 5) == 0) { mulChoice1.Text = meaning[index]; nonrepeater[1] = 1; }
            if ((random_number % 5) == 1) { mulChoice2.Text = meaning[index]; nonrepeater[2] = 1; }
            if ((random_number % 5) == 2) { mulChoice3.Text = meaning[index]; nonrepeater[3] = 1; }
            if ((random_number % 5) == 3) { mulChoice4.Text = meaning[index]; nonrepeater[4] = 1; }
            if ((random_number % 5) == 4) { mulChoice5.Text = meaning[index]; nonrepeater[5] = 1; }

            int terminator = 0;
            
            while(true){
                if ( nonrepeater[1]==0) {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if ((find_duplicity(meaning[random_number]))==0)
                    {
                        mulChoice1.Text = meaning[random_number];
                        ++terminator;
                        nonrepeater[1] = 1;
                    }
                }
                if ( nonrepeater[2] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_duplicity(meaning[random_number])==0)
                    {
                        mulChoice2.Text = meaning[random_number];
                        ++terminator;
                        nonrepeater[2] = 1;
                    }
                }
                if ( nonrepeater[3] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_duplicity(meaning[random_number])==0)
                    {
                        mulChoice3.Text = meaning[random_number];
                        ++terminator;
                        nonrepeater[3] =1;
                    }
                }
                if (nonrepeater[4] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_duplicity(meaning[random_number])==0)
                    {
                        mulChoice4.Text = meaning[random_number];
                        ++terminator;
                        nonrepeater[4] =1;
                    }
                }
                if (nonrepeater[5] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_duplicity(meaning[random_number])==0)
                    {
                        mulChoice5.Text = meaning[random_number];
                        ++terminator;
                        nonrepeater[5] = 1;
                    }
                }
               if (terminator == 4) break;
            }
            ++mulChoiceCounter;
        }

        public void newRevMultipleChoiceQuestion()
        {
            reversechoiceoption1.Checked = false;
            reversechoiceoption2.Checked = false;
            reversechoiceoption3.Checked = false;
            reversechoiceoption4.Checked = false;
            reversechoiceoption5.Checked = false;

            buttonGo.Visible = false;
            //  for (int k = 0; k <= 100; k++) { meaning_status[k] = 0; }
            reversechoiceoption1.Text = ""; reversechoiceoption2.Text = ""; reversechoiceoption3.Text = ""; reversechoiceoption4.Text = ""; reversechoiceoption5.Text = "";
            int[] nonrepeater = { 0, 0, 0, 0, 0, 0 };
            groupBoxReverseChallenge.Visible = true;

            int index = randRevhoiceGenerator(meaning);
            RevchallangeAns_Index = index;
            labelRevereChallengeWord.Text = meaning[index];
            
            Random random = new Random();
            int random_number = random.Next(0, 100);
            if ((random_number % 5) == 0) { reversechoiceoption1.Text = word[index]; nonrepeater[1] = 1; }
            if ((random_number % 5) == 1) { reversechoiceoption2.Text = word[index]; nonrepeater[2] = 1; }
            if ((random_number % 5) == 2) { reversechoiceoption3.Text = word[index]; nonrepeater[3] = 1; }
            if ((random_number % 5) == 3) { reversechoiceoption4.Text = word[index]; nonrepeater[4] = 1; }
            if ((random_number % 5) == 4) { reversechoiceoption5.Text = word[index]; nonrepeater[5] = 1; }

            int terminator = 0;

            while (true)
            {
               
                if (nonrepeater[1] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if ((find_revduplicity(word[random_number])) == 0)
                    {
                        reversechoiceoption1.Text = word[random_number];
                        ++terminator;
                        nonrepeater[1] = 1;
                    }
                }
                if (nonrepeater[2] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_revduplicity(word[random_number]) == 0)
                    {
                        reversechoiceoption2.Text = word[random_number];
                        ++terminator;
                        nonrepeater[2] = 1;
                    }
                }
                if (nonrepeater[3] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_revduplicity(word[random_number]) == 0)
                    {
                        reversechoiceoption3.Text = word[random_number];
                        ++terminator;
                        nonrepeater[3] = 1;
                    }
                }
                if (nonrepeater[4] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_revduplicity(word[random_number]) == 0)
                    {
                        reversechoiceoption4.Text = word[random_number];
                        ++terminator;
                        nonrepeater[4] = 1;
                    }
                }
                if (nonrepeater[5] == 0)
                {
                    random_number = random.Next(0, 100);
                    random_number = random_number % global_count;
                    if (find_revduplicity(word[random_number]) == 0)
                    {
                        reversechoiceoption5.Text = word[random_number];
                        ++terminator;
                        nonrepeater[5] = 1;
                    }
                }
                if (terminator == 4) break;
            }
          // MessageBox.Show( questionsAnswer_status[rightAnsCounter].ToString());
            ++rightAnsCounter;
            ++revmulChoiceCounter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            revtimerCounter = 0;
            labelrevtimercounter.Visible = false;

            if (button1.Text == "Exit")
            {
                groupBoxMultipleChoice.Visible = false;
                SelectTest.Visible = true;
               
            }
            else
            {
                if (rightAns == true) ++scorecalculator;
            }
            if (mulChoiceCounter == count)
            {
                final_result();
                button1.Text = "Exit";
              
            }
            else
            {
                mulChoice1.Checked = false;
                mulChoice2.Checked = false;
                mulChoice3.Checked = false;
                mulChoice4.Checked = false;
                mulChoice5.Checked = false;
                label1.Text = "";
                labelMulchoiceResult.Visible = false;

                
                timer1.Start();
                labelrevtimercounter.Visible = true;
                labelrevtimercounter.Text = "0";
                ++rightAnsCounter;
                newMultipleChoiceQuestion();
               // MessageBox.Show("aaaaaa");
            }

        }

       

        public void final_result(){
            int i = 0; 
            for (int j = 0; j < global_count; j++)
            {
                if (questionsAnswer_status[j] == 1) { ++i; }
            }
            label1.Text = "Your Score is: " + i.ToString();
           
        }

        public void final_revresult()
        {
            int i = 0; string str = "";
            for (int j = 0; j < global_count; j++) {
                if (questionsAnswer_status[j] == 1) { ++i; } str = str + "\t" + questionsAnswer_status[j].ToString();
            }
                label3ReversechoiceResult.Text = "Your Score is: " +i.ToString();
            //label3ReversechoiceResult.Text = ">End<";
               // MessageBox.Show(str);
        }


        /*if (reversechoiceoption1.Text == word[RevchallangeAns_Index]) { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Green; label3ReversechoiceResult.Text = "Correct";

                    if (questionsAnswer_status[rightAnsCounter] == 0)
                        {
                            questionsAnswer_status[rightAnsCounter] = 1;
                            // MessageBox.Show("aaaaaaaaaaaaaaa");
                            rightAns = true;
                          //  MessageBox.Show("1Y"+rightAnsCounter.ToString()+"   "+rightAnsCounter.ToString());
                        }
                        else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                        else
                        {
                            questionsAnswer_status[rightAnsCounter] = 5;
                            MessageBox.Show("1");
                        }
                }
                else
                { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Red; label3ReversechoiceResult.Text = "Wrong.\nAns: " + word[revmulChoiceCounter - 1]; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }*/
        
        
        private void mulChoice1_CheckedChanged(object sender, EventArgs e)
        {
            labelMulchoiceResult.Visible = true;
            try
            {
                if (mulChoice1.Text == meaning[mulchoiceAns_Index]) { label1.ForeColor = System.Drawing.Color.Green; label1.Text = "Correct"; rightAns=true;
                    if (questionsAnswer_status[rightAnsCounter] == 0)
                    {
                        questionsAnswer_status[rightAnsCounter] = 1;
                   
                    }
                    else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                    else
                    {
                        questionsAnswer_status[rightAnsCounter] = 5;
                    //MessageBox.Show("1");
                    }
                }
                else
                { label1.ForeColor = System.Drawing.Color.Red; label1.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }catch(Exception ex){
                MessageBox.Show("Exception occured:" + ex.ToString());
            }

        }
        private void mulChoice2_CheckedChanged(object sender, EventArgs e)
        {
            labelMulchoiceResult.Visible = true;
            try
            {
                if (mulChoice2.Text == meaning[mulchoiceAns_Index]) { label1.ForeColor = System.Drawing.Color.Green; label1.Text = "Correct"; rightAns = true; 
                if (questionsAnswer_status[rightAnsCounter] == 0)
                    {
                        questionsAnswer_status[rightAnsCounter] = 1;
                   
                    }
                    else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                    else
                    {
                        questionsAnswer_status[rightAnsCounter] = 5;
                    //MessageBox.Show("1");
                    }
                }
                else
                { label1.ForeColor = System.Drawing.Color.Red; label1.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }catch(Exception ex){
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void mulChoice3_CheckedChanged(object sender, EventArgs e)
        {
            labelMulchoiceResult.Visible = true;
            try
            {
                if (mulChoice3.Text == meaning[mulchoiceAns_Index]) { label1.ForeColor = System.Drawing.Color.Green; label1.Text = "Correct"; rightAns = true;
                if (questionsAnswer_status[rightAnsCounter] == 0)
                {
                    questionsAnswer_status[rightAnsCounter] = 1;

                }
                else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                else
                {
                    questionsAnswer_status[rightAnsCounter] = 5;
                    //MessageBox.Show("1");
                }
            }
                else
            { label1.ForeColor = System.Drawing.Color.Red; label1.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }
            catch (Exception ex){
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void mulChoice4_CheckedChanged(object sender, EventArgs e)
        {
            labelMulchoiceResult.Visible = true;
            try
            {
                if (mulChoice4.Text == meaning[mulchoiceAns_Index]) { label1.ForeColor = System.Drawing.Color.Green; label1.Text = "Correct"; rightAns = true;
                if (questionsAnswer_status[rightAnsCounter] == 0)
                {
                    questionsAnswer_status[rightAnsCounter] = 1;

                }
                else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                else
                {
                    questionsAnswer_status[rightAnsCounter] = 5;
                    //MessageBox.Show("1");
                }
            }
                else
                { label1.ForeColor = System.Drawing.Color.Red; label1.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }catch(Exception ex){
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void mulChoice5_CheckedChanged(object sender, EventArgs e)
        {
            labelMulchoiceResult.Visible = true;
            if (mulChoice5.Text == meaning[mulchoiceAns_Index]) { label1.ForeColor = System.Drawing.Color.Green; label1.Text = "Correct"; rightAns = true;
            if (questionsAnswer_status[rightAnsCounter] == 0)
            {
                questionsAnswer_status[rightAnsCounter] = 1;

            }
            else if (questionsAnswer_status[rightAnsCounter] == 1) { }
            else
            {
                questionsAnswer_status[rightAnsCounter] = 5;
                //MessageBox.Show("1");
            }
        }
            else
            { label1.ForeColor = System.Drawing.Color.Red; label1.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void LearnWordList_CheckedChanged(object sender, EventArgs e)
        {
            SelectTest.Visible = true;
            groupBoxMultipleChoice.Visible = false;
            groupBoxReverseChallenge.Visible = false;
            groupBoxLearnWordList.Visible = true;

            labelLearnWordListStatus.Text = "";
            buttonLeanWordBack.Text = "Prev";
            buttonLeanWordBack.Visible = true;
            buttonLearnWordNext.Text = "Next";
            buttonLearnWordNext.Visible = true;
            rightAns = false;
            count =-1;
            ++count;
            labelLearnWordListStatus.Text = "Count: "+(count + 1) + "/" + global_count;
            labelLearnWord.Text = word[count];
            richTextBox1.Text = meaning[count];
            
        }

        private void buttonLearnWordNext_Click(object sender, EventArgs e)
        {
            
            if(rightAns==true){
                groupBoxLearnWordList.Visible = false;
                SelectTest.Visible = true;
            }
            ++count;
            labelLearnWordListStatus.Text = "Count: "+(count + 1) + "/" + global_count;
            labelLearnWord.Text = word[count];
            richTextBox1.Text = meaning[count];
            if(count==global_count){
                rightAns = true;
                buttonLeanWordBack.Visible = false;
               buttonLearnWordNext.Text = "End List";
               labelLearnWordListStatus.Text = count + "/" + global_count;
            }
            
        }

        private void buttonLeanWordBack_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                --count;
                labelLearnWordListStatus.Text = "Count: "+(count + 1) + "/" + global_count;
                labelLearnWord.Text = word[count];
                richTextBox1.Text = meaning[count];
            }
        }

        private void groupBoxMultipleChoice_Enter(object sender, EventArgs e)
        {

        }

        private void NewWordlist_Load_1(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            //MessageBox.Show(cml.wordlistnumber+cml.wordlistidentity);
            headerLabel.Text = "Test on Word List " + wordlistnumber.ToString() + ":(" + wordlistIdentity + ")";
            //StreamReader objReader = new StreamReader("I:\\Program Files\\Default Company Name\\Tarantula\\Resources\\" + wordlistnumber.ToString()+ ".txt");

            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //MessageBox.Show(dir);
            StreamReader objReader = new StreamReader(dir+ @"\wordList\" + wordlistnumber.ToString()+ ".txt");

            string str = "asdas";
            int i = 0, k = 0;
            while (true)
            {
                str = objReader.ReadLine();
                if (str == null) break;
                // 
                k = str.IndexOf(" ");
                word[i] = str.Substring(0, k);
                String temp = str.Substring(k, str.Length - k);
                //MessageBox.Show(temp.ToString() );
                //char [] ch= {' ','\t','\n'};
                //temp.TrimStart(ch);
                char[] ch = temp.ToCharArray();
                int j = 0;
                while (ch[j] == ' ')
                {
                    ++j;
                }
                // MessageBox.Show(j.ToString());
                meaning[i++] = temp.Substring(j);
            }
            str = "";
            for (int j = 0; j < i; j++)
                str = str + meaning[j] + "\n";

            //MessageBox.Show(str.ToString());
            //richTextBox1.Text = str;
            global_count = i;
            count = i;
            objReader.Close();


             SelectTest.Visible = true;


           // LearnWordList.Checked = true;
            //MultipleChoice.Checked = false;
            LearnWordList.Checked = false;
            Radiobuttopnmulchoice.Checked = false;
           // reverseChallenge.Checked = false;
            radioButton4.Checked = false;

            groupBoxLearnWordList.Visible = false;
            groupBoxMultipleChoice.Visible = false;
            groupBoxReverseChallenge.Visible = false;
           // panel1.Visible = false;
         // MessageBox.Show("LoadingForm");
        
        }

        private void Radiobuttopnmulchoice_CheckedChanged(object sender, EventArgs e)
        {
            for (int k = 0; k < global_count; k++) questionsAnswer_status[k] = 0;
            rightAnsCounter = 0;

            labelrevtimercounter.Text = "0";
            revtimerCounter = 0;
            for(int i=0;i<=100;i++)word_status[i]=0;
            
            groupBoxReverseChallenge.Visible = false;
            groupBoxLearnWordList.Visible = false;
            SelectTest.Visible = false;

            LabelMulQuesStatus.Text = "";
            labelMulchoiceResult.Visible = false;
            scorecalculator = 0;
            label1.Text = "";
            button1.Text = "Next";
            rightAns = false;
            count = global_count;
            mulChoiceCounter = 0;
            mulChoice1.Checked = false;
            mulChoice2.Checked = false;
            mulChoice3.Checked = false;
            mulChoice4.Checked = false;
            mulChoice5.Checked = false;


            timer1.Start();
            newMultipleChoiceQuestion();
        }

        private void buttonReverseChallanageNext_Click(object sender, EventArgs e)
        {
            
           //MessageBox.Show(questionsAnswer_status[rightAnsCounter].ToString());
            
            mullchoicetimerCounter = 0;
            buttonGo.Visible = false;
            TEXTFORREVCOUNTER.Text = "0";
            timer2.Stop();
            if (buttonReverseChallanageNext.Text == "Exit")
            {
                groupBoxReverseChallenge.Visible = false;
                SelectTest.Visible = true;

            }
            else {
                if(rightAns==true)
                ++scorecalculator;
            }
            if (revmulChoiceCounter == count)
            {
                final_revresult();
                buttonReverseChallanageNext.Text = "Exit";
             }
            else
            {
               // 
                reversechoiceoption1.Checked = false;
                reversechoiceoption2.Checked = false;
                reversechoiceoption3.Checked = false;
                reversechoiceoption4.Checked = false;
                reversechoiceoption5.Checked = false;
                label3ReversechoiceResult.Text = "";
                labelReverseChoice.Visible = false;
                rightAns = false;
                
                labelReveseChallangeStatus.Text = "Counter: "+(revmulChoiceCounter + 1) + "/" + global_count;
                if (revmulChoiceCounter != count) { timer2.Start(); newRevMultipleChoiceQuestion(); }
            }
        }

        private void reversechoiceoption1_CheckedChanged(object sender, EventArgs e)
        {
            labelReverseChoice.Visible = true;
            try
            {
                if (reversechoiceoption1.Text == word[RevchallangeAns_Index]) { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Green; label3ReversechoiceResult.Text = "Correct";

                    if (questionsAnswer_status[rightAnsCounter] == 0)
                        {
                            questionsAnswer_status[rightAnsCounter] = 1;
                            // MessageBox.Show("aaaaaaaaaaaaaaa");
                            rightAns = true;
                          //  MessageBox.Show("1Y"+rightAnsCounter.ToString()+"   "+rightAnsCounter.ToString());
                        }
                        else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                        else
                        {
                            questionsAnswer_status[rightAnsCounter] = 5;
                            MessageBox.Show("1");
                        }
                }
                else
                { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Red; label3ReversechoiceResult.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
               // MessageBox.Show(revmulChoiceCounter.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show("Exception:"+ex.ToString());
            }
        }

        private void reversechoiceoption2_CheckedChanged(object sender, EventArgs e)
        {
            labelReverseChoice.Visible = true;
            try
            {
               // MessageBox.Show("aaaaaaaaaaaaaaa");
                if (reversechoiceoption2.Text == word[RevchallangeAns_Index])
                {
                    label3ReversechoiceResult.ForeColor = System.Drawing.Color.Green; label3ReversechoiceResult.Text = "Correct";

                    if (questionsAnswer_status[rightAnsCounter] == 0)
                    {
                        questionsAnswer_status[rightAnsCounter] = 1;
                        rightAns = true;
                       // MessageBox.Show("2Y" + rightAnsCounter.ToString());
                    }
                    else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                    else
                    {
                        questionsAnswer_status[rightAnsCounter] = 5;
                      //  MessageBox.Show("2");
                    }
                }
                else
                { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Red; label3ReversechoiceResult.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void reversechoiceoption3_CheckedChanged(object sender, EventArgs e)
        {
            labelReverseChoice.Visible = true;
            try
            {
                if (reversechoiceoption3.Text == word[RevchallangeAns_Index])
                {
                    label3ReversechoiceResult.ForeColor = System.Drawing.Color.Green; label3ReversechoiceResult.Text = "Correct";

                    if (questionsAnswer_status[rightAnsCounter] == 0)
                    {
                        questionsAnswer_status[rightAnsCounter] = 1;
                        rightAns = true;
                    }
                    else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                    else
                    {
                        questionsAnswer_status[rightAnsCounter] = 5;
                      //  MessageBox.Show("3");
                    }
                }
                else
                { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Red; label3ReversechoiceResult.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void reversechoiceoption4_CheckedChanged(object sender, EventArgs e)
        {
            labelReverseChoice.Visible = true;
            try
            {
                if (reversechoiceoption4.Text == word[RevchallangeAns_Index])
                {
                    label3ReversechoiceResult.ForeColor = System.Drawing.Color.Green; label3ReversechoiceResult.Text = "Correct";

                    if (questionsAnswer_status[rightAnsCounter] == 0)
                    {
                        questionsAnswer_status[rightAnsCounter] = 1;
                        rightAns = true;
                    }
                    else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                    else
                    {
                        questionsAnswer_status[rightAnsCounter] = 5;
                    }
                }
                else
                { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Red; label3ReversechoiceResult.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void reversechoiceoption5_CheckedChanged(object sender, EventArgs e)
        {
            labelReverseChoice.Visible = true;
            try
            {
                if (reversechoiceoption5.Text == word[RevchallangeAns_Index])
                {
                    label3ReversechoiceResult.ForeColor = System.Drawing.Color.Green; label3ReversechoiceResult.Text = "Correct";

                    if (questionsAnswer_status[rightAnsCounter] == 0)
                    {
                        questionsAnswer_status[rightAnsCounter] = 1;
                        rightAns = true;
                    }
                    else if (questionsAnswer_status[rightAnsCounter] == 1) { }
                    else
                    {
                        questionsAnswer_status[rightAnsCounter] = 5;
                    }
                }
                else
                { label3ReversechoiceResult.ForeColor = System.Drawing.Color.Red; label3ReversechoiceResult.Text = "Wrong."; rightAns = false; questionsAnswer_status[rightAnsCounter] = 5; }
            }
            catch (Exception ex) {
                MessageBox.Show("Exception occured:" + ex.ToString());
            }
        }

        private void groupBoxMultipleChoice_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3ReversechoiceResult_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             
            HotWords hwrd = new HotWords();
            hwrd.wordlistNum = wordlistnumber;
            hwrd.wordListIdenty = wordlistIdentity;
            hwrd.global_counts = global_count;
            hwrd.words = word;
            hwrd.meanings = meaning;
            this.Dispose();
            hwrd.ShowDialog();
            
            hwrd.Focus();
          //  this.dis
        
        }

        private void flipwords_CheckedChanged(object sender, EventArgs e)
        {
            Flip_Words hwrd = new Flip_Words();
            hwrd.wordlistNum = wordlistnumber;
            hwrd.wordListIdenty = wordlistIdentity;
            hwrd.global_counts = global_count;
            hwrd.words = word;
            hwrd.meanings = meaning;
            this.Dispose();
            hwrd.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxReverseChallenge.Visible = false;
            SelectTest.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBoxMultipleChoice.Visible = false;
            SelectTest.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FrontScreen fs = new FrontScreen();
            this.Dispose();
            //fs.ShowDialog();
        }

        private void groupBoxReverseChallenge_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Help abt = new Help();
            abt.flag = 1;
            abt.wordlistNum = wordlistnumber;
            abt.wordListIdenty = wordlistIdentity;
            this.Dispose();
            abt.ShowDialog();
            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = global::WindowsApplication1.Properties.Resources.text_home;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsApplication1.Properties.Resources.home_icon;
            pictureBox1.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox2.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreenText_Help;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = global::WindowsApplication1.Properties.Resources.help_icon1;
            pictureBox2.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
           // pictureBox3.Image = null;
           // pictureBox3.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_Text_About;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox3.Image = global::WindowsApplication1.Properties.Resources.user_icon;
           // pictureBox3.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
            mullchoicetimerCounter = 0;
            TEXTFORREVCOUNTER.Visible = true;

            labelReverseChoice.Visible=false;
            labelRevereChallengeWord.Visible = true;
            reversechoiceoption1.Visible = true;
            reversechoiceoption2.Visible = true;
            reversechoiceoption3.Visible = true;
            reversechoiceoption4.Visible = true;
            reversechoiceoption5.Visible = true;
            buttonReverseChallanageNext.Visible = true;
            button2.Visible = true;
            labelReveseChallangeStatus.Visible = true;
            labelReverseChoice.Visible = true;
            label3ReversechoiceResult.Visible = true;
            newRevMultipleChoiceQuestion();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        //    global_count = Int32.Parse(textBox1.Text);
         //   headerLabel.Text = word[Int32.Parse(textBox1.Text)];
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }



    }
}