namespace QlDiem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDữLiệuToolStripMenuItem
            // 
            this.nhậpDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngSinhViênToolStripMenuItem,
            this.bảngMônToolStripMenuItem,
            this.bảngĐiểmToolStripMenuItem});
            this.nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
            this.nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.nhậpDữLiệuToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // bảngSinhViênToolStripMenuItem
            // 
            this.bảngSinhViênToolStripMenuItem.Name = "bảngSinhViênToolStripMenuItem";
            this.bảngSinhViênToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bảngSinhViênToolStripMenuItem.Text = "Bảng sinh viên";
            this.bảngSinhViênToolStripMenuItem.Click += new System.EventHandler(this.bảngSinhViênToolStripMenuItem_Click);
            // 
            // bảngMônToolStripMenuItem
            // 
            this.bảngMônToolStripMenuItem.Name = "bảngMônToolStripMenuItem";
            this.bảngMônToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bảngMônToolStripMenuItem.Text = "Bảng môn";
            this.bảngMônToolStripMenuItem.Click += new System.EventHandler(this.bảngMônToolStripMenuItem_Click);
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            this.bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            this.bảngĐiểmToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.bảngĐiểmToolStripMenuItem.Text = "Bảng điểm";
            this.bảngĐiểmToolStripMenuItem.Click += new System.EventHandler(this.bảngĐiểmToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
           // this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 342);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}

