namespace DESKTOP_II__5CG9241T2M_
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox_ShowPassword = new CheckBox();
            button_login = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            textBox_Password = new TextBox();
            textBox_Username = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(25, 118, 210);
            label1.Location = new Point(297, 30);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 0;
            label1.Text = "QuizinAja!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 75);
            label2.Name = "label2";
            label2.Size = new Size(309, 25);
            label2.TabIndex = 1;
            label2.Text = "Infinite Learning, Learn Without Limits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(38, 50, 56);
            label3.Location = new Point(65, 16);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(38, 50, 56);
            label4.Location = new Point(65, 91);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 4;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(391, 279);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(162, 29);
            checkBox_ShowPassword.TabIndex = 6;
            checkBox_ShowPassword.Text = "Show Password";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(25, 118, 210);
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(177, 344);
            button_login.Name = "button_login";
            button_login.Size = new Size(376, 34);
            button_login.TabIndex = 7;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 399);
            label5.Name = "label5";
            label5.Size = new Size(197, 25);
            label5.TabIndex = 8;
            label5.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(25, 118, 210);
            linkLabel1.Location = new Point(391, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(132, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(342, 435);
            label6.Name = "label6";
            label6.Size = new Size(29, 25);
            label6.TabIndex = 10;
            label6.Text = "or";
            label6.Click += label6_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.FromArgb(21, 101, 192);
            linkLabel2.Location = new Point(284, 460);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(150, 25);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "join quiz as quest";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(67, 119);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.PlaceholderText = "Enter your password";
            textBox_Password.Size = new Size(376, 31);
            textBox_Password.TabIndex = 5;
            textBox_Password.TextChanged += textBox2_TextChanged;
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(67, 44);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.PlaceholderText = "Enter your username";
            textBox_Username.Size = new Size(375, 31);
            textBox_Username.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 249, 255);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox_Username);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(112, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 389);
            panel1.TabIndex = 13;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 562);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(button_login);
            Controls.Add(checkBox_ShowPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Form Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox_ShowPassword;
        private Button button_login;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label6;
        private LinkLabel linkLabel2;
        private TextBox textBox_Password;
        private TextBox textBox_Username;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}
