namespace DESKTOP_II__5CG9241T2M_
{
    partial class Add_New_Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_quizname = new TextBox();
            textBox_QuizCode = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            Dgv_QuestionData = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Question = new DataGridViewTextBoxColumn();
            OptionA = new DataGridViewTextBoxColumn();
            OptionB = new DataGridViewTextBoxColumn();
            OptionC = new DataGridViewTextBoxColumn();
            OptionD = new DataGridViewTextBoxColumn();
            CorrectAnswer = new DataGridViewTextBoxColumn();
            button3 = new Button();
            textBox_D = new TextBox();
            textBox_C = new TextBox();
            textBox_B = new TextBox();
            textBox_A = new TextBox();
            rB_D = new RadioButton();
            rB_C = new RadioButton();
            rB_B = new RadioButton();
            rB_A = new RadioButton();
            label7 = new Label();
            RTB_Questions = new RichTextBox();
            label6 = new Label();
            button_save = new Button();
            button_cancel = new Button();
            RTB_QuizDescription = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_QuestionData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 0;
            label1.Text = "Add New Quizz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 46);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 1;
            label2.Text = "Fill in the quizz detail below";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 76);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Quiz Name";
            label3.Click += label3_Click;
            // 
            // textBox_quizname
            // 
            textBox_quizname.Location = new Point(23, 104);
            textBox_quizname.Name = "textBox_quizname";
            textBox_quizname.Size = new Size(344, 31);
            textBox_quizname.TabIndex = 3;
            // 
            // textBox_QuizCode
            // 
            textBox_QuizCode.Location = new Point(23, 175);
            textBox_QuizCode.Name = "textBox_QuizCode";
            textBox_QuizCode.Size = new Size(344, 31);
            textBox_QuizCode.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 147);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 5;
            label4.Text = "Quiz Code";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 96);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 6;
            label5.Text = "Quiz Description";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Dgv_QuestionData);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox_D);
            groupBox1.Controls.Add(textBox_C);
            groupBox1.Controls.Add(textBox_B);
            groupBox1.Controls.Add(textBox_A);
            groupBox1.Controls.Add(rB_D);
            groupBox1.Controls.Add(rB_C);
            groupBox1.Controls.Add(rB_B);
            groupBox1.Controls.Add(rB_A);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(RTB_Questions);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(23, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 362);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questions Data";
            // 
            // Dgv_QuestionData
            // 
            Dgv_QuestionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_QuestionData.Columns.AddRange(new DataGridViewColumn[] { No, Question, OptionA, OptionB, OptionC, OptionD, CorrectAnswer });
            Dgv_QuestionData.Location = new Point(6, 191);
            Dgv_QuestionData.Name = "Dgv_QuestionData";
            Dgv_QuestionData.RowHeadersWidth = 62;
            Dgv_QuestionData.Size = new Size(730, 165);
            Dgv_QuestionData.TabIndex = 20;
            Dgv_QuestionData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ToolTipText = "No";
            No.Width = 150;
            // 
            // Question
            // 
            Question.HeaderText = "Question";
            Question.MinimumWidth = 8;
            Question.Name = "Question";
            Question.ToolTipText = "Question";
            Question.Width = 150;
            // 
            // OptionA
            // 
            OptionA.HeaderText = "OptionA";
            OptionA.MinimumWidth = 8;
            OptionA.Name = "OptionA";
            OptionA.ToolTipText = "OptionA";
            OptionA.Width = 150;
            // 
            // OptionB
            // 
            OptionB.HeaderText = "OptionB";
            OptionB.MinimumWidth = 8;
            OptionB.Name = "OptionB";
            OptionB.ToolTipText = "OptionB";
            OptionB.Width = 150;
            // 
            // OptionC
            // 
            OptionC.HeaderText = "OptionC";
            OptionC.MinimumWidth = 8;
            OptionC.Name = "OptionC";
            OptionC.ToolTipText = "OptionC";
            OptionC.Width = 150;
            // 
            // OptionD
            // 
            OptionD.HeaderText = "OptionD";
            OptionD.MinimumWidth = 8;
            OptionD.Name = "OptionD";
            OptionD.ToolTipText = "OptionD";
            OptionD.Width = 150;
            // 
            // CorrectAnswer
            // 
            CorrectAnswer.HeaderText = "CorrectAnswer";
            CorrectAnswer.MinimumWidth = 8;
            CorrectAnswer.Name = "CorrectAnswer";
            CorrectAnswer.ToolTipText = "CorrectAnswer";
            CorrectAnswer.Width = 150;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(25, 118, 210);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(515, 53);
            button3.Name = "button3";
            button3.Size = new Size(138, 34);
            button3.TabIndex = 19;
            button3.Text = "Add Question";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox_D
            // 
            textBox_D.Font = new Font("Segoe UI", 7F);
            textBox_D.Location = new Point(293, 151);
            textBox_D.Name = "textBox_D";
            textBox_D.Size = new Size(186, 26);
            textBox_D.TabIndex = 18;
            // 
            // textBox_C
            // 
            textBox_C.Font = new Font("Segoe UI", 7F);
            textBox_C.Location = new Point(293, 119);
            textBox_C.Name = "textBox_C";
            textBox_C.Size = new Size(186, 26);
            textBox_C.TabIndex = 17;
            // 
            // textBox_B
            // 
            textBox_B.Font = new Font("Segoe UI", 7F);
            textBox_B.Location = new Point(293, 87);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(186, 26);
            textBox_B.TabIndex = 16;
            // 
            // textBox_A
            // 
            textBox_A.Font = new Font("Segoe UI", 7F);
            textBox_A.Location = new Point(293, 55);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(186, 26);
            textBox_A.TabIndex = 15;
            // 
            // rB_D
            // 
            rB_D.AutoSize = true;
            rB_D.Font = new Font("Segoe UI", 7F);
            rB_D.Location = new Point(269, 157);
            rB_D.Name = "rB_D";
            rB_D.Size = new Size(115, 23);
            rB_D.TabIndex = 14;
            rB_D.TabStop = true;
            rB_D.Text = "radioButton4";
            rB_D.UseVisualStyleBackColor = true;
            // 
            // rB_C
            // 
            rB_C.AutoSize = true;
            rB_C.Font = new Font("Segoe UI", 7F);
            rB_C.Location = new Point(269, 119);
            rB_C.Name = "rB_C";
            rB_C.Size = new Size(115, 23);
            rB_C.TabIndex = 13;
            rB_C.TabStop = true;
            rB_C.Text = "radioButton3";
            rB_C.UseVisualStyleBackColor = true;
            rB_C.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rB_B
            // 
            rB_B.AutoSize = true;
            rB_B.Font = new Font("Segoe UI", 7F);
            rB_B.Location = new Point(269, 87);
            rB_B.Name = "rB_B";
            rB_B.Size = new Size(115, 23);
            rB_B.TabIndex = 12;
            rB_B.TabStop = true;
            rB_B.Text = "radioButton2";
            rB_B.UseVisualStyleBackColor = true;
            // 
            // rB_A
            // 
            rB_A.AutoSize = true;
            rB_A.Font = new Font("Segoe UI", 7F);
            rB_A.Location = new Point(269, 56);
            rB_A.Name = "rB_A";
            rB_A.Size = new Size(115, 23);
            rB_A.TabIndex = 11;
            rB_A.TabStop = true;
            rB_A.Text = "radioButton1";
            rB_A.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 27);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 10;
            label7.Text = "Answer";
            // 
            // RTB_Questions
            // 
            RTB_Questions.Location = new Point(6, 55);
            RTB_Questions.Name = "RTB_Questions";
            RTB_Questions.Size = new Size(244, 111);
            RTB_Questions.TabIndex = 9;
            RTB_Questions.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 27);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 8;
            label6.Text = "Question";
            // 
            // button_save
            // 
            button_save.BackColor = Color.FromArgb(25, 118, 210);
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_save.ForeColor = Color.White;
            button_save.Location = new Point(564, 608);
            button_save.Name = "button_save";
            button_save.Size = new Size(112, 34);
            button_save.TabIndex = 0;
            button_save.Text = "save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(25, 118, 210);
            button_cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(682, 608);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(112, 34);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // RTB_QuizDescription
            // 
            RTB_QuizDescription.Location = new Point(399, 124);
            RTB_QuizDescription.Name = "RTB_QuizDescription";
            RTB_QuizDescription.Size = new Size(419, 82);
            RTB_QuizDescription.TabIndex = 9;
            RTB_QuizDescription.Text = "";
            // 
            // Add_New_Quiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 654);
            Controls.Add(RTB_QuizDescription);
            Controls.Add(button_save);
            Controls.Add(button_cancel);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_QuizCode);
            Controls.Add(textBox_quizname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_New_Quiz";
            Text = "Add_New_Quiz";
            Load += Add_New_Quiz_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_QuestionData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_quizname;
        private TextBox textBox_QuizCode;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button button_save;
        private Button button_cancel;
        private Label label6;
        private RichTextBox RTB_QuizDescription;
        private RadioButton rB_D;
        private RadioButton rB_C;
        private RadioButton rB_B;
        private RadioButton rB_A;
        private Label label7;
        private RichTextBox RTB_Questions;
        private TextBox textBox_D;
        private TextBox textBox_C;
        private TextBox textBox_B;
        private TextBox textBox_A;
        private DataGridView Dgv_QuestionData;
        private Button button3;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn OptionA;
        private DataGridViewTextBoxColumn OptionB;
        private DataGridViewTextBoxColumn OptionC;
        private DataGridViewTextBoxColumn OptionD;
        private DataGridViewTextBoxColumn CorrectAnswer;
    }
}