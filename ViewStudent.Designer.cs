namespace Library
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            UserTxt = new TextBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SearBTN = new Button();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBoxrole = new TextBox();
            textBoxmail = new TextBox();
            textBoxpass = new TextBox();
            textBoxuser = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(422, 30);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 1;
            label1.Text = "Search For A Student";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label2.Location = new Point(203, 136);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(291, 136);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(154, 23);
            UserTxt.TabIndex = 2;
            // 
            // SearBTN
            // 
            SearBTN.Location = new Point(451, 136);
            SearBTN.Name = "SearBTN";
            SearBTN.Size = new Size(70, 23);
            SearBTN.TabIndex = 3;
            SearBTN.Text = "Search";
            SearBTN.UseVisualStyleBackColor = true;
            SearBTN.Click += SearBTN_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cornsilk;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBoxrole);
            panel3.Controls.Add(textBoxmail);
            panel3.Controls.Add(textBoxpass);
            panel3.Controls.Add(textBoxuser);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(-1, 364);
            panel3.Name = "panel3";
            panel3.Size = new Size(740, 124);
            panel3.TabIndex = 5;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button4.Location = new Point(638, 88);
            button4.Name = "button4";
            button4.Size = new Size(75, 27);
            button4.TabIndex = 14;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button3.Location = new Point(638, 51);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button2.Location = new Point(638, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxrole
            // 
            textBoxrole.Location = new Point(427, 88);
            textBoxrole.Name = "textBoxrole";
            textBoxrole.Size = new Size(161, 23);
            textBoxrole.TabIndex = 9;
            // 
            // textBoxmail
            // 
            textBoxmail.Location = new Point(139, 88);
            textBoxmail.Name = "textBoxmail";
            textBoxmail.Size = new Size(161, 23);
            textBoxmail.TabIndex = 8;
            // 
            // textBoxpass
            // 
            textBoxpass.Location = new Point(427, 33);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.Size = new Size(161, 23);
            textBoxpass.TabIndex = 7;
            // 
            // textBoxuser
            // 
            textBoxuser.Location = new Point(139, 35);
            textBoxuser.Name = "textBoxuser";
            textBoxuser.Size = new Size(161, 23);
            textBoxuser.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label8.Location = new Point(365, 92);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 3;
            label8.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.Location = new Point(37, 89);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4.Location = new Point(355, 36);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label3.Location = new Point(37, 36);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(692, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(712, 185);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(738, 487);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(SearBTN);
            Controls.Add(UserTxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudent";
            Text = "ViewStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox UserTxt;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button SearBTN;
        private Panel panel3;
        private TextBox textBoxmail;
        private TextBox textBoxpass;
        private TextBox textBoxuser;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBoxrole;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}