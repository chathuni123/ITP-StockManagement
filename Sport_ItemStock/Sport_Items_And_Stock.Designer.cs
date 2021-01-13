namespace Sport_ItemStock
{
    partial class Sport_Items_And_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sport_Items_And_Stock));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reoderRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reports = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDetailsToolStripMenuItem,
            this.stockDetailsToolStripMenuItem,
            this.reoderRequestToolStripMenuItem,
            this.Reports,
            this.reportsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1284, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // itemDetailsToolStripMenuItem
            // 
            this.itemDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemDetailsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDetailsToolStripMenuItem.Name = "itemDetailsToolStripMenuItem";
            this.itemDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.itemDetailsToolStripMenuItem.Size = new System.Drawing.Size(328, 40);
            this.itemDetailsToolStripMenuItem.Text = "                             Item Details";
            this.itemDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemDetailsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.itemDetailsToolStripMenuItem.Click += new System.EventHandler(this.itemDetailsToolStripMenuItem_Click);
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.stockDetailsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 4, 10);
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(326, 40);
            this.stockDetailsToolStripMenuItem.Text = "                           Stock Details";
            this.stockDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
            // 
            // reoderRequestToolStripMenuItem
            // 
            this.reoderRequestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.reoderRequestToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reoderRequestToolStripMenuItem.Name = "reoderRequestToolStripMenuItem";
            this.reoderRequestToolStripMenuItem.Size = new System.Drawing.Size(313, 40);
            this.reoderRequestToolStripMenuItem.Text = "                     Reoder Request";
            this.reoderRequestToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reoderRequestToolStripMenuItem.Click += new System.EventHandler(this.reoderRequestToolStripMenuItem_Click);
            // 
            // Reports
            // 
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(12, 40);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 680);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1284, 28);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(56, 23);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 636);
            this.panel1.TabIndex = 4;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDetailsToolStripMenuItem1});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(225, 40);
            this.reportsToolStripMenuItem.Text = "                    Reports";
            // 
            // itemDetailsToolStripMenuItem1
            // 
            this.itemDetailsToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemDetailsToolStripMenuItem1.Name = "itemDetailsToolStripMenuItem1";
            this.itemDetailsToolStripMenuItem1.Size = new System.Drawing.Size(232, 28);
            this.itemDetailsToolStripMenuItem1.Text = "Item Deteils Report";
            this.itemDetailsToolStripMenuItem1.Click += new System.EventHandler(this.itemDetailsToolStripMenuItem1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(10, 499);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 100);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(10, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 100);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 299);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SK STUDIO";
            // 
            // Sport_Items_And_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Sport_Items_And_Stock";
            this.Text = "Sport_Items_And_Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem itemDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reoderRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reports;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDetailsToolStripMenuItem1;
    }
}



