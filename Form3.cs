using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Admin_Datagrid : Form
    {
        public Admin_Datagrid()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

            cmd.Parameters.AddWithValue("@q1", ADMIN_IDTXT.Text);
            cmd.Parameters.AddWithValue("@q2", PasswordTxt.Text);

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
                        conn.Open();

                        SqlDataAdapter sqDa = new SqlDataAdapter("Select * From Students_Reg", conn);
                        DataTable dt = new DataTable();

                        sqDa.Fill(dt);
                        dataGridView1.DataSource = dt;

                        conn.Close();
                    }
                }
                else
                {
                    string message = "This feature is reserved for admins only." +
                        "If you've forgotten your ID, please refer to the office.";

                    string title = "Unauthorised Entry";

                    MessageBox.Show(message, title, MessageBoxButtons.OK,
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

                ADMIN_IDTXT.Clear();
                PasswordTxt.Clear();

            }
        }

        private void button3_Click(object sender, EventArgs e)
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
