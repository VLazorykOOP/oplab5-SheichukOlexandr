namespace Task1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxVx1;
        private System.Windows.Forms.TextBox textBoxVy1;
        private System.Windows.Forms.TextBox textBoxVx2;
        private System.Windows.Forms.TextBox textBoxVy2;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxVx1 = new System.Windows.Forms.TextBox();
            this.textBoxVy1 = new System.Windows.Forms.TextBox();
            this.textBoxVx2 = new System.Windows.Forms.TextBox();
            this.textBoxVy2 = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(12, 12);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 0;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(12, 38);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 20);
            this.textBoxY1.TabIndex = 1;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(12, 64);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 2;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(12, 90);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 20);
            this.textBoxY2.TabIndex = 3;
            // 
            // textBoxVx1
            // 
            this.textBoxVx1.Location = new System.Drawing.Point(12, 116);
            this.textBoxVx1.Name = "textBoxVx1";
            this.textBoxVx1.Size = new System.Drawing.Size(100, 20);
            this.textBoxVx1.TabIndex = 4;
            // 
            // textBoxVy1
            // 
            this.textBoxVy1.Location = new System.Drawing.Point(12, 142);
            this.textBoxVy1.Name = "textBoxVy1";
            this.textBoxVy1.Size = new System.Drawing.Size(100, 20);
            this.textBoxVy1.TabIndex = 5;
            // 
            // textBoxVx2
            // 
            this.textBoxVx2.Location = new System.Drawing.Point(12, 168);
            this.textBoxVx2.Name = "textBoxVx2";
            this.textBoxVx2.Size = new System.Drawing.Size(100, 20);
            this.textBoxVx2.TabIndex = 6;
            // 
            // textBoxVy2
            // 
            this.textBoxVy2.Location = new System.Drawing.Point(12, 194);
            this.textBoxVy2.Name = "textBoxVy2";
            this.textBoxVy2.Size = new System.Drawing.Size(100, 20);
            this.textBoxVy2.TabIndex = 7;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 220);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 8;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.textBoxVy2);
            this.Controls.Add(this.textBoxVx2);
            this.Controls.Add(this.textBoxVy1);
            this.Controls.Add(this.textBoxVx1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Name = "Form1";
            this.Text = "Hermite Curve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
