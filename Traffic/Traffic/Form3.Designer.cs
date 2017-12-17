namespace Traffic
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Green = new System.Windows.Forms.PictureBox();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Grntxt = new System.Windows.Forms.TextBox();
            this.Orngtxt = new System.Windows.Forms.TextBox();
            this.Redtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fan = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.cart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.Location = new System.Drawing.Point(169, 317);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(160, 170);
            this.Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green.TabIndex = 30;
            this.Green.TabStop = false;
            this.Green.Visible = false;
            // 
            // Orange
            // 
            this.Orange.Image = ((System.Drawing.Image)(resources.GetObject("Orange.Image")));
            this.Orange.Location = new System.Drawing.Point(169, 317);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(160, 170);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange.TabIndex = 29;
            this.Orange.TabStop = false;
            this.Orange.Visible = false;
            // 
            // Red
            // 
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.Location = new System.Drawing.Point(169, 317);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(160, 170);
            this.Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red.TabIndex = 28;
            this.Red.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Minerva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(865, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 152);
            this.button2.TabIndex = 32;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Minerva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(865, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 152);
            this.button1.TabIndex = 31;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Grntxt
            // 
            this.Grntxt.Location = new System.Drawing.Point(1143, 394);
            this.Grntxt.Name = "Grntxt";
            this.Grntxt.Size = new System.Drawing.Size(100, 20);
            this.Grntxt.TabIndex = 41;
            // 
            // Orngtxt
            // 
            this.Orngtxt.Location = new System.Drawing.Point(1144, 317);
            this.Orngtxt.Name = "Orngtxt";
            this.Orngtxt.Size = new System.Drawing.Size(100, 20);
            this.Orngtxt.TabIndex = 40;
            // 
            // Redtxt
            // 
            this.Redtxt.Location = new System.Drawing.Point(1144, 237);
            this.Redtxt.Name = "Redtxt";
            this.Redtxt.Size = new System.Drawing.Size(100, 20);
            this.Redtxt.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1040, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Green Light ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1030, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Orange Light ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1040, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Red Light ";
            // 
            // Fan
            // 
            this.Fan.Interval = 1000;
            this.Fan.Tick += new System.EventHandler(this.Fan_Tick_1);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(500, 600);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(86, 93);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 42;
            this.car.TabStop = false;
            // 
            // cart
            // 
            this.cart.Interval = 1;
            this.cart.Tick += new System.EventHandler(this.cart_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.car);
            this.Controls.Add(this.Grntxt);
            this.Controls.Add(this.Orngtxt);
            this.Controls.Add(this.Redtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Red);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Grntxt;
        private System.Windows.Forms.TextBox Orngtxt;
        private System.Windows.Forms.TextBox Redtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Fan;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer cart;
    }
}