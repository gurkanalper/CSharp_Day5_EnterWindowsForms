namespace Day5_EnterWİndowsForms
{
    partial class frm_menu
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
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğenciListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muhasebeToolStripMenuItem,
            this.cariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muhasebeGirişToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.öğenciListeleToolStripMenuItem});
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.muhasebeToolStripMenuItem.Text = "muhasebe";
            this.muhasebeToolStripMenuItem.Click += new System.EventHandler(this.muhasebeToolStripMenuItem_Click);
            // 
            // muhasebeGirişToolStripMenuItem
            // 
            this.muhasebeGirişToolStripMenuItem.Name = "muhasebeGirişToolStripMenuItem";
            this.muhasebeGirişToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.muhasebeGirişToolStripMenuItem.Text = "muhasebe giriş";
            this.muhasebeGirişToolStripMenuItem.Click += new System.EventHandler(this.muhasebeGirişToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.güncelleToolStripMenuItem.Text = "güncelle";
            // 
            // cariToolStripMenuItem
            // 
            this.cariToolStripMenuItem.Name = "cariToolStripMenuItem";
            this.cariToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.cariToolStripMenuItem.Text = "cari";
            // 
            // öğenciListeleToolStripMenuItem
            // 
            this.öğenciListeleToolStripMenuItem.Name = "öğenciListeleToolStripMenuItem";
            this.öğenciListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.öğenciListeleToolStripMenuItem.Text = "Öğenci Listele";
            this.öğenciListeleToolStripMenuItem.Click += new System.EventHandler(this.öğenciListeleToolStripMenuItem_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 728);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "frm_menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğenciListeleToolStripMenuItem;
    }
}