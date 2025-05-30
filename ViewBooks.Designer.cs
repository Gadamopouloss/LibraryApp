
namespace Library
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            SearchBtn = new Button();
            SearchTx = new TextBox();
            label3 = new Label();
            FiltTxt = new TextBox();
            FilterBox = new ComboBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            buttonRefre = new Button();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            RetDate = new DateTimePicker();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 89);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(841, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(781, 402);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 402);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(462, 36);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(342, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            SearchBtn.Location = new Point(798, 121);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 4;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTx
            // 
            SearchTx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            SearchTx.Location = new Point(734, 94);
            SearchTx.Multiline = true;
            SearchTx.Name = "SearchTx";
            SearchTx.Size = new Size(140, 21);
            SearchTx.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label3.Location = new Point(633, 94);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 1;
            label3.Text = "Book Name";
            // 
            // FiltTxt
            // 
            FiltTxt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            FiltTxt.Location = new Point(192, 92);
            FiltTxt.Multiline = true;
            FiltTxt.Name = "FiltTxt";
            FiltTxt.Size = new Size(128, 23);
            FiltTxt.TabIndex = 4;
            // 
            // FilterBox
            // 
            FilterBox.FlatStyle = FlatStyle.System;
            FilterBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            FilterBox.FormattingEnabled = true;
            FilterBox.IntegralHeight = false;
            FilterBox.Items.AddRange(new object[] { "Author Name", "Book Publication", "Genre" });
            FilterBox.Location = new Point(76, 92);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(110, 25);
            FilterBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Wheat;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(3, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(871, 236);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.Location = new Point(6, 94);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 9;
            label6.Text = "Filter By:";
            // 
            // buttonRefre
            // 
            buttonRefre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            buttonRefre.Location = new Point(245, 121);
            buttonRefre.Name = "buttonRefre";
            buttonRefre.Size = new Size(75, 23);
            buttonRefre.TabIndex = 10;
            buttonRefre.Text = "Refresh";
            buttonRefre.UseVisualStyleBackColor = true;
            buttonRefre.Click += buttonRefre_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Wheat;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Location = new Point(3, 465);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(870, 124);
            dataGridView2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(389, 421);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 6;
            label2.Text = "Ellipse";
            // 
            // RetDate
            // 
            RetDate.CalendarFont = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 161);
            RetDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 161);
            RetDate.Location = new Point(410, 92);
            RetDate.Name = "RetDate";
            RetDate.Size = new Size(217, 23);
            RetDate.TabIndex = 26;
            RetDate.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(323, 96);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 25;
            label4.Text = "Return Date";
            label4.Visible = false;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(890, 601);
            Controls.Add(RetDate);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(buttonRefre);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(FilterBox);
            Controls.Add(SearchBtn);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(SearchTx);
            Controls.Add(FiltTxt);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "ViewBooks";
            Text = "ViewBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Button SearchBtn;
        private PictureBox pictureBox2;
        private TextBox SearchTx;
        private Label label3;
        private TextBox FiltTxt;
        private ComboBox FilterBox;
        private DataGridView dataGridView1;
        private Label label6;
        private Button buttonRefre;
        private DataGridView dataGridView2;
        private Label label2;
        private DateTimePicker RetDate;
        private Label label4;
    }
}