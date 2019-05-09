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
    public partial class UpdateReservationForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";

        public static string choosen;

        public UpdateReservationForm()
        {
            connetionString = @"Data Source =.\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choosen = comboBox1.Text;

            updateReservationForm2 form = new updateReservationForm2();
            this.Hide();
            form.Show();

            DataReader.Close();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user form = new user();
            this.Hide();
            form.Show();

            DataReader.Close();
            cmd.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sql = "select *  from TICKET where PASSENGER_ID = @id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", LoginForm.ID);

            DataAdapter = new SqlDataAdapter(cmd);


            DataSet ds = new DataSet();

            DataAdapter.Fill(ds);

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ds.Tables[0];

            sql = "select FLIGHT_NO from TICKET where PASSENGER_ID = @id ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", LoginForm.ID);

            DataReader = cmd.ExecuteReader();

            while (DataReader.Read())
            {
                comboBox1.Items.Add(DataReader.GetString(0));
            }

            con.Close();

        }
    }
}
