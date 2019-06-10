namespace Interface
{
	partial class Memory
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Process = new System.Windows.Forms.TextBox();
            this.Pronounce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(120, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(805, 304);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "记住";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 415);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "忘记";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(120, 17);
            this.Process.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(132, 25);
            this.Process.TabIndex = 6;
            // 
            // Pronounce
            // 
            this.Pronounce.Location = new System.Drawing.Point(53, 69);
            this.Pronounce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pronounce.Name = "Pronounce";
            this.Pronounce.Size = new System.Drawing.Size(60, 40);
            this.Pronounce.TabIndex = 8;
            this.Pronounce.Text = "发音";
            this.Pronounce.UseVisualStyleBackColor = true;
            this.Pronounce.Click += new System.EventHandler(this.Pronounce_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.Pronounce);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Memory";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Memory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox Process;
		private System.Windows.Forms.Button Pronounce;
	}
}