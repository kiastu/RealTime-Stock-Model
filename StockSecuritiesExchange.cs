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
        protected RealTimeData market;
        List<Form> openForms;
        public StockSecuritiesExchange()
        {
            InitializeComponent();
            market = new RealTimeData();
            List<String> companyNames = market.getNames();
            //prep dynamic menus.
            foreach (string companyName in companyNames)
            {
                ToolStripMenuItem mbpMenu = new ToolStripMenuItem(companyName, null, mbpMenuClick);
                this.mbpMenu.DropDownItems.Add(mbpMenu);
            }
            foreach (string companyName in companyNames)
            {
                ToolStripMenuItem mboMenu = new ToolStripMenuItem(companyName, null, mboMenuClick);
                this.mboMenu.DropDownItems.Add(mboMenu);
            }
            
        }
        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void bidOrder(object sender, EventArgs e)
        {
            BuyForm child = new BuyForm(this.NotifyOrders, market.getNames());
            child.MdiParent = this;
            child.Show();
        }

        private void askOrder(object sender, EventArgs e)
        {
            SellForm child = new SellForm(this.NotifyOrders, market.getNames());
            child.MdiParent = this;
            child.Show();
        }


        private void closeMarket_Click(object sender, EventArgs e)
        {
            this.watchMenu.Visible = false;
            this.ordersMenu.Visible = false;
            this.marketMenu.Text = "Market <<Closed>>";
        }
        
        private void openMarket_Click(object sender, EventArgs e)
        {
            this.watchMenu.Visible = true;
            this.ordersMenu.Visible = true;
            this.marketMenu.Text = "Market <<Open>>";
        }
        
        private void mboMenuClick(object sender, EventArgs e)
        {
            MarketByOrder mbo = new MarketByOrder(sender.ToString());
            mbo.MdiParent = this;
            mbo.Text = "Market By Order - " + sender.ToString();
            mbo.Show();
            market.Register(mbo);
        }
        private void mbpMenuClick(object sender, EventArgs e)
        {
            MarketByPrice mbp = new MarketByPrice(sender.ToString());
            mbp.MdiParent = this;
            mbp.Text = "Market By Price - " + sender.ToString();
            mbp.Show();
            market.Register(mbp);
        }
        private void sssMenu_Click(object sender, EventArgs e)
        {
            StockStateSummary sss = new StockStateSummary();
            sss.MdiParent = this;
            sss.Show();
            market.Register(sss);
        }

        //handles submission of bids
        public void NotifyOrders(EventArgs args)
        {
            var notifyArgs = args as OrderPlacedArgs;
            Order newOrder = notifyArgs.newOrder;
            String companyName = notifyArgs.companyName;
            //place the order.
            market.makeOrder(companyName, newOrder);
            market.notify();
            
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
