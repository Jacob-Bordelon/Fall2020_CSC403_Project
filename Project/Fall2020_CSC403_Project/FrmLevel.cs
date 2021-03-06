using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        /// <summary>
        /// Global Reference for the current playerImage
        /// </summary>
        public static Image playerImage { get; set; } 

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private static InventoryMenu InventoryM;
        private Character Door;

        /// <summary>
        /// Initalize Frm Level
        /// </summary>
        public FrmLevel()
        {
            InitializeComponent();
            this.picPlayer.BackgroundImage = playerImage;
            // Play music 
            SoundPlayer simpleSound = new SoundPlayer(global::Fall2020_CSC403_Project.Properties.Resources.e1m1);
            simpleSound.Play();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            //Andrew Hall Player Template Selector
            player.CharacterTemplate = MainMenu.CharacterTemplate;
            player.SetHPValues();

            // Starting items for player
            player.PlayerInventory.InsertEntry(new Potion(), 2);
            player.PlayerInventory.InsertEntry(new StrengthIncrease(), 2);
            player.PlayerInventory.InsertEntry(new MaxHPIncrease(), 2);
            

            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            bossKoolaid.picbox = picBossKoolAid;
            enemyPoisonPacket.picbox = picEnemyPoisonPacket;
            enemyCheeto.picbox = picEnemyCheeto;

            bossKoolaid.Color = Color.Red;
            bossKoolaid.CharacterTemplate.AlterDefense(2);
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            var door = Controls.Find("door1", true)[0] as PictureBox;
            Door = new Character(CreatePosition(door), CreateCollider(door, PADDING));

            Game.player = player;
            timeBegin = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player 
            player.Move();

            // check collision with walls 
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check if the door and player collides and levels the character and goes to next level 
            if (HitADoor(player, Door))
            {
                player.MoveBack();
                if (player.PlayerInventory.QuantityItem(1000) >= 1)
                {
                    Game.player.PlayerInventory.WithdrawEntry(1000);
                    Game.player.CharacterTemplate.LevelUp();
                    Game.player.MoveBack();
                    this.Hide();
                    var gameForm = new FrmLevelTwo();
                    gameForm.Show();
                    this.Dispose();
                    
                }

            }

            // check collision with enemies 
            if (HitAChar(player, enemyPoisonPacket))
            {
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto))
            {
                Fight(enemyCheeto);
                
            }
            if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);

            }

            // update player's picture box 
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private bool HitADoor(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();

            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }

        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Move Left
                case Keys.Left:
                    player.GoLeft();
                    break;
                case Keys.A:
                    player.GoLeft();
                    break;

                // Move Right
                case Keys.Right:
                    player.GoRight();
                    break;
                case Keys.D:
                    player.GoRight();
                    break;

                // Move Up
                case Keys.Up:
                    player.GoUp();
                    break;
                case Keys.W:
                    player.GoUp();
                    break;

                // Move Down
                case Keys.Down:
                    player.GoDown();
                    break;
                case Keys.S:
                    player.GoDown();
                    break;

                //Open Inventory
                case Keys.I:
                    InventoryM = new InventoryMenu();
                    InventoryM.Show();
                    break;

                //Reset Inventory
                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
    }
}
