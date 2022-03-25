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
    public partial class CustomerInfo : Form
    {
        DataAccess db = new DataAccess();
        

        public CustomerInfo()
        {
            InitializeComponent();
            var query = "select top 1 * from Customer order by id desc";
            var dt= DataAccess.GetDataTable(query);
            

            lblYourId.Text = "C-" + dt.Rows[0][0].ToString() +"";
            lblYourPass.Text = dt.Rows[0]["password"].ToString();

            
            
            
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
