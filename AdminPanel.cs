using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrainTicketManagementSystemProject
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            radioBtnTrain.Checked = true;
            
        }

        DataAccess db = new DataAccess();

        


       


        private void radioBtnTrain_CheckedChanged(object sender, EventArgs e)
        {
            panelCustomer.Visible = false;
            panelTrain.Visible = true;
        }

        private void radioBtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            panelCustomer.Visible = true;
            panelTrain.Visible = false;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginPanel().Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Do you confirm to reset all data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                TrainData.updateTrain();
                var q1 = "update Customer set bought_ticket = 0, cancel_ticket = 0";
                var q2 = "delete from Ticket";
                DataAccess.ExecuteUpdateQuery(q1);
                DataAccess.ExecuteUpdateQuery(q2);
                MessageBox.Show("All data have reseted.");
            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (businessClasstxt.Text == "" || cabinClasstxt.Text == "" || firstClasstxt.Text == "")
            {

                MessageBox.Show("There must be atleast '0' value in each type of seat to proceed.");

            }

            else {

                TrainData.UpdateTrainSchedule(trainIdBox.Text, boxDelay.Text);
                TrainData.IncreaseSeats(trainIdBox.Text, Convert.ToInt32(businessClasstxt.Text), Convert.ToInt32(cabinClasstxt.Text), Convert.ToInt32(firstClasstxt.Text));
                MessageBox.Show("Train Information Updated.");
            
            }
        }

        

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            customerNametxt.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            CancelTicketCheckBox.Enabled = false;
            CustomerUpdatebtn.Enabled = false;

            boxDelay.Enabled = false;
            businessClasstxt.Enabled = false;
            cabinClasstxt.Enabled = false;
            firstClasstxt.Enabled = false;
            btnUpdate.Enabled = false;

            
            var query = "select * from Customer";
            var dq = DataAccess.GetDataSet(query);
            

            for (int index = 0; index < dq.Tables[0].Rows.Count; index++)
            {

                comboBoxCustomerId.Items.Add("C-" + dq.Tables[0].Rows[index][0].ToString() + "");




            }

        }

        private void comboBoxCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sql = "select * from Customer where id = " + Convert.ToInt32(comboBoxCustomerId.Text.Substring(2)) + "";
            var query = "select * from Ticket where customer_id = " + Convert.ToInt32(comboBoxCustomerId.Text.Substring(2)) + "";
            customerNametxt.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            CancelTicketCheckBox.Enabled = true;
            CustomerUpdatebtn.Enabled = true;
            var dt = DataAccess.GetDataSet(sql);
            var dq = DataAccess.GetDataSet(query);

            if (dt.Tables[0].Rows[0][5].ToString() == "1")
            {

                customerNametxt.Text = dt.Tables[0].Rows[0][1].ToString();
                txtPhone.Text = dt.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = dt.Tables[0].Rows[0][3].ToString();

                TIDtxt.Text = dq.Tables[0].Rows[0][3].ToString();
                SeatTypetxt.Text = dq.Tables[0].Rows[0][5].ToString();
                SeatNotxt.Text = dq.Tables[0].Rows[0][9].ToString();


            }

            else {

                customerNametxt.Text = dt.Tables[0].Rows[0][1].ToString();
                txtPhone.Text = dt.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = dt.Tables[0].Rows[0][3].ToString();

                CancelTicketCheckBox.Enabled = false;
            
            }

            
        }

        private void boxShowTrainId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = "select * from Train where train_id = '" + boxShowTrainId.Text + "'";
            var dt = DataAccess.GetDataSet(query);

            txtTrainName.Text = dt.Tables[0].Rows[0][1].ToString();
            txtAvailableBusiness.Text = dt.Tables[0].Rows[0][2].ToString();
            txtAvailableCabin.Text = dt.Tables[0].Rows[0][3].ToString();
            txtAvailable1st.Text = dt.Tables[0].Rows[0][4].ToString();

            int total = Convert.ToInt32(txtAvailableBusiness.Text) + Convert.ToInt32(txtAvailableCabin.Text) + Convert.ToInt32(txtAvailable1st.Text);
            txtTotal.Text = total.ToString();
        }

        private void CustomerUpdatebtn_Click(object sender, EventArgs e)
        {
            var update = "update Customer set name = '" + customerNametxt.Text + "', email = '" + txtEmail.Text + "', phone_number= " + Convert.ToInt32(txtPhone.Text) + " where id = " + Convert.ToInt32(comboBoxCustomerId.Text.Substring(2)) + "";
            
            if (CancelTicketCheckBox.Checked == true) {
                var cancel = "update Customer set bought_ticket = 0, cancel_ticket = 0 where id = " + Convert.ToInt32(comboBoxCustomerId.Text.Substring(2)) + "";
                var delete = "delete Ticket where customer_id = " + Convert.ToInt32(comboBoxCustomerId.Text.Substring(2)) + "";

                var query = "select * from Ticket where customer_id = " + Convert.ToInt32(comboBoxCustomerId.Text.Substring(2)) + "";
                var dq = DataAccess.GetDataSet(query);
                int seatNumber = Convert.ToInt32(dq.Tables[0].Rows[0][9].ToString());
                string seatClass = dq.Tables[0].Rows[0][5].ToString();
                string tid = dq.Tables[0].Rows[0][3].ToString();

                if (seatClass == "Business Class")
                {

                    var updateTrain = "update Train set number_of_business_class_seats = number_of_business_class_seats+" + seatNumber + " where train_id = '" + tid + "'";
                    DataAccess.ExecuteUpdateQuery(updateTrain);
                }

                else if (seatClass == "Cabin Class")
                {

                    var updateTrain = "update Train set number_of_cabin_class_seats = number_of_cabin_class_seats+" + seatNumber + " where train_id = '" + tid + "'";
                    DataAccess.ExecuteUpdateQuery(updateTrain);
                }

                else if (seatClass == "1st Class")
                {

                    var updateTrain = "update Train set number_of_1st_class_seats = number_of_1st_class_seats+" + seatNumber + " where train_id = '" + tid + "'";
                    DataAccess.ExecuteUpdateQuery(updateTrain);
                }


                DataAccess.ExecuteUpdateQuery(delete);
                DataAccess.ExecuteUpdateQuery(cancel);
            
            
            }
            int row = DataAccess.ExecuteUpdateQuery(update);
            if (row == 1)
            {

                MessageBox.Show("Customer information updated");

            }

            else {

                MessageBox.Show("error");

            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void boxDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void businessClasstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cabinClasstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void firstClasstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void trainIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void boxShowTrainId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ViewReqbtn_Click(object sender, EventArgs e)
        {
            new CustomerRequest().Show();
        }

        private void ViewCustomerbtn_Click(object sender, EventArgs e)
        {
            new CustomerInformation().Show();
        }

        private void trainIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxDelay.Enabled = true;
            businessClasstxt.Enabled = true;
            cabinClasstxt.Enabled = true;
            firstClasstxt.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
