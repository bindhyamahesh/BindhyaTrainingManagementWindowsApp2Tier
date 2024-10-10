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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.saveButton.Location = new System.Drawing.Point(356, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 20);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 7;
            // 
            // TraineesInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
    }
}