using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using Fall2020_CSC403_Project.Properties;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{   
    /// <summary>
    /// Loads an inventory menu filled with the players items 
    /// </summary>
    public partial class InventoryMenu : Form
    {
        private Inventory PlayerInventory = Game.player.PlayerInventory;

        /// <summary>
        /// Initialize a inventory menu
        /// </summary>
        public InventoryMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the inventory menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryMenu_Load(object sender, EventArgs e)
        {
            this.UpdateHealthBars();
            List<PictureBox> pictureBoxes = new List<PictureBox>() { this.item1, this.item2, this.item3, this.item4, this.item5, this.item6, this.item7 };

            int curpos = 0;
            foreach (Entry entry in PlayerInventory.InventoryList)
            {

                if (entry.EntryQuantity > 0)
                {
                    PictureBox picbox = pictureBoxes[curpos];
                    Image O = (Image)Resources.ResourceManager.GetObject($"item_{entry.EntryItem.Name.ToLower()}");
                    if (curpos < 7)
                    {
                        if (O != null)
                        {
                            Image image = (Image)new Bitmap(O, new Size(this.item1.Width, this.item1.Height));
                            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
                            var graphics = Graphics.FromImage(image);
                            graphics.DrawString(entry.EntryQuantity.ToString(), font, Brushes.Black, new Point(0, 0));
                            image.Tag = entry.EntryItem.Name;
                            picbox.Image = image;
                        }

                        curpos++;
                    }
                }
            }
    
        }
        /// <summary>
        /// Close the menu when key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Inventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '':
                    this.Visible = false;
                    this.Dispose();
                    break;
                case 'i':
                    this.Visible = false;
                    this.Dispose();
                    break;
            }

        }
        
        /// <summary>
        /// Highights the picture boxes the player is hovering over.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighLight(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            picBox.BackColor = Color.LightGray;
            picBox.Refresh();

        }

        /// <summary>
        /// De-highlight hovered over cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeHighlight(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            picBox.BackColor = Color.Transparent;
            picBox.Refresh();
        }

        /// <summary>
        /// Prevent the player from leaving the inventory menu by clicking off the menu
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Focus();
        }

        /// <summary>
        /// Consume Items when player double clicks the appropiate box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consume(object sender, EventArgs e)
        {
            
            var picBox = (PictureBox)sender;
            if (picBox.Image != null)
            {
                string consume_item = picBox.Image.Tag.ToString();
                // get selected item from entry
                Entry entry = PlayerInventory.InventoryList.Find(item => item.EntryItem.Name==consume_item);

                // TODO: apply item effects 
                int returnVal = entry.EntryItem.Use();

                // remove item from inventory
                if(returnVal == 0) 
                    PlayerInventory.WithdrawEntry(entry.EntryItem.ID);

                // update inventory view
                this.Controls.Clear();
                this.InitializeComponent();
                this.InventoryMenu_Load(null, EventArgs.Empty);
               
            }

        }

        /// <summary>
        /// Update status bar at the top
        /// </summary>
   
        private void UpdateHealthBars()
        {
            Player player = Game.player;
            float playerHealthPer = player.Health / (float)player.MaxHealth;         
            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblPlayerHealthFull.Text = player.Health.ToString();

            // TODO: Add Strength bar and configure its properties

        }
    }
}
