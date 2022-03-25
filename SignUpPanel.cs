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
    public partial class SignUpPanel : Form
    {
        DataAccess db = new DataAccess();

        private string userName;
        private string userEmail;
        private string userPassword;
        private UInt64 userPhoneNumber;

        public SignUpPanel()
        {
            InitializeComponent();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginPanel().Show();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if (Nametxt.Text.Equals("") || Emailtxt.Text.Equals("") || Passtxt.Text.Equals("") || PhoneNotxt.Text.Equals(""))
            {

                MessageBox.Show("Please fill up all the information.");

            }

            else {

                 userName = Nametxt.Text;
                 userEmail = Emailtxt.Text;
                 userPassword = Passtxt.Text;
                 userPhoneNumber = Convert.ToUInt64(PhoneNotxt.Text);

                 string query = "insert into Customer([name],[password],[email],[phone_number])values('" + userName + "','" + userPassword + "','" + userEmail + "'," + userPhoneNumber + ")";

                 DataAccess.GetDataSet(query);

                

               
                

                    MessageBox.Show("SignUp Comepleted!");
                    Nametxt.Text = "";
                    Passtxt.Text = "";
                    PhoneNotxt.Text = "";
                    Emailtxt.Text = "";
                    new CustomerInfo().Show();

                

                

                
            
            }

            
        }

        private void PhoneNotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
