namespace DesignPattern.View
{
    partial class GridData
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
            this.dtgGen1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGen1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGen1
            // 
            this.dtgGen1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGen1.Location = new System.Drawing.Point(3, 2);
            this.dtgGen1.Name = "dtgGen1";
            this.dtgGen1.Size = new System.Drawing.Size(794, 451);
            this.dtgGen1.TabIndex = 0;
            // 
            // GridData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 358);
            this.Controls.Add(this.dtgGen1);
            this.Name = "GridData";
            this.Text = "GridData";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGen1;
    }
}