namespace MegaDesk
{
    partial class ViewQuotesForm
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
            this.ReturnToHomeFromView = new System.Windows.Forms.Button();
            this.ViewQuotesLabel = new System.Windows.Forms.Label();
            this.viewQuotes = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDrawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToHomeFromView
            // 
            this.ReturnToHomeFromView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReturnToHomeFromView.Location = new System.Drawing.Point(932, 595);
            this.ReturnToHomeFromView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReturnToHomeFromView.Name = "ReturnToHomeFromView";
            this.ReturnToHomeFromView.Size = new System.Drawing.Size(186, 38);
            this.ReturnToHomeFromView.TabIndex = 0;
            this.ReturnToHomeFromView.Text = "Return To Home";
            this.ReturnToHomeFromView.UseVisualStyleBackColor = false;
            this.ReturnToHomeFromView.Click += new System.EventHandler(this.ReturnToHomeFromView_Click);
            // 
            // ViewQuotesLabel
            // 
            this.ViewQuotesLabel.AutoSize = true;
            this.ViewQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesLabel.Location = new System.Drawing.Point(429, 83);
            this.ViewQuotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewQuotesLabel.Name = "ViewQuotesLabel";
            this.ViewQuotesLabel.Size = new System.Drawing.Size(271, 40);
            this.ViewQuotesLabel.TabIndex = 1;
            this.ViewQuotesLabel.Text = "View All Quotes";
            // 
            // viewQuotes
            // 
            this.viewQuotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.orderDate,
            this.rushOrder,
            this.price,
            this.depth,
            this.width,
            this.numberOfDrawers,
            this.surfaceMaterial,
            this.desk});
            this.viewQuotes.Location = new System.Drawing.Point(66, 154);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.RowHeadersWidth = 62;
            this.viewQuotes.RowTemplate.Height = 28;
            this.viewQuotes.Size = new System.Drawing.Size(1066, 412);
            this.viewQuotes.TabIndex = 2;
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
            // ViewQuotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.ViewQuotesLabel);
            this.Controls.Add(this.ReturnToHomeFromView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewQuotesForm";
            this.Text = "ViewQuotesForm";
            this.Load += new System.EventHandler(this.ViewQuotesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToHomeFromView;
        private System.Windows.Forms.Label ViewQuotesLabel;
        private System.Windows.Forms.DataGridView viewQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDrawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk;
    }
}