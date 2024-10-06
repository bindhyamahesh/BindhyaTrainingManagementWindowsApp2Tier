namespace TrainingManagementProject.Forms
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeInsertToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traineeToolStripMenuItem,
            this.traineeToolStripMenuItem1,
            this.batchToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "&Forms";
            // 
            // traineeToolStripMenuItem
            // 
            this.traineeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collegeDetailsToolStripMenuItem,
            this.collegeInsertToolStripMenuItem2,
            this.collegeEditDeleteToolStripMenuItem});
            this.traineeToolStripMenuItem.Name = "traineeToolStripMenuItem";
            this.traineeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traineeToolStripMenuItem.Text = "&College";
            // 
            // collegeDetailsToolStripMenuItem
            // 
            this.collegeDetailsToolStripMenuItem.Name = "collegeDetailsToolStripMenuItem";
            this.collegeDetailsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.collegeDetailsToolStripMenuItem.Text = "College &Details";
            this.collegeDetailsToolStripMenuItem.Click += new System.EventHandler(this.collegeDetailsToolStripMenuItem_Click);
            // 
            // collegeInsertToolStripMenuItem2
            // 
            this.collegeInsertToolStripMenuItem2.Name = "collegeInsertToolStripMenuItem2";
            this.collegeInsertToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.collegeInsertToolStripMenuItem2.Text = "College &Insert";
            this.collegeInsertToolStripMenuItem2.Click += new System.EventHandler(this.collegeInsertToolStripMenuItem2_Click);
            // 
            // collegeEditDeleteToolStripMenuItem
            // 
            this.collegeEditDeleteToolStripMenuItem.Name = "collegeEditDeleteToolStripMenuItem";
            this.collegeEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.collegeEditDeleteToolStripMenuItem.Text = "&College Edit&Delete";
            this.collegeEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.collegeEditDeleteToolStripMenuItem_Click);
            // 
            // traineeToolStripMenuItem1
            // 
            this.traineeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.traineeInsertToolStripMenuItem,
            this.traineeEditDeleteToolStripMenuItem});
            this.traineeToolStripMenuItem1.Name = "traineeToolStripMenuItem1";
            this.traineeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.traineeToolStripMenuItem1.Text = "Trainee";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "&Trainee Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // traineeInsertToolStripMenuItem
            // 
            this.traineeInsertToolStripMenuItem.Name = "traineeInsertToolStripMenuItem";
            this.traineeInsertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traineeInsertToolStripMenuItem.Text = "Trainee &Insert";
            this.traineeInsertToolStripMenuItem.Click += new System.EventHandler(this.traineeInsertToolStripMenuItem_Click);
            // 
            // traineeEditDeleteToolStripMenuItem
            // 
            this.traineeEditDeleteToolStripMenuItem.Name = "traineeEditDeleteToolStripMenuItem";
            this.traineeEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traineeEditDeleteToolStripMenuItem.Text = "Trainee Edit&Delete";
            this.traineeEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.traineeEditDeleteToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batchDetailsToolStripMenuItem,
            this.batchIToolStripMenuItem,
            this.batchEditToolStripMenuItem});
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.batchToolStripMenuItem.Text = "Batch";
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.batchToolStripMenuItem_Click);
            // 
            // batchDetailsToolStripMenuItem
            // 
            this.batchDetailsToolStripMenuItem.Name = "batchDetailsToolStripMenuItem";
            this.batchDetailsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.batchDetailsToolStripMenuItem.Text = "Batch &Details";
            this.batchDetailsToolStripMenuItem.Click += new System.EventHandler(this.batchDetailsToolStripMenuItem_Click);
            // 
            // batchIToolStripMenuItem
            // 
            this.batchIToolStripMenuItem.Name = "batchIToolStripMenuItem";
            this.batchIToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.batchIToolStripMenuItem.Text = "Batch &Insert";
            this.batchIToolStripMenuItem.Click += new System.EventHandler(this.batchIToolStripMenuItem_Click);
            // 
            // batchEditToolStripMenuItem
            // 
            this.batchEditToolStripMenuItem.Name = "batchEditToolStripMenuItem";
            this.batchEditToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.batchEditToolStripMenuItem.Text = "Batch Edit&Delete";
            this.batchEditToolStripMenuItem.Click += new System.EventHandler(this.batchEditToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "training management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collegeInsertToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem collegeEditDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeEditDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchEditToolStripMenuItem;
    }
}