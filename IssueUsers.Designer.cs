namespace Library
{
    partial class IssueUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueUsers));
            RetDate = new DateTimePicker();
            label3 = new Label();
            buttonLoan = new Button();
            buttonRefre = new Button();
            label6 = new Label();
            FilterBox = new ComboBox();
            FiltTxt = new TextBox();
            dataGridView1 = new DataGridView();
            buttonSearch = new Button();
            BookTxt = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button2 = new Button();
            textBoxmail = new TextBox();
            textBoxpass = new TextBox();
            textBoxuser = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RetDate
            // 
            RetDate.Location = new Point(193, 550);
            RetDate.Name = "RetDate";
            RetDate.Size = new Size(196, 23);
            RetDate.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(106, 552);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 41;
            label3.Text = "Return Date";
            // 
            // buttonLoan
            // 
            buttonLoan.Location = new Point(510, 552);
            buttonLoan.Name = "buttonLoan";
            buttonLoan.Size = new Size(172, 23);
            buttonLoan.TabIndex = 40;
            buttonLoan.Text = "Sumbit ";
            buttonLoan.UseVisualStyleBackColor = true;
            // 
            // buttonRefre
            // 
            buttonRefre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            buttonRefre.Location = new Point(669, 364);
            buttonRefre.Name = "buttonRefre";
            buttonRefre.Size = new Size(65, 23);
            buttonRefre.TabIndex = 39;
            buttonRefre.Text = "Refresh";
            buttonRefre.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.Location = new Point(362, 364);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 38;
            label6.Text = "Filter By:";
            // 
            // FilterBox
            // 
            FilterBox.FlatStyle = FlatStyle.System;
            FilterBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            FilterBox.FormattingEnabled = true;
            FilterBox.IntegralHeight = false;
            FilterBox.Items.AddRange(new object[] { "Author Name", "Book Publication", "Genre" });
            FilterBox.Location = new Point(438, 362);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(91, 25);
            FilterBox.TabIndex = 37;
            // 
            // FiltTxt
            // 
            FiltTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            FiltTxt.Location = new Point(535, 364);
            FiltTxt.Multiline = true;
            FiltTxt.Name = "FiltTxt";
            FiltTxt.Size = new Size(128, 23);
            FiltTxt.TabIndex = 36;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 128);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(253, 362);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(70, 23);
            buttonSearch.TabIndex = 34;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // BookTxt
            // 
            BookTxt.Location = new Point(93, 362);
            BookTxt.Name = "BookTxt";
            BookTxt.Size = new Size(154, 23);
            BookTxt.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label4.Location = new Point(5, 362);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 32;
            label4.Text = "Book Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(5, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 82);
            panel2.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.Location = new Point(323, 22);
            label5.Name = "label5";
            label5.Size = new Size(138, 30);
            label5.TabIndex = 2;
            label5.Text = "Change Data";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(184, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(102, 77);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(684, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(5, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 70);
            panel1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(323, 16);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 1;
            label1.Text = "Issued Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(184, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button4.Location = new Point(200, 256);
            button4.Name = "button4";
            button4.Size = new Size(75, 27);
            button4.TabIndex = 53;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button2.Location = new Point(119, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 51;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxmail
            // 
            textBoxmail.Location = new Point(114, 177);
            textBoxmail.Name = "textBoxmail";
            textBoxmail.Size = new Size(161, 23);
            textBoxmail.TabIndex = 49;
            // 
            // textBoxpass
            // 
            textBoxpass.Location = new Point(114, 221);
            textBoxpass.Name = "textBoxpass";
            textBoxpass.Size = new Size(161, 23);
            textBoxpass.TabIndex = 48;
            // 
            // textBoxuser
            // 
            textBoxuser.Location = new Point(114, 124);
            textBoxuser.Name = "textBoxuser";
            textBoxuser.Size = new Size(161, 23);
            textBoxuser.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 45;
            label2.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label7.Location = new Point(14, 222);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 44;
            label7.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label9.Location = new Point(12, 125);
            label9.Name = "label9";
            label9.Size = new Size(69, 17);
            label9.TabIndex = 43;
            label9.Text = "Username";
            // 
            // IssueUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(743, 583);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBoxmail);
            Controls.Add(textBoxpass);
            Controls.Add(textBoxuser);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(RetDate);
            Controls.Add(label3);
            Controls.Add(buttonLoan);
            Controls.Add(buttonRefre);
            Controls.Add(label6);
            Controls.Add(FilterBox);
            Controls.Add(FiltTxt);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearch);
            Controls.Add(BookTxt);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueUsers";
            Text = "IssueUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker RetDate;
        private Label label3;
        private Button buttonLoan;
        private Button buttonRefre;
        private Label label6;
        private ComboBox FilterBox;
        private TextBox FiltTxt;
        private DataGridView dataGridView1;

        private Button buttonSearch;
        private TextBox BookTxt;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button2;
        private TextBox textBoxmail;
        private TextBox textBoxpass;
        private TextBox textBoxuser;
        private Label label2;
        private Label label7;
        private Label label9;
    }
}