using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player;
        public static Image playerImage { get; set; }

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;
        private Character[] minion;
        private Character Door;

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private static InventoryMenu InventoryM;


        public FrmLevel2()
        {
            InitializeComponent();
            this.picPlayer.BackgroundImage = playerImage;
        }

        private void FrmLevel2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 27;
            const int Minion = 27;

            player = Game.player;

      

            //enemyPoisonPacket = new Enemy(CreatePosition(minion1), CreateCollider(minion1, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            Door = new Character(CreatePosition(picdoor), CreateCollider(picdoor, PADDING));

            bossKoolaid.picbox = picBoss;
            //enemyPoisonPacket.picbox = minion1;
            enemyCheeto.picbox = picEnemyCheeto;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            // adding in more minions
            minion = new Character[Minion];
            for (int w = 0; w < Minion; w++)
            {
                PictureBox pic = Controls.Find("minion" + w.ToString(), true)[0] as PictureBox;
                minion[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

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

        private void FrmLevel2_KeyUp(object sender, KeyEventArgs e)
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

            if (HitADoor(player, Door))
            {
                Debug.WriteLine("I hit a door");
                player.MoveBack();
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

        //door collider
        private bool HitADoor(Character you, Character Door)
        {
            return you.Collider.Intersects(Door.Collider);
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

        private void FrmLevel2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;
                case Keys.A:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;
                case Keys.D:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;
                case Keys.W:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;
                case Keys.S:
                    player.GoDown();
                    break;

                case Keys.I:
                    InventoryM = new InventoryMenu();
                    InventoryM.Show();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

		private void FrmLevel2_Load_1(object sender, EventArgs e)
		{

		}
	}
}
