namespace TrainingManagementProject.Forms
{
    partial class BatchInsertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.batchNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.endDateCalender = new System.Windows.Forms.MonthCalendar();
            this.startDateTextbox = new System.Windows.Forms.TextBox();
            this.endDateTextbox = new System.Windows.Forms.TextBox();
            this.tentativeEndDateTextbox = new System.Windows.Forms.TextBox();
            this.tentativeEndDateCalender = new System.Windows.Forms.MonthCalendar();
            this.feesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.feesPaidTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.durationTextbox = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.Label();
            this.hoursTakentextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.detailsTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.remarksTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batch Name";
            // 
            // batchNameTextBox
            // 
            this.batchNameTextBox.Location = new System.Drawing.Point(166, 39);
            this.batchNameTextBox.Name = "batchNameTextBox";
            this.batchNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.batchNameTextBox.TabIndex = 1;
            this.batchNameTextBox.TextChanged += new System.EventHandler(this.batchNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TentativeEndDate";
            // 
            // startDateCalendar
            // 
            this.startDateCalendar.Location = new System.Drawing.Point(566, -3);
            this.startDateCalendar.Name = "startDateCalendar";
            this.startDateCalendar.TabIndex = 6;
            this.startDateCalendar.Visible = false;
            this.startDateCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.startDateCalendar_DateSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End Date";
            // 
            // endDateCalender
            // 
            this.endDateCalender.Location = new System.Drawing.Point(566, 135);
            this.endDateCalender.Name = "endDateCalender";
            this.endDateCalender.TabIndex = 8;
            this.endDateCalender.Visible = false;
            this.endDateCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.endDateCalender_DateSelected);
            // 
            // startDateTextbox
            // 
            this.startDateTextbox.Location = new System.Drawing.Point(166, 73);
            this.startDateTextbox.Name = "startDateTextbox";
            this.startDateTextbox.Size = new System.Drawing.Size(122, 20);
            this.startDateTextbox.TabIndex = 9;
            this.startDateTextbox.Click += new System.EventHandler(this.startDateTextbox_Click);
            this.startDateTextbox.TextChanged += new System.EventHandler(this.startDateTextbox_TextChanged);
            // 
            // endDateTextbox
            // 
            this.endDateTextbox.Location = new System.Drawing.Point(370, 73);
            this.endDateTextbox.Name = "endDateTextbox";
            this.endDateTextbox.Size = new System.Drawing.Size(122, 20);
            this.endDateTextbox.TabIndex = 10;
            this.endDateTextbox.Click += new System.EventHandler(this.endDateTextbox_Click);
            // 
            // tentativeEndDateTextbox
            // 
            this.tentativeEndDateTextbox.Location = new System.Drawing.Point(166, 113);
            this.tentativeEndDateTextbox.Name = "tentativeEndDateTextbox";
            this.tentativeEndDateTextbox.Size = new System.Drawing.Size(122, 20);
            this.tentativeEndDateTextbox.TabIndex = 11;
            this.tentativeEndDateTextbox.Click += new System.EventHandler(this.tentativeEndDateTextbox_Click);
            // 
            // tentativeEndDateCalender
            // 
            this.tentativeEndDateCalender.Location = new System.Drawing.Point(566, 270);
            this.tentativeEndDateCalender.Name = "tentativeEndDateCalender";
            this.tentativeEndDateCalender.TabIndex = 12;
            this.tentativeEndDateCalender.Visible = false;
            this.tentativeEndDateCalender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.tentativeEndDateCalender_DateSelected);
            // 
            // feesTextBox
            // 
            this.feesTextBox.Location = new System.Drawing.Point(166, 148);
            this.feesTextBox.Name = "feesTextBox";
            this.feesTextBox.Size = new System.Drawing.Size(122, 20);
            this.feesTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fees";
            // 
            // feesPaidTextBox
            // 
            this.feesPaidTextBox.Location = new System.Drawing.Point(166, 187);
            this.feesPaidTextBox.Name = "feesPaidTextBox";
            this.feesPaidTextBox.Size = new System.Drawing.Size(122, 20);
            this.feesPaidTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "FeesPaid";
            // 
            // durationTextbox
            // 
            this.durationTextbox.Location = new System.Drawing.Point(166, 222);
            this.durationTextbox.Name = "durationTextbox";
            this.durationTextbox.Size = new System.Drawing.Size(122, 20);
            this.durationTextbox.TabIndex = 18;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(65, 225);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(47, 13);
            this.Duration.TabIndex = 17;
            this.Duration.Text = "Duration";
            // 
            // hoursTakentextBox
            // 
            this.hoursTakentextBox.Location = new System.Drawing.Point(166, 257);
            this.hoursTakentextBox.Name = "hoursTakentextBox";
            this.hoursTakentextBox.Size = new System.Drawing.Size(122, 20);
            this.hoursTakentextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hours Taken";
            // 
            // detailsTextbox
            // 
            this.detailsTextbox.Location = new System.Drawing.Point(166, 295);
            this.detailsTextbox.Multiline = true;
            this.detailsTextbox.Name = "detailsTextbox";
            this.detailsTextbox.Size = new System.Drawing.Size(326, 38);
            this.detailsTextbox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Details";
            // 
            // remarksTextbox
            // 
            this.remarksTextbox.Location = new System.Drawing.Point(166, 349);
            this.remarksTextbox.Multiline = true;
            this.remarksTextbox.Name = "remarksTextbox";
            this.remarksTextbox.Size = new System.Drawing.Size(326, 38);
            this.remarksTextbox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Remarks";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(370, 408);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // BatchInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.remarksTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.detailsTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hoursTakentextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.durationTextbox);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.feesPaidTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.feesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tentativeEndDateCalender);
            this.Controls.Add(this.tentativeEndDateTextbox);
            this.Controls.Add(this.endDateTextbox);
            this.Controls.Add(this.startDateTextbox);
            this.Controls.Add(this.endDateCalender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDateCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.batchNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BatchInsertForm";
            this.Text = "BatchInsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox batchNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar startDateCalendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar endDateCalender;
        private System.Windows.Forms.TextBox startDateTextbox;
        private System.Windows.Forms.TextBox endDateTextbox;
        private System.Windows.Forms.TextBox tentativeEndDateTextbox;
        private System.Windows.Forms.MonthCalendar tentativeEndDateCalender;
        private System.Windows.Forms.TextBox feesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox feesPaidTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox durationTextbox;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TextBox hoursTakentextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox detailsTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox remarksTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveButton;
    }
}