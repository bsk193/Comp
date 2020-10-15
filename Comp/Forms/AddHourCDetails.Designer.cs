namespace Comp
{
    partial class AddHourCDetails
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
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.numericQuarter = new System.Windows.Forms.NumericUpDown();
            this.lbSHour = new System.Windows.Forms.Label();
            this.lbEHour = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.numericMStart = new System.Windows.Forms.NumericUpDown();
            this.numericHStart = new System.Windows.Forms.NumericUpDown();
            this.numericMEnding = new System.Windows.Forms.NumericUpDown();
            this.numericHEnding = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMEnding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHEnding)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSubject
            // 
            this.lbSubject.Location = new System.Drawing.Point(12, 9);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(50, 23);
            this.lbSubject.TabIndex = 0;
            this.lbSubject.Text = "Subject:";
            // 
            // lbQuarter
            // 
            this.lbQuarter.Location = new System.Drawing.Point(127, 10);
            this.lbQuarter.Name = "lbQuarter";
            this.lbQuarter.Size = new System.Drawing.Size(46, 23);
            this.lbQuarter.TabIndex = 2;
            this.lbQuarter.Text = "Quarter:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.comboSubject.Location = new System.Drawing.Point(68, 6);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(53, 21);
            this.comboSubject.TabIndex = 7;
            // 
            // numericQuarter
            // 
            this.numericQuarter.Location = new System.Drawing.Point(179, 6);
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
            // lbSHour
            // 
            this.lbSHour.Location = new System.Drawing.Point(12, 47);
            this.lbSHour.Name = "lbSHour";
            this.lbSHour.Size = new System.Drawing.Size(71, 19);
            this.lbSHour.TabIndex = 11;
            this.lbSHour.Text = "Starting Hour";
            // 
            // lbEHour
            // 
            this.lbEHour.Location = new System.Drawing.Point(179, 49);
            this.lbEHour.Name = "lbEHour";
            this.lbEHour.Size = new System.Drawing.Size(76, 19);
            this.lbEHour.TabIndex = 14;
            this.lbEHour.Text = "Ending Hours";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(264, 6);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(81, 20);
            this.datePicker.TabIndex = 17;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(221, 8);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(37, 23);
            this.lbDate.TabIndex = 18;
            this.lbDate.Text = "Date:";
            // 
            // numericMStart
            // 
            this.numericMStart.Location = new System.Drawing.Point(134, 44);
            this.numericMStart.Name = "numericMStart";
            this.numericMStart.Size = new System.Drawing.Size(39, 20);
            this.numericMStart.TabIndex = 13;
            // 
            // numericHStart
            // 
            this.numericHStart.Location = new System.Drawing.Point(89, 44);
            this.numericHStart.Name = "numericHStart";
            this.numericHStart.Size = new System.Drawing.Size(39, 20);
            this.numericHStart.TabIndex = 12;
            // 
            // numericMEnding
            // 
            this.numericMEnding.Location = new System.Drawing.Point(306, 47);
            this.numericMEnding.Name = "numericMEnding";
            this.numericMEnding.Size = new System.Drawing.Size(39, 20);
            this.numericMEnding.TabIndex = 16;
            // 
            // numericHEnding
            // 
            this.numericHEnding.Location = new System.Drawing.Point(261, 47);
            this.numericHEnding.Name = "numericHEnding";
            this.numericHEnding.Size = new System.Drawing.Size(39, 20);
            this.numericHEnding.TabIndex = 15;
            // 
            // AddHourCDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 123);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.numericMEnding);
            this.Controls.Add(this.numericHEnding);
            this.Controls.Add(this.lbEHour);
            this.Controls.Add(this.numericMStart);
            this.Controls.Add(this.numericHStart);
            this.Controls.Add(this.lbSHour);
            this.Controls.Add(this.numericQuarter);
            this.Controls.Add(this.comboSubject);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbQuarter);
            this.Controls.Add(this.lbSubject);
            this.Name = "AddHourCDetails";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.AddHourCDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMEnding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHEnding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbQuarter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.NumericUpDown numericQuarter;
        private System.Windows.Forms.Label lbSHour;
        private System.Windows.Forms.Label lbEHour;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.NumericUpDown numericMStart;
        private System.Windows.Forms.NumericUpDown numericHStart;
        private System.Windows.Forms.NumericUpDown numericMEnding;
        private System.Windows.Forms.NumericUpDown numericHEnding;
    }
}