namespace TrainTicketManagementSystemProject
{
    partial class CustomerInfo
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblYourId = new System.Windows.Forms.Label();
            this.lblYourPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 25);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "Your ID:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(12, 103);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(164, 25);
            this.lblPass.TabIndex = 21;
            this.lblPass.Text = "Your Password:";
            // 
            // lblYourId
            // 
            this.lblYourId.AutoSize = true;
            this.lblYourId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourId.Location = new System.Drawing.Point(182, 46);
            this.lblYourId.Name = "lblYourId";
            this.lblYourId.Size = new System.Drawing.Size(30, 25);
            this.lblYourId.TabIndex = 22;
            this.lblYourId.Text = "...";
            // 
            // lblYourPass
            // 
            this.lblYourPass.AutoSize = true;
            this.lblYourPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourPass.Location = new System.Drawing.Point(182, 103);
            this.lblYourPass.Name = "lblYourPass";
            this.lblYourPass.Size = new System.Drawing.Size(30, 25);
            this.lblYourPass.TabIndex = 23;
            this.lblYourPass.Text = "...";
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 185);
            this.Controls.Add(this.lblYourPass);
            this.Controls.Add(this.lblYourId);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblID);
            this.Name = "CustomerInfo";
            this.Text = "Your Information";
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblYourId;
        private System.Windows.Forms.Label lblYourPass;
    }
}