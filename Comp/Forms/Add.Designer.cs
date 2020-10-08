namespace Comp
{
    partial class Add
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(61, 35);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(267, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // lbNumber
            // 
            this.lbNumber.Location = new System.Drawing.Point(12, 38);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(100, 23);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "Number:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(61, 61);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(267, 20);
            this.txtClass.TabIndex = 6;
            // 
            // lbClass
            // 
            this.lbClass.Location = new System.Drawing.Point(12, 64);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(100, 23);
            this.lbClass.TabIndex = 5;
            this.lbClass.Text = "Class";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 127);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lbClass;
    }
}