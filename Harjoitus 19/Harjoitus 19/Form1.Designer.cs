namespace Harjoitus_19
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
            ylaPL = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            meistaPL = new Panel();
            meistaLB = new Label();
            ruuatPL = new Panel();
            juomatPL = new Panel();
            herkutPL = new Panel();
            koriPL = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            vasenPL = new Panel();
            panel5 = new Panel();
            button5 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            suolaisetLB = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ylaPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            meistaPL.SuspendLayout();
            ruuatPL.SuspendLayout();
            juomatPL.SuspendLayout();
            herkutPL.SuspendLayout();
            koriPL.SuspendLayout();
            vasenPL.SuspendLayout();
            SuspendLayout();
            // 
            // ylaPL
            // 
            ylaPL.BackColor = Color.FromArgb(255, 153, 2);
            ylaPL.Controls.Add(pictureBox1);
            ylaPL.Controls.Add(label1);
            ylaPL.Dock = DockStyle.Top;
            ylaPL.Location = new Point(135, 0);
            ylaPL.Name = "ylaPL";
            ylaPL.Size = new Size(565, 40);
            ylaPL.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cook_hat;
            pictureBox1.Location = new Point(518, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(455, 41);
            label1.TabIndex = 0;
            label1.Text = "Keudan oppilaskunnan kahvila";
            // 
            // meistaPL
            // 
            meistaPL.Controls.Add(meistaLB);
            meistaPL.Dock = DockStyle.Fill;
            meistaPL.Location = new Point(135, 40);
            meistaPL.Name = "meistaPL";
            meistaPL.Size = new Size(565, 260);
            meistaPL.TabIndex = 2;
            // 
            // meistaLB
            // 
            meistaLB.AutoSize = true;
            meistaLB.Location = new Point(3, 9);
            meistaLB.Name = "meistaLB";
            meistaLB.Size = new Size(63, 25);
            meistaLB.TabIndex = 0;
            meistaLB.Text = "label2";
            // 
            // ruuatPL
            // 
            ruuatPL.Controls.Add(label4);
            ruuatPL.Controls.Add(label3);
            ruuatPL.Controls.Add(label2);
            ruuatPL.Controls.Add(suolaisetLB);
            ruuatPL.Dock = DockStyle.Fill;
            ruuatPL.Location = new Point(135, 40);
            ruuatPL.Name = "ruuatPL";
            ruuatPL.Size = new Size(565, 260);
            ruuatPL.TabIndex = 3;
            // 
            // juomatPL
            // 
            juomatPL.Controls.Add(label8);
            juomatPL.Controls.Add(label7);
            juomatPL.Controls.Add(label6);
            juomatPL.Controls.Add(label5);
            juomatPL.Dock = DockStyle.Fill;
            juomatPL.Location = new Point(135, 40);
            juomatPL.Name = "juomatPL";
            juomatPL.Size = new Size(565, 260);
            juomatPL.TabIndex = 4;
            // 
            // herkutPL
            // 
            herkutPL.Controls.Add(label10);
            herkutPL.Controls.Add(label9);
            herkutPL.Dock = DockStyle.Fill;
            herkutPL.Location = new Point(135, 40);
            herkutPL.Name = "herkutPL";
            herkutPL.Size = new Size(565, 260);
            herkutPL.TabIndex = 5;
            // 
            // koriPL
            // 
            koriPL.Controls.Add(label11);
            koriPL.Dock = DockStyle.Fill;
            koriPL.Location = new Point(135, 40);
            koriPL.Name = "koriPL";
            koriPL.Size = new Size(565, 260);
            koriPL.TabIndex = 6;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.info;
            button1.Location = new Point(0, 40);
            button1.Name = "button1";
            button1.Size = new Size(135, 42);
            button1.TabIndex = 0;
            button1.Text = "Meistä";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 218, 45);
            panel1.Location = new Point(3, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 40);
            panel1.TabIndex = 0;
            // 
            // vasenPL
            // 
            vasenPL.BackColor = Color.FromArgb(62, 172, 64);
            vasenPL.Controls.Add(panel5);
            vasenPL.Controls.Add(button5);
            vasenPL.Controls.Add(panel4);
            vasenPL.Controls.Add(button4);
            vasenPL.Controls.Add(panel3);
            vasenPL.Controls.Add(button3);
            vasenPL.Controls.Add(panel2);
            vasenPL.Controls.Add(button2);
            vasenPL.Controls.Add(panel1);
            vasenPL.Controls.Add(button1);
            vasenPL.Dock = DockStyle.Left;
            vasenPL.Location = new Point(0, 0);
            vasenPL.Name = "vasenPL";
            vasenPL.Size = new Size(135, 300);
            vasenPL.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(105, 218, 45);
            panel5.Location = new Point(3, 232);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 40);
            panel5.TabIndex = 7;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(6, 230);
            button5.Name = "button5";
            button5.Size = new Size(135, 42);
            button5.TabIndex = 8;
            button5.Text = "Kori";
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(105, 218, 45);
            panel4.Location = new Point(3, 184);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 40);
            panel4.TabIndex = 5;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 183);
            button4.Name = "button4";
            button4.Size = new Size(135, 42);
            button4.TabIndex = 6;
            button4.Text = "Herkut";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(105, 218, 45);
            panel3.Location = new Point(3, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 40);
            panel3.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 135);
            button3.Name = "button3";
            button3.Size = new Size(135, 42);
            button3.TabIndex = 4;
            button3.Text = "Juomat";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(105, 218, 45);
            panel2.Location = new Point(3, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 40);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 88);
            button2.Name = "button2";
            button2.Size = new Size(135, 42);
            button2.TabIndex = 2;
            button2.Text = "Ruuat";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // suolaisetLB
            // 
            suolaisetLB.AutoSize = true;
            suolaisetLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suolaisetLB.Location = new Point(6, 17);
            suolaisetLB.Name = "suolaisetLB";
            suolaisetLB.Size = new Size(92, 25);
            suolaisetLB.TabIndex = 0;
            suolaisetLB.Text = "Suolaiset";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(276, 16);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Makeat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(181, 84);
            label3.TabIndex = 2;
            label3.Text = "- juustosämpylä     3,00€\r\n- kinkkusämpylä    3,00€\r\n- croissant               2,00€\r\n- karjalanpiirakka   2,00€";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(276, 52);
            label4.Name = "label4";
            label4.Size = new Size(218, 84);
            label4.TabIndex = 3;
            label4.Text = "- voisilmäpulla                3,00€\r\n- munkkipossu                3,00€\r\n- porkkanakakkupala      4,00€\r\n- mustikkapiirakkapala   2,00€";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 23);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 0;
            label5.Text = "Lämpimät juomat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(326, 23);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 1;
            label6.Text = "Kylmät juomat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 52);
            label7.Name = "label7";
            label7.Size = new Size(95, 63);
            label7.TabIndex = 2;
            label7.Text = "- kahvi     1€\r\n- tee         1€\r\n- kaakao  2€";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(326, 60);
            label8.Name = "label8";
            label8.Size = new Size(117, 63);
            label8.TabIndex = 3;
            label8.Text = "- limu      1€\r\n- jäätee    3€\r\n- vesilasi  0,50€";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 17);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 0;
            label9.Text = "Herkut";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 48);
            label10.Name = "label10";
            label10.Size = new Size(145, 84);
            label10.TabIndex = 1;
            label10.Text = "- jäätelötutti        3€\r\n- jäätelöpuikko   2€\r\n- karkkipussi       2€\r\n- tikkari                1€";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(66, 45);
            label11.Name = "label11";
            label11.Size = new Size(297, 25);
            label11.TabIndex = 0;
            label11.Text = "Verkkokauppa avautuu pian (WiP)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(700, 300);
            Controls.Add(meistaPL);
            Controls.Add(koriPL);
            Controls.Add(herkutPL);
            Controls.Add(juomatPL);
            Controls.Add(ruuatPL);
            Controls.Add(ylaPL);
            Controls.Add(vasenPL);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "ruokalistaForm";
            Load += Form1_Load;
            ylaPL.ResumeLayout(false);
            ylaPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            meistaPL.ResumeLayout(false);
            meistaPL.PerformLayout();
            ruuatPL.ResumeLayout(false);
            ruuatPL.PerformLayout();
            juomatPL.ResumeLayout(false);
            juomatPL.PerformLayout();
            herkutPL.ResumeLayout(false);
            herkutPL.PerformLayout();
            koriPL.ResumeLayout(false);
            koriPL.PerformLayout();
            vasenPL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel ylaPL;
        private Panel meistaPL;
        private Panel ruuatPL;
        private Panel juomatPL;
        private Panel herkutPL;
        private Panel koriPL;
        private Button button1;
        private Panel panel1;
        private Panel vasenPL;
        private Panel panel5;
        private Button button5;
        private Panel panel4;
        private Button button4;
        private Panel panel3;
        private Button button3;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label meistaLB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label suolaisetLB;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}
