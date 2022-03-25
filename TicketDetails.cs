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
    public partial class TicketDetails : Form
    {
        public TicketDetails()
        {
            InitializeComponent();
        }
        public string cid;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            var query = "select * from Ticket where customer_id = '"+cid+"'";
            var dt = DataAccess.GetDataSet(query);
            lblTicketID.Text = dt.Tables[0].Rows[0][0].ToString();
            lblCustomerID.Text = dt.Tables[0].Rows[0][1].ToString();
            lblCustomerName.Text = dt.Tables[0].Rows[0][2].ToString();
            lblTrainID.Text = dt.Tables[0].Rows[0][3].ToString();
            lblTrainName.Text = dt.Tables[0].Rows[0][4].ToString();
            lblSeatType.Text = dt.Tables[0].Rows[0][5].ToString();
            lblSeatAmount.Text = dt.Tables[0].Rows[0][9].ToString();
            lblDepartTime.Text = dt.Tables[0].Rows[0][6].ToString();
            lblDepartFrom.Text = dt.Tables[0].Rows[0][7].ToString();
            lblDestination.Text = dt.Tables[0].Rows[0][8].ToString();
        }
    }
}
