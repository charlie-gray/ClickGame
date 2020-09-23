namespace Clicker_Game
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
            this.clickBtn = new System.Windows.Forms.Button();
            this.ClickCounter = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickBtn
            // 
            this.clickBtn.Location = new System.Drawing.Point(265, 172);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(240, 220);
            this.clickBtn.TabIndex = 0;
            this.clickBtn.Text = "Click";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClickCounter
            // 
            this.ClickCounter.AutoSize = true;
            this.ClickCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickCounter.Location = new System.Drawing.Point(367, 100);
            this.ClickCounter.Name = "ClickCounter";
            this.ClickCounter.Size = new System.Drawing.Size(29, 31);
            this.ClickCounter.TabIndex = 1;
            this.ClickCounter.Text = "0";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(238, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(307, 46);
            this.Title.TabIndex = 2;
            this.Title.Text = "Click the button!";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ClickCounter);
            this.Controls.Add(this.clickBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Label ClickCounter;
        private System.Windows.Forms.Label Title;
    }
}

