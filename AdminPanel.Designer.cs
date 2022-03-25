namespace TrainTicketManagementSystemProject
{
    partial class AdminPanel
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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.radioBtnTrain = new System.Windows.Forms.RadioButton();
            this.radioBtnCustomer = new System.Windows.Forms.RadioButton();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.boxDelay = new System.Windows.Forms.ComboBox();
            this.firstClasstxt = new System.Windows.Forms.TextBox();
            this.cabinClasstxt = new System.Windows.Forms.TextBox();
            this.businessClasstxt = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.trainIdBox = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbl1st = new System.Windows.Forms.Label();
            this.lblCabin = new System.Windows.Forms.Label();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.lblIncreaseSeats = new System.Windows.Forms.Label();
            this.lblStartingTime = new System.Windows.Forms.Label();
            this.lblTrainId = new System.Windows.Forms.Label();
            this.panelTrainStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtAvailable1st = new System.Windows.Forms.TextBox();
            this.txtAvailableCabin = new System.Windows.Forms.TextBox();
            this.txtAvailableBusiness = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTrainName = new System.Windows.Forms.TextBox();
            this.boxShowTrainId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.lblTrainName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.CancelTicketCheckBox = new System.Windows.Forms.CheckBox();
            this.TIDtxt = new System.Windows.Forms.TextBox();
            this.lblTID = new System.Windows.Forms.Label();
            this.SeatTypetxt = new System.Windows.Forms.TextBox();
            this.SeatNotxt = new System.Windows.Forms.TextBox();
            this.customerNametxt = new System.Windows.Forms.TextBox();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.CustomerUpdatebtn = new System.Windows.Forms.Button();
            this.lblCancelTicket = new System.Windows.Forms.Label();
            this.lblSeatType = new System.Windows.Forms.Label();
            this.lblSeatNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.ViewReqbtn = new System.Windows.Forms.Button();
            this.ViewCustomerbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelTrain.SuspendLayout();
            this.panelTrainStatus.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(29, 26);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(74, 20);
            this.lblUpdate.TabIndex = 5;
            this.lblUpdate.Text = "Update:";
            // 
            // radioBtnTrain
            // 
            this.radioBtnTrain.AutoSize = true;
            this.radioBtnTrain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTrain.Location = new System.Drawing.Point(123, 22);
            this.radioBtnTrain.Name = "radioBtnTrain";
            this.radioBtnTrain.Size = new System.Drawing.Size(78, 26);
            this.radioBtnTrain.TabIndex = 6;
            this.radioBtnTrain.TabStop = true;
            this.radioBtnTrain.Text = "Train";
            this.radioBtnTrain.UseVisualStyleBackColor = true;
            this.radioBtnTrain.CheckedChanged += new System.EventHandler(this.radioBtnTrain_CheckedChanged);
            // 
            // radioBtnCustomer
            // 
            this.radioBtnCustomer.AutoSize = true;
            this.radioBtnCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCustomer.Location = new System.Drawing.Point(217, 20);
            this.radioBtnCustomer.Name = "radioBtnCustomer";
            this.radioBtnCustomer.Size = new System.Drawing.Size(120, 26);
            this.radioBtnCustomer.TabIndex = 7;
            this.radioBtnCustomer.TabStop = true;
            this.radioBtnCustomer.Text = "Customer";
            this.radioBtnCustomer.UseVisualStyleBackColor = true;
            this.radioBtnCustomer.CheckedChanged += new System.EventHandler(this.radioBtnCustomer_CheckedChanged);
            // 
            // panelTrain
            // 
            this.panelTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrain.Controls.Add(this.boxDelay);
            this.panelTrain.Controls.Add(this.firstClasstxt);
            this.panelTrain.Controls.Add(this.cabinClasstxt);
            this.panelTrain.Controls.Add(this.businessClasstxt);
            this.panelTrain.Controls.Add(this.lblMinutes);
            this.panelTrain.Controls.Add(this.trainIdBox);
            this.panelTrain.Controls.Add(this.btnUpdate);
            this.panelTrain.Controls.Add(this.lbl1st);
            this.panelTrain.Controls.Add(this.lblCabin);
            this.panelTrain.Controls.Add(this.lblBusiness);
            this.panelTrain.Controls.Add(this.lblIncreaseSeats);
            this.panelTrain.Controls.Add(this.lblStartingTime);
            this.panelTrain.Controls.Add(this.lblTrainId);
            this.panelTrain.Location = new System.Drawing.Point(33, 70);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(473, 253);
            this.panelTrain.TabIndex = 8;
            // 
            // boxDelay
            // 
            this.boxDelay.FormattingEnabled = true;
            this.boxDelay.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.boxDelay.Location = new System.Drawing.Point(228, 50);
            this.boxDelay.Name = "boxDelay";
            this.boxDelay.Size = new System.Drawing.Size(54, 24);
            this.boxDelay.TabIndex = 19;
            this.boxDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxDelay_KeyPress);
            // 
            // firstClasstxt
            // 
            this.firstClasstxt.Location = new System.Drawing.Point(196, 202);
            this.firstClasstxt.Name = "firstClasstxt";
            this.firstClasstxt.Size = new System.Drawing.Size(50, 22);
            this.firstClasstxt.TabIndex = 18;
            this.firstClasstxt.Text = "0";
            this.firstClasstxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstClasstxt_KeyPress);
            // 
            // cabinClasstxt
            // 
            this.cabinClasstxt.Location = new System.Drawing.Point(196, 168);
            this.cabinClasstxt.Name = "cabinClasstxt";
            this.cabinClasstxt.Size = new System.Drawing.Size(50, 22);
            this.cabinClasstxt.TabIndex = 17;
            this.cabinClasstxt.Text = "0";
            this.cabinClasstxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cabinClasstxt_KeyPress);
            // 
            // businessClasstxt
            // 
            this.businessClasstxt.Location = new System.Drawing.Point(196, 135);
            this.businessClasstxt.Name = "businessClasstxt";
            this.businessClasstxt.Size = new System.Drawing.Size(50, 22);
            this.businessClasstxt.TabIndex = 16;
            this.businessClasstxt.Text = "0";
            this.businessClasstxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.businessClasstxt_KeyPress);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(284, 52);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(75, 20);
            this.lblMinutes.TabIndex = 15;
            this.lblMinutes.Text = "Minutes";
            // 
            // trainIdBox
            // 
            this.trainIdBox.FormattingEnabled = true;
            this.trainIdBox.Items.AddRange(new object[] {
            "T-001-D",
            "T-001-N",
            "T-002-D",
            "T-002-N",
            "T-003-D",
            "T-003-N",
            "T-004-D",
            "T-004-N",
            "T-005-D",
            "T-005-N",
            "T-006-D",
            "T-006-N"});
            this.trainIdBox.Location = new System.Drawing.Point(228, 12);
            this.trainIdBox.Name = "trainIdBox";
            this.trainIdBox.Size = new System.Drawing.Size(121, 24);
            this.trainIdBox.TabIndex = 13;
            this.trainIdBox.SelectedIndexChanged += new System.EventHandler(this.trainIdBox_SelectedIndexChanged);
            this.trainIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trainIdBox_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(363, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 33);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbl1st
            // 
            this.lbl1st.AutoSize = true;
            this.lbl1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1st.Location = new System.Drawing.Point(34, 202);
            this.lbl1st.Name = "lbl1st";
            this.lbl1st.Size = new System.Drawing.Size(95, 20);
            this.lbl1st.TabIndex = 11;
            this.lbl1st.Text = "1st Class:";
            // 
            // lblCabin
            // 
            this.lblCabin.AutoSize = true;
            this.lblCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabin.Location = new System.Drawing.Point(34, 170);
            this.lblCabin.Name = "lblCabin";
            this.lblCabin.Size = new System.Drawing.Size(117, 20);
            this.lblCabin.TabIndex = 10;
            this.lblCabin.Text = "Cabin Class:";
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusiness.Location = new System.Drawing.Point(34, 137);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(147, 20);
            this.lblBusiness.TabIndex = 9;
            this.lblBusiness.Text = "Business Class:";
            // 
            // lblIncreaseSeats
            // 
            this.lblIncreaseSeats.AutoSize = true;
            this.lblIncreaseSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncreaseSeats.Location = new System.Drawing.Point(17, 92);
            this.lblIncreaseSeats.Name = "lblIncreaseSeats";
            this.lblIncreaseSeats.Size = new System.Drawing.Size(164, 25);
            this.lblIncreaseSeats.TabIndex = 8;
            this.lblIncreaseSeats.Text = "Increase Seats:";
            // 
            // lblStartingTime
            // 
            this.lblStartingTime.AutoSize = true;
            this.lblStartingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingTime.Location = new System.Drawing.Point(17, 50);
            this.lblStartingTime.Name = "lblStartingTime";
            this.lblStartingTime.Size = new System.Drawing.Size(190, 20);
            this.lblStartingTime.TabIndex = 7;
            this.lblStartingTime.Text = "Starting Time(Delay):";
            // 
            // lblTrainId
            // 
            this.lblTrainId.AutoSize = true;
            this.lblTrainId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainId.Location = new System.Drawing.Point(17, 16);
            this.lblTrainId.Name = "lblTrainId";
            this.lblTrainId.Size = new System.Drawing.Size(83, 20);
            this.lblTrainId.TabIndex = 6;
            this.lblTrainId.Text = "Train ID:";
            // 
            // panelTrainStatus
            // 
            this.panelTrainStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrainStatus.Controls.Add(this.label1);
            this.panelTrainStatus.Controls.Add(this.lbl3);
            this.panelTrainStatus.Controls.Add(this.lbl2);
            this.panelTrainStatus.Controls.Add(this.lbl1);
            this.panelTrainStatus.Controls.Add(this.txtAvailable1st);
            this.panelTrainStatus.Controls.Add(this.txtAvailableCabin);
            this.panelTrainStatus.Controls.Add(this.txtAvailableBusiness);
            this.panelTrainStatus.Controls.Add(this.txtTotal);
            this.panelTrainStatus.Controls.Add(this.txtTrainName);
            this.panelTrainStatus.Controls.Add(this.boxShowTrainId);
            this.panelTrainStatus.Controls.Add(this.label2);
            this.panelTrainStatus.Controls.Add(this.label3);
            this.panelTrainStatus.Controls.Add(this.label4);
            this.panelTrainStatus.Controls.Add(this.lblTotalSeats);
            this.panelTrainStatus.Controls.Add(this.lblTrainName);
            this.panelTrainStatus.Controls.Add(this.label7);
            this.panelTrainStatus.Location = new System.Drawing.Point(566, 70);
            this.panelTrainStatus.Name = "panelTrainStatus";
            this.panelTrainStatus.Size = new System.Drawing.Size(477, 303);
            this.panelTrainStatus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "[Available]";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(350, 252);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(97, 20);
            this.lbl3.TabIndex = 26;
            this.lbl3.Text = "[Available]";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(350, 218);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 20);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "[Available]";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(348, 183);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(97, 20);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "[Available]";
            // 
            // txtAvailable1st
            // 
            this.txtAvailable1st.Location = new System.Drawing.Point(292, 250);
            this.txtAvailable1st.Name = "txtAvailable1st";
            this.txtAvailable1st.ReadOnly = true;
            this.txtAvailable1st.Size = new System.Drawing.Size(50, 22);
            this.txtAvailable1st.TabIndex = 23;
            // 
            // txtAvailableCabin
            // 
            this.txtAvailableCabin.Location = new System.Drawing.Point(292, 216);
            this.txtAvailableCabin.Name = "txtAvailableCabin";
            this.txtAvailableCabin.ReadOnly = true;
            this.txtAvailableCabin.Size = new System.Drawing.Size(50, 22);
            this.txtAvailableCabin.TabIndex = 22;
            // 
            // txtAvailableBusiness
            // 
            this.txtAvailableBusiness.Location = new System.Drawing.Point(292, 183);
            this.txtAvailableBusiness.Name = "txtAvailableBusiness";
            this.txtAvailableBusiness.ReadOnly = true;
            this.txtAvailableBusiness.Size = new System.Drawing.Size(50, 22);
            this.txtAvailableBusiness.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(292, 139);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 22);
            this.txtTotal.TabIndex = 16;
            // 
            // txtTrainName
            // 
            this.txtTrainName.Location = new System.Drawing.Point(153, 78);
            this.txtTrainName.Name = "txtTrainName";
            this.txtTrainName.ReadOnly = true;
            this.txtTrainName.Size = new System.Drawing.Size(200, 22);
            this.txtTrainName.TabIndex = 14;
            // 
            // boxShowTrainId
            // 
            this.boxShowTrainId.FormattingEnabled = true;
            this.boxShowTrainId.Items.AddRange(new object[] {
            "T-001-D",
            "T-001-N",
            "T-002-D",
            "T-002-N",
            "T-003-D",
            "T-003-N",
            "T-004-D",
            "T-004-N",
            "T-005-D",
            "T-005-N",
            "T-006-D",
            "T-006-N"});
            this.boxShowTrainId.Location = new System.Drawing.Point(153, 39);
            this.boxShowTrainId.Name = "boxShowTrainId";
            this.boxShowTrainId.Size = new System.Drawing.Size(121, 24);
            this.boxShowTrainId.TabIndex = 13;
            this.boxShowTrainId.SelectedIndexChanged += new System.EventHandler(this.boxShowTrainId_SelectedIndexChanged);
            this.boxShowTrainId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxShowTrainId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "1st Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cabin Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Business Class:";
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeats.Location = new System.Drawing.Point(16, 136);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(130, 25);
            this.lblTotalSeats.TabIndex = 8;
            this.lblTotalSeats.Text = "Total Seats:";
            // 
            // lblTrainName
            // 
            this.lblTrainName.AutoSize = true;
            this.lblTrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainName.Location = new System.Drawing.Point(17, 80);
            this.lblTrainName.Name = "lblTrainName";
            this.lblTrainName.Size = new System.Drawing.Size(112, 20);
            this.lblTrainName.TabIndex = 7;
            this.lblTrainName.Text = "Train Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Train ID:";
            // 
            // panelCustomer
            // 
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.txtEmail);
            this.panelCustomer.Controls.Add(this.txtPhone);
            this.panelCustomer.Controls.Add(this.lblEmail);
            this.panelCustomer.Controls.Add(this.lblPhone);
            this.panelCustomer.Controls.Add(this.CancelTicketCheckBox);
            this.panelCustomer.Controls.Add(this.TIDtxt);
            this.panelCustomer.Controls.Add(this.lblTID);
            this.panelCustomer.Controls.Add(this.SeatTypetxt);
            this.panelCustomer.Controls.Add(this.SeatNotxt);
            this.panelCustomer.Controls.Add(this.customerNametxt);
            this.panelCustomer.Controls.Add(this.comboBoxCustomerId);
            this.panelCustomer.Controls.Add(this.CustomerUpdatebtn);
            this.panelCustomer.Controls.Add(this.lblCancelTicket);
            this.panelCustomer.Controls.Add(this.lblSeatType);
            this.panelCustomer.Controls.Add(this.lblSeatNo);
            this.panelCustomer.Controls.Add(this.lblCustomerName);
            this.panelCustomer.Controls.Add(this.lblCustomerId);
            this.panelCustomer.Location = new System.Drawing.Point(33, 70);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(473, 316);
            this.panelCustomer.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(228, 84);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 22);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(149, 20);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Customer Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(18, 86);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(177, 20);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Customer PhoneNo:";
            // 
            // CancelTicketCheckBox
            // 
            this.CancelTicketCheckBox.AutoSize = true;
            this.CancelTicketCheckBox.Location = new System.Drawing.Point(163, 268);
            this.CancelTicketCheckBox.Name = "CancelTicketCheckBox";
            this.CancelTicketCheckBox.Size = new System.Drawing.Size(18, 17);
            this.CancelTicketCheckBox.TabIndex = 21;
            this.CancelTicketCheckBox.UseVisualStyleBackColor = true;
            // 
            // TIDtxt
            // 
            this.TIDtxt.Location = new System.Drawing.Point(228, 163);
            this.TIDtxt.Name = "TIDtxt";
            this.TIDtxt.ReadOnly = true;
            this.TIDtxt.Size = new System.Drawing.Size(63, 22);
            this.TIDtxt.TabIndex = 20;
            // 
            // lblTID
            // 
            this.lblTID.AutoSize = true;
            this.lblTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTID.Location = new System.Drawing.Point(19, 170);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(83, 20);
            this.lblTID.TabIndex = 19;
            this.lblTID.Text = "Train ID:";
            // 
            // SeatTypetxt
            // 
            this.SeatTypetxt.Location = new System.Drawing.Point(228, 230);
            this.SeatTypetxt.Name = "SeatTypetxt";
            this.SeatTypetxt.ReadOnly = true;
            this.SeatTypetxt.Size = new System.Drawing.Size(153, 22);
            this.SeatTypetxt.TabIndex = 17;
            // 
            // SeatNotxt
            // 
            this.SeatNotxt.Location = new System.Drawing.Point(228, 196);
            this.SeatNotxt.Name = "SeatNotxt";
            this.SeatNotxt.ReadOnly = true;
            this.SeatNotxt.Size = new System.Drawing.Size(63, 22);
            this.SeatNotxt.TabIndex = 16;
            // 
            // customerNametxt
            // 
            this.customerNametxt.Location = new System.Drawing.Point(228, 50);
            this.customerNametxt.Name = "customerNametxt";
            this.customerNametxt.Size = new System.Drawing.Size(181, 22);
            this.customerNametxt.TabIndex = 14;
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCustomerId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(228, 12);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCustomerId.TabIndex = 13;
            this.comboBoxCustomerId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerId_SelectedIndexChanged);
            this.comboBoxCustomerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCustomerId_KeyPress);
            // 
            // CustomerUpdatebtn
            // 
            this.CustomerUpdatebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerUpdatebtn.Location = new System.Drawing.Point(363, 269);
            this.CustomerUpdatebtn.Name = "CustomerUpdatebtn";
            this.CustomerUpdatebtn.Size = new System.Drawing.Size(91, 33);
            this.CustomerUpdatebtn.TabIndex = 12;
            this.CustomerUpdatebtn.Text = "Update";
            this.CustomerUpdatebtn.UseVisualStyleBackColor = true;
            this.CustomerUpdatebtn.Click += new System.EventHandler(this.CustomerUpdatebtn_Click);
            // 
            // lblCancelTicket
            // 
            this.lblCancelTicket.AutoSize = true;
            this.lblCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelTicket.Location = new System.Drawing.Point(17, 265);
            this.lblCancelTicket.Name = "lblCancelTicket";
            this.lblCancelTicket.Size = new System.Drawing.Size(130, 20);
            this.lblCancelTicket.TabIndex = 11;
            this.lblCancelTicket.Text = "Cancel Ticket:";
            // 
            // lblSeatType
            // 
            this.lblSeatType.AutoSize = true;
            this.lblSeatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatType.Location = new System.Drawing.Point(19, 232);
            this.lblSeatType.Name = "lblSeatType";
            this.lblSeatType.Size = new System.Drawing.Size(99, 20);
            this.lblSeatType.TabIndex = 10;
            this.lblSeatType.Text = "Seat Type:";
            // 
            // lblSeatNo
            // 
            this.lblSeatNo.AutoSize = true;
            this.lblSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNo.Location = new System.Drawing.Point(19, 202);
            this.lblSeatNo.Name = "lblSeatNo";
            this.lblSeatNo.Size = new System.Drawing.Size(122, 20);
            this.lblSeatNo.TabIndex = 9;
            this.lblSeatNo.Text = "Seat Amount:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(17, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(150, 20);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(17, 16);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(121, 20);
            this.lblCustomerId.TabIndex = 6;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // ViewReqbtn
            // 
            this.ViewReqbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReqbtn.Location = new System.Drawing.Point(818, 407);
            this.ViewReqbtn.Name = "ViewReqbtn";
            this.ViewReqbtn.Size = new System.Drawing.Size(194, 33);
            this.ViewReqbtn.TabIndex = 13;
            this.ViewReqbtn.Text = "View Request >>";
            this.ViewReqbtn.UseVisualStyleBackColor = true;
            this.ViewReqbtn.Click += new System.EventHandler(this.ViewReqbtn_Click);
            // 
            // ViewCustomerbtn
            // 
            this.ViewCustomerbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomerbtn.Location = new System.Drawing.Point(818, 462);
            this.ViewCustomerbtn.Name = "ViewCustomerbtn";
            this.ViewCustomerbtn.Size = new System.Drawing.Size(225, 33);
            this.ViewCustomerbtn.TabIndex = 14;
            this.ViewCustomerbtn.Text = "View Customer Info >>";
            this.ViewCustomerbtn.UseVisualStyleBackColor = true;
            this.ViewCustomerbtn.Click += new System.EventHandler(this.ViewCustomerbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(33, 462);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(102, 33);
            this.Logoutbtn.TabIndex = 15;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(33, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 42);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset Data";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 530);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.ViewCustomerbtn);
            this.Controls.Add(this.ViewReqbtn);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelTrainStatus);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.radioBtnCustomer);
            this.Controls.Add(this.radioBtnTrain);
            this.Controls.Add(this.lblUpdate);
            this.Name = "AdminPanel";
            this.Text = "TTMS: Admin";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panelTrain.ResumeLayout(false);
            this.panelTrain.PerformLayout();
            this.panelTrainStatus.ResumeLayout(false);
            this.panelTrainStatus.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.RadioButton radioBtnTrain;
        private System.Windows.Forms.RadioButton radioBtnCustomer;
        private System.Windows.Forms.Panel panelTrain;
        private System.Windows.Forms.Label lbl1st;
        private System.Windows.Forms.Label lblCabin;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Label lblIncreaseSeats;
        private System.Windows.Forms.Label lblStartingTime;
        private System.Windows.Forms.Label lblTrainId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox trainIdBox;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox cabinClasstxt;
        private System.Windows.Forms.TextBox businessClasstxt;
        private System.Windows.Forms.TextBox firstClasstxt;
        private System.Windows.Forms.Panel panelTrainStatus;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtAvailable1st;
        private System.Windows.Forms.TextBox txtAvailableCabin;
        private System.Windows.Forms.TextBox txtAvailableBusiness;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTrainName;
        private System.Windows.Forms.ComboBox boxShowTrainId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Label lblTrainName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.TextBox TIDtxt;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.TextBox SeatTypetxt;
        private System.Windows.Forms.TextBox SeatNotxt;
        private System.Windows.Forms.TextBox customerNametxt;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.Button CustomerUpdatebtn;
        private System.Windows.Forms.Label lblCancelTicket;
        private System.Windows.Forms.Label lblSeatType;
        private System.Windows.Forms.Label lblSeatNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.CheckBox CancelTicketCheckBox;
        private System.Windows.Forms.Button ViewReqbtn;
        private System.Windows.Forms.Button ViewCustomerbtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox boxDelay;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;

    }
}