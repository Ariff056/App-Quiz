using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DESKTOP_II__5CG9241T2M_
{
    public partial class Add_New_Quiz : Form
    {
        private int UserID;
        private int nomor = 1;
        public Add_New_Quiz(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Dgv_QuestionData.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus pertanyaan ini?", "konfirmai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    return;
                if(result == DialogResult.Yes)
                {
                    Dgv_QuestionData.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0;i < Dgv_QuestionData.Rows.Count; i++)
                    {
                        if (!Dgv_QuestionData.Rows[i].IsNewRow)
                        {
                            Dgv_QuestionData.Rows[i].Cells["No"].Value = i + 1;
                        }
                    }
                }
            }

            nomor = 1;
            foreach(DataGridViewRow row in Dgv_QuestionData.Rows)
            {
                if(!row.IsNewRow)
                {
                    row.Cells["No"].Value = nomor++;
                }
                
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_quizname.Text == "" || textBox_QuizCode.Text == "" || RTB_QuizDescription.Text == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi","PERINGATAN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textBox_QuizCode.Text, @"^(?=.*[A-Z])(?=.*\d)[A-Z0-9]+$"))
            {
                MessageBox.Show("Code harus berupa kombinasi Huruf Besar Dan Angka Saja","PERINGATAN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox_QuizCode.Focus();
                return;
            }

            if(Dgv_QuestionData.Rows.Count <= 1)
            {
                MessageBox.Show("Tambahkan Minimal Satu Pertanyaan","KONFIRMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string cmdcheck = "SELECT COUNT (*) FROM [Quiz] WHERE Code = @Code";
                SqlCommand cmdcheckCode = new SqlCommand(cmdcheck, conn);

                cmdcheckCode.Parameters.AddWithValue(@"Code", textBox_QuizCode.Text);

                int jumlah = Convert.ToInt32(cmdcheckCode.ExecuteScalar());
                if (jumlah > 0)
                {
                    MessageBox.Show("Code Sudah Digunakan","PERINGATAN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                
                string insert = "INSERT INTO Quiz (UserID,Name,Code,Description,CreatedAt) OUTPUT INSERTED.ID VALUES (@UserID,@Name,@Code,@Description,@CreatedAt)";
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue(@"UserID", UserID);
                cmd.Parameters.AddWithValue(@"Name", textBox_quizname.Text);
                cmd.Parameters.AddWithValue(@"Code", textBox_QuizCode.Text);
                cmd.Parameters.AddWithValue(@"Description", RTB_QuizDescription.Text);
                cmd.Parameters.AddWithValue(@"CreatedAt", DateTime.Now);

                int quizID = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (DataGridViewRow row in Dgv_QuestionData.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string insertQuestions = @"INSERT INTO Question (QuizID,Question,OptionA,OptionB,OptionC,OptionD,CorrectAnswer) VALUES (@QuizID,@Question,@A,@B,@C,@D,@Correct)";
                    SqlCommand cmdQuestion = new SqlCommand(insertQuestions, conn);

                    cmdQuestion.Parameters.AddWithValue(@"QuizID", quizID);
                    cmdQuestion.Parameters.AddWithValue(@"Question", row.Cells["Question"].Value?.ToString());
                    cmdQuestion.Parameters.AddWithValue(@"A", row.Cells["OptionA"].Value?.ToString());
                    cmdQuestion.Parameters.AddWithValue(@"B", row.Cells["OptionB"].Value?.ToString());
                    cmdQuestion.Parameters.AddWithValue(@"C", row.Cells["OptionC"].Value?.ToString());
                    cmdQuestion.Parameters.AddWithValue(@"D", row.Cells["OptionD"].Value?.ToString());
                    cmdQuestion.Parameters.AddWithValue(@"Correct", row.Cells["CorrectAnswer"].Value?.ToString());

                    cmdQuestion.ExecuteNonQuery();
                }

                MessageBox.Show("Quiz Berhasil Ditambahkan","KONFIRMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Membatalkannya?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (result == DialogResult.Yes)
            {
                this.Owner?.Show();
                this.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RTB_Questions.Text == "" || textBox_A.Text == "" || textBox_B.Text == "" || textBox_C.Text == "" || textBox_D.Text == "")
            {
                MessageBox.Show("Pastikan Pilihan Jawaban terisi","KONFIRMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            string correctAnsware = "";
            if (rB_A.Checked)
                correctAnsware = "A";
            else if (rB_B.Checked)
                correctAnsware = "B";
            else if (rB_C.Checked)
                correctAnsware = "C";
            else if (rB_D.Checked)
                correctAnsware = "D";
            else
            {
                MessageBox.Show("Pilih Jawaban Yang Benar","KONFIRMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            Dgv_QuestionData.Rows.Add(nomor++, RTB_Questions.Text, textBox_A.Text, textBox_B.Text, textBox_C.Text, textBox_D.Text, correctAnsware);

            RTB_Questions.Clear();
            textBox_A.Clear();
            textBox_B.Clear();
            textBox_C.Clear();
            textBox_D.Clear();

            rB_A.Checked = false;
            rB_B.Checked = false;
            rB_C.Checked = false;
            rB_D.Checked = false;
        }

        private void Add_New_Quiz_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            Dgv_QuestionData.Columns.Add(btnDelete);

            
        }
    }
}
