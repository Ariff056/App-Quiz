namespace DESKTOP_II__5CG9241T2M_
{
    partial class Quizz_Form
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
            components = new System.ComponentModel.Container();
            label_Nicname = new Label();
            label_waktu = new Label();
            panel1 = new Panel();
            flowLayoutPanelSoal = new FlowLayoutPanel();
            panel2 = new Panel();
            radioButton_D = new RadioButton();
            radioButton_C = new RadioButton();
            radioButton_B = new RadioButton();
            radioButton_A = new RadioButton();
            label5 = new Label();
            label_Soal = new Label();
            button1 = new Button();
            button_Next = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label_Nicname
            // 
            label_Nicname.AutoSize = true;
            label_Nicname.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_Nicname.Location = new Point(46, 26);
            label_Nicname.Name = "label_Nicname";
            label_Nicname.Size = new Size(211, 32);
            label_Nicname.TabIndex = 0;
            label_Nicname.Text = "[Nickname Anda]";
            // 
            // label_waktu
            // 
            label_waktu.AutoSize = true;
            label_waktu.Location = new Point(46, 67);
            label_waktu.Name = "label_waktu";
            label_waktu.Size = new Size(104, 25);
            label_waktu.TabIndex = 1;
            label_waktu.Text = "label Waktu";
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanelSoal);
            panel1.Location = new Point(24, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 439);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanelSoal
            // 
            flowLayoutPanelSoal.AutoScroll = true;
            flowLayoutPanelSoal.Location = new Point(3, 18);
            flowLayoutPanelSoal.Name = "flowLayoutPanelSoal";
            flowLayoutPanelSoal.Padding = new Padding(5);
            flowLayoutPanelSoal.Size = new Size(358, 255);
            flowLayoutPanelSoal.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton_D);
            panel2.Controls.Add(radioButton_C);
            panel2.Controls.Add(radioButton_B);
            panel2.Controls.Add(radioButton_A);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label_Soal);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button_Next);
            panel2.Location = new Point(408, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 556);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // radioButton_D
            // 
            radioButton_D.AutoSize = true;
            radioButton_D.Location = new Point(26, 361);
            radioButton_D.Name = "radioButton_D";
            radioButton_D.Size = new Size(151, 29);
            radioButton_D.TabIndex = 12;
            radioButton_D.TabStop = true;
            radioButton_D.Text = "radioButton_D";
            radioButton_D.UseVisualStyleBackColor = true;
            // 
            // radioButton_C
            // 
            radioButton_C.AutoSize = true;
            radioButton_C.Location = new Point(26, 326);
            radioButton_C.Name = "radioButton_C";
            radioButton_C.Size = new Size(149, 29);
            radioButton_C.TabIndex = 11;
            radioButton_C.TabStop = true;
            radioButton_C.Text = "radioButton_C";
            radioButton_C.UseVisualStyleBackColor = true;
            // 
            // radioButton_B
            // 
            radioButton_B.AutoSize = true;
            radioButton_B.Location = new Point(26, 291);
            radioButton_B.Name = "radioButton_B";
            radioButton_B.Size = new Size(148, 29);
            radioButton_B.TabIndex = 10;
            radioButton_B.TabStop = true;
            radioButton_B.Text = "radioButton_B";
            radioButton_B.UseVisualStyleBackColor = true;
            // 
            // radioButton_A
            // 
            radioButton_A.AutoSize = true;
            radioButton_A.Location = new Point(26, 256);
            radioButton_A.Name = "radioButton_A";
            radioButton_A.Size = new Size(150, 29);
            radioButton_A.TabIndex = 9;
            radioButton_A.TabStop = true;
            radioButton_A.Text = "radioButton_A";
            radioButton_A.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 228);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 8;
            label5.Text = "Answer";
            // 
            // label_Soal
            // 
            label_Soal.BackColor = Color.FromArgb(25, 118, 210);
            label_Soal.FlatStyle = FlatStyle.Flat;
            label_Soal.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Soal.ForeColor = Color.White;
            label_Soal.Location = new Point(26, 34);
            label_Soal.Name = "label_Soal";
            label_Soal.Size = new Size(62, 35);
            label_Soal.TabIndex = 7;
            label_Soal.Text = "soal";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 118, 210);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(14, 509);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Prev";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_Next
            // 
            button_Next.BackColor = Color.FromArgb(25, 118, 210);
            button_Next.ForeColor = Color.White;
            button_Next.Location = new Point(406, 509);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(112, 34);
            button_Next.TabIndex = 6;
            button_Next.Text = "Next";
            button_Next.UseVisualStyleBackColor = false;
            button_Next.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 115);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 4;
            label3.Text = "Question Lat";
            label3.Click += label3_Click;
            // 
            // Quizz_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 610);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label_waktu);
            Controls.Add(label_Nicname);
            Name = "Quizz_Form";
            Text = "Quizz_Form";
            Load += Quizz_Form_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Nicname;
        private Label label_waktu;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Button button1;
        private Button button_Next;
        private RadioButton radioButton_D;
        private RadioButton radioButton_C;
        private RadioButton radioButton_B;
        private RadioButton radioButton_A;
        private Label label5;
        private Label label_Soal;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanelSoal;
    }
}