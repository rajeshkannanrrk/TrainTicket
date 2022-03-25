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
    public partial class LoginPanel : Form
    {
        DataAccess db = new DataAccess();
        
        public LoginPanel()
        {
            InitializeComponent();
        }

        

        string a;
        string x;
        string y;

        private void btnLogin_Click(object sender, EventArgs e)
        {
             a = IDtxt.Text;
             x = a.Substring(0,1);
             y = a.Substring(2);

            if (x == "C")
            {
                int id = Convert.ToInt32(y);
                var sql = "select * from Customer where id = " + id + " and password = '" + Passwordtxt.Text + "'";

                var dt= DataAccess.GetDataSet(sql);



                if (dt.Tables[0].Rows.Count == 1)
                {

                    MessageBox.Show("Welcome," + dt.Tables[0].Rows[0][1].ToString() + "");
                    CustomerPanelHome obj = new CustomerPanelHome();
                    obj.Show();
                    obj.a = IDtxt.Text;
                    this.Close();

                }

                else {

                    MessageBox.Show("Invalid Credentials!");
                
                }

            }

            else if (x == "A")
            {
                var query = "select * from Admin where id = '" + IDtxt.Text + "' and password = '" + Passwordtxt.Text + "'";

                var dt = DataAccess.GetDataSet(query);

                

                if (dt.Tables[0].Rows.Count == 1)
                {

                    MessageBox.Show("Welcome," + dt.Tables[0].Rows[0][1].ToString() + "");
                    new AdminPanel().Show();
                    this.Close();

                }

                else
                {

                    MessageBox.Show("Invalid Credentials!");

                }

            }

            else { MessageBox.Show("Invalid Credentials!"); }


        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new SignUpPanel().Show();
            this.Close();


        }
    }
}
