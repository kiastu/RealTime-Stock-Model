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
    public partial class SellForm : Form
    {
        public delegate void ParentNotify(EventArgs args);
        private ParentNotify parentNotify;
        public SellForm(ParentNotify notify, List<String> companyNames)
        {
            parentNotify = notify;
            InitializeComponent();
            this.sellCompany.DataSource = companyNames;
        }

        private void submit_click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(this.sellNum.Text,out num) && int.TryParse(this.sellPrice.Text,out num)){
            OrderPlacedArgs args = new OrderPlacedArgs();
            args.companyName = this.sellCompany.SelectedItem.ToString();
            Order newOrder = new Order(Double.Parse(this.sellPrice.Text), Int32.Parse(this.sellNum.Text), "sell");
            args.newOrder = newOrder;
            parentNotify(args);
        }
        }
    }
}
