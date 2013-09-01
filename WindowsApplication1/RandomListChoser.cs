using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class RandomListChoser : Form
    {
        public int counter = 0;
        public int counter1 = 0;
        public int firstDigit;
        public int secondDigit;
        int flag = 0;
        public RandomListChoser()
        {
            InitializeComponent();
        }

        private void RandomListChoser_Load(object sender, EventArgs e)
        {
            load_number();
        }
        public void load_number() {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            timer2.Interval = 100;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0,721);
                randomNumber = randomNumber % 6;
                if (randomNumber == 0) { pictureBox1.Image = global::WindowsApplication1.Properties.Resources._0; firstDigit = 0; }
                if (randomNumber == 1) { pictureBox1.Image = global::WindowsApplication1.Properties.Resources._1; firstDigit = 1; }
                if (randomNumber == 2) { pictureBox1.Image = global::WindowsApplication1.Properties.Resources._2; firstDigit = 2; }
                if (randomNumber == 3) { pictureBox1.Image = global::WindowsApplication1.Properties.Resources._3; firstDigit = 3; }
                if (randomNumber == 4) { pictureBox1.Image = global::WindowsApplication1.Properties.Resources._4; firstDigit = 4; }
                if (randomNumber == 5) { pictureBox1.Image = global::WindowsApplication1.Properties.Resources._5; firstDigit = 5; if (counter == 29)flag = 1; }
                ++counter;
                if (counter == 30) timer1.Stop();
                
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sender == timer2)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 200);
                randomNumber = randomNumber % 5;
                if (randomNumber == 0 ) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._0; secondDigit = 0; }
                if (randomNumber == 1 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._1; secondDigit = 1; }
                if (randomNumber == 2 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._2; secondDigit = 2; }
                if (randomNumber == 3 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._3; secondDigit = 3; }
                if (randomNumber == 4 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._4; secondDigit = 4; }
                if (randomNumber == 5&& flag!=1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._5; secondDigit = 5; }
                if (randomNumber == 6 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._6; secondDigit = 6; }
                if (randomNumber == 7 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._7; secondDigit = 7; }
                if (randomNumber == 8 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._8; secondDigit = 8; }
                if (randomNumber == 9 && flag != 1) { pictureBox2.Image = global::WindowsApplication1.Properties.Resources._9; secondDigit = 9; }

                ++counter1;
                if (counter1 == 40) { 
                    timer2.Stop();
                    
                    if (firstDigit.ToString() + secondDigit.ToString() == "00") {
                        pictureBox1.Image = global::WindowsApplication1.Properties.Resources._0; firstDigit = 0;
                        pictureBox2.Image = global::WindowsApplication1.Properties.Resources._1; secondDigit = 1; 
                    }
                    
                    button1.Visible = true; 
                    button1.Text = "Go WordList: " + firstDigit.ToString() + secondDigit.ToString();
                    label1.Visible = true;
                    label1.Text = "Random generator suggesting Word List: " + firstDigit.ToString() + secondDigit.ToString();
                    FrontScreen fnt = new FrontScreen();
                    int number = Int32.Parse(firstDigit.ToString() + secondDigit.ToString());


                    if (number ==1)
                    {
                        button1.Click +=new System.EventHandler(fnt.label1_Click);
                    }

                    if (number ==2)
                    {
                        button1.Click += new System.EventHandler(fnt.label2_Click);
                    }
                    if (number ==3)
                    {
                        button1.Click += new System.EventHandler(fnt.label3_Click);
                    }
                    if (number ==4)
                    {
                        button1.Click += new System.EventHandler(fnt.label4_Click);
                    }
                    if (number ==5)
                    {
                        button1.Click += new System.EventHandler(fnt.label5_Click);
                    }
                    if (number ==6)
                    {
                        button1.Click += new System.EventHandler(fnt.label6_Click);
                    }
                    if (number ==7)
                    {
                        button1.Click += new System.EventHandler(fnt.label7_Click);
                    }
                    if (number ==8)
                    {
                        button1.Click += new System.EventHandler(fnt.label8_Click);
                    }
                    if (number ==9)
                    {
                        button1.Click += new System.EventHandler(fnt.label9_Click);
                    }
                    if (number ==10)
                    {
                        button1.Click += new System.EventHandler(fnt.label10_Click);
                    }
                    if (number ==11)
                    {
                        button1.Click += new System.EventHandler(fnt.label20_Click);
                    }
                    if (number ==12)
                    {
                        button1.Click += new System.EventHandler(fnt.label19_Click);
                    }
                    if (number ==13)
                    {
                        button1.Click += new System.EventHandler(fnt.label18_Click);
                    }
                    if (number ==14)
                    {
                        button1.Click += new System.EventHandler(fnt.label17_Click);
                    }
                    if (number ==15)
                    {
                        button1.Click += new System.EventHandler(fnt.label16_Click);
                    }
                    if (number ==16)
                    {
                        button1.Click += new System.EventHandler(fnt.label15_Click);
                    }
                    if (number ==17)
                    {
                        button1.Click += new System.EventHandler(fnt.label14_Click);
                    }
                    if (number ==18)
                    {
                        button1.Click += new System.EventHandler(fnt.label13_Click);
                    }
                    if (number ==19)
                    {
                        button1.Click += new System.EventHandler(fnt.label12_Click);
                    }
                    if (number ==20)
                    {
                        button1.Click += new System.EventHandler(fnt.label11_Click);
                    }
                    if (number ==21)
                    {
                        button1.Click += new System.EventHandler(fnt.label30_Click);
                    }
                    if (number ==22)
                    {
                        button1.Click += new System.EventHandler(fnt.label29_Click);
                    }
                    if (number ==23)
                    {
                        button1.Click += new System.EventHandler(fnt.label28_Click);
                    }
                    if (number ==24)
                    {
                        button1.Click += new System.EventHandler(fnt.label27_Click);
                    }
                    if (number ==25)
                    {
                        button1.Click += new System.EventHandler(fnt.label26_Click);
                    }
                    if (number ==26)
                    {
                        button1.Click +=new System.EventHandler(fnt.label25_Click);
                    }
                    if (number ==27)
                    {
                        button1.Click += new System.EventHandler(fnt.label24_Click);
                    }
                    if (number ==28)
                    {
                        button1.Click += new System.EventHandler(fnt.label23_Click);
                    }
                    if (number ==29)
                    {
                        button1.Click += new System.EventHandler(fnt.label22_Click);
                    }
                    if (number ==30)
                    {
                        button1.Click += new System.EventHandler(fnt.label21_Click);
                    }

                   if (number ==31)
                    {
                        button1.Click += new System.EventHandler(fnt.label40_Click);
                    }
                    if (number ==32)
                    {
                        button1.Click += new System.EventHandler(fnt.label39_Click);
                    }
                    if (number ==33)
                    {
                        button1.Click += new System.EventHandler(fnt.label38_Click);
                    }
                    if (number ==34)
                    {
                        button1.Click += new System.EventHandler(fnt.label37_Click);
                    }
                    if (number ==35)
                    {
                        button1.Click += new System.EventHandler(fnt.label36_Click);
                    }
                    if (number ==36)
                    {
                        button1.Click += new System.EventHandler(fnt.label35_Click);
                    }
                    if (number ==37)
                    {
                        button1.Click += new System.EventHandler(fnt.label34_Click);
                    }
                    if (number ==38)
                    {
                        button1.Click += new System.EventHandler(fnt.label33_Click);
                    }
                    if (number ==39)
                    {
                        button1.Click += new System.EventHandler(fnt.label32_Click);

                    }
                    if (number ==40)
                    {
                        button1.Click += new System.EventHandler(fnt.label31_Click);
                    }

                    if (number ==41)
                    {
                        button1.Click += new System.EventHandler(fnt.label50_Click);
                    }
                    if (number ==42)
                    {
                        button1.Click += new System.EventHandler(fnt.label49_Click);
                    }
                    
                    if (number ==43)
                    {
                        button1.Click += new System.EventHandler(fnt.label48_Click);
                    }
                    if (number ==44)
                    {
                        button1.Click +=new System.EventHandler(fnt.label47_Click);
                    }
                    if (number ==45)
                    {
                        button1.Click +=new System.EventHandler(fnt.label46_Click);
                    }
                    if (number ==46)
                    {
                        button1.Click +=new System.EventHandler(fnt.label45_Click);
                    }
                    if (number ==47)
                    {
                        button1.Click +=new System.EventHandler(fnt.label44_Click);
                    }
                    if (number ==48)
                    {
                        button1.Click += new System.EventHandler(fnt.label43_Click);
                    }
                    if (number ==49)
                    {
                        button1.Click += new System.EventHandler(fnt.label42_Click);
                    }
                    if (number ==50)
                    {
                        button1.Click +=new System.EventHandler(fnt.label41_Click);
                    }

                }

            }
        }
    }
}