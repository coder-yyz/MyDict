namespace Interface
{
    partial class Favourates
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
            this.Memory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(48, 29);
            this.Memory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(100, 27);
            this.Memory.TabIndex = 4;
            this.Memory.Text = "背单词";
            this.Memory.UseVisualStyleBackColor = true;
            this.Memory.Click += new System.EventHandler(this.Memory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(48, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(822, 438);
            this.textBox1.TabIndex = 5;
            // 
            // Favourates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(924, 597);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Memory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Favourates";
            this.Text = "Favourates";
            this.Load += new System.EventHandler(this.Favourates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Memory;
        private System.Windows.Forms.TextBox textBox1;
    }
}