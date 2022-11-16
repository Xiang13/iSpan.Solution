namespace ISpan.EStore
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.維護商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護商品類別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護商品ToolStripMenuItem,
            this.維護商品類別ToolStripMenuItem,
            this.維護使用者ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(924, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 維護商品ToolStripMenuItem
			// 
			this.維護商品ToolStripMenuItem.Name = "維護商品ToolStripMenuItem";
			this.維護商品ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.維護商品ToolStripMenuItem.Text = "維護商品";
			this.維護商品ToolStripMenuItem.Click += new System.EventHandler(this.維護商品ToolStripMenuItem_Click);
			// 
			// 維護商品類別ToolStripMenuItem
			// 
			this.維護商品類別ToolStripMenuItem.Name = "維護商品類別ToolStripMenuItem";
			this.維護商品類別ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.維護商品類別ToolStripMenuItem.Text = "維護商品類別";
			this.維護商品類別ToolStripMenuItem.Click += new System.EventHandler(this.維護商品類別ToolStripMenuItem_Click);
			// 
			// 維護使用者ToolStripMenuItem
			// 
			this.維護使用者ToolStripMenuItem.Name = "維護使用者ToolStripMenuItem";
			this.維護使用者ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.維護使用者ToolStripMenuItem.Text = "維護使用者";
			this.維護使用者ToolStripMenuItem.Click += new System.EventHandler(this.維護使用者ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 589);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 維護商品ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護商品類別ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護使用者ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
	}
}