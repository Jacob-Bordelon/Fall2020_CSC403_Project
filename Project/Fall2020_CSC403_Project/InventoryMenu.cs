using System;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using System.Diagnostics;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class InventoryMenu : Form
    {

        
        private Inventory PlayerInventory = Game.player.PlayerInventory;
        public InventoryMenu()
        {
            InitializeComponent();
            this.item1.MouseDoubleClick += new MouseEventHandler((o,a)=>Debug.WriteLine(this.Consume(this.item1)));
            this.item2.MouseDoubleClick += new MouseEventHandler((o, a) => Debug.WriteLine(this.Consume(this.item2)));
            this.item3.MouseDoubleClick += new MouseEventHandler((o, a) => Debug.WriteLine(this.Consume(this.item3)));
            this.item4.MouseDoubleClick += new MouseEventHandler((o, a) => Debug.WriteLine(this.Consume(this.item4)));
            this.item5.MouseDoubleClick += new MouseEventHandler((o, a) => Debug.WriteLine(this.Consume(this.item5)));
            this.item6.MouseDoubleClick += new MouseEventHandler((o, a) => Debug.WriteLine(this.Consume(this.item6)));
            this.item7.MouseDoubleClick += new MouseEventHandler((o, a) => Debug.WriteLine(this.Consume(this.item7)));
        }
        // TODO Add mouseclick events to the picture boxs to consume the items and a[[ly thier affects.
        private string Consume(PictureBox item)
        {
            return item.Name;
        }

        private void InventoryMenu_Load(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>() { this.item1, this.item2, this.item3, this.item4, this.item5, this.item6, this.item7 };
            
            int curpos = 0;
            foreach (Entry entry in PlayerInventory.InventoryList)
            {

                if (entry.EntryQuantity > 0)
                {
                    PictureBox picbox = pictureBoxes[curpos];
                    Image O = (Image)Resources.ResourceManager.GetObject($"item_{entry.EntryItem.Name.ToLower()}");
                    if(O != null)
                    {
                        var image = (Image)new Bitmap(O,new Size(this.item1.Width, this.item1.Height));
                        var font = new Font("TimesNewRoman",25,FontStyle.Bold,GraphicsUnit.Pixel);
                        var graphics = Graphics.FromImage(image);
                        graphics.DrawString(entry.EntryQuantity.ToString(),font,Brushes.Black, new Point(0,0));
                        picbox.Image = image;
                    }
                    
                    curpos++;
                }
            }
            // bool isNullOrEmpty = this.item1 == null || this.item1.Image == null;

            


        }

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


    }
}
