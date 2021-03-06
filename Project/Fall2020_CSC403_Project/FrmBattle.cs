using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;
        public static Image playerImage { get; set; }
        private LootRandomizer loot = new LootRandomizer();

        private FrmBattle()
        {
            InitializeComponent();
            this.picPlayer.BackgroundImage = playerImage;
            player = Game.player;
        }

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        public static FrmBattle GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.CharacterTemplate.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.CharacterTemplate.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-1);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-1);
            }

            UpdateHealthBars();
            if (player.Health <= 0)
            {
                instance = null;
                this.Close();
                WinorFailScreen FailureScreen = new WinorFailScreen("loss");
                FailureScreen.Show();


            }
            else if (enemy.Health <= 0)
            {
                
                // To add a random item after defeating an enemy
                player.PlayerInventory.InsertEntry(loot.GetRandomItem(), 1);
                
                // Checks if enemy is a boss (Boss color is red). I recommend to add a function to the enemy: bool IsBoss()
                // Add a key to the invetory
                if (enemy.Color == Color.Red)
                {
                    player.PlayerInventory.InsertEntry(new Potion(), 2);
                    player.CharacterTemplate.LevelUp();
                }
                Enemy.num--;

                instance = null;
                this.Close();

                if(Enemy.num <= 0)
                {
                    player.PlayerInventory.InsertEntry(new Key(), 1);
                    Player.win++;
                }

                if(Player.win >= 2)
                {
                    var WinScreen = new WinorFailScreen("win");
                    WinScreen.Show();
                }


            }
        }
        /// <summary>
        /// The ammount of damage an enemy takes
        /// Thsi function can be reduced to 0 by an enemies defense
        /// </summary>
        /// <param name="amount">initial ammount of damage incoming, should be negitive</param>
        private void EnemyDamage(int amount)
        {
            //check if the defense is greater than the ammount of damage
            if (amount + enemy.CharacterTemplate.Defense < 0)
            { 
                //decrement the health of the enemy by the ammount of damage
                //determined by the defense
                enemy.AlterHealth(amount + enemy.CharacterTemplate.Defense); 
            }
        }
        /// <summary>
        ///  The ammount of damage an enemy takes
        /// Thsi function can be reduced to 0 by an enemies defense
        /// </summary>
        /// <param name="amount">initial ammount of damage incoming, should be negitive</param>
        private void PlayerDamage(int amount)
        {
            //check if the defense is greater than the ammount of damage
            if (amount + player.CharacterTemplate.Defense < 0)
            {
                player.AlterHealth(amount + player.CharacterTemplate.Defense);
            }
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

    }
}
