﻿namespace Trainingmanagement.Forms
{
    partial class BatchDetailsForm
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
            this.batchDetailsDatagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.batchDetailsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // batchDetailsDatagrid
            // 
            this.batchDetailsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batchDetailsDatagrid.Location = new System.Drawing.Point(-1, 3);
            this.batchDetailsDatagrid.Name = "batchDetailsDatagrid";
            this.batchDetailsDatagrid.Size = new System.Drawing.Size(893, 406);
            this.batchDetailsDatagrid.TabIndex = 0;
            this.batchDetailsDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.batchDetailsDatagrid_CellContentClick);
            // 
            // BatchDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 415);
            this.Controls.Add(this.batchDetailsDatagrid);
            this.Name = "BatchDetailsForm";
            this.Text = "BatchDetailsForm";
            this.Load += new System.EventHandler(this.BatchDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchDetailsDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView batchDetailsDatagrid;
    }
}