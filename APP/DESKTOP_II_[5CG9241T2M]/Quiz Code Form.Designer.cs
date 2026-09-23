namespace DESKTOP_II__5CG9241T2M_
{
    partial class Quiz_Code_Form
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
            textBox_QuizCode = new TextBox();
            label2 = new Label();
            textBox_nickname = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 83);
            label1.Name = "label1";
            label1.Size = new Size(280, 34);
            label1.TabIndex = 0;
            label1.Text = "Enter Quiz Code!";
            // 
            // textBox_QuizCode
            // 
            textBox_QuizCode.Font = new Font("Segoe UI", 11F);
            textBox_QuizCode.Location = new Point(153, 150);
            textBox_QuizCode.Name = "textBox_QuizCode";
            textBox_QuizCode.Size = new Size(373, 37);
            textBox_QuizCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 228);
            label2.Name = "label2";
            label2.Size = new Size(183, 22);
            label2.TabIndex = 2;
            label2.Text = "Enter  Nickname!";
            // 
            // textBox_nickname
            // 
            textBox_nickname.Font = new Font("Segoe UI", 11F);
            textBox_nickname.Location = new Point(153, 275);
            textBox_nickname.Name = "textBox_nickname";
            textBox_nickname.Size = new Size(373, 37);
            textBox_nickname.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 118, 210);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(153, 357);
            button1.Name = "button1";
            button1.Size = new Size(373, 44);
            button1.TabIndex = 4;
            button1.Text = "JOIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Quiz_Code_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(686, 523);
            Controls.Add(button1);
            Controls.Add(textBox_nickname);
            Controls.Add(label2);
            Controls.Add(textBox_QuizCode);
            Controls.Add(label1);
            Name = "Quiz_Code_Form";
            Text = "Quiz_Code_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_QuizCode;
        private Label label2;
        private TextBox textBox_nickname;
        private Button button1;
    }
}