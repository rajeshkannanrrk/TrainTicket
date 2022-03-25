namespace TrainTicketManagementSystemProject
{
    partial class CustomerInformation
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
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.gridviewCustomer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(22, 33);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(281, 32);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "Customer Information";
            // 
            // gridviewCustomer
            // 
            this.gridviewCustomer.AllowUserToResizeColumns = false;
            this.gridviewCustomer.AllowUserToResizeRows = false;
            this.gridviewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.email,
            this.phone_number});
            this.gridviewCustomer.Location = new System.Drawing.Point(28, 95);
            this.gridviewCustomer.Name = "gridviewCustomer";
            this.gridviewCustomer.RowTemplate.Height = 24;
            this.gridviewCustomer.Size = new System.Drawing.Size(1004, 344);
            this.gridviewCustomer.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Customer ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Customer Name";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "Phone Number";
            this.phone_number.Name = "phone_number";
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 498);
            this.Controls.Add(this.gridviewCustomer);
            this.Controls.Add(this.lblCustomerInfo);
            this.Name = "CustomerInformation";
            this.Text = "TTMS: Customer Information";
            this.Load += new System.EventHandler(this.CustomerInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.DataGridView gridviewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
    }
}