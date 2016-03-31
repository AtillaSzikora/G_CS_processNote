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
            this.threadGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.threadGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // threadGridView
            // 
            this.threadGridView.AllowUserToAddRows = false;
            this.threadGridView.AllowUserToDeleteRows = false;
            this.threadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.threadGridView.Location = new System.Drawing.Point(12, 12);
            this.threadGridView.Name = "threadGridView";
            this.threadGridView.ReadOnly = true;
            this.threadGridView.Size = new System.Drawing.Size(408, 237);
            this.threadGridView.TabIndex = 0;
            // 
            // ThreadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.threadGridView);
            this.Name = "ThreadsForm";
            this.Text = "ThreadsForm";
            ((System.ComponentModel.ISupportInitialize)(this.threadGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView threadGridView;
    }
}