namespace Interface
{
	partial class Menu
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
            this.MenuPanel = new System.Windows.Forms.TabControl();
            this.History = new System.Windows.Forms.TabPage();
            this.DeleteHis = new System.Windows.Forms.Button();
            this.Dictionaries = new System.Windows.Forms.TabPage();
            this.ImportDict = new System.Windows.Forms.Button();
            this.AddDict = new System.Windows.Forms.Button();
            this.DeleteDict = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.History.SuspendLayout();
            this.Dictionaries.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.History);
            this.MenuPanel.Controls.Add(this.Dictionaries);
            this.MenuPanel.Location = new System.Drawing.Point(-1, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.SelectedIndex = 0;
            this.MenuPanel.Size = new System.Drawing.Size(1047, 531);
            this.MenuPanel.TabIndex = 0;
            // 
            // History
            // 
            this.History.Controls.Add(this.DeleteHis);
            this.History.Location = new System.Drawing.Point(4, 25);
            this.History.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.History.Size = new System.Drawing.Size(1039, 502);
            this.History.TabIndex = 0;
            this.History.Text = "历史记录";
            this.History.UseVisualStyleBackColor = true;
            // 
            // DeleteHis
            // 
            this.DeleteHis.Location = new System.Drawing.Point(928, 419);
            this.DeleteHis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteHis.Name = "DeleteHis";
            this.DeleteHis.Size = new System.Drawing.Size(100, 27);
            this.DeleteHis.TabIndex = 0;
            this.DeleteHis.Text = "清除历史";
            this.DeleteHis.UseVisualStyleBackColor = true;
            // 
            // Dictionaries
            // 
            this.Dictionaries.Controls.Add(this.ImportDict);
            this.Dictionaries.Controls.Add(this.AddDict);
            this.Dictionaries.Controls.Add(this.DeleteDict);
            this.Dictionaries.Location = new System.Drawing.Point(4, 25);
            this.Dictionaries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dictionaries.Name = "Dictionaries";
            this.Dictionaries.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dictionaries.Size = new System.Drawing.Size(1039, 502);
            this.Dictionaries.TabIndex = 1;
            this.Dictionaries.Text = "词典管理";
            this.Dictionaries.UseVisualStyleBackColor = true;
            // 
            // ImportDict
            // 
            this.ImportDict.Location = new System.Drawing.Point(816, 419);
            this.ImportDict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ImportDict.Name = "ImportDict";
            this.ImportDict.Size = new System.Drawing.Size(100, 27);
            this.ImportDict.TabIndex = 2;
            this.ImportDict.Text = "导入词典";
            this.ImportDict.UseVisualStyleBackColor = true;
            // 
            // AddDict
            // 
            this.AddDict.Location = new System.Drawing.Point(708, 419);
            this.AddDict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddDict.Name = "AddDict";
            this.AddDict.Size = new System.Drawing.Size(100, 27);
            this.AddDict.TabIndex = 1;
            this.AddDict.Text = "添加词典";
            this.AddDict.UseVisualStyleBackColor = true;
            // 
            // DeleteDict
            // 
            this.DeleteDict.Location = new System.Drawing.Point(924, 419);
            this.DeleteDict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteDict.Name = "DeleteDict";
            this.DeleteDict.Size = new System.Drawing.Size(100, 27);
            this.DeleteDict.TabIndex = 0;
            this.DeleteDict.Text = "删除词典";
            this.DeleteDict.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1045, 532);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.MenuPanel.ResumeLayout(false);
            this.History.ResumeLayout(false);
            this.Dictionaries.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MenuPanel;
		private System.Windows.Forms.TabPage History;
		private System.Windows.Forms.TabPage Dictionaries;
		private System.Windows.Forms.Button DeleteHis;
		private System.Windows.Forms.Button DeleteDict;
		private System.Windows.Forms.Button ImportDict;
		private System.Windows.Forms.Button AddDict;
	}
}