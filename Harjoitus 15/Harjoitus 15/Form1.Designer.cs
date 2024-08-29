namespace Harjoitus_15
{
    partial class StopwatchForm
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
            timerLB = new Label();
            ajastinTM = new System.Windows.Forms.Timer(components);
            StartBT = new Button();
            ResetBT = new Button();
            StopBT = new Button();
            SuspendLayout();
            // 
            // timerLB
            // 
            timerLB.AutoSize = true;
            timerLB.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLB.Location = new Point(87, 9);
            timerLB.Name = "timerLB";
            timerLB.Size = new Size(627, 128);
            timerLB.TabIndex = 0;
            timerLB.Text = "00:00:00.000";
            // 
            // ajastinTM
            // 
            ajastinTM.Enabled = true;
            ajastinTM.Tick += ajastinTM_Tick;
            // 
            // StartBT
            // 
            StartBT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartBT.Location = new Point(87, 140);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(98, 58);
            StartBT.TabIndex = 1;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = true;
            StartBT.Click += StartBT_Click;
            // 
            // ResetBT
            // 
            ResetBT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBT.Location = new Point(346, 140);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(98, 58);
            ResetBT.TabIndex = 2;
            ResetBT.Text = "Reset";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // StopBT
            // 
            StopBT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopBT.Location = new Point(616, 140);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(98, 58);
            StopBT.TabIndex = 3;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // StopwatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 229);
            Controls.Add(StopBT);
            Controls.Add(ResetBT);
            Controls.Add(StartBT);
            Controls.Add(timerLB);
            Name = "StopwatchForm";
            Text = "Stopwatch";
            Load += StopwatchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timerLB;
        private System.Windows.Forms.Timer ajastinTM;
        private Button StartBT;
        private Button ResetBT;
        private Button StopBT;
    }
}
