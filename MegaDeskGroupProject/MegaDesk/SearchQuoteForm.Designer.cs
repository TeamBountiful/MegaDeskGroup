namespace MegaDesk
{
    partial class SearchQuoteForm
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
            this.SearchReturnButton = new System.Windows.Forms.Button();
            this.SearchQuoteLabel = new System.Windows.Forms.Label();
            this.searchQuotes = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFilterPicker = new System.Windows.Forms.ComboBox();
            this.filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchReturnButton
            // 
            this.SearchReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchReturnButton.Location = new System.Drawing.Point(767, 466);
            this.SearchReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchReturnButton.Name = "SearchReturnButton";
            this.SearchReturnButton.Size = new System.Drawing.Size(203, 55);
            this.SearchReturnButton.TabIndex = 0;
            this.SearchReturnButton.Text = "Return To Home";
            this.SearchReturnButton.UseVisualStyleBackColor = false;
            this.SearchReturnButton.Click += new System.EventHandler(this.SearchReturnButton_Click);
            // 
            // SearchQuoteLabel
            // 
            this.SearchQuoteLabel.AutoSize = true;
            this.SearchQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuoteLabel.Location = new System.Drawing.Point(396, 42);
            this.SearchQuoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchQuoteLabel.Name = "SearchQuoteLabel";
            this.SearchQuoteLabel.Size = new System.Drawing.Size(212, 36);
            this.SearchQuoteLabel.TabIndex = 1;
            this.SearchQuoteLabel.Text = "Search Quotes";
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.orderDate,
            this.rushOrder,
            this.price,
            this.depth,
            this.width,
            this.numberOfDrawers,
            this.surfaceMaterial,
            this.desk});
            this.searchQuotes.Location = new System.Drawing.Point(59, 112);
            this.searchQuotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.RowHeadersWidth = 62;
            this.searchQuotes.RowTemplate.Height = 28;
            this.searchQuotes.Size = new System.Drawing.Size(948, 330);
            this.searchQuotes.TabIndex = 3;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Customer Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // orderDate
            // 
            this.orderDate.DataPropertyName = "OrderDate";
            this.orderDate.HeaderText = "Date Ordered";
            this.orderDate.MinimumWidth = 8;
            this.orderDate.Name = "orderDate";
            this.orderDate.Width = 90;
            // 
            // rushOrder
            // 
            this.rushOrder.DataPropertyName = "RushOrder";
            this.rushOrder.HeaderText = "Production Time";
            this.rushOrder.MinimumWidth = 8;
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 70;
            // 
            // depth
            // 
            this.depth.DataPropertyName = "Depth";
            this.depth.HeaderText = "Depth";
            this.depth.MinimumWidth = 8;
            this.depth.Name = "depth";
            this.depth.Width = 70;
            // 
            // width
            // 
            this.width.DataPropertyName = "Width";
            this.width.HeaderText = "Width";
            this.width.MinimumWidth = 8;
            this.width.Name = "width";
            this.width.Width = 70;
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.DataPropertyName = "NumberofDrawers";
            this.numberOfDrawers.HeaderText = "Drawers";
            this.numberOfDrawers.MinimumWidth = 8;
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Width = 70;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.DataPropertyName = "SurfaceMaterial";
            this.surfaceMaterial.HeaderText = "Surface Materials";
            this.surfaceMaterial.MinimumWidth = 8;
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Width = 70;
            // 
            // desk
            // 
            this.desk.DataPropertyName = "Desk";
            this.desk.HeaderText = "Desk";
            this.desk.MinimumWidth = 8;
            this.desk.Name = "desk";
            this.desk.Visible = false;
            this.desk.Width = 150;
            // 
            // materialFilterPicker
            // 
            this.materialFilterPicker.FormattingEnabled = true;
            this.materialFilterPicker.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.materialFilterPicker.Location = new System.Drawing.Point(59, 42);
            this.materialFilterPicker.Margin = new System.Windows.Forms.Padding(4);
            this.materialFilterPicker.Name = "materialFilterPicker";
            this.materialFilterPicker.Size = new System.Drawing.Size(160, 24);
            this.materialFilterPicker.TabIndex = 6;
            this.materialFilterPicker.Text = "filter search";
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.filter.Location = new System.Drawing.Point(59, 73);
            this.filter.Margin = new System.Windows.Forms.Padding(4);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(141, 33);
            this.filter.TabIndex = 8;
            this.filter.Text = "Filter Quotes";
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // SearchQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.materialFilterPicker);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.SearchQuoteLabel);
            this.Controls.Add(this.SearchReturnButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchQuoteForm";
            this.Text = "SearchQuoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchReturnButton;
        private System.Windows.Forms.Label SearchQuoteLabel;
        private System.Windows.Forms.DataGridView searchQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk;
        private System.Windows.Forms.ComboBox materialFilterPicker;
        private System.Windows.Forms.Button filter;
    }
}