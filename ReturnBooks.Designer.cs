namespace Library
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            panel1 = new Panel();
            CanBt = new Button();
            BookTx = new TextBox();
            RetuBtn = new Button();
            BookBt = new Button();
            ReturnDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            UserBt = new Button();
            UserTx = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(CanBt);
            panel1.Controls.Add(BookTx);
            panel1.Controls.Add(RetuBtn);
            panel1.Controls.Add(BookBt);
            panel1.Controls.Add(ReturnDate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(UserBt);
            panel1.Controls.Add(UserTx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(12, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 299);
            panel1.TabIndex = 0;
            // 
            // CanBt
            // 
            CanBt.BackColor = Color.LightCoral;
            CanBt.Location = new Point(56, 252);
            CanBt.Name = "CanBt";
            CanBt.Size = new Size(90, 23);
            CanBt.TabIndex = 10;
            CanBt.Text = "Cancel";
            CanBt.UseVisualStyleBackColor = false;
            // 
            // BookTx
            // 
            BookTx.Location = new Point(302, 122);
            BookTx.Name = "BookTx";
            BookTx.Size = new Size(139, 23);
            BookTx.TabIndex = 8;
            // 
            // RetuBtn
            // 
            RetuBtn.Location = new Point(203, 252);
            RetuBtn.Name = "RetuBtn";
            RetuBtn.Size = new Size(86, 23);
            RetuBtn.TabIndex = 8;
            RetuBtn.Text = "Return";
            RetuBtn.UseVisualStyleBackColor = true;
            RetuBtn.Click += RetuBtn_Click;
            // 
            // BookBt
            // 
            BookBt.Location = new Point(302, 151);
            BookBt.Name = "BookBt";
            BookBt.Size = new Size(115, 23);
            BookBt.TabIndex = 7;
            BookBt.Text = "Search For Book";
            BookBt.UseVisualStyleBackColor = true;
            BookBt.Click += BookBt_Click;
            // 
            // ReturnDate
            // 
            ReturnDate.Location = new Point(129, 197);
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Size = new Size(220, 23);
            ReturnDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.Location = new Point(316, 102);
            label6.Name = "label6";
            label6.Size = new Size(119, 17);
            label6.TabIndex = 6;
            label6.Text = "Enter Book Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label7.Location = new Point(34, 197);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 7;
            label7.Text = "Return Date";
            // 
            // UserBt
            // 
            UserBt.Location = new Point(38, 151);
            UserBt.Name = "UserBt";
            UserBt.Size = new Size(115, 23);
            UserBt.TabIndex = 5;
            UserBt.Text = "Search For Student";
            UserBt.UseVisualStyleBackColor = true;
            UserBt.Click += button1_Click;
            // 
            // UserTx
            // 
            UserTx.Location = new Point(38, 122);
            UserTx.Name = "UserTx";
            UserTx.Size = new Size(139, 23);
            UserTx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.Location = new Point(38, 102);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 3;
            label2.Text = "Enter Username";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(163, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 41);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Return A Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1068, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(536, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(567, 278);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 356);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 21);
            label3.TabIndex = 12;
            label3.Text = "Should have been returned";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Lavender;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 380);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(581, 108);
            dataGridView2.TabIndex = 13;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Lavender;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(599, 380);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(542, 108);
            dataGridView3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(599, 343);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 15;
            label4.Text = "Returned";
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1153, 500);
            Controls.Add(label4);
            Controls.Add(dataGridView3);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReturnBooks";
            Text = "ReturnBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox UserTx;
        private Button UserBt;
        private Button CanBt;
        private TextBox BookTx;
        private Button RetuBtn;
        private Button BookBt;
        private DateTimePicker ReturnDate;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label4;
    }
}