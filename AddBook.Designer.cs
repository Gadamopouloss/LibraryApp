namespace Library
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            GenBox = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker = new DateTimePicker();
            pricetxt = new TextBox();
            quantxt = new TextBox();
            publtxt = new TextBox();
            autortxt = new TextBox();
            nametxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 89);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(739, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Wheat;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            textBox1.Location = new Point(417, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 3;
            textBox1.Text = "ADD A BOOK";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(311, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(338, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(GenBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dateTimePicker);
            panel3.Controls.Add(pricetxt);
            panel3.Controls.Add(quantxt);
            panel3.Controls.Add(publtxt);
            panel3.Controls.Add(autortxt);
            panel3.Controls.Add(nametxt);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(348, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 449);
            panel3.TabIndex = 2;
            // 
            // GenBox
            // 
            GenBox.FormattingEnabled = true;
            GenBox.Items.AddRange(new object[] { "Fiction", "Mystery", "Romance", "Science Fiction", "Fantasy", "Thriller", "Biography", "Self-Help", "History", "Young Adult" });
            GenBox.Location = new Point(191, 332);
            GenBox.Name = "GenBox";
            GenBox.Size = new Size(186, 23);
            GenBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(22, 332);
            label7.Name = "label7";
            label7.Size = new Size(85, 17);
            label7.TabIndex = 14;
            label7.Text = "Book Genres";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(273, 376);
            button2.Name = "button2";
            button2.Size = new Size(79, 24);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(166, 376);
            button1.Name = "button1";
            button1.Size = new Size(79, 24);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(191, 189);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(186, 23);
            dateTimePicker.TabIndex = 11;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(191, 290);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(186, 23);
            pricetxt.TabIndex = 10;
            // 
            // quantxt
            // 
            quantxt.Location = new Point(191, 239);
            quantxt.Name = "quantxt";
            quantxt.Size = new Size(186, 23);
            quantxt.TabIndex = 9;
            // 
            // publtxt
            // 
            publtxt.Location = new Point(191, 138);
            publtxt.Name = "publtxt";
            publtxt.Size = new Size(186, 23);
            publtxt.TabIndex = 8;
            // 
            // autortxt
            // 
            autortxt.Location = new Point(191, 94);
            autortxt.Name = "autortxt";
            autortxt.Size = new Size(186, 23);
            autortxt.TabIndex = 7;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(191, 52);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(186, 23);
            nametxt.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(22, 290);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 5;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(22, 247);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 4;
            label5.Text = "Book Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(22, 193);
            label4.Name = "label4";
            label4.Size = new Size(130, 17);
            label4.TabIndex = 3;
            label4.Text = "Book Purchace Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(22, 146);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 2;
            label3.Text = "Book Publication";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(22, 97);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 1;
            label2.Text = "Book Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            label1.Click += label1_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 526);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBook";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker;
        private TextBox pricetxt;
        private TextBox quantxt;
        private TextBox publtxt;
        private TextBox autortxt;
        private TextBox nametxt;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox3;
        private Label label7;
        private ComboBox GenBox;
    }
}