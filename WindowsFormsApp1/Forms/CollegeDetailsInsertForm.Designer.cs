using System.Windows.Forms;
using System.Drawing;
namespace TrainingManagementProject.Forms
{
    partial class CollegeDetailsInsertForm
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
            label1 = new Label();
            collegeNameTextbox = new TextBox();
            locationTextbox = new TextBox();
            label2 = new Label();
            remarksTextbox = new TextBox();
            label3 = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "College Name";
            // 
            // collegeNameTextbox
            // 
            collegeNameTextbox.Location = new Point(274, 93);
            collegeNameTextbox.Margin = new Padding(4, 3, 4, 3);
            collegeNameTextbox.Name = "collegeNameTextbox";
            collegeNameTextbox.Size = new Size(344, 23);
            collegeNameTextbox.TabIndex = 1;
            // 
            // locationTextbox
            // 
            locationTextbox.Location = new Point(274, 148);
            locationTextbox.Margin = new Padding(4, 3, 4, 3);
            locationTextbox.Name = "locationTextbox";
            locationTextbox.Size = new Size(344, 23);
            locationTextbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Location";
            // 
            // remarksTextbox
            // 
            remarksTextbox.Location = new Point(274, 207);
            remarksTextbox.Margin = new Padding(4, 3, 4, 3);
            remarksTextbox.Multiline = true;
            remarksTextbox.Name = "remarksTextbox";
            remarksTextbox.Size = new Size(344, 52);
            remarksTextbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Remarks";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(497, 293);
            saveButton.Margin = new Padding(4, 3, 4, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 27);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // CollegeDetailsInsertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(remarksTextbox);
            Controls.Add(locationTextbox);
            Controls.Add(label2);
            Controls.Add(collegeNameTextbox);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CollegeDetailsInsertForm";
            Text = "CollegeDetailsInsertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox collegeNameTextbox;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remarksTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
    }
}