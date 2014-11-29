using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dkong22_Assignment_2
{
    public partial class StockSecuritiesExchange : Form
    {
        public StockSecuritiesExchange()
        {
            InitializeComponent();
        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuyForm child = new BuyForm();
            child.MdiParent = this;
            child.Show();
        }

        private void ask_Click(object sender, EventArgs e)
        {
            SellForm child = new SellForm();
            child.MdiParent = this;
            child.Show();
        }


        private void closeMarket_Click(object sender, EventArgs e)
        {
            this.watchMenu.Visible = false;
            this.ordersMenu.Visible = false;
        }

        private void openMarket_Click(object sender, EventArgs e)
        {
            this.watchMenu.Visible = true;
            this.ordersMenu.Visible = true;
        }

        private void windowsTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void windowsTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void windowsCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
