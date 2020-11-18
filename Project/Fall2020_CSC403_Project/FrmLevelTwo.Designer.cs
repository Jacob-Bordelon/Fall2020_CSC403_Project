namespace Fall2020_CSC403_Project
{
    partial class FrmLevelTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevelTwo));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.picBush1 = new System.Windows.Forms.PictureBox();
            this.picBush0 = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picBush2 = new System.Windows.Forms.PictureBox();
            this.picBush3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBush1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBush0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBush2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBush3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(13, 9);
            this.lblInGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(60, 24);
            this.lblInGameTime.TabIndex = 6;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // picBush1
            // 
            this.picBush1.BackColor = System.Drawing.Color.Transparent;
            this.picBush1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.bush;
            this.picBush1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBush1.Location = new System.Drawing.Point(95, 37);
            this.picBush1.Margin = new System.Windows.Forms.Padding(4);
            this.picBush1.Name = "picBush1";
            this.picBush1.Size = new System.Drawing.Size(1339, 100);
            this.picBush1.TabIndex = 15;
            this.picBush1.TabStop = false;
            // 
            // picBush0
            // 
            this.picBush0.BackColor = System.Drawing.Color.Transparent;
            this.picBush0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.bush2;
            this.picBush0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBush0.Location = new System.Drawing.Point(2, 37);
            this.picBush0.Margin = new System.Windows.Forms.Padding(4);
            this.picBush0.Name = "picBush0";
            this.picBush0.Size = new System.Drawing.Size(96, 744);
            this.picBush0.TabIndex = 14;
            this.picBush0.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(218, 288);
            this.picEnemyPoisonPacket.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(84, 118);
            this.picEnemyPoisonPacket.TabIndex = 5;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 636);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(72, 130);
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // picBush2
            // 
            this.picBush2.BackColor = System.Drawing.Color.Transparent;
            this.picBush2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.bush;
            this.picBush2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBush2.Location = new System.Drawing.Point(2, 789);
            this.picBush2.Margin = new System.Windows.Forms.Padding(4);
            this.picBush2.Name = "picBush2";
            this.picBush2.Size = new System.Drawing.Size(1564, 100);
            this.picBush2.TabIndex = 16;
            this.picBush2.TabStop = false;
            // 
            // picBush3
            // 
            this.picBush3.BackColor = System.Drawing.Color.Transparent;
            this.picBush3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.bush2;
            this.picBush3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBush3.Location = new System.Drawing.Point(1429, 37);
            this.picBush3.Margin = new System.Windows.Forms.Padding(4);
            this.picBush3.Name = "picBush3";
            this.picBush3.Size = new System.Drawing.Size(137, 751);
            this.picBush3.TabIndex = 17;
            this.picBush3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(1034, 219);
            this.picBossKoolAid.Margin = new System.Windows.Forms.Padding(4);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(257, 239);
            this.picBossKoolAid.TabIndex = 18;
            this.picBossKoolAid.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(746, 573);
            this.picEnemyCheeto.Margin = new System.Windows.Forms.Padding(4);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(85, 132);
            this.picEnemyCheeto.TabIndex = 19;
            this.picEnemyCheeto.TabStop = false;
            // 
            // FrmLevelTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1568, 894);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picBush3);
            this.Controls.Add(this.picBush2);
            this.Controls.Add(this.picBush1);
            this.Controls.Add(this.picBush0);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmLevelTwo";
            this.Text = "Explore";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.FrmLevelTwo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevelTwo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevelTwo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBush1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBush0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBush2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBush3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.PictureBox picBush0;
        private System.Windows.Forms.PictureBox picBush1;
        private System.Windows.Forms.PictureBox picBush2;
        private System.Windows.Forms.PictureBox picBush3;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.PictureBox picEnemyCheeto;
    }
}