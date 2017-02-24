namespace Name_That_Song
{
    partial class GamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            this.radioButton_SongName1 = new System.Windows.Forms.RadioButton();
            this.radioButton_SongName2 = new System.Windows.Forms.RadioButton();
            this.radioButton_SongName3 = new System.Windows.Forms.RadioButton();
            this.radioButton_SongName4 = new System.Windows.Forms.RadioButton();
            this.playMusic = new System.Windows.Forms.Button();
            this.pictureBox_SecondsRemaining = new System.Windows.Forms.PictureBox();
            this.button_Submit_Button = new System.Windows.Forms.Button();
            this.label_Points = new System.Windows.Forms.Label();
            this.label_Change_Actual_Points = new System.Windows.Forms.Label();
            this.label_Lives = new System.Windows.Forms.Label();
            this.label_Lives_to_Change = new System.Windows.Forms.Label();
            this.label_CheatSheet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SecondsRemaining)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_SongName1
            // 
            this.radioButton_SongName1.AutoSize = true;
            this.radioButton_SongName1.Enabled = false;
            this.radioButton_SongName1.Location = new System.Drawing.Point(226, 189);
            this.radioButton_SongName1.Name = "radioButton_SongName1";
            this.radioButton_SongName1.Size = new System.Drawing.Size(114, 17);
            this.radioButton_SongName1.TabIndex = 0;
            this.radioButton_SongName1.TabStop = true;
            this.radioButton_SongName1.Text = "radioButton_Artist1";
            this.radioButton_SongName1.UseVisualStyleBackColor = true;
            // 
            // radioButton_SongName2
            // 
            this.radioButton_SongName2.AutoSize = true;
            this.radioButton_SongName2.Enabled = false;
            this.radioButton_SongName2.Location = new System.Drawing.Point(226, 227);
            this.radioButton_SongName2.Name = "radioButton_SongName2";
            this.radioButton_SongName2.Size = new System.Drawing.Size(114, 17);
            this.radioButton_SongName2.TabIndex = 1;
            this.radioButton_SongName2.TabStop = true;
            this.radioButton_SongName2.Text = "radioButton_Artist2";
            this.radioButton_SongName2.UseVisualStyleBackColor = true;
            // 
            // radioButton_SongName3
            // 
            this.radioButton_SongName3.AutoSize = true;
            this.radioButton_SongName3.Enabled = false;
            this.radioButton_SongName3.Location = new System.Drawing.Point(226, 265);
            this.radioButton_SongName3.Name = "radioButton_SongName3";
            this.radioButton_SongName3.Size = new System.Drawing.Size(85, 17);
            this.radioButton_SongName3.TabIndex = 2;
            this.radioButton_SongName3.TabStop = true;
            this.radioButton_SongName3.Text = "radioButton3";
            this.radioButton_SongName3.UseVisualStyleBackColor = true;
            // 
            // radioButton_SongName4
            // 
            this.radioButton_SongName4.AutoSize = true;
            this.radioButton_SongName4.Enabled = false;
            this.radioButton_SongName4.Location = new System.Drawing.Point(226, 300);
            this.radioButton_SongName4.Name = "radioButton_SongName4";
            this.radioButton_SongName4.Size = new System.Drawing.Size(85, 17);
            this.radioButton_SongName4.TabIndex = 3;
            this.radioButton_SongName4.TabStop = true;
            this.radioButton_SongName4.Text = "radioButton4";
            this.radioButton_SongName4.UseVisualStyleBackColor = true;
            // 
            // playMusic
            // 
            this.playMusic.Location = new System.Drawing.Point(211, 370);
            this.playMusic.Name = "playMusic";
            this.playMusic.Size = new System.Drawing.Size(114, 23);
            this.playMusic.TabIndex = 5;
            this.playMusic.Text = "Start Round";
            this.playMusic.UseVisualStyleBackColor = true;
            this.playMusic.Click += new System.EventHandler(this.playMusic_Click);
            // 
            // pictureBox_SecondsRemaining
            // 
            this.pictureBox_SecondsRemaining.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SecondsRemaining.Image")));
            this.pictureBox_SecondsRemaining.Location = new System.Drawing.Point(211, 35);
            this.pictureBox_SecondsRemaining.Name = "pictureBox_SecondsRemaining";
            this.pictureBox_SecondsRemaining.Size = new System.Drawing.Size(144, 134);
            this.pictureBox_SecondsRemaining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SecondsRemaining.TabIndex = 6;
            this.pictureBox_SecondsRemaining.TabStop = false;
            // 
            // button_Submit_Button
            // 
            this.button_Submit_Button.Location = new System.Drawing.Point(211, 400);
            this.button_Submit_Button.Name = "button_Submit_Button";
            this.button_Submit_Button.Size = new System.Drawing.Size(114, 23);
            this.button_Submit_Button.TabIndex = 7;
            this.button_Submit_Button.Text = "Submit";
            this.button_Submit_Button.UseVisualStyleBackColor = true;
            this.button_Submit_Button.Click += new System.EventHandler(this.button_Submit_Button_Click);
            // 
            // label_Points
            // 
            this.label_Points.AutoSize = true;
            this.label_Points.Location = new System.Drawing.Point(502, 35);
            this.label_Points.Name = "label_Points";
            this.label_Points.Size = new System.Drawing.Size(39, 13);
            this.label_Points.TabIndex = 8;
            this.label_Points.Text = "Points:";
            // 
            // label_Change_Actual_Points
            // 
            this.label_Change_Actual_Points.AutoSize = true;
            this.label_Change_Actual_Points.Location = new System.Drawing.Point(513, 58);
            this.label_Change_Actual_Points.Name = "label_Change_Actual_Points";
            this.label_Change_Actual_Points.Size = new System.Drawing.Size(13, 13);
            this.label_Change_Actual_Points.TabIndex = 9;
            this.label_Change_Actual_Points.Text = "0";
            // 
            // label_Lives
            // 
            this.label_Lives.AutoSize = true;
            this.label_Lives.Location = new System.Drawing.Point(379, 35);
            this.label_Lives.Name = "label_Lives";
            this.label_Lives.Size = new System.Drawing.Size(65, 13);
            this.label_Lives.TabIndex = 10;
            this.label_Lives.Text = "   Lives Left:";
            // 
            // label_Lives_to_Change
            // 
            this.label_Lives_to_Change.AutoSize = true;
            this.label_Lives_to_Change.Location = new System.Drawing.Point(408, 58);
            this.label_Lives_to_Change.Name = "label_Lives_to_Change";
            this.label_Lives_to_Change.Size = new System.Drawing.Size(13, 13);
            this.label_Lives_to_Change.TabIndex = 11;
            this.label_Lives_to_Change.Text = "3";
            // 
            // label_CheatSheet
            // 
            this.label_CheatSheet.AutoSize = true;
            this.label_CheatSheet.Location = new System.Drawing.Point(32, 189);
            this.label_CheatSheet.Name = "label_CheatSheet";
            this.label_CheatSheet.Size = new System.Drawing.Size(35, 13);
            this.label_CheatSheet.TabIndex = 12;
            this.label_CheatSheet.Text = "label1";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 498);
            this.Controls.Add(this.label_CheatSheet);
            this.Controls.Add(this.label_Lives_to_Change);
            this.Controls.Add(this.label_Lives);
            this.Controls.Add(this.label_Change_Actual_Points);
            this.Controls.Add(this.label_Points);
            this.Controls.Add(this.button_Submit_Button);
            this.Controls.Add(this.pictureBox_SecondsRemaining);
            this.Controls.Add(this.playMusic);
            this.Controls.Add(this.radioButton_SongName4);
            this.Controls.Add(this.radioButton_SongName3);
            this.Controls.Add(this.radioButton_SongName2);
            this.Controls.Add(this.radioButton_SongName1);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SecondsRemaining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_SongName1;
        private System.Windows.Forms.RadioButton radioButton_SongName2;
        private System.Windows.Forms.RadioButton radioButton_SongName3;
        private System.Windows.Forms.RadioButton radioButton_SongName4;
        private System.Windows.Forms.Button playMusic;
        private System.Windows.Forms.PictureBox pictureBox_SecondsRemaining;
        private System.Windows.Forms.Button button_Submit_Button;
        private System.Windows.Forms.Label label_Points;
        private System.Windows.Forms.Label label_Change_Actual_Points;
        private System.Windows.Forms.Label label_Lives;
        private System.Windows.Forms.Label label_Lives_to_Change;
        private System.Windows.Forms.Label label_CheatSheet;
    }
}