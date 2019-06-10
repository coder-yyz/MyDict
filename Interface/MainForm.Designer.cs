namespace Interface
{
	partial class MainForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SavedItems = new System.Windows.Forms.Button();
            this.Pronounce = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.Location = new System.Drawing.Point(177, 40);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(688, 49);
            this.SearchBox.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Location = new System.Drawing.Point(16, 14);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(89, 27);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "菜单";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(811, 100);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(53, 27);
            this.Save.TabIndex = 3;
            this.Save.Text = "收藏";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(891, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SavedItems
            // 
            this.SavedItems.Location = new System.Drawing.Point(17, 482);
            this.SavedItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SavedItems.Name = "SavedItems";
            this.SavedItems.Size = new System.Drawing.Size(88, 27);
            this.SavedItems.TabIndex = 7;
            this.SavedItems.Text = "收藏夹";
            this.SavedItems.UseVisualStyleBackColor = true;
            this.SavedItems.Click += new System.EventHandler(this.SavedItems_Click);
            // 
            // Pronounce
            // 
            this.Pronounce.Location = new System.Drawing.Point(177, 100);
            this.Pronounce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pronounce.Name = "Pronounce";
            this.Pronounce.Size = new System.Drawing.Size(60, 27);
            this.Pronounce.TabIndex = 8;
            this.Pronounce.Text = "发音";
            this.Pronounce.UseVisualStyleBackColor = true;
            this.Pronounce.Click += new System.EventHandler(this.Pronounce_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(177, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(687, 166);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "笔记";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(177, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(687, 137);
            this.textBox2.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1035, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Pronounce);
            this.Controls.Add(this.SavedItems);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.SearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Button Menu;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button SavedItems;
		private System.Windows.Forms.Button Pronounce;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

