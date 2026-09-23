using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DESKTOP_II__5CG9241T2M_
{
    public partial class Quiz_Code_Form : Form
    {
        public Quiz_Code_Form()
        {
            InitializeComponent();
        }
        
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_QuizCode.Text == "" || textBox_nickname.Text == "")
            {
                MessageBox.Show("Pastikan Code dan Nickname Terisi","PERINGATAN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [Quiz] WHERE Code=@Code";
                SqlCommand cmd = new SqlCommand(query, conn);

                
                cmd.Parameters.AddWithValue("Code", textBox_QuizCode.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count >0)
                {
                   
                    int quizID = Convert.ToInt32(dt.Rows[0]["ID"]);
                    
                    MessageBox.Show("Selamat Code Anda Benar","Konfirmasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Quizz_Form Qf = new Quizz_Form(textBox_nickname.Text,quizID);
                    Qf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan","INFORMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox_nickname.Clear();
                    textBox_QuizCode.Clear();
                }
            }
                
        }
    }
}
