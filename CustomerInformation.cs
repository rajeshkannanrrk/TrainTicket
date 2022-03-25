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
    public partial class CustomerInformation : Form
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            var sql = "select * from Customer";
            gridviewCustomer.AutoGenerateColumns = false;
            gridviewCustomer.DataSource = DataAccess.GetDataTable(sql);
            
        }
    }
}
