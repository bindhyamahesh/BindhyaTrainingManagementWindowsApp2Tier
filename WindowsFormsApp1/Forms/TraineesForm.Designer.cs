using System.Windows.Forms;
using System.Drawing;
namespace TrainingManagementProject.Forms
{
    partial class TraineesForm
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
            this.traineesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.traineesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // traineesDataGrid
            // 
            this.traineesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineesDataGrid.Location = new System.Drawing.Point(10, 10);
            this.traineesDataGrid.Name = "traineesDataGrid";
            this.traineesDataGrid.Size = new System.Drawing.Size(893, 473);
            this.traineesDataGrid.TabIndex = 0;
            // 
            // TraineesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 495);
            this.Controls.Add(this.traineesDataGrid);
            this.Name = "TraineesForm";
            this.Text = "TraineesForm";
            this.Load += new System.EventHandler(this.TraineesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traineesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView traineesDataGrid;
    }
}