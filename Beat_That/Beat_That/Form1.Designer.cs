namespace Beat_That
{
    partial class Form1
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
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(12, 12);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(217, 136);
            this.Red.TabIndex = 0;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green.Location = new System.Drawing.Point(235, 12);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(217, 136);
            this.Green.TabIndex = 1;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(12, 154);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(217, 136);
            this.Yellow.TabIndex = 2;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(235, 154);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(217, 136);
            this.Blue.TabIndex = 3;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(94, 307);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(61, 17);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(294, 307);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(85, 17);
            this.PatternLabel.TabIndex = 5;
            this.PatternLabel.Text = "In Pattern: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 342);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Name = "Form1";
            this.Text = "Beat That";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label PatternLabel;
    }
}

