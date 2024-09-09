namespace Harjoitus_18
{
    partial class Avainhekilot_form
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
            otsikkoLB = new Label();
            oppilaitosLB = new Label();
            vastuuhenkiloLB = new Label();
            oppilaitosCB = new ComboBox();
            vastuuhenkiloCB = new ComboBox();
            osoiteLB = new Label();
            postinumeroLB = new Label();
            puhelinLB = new Label();
            postitoimipaikkaLB = new Label();
            puhelin2LB = new Label();
            sahkopostiLB = new Label();
            osastoLB = new Label();
            titteliLB = new Label();
            SuspendLayout();
            // 
            // otsikkoLB
            // 
            otsikkoLB.AutoSize = true;
            otsikkoLB.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otsikkoLB.Location = new Point(12, 9);
            otsikkoLB.Name = "otsikkoLB";
            otsikkoLB.Size = new Size(476, 50);
            otsikkoLB.TabIndex = 0;
            otsikkoLB.Text = "Oppilaitosten Avainhenkilöt";
            // 
            // oppilaitosLB
            // 
            oppilaitosLB.AutoSize = true;
            oppilaitosLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oppilaitosLB.Location = new Point(22, 72);
            oppilaitosLB.Name = "oppilaitosLB";
            oppilaitosLB.Size = new Size(130, 21);
            oppilaitosLB.TabIndex = 1;
            oppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // vastuuhenkiloLB
            // 
            vastuuhenkiloLB.AutoSize = true;
            vastuuhenkiloLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vastuuhenkiloLB.Location = new Point(358, 72);
            vastuuhenkiloLB.Name = "vastuuhenkiloLB";
            vastuuhenkiloLB.Size = new Size(159, 21);
            vastuuhenkiloLB.TabIndex = 2;
            vastuuhenkiloLB.Text = "Valitse vastuuhenkilö:";
            // 
            // oppilaitosCB
            // 
            oppilaitosCB.FormattingEnabled = true;
            oppilaitosCB.Location = new Point(22, 108);
            oppilaitosCB.Name = "oppilaitosCB";
            oppilaitosCB.Size = new Size(130, 23);
            oppilaitosCB.TabIndex = 3;
            oppilaitosCB.SelectedIndexChanged += oppilaitosCB_SelectedIndexChanged;
            // 
            // vastuuhenkiloCB
            // 
            vastuuhenkiloCB.FormattingEnabled = true;
            vastuuhenkiloCB.Location = new Point(358, 108);
            vastuuhenkiloCB.Name = "vastuuhenkiloCB";
            vastuuhenkiloCB.Size = new Size(159, 23);
            vastuuhenkiloCB.TabIndex = 4;
            vastuuhenkiloCB.SelectedIndexChanged += vastuuhenkiloCB_TextChanged;
            // 
            // osoiteLB
            // 
            osoiteLB.AutoSize = true;
            osoiteLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            osoiteLB.Location = new Point(22, 175);
            osoiteLB.Name = "osoiteLB";
            osoiteLB.Size = new Size(55, 21);
            osoiteLB.TabIndex = 5;
            osoiteLB.Text = "Osoite";
            // 
            // postinumeroLB
            // 
            postinumeroLB.AutoSize = true;
            postinumeroLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postinumeroLB.Location = new Point(22, 219);
            postinumeroLB.Name = "postinumeroLB";
            postinumeroLB.Size = new Size(98, 21);
            postinumeroLB.TabIndex = 6;
            postinumeroLB.Text = "Postinumero";
            // 
            // puhelinLB
            // 
            puhelinLB.AutoSize = true;
            puhelinLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            puhelinLB.Location = new Point(22, 325);
            puhelinLB.Name = "puhelinLB";
            puhelinLB.Size = new Size(62, 21);
            puhelinLB.TabIndex = 7;
            puhelinLB.Text = "Puhelin";
            // 
            // postitoimipaikkaLB
            // 
            postitoimipaikkaLB.AutoSize = true;
            postitoimipaikkaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postitoimipaikkaLB.Location = new Point(22, 269);
            postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            postitoimipaikkaLB.Size = new Size(124, 21);
            postitoimipaikkaLB.TabIndex = 8;
            postitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelin2LB
            // 
            puhelin2LB.AutoSize = true;
            puhelin2LB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            puhelin2LB.Location = new Point(358, 325);
            puhelin2LB.Name = "puhelin2LB";
            puhelin2LB.Size = new Size(62, 21);
            puhelin2LB.TabIndex = 9;
            puhelin2LB.Text = "Puhelin";
            // 
            // sahkopostiLB
            // 
            sahkopostiLB.AutoSize = true;
            sahkopostiLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sahkopostiLB.Location = new Point(358, 269);
            sahkopostiLB.Name = "sahkopostiLB";
            sahkopostiLB.Size = new Size(87, 21);
            sahkopostiLB.TabIndex = 10;
            sahkopostiLB.Text = "Sähköposti";
            // 
            // osastoLB
            // 
            osastoLB.AutoSize = true;
            osastoLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            osastoLB.Location = new Point(358, 219);
            osastoLB.Name = "osastoLB";
            osastoLB.Size = new Size(58, 21);
            osastoLB.TabIndex = 11;
            osastoLB.Text = "Osasto";
            // 
            // titteliLB
            // 
            titteliLB.AutoSize = true;
            titteliLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titteliLB.Location = new Point(358, 175);
            titteliLB.Name = "titteliLB";
            titteliLB.Size = new Size(48, 21);
            titteliLB.TabIndex = 12;
            titteliLB.Text = "Titteli";
            // 
            // Avainhekilot_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 418);
            Controls.Add(titteliLB);
            Controls.Add(osastoLB);
            Controls.Add(sahkopostiLB);
            Controls.Add(puhelin2LB);
            Controls.Add(postitoimipaikkaLB);
            Controls.Add(puhelinLB);
            Controls.Add(postinumeroLB);
            Controls.Add(osoiteLB);
            Controls.Add(vastuuhenkiloCB);
            Controls.Add(oppilaitosCB);
            Controls.Add(vastuuhenkiloLB);
            Controls.Add(oppilaitosLB);
            Controls.Add(otsikkoLB);
            Name = "Avainhekilot_form";
            Text = "Avainhenkilöstö";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label otsikkoLB;
        private Label oppilaitosLB;
        private Label vastuuhenkiloLB;
        private ComboBox oppilaitosCB;
        private ComboBox vastuuhenkiloCB;
        private Label osoiteLB;
        private Label postinumeroLB;
        private Label puhelinLB;
        private Label postitoimipaikkaLB;
        private Label puhelin2LB;
        private Label sahkopostiLB;
        private Label osastoLB;
        private Label titteliLB;
    }
}
