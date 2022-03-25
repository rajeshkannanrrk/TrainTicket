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
    public partial class CustomerRequest : Form
    {
        DataAccess db = new DataAccess();
        int ids;

        public CustomerRequest()
        {
            InitializeComponent();
        }

        

        private void CustomerRequest_Load(object sender, EventArgs e)
        {
            var sql = "select * from Customer where cancel_ticket = 1";


            gridviewCustomer.AutoGenerateColumns = false;
            gridviewCustomer.DataSource = DataAccess.GetDataTable(sql);
            


        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {

            
            var update = "update Customer set bought_ticket = 0, cancel_ticket = 0 where id = " + ids + "";
            DataAccess.ExecuteUpdateQuery(update);
            
            

                var delete = "delete Ticket where customer_id = " + ids + "";

                var query = "select * from Ticket where customer_id = " + ids + "";
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



            

            var sql2 = "select * from Customer where cancel_ticket = 1";
            gridviewCustomer.DataSource = DataAccess.GetDataTable(sql2);

        }

        private void CancelAllbtn_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Are you sure you want to cancel all the tickets?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (dr == DialogResult.Yes) {

               var sql = "select * from Customer where cancel_ticket = 1";
               var dt = DataAccess.GetDataSet(sql);
               
               var update = "update Customer set bought_ticket = 0, cancel_ticket = 0 where cancel_ticket = 1";
               DataAccess.ExecuteUpdateQuery(update);
               for (int index = 0; index < dt.Tables[0].Rows.Count; index++)
               {

                   var delete = "delete Ticket where customer_id = " + dt.Tables[0].Rows[index][0] + "";
                   var query = "select * from Ticket where customer_id = " + dt.Tables[0].Rows[index][0] + "";
                   var dq = DataAccess.GetDataSet(query);
                   int seatNumber = Convert.ToInt32(dq.Tables[0].Rows[0][9].ToString());
                   string seatClass = dq.Tables[0].Rows[0][5].ToString();
                   string tid = dq.Tables[0].Rows[0][3].ToString();

                   if (seatClass == "Business Class") {

                       var updateTrain = "update Train set number_of_business_class_seats = number_of_business_class_seats+" + seatNumber + " where train_id = '"+tid+"'";
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



               }

               var sql2 = "select * from Customer where cancel_ticket = 1";
               gridviewCustomer.DataSource = DataAccess.GetDataTable(sql2);
           

           
           }



        }

        private void gridviewCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             ids = Convert.ToInt32(gridviewCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
