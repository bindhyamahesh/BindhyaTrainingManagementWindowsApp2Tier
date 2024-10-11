using System.Windows.Forms;
using System.Drawing;
namespace TrainingManagementProject.Forms
{
    partial class CollegeEditDeleteForms
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
            this.collegeNameCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.remarksTextbox = new System.Windows.Forms.TextBox();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.collegeNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // collegeNameCombobox
            // 
            this.collegeNameCombobox.FormattingEnabled = true;
            this.collegeNameCombobox.Location = new System.Drawing.Point(157, 36);
            this.collegeNameCombobox.Name = "collegeNameCombobox";
            this.collegeNameCombobox.Size = new System.Drawing.Size(253, 21);
            this.collegeNameCombobox.TabIndex = 0;
            this.collegeNameCombobox.SelectedIndexChanged += new System.EventHandler(this.collegeNameCombobox_SelectedIndexChanged);
            this.collegeNameCombobox.SelectionChangeCommitted += new System.EventHandler(this.collegeNameCombobox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select College";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editButton.Location = new System.Drawing.Point(276, 234);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 20);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remarks";
            // 
            // remarksTextbox
            // 
            this.remarksTextbox.Location = new System.Drawing.Point(157, 162);
            this.remarksTextbox.Multiline = true;
            this.remarksTextbox.Name = "remarksTextbox";
            this.remarksTextbox.Size = new System.Drawing.Size(253, 40);
            this.remarksTextbox.TabIndex = 10;
            // 
            // locationTextbox
            // 
            this.locationTextbox.Location = new System.Drawing.Point(157, 118);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(253, 20);
            this.locationTextbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.Location = new System.Drawing.Point(345, 234);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 20);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CollegeName";
            // 
            // collegeNameTextbox
            // 
            this.collegeNameTextbox.Location = new System.Drawing.Point(157, 75);
            this.collegeNameTextbox.Name = "collegeNameTextbox";
            this.collegeNameTextbox.Size = new System.Drawing.Size(253, 20);
            this.collegeNameTextbox.TabIndex = 14;
            // 
            // CollegeEditDeleteForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.collegeNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remarksTextbox);
            this.Controls.Add(this.locationTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collegeNameCombobox);
            this.Name = "CollegeEditDeleteForms";
            this.Text = "CollegeEditDeleteForms";
            this.Load += new System.EventHandler(this.CollegeEditDeleteForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox collegeNameCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remarksTextbox;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox collegeNameTextbox;
    }
}