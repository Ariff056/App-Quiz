namespace DESKTOP_II__5CG9241T2M_
{
    partial class View_Quiz_Report_Form
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
            comboBox_Quiz = new ComboBox();
            groupBox1 = new GroupBox();
            Dgv_DetailData = new DataGridView();
            label_Average_Time_Taken = new Label();
            label_Average_Correct_Percentage = new Label();
            label_Total_Participant = new Label();
            button_kembali = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_DetailData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 0;
            label1.Text = "View Quiz Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 52);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = "Quiz";
            // 
            // comboBox_Quiz
            // 
            comboBox_Quiz.FormattingEnabled = true;
            comboBox_Quiz.Location = new Point(70, 52);
            comboBox_Quiz.Name = "comboBox_Quiz";
            comboBox_Quiz.Size = new Size(306, 33);
            comboBox_Quiz.TabIndex = 2;
            comboBox_Quiz.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Dgv_DetailData);
            groupBox1.Location = new Point(25, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 438);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Data";
            // 
            // Dgv_DetailData
            // 
            Dgv_DetailData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_DetailData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_DetailData.Location = new Point(6, 30);
            Dgv_DetailData.Name = "Dgv_DetailData";
            Dgv_DetailData.RowHeadersWidth = 62;
            Dgv_DetailData.Size = new Size(863, 402);
            Dgv_DetailData.TabIndex = 0;
            Dgv_DetailData.CellContentClick += Dgv_DetailData_CellContentClick;
            // 
            // label_Average_Time_Taken
            // 
            label_Average_Time_Taken.AutoSize = true;
            label_Average_Time_Taken.Location = new Point(429, 47);
            label_Average_Time_Taken.Name = "label_Average_Time_Taken";
            label_Average_Time_Taken.Size = new Size(178, 25);
            label_Average_Time_Taken.TabIndex = 4;
            label_Average_Time_Taken.Text = "Average Time Taken :";
            // 
            // label_Average_Correct_Percentage
            // 
            label_Average_Correct_Percentage.AutoSize = true;
            label_Average_Correct_Percentage.Location = new Point(429, 72);
            label_Average_Correct_Percentage.Name = "label_Average_Correct_Percentage";
            label_Average_Correct_Percentage.Size = new Size(239, 25);
            label_Average_Correct_Percentage.TabIndex = 5;
            label_Average_Correct_Percentage.Text = "Average Correct Percentage :";
            label_Average_Correct_Percentage.Click += label4_Click;
            // 
            // label_Total_Participant
            // 
            label_Total_Participant.AutoSize = true;
            label_Total_Participant.Location = new Point(429, 97);
            label_Total_Participant.Name = "label_Total_Participant";
            label_Total_Participant.Size = new Size(187, 25);
            label_Total_Participant.TabIndex = 6;
            label_Total_Participant.Text = "label Total Participant :";
            // 
            // button_kembali
            // 
            button_kembali.BackColor = Color.FromArgb(25, 118, 210);
            button_kembali.FlatStyle = FlatStyle.Flat;
            button_kembali.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_kembali.ForeColor = Color.White;
            button_kembali.Location = new Point(814, 12);
            button_kembali.Name = "button_kembali";
            button_kembali.Size = new Size(108, 31);
            button_kembali.TabIndex = 7;
            button_kembali.Text = "<-kembali";
            button_kembali.UseVisualStyleBackColor = false;
            button_kembali.Click += button_kembali_Click;
            // 
            // View_Quiz_Report_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 615);
            Controls.Add(button_kembali);
            Controls.Add(label_Total_Participant);
            Controls.Add(label_Average_Correct_Percentage);
            Controls.Add(label_Average_Time_Taken);
            Controls.Add(groupBox1);
            Controls.Add(comboBox_Quiz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "View_Quiz_Report_Form";
            Text = "View_Quiz_Report_Form";
            Load += View_Quiz_Report_Form_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dgv_DetailData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox_Quiz;
        private GroupBox groupBox1;
        private DataGridView Dgv_DetailData;
        private Label label_Average_Time_Taken;
        private Label label_Average_Correct_Percentage;
        private Label label_Total_Participant;
        private Button button_kembali;
    }
}