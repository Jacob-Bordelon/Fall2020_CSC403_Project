using System;
using System.Drawing;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    class MainMenu : Form
    {
        public static Template CharacterTemplate { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;

        public static Image Character{get;set;}

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.BackColor = Color.White;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Size = new System.Drawing.Size(137, 210);
            this.button1.Image = (Image)new Bitmap(global::Fall2020_CSC403_Project.Properties.Resources.mrpeanut,this.button1.Size);
            this.button1.Location = new System.Drawing.Point(90, 233);
            this.button1.Name = "button1";
            this.button1.TabIndex = 0;
            this.button1.Text = "Mr. Peanut";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Size = new System.Drawing.Size(137, 210);
            this.button2.Image = (Image)new Bitmap(global::Fall2020_CSC403_Project.Properties.Resources.applejacks, this.button2.Size);
            this.button2.Location = new System.Drawing.Point(253, 233);
            this.button2.Name = "button2";
            this.button2.TabIndex = 1;
            this.button2.Text = "Cinnamon";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Size = new System.Drawing.Size(137, 210);
            this.button3.Image = (Image)new Bitmap(global::Fall2020_CSC403_Project.Properties.Resources.MnM, this.button3.Size);
            this.button3.Location = new System.Drawing.Point(412, 233);
            this.button3.Name = "button3";
            this.button3.TabIndex = 2;
            this.button3.Text = "MnM";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Size = new System.Drawing.Size(137, 210);
            this.button4.Image = (Image)new Bitmap(global::Fall2020_CSC403_Project.Properties.Resources.chestercheetah, this.button4.Size);
            this.button4.Location = new System.Drawing.Point(571, 233);
            this.button4.Name = "button4";
            this.button4.TabIndex = 3;
            this.button4.Text = "Chester Cheetah";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.snackAttack;
            this.pictureBox1.Location = new System.Drawing.Point(123, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(825, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
        //selects Mr Peanut The Fighter as the playable character ADH
        private void button1_Click(object sender, EventArgs e)
        {
            Character= this.button1.Image;
            CharacterTemplate = new Fighter(); 
            start();
        }
        //selects Mr Cinnimon the Wizard as the playable character ADH
        private void button2_Click(object sender, EventArgs e)
        {
            Character=this.button2.Image;
            CharacterTemplate = new Wizard();
            start();
        }
        //selects Mr M&M the Rogue as the playable character ADH
        private void button3_Click(object sender, EventArgs e)
        {
            Character= this.button3.Image;
            CharacterTemplate = new Rogue();
            start();
        }
        //selects Mr Chester the CheetoCat as the playable character ADH
        private void button4_Click(object sender, EventArgs e)
        {
            Character= this.button4.Image;
            CharacterTemplate = new Cheetocat();
            start();
        }

        private void start()
        {
            this.Hide();
            var gameForm = new FrmLevel();
            gameForm.Closed += (s, args) => this.Close();
            gameForm.Show();
        }
    }
}
