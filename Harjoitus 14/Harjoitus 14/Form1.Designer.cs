﻿namespace Harjoitus_14
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
            SyottoTB = new TextBox();
            TallennaBT = new Button();
            SuspendLayout();
            // 
            // SyottoTB
            // 
            SyottoTB.Location = new Point(12, 12);
            SyottoTB.Multiline = true;
            SyottoTB.Name = "SyottoTB";
            SyottoTB.Size = new Size(776, 365);
            SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            TallennaBT.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TallennaBT.Location = new Point(12, 383);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(776, 55);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallenna Päiväkirjaan";
            TallennaBT.UseVisualStyleBackColor = true;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TallennaBT);
            Controls.Add(SyottoTB);
            Name = "Form1";
            Text = "Päiväkirja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SyottoTB;
        private Button TallennaBT;
    }
}
