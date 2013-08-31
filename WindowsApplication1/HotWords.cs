// This is for Words Jam

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class HotWords : Form
    {
        public int wordlistNum;
        public string wordListIdenty;
        public string[] words = new string[10000];
        public int[] words_assaignment = new int[10000];
        public string[] meanings = new string[10000];
        int[] label_status = new int[1000];
        int[] meaning_status = new int[1000];
        public int global_counts;
        public int flag = 0;
        public int refilling_counter;
        public string isword = "";
        public string ismeaning = "";
        public int[] label_1_10Select ={ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] label_11_20Select ={ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string backcolor = System.Drawing.Color.SkyBlue.ToString();
        public string selectebackcolor = System.Drawing.Color.Yellow.ToString();
        public int No_of_current_Jams;

        public HotWords()
        {
            InitializeComponent();
        }



        private void HotWords_Load(object sender, EventArgs e)
        {
            labelHeader.Text = "Words Jam> Word List: " + wordlistNum.ToString() + " ("+  wordListIdenty + ")";

            for (int i = 0; i < global_counts; i++)
            {
                words_assaignment[i] = 0;
            }
            refilling_counter = global_counts;

            //if (refilling_counter < 0) ;
            if (refilling_counter < 10) { }//load_words(n);
            else
            {
                load_words(10);
                refilling_counter = refilling_counter - 10;
            }
        }


        public void load_words(int n)
        {
            int terminator = 0;
            for (int j = 0; j < 10; j++) { label_status[j] = 200; }
            Random rand_number = new Random();
            while (terminator < n)
            {
                int random = rand_number.Next(0, 150);
                int index = random % global_counts;
                if (words_assaignment[index] == 0)
                {
                    if (label_status[0] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[0] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[1] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[1] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[2] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[2] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[3] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[3] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[4] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[4] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[5] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[5] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[6] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[6] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[7] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[7] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[8] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[8] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }
                    if (label_status[9] == 200 && words_assaignment[index] == 0)
                    {
                        label_status[9] = index;
                        ++terminator;
                        words_assaignment[index] = 1;
                    }

                }
            }
            label1.Text = words[label_status[0]]; label2.Text = words[label_status[1]]; label3.Text = words[label_status[2]];
            label4.Text = words[label_status[3]]; label5.Text = words[label_status[4]]; label6.Text = words[label_status[5]];
            label7.Text = words[label_status[6]]; label8.Text = words[label_status[7]]; label9.Text = words[label_status[8]];
            label10.Text = words[label_status[9]];

            load_meaning(label_status, 10);

            richTextBox1.Text = "\n\n\n\nYou are on Jam No." + (++No_of_current_Jams) + "\nof " + (global_counts / 10);
        }

        public void load_meaning(int[] label_status, int n)
        {
            int terminator = 0;
            for (int j = 0; j < 10; j++) { meaning_status[j] = 200; }
            int[] refill_of_meaning ={ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Random rand_number = new Random();
            while (terminator < n)
            {
                int random = rand_number.Next(0, 150);
                int index = random % 10;
                if (meaning_status[0] == 200 && refill_of_meaning[index] == 0)
                {
                    label11.Text = meanings[label_status[index]];
                    label11.Tag = index;
                    ++terminator;
                    meaning_status[0] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[1] == 200 && refill_of_meaning[index] == 0)
                {
                    label12.Text = meanings[label_status[index]];
                    label12.Tag = index;
                    ++terminator;
                    meaning_status[1] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[2] == 200 && refill_of_meaning[index] == 0)
                {
                    label13.Text = meanings[label_status[index]];
                    label13.Tag = index;
                    ++terminator;
                    meaning_status[2] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[3] == 200 && refill_of_meaning[index] == 0)
                {
                    label14.Text = meanings[label_status[index]];
                    label14.Tag = index;
                    ++terminator;
                    meaning_status[3] = 1;
                    refill_of_meaning[index] = 1;

                }
                if (meaning_status[4] == 200 && refill_of_meaning[index] == 0)
                {
                    label15.Text = meanings[label_status[index]];
                    label15.Tag = index;
                    ++terminator;
                    meaning_status[4] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[5] == 200 && refill_of_meaning[index] == 0)
                {
                    label16.Text = meanings[label_status[index]];
                    label16.Tag = index;
                    ++terminator;
                    meaning_status[5] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[6] == 200 && refill_of_meaning[index] == 0)
                {
                    label17.Text = meanings[label_status[index]];
                    label17.Tag = index;
                    ++terminator;
                    meaning_status[6] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[7] == 200 && refill_of_meaning[index] == 0)
                {
                    label18.Text = meanings[label_status[index]];
                    label18.Tag = index;
                    ++terminator;
                    meaning_status[7] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[8] == 200 && refill_of_meaning[index] == 0)
                {
                    label19.Text = meanings[label_status[index]];
                    label19.Tag = index;
                    ++terminator;
                    meaning_status[8] = 1;
                    refill_of_meaning[index] = 1;
                }
                if (meaning_status[9] == 200 && refill_of_meaning[index] == 0)
                {
                    label20.Text = meanings[label_status[index]];
                    label20.Tag = index;
                    ++terminator;
                    meaning_status[9] = 1;
                    refill_of_meaning[index] = 1;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true; label1.BackColor = System.Drawing.Color.Yellow; label2.Visible = true; label2.BackColor = System.Drawing.Color.Yellow; label3.Visible = true; label3.BackColor = System.Drawing.Color.Yellow; label4.Visible = true; label4.BackColor = System.Drawing.Color.Yellow; label5.Visible = true; label5.BackColor = System.Drawing.Color.Yellow; label6.Visible = true; label6.BackColor = System.Drawing.Color.Yellow; label7.Visible = true; label7.BackColor = System.Drawing.Color.Yellow; label8.Visible = true; label8.BackColor = System.Drawing.Color.Yellow; label9.Visible = true; label9.BackColor = System.Drawing.Color.Yellow; label10.Visible = true; label10.BackColor = System.Drawing.Color.Yellow;
            label11.Visible = true; label11.BackColor = System.Drawing.Color.Yellow; label12.Visible = true; label12.BackColor = System.Drawing.Color.Yellow; label13.Visible = true; label13.BackColor = System.Drawing.Color.Yellow; label14.Visible = true; label14.BackColor = System.Drawing.Color.Yellow; label15.Visible = true; label15.BackColor = System.Drawing.Color.Yellow; label16.Visible = true; label16.BackColor = System.Drawing.Color.Yellow; label17.Visible = true; label17.BackColor = System.Drawing.Color.Yellow; label18.Visible = true; label18.BackColor = System.Drawing.Color.Yellow; label19.Visible = true; label19.BackColor = System.Drawing.Color.Yellow; label20.Visible = true; label20.BackColor = System.Drawing.Color.Yellow;
            if (refilling_counter < 10) { groupBox1.Visible = false; panel1.Visible = true; buttongoforoptions.Visible = true; richTextBox1.Visible = false; }//load_words(n);
            else
            {
                load_words(10);
                refilling_counter = refilling_counter - 10;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(0);
            label_1_10Select[0] = 1; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[0]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }
            if (selectindex == 0 && ismeaning == meanings[label_status[0]]) { label11.Visible = false; label1.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[0]]) { label12.Visible = false; label1.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[0]]) { label13.Visible = false; label1.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[0]]) { label14.Visible = false; label1.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[0]]) { label15.Visible = false; label1.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[0]]) { label16.Visible = false; label1.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[0]]) { label17.Visible = false; label1.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[0]]) { label18.Visible = false; label1.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[0]]) { label19.Visible = false; label1.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[0]]) { label20.Visible = false; label1.Visible = false; }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(1);
            label_1_10Select[0] = 0; label_1_10Select[1] = 1; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[1]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }
            if (selectindex == 0 && ismeaning == meanings[label_status[1]]) { label11.Visible = false; label2.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[1]]) { label12.Visible = false; label2.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[1]]) { label13.Visible = false; label2.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[1]]) { label14.Visible = false; label2.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[1]]) { label15.Visible = false; label2.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[1]]) { label16.Visible = false; label2.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[1]]) { label17.Visible = false; label2.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[1]]) { label18.Visible = false; label2.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[1]]) { label19.Visible = false; label2.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[1]]) { label20.Visible = false; label2.Visible = false; }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(2);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 1; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[2]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[2]]) { label11.Visible = false; label3.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[2]]) { label12.Visible = false; label3.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[2]]) { label13.Visible = false; label3.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[2]]) { label14.Visible = false; label3.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[2]]) { label15.Visible = false; label3.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[2]]) { label16.Visible = false; label3.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[2]]) { label17.Visible = false; label3.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[2]]) { label18.Visible = false; label3.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[2]]) { label19.Visible = false; label3.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[2]]) { label20.Visible = false; label3.Visible = false; }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(3);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 1; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[3]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[3]]) { label11.Visible = false; label4.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[3]]) { label12.Visible = false; label4.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[3]]) { label13.Visible = false; label4.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[3]]) { label14.Visible = false; label4.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[3]]) { label15.Visible = false; label4.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[3]]) { label16.Visible = false; label4.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[3]]) { label17.Visible = false; label4.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[3]]) { label18.Visible = false; label4.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[3]]) { label19.Visible = false; label4.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[3]]) { label20.Visible = false; label4.Visible = false; }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(4);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 1;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[4]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[4]]) { label11.Visible = false; label5.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[4]]) { label12.Visible = false; label5.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[4]]) { label13.Visible = false; label5.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[4]]) { label14.Visible = false; label5.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[4]]) { label15.Visible = false; label5.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[4]]) { label16.Visible = false; label5.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[4]]) { label17.Visible = false; label5.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[4]]) { label18.Visible = false; label5.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[4]]) { label19.Visible = false; label5.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[4]]) { label20.Visible = false; label5.Visible = false; }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(5);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 1; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[5]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[5]]) { label11.Visible = false; label6.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[5]]) { label12.Visible = false; label6.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[5]]) { label13.Visible = false; label6.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[5]]) { label14.Visible = false; label6.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[5]]) { label15.Visible = false; label6.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[5]]) { label16.Visible = false; label6.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[5]]) { label17.Visible = false; label6.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[5]]) { label18.Visible = false; label6.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[5]]) { label19.Visible = false; label6.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[5]]) { label20.Visible = false; label6.Visible = false; }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(6);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 1; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[6]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }
            if (selectindex == 0 && ismeaning == meanings[label_status[6]]) { label11.Visible = false; label7.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[6]]) { label12.Visible = false; label7.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[6]]) { label13.Visible = false; label7.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[6]]) { label14.Visible = false; label7.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[6]]) { label15.Visible = false; label7.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[6]]) { label16.Visible = false; label7.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[6]]) { label17.Visible = false; label7.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[6]]) { label18.Visible = false; label7.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[6]]) { label19.Visible = false; label7.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[6]]) { label20.Visible = false; label7.Visible = false; }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(7);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 1; label_1_10Select[8] = 0; label_1_10Select[9] = 0;
            isword = words[label_status[7]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[7]]) { label11.Visible = false; label8.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[7]]) { label12.Visible = false; label8.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[7]]) { label13.Visible = false; label8.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[7]]) { label14.Visible = false; label8.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[7]]) { label15.Visible = false; label8.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[7]]) { label16.Visible = false; label8.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[7]]) { label17.Visible = false; label8.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[7]]) { label18.Visible = false; label8.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[7]]) { label19.Visible = false; label8.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[7]]) { label20.Visible = false; label8.Visible = false; }


        }

        private void label9_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(8);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 1; label_1_10Select[9] = 0;
            isword = words[label_status[8]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[8]]) { label11.Visible = false; label9.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[8]]) { label12.Visible = false; label9.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[8]]) { label13.Visible = false; label9.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[8]]) { label14.Visible = false; label9.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[8]]) { label15.Visible = false; label9.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[8]]) { label16.Visible = false; label9.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[8]]) { label17.Visible = false; label9.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[8]]) { label18.Visible = false; label9.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[8]]) { label19.Visible = false; label9.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[8]]) { label20.Visible = false; label9.Visible = false; }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            setcolor1LabelTO20(9);
            label_1_10Select[0] = 0; label_1_10Select[1] = 0; label_1_10Select[2] = 0; label_1_10Select[3] = 0; label_1_10Select[4] = 0;
            label_1_10Select[5] = 0; label_1_10Select[6] = 0; label_1_10Select[7] = 0; label_1_10Select[8] = 0; label_1_10Select[9] = 1;
            isword = words[label_status[9]];

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_11_20Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && ismeaning == meanings[label_status[9]]) { label11.Visible = false; label10.Visible = false; }
            if (selectindex == 1 && ismeaning == meanings[label_status[9]]) { label12.Visible = false; label10.Visible = false; }
            if (selectindex == 2 && ismeaning == meanings[label_status[9]]) { label13.Visible = false; label10.Visible = false; }
            if (selectindex == 3 && ismeaning == meanings[label_status[9]]) { label14.Visible = false; label10.Visible = false; }
            if (selectindex == 4 && ismeaning == meanings[label_status[9]]) { label15.Visible = false; label10.Visible = false; }
            if (selectindex == 5 && ismeaning == meanings[label_status[9]]) { label16.Visible = false; label10.Visible = false; }
            if (selectindex == 6 && ismeaning == meanings[label_status[9]]) { label17.Visible = false; label10.Visible = false; }
            if (selectindex == 7 && ismeaning == meanings[label_status[9]]) { label18.Visible = false; label10.Visible = false; }
            if (selectindex == 8 && ismeaning == meanings[label_status[9]]) { label19.Visible = false; label10.Visible = false; }
            if (selectindex == 9 && ismeaning == meanings[label_status[9]]) { label20.Visible = false; label10.Visible = false; }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(0);
            label_11_20Select[0] = 1; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label11.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }
            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label1.Visible = false; label11.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label2.Visible = false; label11.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label3.Visible = false; label11.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label4.Visible = false; label11.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label5.Visible = false; label11.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label6.Visible = false; label11.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label7.Visible = false; label11.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label8.Visible = false; label11.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label9.Visible = false; label11.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label11.Tag.ToString())]]) { label10.Visible = false; label11.Visible = false; }

        }

        private void label12_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(1);
            label_11_20Select[0] = 0; label_11_20Select[1] = 1; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label12.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }
            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label1.Visible = false; label12.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label2.Visible = false; label12.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label3.Visible = false; label12.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label4.Visible = false; label12.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label5.Visible = false; label12.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label6.Visible = false; label12.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label7.Visible = false; label12.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label8.Visible = false; label12.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label9.Visible = false; label12.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label12.Tag.ToString())]]) { label10.Visible = false; label12.Visible = false; }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(2);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 1; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label13.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label1.Visible = false; label13.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label2.Visible = false; label13.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label3.Visible = false; label13.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label4.Visible = false; label13.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label5.Visible = false; label13.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label6.Visible = false; label13.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label7.Visible = false; label13.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label8.Visible = false; label13.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label9.Visible = false; label13.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label13.Tag.ToString())]]) { label10.Visible = false; label13.Visible = false; }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(3);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 1; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label14.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label1.Visible = false; label14.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label2.Visible = false; label14.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label3.Visible = false; label14.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label4.Visible = false; label14.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label5.Visible = false; label14.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label6.Visible = false; label14.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label7.Visible = false; label14.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label8.Visible = false; label14.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label9.Visible = false; label14.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label14.Tag.ToString())]]) { label10.Visible = false; label14.Visible = false; }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(4);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 1;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label15.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label1.Visible = false; label15.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label2.Visible = false; label15.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label3.Visible = false; label15.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label4.Visible = false; label15.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label5.Visible = false; label15.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label6.Visible = false; label15.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label7.Visible = false; label15.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label8.Visible = false; label15.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label9.Visible = false; label15.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label15.Tag.ToString())]]) { label10.Visible = false; label15.Visible = false; }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(5);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 1; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label16.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label1.Visible = false; label16.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label2.Visible = false; label16.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label3.Visible = false; label16.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label4.Visible = false; label16.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label5.Visible = false; label16.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label6.Visible = false; label16.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label7.Visible = false; label16.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label8.Visible = false; label16.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label9.Visible = false; label16.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label16.Tag.ToString())]]) { label10.Visible = false; label16.Visible = false; }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(6);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 1; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label17.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label1.Visible = false; label17.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label2.Visible = false; label17.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label3.Visible = false; label17.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label4.Visible = false; label17.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label5.Visible = false; label17.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label6.Visible = false; label17.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label7.Visible = false; label17.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label8.Visible = false; label17.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label9.Visible = false; label17.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label17.Tag.ToString())]]) { label10.Visible = false; label17.Visible = false; }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(7);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 1; label_11_20Select[8] = 0;
            label_11_20Select[9] = 0;

            ismeaning = label18.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label1.Visible = false; label18.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label2.Visible = false; label18.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label3.Visible = false; label18.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label4.Visible = false; label18.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label5.Visible = false; label18.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label6.Visible = false; label18.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label7.Visible = false; label18.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label8.Visible = false; label18.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label9.Visible = false; label18.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label18.Tag.ToString())]]) { label10.Visible = false; label18.Visible = false; }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(8);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 1;
            label_11_20Select[9] = 0;

            ismeaning = label19.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label1.Visible = false; label19.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label2.Visible = false; label19.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label3.Visible = false; label19.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label4.Visible = false; label19.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label5.Visible = false; label19.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label6.Visible = false; label19.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label7.Visible = false; label19.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label8.Visible = false; label19.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label9.Visible = false; label19.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label19.Tag.ToString())]]) { label10.Visible = false; label19.Visible = false; }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            setcolor1Label0TO20(9);
            label_11_20Select[0] = 0; label_11_20Select[1] = 0; label_11_20Select[2] = 0; label_11_20Select[3] = 0; label_11_20Select[4] = 0;
            label_11_20Select[5] = 0; label_11_20Select[6] = 0; label_11_20Select[7] = 0; label_11_20Select[8] = 0;
            label_11_20Select[9] = 1;

            ismeaning = label20.Text;

            int selectindex = 0;
            for (int i = 0; i < 10; i++)
            {
                if (label_1_10Select[i] == 1) selectindex = i;
            }

            if (selectindex == 0 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label1.Visible = false; label20.Visible = false; }
            if (selectindex == 1 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label2.Visible = false; label20.Visible = false; }
            if (selectindex == 2 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label3.Visible = false; label20.Visible = false; }
            if (selectindex == 3 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label4.Visible = false; label20.Visible = false; }
            if (selectindex == 4 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label5.Visible = false; label20.Visible = false; }
            if (selectindex == 5 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label6.Visible = false; label20.Visible = false; }
            if (selectindex == 6 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label7.Visible = false; label20.Visible = false; }
            if (selectindex == 7 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label8.Visible = false; label20.Visible = false; }
            if (selectindex == 8 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label9.Visible = false; label20.Visible = false; }
            if (selectindex == 9 && isword == words[label_status[Int32.Parse(label20.Tag.ToString())]]) { label10.Visible = false; label20.Visible = false; }
        }
        public void setcolor1LabelTO20(int i)
        {
            if (i == 0) { label1.BackColor = System.Drawing.Color.SkyBlue; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 1) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.SkyBlue; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 2) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.SkyBlue; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 3) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.SkyBlue; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 4) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.SkyBlue; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 5) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.SkyBlue; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 6) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.SkyBlue; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 7) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.SkyBlue; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 8) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.SkyBlue; label10.BackColor = System.Drawing.Color.Yellow; }
            if (i == 9) { label1.BackColor = System.Drawing.Color.Yellow; label2.BackColor = System.Drawing.Color.Yellow; label3.BackColor = System.Drawing.Color.Yellow; label4.BackColor = System.Drawing.Color.Yellow; label5.BackColor = System.Drawing.Color.Yellow; label6.BackColor = System.Drawing.Color.Yellow; label7.BackColor = System.Drawing.Color.Yellow; label8.BackColor = System.Drawing.Color.Yellow; label9.BackColor = System.Drawing.Color.Yellow; label10.BackColor = System.Drawing.Color.SkyBlue; }
        }
        public void setcolor1Label0TO20(int i)
        {
            if (i == 0) { label11.BackColor = System.Drawing.Color.SkyBlue; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 1) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.SkyBlue; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 2) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.SkyBlue; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 3) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.SkyBlue; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 4) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.SkyBlue; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 5) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.SkyBlue; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 6) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.SkyBlue; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 7) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.SkyBlue; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 8) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.SkyBlue; label20.BackColor = System.Drawing.Color.Yellow; }
            if (i == 9) { label11.BackColor = System.Drawing.Color.Yellow; label12.BackColor = System.Drawing.Color.Yellow; label13.BackColor = System.Drawing.Color.Yellow; label14.BackColor = System.Drawing.Color.Yellow; label15.BackColor = System.Drawing.Color.Yellow; label16.BackColor = System.Drawing.Color.Yellow; label17.BackColor = System.Drawing.Color.Yellow; label18.BackColor = System.Drawing.Color.Yellow; label19.BackColor = System.Drawing.Color.Yellow; label20.BackColor = System.Drawing.Color.SkyBlue; }
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