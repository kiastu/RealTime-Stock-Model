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
    public partial class MarketByPrice : Form,StockMarketDisplay
    {
        String companyName;
        Company lastUpdate;
        public MarketByPrice()
        {
            InitializeComponent();
        }
        public MarketByPrice(String companyName)
        {
            InitializeComponent();
            this.companyName = companyName;
        }
        public void Update(List<Company> inputData)
        {
            // get gridrow, compare for changes. If so, refresh it
            Company currentUpdate = new Company("fill", 0);
            //look for company we're interested in.
            foreach (Company data in inputData)
            {
                if (data.getCompanyName() == companyName)
                {
                    currentUpdate = data;
                }
                else
                {
                    continue;
                }
            }
            do
            {
                foreach (DataGridViewRow row in this.datagrid.Rows)
                {
                    try
                    {
                        this.datagrid.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (this.datagrid.Rows.Count > 1);
            List<Order> completedBuyOrders = currentUpdate.getCompleted();
            List<Order> completedSellOrders = new List<Order>(completedBuyOrders);

            //Sort Lists.
            completedBuyOrders.Sort(Order.CompareByPrice);
            completedSellOrders.Sort(Order.CompareByInvPrice);

            for (int i = 0; i < completedBuyOrders.Count(); i += 1)
            {
                this.datagrid.Rows.Add(i,completedBuyOrders[i].getSize(), completedBuyOrders[i].getPrice(),i, completedSellOrders[i].getSize(), completedSellOrders[i].getPrice());
            }

        }
    }
}
