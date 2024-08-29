namespace Harjoitus_11
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
            noppa01PB = new PictureBox();
            noppa02PB = new PictureBox();
            HeitaBT_click = new Button();
            ((System.ComponentModel.ISupportInitialize)noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // noppa01PB
            // 
            noppa01PB.Image = Properties.Resources.rollingDice;
            noppa01PB.Location = new Point(32, 29);
            noppa01PB.Name = "noppa01PB";
            noppa01PB.Size = new Size(110, 110);
            noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa01PB.TabIndex = 0;
            noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            noppa02PB.Image = Properties.Resources.rollingDice;
            noppa02PB.Location = new Point(204, 29);
            noppa02PB.Name = "noppa02PB";
            noppa02PB.Size = new Size(110, 110);
            noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa02PB.TabIndex = 1;
            noppa02PB.TabStop = false;
            // 
            // HeitaBT_click
            // 
            HeitaBT_click.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeitaBT_click.Location = new Point(32, 174);
            HeitaBT_click.Name = "HeitaBT_click";
            HeitaBT_click.Size = new Size(286, 69);
            HeitaBT_click.TabIndex = 2;
            HeitaBT_click.Text = "Heitä!";
            HeitaBT_click.UseVisualStyleBackColor = true;
            HeitaBT_click.Click += HeitaBT_click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 310);
            Controls.Add(HeitaBT_click);
            Controls.Add(noppa02PB);
            Controls.Add(noppa01PB);
            Name = "Form1";
            Text = "Heitä Noppa";
            ((System.ComponentModel.ISupportInitialize)noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button HeitaBT_click;
    }
}
