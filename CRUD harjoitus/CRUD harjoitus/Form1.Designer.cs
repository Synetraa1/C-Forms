namespace CRUD_harjoitus
{
    partial class Opiskelijahaku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idlb = new System.Windows.Forms.Label();
            this.etulb = new System.Windows.Forms.Label();
            this.sukulb = new System.Windows.Forms.Label();
            this.opiskelijanumerolb = new System.Windows.Forms.Label();
            this.spostilb = new System.Windows.Forms.Label();
            this.puhlb = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.sukutb = new System.Windows.Forms.TextBox();
            this.etutb = new System.Windows.Forms.TextBox();
            this.opiskelijanumerotb = new System.Windows.Forms.TextBox();
            this.spostitb = new System.Windows.Forms.TextBox();
            this.puhtb = new System.Windows.Forms.TextBox();
            this.tyhjennabt = new System.Windows.Forms.Button();
            this.poistabt = new System.Windows.Forms.Button();
            this.paivitabt = new System.Windows.Forms.Button();
            this.tallennabt = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlb.Location = new System.Drawing.Point(20, 13);
            this.idlb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(30, 18);
            this.idlb.TabIndex = 0;
            this.idlb.Text = "ID:";
            // 
            // etulb
            // 
            this.etulb.AutoSize = true;
            this.etulb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etulb.Location = new System.Drawing.Point(20, 50);
            this.etulb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.etulb.Name = "etulb";
            this.etulb.Size = new System.Drawing.Size(72, 18);
            this.etulb.TabIndex = 1;
            this.etulb.Text = "Etunimi:";
            // 
            // sukulb
            // 
            this.sukulb.AutoSize = true;
            this.sukulb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukulb.Location = new System.Drawing.Point(20, 85);
            this.sukulb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sukulb.Name = "sukulb";
            this.sukulb.Size = new System.Drawing.Size(85, 18);
            this.sukulb.TabIndex = 2;
            this.sukulb.Text = "Sukunimi:";
            // 
            // opiskelijanumerolb
            // 
            this.opiskelijanumerolb.AutoSize = true;
            this.opiskelijanumerolb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opiskelijanumerolb.Location = new System.Drawing.Point(411, 85);
            this.opiskelijanumerolb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.opiskelijanumerolb.Name = "opiskelijanumerolb";
            this.opiskelijanumerolb.Size = new System.Drawing.Size(151, 18);
            this.opiskelijanumerolb.TabIndex = 3;
            this.opiskelijanumerolb.Text = "Opiskelijanumero:";
            // 
            // spostilb
            // 
            this.spostilb.AutoSize = true;
            this.spostilb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spostilb.Location = new System.Drawing.Point(411, 50);
            this.spostilb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.spostilb.Name = "spostilb";
            this.spostilb.Size = new System.Drawing.Size(102, 18);
            this.spostilb.TabIndex = 4;
            this.spostilb.Text = "Sähköposti:";
            // 
            // puhlb
            // 
            this.puhlb.AutoSize = true;
            this.puhlb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhlb.Location = new System.Drawing.Point(411, 13);
            this.puhlb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.puhlb.Name = "puhlb";
            this.puhlb.Size = new System.Drawing.Size(72, 18);
            this.puhlb.TabIndex = 5;
            this.puhlb.Text = "Puhelin:";
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(144, 10);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(215, 26);
            this.idtb.TabIndex = 6;
            // 
            // sukutb
            // 
            this.sukutb.Location = new System.Drawing.Point(144, 82);
            this.sukutb.Name = "sukutb";
            this.sukutb.Size = new System.Drawing.Size(215, 26);
            this.sukutb.TabIndex = 7;
            // 
            // etutb
            // 
            this.etutb.Location = new System.Drawing.Point(144, 47);
            this.etutb.Name = "etutb";
            this.etutb.Size = new System.Drawing.Size(215, 26);
            this.etutb.TabIndex = 8;
            // 
            // opiskelijanumerotb
            // 
            this.opiskelijanumerotb.Location = new System.Drawing.Point(569, 82);
            this.opiskelijanumerotb.Name = "opiskelijanumerotb";
            this.opiskelijanumerotb.Size = new System.Drawing.Size(215, 26);
            this.opiskelijanumerotb.TabIndex = 9;
            // 
            // spostitb
            // 
            this.spostitb.Location = new System.Drawing.Point(569, 47);
            this.spostitb.Name = "spostitb";
            this.spostitb.Size = new System.Drawing.Size(215, 26);
            this.spostitb.TabIndex = 10;
            // 
            // puhtb
            // 
            this.puhtb.Location = new System.Drawing.Point(569, 10);
            this.puhtb.Name = "puhtb";
            this.puhtb.Size = new System.Drawing.Size(215, 26);
            this.puhtb.TabIndex = 11;
            // 
            // tyhjennabt
            // 
            this.tyhjennabt.BackColor = System.Drawing.Color.DarkGray;
            this.tyhjennabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tyhjennabt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennabt.Location = new System.Drawing.Point(23, 128);
            this.tyhjennabt.Name = "tyhjennabt";
            this.tyhjennabt.Size = new System.Drawing.Size(112, 36);
            this.tyhjennabt.TabIndex = 12;
            this.tyhjennabt.Text = "TYHJENNÄ";
            this.tyhjennabt.UseVisualStyleBackColor = false;
            this.tyhjennabt.Click += new System.EventHandler(this.tyhjennabt_Click);
            // 
            // poistabt
            // 
            this.poistabt.BackColor = System.Drawing.Color.DarkGray;
            this.poistabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poistabt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistabt.Location = new System.Drawing.Point(377, 128);
            this.poistabt.Name = "poistabt";
            this.poistabt.Size = new System.Drawing.Size(112, 36);
            this.poistabt.TabIndex = 13;
            this.poistabt.Text = "POISTA";
            this.poistabt.UseVisualStyleBackColor = false;
            this.poistabt.Click += new System.EventHandler(this.poistabt_Click);
            // 
            // paivitabt
            // 
            this.paivitabt.BackColor = System.Drawing.Color.DarkGray;
            this.paivitabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paivitabt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paivitabt.Location = new System.Drawing.Point(259, 128);
            this.paivitabt.Name = "paivitabt";
            this.paivitabt.Size = new System.Drawing.Size(112, 36);
            this.paivitabt.TabIndex = 14;
            this.paivitabt.Text = "PÄIVITÄ";
            this.paivitabt.UseVisualStyleBackColor = false;
            this.paivitabt.Click += new System.EventHandler(this.paivitabt_Click);
            // 
            // tallennabt
            // 
            this.tallennabt.BackColor = System.Drawing.Color.DarkGray;
            this.tallennabt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tallennabt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallennabt.Location = new System.Drawing.Point(141, 128);
            this.tallennabt.Name = "tallennabt";
            this.tallennabt.Size = new System.Drawing.Size(112, 36);
            this.tallennabt.TabIndex = 15;
            this.tallennabt.Text = "TALLENNA";
            this.tallennabt.UseVisualStyleBackColor = false;
            this.tallennabt.Click += new System.EventHandler(this.tallennabt_Click);
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(23, 170);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(775, 243);
            this.TietotauluDG.TabIndex = 16;
            // 
            // Opiskelijahaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 425);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.tallennabt);
            this.Controls.Add(this.paivitabt);
            this.Controls.Add(this.poistabt);
            this.Controls.Add(this.tyhjennabt);
            this.Controls.Add(this.puhtb);
            this.Controls.Add(this.spostitb);
            this.Controls.Add(this.opiskelijanumerotb);
            this.Controls.Add(this.etutb);
            this.Controls.Add(this.sukutb);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.puhlb);
            this.Controls.Add(this.spostilb);
            this.Controls.Add(this.opiskelijanumerolb);
            this.Controls.Add(this.sukulb);
            this.Controls.Add(this.etulb);
            this.Controls.Add(this.idlb);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Opiskelijahaku";
            this.Text = "Opsikelijahaku";
            this.Load += new System.EventHandler(this.Opiskelijahaku_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.Label etulb;
        private System.Windows.Forms.Label sukulb;
        private System.Windows.Forms.Label opiskelijanumerolb;
        private System.Windows.Forms.Label spostilb;
        private System.Windows.Forms.Label puhlb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox sukutb;
        private System.Windows.Forms.TextBox etutb;
        private System.Windows.Forms.TextBox opiskelijanumerotb;
        private System.Windows.Forms.TextBox spostitb;
        private System.Windows.Forms.TextBox puhtb;
        private System.Windows.Forms.Button tyhjennabt;
        private System.Windows.Forms.Button poistabt;
        private System.Windows.Forms.Button paivitabt;
        private System.Windows.Forms.Button tallennabt;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

