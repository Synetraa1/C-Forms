namespace Harjoitus_7
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
            LainaLB = new Label();
            NesteetLB = new Label();
            VakuutusLB = new Label();
            MuutLB = new Label();
            PolttoaineLB = new Label();
            PesutLB = new Label();
            HuollotLB = new Label();
            RenkaatLB = new Label();
            KilometritLB = new Label();
            VastausLB = new Label();
            LainaTB = new TextBox();
            NesteetTB = new TextBox();
            VakuutusTB = new TextBox();
            MuutTB = new TextBox();
            PolttoaineTB = new TextBox();
            PesutTB = new TextBox();
            HuoltoTB = new TextBox();
            RenkaatTB = new TextBox();
            KilometritCB = new ComboBox();
            SuspendLayout();
            // 
            // LainaLB
            // 
            LainaLB.AutoSize = true;
            LainaLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LainaLB.Location = new Point(12, 37);
            LainaLB.Name = "LainaLB";
            LainaLB.Size = new Size(211, 21);
            LainaLB.TabIndex = 0;
            LainaLB.Text = "Lainan lyhennys korkoineen: ";
            // 
            // NesteetLB
            // 
            NesteetLB.AutoSize = true;
            NesteetLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NesteetLB.Location = new Point(12, 108);
            NesteetLB.Name = "NesteetLB";
            NesteetLB.Size = new Size(166, 21);
            NesteetLB.TabIndex = 1;
            NesteetLB.Text = "Lisättävät nesteet yms:";
            // 
            // VakuutusLB
            // 
            VakuutusLB.AutoSize = true;
            VakuutusLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VakuutusLB.Location = new Point(12, 178);
            VakuutusLB.Name = "VakuutusLB";
            VakuutusLB.Size = new Size(133, 21);
            VakuutusLB.TabIndex = 2;
            VakuutusLB.Text = "Vakuutusmaksut: ";
            // 
            // MuutLB
            // 
            MuutLB.AutoSize = true;
            MuutLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MuutLB.Location = new Point(12, 245);
            MuutLB.Name = "MuutLB";
            MuutLB.Size = new Size(93, 21);
            MuutLB.TabIndex = 3;
            MuutLB.Text = "Muut kulut: ";
            // 
            // PolttoaineLB
            // 
            PolttoaineLB.AutoSize = true;
            PolttoaineLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PolttoaineLB.Location = new Point(12, 315);
            PolttoaineLB.Name = "PolttoaineLB";
            PolttoaineLB.Size = new Size(87, 21);
            PolttoaineLB.TabIndex = 4;
            PolttoaineLB.Text = "Polttoaine: ";
            // 
            // PesutLB
            // 
            PesutLB.AutoSize = true;
            PesutLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PesutLB.Location = new Point(422, 37);
            PesutLB.Name = "PesutLB";
            PesutLB.Size = new Size(55, 21);
            PesutLB.TabIndex = 5;
            PesutLB.Text = "Pesut: ";
            // 
            // HuollotLB
            // 
            HuollotLB.AutoSize = true;
            HuollotLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HuollotLB.Location = new Point(422, 108);
            HuollotLB.Name = "HuollotLB";
            HuollotLB.Size = new Size(68, 21);
            HuollotLB.TabIndex = 6;
            HuollotLB.Text = "Huollot: ";
            // 
            // RenkaatLB
            // 
            RenkaatLB.AutoSize = true;
            RenkaatLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RenkaatLB.Location = new Point(422, 178);
            RenkaatLB.Name = "RenkaatLB";
            RenkaatLB.Size = new Size(73, 21);
            RenkaatLB.TabIndex = 7;
            RenkaatLB.Text = "Renkaat: ";
            // 
            // KilometritLB
            // 
            KilometritLB.AutoSize = true;
            KilometritLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KilometritLB.Location = new Point(422, 245);
            KilometritLB.Name = "KilometritLB";
            KilometritLB.Size = new Size(136, 21);
            KilometritLB.TabIndex = 8;
            KilometritLB.Text = "Kilometrit / vuosi: ";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(12, 387);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(253, 21);
            VastausLB.TabIndex = 9;
            VastausLB.Text = "Kustannukset kilometriä kohti ovat:";
            // 
            // LainaTB
            // 
            LainaTB.Location = new Point(219, 39);
            LainaTB.Name = "LainaTB";
            LainaTB.Size = new Size(128, 23);
            LainaTB.TabIndex = 10;
            // 
            // NesteetTB
            // 
            NesteetTB.Location = new Point(219, 106);
            NesteetTB.Name = "NesteetTB";
            NesteetTB.Size = new Size(128, 23);
            NesteetTB.TabIndex = 11;
            // 
            // VakuutusTB
            // 
            VakuutusTB.Location = new Point(219, 176);
            VakuutusTB.Name = "VakuutusTB";
            VakuutusTB.Size = new Size(128, 23);
            VakuutusTB.TabIndex = 12;
            // 
            // MuutTB
            // 
            MuutTB.Location = new Point(219, 243);
            MuutTB.Name = "MuutTB";
            MuutTB.Size = new Size(128, 23);
            MuutTB.TabIndex = 13;
            // 
            // PolttoaineTB
            // 
            PolttoaineTB.Location = new Point(219, 313);
            PolttoaineTB.Name = "PolttoaineTB";
            PolttoaineTB.Size = new Size(128, 23);
            PolttoaineTB.TabIndex = 14;
            // 
            // PesutTB
            // 
            PesutTB.Location = new Point(575, 39);
            PesutTB.Name = "PesutTB";
            PesutTB.Size = new Size(128, 23);
            PesutTB.TabIndex = 15;
            // 
            // HuoltoTB
            // 
            HuoltoTB.Location = new Point(575, 106);
            HuoltoTB.Name = "HuoltoTB";
            HuoltoTB.Size = new Size(128, 23);
            HuoltoTB.TabIndex = 16;
            // 
            // RenkaatTB
            // 
            RenkaatTB.Location = new Point(575, 180);
            RenkaatTB.Name = "RenkaatTB";
            RenkaatTB.Size = new Size(128, 23);
            RenkaatTB.TabIndex = 17;
            // 
            // KilometritCB
            // 
            KilometritCB.FormattingEnabled = true;
            KilometritCB.Items.AddRange(new object[] { "10,000", "15,000", "20,000", "30,000", "40,000", "50,000", "75,000", "100,000" });
            KilometritCB.Location = new Point(575, 243);
            KilometritCB.Name = "KilometritCB";
            KilometritCB.Size = new Size(128, 23);
            KilometritCB.TabIndex = 18;
            KilometritCB.SelectedIndexChanged += KilometritCB_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KilometritCB);
            Controls.Add(RenkaatTB);
            Controls.Add(HuoltoTB);
            Controls.Add(PesutTB);
            Controls.Add(PolttoaineTB);
            Controls.Add(MuutTB);
            Controls.Add(VakuutusTB);
            Controls.Add(NesteetTB);
            Controls.Add(LainaTB);
            Controls.Add(VastausLB);
            Controls.Add(KilometritLB);
            Controls.Add(RenkaatLB);
            Controls.Add(HuollotLB);
            Controls.Add(PesutLB);
            Controls.Add(PolttoaineLB);
            Controls.Add(MuutLB);
            Controls.Add(VakuutusLB);
            Controls.Add(NesteetLB);
            Controls.Add(LainaLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LainaLB;
        private Label NesteetLB;
        private Label VakuutusLB;
        private Label MuutLB;
        private Label PolttoaineLB;
        private Label PesutLB;
        private Label HuollotLB;
        private Label RenkaatLB;
        private Label KilometritLB;
        private Label VastausLB;
        private TextBox LainaTB;
        private TextBox NesteetTB;
        private TextBox VakuutusTB;
        private TextBox MuutTB;
        private TextBox PolttoaineTB;
        private TextBox PesutTB;
        private TextBox HuoltoTB;
        private TextBox RenkaatTB;
        private ComboBox KilometritCB;
    }
}
