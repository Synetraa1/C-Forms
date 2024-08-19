namespace Harjoitus_2
{
    partial class OtsikkoLB
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
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 33);
            label1.TabIndex = 0;
            label1.Text = "Anna tulostettava teksti:";
            label1.Click += label1_Click;
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Location = new Point(15, 59);
            TulostusLB.Margin = new Padding(6, 0, 6, 0);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(72, 33);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Location = new Point(302, 9);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(509, 41);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TulostaBT.ForeColor = Color.MintCream;
            TulostaBT.Location = new Point(683, 213);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(128, 32);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta Teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // OtsikkoLB
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(823, 257);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(label1);
            Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MintCream;
            Margin = new Padding(6, 7, 6, 7);
            Name = "OtsikkoLB";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}
