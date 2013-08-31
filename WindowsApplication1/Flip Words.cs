using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Flip_Words : Form
    {
        public string []words = new string[1000];
        public string []meanings = new string[1000];
        public int []words_status= new int [1000];
        public int wordlistNum;
        public string wordListIdenty;
        public int global_counts;
        public int currentMeaningIndex;
        public int counter = 0;

        public Flip_Words()
        {
            InitializeComponent();
        }

        private void Flip_Words_Load(object sender, EventArgs e)
        {
            labelHeader.Text = "Flip Words> Word List: " + wordlistNum.ToString() + " (" + wordListIdenty + ")";
            load_word();
        }
        public void load_word() {
            Random rand = new Random();
            int terminator = 0;

            while (terminator != 1)
            {
                int random_number = rand.Next() % global_counts;
                if (words_status[random_number] == 0) {
                    labelword.Text = words[random_number];
                    currentMeaningIndex = random_number;
                    terminator = 1;
                    words_status[random_number] = 1;
                    ++counter;
                    label1.Text = "Counter: " + counter + "/" + global_counts;
                }
            }
            
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Flip")
            {
                labelmeaningtitle.Visible = true;
                labelmeaning.Visible = true;
                labelmeaning.Text = meanings[currentMeaningIndex];
                
                button1.Text = "Next";
            }

            else if (button1.Text == "Next")
            {
                labelmeaning.Visible = false;
                labelmeaningtitle.Visible = false;
                if (counter == global_counts) { groupBox1.Visible = false; buttongoforoptions.Visible = true; panel1.Visible = true; }
                else
                {
                    load_word();
                }
                button1.Text = "Flip";
            }
            else { }
        }

        private void buttongoforoptions_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = wordlistNum;
            nwl.wordlistIdentity = wordListIdenty;
            nwl.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = wordlistNum;
            nwl.wordlistIdentity = wordListIdenty;
            nwl.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help hp = new Help();
            hp.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = wordlistNum;
            nwl.wordlistIdentity = wordListIdenty;
            nwl.Show();
            this.Close();
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
            pictureBox3.Image = null;
            pictureBox3.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_Text_Back;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = global::WindowsApplication1.Properties.Resources.back_icon;
            pictureBox3.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }
    }
}