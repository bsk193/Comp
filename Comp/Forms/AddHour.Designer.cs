namespace Comp
{
    partial class AddHour
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
            this.lstData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Location = new System.Drawing.Point(13, 13);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(259, 461);
            this.lstData.TabIndex = 0;
            this.lstData.UseCompatibleStateImageBehavior = false;
            // 
            // AddHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 486);
            this.Controls.Add(this.lstData);
            this.Name = "AddHour";
            this.Text = "AddHour";
            this.Load += new System.EventHandler(this.AddHour_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstData;
    }
}