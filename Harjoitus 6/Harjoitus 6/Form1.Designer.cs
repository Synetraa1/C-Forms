namespace Harjoitus_6
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            VirheviestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            SalasanaLB = new Label();
            KayttajaLB = new Label();
            SalasanaOikeinPanel = new Panel();
            label1 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(SalasanaLB);
            SalasanaPanel.Controls.Add(KayttajaLB);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(669, 245);
            SalasanaPanel.TabIndex = 0;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.ForeColor = Color.Red;
            VirheviestiLB.Location = new Point(202, 97);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(70, 32);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(455, 193);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(124, 40);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Kirjaudu";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(202, 55);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(377, 39);
            SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(202, 6);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(377, 39);
            KayttajaTB.TabIndex = 2;
            // 
            // SalasanaLB
            // 
            SalasanaLB.AutoSize = true;
            SalasanaLB.Location = new Point(79, 55);
            SalasanaLB.Name = "SalasanaLB";
            SalasanaLB.Size = new Size(117, 32);
            SalasanaLB.TabIndex = 1;
            SalasanaLB.Text = "Salasana: ";
            // 
            // KayttajaLB
            // 
            KayttajaLB.AutoSize = true;
            KayttajaLB.Location = new Point(12, 9);
            KayttajaLB.Name = "KayttajaLB";
            KayttajaLB.Size = new Size(184, 32);
            KayttajaLB.TabIndex = 0;
            KayttajaLB.Text = "Käyttäjätunnus: ";
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.Maroon;
            SalasanaOikeinPanel.Controls.Add(label1);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(669, 245);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 81);
            label1.Name = "label1";
            label1.Size = new Size(500, 64);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa Sivuilleni! ";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 245);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Name = "SalasanaForm";
            Text = "Salasanan Tarkistus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label SalasanaLB;
        private Label KayttajaLB;
        private Label VirheviestiLB;
        private Button TarkistaBT;
        private Panel SalasanaOikeinPanel;
        private Label label1;
    }
}
