namespace Traffic
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Green = new System.Windows.Forms.PictureBox();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.Red = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grntxt = new System.Windows.Forms.TextBox();
            this.Orngtxt = new System.Windows.Forms.TextBox();
            this.Redtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.Location = new System.Drawing.Point(164, 150);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(375, 407);
            this.Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Green.TabIndex = 27;
            this.Green.TabStop = false;
            this.Green.Visible = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Orange
            // 
            this.Orange.Image = ((System.Drawing.Image)(resources.GetObject("Orange.Image")));
            this.Orange.Location = new System.Drawing.Point(164, 150);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(375, 407);
            this.Orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Orange.TabIndex = 26;
            this.Orange.TabStop = false;
            this.Orange.Visible = false;
            // 
            // Red
            // 
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.Location = new System.Drawing.Point(164, 150);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(375, 407);
            this.Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red.TabIndex = 25;
            this.Red.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Minerva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(647, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 152);
            this.button1.TabIndex = 28;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Minerva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(647, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 152);
            this.button2.TabIndex = 29;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grntxt
            // 
            this.Grntxt.Location = new System.Drawing.Point(1126, 438);
            this.Grntxt.Name = "Grntxt";
            this.Grntxt.Size = new System.Drawing.Size(100, 20);
            this.Grntxt.TabIndex = 35;
            // 
            // Orngtxt
            // 
            this.Orngtxt.Location = new System.Drawing.Point(1127, 361);
            this.Orngtxt.Name = "Orngtxt";
            this.Orngtxt.Size = new System.Drawing.Size(100, 20);
            this.Orngtxt.TabIndex = 34;
            // 
            // Redtxt
            // 
            this.Redtxt.Location = new System.Drawing.Point(1127, 281);
            this.Redtxt.Name = "Redtxt";
            this.Redtxt.Size = new System.Drawing.Size(100, 20);
            this.Redtxt.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1023, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Green Light ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1013, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Orange Light ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1023, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Red Light ";
            // 
            // Fan
            // 
            this.Fan.Interval = 1000;
            this.Fan.Tick += new System.EventHandler(this.Fan_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1479, 718);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Green;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Grntxt;
        private System.Windows.Forms.TextBox Orngtxt;
        private System.Windows.Forms.TextBox Redtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Fan;
    }
}