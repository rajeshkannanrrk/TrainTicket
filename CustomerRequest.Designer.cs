namespace TrainTicketManagementSystemProject
{
    partial class CustomerRequest
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
            this.lblTicketCancel = new System.Windows.Forms.Label();
            this.gridviewCustomer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelAllbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketCancel
            // 
            this.lblTicketCancel.AutoSize = true;
            this.lblTicketCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCancel.Location = new System.Drawing.Point(12, 50);
            this.lblTicketCancel.Name = "lblTicketCancel";
            this.lblTicketCancel.Size = new System.Drawing.Size(398, 32);
            this.lblTicketCancel.TabIndex = 0;
            this.lblTicketCancel.Text = "Request For Ticket Cancellation";
            // 
            // gridviewCustomer
            // 
            this.gridviewCustomer.AllowUserToResizeColumns = false;
            this.gridviewCustomer.AllowUserToResizeRows = false;
            this.gridviewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.gridviewCustomer.Location = new System.Drawing.Point(18, 123);
            this.gridviewCustomer.Name = "gridviewCustomer";
            this.gridviewCustomer.RowTemplate.Height = 24;
            this.gridviewCustomer.Size = new System.Drawing.Size(356, 307);
            this.gridviewCustomer.TabIndex = 1;
            this.gridviewCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewCustomer_RowHeaderMouseClick);
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
            // CancelAllbtn
            // 
            this.CancelAllbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAllbtn.Location = new System.Drawing.Point(39, 444);
            this.CancelAllbtn.Name = "CancelAllbtn";
            this.CancelAllbtn.Size = new System.Drawing.Size(130, 33);
            this.CancelAllbtn.TabIndex = 13;
            this.CancelAllbtn.Text = "Cancel All";
            this.CancelAllbtn.UseVisualStyleBackColor = true;
            this.CancelAllbtn.Click += new System.EventHandler(this.CancelAllbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(175, 444);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(91, 33);
            this.Cancelbtn.TabIndex = 14;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // CustomerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 489);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.CancelAllbtn);
            this.Controls.Add(this.gridviewCustomer);
            this.Controls.Add(this.lblTicketCancel);
            this.Name = "CustomerRequest";
            this.Text = "TTMS: Customer Request";
            this.Load += new System.EventHandler(this.CustomerRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketCancel;
        private System.Windows.Forms.DataGridView gridviewCustomer;
        private System.Windows.Forms.Button CancelAllbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}