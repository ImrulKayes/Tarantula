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

        public int flag = 0;
        public int wordlistNum;
        public string wordListIdenty;

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

    }
}