namespace TrainTicketManagementSystemProject
{
    partial class CustomerPanelTransaction
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTrain = new System.Windows.Forms.Label();
            this.panelTrainStatus = new System.Windows.Forms.Panel();
            this.txtSelectedSeats = new System.Windows.Forms.ComboBox();
            this.Buybtn = new System.Windows.Forms.Button();
            this.lblNumberofSeats = new System.Windows.Forms.Label();
            this.radiobtn1stClass = new System.Windows.Forms.RadioButton();
            this.radiobtnCabin = new System.Windows.Forms.RadioButton();
            this.radioBtnBusiness = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1st = new System.Windows.Forms.TextBox();
            this.txtcabin = new System.Windows.Forms.TextBox();
            this.txtbusiness = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.Traintxt = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelTrainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(57, 53);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(167, 35);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Instructions";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(81, 108);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(876, 20);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "1. A customer can buy maximum of 6 1st class seats or 2 cabin class seats or 3 bu" +
    "siness class seats.";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(81, 143);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(406, 20);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "2. Only today\'s schedule tickets can be bought.";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(81, 177);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(922, 20);
            this.lbl3.TabIndex = 27;
            this.lbl3.Text = "3. A customer can only buy once. if there is to be another transaction, the previ" +
    "ous ticket must be cancelled.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 10);
            this.panel1.TabIndex = 28;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(28, 263);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(198, 20);
            this.lblLocation.TabIndex = 29;
            this.lblLocation.Text = "Choose your Location:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(28, 311);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(218, 20);
            this.lblDestination.TabIndex = 30;
            this.lblDestination.Text = "Choose your destination:";
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(28, 502);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(112, 20);
            this.lblTrain.TabIndex = 31;
            this.lblTrain.Text = "Train Name:";
            // 
            // panelTrainStatus
            // 
            this.panelTrainStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrainStatus.Controls.Add(this.txtSelectedSeats);
            this.panelTrainStatus.Controls.Add(this.Buybtn);
            this.panelTrainStatus.Controls.Add(this.lblNumberofSeats);
            this.panelTrainStatus.Controls.Add(this.radiobtn1stClass);
            this.panelTrainStatus.Controls.Add(this.radiobtnCabin);
            this.panelTrainStatus.Controls.Add(this.radioBtnBusiness);
            this.panelTrainStatus.Controls.Add(this.lblType);
            this.panelTrainStatus.Controls.Add(this.label3);
            this.panelTrainStatus.Controls.Add(this.label4);
            this.panelTrainStatus.Controls.Add(this.label5);
            this.panelTrainStatus.Controls.Add(this.txt1st);
            this.panelTrainStatus.Controls.Add(this.txtcabin);
            this.panelTrainStatus.Controls.Add(this.txtbusiness);
            this.panelTrainStatus.Controls.Add(this.lblAvailable);
            this.panelTrainStatus.Controls.Add(this.txttotal);
            this.panelTrainStatus.Controls.Add(this.label6);
            this.panelTrainStatus.Controls.Add(this.label7);
            this.panelTrainStatus.Controls.Add(this.label8);
            this.panelTrainStatus.Location = new System.Drawing.Point(442, 237);
            this.panelTrainStatus.Name = "panelTrainStatus";
            this.panelTrainStatus.Size = new System.Drawing.Size(623, 347);
            this.panelTrainStatus.TabIndex = 32;
            // 
            // txtSelectedSeats
            // 
            this.txtSelectedSeats.FormattingEnabled = true;
            this.txtSelectedSeats.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txtSelectedSeats.Location = new System.Drawing.Point(567, 196);
            this.txtSelectedSeats.Name = "txtSelectedSeats";
            this.txtSelectedSeats.Size = new System.Drawing.Size(51, 24);
            this.txtSelectedSeats.TabIndex = 34;
            this.txtSelectedSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSelectedSeats_KeyPress);
            // 
            // Buybtn
            // 
            this.Buybtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buybtn.Location = new System.Drawing.Point(437, 277);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(150, 45);
            this.Buybtn.TabIndex = 33;
            this.Buybtn.Text = "Buy Ticket";
            this.Buybtn.UseVisualStyleBackColor = true;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // lblNumberofSeats
            // 
            this.lblNumberofSeats.AutoSize = true;
            this.lblNumberofSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberofSeats.Location = new System.Drawing.Point(264, 195);
            this.lblNumberofSeats.Name = "lblNumberofSeats";
            this.lblNumberofSeats.Size = new System.Drawing.Size(266, 25);
            this.lblNumberofSeats.TabIndex = 31;
            this.lblNumberofSeats.Text = "Choose Number Of Seats:";
            // 
            // radiobtn1stClass
            // 
            this.radiobtn1stClass.AutoSize = true;
            this.radiobtn1stClass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn1stClass.Location = new System.Drawing.Point(24, 296);
            this.radiobtn1stClass.Name = "radiobtn1stClass";
            this.radiobtn1stClass.Size = new System.Drawing.Size(114, 26);
            this.radiobtn1stClass.TabIndex = 30;
            this.radiobtn1stClass.TabStop = true;
            this.radiobtn1stClass.Text = "1st Class";
            this.radiobtn1stClass.UseVisualStyleBackColor = true;
            // 
            // radiobtnCabin
            // 
            this.radiobtnCabin.AutoSize = true;
            this.radiobtnCabin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnCabin.Location = new System.Drawing.Point(24, 264);
            this.radiobtnCabin.Name = "radiobtnCabin";
            this.radiobtnCabin.Size = new System.Drawing.Size(139, 26);
            this.radiobtnCabin.TabIndex = 29;
            this.radiobtnCabin.TabStop = true;
            this.radiobtnCabin.Text = "Cabin Class";
            this.radiobtnCabin.UseVisualStyleBackColor = true;
            // 
            // radioBtnBusiness
            // 
            this.radioBtnBusiness.AutoSize = true;
            this.radioBtnBusiness.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnBusiness.Location = new System.Drawing.Point(24, 232);
            this.radioBtnBusiness.Name = "radioBtnBusiness";
            this.radioBtnBusiness.Size = new System.Drawing.Size(168, 26);
            this.radioBtnBusiness.TabIndex = 28;
            this.radioBtnBusiness.TabStop = true;
            this.radioBtnBusiness.Text = "Business Class";
            this.radioBtnBusiness.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(19, 195);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(200, 25);
            this.lblType.TabIndex = 27;
            this.lblType.Text = "Choose Seat Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "[Available]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "[Available]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "[Available]";
            // 
            // txt1st
            // 
            this.txt1st.Location = new System.Drawing.Point(269, 146);
            this.txt1st.Name = "txt1st";
            this.txt1st.ReadOnly = true;
            this.txt1st.Size = new System.Drawing.Size(50, 22);
            this.txt1st.TabIndex = 23;
            // 
            // txtcabin
            // 
            this.txtcabin.Location = new System.Drawing.Point(269, 109);
            this.txtcabin.Name = "txtcabin";
            this.txtcabin.ReadOnly = true;
            this.txtcabin.Size = new System.Drawing.Size(50, 22);
            this.txtcabin.TabIndex = 22;
            // 
            // txtbusiness
            // 
            this.txtbusiness.Location = new System.Drawing.Point(269, 73);
            this.txtbusiness.Name = "txtbusiness";
            this.txtbusiness.ReadOnly = true;
            this.txtbusiness.Size = new System.Drawing.Size(50, 22);
            this.txtbusiness.TabIndex = 21;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(19, 25);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(225, 25);
            this.lblAvailable.TabIndex = 20;
            this.lblAvailable.Text = "Total Seats Available:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(269, 29);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(50, 22);
            this.txttotal.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "1st Class:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cabin Class:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Business Class:";
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Items.AddRange(new object[] {
            "Dhaka",
            "Sylhet",
            "Chattogram",
            "Rangpur"});
            this.comboBoxDestination.Location = new System.Drawing.Point(283, 307);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDestination.TabIndex = 33;
            this.comboBoxDestination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestination_SelectedIndexChanged);
            this.comboBoxDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDestination_KeyPress);
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Dhaka",
            "Sylhet",
            "Chattogram",
            "Rangpur"});
            this.comboBoxLocation.Location = new System.Drawing.Point(283, 259);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLocation.TabIndex = 34;
            this.comboBoxLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxLocation_KeyPress);
            // 
            // Traintxt
            // 
            this.Traintxt.Location = new System.Drawing.Point(283, 502);
            this.Traintxt.Name = "Traintxt";
            this.Traintxt.Size = new System.Drawing.Size(121, 22);
            this.Traintxt.TabIndex = 35;
            this.Traintxt.TextChanged += new System.EventHandler(this.Traintxt_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(32, 359);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 45);
            this.btnConfirm.TabIndex = 36;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CustomerPanelTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 596);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Traintxt);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.panelTrainStatus);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblInstructions);
            this.Name = "CustomerPanelTransaction";
            this.Text = "TTMS: Customer Panel";
            this.Load += new System.EventHandler(this.CustomerPanelTransaction_Load);
            this.panelTrainStatus.ResumeLayout(false);
            this.panelTrainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Panel panelTrainStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1st;
        private System.Windows.Forms.TextBox txtcabin;
        private System.Windows.Forms.TextBox txtbusiness;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNumberofSeats;
        private System.Windows.Forms.RadioButton radiobtn1stClass;
        private System.Windows.Forms.RadioButton radiobtnCabin;
        private System.Windows.Forms.RadioButton radioBtnBusiness;
        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.TextBox Traintxt;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox txtSelectedSeats;
    }
}