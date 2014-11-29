namespace dkong22_Assignment_2
{
    partial class StockStateSummary
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_net_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.share_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company,
            this.open_price,
            this.last_sale,
            this.change_net_percent,
            this.share_volume});
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.Location = new System.Drawing.Point(2, 1);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(545, 391);
            this.datagrid.TabIndex = 1;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            // 
            // open_price
            // 
            this.open_price.HeaderText = "Open Price";
            this.open_price.Name = "open_price";
            // 
            // last_sale
            // 
            this.last_sale.HeaderText = "Last Sale";
            this.last_sale.Name = "last_sale";
            // 
            // change_net_percent
            // 
            this.change_net_percent.HeaderText = "Change Net -%";
            this.change_net_percent.Name = "change_net_percent";
            // 
            // share_volume
            // 
            this.share_volume.HeaderText = "Share Volume";
            this.share_volume.Name = "share_volume";
            // 
            // StockStateSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 393);
            this.Controls.Add(this.datagrid);
            this.Name = "StockStateSummary";
            this.Text = "StockStateSummary";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn open_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_net_percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn share_volume;
    }
}