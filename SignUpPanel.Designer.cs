namespace TrainTicketManagementSystemProject
{
    partial class SignUpPanel
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.PhoneNotxt = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(235, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(235, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(201, 173);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(160, 218);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(138, 20);
            this.lblPhoneNo.TabIndex = 6;
            this.lblPhoneNo.Text = "Phone Number:";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(321, 78);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(209, 22);
            this.Nametxt.TabIndex = 7;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(321, 126);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(209, 22);
            this.Emailtxt.TabIndex = 8;
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(321, 173);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(209, 22);
            this.Passtxt.TabIndex = 9;
            this.Passtxt.UseSystemPasswordChar = true;
            // 
            // PhoneNotxt
            // 
            this.PhoneNotxt.Location = new System.Drawing.Point(321, 216);
            this.PhoneNotxt.Name = "PhoneNotxt";
            this.PhoneNotxt.Size = new System.Drawing.Size(209, 22);
            this.PhoneNotxt.TabIndex = 10;
            this.PhoneNotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNotxt_KeyPress);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(281, 267);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(91, 33);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(396, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 33);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SignUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 397);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.PhoneNotxt);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Name = "SignUpPanel";
            this.Text = "TTMS: SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox PhoneNotxt;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBack;
    }
}