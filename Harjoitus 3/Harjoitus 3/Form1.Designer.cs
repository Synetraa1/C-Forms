namespace Harjoitus_3
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
            LukuYksiTB = new TextBox();
            LukuKaksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            Merkki1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            SuspendLayout();
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LukuYksiTB.Location = new Point(35, 75);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(92, 35);
            LukuYksiTB.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LukuKaksiTB.Location = new Point(233, 75);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(92, 35);
            LukuKaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(155, 75);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(46, 38);
            LaskutoimitusCB.TabIndex = 2;
            // 
            // Merkki1
            // 
            Merkki1.AutoSize = true;
            Merkki1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Merkki1.Location = new Point(344, 75);
            Merkki1.Name = "Merkki1";
            Merkki1.Size = new Size(27, 30);
            Merkki1.TabIndex = 3;
            Merkki1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(380, 75);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(28, 32);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "X";
            VastausLB.Visible = false;
            VastausLB.Click += VastausLB_Click;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaskeBT.Location = new Point(472, 134);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(75, 37);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 181);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(Merkki1);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LukuYksiTB);
            Name = "Form1";
            Text = "Yksinkertainen Nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuYksiTB;
        private TextBox LukuKaksiTB;
        private ComboBox LaskutoimitusCB;
        private Label Merkki1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}
