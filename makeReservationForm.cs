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
    public partial class makeReservationForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public makeReservationForm()
        {
            connetionString = @"Data Source =.\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();
            InitializeComponent();
        }

        private void makeReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flight_ReservationDataSet1.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flight_ReservationDataSet1.FLIGHT);

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            user form = new user();
            this.Hide();
            form.Show();

        }

        private void reserveBTN_Click(object sender, EventArgs e)
        {
            DataAdapter.Dispose();
            string query = "select [EMAIL] from PASSENGER WHERE [PASSENGER_ID] = @id";
            SqlCommand cmd5 = new SqlCommand(query, con);
            cmd5.Parameters.AddWithValue("@id", LoginForm.ID);
            SqlDataReader DataReader1 = cmd5.ExecuteReader();
            DataReader1.Read();
            string email = DataReader1.GetString(0);
            DataReader1.Close();

            string query1 = "select * from FLIGHT WHERE [FLIGHT_NO] = @flight";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@flight", comboBox1.Text);
            SqlDataReader DataReader2 = cmd1.ExecuteReader();
            DataReader2.Read();
            string PID = DataReader2.GetString(2);
            DataReader2.Close();

            sql = "INSERT into TICKET Values (@id , @email, @seat , @ticket , 'ecomomy' , @flight ,@pilot)";
            SqlCommand cmd4 = new SqlCommand(sql, con);
            cmd4.Parameters.AddWithValue("@id", LoginForm.ID);
            cmd4.Parameters.AddWithValue("@email", email);
            cmd4.Parameters.AddWithValue("@seat", "S21133315");
            cmd4.Parameters.AddWithValue("@ticket", "T4511224");
            cmd4.Parameters.AddWithValue("@flight", comboBox1.Text);
            cmd4.Parameters.AddWithValue("@pilot", PID);

            cmd4.ExecuteNonQuery();

            MessageBox.Show("DONE!");

            user form = new user();
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
    }
}
