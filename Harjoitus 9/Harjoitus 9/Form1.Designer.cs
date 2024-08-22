namespace Harjoitus_9
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
            AsteetLB = new Label();
            VastausLB = new Label();
            MuunnaBT = new Button();
            MuunnosKysymysLB = new Label();
            CelsiusRB = new RadioButton();
            FahrenheitRB = new RadioButton();
            AsteetTB = new TextBox();
            SuspendLayout();
            // 
            // AsteetLB
            // 
            AsteetLB.AutoSize = true;
            AsteetLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AsteetLB.Location = new Point(12, 36);
            AsteetLB.Name = "AsteetLB";
            AsteetLB.Size = new Size(98, 21);
            AsteetLB.TabIndex = 0;
            AsteetLB.Text = "Anna asteet: ";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(12, 166);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(63, 21);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuunnaBT
            // 
            MuunnaBT.Location = new Point(347, 156);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(97, 45);
            MuunnaBT.TabIndex = 2;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // MuunnosKysymysLB
            // 
            MuunnosKysymysLB.AutoSize = true;
            MuunnosKysymysLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MuunnosKysymysLB.Location = new Point(237, 36);
            MuunnosKysymysLB.Name = "MuunnosKysymysLB";
            MuunnosKysymysLB.Size = new Size(124, 21);
            MuunnosKysymysLB.TabIndex = 5;
            MuunnosKysymysLB.Text = "Miten muunnat?";
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Location = new Point(237, 74);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(62, 19);
            CelsiusRB.TabIndex = 6;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            CelsiusRB.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Location = new Point(237, 99);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(81, 19);
            FahrenheitRB.TabIndex = 7;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(116, 34);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(79, 23);
            AsteetTB.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 213);
            Controls.Add(AsteetTB);
            Controls.Add(FahrenheitRB);
            Controls.Add(CelsiusRB);
            Controls.Add(MuunnosKysymysLB);
            Controls.Add(MuunnaBT);
            Controls.Add(VastausLB);
            Controls.Add(AsteetLB);
            Name = "Form1";
            Text = "Muunnin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AsteetLB;
        private Label VastausLB;
        private Button MuunnaBT;
        private Label MuunnosKysymysLB;
        private RadioButton CelsiusRB;
        private RadioButton FahrenheitRB;
        private TextBox AsteetTB;
    }
}
