using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
    public partial class FrontScreen : Form
    {
        public FrontScreen()
        {
            InitializeComponent();
        }

     
        // show help screen when user clicks at help picturebox
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Help hp = new Help();
            hp.ShowDialog();
        }

      
        // show the "Help" text when a mouse hover on help icon
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox2.BackgroundImage=global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreenText_Help;
        }

        // show the "Help" icon when a mouse hover left from the  "Help" text
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = global::WindowsApplication1.Properties.Resources.help_icon1;
            pictureBox2.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }

        // show the "Home" text when a mouse hover on Home icon
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = global::WindowsApplication1.Properties.Resources.text_home;
        }

        // show the "Home" icon when a mouse hover left from the  "Home" text
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            pictureBox1.Image = global::WindowsApplication1.Properties.Resources.home_icon;
            pictureBox1.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }

        // following codes deal with mouse hover, mouse leave from wordlist labels and click on a label.
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.BackColor = System.Drawing.Color.Yellow;
            label1.Text = "Abase-Adroit";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.BackColor = System.Drawing.Color.White;
            label1.Text = "Word List 01";
        }
        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.BackColor = System.Drawing.Color.Yellow;
            label2.Text = "Adulation-Amend";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.BackColor = System.Drawing.Color.White;
            label2.Text = "Word List 02";
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.BackColor = System.Drawing.Color.Yellow;
            label3.Text = "Amenities-Apothecary";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.BackColor = System.Drawing.Color.White;
            label3.Text = "Word List 03";
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.BackColor = System.Drawing.Color.Yellow;
            label4.Text = "Apothegm-Astagmatism";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.BackColor = System.Drawing.Color.White;
            label4.Text = "Word List 04";
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.BackColor = System.Drawing.Color.Yellow;
            label5.Text = "Astral-Barb";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.BackColor = System.Drawing.Color.White;
            label5.Text = "Word List 05";
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.BackColor = System.Drawing.Color.Yellow;
            label6.Text = "Bard-Bluff";
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.BackColor = System.Drawing.Color.White;
            label6.Text = "Word List 06";
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.BackColor = System.Drawing.Color.Yellow;
            label7.Text = "Blunder-Canter";
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {

            label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.BackColor = System.Drawing.Color.White;
            label7.Text = "Word List 07";
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.BackColor = System.Drawing.Color.Yellow;
            label8.Text = "Canto-Cameleon";
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.BackColor = System.Drawing.Color.White;
            label8.Text = "Word List 08";
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.BackColor = System.Drawing.Color.Yellow;
            label9.Text = "Chanpion-Colander";
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.BackColor = System.Drawing.Color.White;
            label9.Text = "Word List 09";
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.BackColor = System.Drawing.Color.Yellow;
            label10.Text = "Collaborate-Congenital";
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.BackColor = System.Drawing.Color.White;
            label10.Text = "Word List 10";
        }

        public void label1_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 1;
            nwl.wordlistIdentity = label1.Text;
            nwl.Show();

        }

        public void label20_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 11;
            nwl.wordlistIdentity = label20.Text;
            nwl.Show();
        }

        public void label19_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 12;
            nwl.wordlistIdentity = label19.Text;
            nwl.Show();
        }

        public void label18_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 13;
            nwl.wordlistIdentity = label18.Text;
            nwl.Show();
        }
        public void label17_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 14;
            nwl.wordlistIdentity = label17.Text;
            nwl.Show();
        }
        public void label16_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 15;
            nwl.wordlistIdentity = label16.Text;
            nwl.Show();
        }

        public void label15_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 16;
            nwl.wordlistIdentity = label15.Text;
            nwl.Show();
        }

        public void label14_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 17;
            nwl.wordlistIdentity = label14.Text;
            nwl.Show();
        }

        public void label13_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 18;
            nwl.wordlistIdentity = label13.Text;
            nwl.Show();
        }

        public void label12_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 19;
            nwl.wordlistIdentity = label12.Text;
            nwl.Show();
        }

        public void label11_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 20;
            nwl.wordlistIdentity = label11.Text;
            nwl.Show();
        }

        public void label30_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 21;
            nwl.wordlistIdentity = label30.Text;
            nwl.Show();
        }

        public void label29_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 22;
            nwl.wordlistIdentity = label29.Text;
            nwl.Show();
        }

        public void label28_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber=23;
            nwl.wordlistIdentity = label28.Text;
            nwl.Show();
        }

        public void label27_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 24;
            nwl.wordlistIdentity = label27.Text;
            nwl.Show();
        }

        public void label26_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 25;
            nwl.wordlistIdentity = label26.Text;
            nwl.Show();
        }

        public void label25_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 26;
            nwl.wordlistIdentity = label25.Text;
            nwl.Show();
        }

        public void label24_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 27;
            nwl.wordlistIdentity = label24.Text;
            nwl.Show();
        }

        public void label23_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 28;
            nwl.wordlistIdentity = label23.Text;
            nwl.Show();
        }

        public void label22_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 29;
            nwl.wordlistIdentity = label22.Text;
            nwl.Show();
        }

        public void label21_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 30;
            nwl.wordlistIdentity = label21.Text;
            nwl.Show();
        }

        public void label40_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 31;
            nwl.wordlistIdentity = label40.Text;
            nwl.Show();
        }

        public void label39_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 32;
            nwl.wordlistIdentity = label39.Text;
            nwl.Show();
        }

        public void label38_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 33;
            nwl.wordlistIdentity = label38.Text;
            nwl.Show();
        }

        public void label37_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 34;
            nwl.wordlistIdentity = label37.Text;
            nwl.Show();
        }

        public void label36_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 35;
            nwl.wordlistIdentity = label36.Text;
            nwl.Show();
        }

        public void label35_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 36;
            nwl.wordlistIdentity = label35.Text;
            nwl.Show();
        }

        public void label34_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 37;
            nwl.wordlistIdentity = label34.Text;
            nwl.Show();
        }

        public void label33_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 38;
            nwl.wordlistIdentity = label33.Text;
            nwl.Show();
        }

        public void label32_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 39;
            nwl.wordlistIdentity = label32.Text;
            nwl.Show();
        }

        public void label31_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 40;
            nwl.wordlistIdentity = label31.Text;
            nwl.Show();
        }

        public void label50_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 41;
            nwl.wordlistIdentity = label50.Text;
            nwl.Show();
        }

        public void label49_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 42;
            nwl.wordlistIdentity = label49.Text;
            nwl.Show();
        }

        public void label48_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 43;
            nwl.wordlistIdentity = label48.Text;
            nwl.Show();
        }

        public void label47_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 44;
            nwl.wordlistIdentity = label47.Text;
            nwl.Show();
        }

        public void label46_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 45;
            nwl.wordlistIdentity = label46.Text;
            nwl.Show();
        }

        public void label45_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 46;
            nwl.wordlistIdentity = label45.Text;
            nwl.Show();
        }

        public void label44_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 47;
            nwl.wordlistIdentity = label44.Text;
            nwl.Show();
        }

        public void label43_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 48;
            nwl.wordlistIdentity = label43.Text;
            nwl.Show();
        }

        public void label42_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 49;
            nwl.wordlistIdentity = label42.Text;
            nwl.Show();
        }

        public void label41_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 50;
            nwl.wordlistIdentity = label41.Text;
            nwl.Show();
        }

        private void label27_MouseHover(object sender, EventArgs e)
        {
            label27.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.BackColor = System.Drawing.Color.Yellow;
            label27.Text = "Immaculate-Incessant";
           
        }


        private void label27_MouseLeave(object sender, EventArgs e)
        {

            label27.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label27.BackColor = System.Drawing.Color.White;
            label27.Text = "Word List 24";
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            label11.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.BackColor = System.Drawing.Color.Yellow;
            label11.Text = "Flippant-Gaffe"; 
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.BackColor = System.Drawing.Color.White;
            label11.Text = "Word List 20";
        }

        private void label40_MouseHover(object sender, EventArgs e)
        {
            label40.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.BackColor = System.Drawing.Color.Yellow;
            label40.Text = "Misogamy-Nascent"; 
        }   

        private void label40_MouseLeave(object sender, EventArgs e)
        {
            label40.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label40.BackColor = System.Drawing.Color.White;
            label40.Text = "Word List 31";
        }

        private void label39_MouseHover(object sender, EventArgs e)
        {
            label39.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.BackColor = System.Drawing.Color.Yellow;
            label39.Text = "Natation-Obsidian"; 
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            label39.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label39.BackColor = System.Drawing.Color.White;
            label39.Text = "Word List 32";
        }

        private void label38_MouseHover(object sender, EventArgs e)
        {
            label38.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.BackColor = System.Drawing.Color.Yellow;
            label38.Text = "Obsolete-Overweening"; 
        }

        private void label38_MouseLeave(object sender, EventArgs e)
        {
            label38.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label38.BackColor = System.Drawing.Color.White;
            label38.Text = "Word List 33";
        }

        private void label37_MouseHover(object sender, EventArgs e)
        {
            label37.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.BackColor = System.Drawing.Color.Yellow;
            label37.Text = "Overwrought-Peccadillo"; 
        }

        private void label37_MouseLeave(object sender, EventArgs e)
        {
            label37.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label37.BackColor = System.Drawing.Color.White;
            label37.Text = "Word List 34";
        }

        private void label36_MouseHover(object sender, EventArgs e)
        {
            label36.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.BackColor = System.Drawing.Color.Yellow;
            label36.Text = "Pecuniary-Philanderer"; 
        }

        private void label36_MouseLeave(object sender, EventArgs e)
        {
            label36.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label36.BackColor = System.Drawing.Color.White;
            label36.Text = "Word List 35";
        }

        private void label35_MouseHover(object sender, EventArgs e)
        {
            label35.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.BackColor = System.Drawing.Color.Yellow;
            label35.Text = "Philanthropist-Precedent"; 
        }

        private void label35_MouseLeave(object sender, EventArgs e)
        {
            label35.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label35.BackColor = System.Drawing.Color.White;
            label35.Text = "Word List 36";
        }

        private void label34_MouseHover(object sender, EventArgs e)
        {
            label34.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.BackColor = System.Drawing.Color.Yellow;
            label34.Text = "Percept-Propitiate"; 
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            label34.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.BackColor = System.Drawing.Color.White;
            label34.Text = "Word List 37";
        }

        private void label33_MouseHover(object sender, EventArgs e)
        {
            label33.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.BackColor = System.Drawing.Color.Yellow;
            label33.Text = "Propitious-Quarry"; 
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            label33.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label33.BackColor = System.Drawing.Color.White;
            label33.Text = "Word List 38";
        }

        private void label32_MouseHover(object sender, EventArgs e)
        {
            label32.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.BackColor = System.Drawing.Color.Yellow;
            label32.Text = "Quash-Recurrent"; 
        }

        private void label32_MouseLeave(object sender, EventArgs e)
        {
            label32.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label32.BackColor = System.Drawing.Color.White;
            label32.Text = "Word List 39";
        }

        private void label31_MouseHover(object sender, EventArgs e)
        {
            label31.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.BackColor = System.Drawing.Color.Yellow;
            label31.Text = "Redolent-Requite"; 
        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            label31.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label31.BackColor = System.Drawing.Color.White;
            label31.Text = "Word List 40";
        }

        private void label50_MouseHover(object sender, EventArgs e)
        {
            label50.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.BackColor = System.Drawing.Color.Yellow;
            label50.Text = "Rescind-Sacrosanct"; 
        }

        private void label50_MouseLeave(object sender, EventArgs e)
        {
            label50.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label50.BackColor = System.Drawing.Color.White;
            label50.Text = "Word List 41";
        }

        private void label49_MouseHover(object sender, EventArgs e)
        {
            label49.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.BackColor = System.Drawing.Color.Yellow;
            label49.Text = "Sadistic-Sepulcher"; 
        }

        private void label49_MouseLeave(object sender, EventArgs e)
        {
            label49.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label49.BackColor = System.Drawing.Color.White;
            label49.Text = "Word List 42";
        }

        private void label48_MouseHover(object sender, EventArgs e)
        {
            label48.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label48.BackColor = System.Drawing.Color.Yellow;
            label48.Text = "Sequester-Somatic"; 
        }

        private void label48_MouseLeave(object sender, EventArgs e)
        {
            label48.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label48.BackColor = System.Drawing.Color.White;
            label48.Text = "Word List 43";
        }

        private void label47_MouseHover(object sender, EventArgs e)
        {
            label47.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.BackColor = System.Drawing.Color.Yellow;
            label47.Text = "Somber-Sublime"; 
        }

        private void label47_MouseLeave(object sender, EventArgs e)
        {
            label47.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label47.BackColor = System.Drawing.Color.White;
            label47.Text = "Word List 44";
        }

        private void label46_MouseHover(object sender, EventArgs e)
        {
            label46.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.BackColor = System.Drawing.Color.Yellow;
            label46.Text = "Subliminal-Tantamount"; 
        }

        private void label46_MouseLeave(object sender, EventArgs e)
        {
            label46.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label46.BackColor = System.Drawing.Color.White;
            label46.Text = "Word List 45";
        }

        private void label45_MouseHover(object sender, EventArgs e)
        {
            label45.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.BackColor = System.Drawing.Color.Yellow;
            label45.Text = "Tantrum-Tome"; 
        }

        private void label45_MouseLeave(object sender, EventArgs e)
        {
            label45.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label45.BackColor = System.Drawing.Color.White;
            label45.Text = "Word List 46";
        }

        private void label44_MouseHover(object sender, EventArgs e)
        {
            label44.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.BackColor = System.Drawing.Color.Yellow;
            label44.Text = "Tonsure-Ubiquitous"; 
        }

        private void label44_MouseLeave(object sender, EventArgs e)
        {
            label44.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label44.BackColor = System.Drawing.Color.White;
            label44.Text = "Word List 47";
        }

        private void label43_MouseHover(object sender, EventArgs e)
        {
            label43.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.BackColor = System.Drawing.Color.Yellow;
            label43.Text = "Ulterior-Vehement"; 
        }

        private void label43_MouseLeave(object sender, EventArgs e)
        {
            label43.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label43.BackColor = System.Drawing.Color.White;
            label43.Text = "Word List 48";
        }

        private void label42_MouseHover(object sender, EventArgs e)
        {
            label42.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.BackColor = System.Drawing.Color.Yellow;
            label42.Text = "Velocity-Vogue"; 
        }

        private void label42_MouseLeave(object sender, EventArgs e)
        {
            label42.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label42.BackColor = System.Drawing.Color.White;
            label42.Text = "Word List 49";
        }

        private void label41_MouseHover(object sender, EventArgs e)
        {
            label41.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.BackColor = System.Drawing.Color.Yellow;
            label41.Text = "Volatile-Zephyr"; 
        }

        private void label41_MouseLeave(object sender, EventArgs e)
        {
            label41.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label41.BackColor = System.Drawing.Color.White;
            label41.Text = "Word List 50";
        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            label20.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.BackColor = System.Drawing.Color.Yellow;
            label20.Text = "Conglomeration-Countermand"; 
        }

        private void label20_MouseLeave(object sender, EventArgs e){
            label20.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.BackColor = System.Drawing.Color.White;
            label20.Text = "Word List 11";
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            label19.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.BackColor = System.Drawing.Color.Yellow;
            label19.Text = "Counterpart-Decelerate"; 
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.BackColor = System.Drawing.Color.White;
            label19.Text = "Word List 12";
        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            label18.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.BackColor = System.Drawing.Color.Yellow;
            label18.Text = "Deciduous-Dermatologist"; 
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label18.BackColor = System.Drawing.Color.White;
            label18.Text = "Word List 13";
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            label17.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.BackColor = System.Drawing.Color.Yellow;
            label17.Text = "Derogatory-Disgruntle"; 
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.BackColor = System.Drawing.Color.White;
            label17.Text = "Word List 14";
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label16.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.BackColor = System.Drawing.Color.Yellow;
            label16.Text = "Dishearten-Duplicity"; 
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.BackColor = System.Drawing.Color.White;
            label16.Text = "Word List 15";
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            label15.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.BackColor = System.Drawing.Color.Yellow;
            label15.Text = "Duration-Encroachment"; 
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.BackColor = System.Drawing.Color.White;
            label15.Text = "Word List 16";
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.BackColor = System.Drawing.Color.Yellow;
            label14.Text = "Encumber-Eulogistic"; 
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.BackColor = System.Drawing.Color.White;
            label14.Text = "Word List 17";
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            label13.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.BackColor = System.Drawing.Color.Yellow;
            label13.Text = "Eulogy-Faculty"; 
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.BackColor = System.Drawing.Color.White;
            label13.Text = "Word List 18";
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.BackColor = System.Drawing.Color.Yellow;
            label12.Text = "Fallacious-Flinch"; 
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.BackColor = System.Drawing.Color.White;
            label12.Text = "Word List 19";
        }

        private void label30_MouseHover(object sender, EventArgs e)
        {
            label30.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.BackColor = System.Drawing.Color.Yellow;
            label30.Text = "Gainsay-Gossamer"; 
        }

        private void label30_MouseLeave(object sender, EventArgs e)
        {
            label30.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label30.BackColor = System.Drawing.Color.White;
            label30.Text = "Word List 21";
        }

        private void label29_MouseHover(object sender, EventArgs e)
        {
            label29.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.BackColor = System.Drawing.Color.Yellow;
            label29.Text = "Gouge-Hiatus"; 
        }

        private void label29_MouseLeave(object sender, EventArgs e)
        {
            label29.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label29.BackColor = System.Drawing.Color.White;
            label29.Text = "Word List 22";
        }

        private void label28_MouseHover(object sender, EventArgs e)
        {
            label28.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.BackColor = System.Drawing.Color.Yellow;
            label28.Text = "Hibernal-Imbue"; 
        }

        private void label28_MouseLeave(object sender, EventArgs e)
        {
            label28.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label28.BackColor = System.Drawing.Color.White;
            label28.Text = "Word List 23";
        }

        private void label26_MouseHover(object sender, EventArgs e)
        {
            label26.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.BackColor = System.Drawing.Color.Yellow;
            label26.Text = "Inchoate-Infraction"; 
        }

        private void label26_MouseLeave(object sender, EventArgs e)
        {
            label26.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label26.BackColor = System.Drawing.Color.White;
            label26.Text = "Word List 25";
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            label25.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.BackColor = System.Drawing.Color.Yellow;
            label25.Text = "Infringe-Invert"; 
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            label25.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label25.BackColor = System.Drawing.Color.White;
            label25.Text = "Word List 26";
        }

        private void label24_MouseHover(object sender, EventArgs e)
        {
            label24.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.BackColor = System.Drawing.Color.Yellow;
            label24.Text = "Inveterate-Laggard"; 
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label24.BackColor = System.Drawing.Color.White;
            label24.Text = "Word List 27";
        }

        private void label23_MouseHover(object sender, EventArgs e)
        {
            label23.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.BackColor = System.Drawing.Color.Yellow;
            label23.Text = "Lagoon-Loquacious"; 
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label23.BackColor = System.Drawing.Color.White;
            label23.Text = "Word List 28";
        }

        private void label22_MouseHover(object sender, EventArgs e)
        {
            label22.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.BackColor = System.Drawing.Color.Yellow;
            label22.Text = "Lout-Maul"; 
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label22.BackColor = System.Drawing.Color.White;
            label22.Text = "Word List 29";
        }

        private void label21_MouseHover(object sender, EventArgs e)
        {
            label21.Font = new System.Drawing.Font("Trebuchet MS", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.BackColor = System.Drawing.Color.Yellow;
            label21.Text = "Mausoleum-Misnomer"; 
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label21.BackColor = System.Drawing.Color.White;
            label21.Text = "Word List 30";
        }

        public void label2_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 2;
            nwl.wordlistIdentity = label2.Text;
            nwl.Show();
        }

        public void label3_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 3;
            nwl.wordlistIdentity = label3.Text;
            nwl.Show();
        }

        public void label4_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 4;
            nwl.wordlistIdentity = label4.Text;
            nwl.Show();
        }

        public void label5_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 5;
            nwl.wordlistIdentity = label5.Text;
            nwl.Show();
        }

        public void label6_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 6;
            nwl.wordlistIdentity = label6.Text;
            nwl.Show();
        }

        public void label7_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 7;
            nwl.wordlistIdentity = label7.Text;
            nwl.Show();
        }

        public void label8_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 8;
            nwl.wordlistIdentity = label8.Text;
            nwl.Show();
        }

        public void label9_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 9;
            nwl.wordlistIdentity = label9.Text;
            nwl.Show();
        }

        public void label10_Click(object sender, EventArgs e)
        {
            NewWordlist nwl = new NewWordlist();
            nwl.wordlistnumber = 10;
            nwl.wordlistIdentity = label10.Text;
            nwl.Show();
        }

        public void label51_Click(object sender, EventArgs e)
        {
            RandomListChoser rls = new RandomListChoser();
            rls.Show();
        }

        // Following codes handle mouse hover, mouse left and click on rand option
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
            pictureBox4.BackgroundImage = global::WindowsApplication1.Properties.Resources.Rand_text;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = global::WindowsApplication1.Properties.Resources.random;
            pictureBox4.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            RandomListChoser rnd = new RandomListChoser();
            rnd.Show();
        }
        
    }
}