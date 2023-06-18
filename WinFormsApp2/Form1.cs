using System.Text;

using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QRC7DE0\\SQLEXPRESS;Initial Catalog=form1;Integrated Security=True");
            con.Open();
           
            SqlCommand cmd = new SqlCommand("insert into insert_data(name,email,contact) values ('" + txtname.Text + "', '" + txtemail.Text + "','" + txtcontact.Text + "')", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("saved ");

            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
            






            string name = txtname.Text;
            string email = txtemail.Text;
            string contact = txtcontact.Text;
            string all_data = "Name:  " + name + ", Email:" + email + " ,Contact: " + contact;
           // MessageBox.Show(all_data);

            String file = @"C:\Users\Lenovo\Desktop\WorkFolder ASP.net\Day 1\Output.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { };
            output.AppendLine(string.Join(separator, headings));
            String[] newLine = { all_data };
            output.AppendLine(string.Join(separator, newLine));
            output.ToString();
            try
            {
                File.AppendAllText(file, output.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data could not be written to the CSV file.");
                return;
            }

           




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}