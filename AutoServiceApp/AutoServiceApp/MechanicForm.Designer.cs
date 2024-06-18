namespace AutoServiceApp
{
    partial class MechanicForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnUpdateOrderStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(15, 330);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(250, 25);
            this.btnViewOrders.TabIndex = 1;
            this.btnViewOrders.Text = "Просмотр заказов";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(15, 370);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(250, 25);
            this.btnUpdateOrderStatus.TabIndex = 2;
            this.btnUpdateOrderStatus.Text = "Обновить статус заказа";
            this.btnUpdateOrderStatus.UseVisualStyleBackColor = true;
            this.btnUpdateOrderStatus.Click += new System.EventHandler(this.btnUpdateOrderStatus_Click);
            // 
            // MechanicForm
            // 
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.btnUpdateOrderStatus);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "MechanicForm";
            this.Text = "Автомеханик";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnUpdateOrderStatus;
    }
}
