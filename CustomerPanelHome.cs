using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTicketManagementSystemProject
{
    public partial class CustomerPanelHome : Form
    {
        public string a;

        public CustomerPanelHome()
        {
            InitializeComponent();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginPanel().Show();
        }

        private void Buybtn_Click(object sender, EventArgs e)
        {
            var valid = "select * from Customer where id = " + Convert.ToInt32(a.Substring(2)) + "";
            var dt = DataAccess.GetDataSet(valid);
            if (Convert.ToInt32(dt.Tables[0].Rows[0][5]) == 0)
            {

                this.Close();
                CustomerPanelTransaction obj = new CustomerPanelTransaction();
                obj.customerId = a;
                obj.Show();


            }

            else {

                MessageBox.Show("You have already bought a ticket");
            
            }
            
        }

        private void ShowTicketbtn_Click(object sender, EventArgs e)
        {
            var valid = "select * from Customer where id = " + Convert.ToInt32(a.Substring(2)) + "";
            var dt = DataAccess.GetDataSet(valid);
            if (Convert.ToInt32(dt.Tables[0].Rows[0][5]) == 1)
            {

                TicketDetails t = new TicketDetails();
                t.cid = a.Substring(2);
                t.Show();
                
            }

            else {

                MessageBox.Show("You have not bought any ticket for it to be shown");
            
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var valid = "select * from Customer where id = " + Convert.ToInt32(a.Substring(2)) + "";
            var dt = DataAccess.GetDataSet(valid);
            if (Convert.ToInt32(dt.Tables[0].Rows[0][5]) == 1)
            {

                DialogResult dr = MessageBox.Show("Do you want to cancel your ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var confirmCancel = "update Customer set cancel_ticket = 1 where id = " + Convert.ToInt32(a.Substring(2)) + "";
                    DataAccess.ExecuteUpdateQuery(confirmCancel);
                    MessageBox.Show("Your cancel request has been sent to admin");

                }


            }

            else {

                MessageBox.Show("You have no ticket to cancel");
            
            }
        }

        private void CustomerPanelHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
