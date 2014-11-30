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
    public partial class BuyForm : Form
    {
        public delegate void ParentNotify(EventArgs args);
        private ParentNotify parentNotify;
        public BuyForm(ParentNotify notify, List<String> companyNames)
        {
            parentNotify = notify;
            InitializeComponent();
            this.buyCompany.DataSource = companyNames;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(this.buyNum.Text,out num) && int.TryParse(this.buyPrice.Text,out num))
            {
                OrderPlacedArgs args = new OrderPlacedArgs();
                args.companyName = this.buyCompany.SelectedItem.ToString();

                Order newOrder = new Order(Double.Parse(this.buyPrice.Text), Int32.Parse(this.buyNum.Text), "buy");
                args.newOrder = newOrder;
                parentNotify(args);
            }
        }
    }
}
