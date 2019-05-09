using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class user : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public user()
        {
            connetionString = @"Data Source =.\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Click(object sender, EventArgs e)
        {
            makeReservationForm form1 = new makeReservationForm();
            this.Hide();
            form1.Show();
        }

        private void UpdateTicket_Click(object sender, EventArgs e)
        {
            
            UpdateReservationForm form = new UpdateReservationForm();
            this.Hide();
            form.Show();
            

        }

        private void ShowTicket_Click(object sender, EventArgs e)
        {
            ShowTicketsForm form = new ShowTicketsForm();
            this.Hide();
            form.Show();
        }
    }
}
