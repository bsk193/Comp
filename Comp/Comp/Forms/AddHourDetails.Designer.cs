namespace Comp
{
    partial class AddHourDetails
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
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbQuarter = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbHoras = new System.Windows.Forms.Label();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.numericQuarter = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSubject
            // 
            this.lbSubject.Location = new System.Drawing.Point(12, 9);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(100, 23);
            this.lbSubject.TabIndex = 0;
            this.lbSubject.Text = "Subject:";
            // 
            // lbQuarter
            // 
            this.lbQuarter.Location = new System.Drawing.Point(99, 9);
            this.lbQuarter.Name = "lbQuarter";
            this.lbQuarter.Size = new System.Drawing.Size(100, 23);
            this.lbQuarter.TabIndex = 2;
            this.lbQuarter.Text = "Quarter:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbHoras
            // 
            this.lbHoras.Location = new System.Drawing.Point(188, 9);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(45, 19);
            this.lbHoras.TabIndex = 5;
            this.lbHoras.Text = "Hours";
            // 
            // comboSubject
            // 
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Items.AddRange(new object[] {
            "PT",
            "ING",
            "TIC",
            "EF",
            "AI",
            "FQ",
            "MAT",
            "PSI",
            "SO",
            "AC",
            "RC"});
            this.comboSubject.Location = new System.Drawing.Point(61, 9);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(32, 21);
            this.comboSubject.TabIndex = 7;
            // 
            // numericQuarter
            // 
            this.numericQuarter.Location = new System.Drawing.Point(146, 9);
            this.numericQuarter.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericQuarter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuarter.Name = "numericQuarter";
            this.numericQuarter.Size = new System.Drawing.Size(36, 20);
            this.numericQuarter.TabIndex = 8;
            this.numericQuarter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(273, 9);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // AddHourDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 92);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericQuarter);
            this.Controls.Add(this.comboSubject);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbQuarter);
            this.Controls.Add(this.lbSubject);
            this.Name = "AddHourDetails";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbQuarter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.NumericUpDown numericQuarter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}