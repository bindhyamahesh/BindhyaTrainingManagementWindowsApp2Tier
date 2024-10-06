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
            traineesDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)traineesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // traineesDataGrid
            // 
            traineesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            traineesDataGrid.Location = new Point(12, 12);
            traineesDataGrid.Name = "traineesDataGrid";
            traineesDataGrid.Size = new Size(690, 307);
            traineesDataGrid.TabIndex = 0;
            // 
            // TraineesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(traineesDataGrid);
            Name = "TraineesForm";
            Text = "TraineesForm";
            Load += TraineesForm_Load;
            ((System.ComponentModel.ISupportInitialize)traineesDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView traineesDataGrid;
    }
}