namespace DESKTOP_II__5CG9241T2M_
{
    partial class Form_Create_Account
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
            txtBox_Username = new TextBox();
            textBox_Password = new TextBox();
            textBox_FullName = new TextBox();
            textBox_RetypePassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DTP_DateOfBirh = new DateTimePicker();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(224, 48);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 83);
            label2.Name = "label2";
            label2.Size = new Size(482, 25);
            label2.TabIndex = 1;
            label2.Text = "Fill in  below information to complete your registrations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 125);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // txtBox_Username
            // 
            txtBox_Username.Location = new Point(54, 153);
            txtBox_Username.Name = "txtBox_Username";
            txtBox_Username.Size = new Size(347, 31);
            txtBox_Username.TabIndex = 3;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(445, 153);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(347, 31);
            textBox_Password.TabIndex = 4;
            // 
            // textBox_FullName
            // 
            textBox_FullName.Location = new Point(54, 231);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(347, 31);
            textBox_FullName.TabIndex = 5;
            textBox_FullName.TextChanged += textBox3_TextChanged;
            // 
            // textBox_RetypePassword
            // 
            textBox_RetypePassword.Location = new Point(445, 231);
            textBox_RetypePassword.Name = "textBox_RetypePassword";
            textBox_RetypePassword.Size = new Size(347, 31);
            textBox_RetypePassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 125);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 7;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 203);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 8;
            label5.Text = "Full Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(445, 203);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 9;
            label6.Text = "Retype Password";
            label6.Click += label6_Click;
            // 
            // DTP_DateOfBirh
            // 
            DTP_DateOfBirh.Location = new Point(54, 308);
            DTP_DateOfBirh.Name = "DTP_DateOfBirh";
            DTP_DateOfBirh.Size = new Size(347, 31);
            DTP_DateOfBirh.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 280);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 11;
            label7.Text = "Date of Birth";
            // 
            // button1
            // 
            button1.Location = new Point(254, 401);
            button1.Name = "button1";
            button1.Size = new Size(364, 34);
            button1.TabIndex = 12;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(281, 438);
            label8.Name = "label8";
            label8.Size = new Size(213, 25);
            label8.TabIndex = 13;
            label8.Text = "Already have an account?";
            label8.Click += label8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(489, 438);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form_Create_Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(865, 571);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(DTP_DateOfBirh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_RetypePassword);
            Controls.Add(textBox_FullName);
            Controls.Add(textBox_Password);
            Controls.Add(txtBox_Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Create_Account";
            Text = "Form_Create_Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBox_Username;
        private TextBox textBox_Password;
        private TextBox textBox_FullName;
        private TextBox textBox_RetypePassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker DTP_DateOfBirh;
        private Label label7;
        private Button button1;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}