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
    public partial class signUpForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";


        public signUpForm()
        {
            connetionString = @"Data Source = .\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

            con = new SqlConnection(connetionString);

            con.Open();

            InitializeComponent();
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {

        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {

            string Name = NameTxtBox.Text;
            string ID = IDTxtBox.Text;
            string Email = EmailTxtBox.Text;
            string Type = "User";

            //INSERT into PASSENGERS (PASSENGERS_ID  ,EMAIL , NAME , TYPE) Values ('ID' , 'Email' , 'Name' , 'type'); 

            DataAdapter = new SqlDataAdapter();
            sql = "";
            sql = "INSERT into PASSENGER Values ('" + ID + "' , '" + Email + "' , '" + Name + "' , '" + Type + "');";

            cmd = new SqlCommand(sql, con);

            DataAdapter.InsertCommand = new SqlCommand(sql, con);

            DataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("You can back and sign in now..");

            DataReader.Close();
            cmd.Dispose();
            con.Close();
        }
    }
}
