namespace Library
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            buttonSearch = new Button();
            BookTxt = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            buttonRefre = new Button();
            label6 = new Label();
            FilterBox = new ComboBox();
            FiltTxt = new TextBox();
            buttonLoan = new Button();
            RetDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            UserTxt = new TextBox();
            SearBTN = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 285);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 70);
            panel1.TabIndex = 0;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(681, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(733, 128);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(2, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 82);
            panel2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.Location = new Point(323, 22);
            label5.Name = "label5";
            label5.Size = new Size(220, 30);
            label5.TabIndex = 2;
            label5.Text = "Search For A Student";
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
            // buttonSearch
            // 
            buttonSearch.Location = new Point(250, 358);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(70, 23);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // BookTxt
            // 
            BookTxt.Location = new Point(90, 358);
            BookTxt.Name = "BookTxt";
            BookTxt.Size = new Size(154, 23);
            BookTxt.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label4.Location = new Point(2, 358);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 14;
            label4.Text = "Book Name";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Cornsilk;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-1, 390);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(736, 128);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // buttonRefre
            // 
            buttonRefre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            buttonRefre.Location = new Point(666, 360);
            buttonRefre.Name = "buttonRefre";
            buttonRefre.Size = new Size(65, 23);
            buttonRefre.TabIndex = 21;
            buttonRefre.Text = "Refresh";
            buttonRefre.UseVisualStyleBackColor = true;
            buttonRefre.Click += buttonRefre_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.Location = new Point(359, 360);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 20;
            label6.Text = "Filter By:";
            // 
            // FilterBox
            // 
            FilterBox.FlatStyle = FlatStyle.System;
            FilterBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            FilterBox.FormattingEnabled = true;
            FilterBox.IntegralHeight = false;
            FilterBox.Items.AddRange(new object[] { "Author Name", "Book Publication", "Genre" });
            FilterBox.Location = new Point(435, 358);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(91, 25);
            FilterBox.TabIndex = 19;
            // 
            // FiltTxt
            // 
            FiltTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            FiltTxt.Location = new Point(532, 360);
            FiltTxt.Multiline = true;
            FiltTxt.Name = "FiltTxt";
            FiltTxt.Size = new Size(128, 23);
            FiltTxt.TabIndex = 18;
            // 
            // buttonLoan
            // 
            buttonLoan.Location = new Point(507, 548);
            buttonLoan.Name = "buttonLoan";
            buttonLoan.Size = new Size(172, 23);
            buttonLoan.TabIndex = 22;
            buttonLoan.Text = "Sumbit ";
            buttonLoan.UseVisualStyleBackColor = true;
            buttonLoan.Click += buttonLoan_Click;
            // 
            // RetDate
            // 
            RetDate.Location = new Point(190, 546);
            RetDate.Name = "RetDate";
            RetDate.Size = new Size(196, 23);
            RetDate.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(103, 548);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 23;
            label3.Text = "Return Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label2.Location = new Point(2, 109);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // UserTxt
            // 
            UserTxt.Location = new Point(90, 109);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(154, 23);
            UserTxt.TabIndex = 10;
            // 
            // SearBTN
            // 
            SearBTN.Location = new Point(250, 109);
            SearBTN.Name = "SearBTN";
            SearBTN.Size = new Size(70, 23);
            SearBTN.TabIndex = 11;
            SearBTN.Text = "Search";
            SearBTN.UseVisualStyleBackColor = true;
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(743, 583);
            Controls.Add(RetDate);
            Controls.Add(label3);
            Controls.Add(buttonLoan);
            Controls.Add(buttonRefre);
            Controls.Add(label6);
            Controls.Add(FilterBox);
            Controls.Add(FiltTxt);
            Controls.Add(dataGridView2);
            Controls.Add(buttonSearch);
            Controls.Add(BookTxt);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(SearBTN);
            Controls.Add(UserTxt);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBooks";
            Text = "IssueBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label5;
        private PictureBox pictureBox4;
        private Button buttonSearch;
        private TextBox textBox1;
        private Label label4;
        private DataGridView dataGridView2;
        private TextBox BookTxt;
        private Button buttonRefre;
        private Label label6;
        private ComboBox FilterBox;
        private TextBox FiltTxt;
        private Button buttonLoan;
        private DateTimePicker RetDate;
        private Label label3;
        private Label label2;
        private TextBox UserTxt;
        private Button SearBTN;
    }
}