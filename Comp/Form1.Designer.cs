namespace Comp
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
            this.lvData = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registHourToOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalHoursToOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalCompensatedHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvData
            // 
            this.lvData.Location = new System.Drawing.Point(12, 27);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(193, 366);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.hoursToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(217, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuMain";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "New";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // hoursToolStripMenuItem
            // 
            this.hoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registHourToOffsetToolStripMenuItem,
            this.registToolStripMenuItem});
            this.hoursToolStripMenuItem.Name = "hoursToolStripMenuItem";
            this.hoursToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hoursToolStripMenuItem.Text = "Hours";
            // 
            // registHourToOffsetToolStripMenuItem
            // 
            this.registHourToOffsetToolStripMenuItem.Name = "registHourToOffsetToolStripMenuItem";
            this.registHourToOffsetToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.registHourToOffsetToolStripMenuItem.Text = "Register hours to offset";
            // 
            // registToolStripMenuItem
            // 
            this.registToolStripMenuItem.Name = "registToolStripMenuItem";
            this.registToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.registToolStripMenuItem.Text = "Regiser compensated hours";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalHoursToOffsetToolStripMenuItem,
            this.totalCompensatedHoursToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // totalHoursToOffsetToolStripMenuItem
            // 
            this.totalHoursToOffsetToolStripMenuItem.Name = "totalHoursToOffsetToolStripMenuItem";
            this.totalHoursToOffsetToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.totalHoursToOffsetToolStripMenuItem.Text = "Total Hours to Offset";
            // 
            // totalCompensatedHoursToolStripMenuItem
            // 
            this.totalCompensatedHoursToolStripMenuItem.Name = "totalCompensatedHoursToolStripMenuItem";
            this.totalCompensatedHoursToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.totalCompensatedHoursToolStripMenuItem.Text = "Total Compensated Hours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 405);
            this.Controls.Add(this.lvData);
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

        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registHourToOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalHoursToOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalCompensatedHoursToolStripMenuItem;
    }
}

