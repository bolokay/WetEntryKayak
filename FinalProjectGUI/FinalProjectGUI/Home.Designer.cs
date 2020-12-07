namespace FinalProjectGUI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newKayaksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gearAndAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundGB = new System.Windows.Forms.GroupBox();
            this.lblShopAll = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.backgroundGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.shopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.checkoutToolStripMenuItem.Text = "Shopping Cart";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.newKayaksToolStripMenuItem,
            this.gearAndAccToolStripMenuItem});
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // newKayaksToolStripMenuItem
            // 
            this.newKayaksToolStripMenuItem.Name = "newKayaksToolStripMenuItem";
            this.newKayaksToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newKayaksToolStripMenuItem.Text = "New Kayaks";
            this.newKayaksToolStripMenuItem.Click += new System.EventHandler(this.newKayaksToolStripMenuItem_Click);
            // 
            // gearAndAccToolStripMenuItem
            // 
            this.gearAndAccToolStripMenuItem.Name = "gearAndAccToolStripMenuItem";
            this.gearAndAccToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gearAndAccToolStripMenuItem.Text = "Gear and Accessories";
            this.gearAndAccToolStripMenuItem.Click += new System.EventHandler(this.gearAndAccToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // backgroundGB
            // 
            this.backgroundGB.BackColor = System.Drawing.Color.Transparent;
            this.backgroundGB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundGB.BackgroundImage")));
            this.backgroundGB.Controls.Add(this.lblShopAll);
            this.backgroundGB.ForeColor = System.Drawing.Color.Transparent;
            this.backgroundGB.Location = new System.Drawing.Point(0, 0);
            this.backgroundGB.Name = "backgroundGB";
            this.backgroundGB.Size = new System.Drawing.Size(1146, 651);
            this.backgroundGB.TabIndex = 5;
            this.backgroundGB.TabStop = false;
            // 
            // lblShopAll
            // 
            this.lblShopAll.BackColor = System.Drawing.Color.LightGray;
            this.lblShopAll.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShopAll.Location = new System.Drawing.Point(0, 257);
            this.lblShopAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopAll.Name = "lblShopAll";
            this.lblShopAll.Size = new System.Drawing.Size(1146, 50);
            this.lblShopAll.TabIndex = 2;
            this.lblShopAll.Text = "Shop All Kayaks";
            this.lblShopAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShopAll.Click += new System.EventHandler(this.LblShopAll_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1148, 566);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.backgroundGB);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.backgroundGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newKayaksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gearAndAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.GroupBox backgroundGB;
        private System.Windows.Forms.Label lblShopAll;
    }
}

