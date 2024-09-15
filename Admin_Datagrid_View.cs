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

namespace WinFormsApp1
{
    public partial class Admin_Datagrid_View : Form
    {
        public Admin_Datagrid_View()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this ensures that only administrators can view the data from the database

            SqlDataReader reader;
            SqlCommand cmd;
            SqlConnection connect = new SqlConnection(@"Data Source=KARMA_INCARNATE;
            Initial Catalog=LIMITED;Integrated Security=True");

            connect.Open();

            string s = "SELECT * FROM Admins WHERE Admin_Id = @q1 AND Password= @q2;";

            cmd = new SqlCommand(s, connect);

            cmd.Parameters.AddWithValue("@q1", AdmTxt.Text);
            cmd.Parameters.AddWithValue("@q2", PassTxt.Text);

            reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Close();
                    connect.Close();
                    string con = @"Data Source=KARMA_INCARNATE;Initial Catalog=
                LIMITED;Integrated Security=True";

                    using (SqlConnection conn = new SqlConnection(con))
                    {

                        string query = "Select Reg_Number as 'Registration Number', First_Name as 'First Name'," +
                                       "Last_Name as 'Last Name',DOB as 'Date of Birth'," +
                                       "Gender,Id_Number as 'ID Number', Programme " +
                                       " From Students_Reg";

                        SqlCommand method = new SqlCommand(query, conn);
                        conn.Open();

                        SqlDataReader final = method.ExecuteReader();
                        DataTable dataTable1 = new DataTable();
                        dataTable1.Load(final);
                        dataGridView1.DataSource = dataTable1;



                        conn.Close();

                    }


                }
                else
                {
                   
                    string message = "This feature is reserved for admins only." +
                        "If you've forgotten your ID, please refer to the office.";
                    string title = "Unauthorised Entry";

                    MessageBox.Show(message,title,MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                }

            }

            catch (Exception i)
            {
                string message = "Oops something went wrong with the connection, restart the application" +
                    "and try again";
                string title = "Something Wrong";

                DialogResult diag = MessageBox.Show(message, title, MessageBoxButtons.OK,
                     MessageBoxIcon.Error);

                if (diag == DialogResult.OK)
                {
                    Application.Exit();
                }
              
            }

            finally
            {
                AdmTxt.Clear();
                PassTxt.Clear();
            }


        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            //confirms that the user wants to close the application

            string message = "Are you sure you want to close?!";
            string title = "Confirm";

            DialogResult diag = MessageBox.Show(message, title, MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (diag == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //takes the user back to the main form

            string message = "Are you sure you want to go back?";
            string title = "Confirm";

            DialogResult diag = MessageBox.Show(message, title, MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (diag == DialogResult.Yes)
            {
                this.Close();
                var mainForm = new Students_Registration();
                mainForm.Show();
            }
        }
    }
}
