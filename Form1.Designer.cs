namespace Library
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            LgnBtn = new Button();
            SgnBtn = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ExtBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.Black;
            TxtUsername.BorderStyle = BorderStyle.FixedSingle;
            TxtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            TxtUsername.ForeColor = Color.White;
            TxtUsername.Location = new Point(140, 178);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(211, 27);
            TxtUsername.TabIndex = 1;
            TxtUsername.Text = "Username";
            TxtUsername.MouseClick += TxtUsername_MouseClick;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = SystemColors.WindowText;
            TxtPassword.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 161);
            TxtPassword.ForeColor = Color.White;
            TxtPassword.Location = new Point(140, 234);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(211, 27);
            TxtPassword.TabIndex = 2;
            TxtPassword.Text = "Password";
            TxtPassword.MouseClick += TxtPassword_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // LgnBtn
            // 
            LgnBtn.AutoEllipsis = true;
            LgnBtn.BackColor = Color.Cyan;
            LgnBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LgnBtn.Cursor = Cursors.Hand;
            LgnBtn.FlatStyle = FlatStyle.Popup;
            LgnBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            LgnBtn.Location = new Point(57, 295);
            LgnBtn.Margin = new Padding(0);
            LgnBtn.Name = "LgnBtn";
            LgnBtn.Size = new Size(139, 38);
            LgnBtn.TabIndex = 11;
            LgnBtn.Text = "Login";
            LgnBtn.UseVisualStyleBackColor = false;
            LgnBtn.Click += LgnBtn_Click;
            // 
            // SgnBtn
            // 
            SgnBtn.BackColor = Color.Black;
            SgnBtn.Cursor = Cursors.Hand;
            SgnBtn.FlatStyle = FlatStyle.Popup;
            SgnBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            SgnBtn.ForeColor = Color.Cyan;
            SgnBtn.Location = new Point(226, 295);
            SgnBtn.Name = "SgnBtn";
            SgnBtn.Size = new Size(139, 38);
            SgnBtn.TabIndex = 6;
            SgnBtn.Text = "Sign Up";
            SgnBtn.UseVisualStyleBackColor = false;
            SgnBtn.Click += SgnBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(106, 372);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(192, 372);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(278, 372);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // ExtBtn
            // 
            ExtBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            ExtBtn.Location = new Point(402, 12);
            ExtBtn.Name = "ExtBtn";
            ExtBtn.Size = new Size(27, 23);
            ExtBtn.TabIndex = 10;
            ExtBtn.Text = "X";
            ExtBtn.UseVisualStyleBackColor = true;
            ExtBtn.Click += ExtBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(441, 450);
            Controls.Add(ExtBtn);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(SgnBtn);
            Controls.Add(LgnBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button LgnBtn;
        private Button SgnBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button ExtBtn;
    }
}
