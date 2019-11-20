namespace DesignPattern.View
{
    partial class ComboBoxGen
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
            this.cbGen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbGen
            // 
            this.cbGen.FormattingEnabled = true;
            this.cbGen.Location = new System.Drawing.Point(178, 65);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(219, 21);
            this.cbGen.TabIndex = 0;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 289);
            this.Controls.Add(this.cbGen);
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGen;
    }
}