namespace WindowsApplication1
{
    partial class Flip_Words
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flip_Words));
            this.labelwordtitle = new System.Windows.Forms.Label();
            this.labelword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelmeaning = new System.Windows.Forms.Label();
            this.labelmeaningtitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttongoforoptions = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelwordtitle
            // 
            this.labelwordtitle.AutoSize = true;
            this.labelwordtitle.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwordtitle.Location = new System.Drawing.Point(47, 41);
            this.labelwordtitle.Name = "labelwordtitle";
            this.labelwordtitle.Size = new System.Drawing.Size(61, 24);
            this.labelwordtitle.TabIndex = 0;
            this.labelwordtitle.Text = "Word:";
            // 
            // labelword
            // 
            this.labelword.AutoSize = true;
            this.labelword.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelword.Location = new System.Drawing.Point(114, 44);
            this.labelword.Name = "labelword";
            this.labelword.Size = new System.Drawing.Size(56, 23);
            this.labelword.TabIndex = 1;
            this.labelword.Text = "label2";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Flip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelmeaning);
            this.groupBox1.Controls.Add(this.labelmeaningtitle);
            this.groupBox1.Controls.Add(this.labelwordtitle);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelword);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flip Words";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(139, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit to Options";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(301, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // labelmeaning
            // 
            this.labelmeaning.AutoSize = true;
            this.labelmeaning.Font = new System.Drawing.Font("Trebuchet MS", 12.75F);
            this.labelmeaning.Location = new System.Drawing.Point(115, 72);
            this.labelmeaning.Name = "labelmeaning";
            this.labelmeaning.Size = new System.Drawing.Size(56, 23);
            this.labelmeaning.TabIndex = 4;
            this.labelmeaning.Text = "label2";
            this.labelmeaning.Visible = false;
            // 
            // labelmeaningtitle
            // 
            this.labelmeaningtitle.AutoSize = true;
            this.labelmeaningtitle.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmeaningtitle.Location = new System.Drawing.Point(25, 70);
            this.labelmeaningtitle.Name = "labelmeaningtitle";
            this.labelmeaningtitle.Size = new System.Drawing.Size(86, 24);
            this.labelmeaningtitle.TabIndex = 3;
            this.labelmeaningtitle.Text = "Meaning:";
            this.labelmeaningtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelmeaningtitle.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsApplication1.Properties.Resources.flopWordsBack;
            this.panel1.Controls.Add(this.buttongoforoptions);
            this.panel1.Location = new System.Drawing.Point(225, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 385);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // buttongoforoptions
            // 
            this.buttongoforoptions.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongoforoptions.Location = new System.Drawing.Point(88, 147);
            this.buttongoforoptions.Name = "buttongoforoptions";
            this.buttongoforoptions.Size = new System.Drawing.Size(183, 47);
            this.buttongoforoptions.TabIndex = 22;
            this.buttongoforoptions.Text = "Go for Options";
            this.buttongoforoptions.UseVisualStyleBackColor = true;
            this.buttongoforoptions.Visible = false;
            this.buttongoforoptions.Click += new System.EventHandler(this.buttongoforoptions_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(172, 134);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(77, 24);
            this.labelHeader.TabIndex = 24;
            this.labelHeader.Text = "label21";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
            this.pictureBox1.Image = global::WindowsApplication1.Properties.Resources.home_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(628, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 45);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
            this.pictureBox2.Image = global::WindowsApplication1.Properties.Resources.help_icon1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(666, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 45);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsApplication1.Properties.Resources.icon_gatis_froneScreen;
            this.pictureBox3.Image = global::WindowsApplication1.Properties.Resources.back_icon;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(704, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 45);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // Flip_Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsApplication1.Properties.Resources.flopWordsBack;
            this.ClientSize = new System.Drawing.Size(819, 592);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Flip_Words";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flip Words";
            this.Load += new System.EventHandler(this.Flip_Words_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelwordtitle;
        private System.Windows.Forms.Label labelword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelmeaningtitle;
        private System.Windows.Forms.Label labelmeaning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttongoforoptions;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}