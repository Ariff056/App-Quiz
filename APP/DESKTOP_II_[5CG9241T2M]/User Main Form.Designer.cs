namespace DESKTOP_II__5CG9241T2M_
{
    partial class User_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Main_Form));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Dgv_Quizz = new DataGridView();
            ColDelete = new DataGridViewTextBoxColumn();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label_nama = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Dgv_Quizz).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 118, 210);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 199);
            button1.Name = "button1";
            button1.Size = new Size(176, 34);
            button1.TabIndex = 2;
            button1.Text = "Add Quiz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 118, 210);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 250);
            button2.Name = "button2";
            button2.Size = new Size(176, 34);
            button2.TabIndex = 3;
            button2.Text = "View Quiz Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(33, 485);
            button3.Name = "button3";
            button3.Size = new Size(176, 51);
            button3.TabIndex = 4;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Dgv_Quizz
            // 
            Dgv_Quizz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Quizz.Columns.AddRange(new DataGridViewColumn[] { ColDelete });
            Dgv_Quizz.Location = new Point(247, 109);
            Dgv_Quizz.Name = "Dgv_Quizz";
            Dgv_Quizz.RowHeadersWidth = 62;
            Dgv_Quizz.Size = new Size(622, 445);
            Dgv_Quizz.TabIndex = 5;
            // 
            // ColDelete
            // 
            ColDelete.HeaderText = "Delete";
            ColDelete.MinimumWidth = 8;
            ColDelete.Name = "ColDelete";
            ColDelete.ToolTipText = "Delete";
            ColDelete.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 81);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 6;
            label3.Text = "Your quizz";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 138);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label_nama);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 554);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(239, 68, 68);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 496);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nama.ForeColor = Color.White;
            label_nama.Location = new Point(90, 93);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(76, 30);
            label_nama.TabIndex = 1;
            label_nama.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 96);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // User_Main_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 249, 255);
            BackgroundImage = Properties.Resources.ChatGPT_Image_10_Sep_2026__09_11_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(881, 566);
            Controls.Add(label3);
            Controls.Add(Dgv_Quizz);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "User_Main_Form";
            Text = "User_Main_Form";
            Load += User_Main_Form_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Quizz).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView Dgv_Quizz;
        private Label label3;
        private DataGridViewTextBoxColumn ColDelete;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label_nama;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}