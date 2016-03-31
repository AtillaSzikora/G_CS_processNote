namespace ProcessNote
{
    partial class DetailsForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.cpuBox = new System.Windows.Forms.TextBox();
            this.memoryBox = new System.Windows.Forms.TextBox();
            this.runningTimeBox = new System.Windows.Forms.TextBox();
            this.startTimeBox = new System.Windows.Forms.TextBox();
            this.nameBoxLabel = new System.Windows.Forms.Label();
            this.cpuBoxLabel = new System.Windows.Forms.Label();
            this.memoryBoxLabel = new System.Windows.Forms.Label();
            this.runningTimeBoxLabel = new System.Windows.Forms.Label();
            this.startTimeBoxLabel = new System.Windows.Forms.Label();
            this.threadsButton = new System.Windows.Forms.Button();
            this.threadsButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(133, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(139, 20);
            this.nameBox.TabIndex = 0;
            // 
            // cpuBox
            // 
            this.cpuBox.Enabled = false;
            this.cpuBox.Location = new System.Drawing.Point(133, 38);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(139, 20);
            this.cpuBox.TabIndex = 1;
            // 
            // memoryBox
            // 
            this.memoryBox.Enabled = false;
            this.memoryBox.Location = new System.Drawing.Point(133, 64);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(139, 20);
            this.memoryBox.TabIndex = 2;
            // 
            // runningTimeBox
            // 
            this.runningTimeBox.Enabled = false;
            this.runningTimeBox.Location = new System.Drawing.Point(133, 90);
            this.runningTimeBox.Name = "runningTimeBox";
            this.runningTimeBox.Size = new System.Drawing.Size(139, 20);
            this.runningTimeBox.TabIndex = 3;
            // 
            // startTimeBox
            // 
            this.startTimeBox.Enabled = false;
            this.startTimeBox.Location = new System.Drawing.Point(133, 116);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(139, 20);
            this.startTimeBox.TabIndex = 4;
            // 
            // nameBoxLabel
            // 
            this.nameBoxLabel.AutoSize = true;
            this.nameBoxLabel.Location = new System.Drawing.Point(46, 15);
            this.nameBoxLabel.Name = "nameBoxLabel";
            this.nameBoxLabel.Size = new System.Drawing.Size(38, 13);
            this.nameBoxLabel.TabIndex = 5;
            this.nameBoxLabel.Text = "Name:";
            // 
            // cpuBoxLabel
            // 
            this.cpuBoxLabel.AutoSize = true;
            this.cpuBoxLabel.Location = new System.Drawing.Point(46, 41);
            this.cpuBoxLabel.Name = "cpuBoxLabel";
            this.cpuBoxLabel.Size = new System.Drawing.Size(66, 13);
            this.cpuBoxLabel.TabIndex = 6;
            this.cpuBoxLabel.Text = "CPU Usage:";
            // 
            // memoryBoxLabel
            // 
            this.memoryBoxLabel.AutoSize = true;
            this.memoryBoxLabel.Location = new System.Drawing.Point(46, 67);
            this.memoryBoxLabel.Name = "memoryBoxLabel";
            this.memoryBoxLabel.Size = new System.Drawing.Size(81, 13);
            this.memoryBoxLabel.TabIndex = 7;
            this.memoryBoxLabel.Text = "Memory Usage:";
            // 
            // runningTimeBoxLabel
            // 
            this.runningTimeBoxLabel.AutoSize = true;
            this.runningTimeBoxLabel.Location = new System.Drawing.Point(46, 93);
            this.runningTimeBoxLabel.Name = "runningTimeBoxLabel";
            this.runningTimeBoxLabel.Size = new System.Drawing.Size(76, 13);
            this.runningTimeBoxLabel.TabIndex = 8;
            this.runningTimeBoxLabel.Text = "Running Time:";
            // 
            // startTimeBoxLabel
            // 
            this.startTimeBoxLabel.AutoSize = true;
            this.startTimeBoxLabel.Location = new System.Drawing.Point(46, 119);
            this.startTimeBoxLabel.Name = "startTimeBoxLabel";
            this.startTimeBoxLabel.Size = new System.Drawing.Size(58, 13);
            this.startTimeBoxLabel.TabIndex = 9;
            this.startTimeBoxLabel.Text = "Start Time:";
            // 
            // threadsButton
            // 
            this.threadsButton.Location = new System.Drawing.Point(133, 142);
            this.threadsButton.Name = "threadsButton";
            this.threadsButton.Size = new System.Drawing.Size(139, 20);
            this.threadsButton.TabIndex = 10;
            this.threadsButton.Text = "Show Threads";
            this.threadsButton.UseVisualStyleBackColor = true;
            this.threadsButton.Click += new System.EventHandler(this.threadsButton_Click);
            // 
            // threadsButtonLabel
            // 
            this.threadsButtonLabel.AutoSize = true;
            this.threadsButtonLabel.Location = new System.Drawing.Point(46, 146);
            this.threadsButtonLabel.Name = "threadsButtonLabel";
            this.threadsButtonLabel.Size = new System.Drawing.Size(49, 13);
            this.threadsButtonLabel.TabIndex = 11;
            this.threadsButtonLabel.Text = "Threads:";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.threadsButtonLabel);
            this.Controls.Add(this.threadsButton);
            this.Controls.Add(this.startTimeBoxLabel);
            this.Controls.Add(this.runningTimeBoxLabel);
            this.Controls.Add(this.memoryBoxLabel);
            this.Controls.Add(this.cpuBoxLabel);
            this.Controls.Add(this.nameBoxLabel);
            this.Controls.Add(this.startTimeBox);
            this.Controls.Add(this.runningTimeBox);
            this.Controls.Add(this.memoryBox);
            this.Controls.Add(this.cpuBox);
            this.Controls.Add(this.nameBox);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox cpuBox;
        private System.Windows.Forms.TextBox memoryBox;
        private System.Windows.Forms.TextBox runningTimeBox;
        private System.Windows.Forms.TextBox startTimeBox;
        private System.Windows.Forms.Label nameBoxLabel;
        private System.Windows.Forms.Label cpuBoxLabel;
        private System.Windows.Forms.Label memoryBoxLabel;
        private System.Windows.Forms.Label runningTimeBoxLabel;
        private System.Windows.Forms.Label startTimeBoxLabel;
        private System.Windows.Forms.Button threadsButton;
        private System.Windows.Forms.Label threadsButtonLabel;
    }
}