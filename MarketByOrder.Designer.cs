namespace dkong22_Assignment_2
{
    partial class MarketByOrder
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
            this.buy_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buy_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sell_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buy_volume,
            this.buy_price,
            this.sell_volume,
            this.sell_price});
            this.datagrid.Location = new System.Drawing.Point(1, -3);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(451, 369);
            this.datagrid.TabIndex = 1;
            // 
            // buy_volume
            // 
            this.buy_volume.HeaderText = "Buy Volume";
            this.buy_volume.Name = "buy_volume";
            // 
            // buy_price
            // 
            this.buy_price.HeaderText = "BuyPrice";
            this.buy_price.Name = "buy_price";
            // 
            // sell_volume
            // 
            this.sell_volume.HeaderText = "Sell Volume";
            this.sell_volume.Name = "sell_volume";
            // 
            // sell_price
            // 
            this.sell_price.HeaderText = "Sell Price";
            this.sell_price.Name = "sell_price";
            // 
            // MarketByOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 366);
            this.Controls.Add(this.datagrid);
            this.Name = "MarketByOrder";
            this.Text = "MarketByOrder";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buy_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn buy_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn sell_price;
    }
}