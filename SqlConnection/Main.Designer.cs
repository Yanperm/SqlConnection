namespace SqlConnections
{
    partial class Main
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
            this.ตงคาระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ระบบงานในแผนกไอทToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ตงคาระบบToolStripMenuItem,
            this.ระบบงานในแผนกไอทToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ตงคาระบบToolStripMenuItem
            // 
            this.ตงคาระบบToolStripMenuItem.Name = "ตงคาระบบToolStripMenuItem";
            this.ตงคาระบบToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ตงคาระบบToolStripMenuItem.Text = "ตั้งค่าระบบ";
            // 
            // ระบบงานในแผนกไอทToolStripMenuItem
            // 
            this.ระบบงานในแผนกไอทToolStripMenuItem.Name = "ระบบงานในแผนกไอทToolStripMenuItem";
            this.ระบบงานในแผนกไอทToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.ระบบงานในแผนกไอทToolStripMenuItem.Text = "ระบบงานในแผนกไอที";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main Page : หน้าหลักระบบงาน";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ตงคาระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ระบบงานในแผนกไอทToolStripMenuItem;
    }
}

