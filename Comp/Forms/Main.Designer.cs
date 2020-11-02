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
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quarter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remains = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registHourToOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.quarter,
            this.subject,
            this.date,
            this.startHour,
            this.endHour,
            this.remains});
            this.lvData.Location = new System.Drawing.Point(12, 27);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(538, 366);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 75;
            // 
            // quarter
            // 
            this.quarter.Text = "Quarter";
            this.quarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quarter.Width = 75;
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            this.subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subject.Width = 75;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 75;
            // 
            // startHour
            // 
            this.startHour.Text = "Start Hour";
            this.startHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startHour.Width = 75;
            // 
            // endHour
            // 
            this.endHour.Text = "End Hour";
            this.endHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endHour.Width = 75;
            // 
            // remains
            // 
            this.remains.Text = "Remaining";
            this.remains.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.remains.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.hoursToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
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
            this.createToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.createToolStripMenuItem.Text = "New";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
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
            this.registHourToOffsetToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.registHourToOffsetToolStripMenuItem.Text = "Register hours to compensate";
            this.registHourToOffsetToolStripMenuItem.Click += new System.EventHandler(this.registHourToOffsetToolStripMenuItem_Click);
            // 
            // registToolStripMenuItem
            // 
            this.registToolStripMenuItem.Name = "registToolStripMenuItem";
            this.registToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.registToolStripMenuItem.Text = "Regiser compensated hours";
            this.registToolStripMenuItem.Click += new System.EventHandler(this.registToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // totalsToolStripMenuItem
            // 
            this.totalsToolStripMenuItem.Name = "totalsToolStripMenuItem";
            this.totalsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.totalsToolStripMenuItem.Text = "Totals";
            this.totalsToolStripMenuItem.Click += new System.EventHandler(this.totalsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 405);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quarter;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader startHour;
        private System.Windows.Forms.ColumnHeader endHour;
        private System.Windows.Forms.ColumnHeader remains;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalsToolStripMenuItem;
    }
}

