namespace Harjoitus_12
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
            KysymysLB = new Label();
            VastausGB = new GroupBox();
            VastausDRB = new RadioButton();
            VastausCRB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausARB = new RadioButton();
            ERB = new RadioButton();
            VastausLB = new Label();
            VastausGB.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KysymysLB.Location = new Point(12, 11);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(259, 21);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Klikkaa jotain kirjainta aloittaaksesi";
            // 
            // VastausGB
            // 
            VastausGB.Controls.Add(VastausDRB);
            VastausGB.Controls.Add(VastausCRB);
            VastausGB.Controls.Add(VastausBRB);
            VastausGB.Controls.Add(VastausARB);
            VastausGB.Controls.Add(ERB);
            VastausGB.Location = new Point(200, 35);
            VastausGB.Name = "VastausGB";
            VastausGB.Size = new Size(125, 183);
            VastausGB.TabIndex = 1;
            VastausGB.TabStop = false;
            VastausGB.Text = "vastaus";
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(6, 97);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(33, 19);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(6, 72);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(33, 19);
            VastausCRB.TabIndex = 3;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(6, 47);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(32, 19);
            VastausBRB.TabIndex = 2;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(6, 22);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(33, 19);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            // 
            // ERB
            // 
            ERB.AutoSize = true;
            ERB.Location = new Point(6, 22);
            ERB.Name = "ERB";
            ERB.Size = new Size(31, 19);
            ERB.TabIndex = 0;
            ERB.TabStop = true;
            ERB.Text = "E";
            ERB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(12, 197);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(63, 21);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 234);
            Controls.Add(VastausLB);
            Controls.Add(VastausGB);
            Controls.Add(KysymysLB);
            Name = "Form1";
            Text = "Vastauslomake";
            Load += Form1_Load;
            VastausGB.ResumeLayout(false);
            VastausGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private GroupBox VastausGB;
        private RadioButton VastausDRB;
        private RadioButton VastausCRB;
        private RadioButton VastausBRB;
        private RadioButton VastausARB;
        private RadioButton ERB;
        private Label VastausLB;
    }
}
