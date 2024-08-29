namespace Harjoitus_13
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
            label1 = new Label();
            VastausLB = new Label();
            NimiTB = new TextBox();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 20);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkistan onko nimesi 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(12, 53);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(38, 21);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "xxxx";
            VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(463, 6);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(312, 23);
            NimiTB.TabIndex = 2;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TarkastaBT.Location = new Point(665, 54);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(110, 23);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkista";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 88);
            Controls.Add(TarkastaBT);
            Controls.Add(NimiTB);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Onko nimesi suosittujen joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox NimiTB;
        private Button TarkastaBT;
    }
}
