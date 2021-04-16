
namespace Kelime_Oyunu
{
    partial class Oyun_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyun_Ekrani));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.harf10 = new System.Windows.Forms.Button();
            this.harf9 = new System.Windows.Forms.Button();
            this.harf8 = new System.Windows.Forms.Button();
            this.harf7 = new System.Windows.Forms.Button();
            this.harf6 = new System.Windows.Forms.Button();
            this.harf5 = new System.Windows.Forms.Button();
            this.harf4 = new System.Windows.Forms.Button();
            this.harf3 = new System.Windows.Forms.Button();
            this.harf2 = new System.Windows.Forms.Button();
            this.harf1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(643, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tahminde Bulun";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(11, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Harf İste";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 26);
            this.progressBar1.MarqueeAnimationSpeed = 240;
            this.progressBar1.Maximum = 240;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 31);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 240;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "240";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(693, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "20";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(536, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 34);
            this.textBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(636, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Onayla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(342, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "SORU";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 462);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Bisque;
            this.textBox2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(147, 110);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(486, 27);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(597, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "SKOR = ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.harf10);
            this.groupBox2.Controls.Add(this.harf9);
            this.groupBox2.Controls.Add(this.harf8);
            this.groupBox2.Controls.Add(this.harf7);
            this.groupBox2.Controls.Add(this.harf6);
            this.groupBox2.Controls.Add(this.harf5);
            this.groupBox2.Controls.Add(this.harf4);
            this.groupBox2.Controls.Add(this.harf3);
            this.groupBox2.Controls.Add(this.harf2);
            this.groupBox2.Controls.Add(this.harf1);
            this.groupBox2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(145, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 91);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HARFLER";
            // 
            // harf10
            // 
            this.harf10.BackColor = System.Drawing.SystemColors.Window;
            this.harf10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf10.Location = new System.Drawing.Point(436, 31);
            this.harf10.Name = "harf10";
            this.harf10.Size = new System.Drawing.Size(42, 41);
            this.harf10.TabIndex = 9;
            this.harf10.Text = "_";
            this.harf10.UseVisualStyleBackColor = false;
            // 
            // harf9
            // 
            this.harf9.BackColor = System.Drawing.SystemColors.Window;
            this.harf9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf9.Location = new System.Drawing.Point(390, 31);
            this.harf9.Name = "harf9";
            this.harf9.Size = new System.Drawing.Size(42, 41);
            this.harf9.TabIndex = 8;
            this.harf9.Text = "_";
            this.harf9.UseVisualStyleBackColor = false;
            // 
            // harf8
            // 
            this.harf8.BackColor = System.Drawing.SystemColors.Window;
            this.harf8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf8.Location = new System.Drawing.Point(342, 31);
            this.harf8.Name = "harf8";
            this.harf8.Size = new System.Drawing.Size(42, 41);
            this.harf8.TabIndex = 7;
            this.harf8.Text = "_";
            this.harf8.UseVisualStyleBackColor = false;
            // 
            // harf7
            // 
            this.harf7.BackColor = System.Drawing.SystemColors.Window;
            this.harf7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf7.Location = new System.Drawing.Point(294, 31);
            this.harf7.Name = "harf7";
            this.harf7.Size = new System.Drawing.Size(42, 41);
            this.harf7.TabIndex = 6;
            this.harf7.Text = "_";
            this.harf7.UseVisualStyleBackColor = false;
            // 
            // harf6
            // 
            this.harf6.BackColor = System.Drawing.SystemColors.Window;
            this.harf6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf6.Location = new System.Drawing.Point(246, 31);
            this.harf6.Name = "harf6";
            this.harf6.Size = new System.Drawing.Size(42, 41);
            this.harf6.TabIndex = 5;
            this.harf6.Text = "_";
            this.harf6.UseVisualStyleBackColor = false;
            // 
            // harf5
            // 
            this.harf5.BackColor = System.Drawing.SystemColors.Window;
            this.harf5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf5.Location = new System.Drawing.Point(198, 31);
            this.harf5.Name = "harf5";
            this.harf5.Size = new System.Drawing.Size(42, 41);
            this.harf5.TabIndex = 4;
            this.harf5.Text = "_";
            this.harf5.UseVisualStyleBackColor = false;
            // 
            // harf4
            // 
            this.harf4.BackColor = System.Drawing.SystemColors.Window;
            this.harf4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf4.Location = new System.Drawing.Point(150, 31);
            this.harf4.Name = "harf4";
            this.harf4.Size = new System.Drawing.Size(42, 41);
            this.harf4.TabIndex = 3;
            this.harf4.Text = "_";
            this.harf4.UseVisualStyleBackColor = false;
            // 
            // harf3
            // 
            this.harf3.BackColor = System.Drawing.SystemColors.Window;
            this.harf3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf3.Location = new System.Drawing.Point(102, 31);
            this.harf3.Name = "harf3";
            this.harf3.Size = new System.Drawing.Size(42, 41);
            this.harf3.TabIndex = 2;
            this.harf3.Text = "_";
            this.harf3.UseVisualStyleBackColor = false;
            // 
            // harf2
            // 
            this.harf2.BackColor = System.Drawing.SystemColors.Window;
            this.harf2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf2.Location = new System.Drawing.Point(54, 31);
            this.harf2.Name = "harf2";
            this.harf2.Size = new System.Drawing.Size(42, 41);
            this.harf2.TabIndex = 1;
            this.harf2.Text = "_";
            this.harf2.UseVisualStyleBackColor = false;
            // 
            // harf1
            // 
            this.harf1.BackColor = System.Drawing.SystemColors.Window;
            this.harf1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.harf1.Location = new System.Drawing.Point(6, 31);
            this.harf1.Name = "harf1";
            this.harf1.Size = new System.Drawing.Size(42, 41);
            this.harf1.TabIndex = 0;
            this.harf1.Text = "_";
            this.harf1.UseVisualStyleBackColor = false;
            // 
            // Oyun_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 434);
            this.Controls.Add(this.groupBox1);
            this.Name = "Oyun_Ekrani";
            this.Text = "Oyun_Ekrani";
            this.Load += new System.EventHandler(this.Oyun_Ekrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button harf10;
        private System.Windows.Forms.Button harf9;
        private System.Windows.Forms.Button harf8;
        private System.Windows.Forms.Button harf7;
        private System.Windows.Forms.Button harf6;
        private System.Windows.Forms.Button harf5;
        private System.Windows.Forms.Button harf4;
        private System.Windows.Forms.Button harf3;
        private System.Windows.Forms.Button harf2;
        private System.Windows.Forms.Button harf1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}