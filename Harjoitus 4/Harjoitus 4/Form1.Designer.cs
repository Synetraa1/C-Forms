namespace Harjoitus_4
{
    partial class IkäLaskuri
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
            SyntynmaAikaDT = new DateTimePicker();
            LaskeBT = new Button();
            VuosinaLB = new Label();
            TunteinaLB = new Label();
            KuukausinaLB = new Label();
            MinuutteinaLB = new Label();
            PaivinaLB = new Label();
            SekunteinaLB = new Label();
            SuspendLayout();
            // 
            // SyntynmaAikaDT
            // 
            SyntynmaAikaDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SyntynmaAikaDT.Location = new Point(12, 12);
            SyntynmaAikaDT.Name = "SyntynmaAikaDT";
            SyntynmaAikaDT.Size = new Size(246, 29);
            SyntynmaAikaDT.TabIndex = 0;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(534, 161);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(86, 41);
            LaskeBT.TabIndex = 1;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VuosinaLB.Location = new Point(19, 90);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(56, 21);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuotta";
            VuosinaLB.Visible = false;
            VuosinaLB.Click += label1_Click;
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TunteinaLB.Location = new Point(206, 90);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(53, 21);
            TunteinaLB.TabIndex = 3;
            TunteinaLB.Text = "Tuntia";
            TunteinaLB.Visible = false;
            TunteinaLB.Click += label2_Click;
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KuukausinaLB.Location = new Point(19, 135);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(80, 21);
            KuukausinaLB.TabIndex = 4;
            KuukausinaLB.Text = "Kuukautta";
            KuukausinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinuutteinaLB.Location = new Point(206, 135);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(77, 21);
            MinuutteinaLB.TabIndex = 5;
            MinuutteinaLB.Text = "Minuuttia";
            MinuutteinaLB.Visible = false;
            MinuutteinaLB.Click += label4_Click;
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaivinaLB.Location = new Point(19, 181);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(54, 21);
            PaivinaLB.TabIndex = 6;
            PaivinaLB.Text = "Päivää";
            PaivinaLB.Visible = false;
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SekunteinaLB.Location = new Point(206, 181);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(75, 21);
            SekunteinaLB.TabIndex = 7;
            SekunteinaLB.Text = "Sekunttia";
            SekunteinaLB.Visible = false;
            // 
            // IkäLaskuri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 227);
            Controls.Add(SekunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(LaskeBT);
            Controls.Add(SyntynmaAikaDT);
            Name = "IkäLaskuri";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntynmaAikaDT;
        private Button LaskeBT;
        private Label VuosinaLB;
        private Label TunteinaLB;
        private Label KuukausinaLB;
        private Label MinuutteinaLB;
        private Label PaivinaLB;
        private Label SekunteinaLB;
    }
}
