using System.Data.SqlClient;
using System.Linq.Expressions;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            try
            {

                string connstring = "Data Source = DESKTOP-ASL4DQF\\SQLEXPRESS; Initial Catalog=e1; Integrated Security=true";
                connection = new SqlConnection(connstring);

                connection.Open();
                string query = "Select * from StudentTable";
                SqlCommand cmd = new SqlCommand(query, connection);

                //SqlCommand cmd;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader[0].ToString();
                    string studentName = reader[1].ToString();
                    string grad1 = reader[2].ToString();
                    string grad2 = reader[3].ToString();

                    richTextBox1.Text = richTextBox1.Text + id + " " + studentName + "   Grade1: " + grad1 + "     Grade2:" + grad2 + "\n";
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Sql Query Connection Failed !" + ex.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

