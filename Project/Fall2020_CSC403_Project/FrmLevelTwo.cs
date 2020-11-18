using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevelTwo : Form
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
        public FrmLevelTwo()
        {
            InitializeComponent();
            this.picPlayer.BackgroundImage = playerImage;
        }

        private void FrmLevelTwo_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            //const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            //player.Position = CreatePosition(picPlayer);

            // Setting inventory for player
            player.PlayerInventory = Game.player.PlayerInventory;


            //Andrew Hall Player Template Selector
            player.CharacterTemplate = Game.player.CharacterTemplate; ;
            player.SetHPValues();

            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));

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

        private void FrmLevelTwo_KeyUp(object sender, KeyEventArgs e)
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

            // update player's picture box 
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }
            private void FrmLevelTwo_KeyDown(object sender, KeyEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
