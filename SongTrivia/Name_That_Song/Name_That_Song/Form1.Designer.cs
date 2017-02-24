namespace Name_That_Song
{
    partial class Form1
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
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_SelectFile = new System.Windows.Forms.Label();
            this.button_Select_File = new System.Windows.Forms.Button();
            this.folderBrowserDialog_Select_Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.button_startGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Location = new System.Drawing.Point(218, 9);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(148, 13);
            this.label_Welcome.TabIndex = 1;
            this.label_Welcome.Text = "Welcome to Name That Song\r\n";
            // 
            // label_SelectFile
            // 
            this.label_SelectFile.AutoSize = true;
            this.label_SelectFile.Location = new System.Drawing.Point(172, 234);
            this.label_SelectFile.Name = "label_SelectFile";
            this.label_SelectFile.Size = new System.Drawing.Size(242, 26);
            this.label_SelectFile.TabIndex = 2;
            this.label_SelectFile.Text = "Please Select a File from below to start the game, \r\n             Then press play" +
    " to start the game! \r\n";
            // 
            // button_Select_File
            // 
            this.button_Select_File.Location = new System.Drawing.Point(221, 283);
            this.button_Select_File.Name = "button_Select_File";
            this.button_Select_File.Size = new System.Drawing.Size(145, 23);
            this.button_Select_File.TabIndex = 3;
            this.button_Select_File.Text = "Click here to open a file";
            this.button_Select_File.UseVisualStyleBackColor = true;
            this.button_Select_File.Click += new System.EventHandler(this.button_Select_File_Click);
            // 
            // button_startGame
            // 
            this.button_startGame.Location = new System.Drawing.Point(221, 357);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(145, 46);
            this.button_startGame.TabIndex = 4;
            this.button_startGame.Text = "Start the game";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Name_That_Song.Properties.Resources.musicTrivia;
            this.pictureBox1.Location = new System.Drawing.Point(203, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 176);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_startGame);
            this.Controls.Add(this.button_Select_File);
            this.Controls.Add(this.label_SelectFile);
            this.Controls.Add(this.label_Welcome);
            this.Name = "Form1";
            this.Text = "Name That Song?!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_SelectFile;
        private System.Windows.Forms.Button button_Select_File;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Select_Folder;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

