using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DESKTOP_II__5CG9241T2M_
{
    public partial class Form_Create_Account : Form
    {
        
        public Form_Create_Account()
        {
            InitializeComponent();
            
        }

        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "" || textBox_FullName.Text == "" || textBox_Password.Text == "" || textBox_RetypePassword.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi");
                return;
            }

            if(textBox_Password.Text.Length < 4)
            {
                MessageBox.Show("Password minimal 4 karakter");
                return;
            }
            
            if(textBox_Password.Text != textBox_RetypePassword.Text)
            {
                MessageBox.Show("password yang di isi harus sama");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string cek = "SELECT COUNT (*) FROM [User] WHERE Username=@Username";
                SqlCommand cmdcheck = new SqlCommand(cek, conn);
                
                cmdcheck.Parameters.AddWithValue("Username", txtBox_Username.Text);

                int jumlah = Convert.ToInt32(cmdcheck.ExecuteScalar());

                if(jumlah > 0)
                {
                    MessageBox.Show("Username Sudah Ada");
                    return;
                }

                string insert = "INSERT INTO [User] (Username,FullName,Password,DateOfBirth) VALUES (@Username,@FullName,@Password,@DateOfBirth)";
                SqlCommand cmdinsert = new SqlCommand(insert, conn);

                cmdinsert.Parameters.AddWithValue("Username", txtBox_Username.Text);
                cmdinsert.Parameters.AddWithValue("FullName", textBox_FullName.Text); 
                cmdinsert.Parameters.AddWithValue("Password",textBox_Password.Text);
                cmdinsert.Parameters.AddWithValue("DateOfBirth", DTP_DateOfBirh.Value.Date);

                cmdinsert.ExecuteNonQuery();

                
                MessageBox.Show("Akun Berhasil Dibuat");


            }

       
        }
    }
}
