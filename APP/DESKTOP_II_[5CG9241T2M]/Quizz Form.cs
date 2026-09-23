using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;


namespace DESKTOP_II__5CG9241T2M_
{
    
    public partial class  Quizz_Form : Form
    {

        private TimeSpan timeElapsed;
        private int UserID;
        private int QuizID;
        private DataTable dtSoal;
        private int currentQuestionIndex = 0;
        private bool[] sudahDijawab;
        private string[] jawabanUser;
        private bool sedangMenampilkanSoal = false;
        private string ParticipantNickname;
        
        public Quizz_Form(string Nickname,int quizID)
        {
            InitializeComponent();
            label_Nicname.Text = Nickname;
            ParticipantNickname = Nickname;
            
         
            this.QuizID = quizID;

            radioButton_A.CheckedChanged += JawabanDipilih;
            radioButton_B.CheckedChanged += JawabanDipilih;
            radioButton_C.CheckedChanged += JawabanDipilih;
            radioButton_D.CheckedChanged += JawabanDipilih;


        }

        private string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QuizinAja;Integrated Security=True;TrustServerCertificate=True";

        public class QuestionModel
        {
            public int ID { get; set; }
            public string Question { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectAnswer { get; set;}
            public string UserAnswer { get; set; }
        }

        private void NomorSoal()
        {
            flowLayoutPanelSoal.Controls.Clear();

            for (int i = 0; i < dtSoal.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Text = (i + 1).ToString();
                btn.Width = 60;
                btn.Height = 55;
                btn.Margin = new Padding(5);

                btn.BackColor = Color.LightGray;
                btn.ForeColor = Color.Black;

                btn.Tag = i;

                btn.Click += NomorSoal_Click;

                flowLayoutPanelSoal.Controls.Add(btn);
            }
        }

        private void NomorSoal_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;
            int index = Convert.ToInt32(btn.Tag);

            currentQuestionIndex = index;

            TampilkanSoal();
        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query ="SELECT ID,Question,OptionA,OptionB,OptionC,OptionD,CorrectAnswer FROM Question WHERE QuizID =@QuizID ORDER BY ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(@"QuizID",SqlDbType.Int).Value = QuizID;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtSoal = new DataTable();
                da.Fill(dtSoal);


                if(dtSoal.Rows.Count > 0)
                {
                    currentQuestionIndex = 0;

                    sudahDijawab = new bool[dtSoal.Rows.Count];
                    jawabanUser = new string[dtSoal.Rows.Count];

                    NomorSoal();

                    TampilkanSoal();
                }
                else
                {
                    MessageBox.Show("Data Soal Tidak Ditemukan","INFORMASI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }

        }
        
        private void TampilkanSoal()
        {
          
            if (dtSoal == null || dtSoal.Rows.Count == 0)
                return;

            sedangMenampilkanSoal = true;
            DataRow row = dtSoal.Rows[currentQuestionIndex];
            label_Soal.Text = row["Question"].ToString();
            label_Soal.AutoSize = false;
            label_Soal.MaximumSize = new Size(500, 0);
            label_Soal.Width = 500;
            label_Soal.Height = 100;

            radioButton_A.Text = row["OptionA"].ToString();
            radioButton_B.Text = row["OptionB"].ToString();
            radioButton_C.Text = row["OptionC"].ToString();
            radioButton_D.Text = row["OptionD"].ToString();


            radioButton_A.Checked = false;
            radioButton_B.Checked = false;
            radioButton_C.Checked = false;
            radioButton_D.Checked = false;

            if (jawabanUser[currentQuestionIndex] == "A")
                radioButton_A.Checked = true;
            else if (jawabanUser[currentQuestionIndex] == "B")
                radioButton_B.Checked = true;
            else if (jawabanUser[currentQuestionIndex] == "C")
                radioButton_C.Checked = true;
            else if (jawabanUser[currentQuestionIndex] == "D")
                radioButton_D.Checked = true;

            sedangMenampilkanSoal = false;
            UpdateWarnaTombol();
        }

        
        private void TandaiSudahDijawab(int nomorSoal)
        {
            int index = nomorSoal - 1;

            if (index >= 0 && index < sudahDijawab.Length)
            {
                sudahDijawab[index] = true;
            }

            UpdateWarnaTombol();
        }

        private void JawabanDipilih(object sender , EventArgs e)
        {
            if (sedangMenampilkanSoal)
                return;
            RadioButton rb = sender as RadioButton;

            if(rb != null && rb.Checked)
            {
                if(rb == radioButton_A)
                {
                    jawabanUser[currentQuestionIndex] = "A";
                }
                else if(rb == radioButton_B)
                {
                    jawabanUser[currentQuestionIndex] = "B";
                }
                else if(rb == radioButton_C)
                {
                    jawabanUser[currentQuestionIndex] = "C";
                }
                else if(rb == radioButton_D)
                {
                    jawabanUser[currentQuestionIndex] = "D";
                }

                TandaiSudahDijawab(currentQuestionIndex + 1);
            }
            
        }

        private void UpdateWarnaTombol()
        {

            for(int i = 0; i < flowLayoutPanelSoal.Controls.Count; i++)
            {
                Button btn = flowLayoutPanelSoal.Controls[i] as Button;
                if (btn == null)
                    continue;
                if (sudahDijawab[i])
                {
                    btn.BackColor = Color.FromArgb(25,118,210);                    
                    btn.ForeColor = Color.White;
                }
                else if(i == currentQuestionIndex)
                {
                    btn.BackColor = Color.Gold;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.LightGray;
                    btn.ForeColor = Color.Black;
                }
                
            }
        }

        private void simpanHasilQuiz()
        {
            int participantID = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string querryparticipant = "INSERT INTO Participant(QuizID,ParticipantNickname,ParticipationDate,TimeTaken)OUTPUT INSERTED.ID VALUES(@QuizID,@ParticipantNickname,@ParticipationDate,@TimeTaken)";
                    SqlCommand cmdParticipant = new SqlCommand(querryparticipant, conn, transaction);

                    cmdParticipant.Parameters.AddWithValue(@"QuizID", QuizID);
                    cmdParticipant.Parameters.AddWithValue(@"ParticipantNickname", ParticipantNickname);
                    cmdParticipant.Parameters.AddWithValue(@"ParticipationDate", DateTime.Now);
                    cmdParticipant.Parameters.AddWithValue(@"TimeTaken", (int)timeElapsed.TotalSeconds);

                     participantID = Convert.ToInt32(cmdParticipant.ExecuteScalar());

                    for(int i = 0; i < dtSoal.Rows.Count; i++ )
                    {
                        int questionID = Convert.ToInt32(dtSoal.Rows[i]["ID"]);

                        string answare = AmbilIsiJawaban(i);

                        string queryAnswer = @"INSERT INTO  ParticipantAnswer(ParticipantID,QuestionID,Answer) VALUES (@ParticipantID,@QuestionID,@Answer)";
                        SqlCommand cmdAnswer = new SqlCommand(queryAnswer, conn, transaction);

                        cmdAnswer.Parameters.AddWithValue(@"ParticipantID", participantID);
                        cmdAnswer.Parameters.AddWithValue(@"QuestionID", questionID);
                        cmdAnswer.Parameters.AddWithValue(@"Answer", answare ?? "");

                        cmdAnswer.ExecuteNonQuery();
                    }

                    transaction.Commit();
                  
                }
                catch(Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {

                    }
                    MessageBox.Show("Gagal Menyimpan Hasil Quiz:\n" + ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
               

            }

            MessageBox.Show("Selamat Quiz Berhasi DIselesaikan", "QUIZ SELESAI", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Form_Penilaian Fp = new Form_Penilaian(participantID, QuizID, timeElapsed);
            Fp.Show();
            this.Hide();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private string AmbilJawaban()
        {
            if (radioButton_A.Checked)
                return "A";
            if(radioButton_B.Checked)
                return "B";
            if (radioButton_C.Checked)
                return "C";
            if( radioButton_D.Checked)
                return "D";

            return null;

        }

        private string AmbilIsiJawaban(int indexSoal)
        {
            string kodeJawaban = jawabanUser[indexSoal];

            if (string.IsNullOrEmpty(kodeJawaban))
                return "";

            DataRow row = dtSoal.Rows[indexSoal];

            switch (kodeJawaban)
            {
                case "A":
                    return row["OptionA"].ToString();

                case "B":
                    return row["OptionB"].ToString();

                case "C":
                    return row["OptionC"].ToString();

                case "D":
                    return row["OptionD"].ToString();

                default:
                    return "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jawaban = AmbilJawaban();
            
            if (!radioButton_A.Checked && !radioButton_B.Checked && !radioButton_C.Checked && !radioButton_D.Checked)
            {
                MessageBox.Show("Pilih Jawaban Terlebih Dahulu", "Peringatan", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            jawabanUser[currentQuestionIndex] = jawaban;
            TandaiSudahDijawab(currentQuestionIndex + 1);
            

            if(currentQuestionIndex == dtSoal.Rows.Count -1)
            {
                simpanHasilQuiz();
                return;
            }
            
            currentQuestionIndex++;
            TampilkanSoal();
        }

        private void Quizz_Form_Load(object sender, EventArgs e)
        {
           
            timeElapsed = TimeSpan.Zero;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            timer1.Start();


            LoadData();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed = timeElapsed.Add(TimeSpan.FromSeconds(1));

            label_waktu.Text = "Time Elapsed: " + timeElapsed.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Kembali ke Halaman Sebelumnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            if(currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                
                TampilkanSoal();

            }
            else
            {
                MessageBox.Show("Ini Adalah Soal Pertama", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
