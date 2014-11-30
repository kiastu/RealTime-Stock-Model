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
    public partial class MarketByOrder : Form,StockMarketDisplay
    {
        String companyName;
        Company lastUpdate;
        public MarketByOrder()
        {
            InitializeComponent();
        }
        public MarketByOrder(String companyName)
        {
            InitializeComponent();
            this.companyName = companyName;
        }
        public void Update(List<Company> inputData)
        {
            // get gridrow, compare for changes. If so, refresh it
            Company currentUpdate = new Company("fill",0);
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
            List<Order> orders = currentUpdate.getOrders();
            List<Order> buyOrders = new List<Order>();
            List<Order> sellOrders = new List<Order>();
            foreach (Order order in orders)
            {
                switch (order.getType())// switch statement only gets uncompleted orders.
                {
                    case "buy":
                        buyOrders.Add(order);
                        break;

                    case "sell":
                        sellOrders.Add(order);
                        break;
                }
            }
            //Sort Lists.
            buyOrders.Sort(Order.CompareByPrice);
            sellOrders.Sort(Order.CompareByInvPrice);

            //check which size is bigger, fill up the grid
            if (buyOrders.Count() > sellOrders.Count())
            {
                for(int i = 0;i<buyOrders.Count();i+=1){
                    if (sellOrders.Count() > i)//prevent issues with sell.
                    {
                        this.datagrid.Rows.Add(buyOrders[i].getSize(), buyOrders[i].getPrice(), sellOrders[i].getSize(), sellOrders[i].getPrice());
                    }
                    else
                    {
                        this.datagrid.Rows.Add(buyOrders[i].getSize(), buyOrders[i].getPrice(), "", "");

                    }
                }
                

            }
            else
            {
                //sell orders are bigger.
                for (int i = 0; i < sellOrders.Count(); i += 1)
                {
                    if (buyOrders.Count() > i)//prevent issues with sell.
                    {
                        this.datagrid.Rows.Add(buyOrders[i].getSize(), buyOrders[i].getPrice(), sellOrders[i].getSize(), sellOrders[i].getPrice());
                    }
                    else
                    {
                        this.datagrid.Rows.Add("", "", sellOrders[i].getSize(), sellOrders[i].getPrice());
                    }
                }
            }


        }
    }
}
