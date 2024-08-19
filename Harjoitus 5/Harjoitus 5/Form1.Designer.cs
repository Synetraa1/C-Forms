namespace Harjoitus_5
{
    partial class LukujenJarjestys
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
            LukuLB = new Label();
            uusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // LukuLB
            // 
            LukuLB.AutoSize = true;
            LukuLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LukuLB.Location = new Point(12, 9);
            LukuLB.Name = "LukuLB";
            LukuLB.Size = new Size(185, 21);
            LukuLB.TabIndex = 0;
            LukuLB.Text = "Anna luku (-999 lopetus):";
            // 
            // uusiLukuTB
            // 
            uusiLukuTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uusiLukuTB.Location = new Point(203, 7);
            uusiLukuTB.Name = "uusiLukuTB";
            uusiLukuTB.Size = new Size(142, 29);
            uusiLukuTB.TabIndex = 1;
            uusiLukuTB.KeyPress += uusiLukuTB_KeyPress;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(12, 51);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(63, 21);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 368);
            Controls.Add(VastausLB);
            Controls.Add(uusiLukuTB);
            Controls.Add(LukuLB);
            Name = "LukujenJarjestys";
            Text = "Lukujen Järjestys";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LukuLB;
        private TextBox uusiLukuTB;
        private Label VastausLB;
    }
}
