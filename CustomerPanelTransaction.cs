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
    public partial class CustomerPanelTransaction : Form
    {
        DataAccess db = new DataAccess();
        public CustomerPanelTransaction()
        {
            InitializeComponent();

        }


        string trainId;
        public string customerId; 

        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void Traintxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomerPanelTransaction_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxLocation.Text == comboBoxDestination.Text)
            {

                MessageBox.Show("Location and Destination can't be same.");

            }

            else
            {
                var sql = "select * from Train_Schedule where departing_location = '" + comboBoxLocation.Text + "' and destination = '" + comboBoxDestination.Text + "'";
                var dt = DataAccess.GetDataSet(sql);

                trainId = dt.Tables[0].Rows[0][0].ToString();

                var query = "select * from Train where train_id = '"+trainId+"'";
                var dq = DataAccess.GetDataSet(query);

                Traintxt.Text = dq.Tables[0].Rows[0][1].ToString();

                txtbusiness.Text = dq.Tables[0].Rows[0][2].ToString();
                txtcabin.Text = dq.Tables[0].Rows[0][3].ToString();
                txt1st.Text = dq.Tables[0].Rows[0][4].ToString();

                int a = Convert.ToInt32(txtbusiness.Text) + Convert.ToInt32(txtcabin.Text) + Convert.ToInt32(txt1st.Text);
                txttotal.Text = Convert.ToString(a);
            }
        }




        public void SeatCalculation(int selectedSeat)
        {

            int[] limit = new int[3] { 3, 2, 6 };
            int available;

            if (radioBtnBusiness.Checked == true)
            {

                available = Convert.ToInt32(txtbusiness.Text);

                if (selectedSeat <= available)
                {

                    if (selectedSeat <= limit[0])
                    {

                        DialogResult dr = MessageBox.Show("Do you want to buy this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {

                            var query = "update Train set number_of_business_class_seats = number_of_business_class_seats-" + selectedSeat + " where train_id = '" + trainId + "'";
                            int row=DataAccess.ExecuteUpdateQuery(query);

                            var q1 = "update Customer set bought_ticket = 1 where id = " + Convert.ToInt32(customerId.Substring(2)) + "";
                            DataAccess.ExecuteUpdateQuery(q1);
                            var q2 = "select * from Customer where id = " + Convert.ToInt32(customerId.Substring(2)) + "";
                            var dt = DataAccess.GetDataSet(q2);
                            var q3 = "select * from Train_Schedule where train_id = '"+trainId+"'";
                            var dq = DataAccess.GetDataSet(q3);
                            var insert = "insert into Ticket([customer_id],[customer_name],[train_id],[train_name],[seat_type],[depart_time],[depart_from],[destination],[seat_amount])values(" + Convert.ToInt32(customerId.Substring(2)) + ",'" + dt.Tables[0].Rows[0][1] + "','" + dq.Tables[0].Rows[0][0] + "','" + Traintxt.Text + "','Business Class','" + dq.Tables[0].Rows[0][3] + "','" + dq.Tables[0].Rows[0][1] + "','" + dq.Tables[0].Rows[0][2] + "'," + Convert.ToInt32(txtSelectedSeats.Text) + ")";
                            DataAccess.ExecuteUpdateQuery(insert);

                            if (row == 1)
                            {

                                MessageBox.Show("Ticket Bought Successfully!");
                                this.Close();
                                new LoginPanel().Show();

                            }

                            else {

                                MessageBox.Show("Error!");
                            
                            }

                            

                        }



                    }

                    else
                    {

                        MessageBox.Show("You can not buy more than " + limit[0] + " seats. \n Please read the instructions.");

                    }

                }

                else
                {

                    MessageBox.Show("Sorry, not enough seats available.");

                }

            }


            else if (radiobtnCabin.Checked == true)
            {

                available = Convert.ToInt32(txtcabin.Text);

                if (selectedSeat <= available)
                {

                    if (selectedSeat <= limit[1])
                    {

                        DialogResult dr = MessageBox.Show("Do you want to buy this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {

                            var query = "update Train set number_of_cabin_class_seats = number_of_cabin_class_seats-" + selectedSeat + " where train_id = '" + trainId + "'";
                            int row = DataAccess.ExecuteUpdateQuery(query);

                            var q1 = "update Customer set bought_ticket = 1 where id = " + Convert.ToInt32(customerId.Substring(2)) + "";
                            DataAccess.ExecuteUpdateQuery(q1);
                            var q2 = "select * from Customer where id = " + Convert.ToInt32(customerId.Substring(2)) + "";
                            var dt = DataAccess.GetDataSet(q2);
                            var q3 = "select * from Train_Schedule where train_id = '" + trainId + "'";
                            var dq = DataAccess.GetDataSet(q3);
                            var insert = "insert into Ticket([customer_id],[customer_name],[train_id],[train_name],[seat_type],[depart_time],[depart_from],[destination],[seat_amount])values(" + Convert.ToInt32(customerId.Substring(2)) + ",'" + dt.Tables[0].Rows[0][1] + "','" + dq.Tables[0].Rows[0][0] + "','" + Traintxt.Text + "','Cabin Class','" + dq.Tables[0].Rows[0][3] + "','" + dq.Tables[0].Rows[0][1] + "','" + dq.Tables[0].Rows[0][2] + "'," + Convert.ToInt32(txtSelectedSeats.Text) + ")";
                            DataAccess.ExecuteUpdateQuery(insert);

                            if (row == 1)
                            {

                                MessageBox.Show("Ticket Bought Successfully!");
                                this.Close();
                                new LoginPanel().Show();

                            }

                            else
                            {

                                MessageBox.Show("Error!");

                            }



                        }



                    }

                    else
                    {

                        MessageBox.Show("You can not buy more than " + limit[1] + " seats. \n Please read the instructions.");

                    }

                }

                else
                {

                    MessageBox.Show("Sorry, not enough seats available.");

                }

            }

            else if (radiobtn1stClass.Checked == true)
            {

                available = Convert.ToInt32(txt1st.Text);

                if (selectedSeat <= available)
                {

                    if (selectedSeat <= limit[2])
                    {

                        DialogResult dr = MessageBox.Show("Do you want to buy this ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {

                            var query = "update Train set number_of_1st_class_seats = number_of_1st_class_seats-" + selectedSeat + " where train_id = '" + trainId + "'";
                            int row = DataAccess.ExecuteUpdateQuery(query);

                            var q1 = "update Customer set bought_ticket = 1 where id = " + Convert.ToInt32(customerId.Substring(2)) + "";
                            DataAccess.ExecuteUpdateQuery(q1);
                            var q2 = "select * from Customer where id = " + Convert.ToInt32(customerId.Substring(2)) + "";
                            var dt = DataAccess.GetDataSet(q2);
                            var q3 = "select * from Train_Schedule where train_id = '" + trainId + "'";
                            var dq = DataAccess.GetDataSet(q3);
                            var insert = "insert into Ticket([customer_id],[customer_name],[train_id],[train_name],[seat_type],[depart_time],[depart_from],[destination],[seat_amount])values(" + Convert.ToInt32(customerId.Substring(2)) + ",'" + dt.Tables[0].Rows[0][1] + "','" + dq.Tables[0].Rows[0][0] + "','" + Traintxt.Text + "','1st Class','" + dq.Tables[0].Rows[0][3] + "','" + dq.Tables[0].Rows[0][1] + "','" + dq.Tables[0].Rows[0][2] + "'," + Convert.ToInt32(txtSelectedSeats.Text) + ")";
                            DataAccess.ExecuteUpdateQuery(insert);

                            if (row == 1)
                            {

                                MessageBox.Show("Ticket Bought Successfully!");
                                this.Close();
                                new LoginPanel().Show();

                            }

                            else
                            {

                                MessageBox.Show("Error!");

                            }



                        }



                    }

                    else
                    {

                        MessageBox.Show("You can not buy more than " + limit[2] + " seats. \n Please read the instructions.");

                    }

                }

                else
                {

                    MessageBox.Show("Sorry, not enough seats available.");

                }

            }


        }

        private void Buybtn_Click(object sender, EventArgs e)
        {
            SeatCalculation(Convert.ToInt32(txtSelectedSeats.Text));



        }

        private void txtSelectedSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = true;
        }

        private void comboBoxLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxDestination_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



    }
}
