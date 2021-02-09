namespace Arcade_Machine
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
            System.Windows.Forms.Button StartLabel;
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.CountdownLabel3 = new System.Windows.Forms.Label();
            this.CountdownLabel2 = new System.Windows.Forms.Label();
            this.CountdownLabel1 = new System.Windows.Forms.Label();
            this.GoLabel = new System.Windows.Forms.Label();
            StartLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            StartLabel.BackColor = System.Drawing.Color.Gray;
            StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            StartLabel.Location = new System.Drawing.Point(195, 254);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new System.Drawing.Size(355, 122);
            StartLabel.TabIndex = 0;
            StartLabel.Text = "Click To Start";
            StartLabel.UseVisualStyleBackColor = false;
            StartLabel.Click += new System.EventHandler(this.StartLabel_Click);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.ForeColor = System.Drawing.Color.Black;
            this.CountdownLabel.Location = new System.Drawing.Point(223, 72);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(267, 29);
            this.CountdownLabel.TabIndex = 1;
            this.CountdownLabel.Text = "The Game Will Begin In";
            // 
            // CountdownLabel3
            // 
            this.CountdownLabel3.AutoSize = true;
            this.CountdownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel3.ForeColor = System.Drawing.Color.Black;
            this.CountdownLabel3.Location = new System.Drawing.Point(496, 72);
            this.CountdownLabel3.Name = "CountdownLabel3";
            this.CountdownLabel3.Size = new System.Drawing.Size(44, 29);
            this.CountdownLabel3.TabIndex = 2;
            this.CountdownLabel3.Text = "3...";
            // 
            // CountdownLabel2
            // 
            this.CountdownLabel2.AutoSize = true;
            this.CountdownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel2.ForeColor = System.Drawing.Color.Black;
            this.CountdownLabel2.Location = new System.Drawing.Point(496, 72);
            this.CountdownLabel2.Name = "CountdownLabel2";
            this.CountdownLabel2.Size = new System.Drawing.Size(44, 29);
            this.CountdownLabel2.TabIndex = 3;
            this.CountdownLabel2.Text = "2...";
            // 
            // CountdownLabel1
            // 
            this.CountdownLabel1.AutoSize = true;
            this.CountdownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel1.ForeColor = System.Drawing.Color.Black;
            this.CountdownLabel1.Location = new System.Drawing.Point(496, 72);
            this.CountdownLabel1.Name = "CountdownLabel1";
            this.CountdownLabel1.Size = new System.Drawing.Size(44, 29);
            this.CountdownLabel1.TabIndex = 4;
            this.CountdownLabel1.Text = "1...";
            this.CountdownLabel1.Click += new System.EventHandler(this.CoountdownLabel1_Click);
            // 
            // GoLabel
            // 
            this.GoLabel.AutoSize = true;
            this.GoLabel.BackColor = System.Drawing.Color.Black;
            this.GoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLabel.ForeColor = System.Drawing.Color.Black;
            this.GoLabel.Location = new System.Drawing.Point(331, 199);
            this.GoLabel.Name = "GoLabel";
            this.GoLabel.Size = new System.Drawing.Size(69, 37);
            this.GoLabel.TabIndex = 5;
            this.GoLabel.Text = "Go!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.GoLabel);
            this.Controls.Add(this.CountdownLabel1);
            this.Controls.Add(this.CountdownLabel2);
            this.Controls.Add(this.CountdownLabel3);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(StartLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Label CountdownLabel3;
        private System.Windows.Forms.Label CountdownLabel2;
        private System.Windows.Forms.Label CountdownLabel1;
        private System.Windows.Forms.Label GoLabel;
    }
}

