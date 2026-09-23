using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class User_Main_Form : Form
    {
        private int UserID;
        private int SelectedId;

        public User_Main_Form(int userID, int selectedId)
        {
            InitializeComponent();
            UserID = userID;
            SelectedId = selectedId;
            
           


            loadData();


        }

        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";




        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT Name,Code,Description FROM Quiz WHERE UserID=@UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                Dgv_Quizz.DataSource = dt;
                Dgv_Quizz.Columns["ColDelete"].DisplayIndex = Dgv_Quizz.Columns.Count - 1;

                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "ColDelete";
                btnDelete.HeaderText = "";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;

                Dgv_Quizz.Columns.Add(btnDelete);

                if (dt.Rows.Count > 0)
                {
                    Dgv_Quizz.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");

                }

                string nama = "SELECT FullName FROM [User] WHERE ID=@ID";
                SqlCommand cmdnama = new SqlCommand(nama, conn);

                cmdnama.Parameters.AddWithValue("@ID", UserID);

                string FullName = cmdnama.ExecuteScalar()?.ToString();

                label_nama.Text = FullName;

                object result = cmdnama.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Data user tidak ditemukan");
                }
                else
                {
                    label_nama.Text = result.ToString();
                }

            }
        }
        private void User_Main_Form_Load(object sender, EventArgs e)
        {
            loadData();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin loguot?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (result == DialogResult.Yes)
            {
                FormLogin fl = new FormLogin();
                fl.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Quiz ANQ = new Add_New_Quiz(UserID);
            ANQ.Owner = this;

            this.Hide();
            ANQ.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Quiz_Report_Form VQRF = new View_Quiz_Report_Form(UserID);
            VQRF.Owner = this;
            this.Hide();

            VQRF.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
