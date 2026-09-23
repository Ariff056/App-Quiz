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
    public partial class View_Quiz_Report_Form : Form
    {
        private int UserID;

        public View_Quiz_Report_Form(int userID)
        {
            InitializeComponent();
            this.UserID = userID;



        }
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT ID,Name FROM Quiz WHERE UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(@"UserID", UserID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox_Quiz.DataSource = dt;
                comboBox_Quiz.DisplayMember = "Name";
                comboBox_Quiz.ValueMember = "ID";
                comboBox_Quiz.SelectedIndex = -1;

            }

        }

        private void loadSummary(int quizID)
        {
            using (SqlConnection conn = new SqlConnection((string)ConnectionString))
            {
                conn.Open();
                string Queery = @"WITH QuestionCount AS (SELECT QuizID,COUNT(*) AS TotalQuestions FROM Question WHERE QuizID = @QuizID GROUP BY QuizID), ParticipantScore AS (SELECT P.ID AS ParticipantID, P.TimeTaken,
                                 CAST(COALESCE(SUM(CASE WHEN PA.Answer = Q.CorrectAnswer THEN 1 ELSE 0 END ),0)*100.0 / NULLIF(QC.TotalQuestions,0) AS DECIMAL(5,2)) AS CorrectPercentage FROM Participant P LEFT JOIN ParticipantAnswer PA ON
                                 P.ID=PA.ParticipantID LEFT JOIN Question Q  ON PA.QuestionID=Q.ID AND Q.QuizID = P.QuizID INNER JOIN QuestionCount QC ON P.QuizID = QC.QuizID WHERE P.QuizID=@QuizID  GROUP BY P.ID,P.TimeTaken,P.QuizID,QC.TotalQuestions)
                                 SELECT AVG(CAST(TimeTaken AS FLOAT)) AS AverageTime, AVG(CAST(CorrectPercentage AS FlOAT)) AS AveragePercentage,
                                 COUNT (*) AS TotalParticipants FROM ParticipantScore";

                SqlCommand cmd = new SqlCommand(Queery, conn);
                cmd.Parameters.AddWithValue(@"QuizID", quizID);

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    if (reader["AverageTime"] !=DBNull.Value)
                    {
                        double averageSeconds = Convert.ToDouble(reader["AverageTime"]);

                        TimeSpan averageTime = TimeSpan.FromSeconds(averageSeconds);

                        label_Average_Time_Taken.Text = "Average Time Taken: " + averageTime.ToString(@"hh\:mm\:ss");
                        
                    }
                    else
                    {
                        label_Average_Time_Taken.Text = " Average Time Taken: 00:00:00";
                    }


                    if(reader["AveragePercentage"] !=DBNull.Value)
                    {
                        double averagePercentage = Convert.ToDouble(reader["AveragePercentage"]);

                        label_Average_Correct_Percentage.Text = " Average Correct Percentage: " + averagePercentage.ToString("0") + "%";
                    }
                    else
                    {
                        label_Average_Correct_Percentage.Text = "Average Correct Percentage: 0%";
                    }


                    int totalParticipant = Convert.ToInt32(reader["TotalParticipants"]);

                    label_Total_Participant.Text = "Total Participant: " + totalParticipant;
                }
            }
        }

        private void loadParticipantData(int quizID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string Querydgv = @"WITH QuestionCount AS (SELECT QuizID,COUNT(*) AS TotalQuestions FROM Question WHERE QuizID=@QuizID GROUP BY QuizID)
                                  SELECT P.ParticipantNickname,CONVERT(varchar(8),DATEADD(SECOND,P.TimeTaken,'00:00:00'),108) AS TimeTaken, CONCAT(CAST(COALESCE(SUM(CASE WHEN PA.Answer = Q.CorrectAnswer THEN 1 ELSE 0 END),0)*100.0 / NULLIF(QC.TotalQuestions,0) AS INT),'%') As CorrectPercentage  FROM Participant P
                                  LEFT JOIN ParticipantAnswer PA ON P.ID = PA.ParticipantID LEFT JOIN Question Q ON PA.QuestionID = Q.ID AND Q.QuizID = P.QuizID INNER JOIN QuestionCount QC ON P.QuizID = QC.QuizID WHERE P.QuizID=@QuizID  GROUP BY P.ID,P.ParticipantNickname,P.TimeTaken,P.QuizID,QC.TotalQuestions ORDER BY P.ParticipantNickname ASC ";

                SqlCommand cmd = new SqlCommand(Querydgv, conn);
                cmd.Parameters.AddWithValue(@"QuizID", quizID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                Dgv_DetailData.Columns.Clear();

                Dgv_DetailData.AutoGenerateColumns = true;

                Dgv_DetailData.DataSource = dt;

                if (Dgv_DetailData.Columns.Contains("ParticipantNickname"))
                {
                    Dgv_DetailData.Columns["ParticipantNickname"].HeaderText = "Participant Nickname";
                    Dgv_DetailData.Columns["ParticipantNickname"].Width = 110;
                }
                if (Dgv_DetailData.Columns.Contains("TimeTaken"))
                {
                    Dgv_DetailData.Columns["TimeTaken"].HeaderText = "Time Taken";
                    Dgv_DetailData.Columns["TimeTaken"].Width = 120;
                }

                if (Dgv_DetailData.Columns.Contains("CorrectPercentage"))
                {
                    Dgv_DetailData.Columns["CorrectPercentage"].HeaderText = "Correct Percentage";
                    Dgv_DetailData.Columns["CorrectPercentage"].Width = 255;
                }

                Dgv_DetailData.AllowUserToAddRows = false;

                
            }
        }

        private void View_Quiz_Report_Form_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button_kembali_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Kembali?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            if (result == DialogResult.Yes)
            {
                this.Owner?.Show();
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Quiz.SelectedIndex == -1)
                return;
            if (comboBox_Quiz.SelectedValue == null)
                return;
            if (comboBox_Quiz.SelectedValue is DataRowView)
                return;

            int quizID = Convert.ToInt32(comboBox_Quiz.SelectedValue);

            loadSummary(quizID);
            loadParticipantData(quizID);
            
        }

        private void Dgv_DetailData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}