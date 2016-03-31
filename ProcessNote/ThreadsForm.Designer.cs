namespace ProcessNote
{
    partial class ThreadsForm
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
            this.threadsBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // threadsBox
            // 
            this.threadsBox.FormattingEnabled = true;
            this.threadsBox.Location = new System.Drawing.Point(12, 12);
            this.threadsBox.Name = "threadsBox";
            this.threadsBox.Size = new System.Drawing.Size(260, 238);
            this.threadsBox.TabIndex = 0;
            // 
            // ThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.threadsBox);
            this.Name = "ThreadsForm";
            this.Text = "ThreadsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox threadsBox;
    }
}