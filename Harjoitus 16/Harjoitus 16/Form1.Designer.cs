namespace Harjoitus_16
{
    partial class Ajastin
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
            components = new System.ComponentModel.Container();
            MinuutitLB = new Label();
            SekunnitLB = new Label();
            minuutitCB = new ComboBox();
            sekunnitCB = new ComboBox();
            aikaLB = new Label();
            startBT = new Button();
            StopBT = new Button();
            ajastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MinuutitLB
            // 
            MinuutitLB.AutoSize = true;
            MinuutitLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinuutitLB.Location = new Point(45, 26);
            MinuutitLB.Name = "MinuutitLB";
            MinuutitLB.Size = new Size(72, 21);
            MinuutitLB.TabIndex = 0;
            MinuutitLB.Text = "Minuutit:";
            // 
            // SekunnitLB
            // 
            SekunnitLB.AutoSize = true;
            SekunnitLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SekunnitLB.Location = new Point(129, 26);
            SekunnitLB.Name = "SekunnitLB";
            SekunnitLB.Size = new Size(74, 21);
            SekunnitLB.TabIndex = 1;
            SekunnitLB.Text = "Sekunnit:";
            // 
            // minuutitCB
            // 
            minuutitCB.FormattingEnabled = true;
            minuutitCB.Location = new Point(45, 50);
            minuutitCB.Name = "minuutitCB";
            minuutitCB.Size = new Size(76, 23);
            minuutitCB.TabIndex = 2;
            // 
            // sekunnitCB
            // 
            sekunnitCB.FormattingEnabled = true;
            sekunnitCB.Location = new Point(127, 50);
            sekunnitCB.Name = "sekunnitCB";
            sekunnitCB.Size = new Size(76, 23);
            sekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aikaLB.Location = new Point(33, 76);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(191, 86);
            aikaLB.TabIndex = 4;
            aikaLB.Text = "00:00";
            // 
            // startBT
            // 
            startBT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBT.Location = new Point(45, 165);
            startBT.Name = "startBT";
            startBT.Size = new Size(76, 44);
            startBT.TabIndex = 5;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // StopBT
            // 
            StopBT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopBT.Location = new Point(127, 165);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(76, 44);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // ajastinTM
            // 
            ajastinTM.Interval = 1000;
            ajastinTM.Tick += ajastinTM_Tick;
            // 
            // Ajastin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 270);
            Controls.Add(StopBT);
            Controls.Add(startBT);
            Controls.Add(aikaLB);
            Controls.Add(sekunnitCB);
            Controls.Add(minuutitCB);
            Controls.Add(SekunnitLB);
            Controls.Add(MinuutitLB);
            Name = "Ajastin";
            Text = "Ajastin";
            Load += Ajastin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinuutitLB;
        private Label SekunnitLB;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Label aikaLB;
        private Button startBT;
        private Button StopBT;
        private System.Windows.Forms.Timer ajastinTM;
    }
}
