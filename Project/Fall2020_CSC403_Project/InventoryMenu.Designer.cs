namespace Fall2020_CSC403_Project
{
    partial class InventoryMenu
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
            this.item1 = new System.Windows.Forms.PictureBox();
            this.item2 = new System.Windows.Forms.PictureBox();
            this.item4 = new System.Windows.Forms.PictureBox();
            this.item3 = new System.Windows.Forms.PictureBox();
            this.item6 = new System.Windows.Forms.PictureBox();
            this.item5 = new System.Windows.Forms.PictureBox();
            this.item7 = new System.Windows.Forms.PictureBox();
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item7)).BeginInit();
            this.SuspendLayout();
            // 
            // item1
            // 
            this.item1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.item1.Location = new System.Drawing.Point(12, 63);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(81, 73);
            this.item1.TabIndex = 0;
            this.item1.TabStop = false;
            this.item1.DoubleClick += new System.EventHandler(this.Consume);
            this.item1.MouseEnter += new System.EventHandler(this.HighLight);
            this.item1.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // item2
            // 
            this.item2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item2.Location = new System.Drawing.Point(99, 63);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(81, 73);
            this.item2.TabIndex = 1;
            this.item2.TabStop = false;
            this.item2.DoubleClick += new System.EventHandler(this.Consume);
            this.item2.MouseEnter += new System.EventHandler(this.HighLight);
            this.item2.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // item4
            // 
            this.item4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item4.Location = new System.Drawing.Point(273, 63);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(81, 73);
            this.item4.TabIndex = 3;
            this.item4.TabStop = false;
            this.item4.DoubleClick += new System.EventHandler(this.Consume);
            this.item4.MouseEnter += new System.EventHandler(this.HighLight);
            this.item4.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // item3
            // 
            this.item3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item3.Location = new System.Drawing.Point(186, 63);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(81, 73);
            this.item3.TabIndex = 2;
            this.item3.TabStop = false;
            this.item3.DoubleClick += new System.EventHandler(this.Consume);
            this.item3.MouseEnter += new System.EventHandler(this.HighLight);
            this.item3.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // item6
            // 
            this.item6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item6.Location = new System.Drawing.Point(447, 63);
            this.item6.Name = "item6";
            this.item6.Size = new System.Drawing.Size(81, 73);
            this.item6.TabIndex = 5;
            this.item6.TabStop = false;
            this.item6.DoubleClick += new System.EventHandler(this.Consume);
            this.item6.MouseEnter += new System.EventHandler(this.HighLight);
            this.item6.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // item5
            // 
            this.item5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item5.Location = new System.Drawing.Point(360, 63);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(81, 73);
            this.item5.TabIndex = 4;
            this.item5.TabStop = false;
            this.item5.DoubleClick += new System.EventHandler(this.Consume);
            this.item5.MouseEnter += new System.EventHandler(this.HighLight);
            this.item5.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // item7
            // 
            this.item7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item7.Location = new System.Drawing.Point(534, 63);
            this.item7.Name = "item7";
            this.item7.Size = new System.Drawing.Size(81, 73);
            this.item7.TabIndex = 6;
            this.item7.TabStop = false;
            this.item7.DoubleClick += new System.EventHandler(this.Consume);
            this.item7.MouseEnter += new System.EventHandler(this.HighLight);
            this.item7.MouseLeave += new System.EventHandler(this.DeHighlight);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(215, 20);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerHealthFull.TabIndex = 7;
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(174, 25);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(22, 13);
            this.HP.TabIndex = 8;
            this.HP.Text = "HP";
            // 
            // InventoryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 148);
            this.ControlBox = false;
            this.Controls.Add(this.HP);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.item7);
            this.Controls.Add(this.item6);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryMenu";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.InventoryMenu_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Inventory_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox item1;
        private System.Windows.Forms.PictureBox item2;
        private System.Windows.Forms.PictureBox item4;
        private System.Windows.Forms.PictureBox item3;
        private System.Windows.Forms.PictureBox item6;
        private System.Windows.Forms.PictureBox item5;
        private System.Windows.Forms.PictureBox item7;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label HP;
    }
}