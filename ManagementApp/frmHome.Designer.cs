namespace ManagementApp
{
    partial class frmHome
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
            this.empToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardAndPenaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.posToolStripMenuItem,
            this.certificateToolStripMenuItem,
            this.regulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empToolStripMenuItem
            // 
            this.empToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagementToolStripMenuItem,
            this.rewardAndPenaltyToolStripMenuItem});
            this.empToolStripMenuItem.Name = "empToolStripMenuItem";
            this.empToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.empToolStripMenuItem.Text = "Employee";
            // 
            // employeeManagementToolStripMenuItem
            // 
            this.employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            this.employeeManagementToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.employeeManagementToolStripMenuItem.Text = "Employee Management";
            this.employeeManagementToolStripMenuItem.Click += new System.EventHandler(this.employeeManagementToolStripMenuItem_Click);
            // 
            // rewardAndPenaltyToolStripMenuItem
            // 
            this.rewardAndPenaltyToolStripMenuItem.Name = "rewardAndPenaltyToolStripMenuItem";
            this.rewardAndPenaltyToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.rewardAndPenaltyToolStripMenuItem.Text = "Reward And Penalty";
            this.rewardAndPenaltyToolStripMenuItem.Click += new System.EventHandler(this.rewardAndPenaltyToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // posToolStripMenuItem
            // 
            this.posToolStripMenuItem.Name = "posToolStripMenuItem";
            this.posToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.posToolStripMenuItem.Text = "Position";
            this.posToolStripMenuItem.Click += new System.EventHandler(this.posToolStripMenuItem_Click);
            // 
            // certificateToolStripMenuItem
            // 
            this.certificateToolStripMenuItem.Name = "certificateToolStripMenuItem";
            this.certificateToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.certificateToolStripMenuItem.Text = "Certificate";
            this.certificateToolStripMenuItem.Click += new System.EventHandler(this.certificateToolStripMenuItem_Click);
            // 
            // regulationToolStripMenuItem
            // 
            this.regulationToolStripMenuItem.Name = "regulationToolStripMenuItem";
            this.regulationToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.regulationToolStripMenuItem.Text = "Regulation";
            this.regulationToolStripMenuItem.Click += new System.EventHandler(this.regulationToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 628);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewardAndPenaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regulationToolStripMenuItem;
    }
}