namespace Miniräknare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.about = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.province = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_digit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empty = new System.Windows.Forms.Button();
            this.man = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(260, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(58, 28);
            this.about.TabIndex = 1;
            this.about.UseVisualStyleBackColor = true;
            this.about.MouseClick += new System.Windows.Forms.MouseEventHandler(this.about_MouseClick);
            // 
            // year
            // 
            this.year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.year.Location = new System.Drawing.Point(29, 53);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(20, 20);
            this.year.TabIndex = 2;
            // 
            // month
            // 
            this.month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month.Location = new System.Drawing.Point(55, 53);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(20, 20);
            this.month.TabIndex = 3;
            // 
            // day
            // 
            this.day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.day.Location = new System.Drawing.Point(81, 53);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(20, 20);
            this.day.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "YY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "MM";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.BackColor = System.Drawing.Color.Transparent;
            this.day_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_label.ForeColor = System.Drawing.Color.White;
            this.day_label.Location = new System.Drawing.Point(78, 34);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(26, 17);
            this.day_label.TabIndex = 7;
            this.day_label.Text = "DD";
            this.day_label.Click += new System.EventHandler(this.day_label_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(29, 215);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(60, 30);
            this.generate.TabIndex = 8;
            this.generate.Text = "Generera";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // province
            // 
            this.province.Cursor = System.Windows.Forms.Cursors.Hand;
            this.province.Location = new System.Drawing.Point(122, 53);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(20, 20);
            this.province.TabIndex = 9;
            this.province.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Län";
            // 
            // check_digit
            // 
            this.check_digit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_digit.Location = new System.Drawing.Point(174, 53);
            this.check_digit.Name = "check_digit";
            this.check_digit.ReadOnly = true;
            this.check_digit.Size = new System.Drawing.Size(20, 20);
            this.check_digit.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(171, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kontrollsiffra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kön";
            // 
            // empty
            // 
            this.empty.Location = new System.Drawing.Point(95, 215);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(60, 30);
            this.empty.TabIndex = 15;
            this.empty.Text = "Töm";
            this.empty.UseVisualStyleBackColor = true;
            this.empty.Click += new System.EventHandler(this.empty_Click);
            this.empty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.empty_MouseClick);
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.BackColor = System.Drawing.Color.Transparent;
            this.man.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.man.ForeColor = System.Drawing.Color.Transparent;
            this.man.Location = new System.Drawing.Point(32, 103);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(52, 21);
            this.man.TabIndex = 16;
            this.man.TabStop = true;
            this.man.Text = "Man";
            this.man.UseVisualStyleBackColor = false;
            this.man.CheckedChanged += new System.EventHandler(this.man_CheckedChanged);
            this.man.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(87, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 21);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kvinna";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.Transparent;
            this.label_gender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(145, 34);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(30, 17);
            this.label_gender.TabIndex = 18;
            this.label_gender.Text = "Kön";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(148, 53);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(20, 20);
            this.gender.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "-";
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(317, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 28);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::generera_personnummer.Properties.Resources.bakgrund_violett_1;
            this.ClientSize = new System.Drawing.Size(371, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.man);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check_digit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.province);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.day_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.about);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnummer";
            this.Click += new System.EventHandler(this.s);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox check_digit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button empty;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label6;
    }
}

