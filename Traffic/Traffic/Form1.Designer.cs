namespace Traffic
{
    partial class Red
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Red));
            this.Red1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.Green = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Fan = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.PictureBox();
            this.cart = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Green2 = new System.Windows.Forms.PictureBox();
            this.Orange2 = new System.Windows.Forms.PictureBox();
            this.Red2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.cart2 = new System.Windows.Forms.Timer(this.components);
            this.Fan2 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            this.SuspendLayout();
            // 
            // Red1
            // 
            this.Red1.Image = ((System.Drawing.Image)(resources.GetObject("Red1.Image")));
            this.Red1.Location = new System.Drawing.Point(699, 453);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(160, 181);
            this.Red1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red1.TabIndex = 0;
            this.Red1.TabStop = false;
            this.Red1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Moonbeam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(865, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Nasalization", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 192);
            this.button2.TabIndex = 2;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(955, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red Light 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(945, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orange Light 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(955, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Green Light 1";
            // 
            // Orange
            // 
            this.Orange.Image = ((System.Drawing.Image)(resources.GetObject("Orange.Image")));
            this.Orange.Location = new System.Drawing.Point(699, 453);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(160, 181);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange.TabIndex = 9;
            this.Orange.TabStop = false;
            this.Orange.Visible = false;
            // 
            // Green
            // 
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.Location = new System.Drawing.Point(699, 453);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(160, 181);
            this.Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green.TabIndex = 10;
            this.Green.TabStop = false;
            this.Green.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1059, 538);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1059, 618);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1059, 695);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Fan
            // 
            this.Fan.Interval = 1000;
            this.Fan.Tick += new System.EventHandler(this.Fan_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Moonbeam", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1091, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(567, 606);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(99, 93);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 15;
            this.car.TabStop = false;
            // 
            // cart
            // 
            this.cart.Interval = 1;
            this.cart.Tick += new System.EventHandler(this.car_Tick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1292, 695);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1292, 618);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1292, 538);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1188, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Green Light 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1170, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Orange Light 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1188, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Red Light 2";
            // 
            // Green2
            // 
            this.Green2.Image = ((System.Drawing.Image)(resources.GetObject("Green2.Image")));
            this.Green2.Location = new System.Drawing.Point(345, 47);
            this.Green2.Name = "Green2";
            this.Green2.Size = new System.Drawing.Size(160, 181);
            this.Green2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green2.TabIndex = 24;
            this.Green2.TabStop = false;
            // 
            // Orange2
            // 
            this.Orange2.Image = ((System.Drawing.Image)(resources.GetObject("Orange2.Image")));
            this.Orange2.Location = new System.Drawing.Point(345, 47);
            this.Orange2.Name = "Orange2";
            this.Orange2.Size = new System.Drawing.Size(160, 181);
            this.Orange2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange2.TabIndex = 23;
            this.Orange2.TabStop = false;
            this.Orange2.Visible = false;
            // 
            // Red2
            // 
            this.Red2.Image = ((System.Drawing.Image)(resources.GetObject("Red2.Image")));
            this.Red2.Location = new System.Drawing.Point(345, 47);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(160, 181);
            this.Red2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red2.TabIndex = 22;
            this.Red2.TabStop = false;
            this.Red2.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Moonbeam", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(260, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 71);
            this.button4.TabIndex = 25;
            this.button4.Text = "Change";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // car2
            // 
            this.car2.Image = ((System.Drawing.Image)(resources.GetObject("car2.Image")));
            this.car2.Location = new System.Drawing.Point(57, 268);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(106, 98);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 26;
            this.car2.TabStop = false;
            // 
            // cart2
            // 
            this.cart2.Interval = 1;
            this.cart2.Tick += new System.EventHandler(this.cart2_Tick);
            // 
            // Fan2
            // 
            this.Fan2.Interval = 1000;
            this.Fan2.Tick += new System.EventHandler(this.Fan2_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Minion Pro SmBd", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1082, 742);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 80);
            this.button5.TabIndex = 27;
            this.button5.Text = "Manual";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Minion Pro SmBd", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(899, 752);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 52);
            this.button6.TabIndex = 28;
            this.button6.Text = "Level 1";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Minion Pro SmBd", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1310, 752);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 52);
            this.button7.TabIndex = 29;
            this.button7.Text = "Level 2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Red
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1450, 827);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Green2);
            this.Controls.Add(this.Orange2);
            this.Controls.Add(this.Red2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.car);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Red1);
            this.Name = "Red";
            this.Text = "Traffic";
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Red1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer Fan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer cart;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Green2;
        private System.Windows.Forms.PictureBox Orange2;
        private System.Windows.Forms.PictureBox Red2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.Timer cart2;
        private System.Windows.Forms.Timer Fan2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

