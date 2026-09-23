using System.Data;
using System.Data.SqlClient;

namespace DESKTOP_II__5CG9241T2M_
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
            
        }

        
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";


        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                textBox_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_textChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Create_Account fca = new Form_Create_Account();
            fca.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quiz_Code_Form fcf = new Quiz_Code_Form();
            fcf.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi","PERINGATAN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(textBox_Password.Text.Length < 4)
            {
                MessageBox.Show("Password minimal 4 karakter","PERINGATAN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
               
                conn.Open();
                string query = "SELECT * FROM [User] WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", textBox_Username.Text);
                cmd.Parameters.AddWithValue("Password", textBox_Password.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int userId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    int selectedId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    User_Main_Form UMF = new User_Main_Form(userId, selectedId);
                    UMF.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah","KONFIRMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox_Username.Clear();
                    textBox_Password.Clear();
                }

                
            }
        }
    }
}
