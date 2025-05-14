namespace Lab7CSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(376, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab 7. C#";

            // pictureBox1
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(231, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;

            // groupBox1
            this.groupBox1.Controls.Add(this.rbCircle);
            this.groupBox1.Controls.Add(this.rbEllipse);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Location = new System.Drawing.Point(231, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "тип примітива";

            // rbLine
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(6, 21);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(82, 20);
            this.rbLine.TabIndex = 4;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Відрізок";
            this.rbLine.UseVisualStyleBackColor = true;

            // rbRectangle
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(94, 21);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(115, 20);
            this.rbRectangle.TabIndex = 5;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "\tПрямокутник";
            this.rbRectangle.UseVisualStyleBackColor = true;

            // rbEllipse
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(215, 22);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(65, 20);
            this.rbEllipse.TabIndex = 6;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Еліпс";
            this.rbEllipse.UseVisualStyleBackColor = true;

            // rbCircle
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(297, 22);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(60, 20);
            this.rbCircle.TabIndex = 7;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Коло";
            this.rbCircle.UseVisualStyleBackColor = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(1067, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbCircle;
    }
}
