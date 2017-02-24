namespace Name_That_Song
{
    partial class waitForm
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
            this.label_Please_Wait = new System.Windows.Forms.Label();
            this.progressBar_Files_Completed = new System.Windows.Forms.ProgressBar();
            this.Label_files_Completed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Please_Wait
            // 
            this.label_Please_Wait.AutoSize = true;
            this.label_Please_Wait.Location = new System.Drawing.Point(201, 48);
            this.label_Please_Wait.Name = "label_Please_Wait";
            this.label_Please_Wait.Size = new System.Drawing.Size(165, 13);
            this.label_Please_Wait.TabIndex = 0;
            this.label_Please_Wait.Text = "Please wait for the Files to load....";
            // 
            // progressBar_Files_Completed
            // 
            this.progressBar_Files_Completed.Location = new System.Drawing.Point(37, 129);
            this.progressBar_Files_Completed.Name = "progressBar_Files_Completed";
            this.progressBar_Files_Completed.Size = new System.Drawing.Size(474, 23);
            this.progressBar_Files_Completed.TabIndex = 1;
            // 
            // Label_files_Completed
            // 
            this.Label_files_Completed.AutoSize = true;
            this.Label_files_Completed.Location = new System.Drawing.Point(220, 100);
            this.Label_files_Completed.Name = "Label_files_Completed";
            this.Label_files_Completed.Size = new System.Drawing.Size(110, 26);
            this.Label_files_Completed.TabIndex = 2;
            this.Label_files_Completed.Text = "     0 Files out of 0 \r\nhave been completed";
            // 
            // waitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 230);
            this.Controls.Add(this.Label_files_Completed);
            this.Controls.Add(this.progressBar_Files_Completed);
            this.Controls.Add(this.label_Please_Wait);
            this.Name = "waitForm";
            this.Text = "waitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Please_Wait;
        private System.Windows.Forms.ProgressBar progressBar_Files_Completed;
        private System.Windows.Forms.Label Label_files_Completed;
    }
}