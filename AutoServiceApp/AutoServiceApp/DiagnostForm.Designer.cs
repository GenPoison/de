namespace AutoServiceApp
{
    partial class DiagnostForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCarElement = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtAmountDamage = new System.Windows.Forms.TextBox();
            this.txtLiquids = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnViewOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarElement
            // 
            this.txtCarElement.Location = new System.Drawing.Point(15, 15);
            this.txtCarElement.Name = "txtCarElement";
            this.txtCarElement.Size = new System.Drawing.Size(250, 22);
            this.txtCarElement.TabIndex = 0;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(15, 50);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(250, 22);
            this.txtDetails.TabIndex = 1;
            // 
            // txtAmountDamage
            // 
            this.txtAmountDamage.Location = new System.Drawing.Point(15, 85);
            this.txtAmountDamage.Name = "txtAmountDamage";
            this.txtAmountDamage.Size = new System.Drawing.Size(250, 22);
            this.txtAmountDamage.TabIndex = 2;
            // 
            // txtLiquids
            // 
            this.txtLiquids.Location = new System.Drawing.Point(15, 120);
            this.txtLiquids.Name = "txtLiquids";
            this.txtLiquids.Size = new System.Drawing.Size(250, 22);
            this.txtLiquids.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(15, 155);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(250, 25);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "Создать заказ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(15, 190);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewOrders.TabIndex = 5;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(15, 400);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(250, 25);
            this.btnViewOrders.TabIndex = 6;
            this.btnViewOrders.Text = "Просмотр заказов";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // DiagnostForm
            // 
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.txtLiquids);
            this.Controls.Add(this.txtAmountDamage);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtCarElement);
            this.Name = "DiagnostForm";
            this.Text = "Автодиагност";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCarElement;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtAmountDamage;
        private System.Windows.Forms.TextBox txtLiquids;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnViewOrders;
    }
}