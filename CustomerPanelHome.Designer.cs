namespace TrainTicketManagementSystemProject
{
    partial class CustomerPanelHome
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
            this.Buybtn = new System.Windows.Forms.Button();
            this.ShowTicketbtn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buybtn
            // 
            this.Buybtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buybtn.Location = new System.Drawing.Point(31, 48);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(150, 45);
            this.Buybtn.TabIndex = 13;
            this.Buybtn.Text = "Buy Ticket";
            this.Buybtn.UseVisualStyleBackColor = true;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // ShowTicketbtn
            // 
            this.ShowTicketbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTicketbtn.Location = new System.Drawing.Point(202, 48);
            this.ShowTicketbtn.Name = "ShowTicketbtn";
            this.ShowTicketbtn.Size = new System.Drawing.Size(150, 45);
            this.ShowTicketbtn.TabIndex = 14;
            this.ShowTicketbtn.Text = "Show Ticket";
            this.ShowTicketbtn.UseVisualStyleBackColor = true;
            this.ShowTicketbtn.Click += new System.EventHandler(this.ShowTicketbtn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(31, 108);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 45);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(202, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel Ticket";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustomerPanelHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 193);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.ShowTicketbtn);
            this.Controls.Add(this.Buybtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerPanelHome";
            this.Text = "TTMS: Customer Panel";
            this.Load += new System.EventHandler(this.CustomerPanelHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.Button ShowTicketbtn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCancel;
    }
}