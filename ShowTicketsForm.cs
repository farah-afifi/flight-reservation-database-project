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

    public partial class ShowTicketsForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public ShowTicketsForm()
        {
            connetionString = @"Data Source =.\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();
            InitializeComponent();
        }

        private void ShowTicketsForm_Load(object sender, EventArgs e)
        {

            sql = "SELECT PASSENGER_ID, EMAIL, SEAT_NO, TICKET_NO, CLASS, T.FLIGHT_NO , [DESTINATION_CITY] ,[DEPARTURE_CITY] FROM dbo.TICKET T, FLIGHT F where T.FLIGHT_NO = F.FLIGHT_NO and PASSENGER_ID = @id";
            cmd = new SqlCommand(sql ,con);
            cmd.Parameters.AddWithValue("@id", LoginForm.ID);

            DataAdapter = new SqlDataAdapter(cmd);


            DataSet ds = new DataSet();

            DataAdapter.Fill(ds);

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ds.Tables[0];

            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            user form = new user();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
