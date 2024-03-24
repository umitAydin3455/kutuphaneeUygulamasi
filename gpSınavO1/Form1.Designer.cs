namespace gpSınavO1
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
            this.üyeYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeYönetimiToolStripMenuItem,
            this.kitapYönetimiToolStripMenuItem,
            this.emanetİşlemleriToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeYönetimiToolStripMenuItem
            // 
            this.üyeYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıGirişiToolStripMenuItem,
            this.üToolStripMenuItem});
            this.üyeYönetimiToolStripMenuItem.Name = "üyeYönetimiToolStripMenuItem";
            this.üyeYönetimiToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.üyeYönetimiToolStripMenuItem.Text = "Üye Yönetimi";
            // 
            // kullanıcıGirişiToolStripMenuItem
            // 
            this.kullanıcıGirişiToolStripMenuItem.Name = "kullanıcıGirişiToolStripMenuItem";
            this.kullanıcıGirişiToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.kullanıcıGirişiToolStripMenuItem.Text = "Kullanıcı Girişi";
            this.kullanıcıGirişiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGirişiToolStripMenuItem_Click);
            // 
            // üToolStripMenuItem
            // 
            this.üToolStripMenuItem.Name = "üToolStripMenuItem";
            this.üToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.üToolStripMenuItem.Text = "Üye Ekleme";
            this.üToolStripMenuItem.Click += new System.EventHandler(this.üToolStripMenuItem_Click);
            // 
            // kitapYönetimiToolStripMenuItem
            // 
            this.kitapYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEklemeToolStripMenuItem});
            this.kitapYönetimiToolStripMenuItem.Name = "kitapYönetimiToolStripMenuItem";
            this.kitapYönetimiToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.kitapYönetimiToolStripMenuItem.Text = "Kitap Yönetimi";
            // 
            // kitapEklemeToolStripMenuItem
            // 
            this.kitapEklemeToolStripMenuItem.Name = "kitapEklemeToolStripMenuItem";
            this.kitapEklemeToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.kitapEklemeToolStripMenuItem.Text = "Kitap Ekleme";
            this.kitapEklemeToolStripMenuItem.Click += new System.EventHandler(this.kitapEklemeToolStripMenuItem_Click);
            // 
            // emanetİşlemleriToolStripMenuItem1
            // 
            this.emanetİşlemleriToolStripMenuItem1.Name = "emanetİşlemleriToolStripMenuItem1";
            this.emanetİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(133, 24);
            this.emanetİşlemleriToolStripMenuItem1.Text = "Emanet İşlemleri";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(990, 414);
            this.panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 444);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem üToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEklemeToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
    }
}

