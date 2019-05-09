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
    public partial class updateReservationForm2 : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";


        public updateReservationForm2()
        {
            connetionString = @"Data Source =.\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string query = "select * from FLIGHT WHERE [FLIGHT_NO] = @flight";
            SqlCommand cmd5 = new SqlCommand(query, con);
            cmd5.Parameters.AddWithValue("@flight", comboBox1.Text);
            SqlDataReader DataReader1 = cmd5.ExecuteReader();
            DataReader1.Read();
            string PID = DataReader1.GetString(2);
            DataReader1.Close();

            string query2 = "select [TICKET_NO] , [SEAT_NO] from TICKET WHERE [FLIGHT_NO] = @flight";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@flight", UpdateReservationForm.choosen);
            SqlDataReader DataReader2 = cmd2.ExecuteReader();
            DataReader2.Read();

            string ticket = DataReader2.GetString(0);
            string seat = DataReader2.GetString(1);
            DataReader2.Close();

            sql = "Update TICKET set [FLIGHT_NO] = @flight , [PILOT_ID] = @PID where [PASSENGER_ID] = @ID and [TICKET_NO] = @Ticket and [SEAT_NO] = @seat";
            SqlCommand cmd4 = new SqlCommand(sql, con);
            cmd4.Parameters.AddWithValue("@flight", comboBox1.Text);
            cmd4.Parameters.AddWithValue("@PID", PID);
            cmd4.Parameters.AddWithValue("@ID", LoginForm.ID);
            cmd4.Parameters.AddWithValue("@Ticket" , ticket);
            cmd4.Parameters.AddWithValue("@seat", seat);

            DataAdapter = new SqlDataAdapter();
            DataAdapter.InsertCommand = (cmd4);

            DataAdapter.InsertCommand.ExecuteNonQuery();

            cmd4.Dispose();
            DataAdapter.Dispose();

            MessageBox.Show("DONE!");

            user form = new user();
            this.Hide();
            form.Show();

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            UpdateReservationForm form = new UpdateReservationForm();
            this.Hide();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = TO.Text;
            string to = FROM.Text;


            sql = "select *  from FLIGHT where [DESTINATION_CITY] = @to and [DEPARTURE_CITY] = @from";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@from", from);
            cmd.ExecuteScalar();


            DataAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            DataAdapter.Fill(ds);

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ds.Tables[0];

            sql = "select FLIGHT_NO from FLIGHT where [DESTINATION_CITY] = @to and [DEPARTURE_CITY] = @from";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@to", to);
            cmd.Parameters.AddWithValue("@from", from);

            SqlDataReader DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                comboBox1.Items.Add(DataReader.GetString(0));
            }
            DataReader.Close();
        }

        private void updateReservationForm2_Load(object sender, EventArgs e)
        {
            

        }
    }
}
