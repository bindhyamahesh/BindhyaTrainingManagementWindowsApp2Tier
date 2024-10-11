using System.Drawing;
using System.Windows.Forms;
namespace TrainingManagementProject.Forms
{
    partial class TraineesInsertForm
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
            this.collegesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.traineeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.traineeLocationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.traineeEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.traineePhoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yesRadiobutton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // collegesComboBox
            // 
            this.collegesComboBox.FormattingEnabled = true;
            this.collegesComboBox.Location = new System.Drawing.Point(110, 29);
            this.collegesComboBox.Name = "collegesComboBox";
            this.collegesComboBox.Size = new System.Drawing.Size(284, 21);
            this.collegesComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "College";
            // 
            // traineeNameTextBox
            // 
            this.traineeNameTextBox.Location = new System.Drawing.Point(110, 55);
            this.traineeNameTextBox.Name = "traineeNameTextBox";
            this.traineeNameTextBox.Size = new System.Drawing.Size(284, 20);
            this.traineeNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trainee Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(280, 230);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 20);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trainee Location";
            // 
            // traineeLocationTextBox
            // 
            this.traineeLocationTextBox.Location = new System.Drawing.Point(110, 87);
            this.traineeLocationTextBox.Name = "traineeLocationTextBox";
            this.traineeLocationTextBox.Size = new System.Drawing.Size(284, 20);
            this.traineeLocationTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // traineeEmailTextBox
            // 
            this.traineeEmailTextBox.Location = new System.Drawing.Point(110, 120);
            this.traineeEmailTextBox.Name = "traineeEmailTextBox";
            this.traineeEmailTextBox.Size = new System.Drawing.Size(284, 20);
            this.traineeEmailTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone";
            // 
            // traineePhoneTextBox
            // 
            this.traineePhoneTextBox.Location = new System.Drawing.Point(110, 156);
            this.traineePhoneTextBox.Name = "traineePhoneTextBox";
            this.traineePhoneTextBox.Size = new System.Drawing.Size(284, 20);
            this.traineePhoneTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Discountinue";
            // 
            // yesRadiobutton
            // 
            this.yesRadiobutton.AutoSize = true;
            this.yesRadiobutton.Location = new System.Drawing.Point(110, 197);
            this.yesRadiobutton.Name = "yesRadiobutton";
            this.yesRadiobutton.Size = new System.Drawing.Size(43, 17);
            this.yesRadiobutton.TabIndex = 12;
            this.yesRadiobutton.TabStop = true;
            this.yesRadiobutton.Text = "Yes";
            this.yesRadiobutton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(213, 197);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(39, 17);
            this.NoRadioButton.TabIndex = 13;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // TraineesInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.yesRadiobutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.traineePhoneTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.traineeEmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.traineeLocationTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.traineeNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collegesComboBox);
            this.Name = "TraineesInsertForm";
            this.Text = "TraineesInsertForm";
            this.Load += new System.EventHandler(this.TraineesInsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox collegesComboBox;
        private Label label1;
        private TextBox traineeNameTextBox;
        private Label label2;
        private Button saveButton;
        private Label label3;
        private TextBox traineeLocationTextBox;
        private Label label4;
        private TextBox traineeEmailTextBox;
        private Label label5;
        private TextBox traineePhoneTextBox;
        private Label label6;
        private RadioButton yesRadiobutton;
        private RadioButton NoRadioButton;
    }
}