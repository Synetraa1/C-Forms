namespace Harjoitus_10
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
            PainoLB = new Label();
            PituusLB = new Label();
            PainoindeksiBT = new Button();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            TulosLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // PainoLB
            // 
            PainoLB.AutoSize = true;
            PainoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PainoLB.Location = new Point(12, 9);
            PainoLB.Name = "PainoLB";
            PainoLB.Size = new Size(102, 17);
            PainoLB.TabIndex = 0;
            PainoLB.Text = "Anna Paino (kg):";
            // 
            // PituusLB
            // 
            PituusLB.AutoSize = true;
            PituusLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PituusLB.Location = new Point(12, 49);
            PituusLB.Name = "PituusLB";
            PituusLB.Size = new Size(107, 17);
            PituusLB.TabIndex = 1;
            PituusLB.Text = "Anna Pituus (cm):";
            // 
            // PainoindeksiBT
            // 
            PainoindeksiBT.Location = new Point(12, 81);
            PainoindeksiBT.Name = "PainoindeksiBT";
            PainoindeksiBT.Size = new Size(226, 23);
            PainoindeksiBT.TabIndex = 2;
            PainoindeksiBT.Text = "Laske Painoindeksi";
            PainoindeksiBT.UseVisualStyleBackColor = true;
            PainoindeksiBT.Click += PainoindeksiBT_Click;
            // 
            // PainoTB
            // 
            PainoTB.Location = new Point(138, 3);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(100, 23);
            PainoTB.TabIndex = 3;
            PainoTB.TextChanged += textBox1_TextChanged;
            // 
            // PituusTB
            // 
            PituusTB.Location = new Point(138, 43);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(100, 23);
            PituusTB.TabIndex = 4;
            // 
            // TulosLB
            // 
            TulosLB.AutoSize = true;
            TulosLB.Location = new Point(12, 121);
            TulosLB.Name = "TulosLB";
            TulosLB.Size = new Size(31, 15);
            TulosLB.TabIndex = 5;
            TulosLB.Text = "xxxx";
            TulosLB.TextAlign = ContentAlignment.TopCenter;
            TulosLB.Visible = false;
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Location = new Point(12, 148);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(31, 15);
            KuvausLB.TabIndex = 6;
            KuvausLB.Text = "xxxx";
            KuvausLB.TextAlign = ContentAlignment.TopCenter;
            KuvausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 183);
            Controls.Add(KuvausLB);
            Controls.Add(TulosLB);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(PainoindeksiBT);
            Controls.Add(PituusLB);
            Controls.Add(PainoLB);
            Name = "Form1";
            Text = "BMI-laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PainoLB;
        private Label PituusLB;
        private Button PainoindeksiBT;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Label TulosLB;
        private Label KuvausLB;
    }
}
