using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Help : Form
    {
        
        public Help()
        {
            InitializeComponent();
        }

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
        public int flag = 0;
        public int wordlistNum;
        public string wordListIdenty;
            
        
        private void Help_Load(object sender, EventArgs e)
        {
          //  button3.Visible = false;

            /* pictureBox1.Image= global::WindowsApplication1.Properties.Resources._1;
           //abc();
            DateTime dt1 = DateTime.Now;
            int diff = 0;

            for (int a = 0; a < 30000; a++) for (int a1 = 0; a1 < 30000; a1++) { }
                               
               pictureBox1.Image = global::WindowsApplication1.Properties.Resources._3;

               for (int a = 0; a < 30000; a++) for (int a1 = 0; a1 < 30000; a1++) { }
               pictureBox1.Image = global::WindowsApplication1.Properties.Resources._1;
               /*while (diff < 3)
            {

                DateTime dt2 = DateTime.Now;
                TimeSpan ts = dt2.Subtract(dt1);
                pictureBox1.Image = global::WindowsApplication1.Properties.Resources._1;
                diff = (int)ts.TotalSeconds;
                
                //Application.DoEvents();

            }*/

            
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            int counter = 0;
            for (int k1 = 1; k1<= 25;k1++ ) {

                StreamReader objReader = new StreamReader("E:\\TextGre\\me\\" + k1.ToString() + ".txt");

                string str = "asdas";
                int i = 0, k = 0;
                while (true)
                {
                    str = objReader.ReadLine();
                    try
                    {
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
                    catch (Exception ex) { 
                        MessageBox.Show("Exception occured:"+ex.ToString());
                    }
                }
                str = "";
                for (int j = 0; j < i; j++)
                    str = str + meaning[j] + "\n";

                //MessageBox.Show(str.ToString());
                //richTextBox1.Text = str;
                counter = counter+i;
                i = 0;
                objReader.Close();


            
            }
           // button1.Text = counter.ToString();
           
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 1)
            {
                NewWordlist nwd = new NewWordlist();
                nwd.wordlistnumber = wordlistNum;
                nwd.wordlistIdentity = wordListIdenty;
                nwd.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.Visible = false;
           // button3.Visible = true;
           // this.BackgroundImage = global::WindowsApplication1.Properties.Resources.Help2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // button3.Visible = false;
          //  button2.Visible = true;
          //  this.BackgroundImage = global::WindowsApplication1.Properties.Resources.Help1;
        }
    }
}