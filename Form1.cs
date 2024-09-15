using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
namespace WinFormsApp1
{
    public partial class Students_Registration : Form
    {
        public Students_Registration()
        {
            InitializeComponent();
            MaximizeBox = false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if (

                //Ensures that the user doesn't enter data with missing values

                string.IsNullOrWhiteSpace(Firsttxt.Text) ||
                string.IsNullOrWhiteSpace(Lasttxt.Text) ||
                string.IsNullOrWhiteSpace(DOBTxt.Text) ||
                string.IsNullOrWhiteSpace(GenderTxt.Text) ||
                string.IsNullOrWhiteSpace(IDTxt.Text) ||
                string.IsNullOrWhiteSpace(ProgrammeTxt.Text))
            {

                string message = "Please enter all your details.";
                string title = "Invalid Entry";

                MessageBox.Show(message,title,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
                
            }

            else
            {

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=KARMA_INCARNATE;Initial Catalog=LIMITED;Integrated Security=True");

                    SqlCommand cmd;

                    con.Open();

                    string s = "Insert into Students_Reg VALUES(@First_Name," +
                        "@Last_Name,@DOB,@Gender,@Id_Number,@Programme)";

                    cmd = new SqlCommand(s, con);

                    cmd.Parameters.AddWithValue("@First_Name", Firsttxt.Text);
                    cmd.Parameters.AddWithValue("@Last_Name", Lasttxt.Text);
                    cmd.Parameters.AddWithValue("@DOB", DOBTxt.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderTxt.Text);
                    cmd.Parameters.AddWithValue("@Id_Number", IDTxt.Text);
                    cmd.Parameters.AddWithValue("@Programme", ProgrammeTxt.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    string message = "One Row Inserted!";
                    string title = "Successful Addition";

                    MessageBox.Show(message,title,MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    Firsttxt.Clear();
                    Lasttxt.Clear();
                    DOBTxt.Clear();
                    GenderTxt.Clear();
                    IDTxt.Clear();
                    ProgrammeTxt.Clear();

                }

                catch (Exception i)
                {
                    string message = "Its not you, its us. Restart the application";
                    string title = "Something Wrong";

                   DialogResult diag = MessageBox.Show(message,title,MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    if (diag == DialogResult.OK) 
                    {
                        Application.Exit();
                    }
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirms that the user wants to close the application

            string message = "Are you sure you want to close?!";
            string title = "Confirm";

           DialogResult diag= MessageBox.Show(message, title, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (diag == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Used by admins to view data in the form in a more optimal form
            //Here column names are changed to allow for better readability

            var Admin_Form = new Admin_Datagrid_View();
            Admin_Form.Show();
            this.Hide();

        }

        private void Students_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Used by admins to view data on the table exactly as it is.
            //Here column names are maintained

            var Admin_Form = new Admin_Datagrid();
            Admin_Form.Show();
            this.Hide();
        }
    }
}
