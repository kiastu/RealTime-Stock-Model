namespace dkong22_Assignment_2
{
    partial class StockSecuritiesExchange
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.marketMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMarket = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMarket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sssMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mboMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mbpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bid = new System.Windows.Forms.ToolStripMenuItem();
            this.ask = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketMenu,
            this.watchMenu,
            this.ordersMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(823, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // marketMenu
            // 
            this.marketMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMarket,
            this.closeMarket,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.marketMenu.Name = "marketMenu";
            this.marketMenu.Size = new System.Drawing.Size(124, 20);
            this.marketMenu.Text = "Market<<Closed>>";
            // 
            // openMarket
            // 
            this.openMarket.Name = "openMarket";
            this.openMarket.Size = new System.Drawing.Size(103, 22);
            this.openMarket.Text = "Open";
            this.openMarket.Click += new System.EventHandler(this.openMarket_Click);
            // 
            // closeMarket
            // 
            this.closeMarket.Enabled = false;
            this.closeMarket.Name = "closeMarket";
            this.closeMarket.Size = new System.Drawing.Size(103, 22);
            this.closeMarket.Text = "Close";
            this.closeMarket.Click += new System.EventHandler(this.closeMarket_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // watchMenu
            // 
            this.watchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssMenu,
            this.mboMenu,
            this.mbpMenu});
            this.watchMenu.Name = "watchMenu";
            this.watchMenu.Size = new System.Drawing.Size(53, 20);
            this.watchMenu.Text = "Watch";
            this.watchMenu.Visible = false;
            // 
            // sssMenu
            // 
            this.sssMenu.Name = "sssMenu";
            this.sssMenu.Size = new System.Drawing.Size(186, 22);
            this.sssMenu.Text = "Stock State Summary";
            this.sssMenu.Click += new System.EventHandler(this.sssMenu_Click);
            // 
            // mboMenu
            // 
            this.mboMenu.Name = "mboMenu";
            this.mboMenu.Size = new System.Drawing.Size(186, 22);
            this.mboMenu.Text = "Market By Order";
            // 
            // mbpMenu
            // 
            this.mbpMenu.Name = "mbpMenu";
            this.mbpMenu.Size = new System.Drawing.Size(186, 22);
            this.mbpMenu.Text = "Market By Price";
            // 
            // ordersMenu
            // 
            this.ordersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bid,
            this.ask});
            this.ordersMenu.Name = "ordersMenu";
            this.ordersMenu.Size = new System.Drawing.Size(54, 20);
            this.ordersMenu.Text = "Orders";
            this.ordersMenu.Visible = false;
            this.ordersMenu.Click += new System.EventHandler(this.bidToolStripMenuItem_Click);
            // 
            // bid
            // 
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(152, 22);
            this.bid.Text = "Bid";
            this.bid.Click += new System.EventHandler(this.bidOrder);
            // 
            // ask
            // 
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(152, 22);
            this.ask.Text = "Ask";
            this.ask.Click += new System.EventHandler(this.askOrder);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsCascade,
            this.windowsTileHorizontal,
            this.windowsTileVertical,
            this.toolStripSeparator1});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "Windows";
            // 
            // windowsCascade
            // 
            this.windowsCascade.Name = "windowsCascade";
            this.windowsCascade.Size = new System.Drawing.Size(152, 22);
            this.windowsCascade.Text = "Cascade";
            this.windowsCascade.Click += new System.EventHandler(this.windowsCascade_Click);
            // 
            // windowsTileHorizontal
            // 
            this.windowsTileHorizontal.Name = "windowsTileHorizontal";
            this.windowsTileHorizontal.Size = new System.Drawing.Size(152, 22);
            this.windowsTileHorizontal.Text = "Horizontal Tile";
            this.windowsTileHorizontal.Click += new System.EventHandler(this.windowsTileHorizontal_Click);
            // 
            // windowsTileVertical
            // 
            this.windowsTileVertical.Name = "windowsTileVertical";
            this.windowsTileVertical.Size = new System.Drawing.Size(152, 22);
            this.windowsTileVertical.Text = "Vertical Tile";
            this.windowsTileVertical.Click += new System.EventHandler(this.windowsTileVertical_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // StockSecuritiesExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 483);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "StockSecuritiesExchange";
            this.Text = "Stock Securities Exchange";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem marketMenu;
        private System.Windows.Forms.ToolStripMenuItem watchMenu;
        private System.Windows.Forms.ToolStripMenuItem ordersMenu;
        private System.Windows.Forms.ToolStripMenuItem bid;
        private System.Windows.Forms.ToolStripMenuItem ask;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsCascade;
        private System.Windows.Forms.ToolStripMenuItem windowsTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem windowsTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openMarket;
        private System.Windows.Forms.ToolStripMenuItem closeMarket;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sssMenu;
        private System.Windows.Forms.ToolStripMenuItem mboMenu;
        private System.Windows.Forms.ToolStripMenuItem mbpMenu;
    }
}

