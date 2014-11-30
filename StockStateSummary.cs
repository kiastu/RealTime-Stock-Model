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
    public partial class StockStateSummary : Form ,StockMarketDisplay
    {
        private List<Company> companies;
        public StockStateSummary()
        {
            InitializeComponent();
        }
        public void Update(List<Company> companies)
        {
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
            foreach (Company company in companies)
            {
                Image icon = Image.FromFile(company.getIcon());
                this.datagrid.Rows.Add(company.getCompanyName(), company.getOpenPrice(), company.getLastPrice(),
                    company.getChange(), icon, company.getPercentChange(), company.getVolume());

            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
