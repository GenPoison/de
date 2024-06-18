namespace AutoServiceApp
{
    partial class MasterForm
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnViewOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(15, 15);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 22);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(15, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 120);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(15, 155);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(250, 22);
            this.txtMiddleName.TabIndex = 4;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(15, 190);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(250, 24);
            this.cmbUserRole.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(15, 225);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(250, 25);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Добавить пользователя";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(15, 260);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(500, 200);
            this.dataGridViewOrders.TabIndex = 7;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(15, 470);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(250, 25);
            this.btnViewOrders.TabIndex = 8;
            this.btnViewOrders.Text = "Просмотр заказов";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // MasterForm
            // 
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Name = "MasterForm";
            this.Text = "Мастер приемщик";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnViewOrders;
    }
}
