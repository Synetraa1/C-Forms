namespace Harjoitus_1
{
    partial class Harjoitus1
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
            OtsikkoLB = new Label();
            VaihdaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Location = new Point(12, 24);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(58, 20);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Otsikko";
            // 
            // VaihdaBT
            // 
            VaihdaBT.Location = new Point(12, 47);
            VaihdaBT.Name = "VaihdaBT";
            VaihdaBT.Size = new Size(94, 60);
            VaihdaBT.TabIndex = 1;
            VaihdaBT.Text = "Vaihda Teksti";
            VaihdaBT.UseVisualStyleBackColor = true;
            VaihdaBT.Click += VaihdaBT_Click;
            // 
            // Harjoitus1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 522);
            Controls.Add(VaihdaBT);
            Controls.Add(OtsikkoLB);
            Name = "Harjoitus1";
            RightToLeftLayout = true;
            Text = "Harjoitus 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Button VaihdaBT;
    }
}
