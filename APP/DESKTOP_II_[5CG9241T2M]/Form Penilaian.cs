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
    public partial class Form_Penilaian : Form
    {
        private int ParticipantID;
        private int QuizID;
        private TimeSpan WaktuPengerjaan;

        public Form_Penilaian(int participantID,int quizID,TimeSpan waktu)
        {
            InitializeComponent();
            ParticipantID = participantID;
            QuizID = quizID;
            WaktuPengerjaan = waktu;

            TampilkanHasilQuiz();

        }
        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";

        private void TampilkanHasilQuiz()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string querryNilai = @"SELECT COUNT(*) FROM ParticipantAnswer PA INNER JOIN Question Q ON PA.QuestionID = Q.ID WHERE PA.ParticipantID = @ParticipantID AND PA.Answer = CASE Q.CorrectAnswer
                                       WHEN 'A' THEN Q.OptionA WHEN 'B' THEN Q.OptionB WHEN 'C' THEN Q.OptionC WHEN 'D' THEN Q.OptionD END";

                int JumlahBenar = 0;

                using (SqlCommand cmdnilai = new SqlCommand(querryNilai,conn))
                {
                    cmdnilai.Parameters.AddWithValue(@"ParticipantID", ParticipantID);

                    JumlahBenar = Convert.ToInt32(cmdnilai.ExecuteScalar());
                }

                string TotalSoal = @"SELECT COUNT(*) FROM ParticipantAnswer WHERE ParticipantID =@ParticipantID";

                int totalSoal = 0;

                using(SqlCommand cmdSoal = new SqlCommand(TotalSoal,conn))
                {
                    cmdSoal.Parameters.AddWithValue(@"ParticipantID", ParticipantID);
                    totalSoal = Convert.ToInt32(cmdSoal.ExecuteScalar());
                }

                int nilai = 0;
                if(totalSoal > 0)
                {
                    nilai = (JumlahBenar * 100) / totalSoal;

                    label_Nilai.Text = nilai.ToString(); 


                    label_Waktu.Text = WaktuPengerjaan.ToString(@"hh\:mm\:ss");

                }

                string querryRanking = @"SELECT COUNT(*) +1 FROM (SELECT P.ID,COUNT(CASE WHEN PA.Answer = CASE Q.CorrectAnswer WHEN 'A' THEN Q.OptionA WHEN 'B' THEN Q.OptionB WHEN 'C' THEN Q.OptionC WHEN 'D'THEN Q.OptionD END THEN 1 END) * 100.0 / COUNT(PA.QuestionID) AS Nilai FROM Participant P
                                         INNER JOIN ParticipantAnswer PA  ON P.ID = PA.ParticipantID INNER JOIN Question Q ON PA.QuestionID = Q.ID WHERE P.QuizID = @QuizID GROUP BY P.ID) AS Ranking WHERE Ranking.Nilai > @Nilai";

                int Peringkat = 1;
                using(SqlCommand cmdPeringkat = new SqlCommand(querryRanking,conn))
                {
                    cmdPeringkat.Parameters.AddWithValue(@"QuizID", QuizID);
                    cmdPeringkat.Parameters.AddWithValue(@"Nilai", nilai);

                    Peringkat = Convert.ToInt32(cmdPeringkat.ExecuteScalar());

                    label_ranking.Text = Peringkat.ToString();
                    
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form_Penilaian_Load(object sender, EventArgs e)
        {

        }
    }
}
