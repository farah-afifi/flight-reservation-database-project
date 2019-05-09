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
    public partial class LoginForm : Form
    {
        string connetionString = null;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader DataReader;
        SqlDataAdapter DataAdapter;
        string sql, output = "";
        public static string ID = "";

        public LoginForm()
        {
            try
            {
                connetionString = @"Data Source =.\SQLEXPRESS;
                                  Initial Catalog = Flight_Reservation;
                                  Integrated Security=True";

                con = new SqlConnection(connetionString);

                con.Open();

                InitializeComponent();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = NameTxtBox.Text;
                string ID1 = IDTxtBox.Text;
                ID = ID1;

                //SELECT [TYPE] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] = 'AA110' AND [NAME] like 'Aymen'


                sql = "SELECT [TYPE] FROM [dbo].[PASSENGER] WHERE [PASSENGER_ID] = '" + ID1 + "' AND [NAME] like '" + Name + "'";

                cmd = new SqlCommand(sql, con);
                DataReader = cmd.ExecuteReader();

                output = "";
                while (DataReader.Read())
                {
                    output += DataReader.GetValue(0);
                    if (output == "Admen")
                    {
                        // Here i should open a form that contain the operation that admin can perform.
                        /*
                         * AdmenForm form = new AdmenForm();
                         * this.Hide();
                         * form.Show();
                         */
                        MessageBox.Show("Admin Form :D");
                        DataReader.Close();
                        cmd.Dispose();

                        return;
                    }

                   
                }
               // Console.WriteLine()
                if (output == "User")
                {

                    // Here i should open a form that contain the operation that USER can perform.
                     user form = new user();
                     this.Hide();
                     form.Show();
                    
                }
                else
                {
                    MessageBox.Show("inValid user name and password" , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                    NameTxtBox.Focus();
                    
                }
                
                DataReader.Close();
                cmd.Dispose();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Open the sign up form to take new user data 
            
             signUpForm form = new signUpForm();
             this.Hide();
             form.Show();
            
        }
    }
}
