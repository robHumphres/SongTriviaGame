using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Name_That_Song.Properties;

namespace Name_That_Song
{
    public partial class GamePlay : Form
    {

        //members
        private string _folder, _currentPlayingSong, songPath;
        private int _filesInFolder, _filesCompleted, livesLeft = 3,radioButtonHasRealSong,pointsCount=0;
        private LinkedList<SongClips> songs = new LinkedList<SongClips>();
        private WMPLib.WindowsMediaPlayer wplayer;
        private LinkedList<string> songsAlreadyPlayed = new LinkedList<string>();
        private bool mediaPlaying = false,firstTime = true;
        private bool submitClicked = false;
        private static Random rnd = new Random();
        
        //rnd.Next(1, 6)
        
        



        //used to carry data from formWait to GamePlay

        




        public GamePlay()
        {
            InitializeComponent();
            button_Submit_Button.Enabled = false;
        }

       

        private void PlayGame()
        {
            SetRadiosTrue();
            //SetRadioButtons();
            playMusic.Enabled = false;
            button_Submit_Button.Enabled = true;
            submitClicked = false;
            PickRandomSong();
        }

        private void GameOver()
        {
            //MessageBox.Show("The game is over. Looks Like you lost. You scored " + label_Change_Actual_Points + " points though!" );
            DialogResult dialogResult = MessageBox.Show("The game is over. Looks Like you lost. You scored " + label_Change_Actual_Points.ToString() + " points though!" +
                Environment.NewLine + " Would you like to play again?", "Game Over", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                /*GamePlay form = new GamePlay();
                form.Closed += (s, args) => this.Close();
                form.Show();
                */
                this.Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void StopGame()
        {
            if (livesLeft == 0)
                GameOver();
            CheckForIllegalCrossThreadCalls = false;
            playMusic.Enabled = true;
            button_Submit_Button.Enabled = false;
            mediaPlaying = false;
            playMusic.Text = "Start next round";
            wplayer.controls.stop();
            //AddSongtoAlreadyPlayed();
            SetRadiosFalse();
            setRadiosToBlank();
            if (!submitClicked)
            {
                label_Lives_to_Change.Text = livesLeft.ToString();
                livesLeft--;
                submitClicked = false;
            }
        }


        private void PickRandomSong()
        {
            //Random rnd = new Random();
            int tempRandomNumber = rnd.Next(1, songs.Count());//randomInt(1, songs.Count());
            int tempRandomRadioButton = radioButtonHasRealSong = rnd.Next(1, 4);
            int tempCounter = 0;
            foreach (SongClips s in songs)
            {
                if (tempCounter == tempRandomNumber)
                {
                    _currentPlayingSong = s.getSong();
                    label_CheatSheet.Text = s.getSong();
                    songPath = s.getFileName();
                    switch (tempRandomRadioButton)
                    {
                        case 1: radioButton_SongName1.Text = s.getSong();
                            break;
                        case 2:
                            radioButton_SongName2.Text = s.getSong();
                            break;
                        case 3:
                            radioButton_SongName3.Text = s.getSong();
                            break;
                        case 4:
                            radioButton_SongName4.Text = s.getSong();
                            break;

                    }// switch

                    

                }//if
                tempCounter++;
            }//for each
            SetRadioButtons();
        }//end of void PickRandomSong


        private void AddSongtoAlreadyPlayed()
        {
            songsAlreadyPlayed.AddLast(_currentPlayingSong);
        }

        private void playMusic_Click(object sender, EventArgs e)
        {
            PlayGame();
            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = _folder+ "\\"+songPath;//_folder + "\\Alice In Chains - I Stay Away.mp3";


            if (mediaPlaying == false)
            {
                wplayer.controls.play();
                mediaPlaying = true;
                // PlayGame();
                new Thread(() =>
                {
                    int count = 15;
                    while (count!=0)
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Thread.Sleep(1000);
                        if (submitClicked == true) break;
                        count--;
                    }

                    if (count == 0)
                    {
                        wplayer.controls.stop();
                        StopGame();
                    }
                }).Start();
            }//mediaPlaying 

            new Thread(() =>
            {
                    Thread.CurrentThread.IsBackground = true;
                    int count = 15;
                    while (count != -1)
                    {
                        ChangePictureBox(count);
                        pictureBox_SecondsRemaining.Invalidate();
                        Thread.Sleep(1000);
                        count--;
                        if (submitClicked == true) break;
                    }
                   
            }).Start();





        }//end of playMusic_Click

        //Could DEFINITELY IMPROVE THIS!!! Possibly take Count.toString()+".png");
        private void ChangePictureBox(int count)
        {
            pictureBox_SecondsRemaining.Image = new Bitmap(count.ToString()+".png");   
        }


        private void SetRadiosTrue()
        {
            radioButton_SongName1.Enabled = true;
            radioButton_SongName2.Enabled = true;
            radioButton_SongName3.Enabled = true;
            radioButton_SongName4.Enabled = true;   
        }

        private void SetRadiosFalse()
        {
            radioButton_SongName1.Enabled = false;
            radioButton_SongName2.Enabled = false;
            radioButton_SongName3.Enabled = false;
            radioButton_SongName4.Enabled = false;
        }

        private void setRadiosToBlank()
        {
            radioButton_SongName1.Text = "Ready";
            radioButton_SongName2.Text = "For";
            radioButton_SongName3.Text = "Next";
            radioButton_SongName4.Text = "Round?!";
        }

        private void SetRadioButtons()
        {
            int count = 1;
            foreach (SongClips s in songs)
            {
                if (!(s.getSong().Equals(radioButton_SongName1.Text) && !(s.getSong().Equals(radioButton_SongName2.Text)) && !(s.getSong().Equals(radioButton_SongName3.Text)) && !(s.getSong().Equals(radioButton_SongName4.Text))))
                {

                    if (count == 1 && count != radioButtonHasRealSong)
                        radioButton_SongName1.Text = s.getSong();
                    if (count == 2 && count != radioButtonHasRealSong)
                        radioButton_SongName2.Text = s.getSong();
                    if (count == 3 && count != radioButtonHasRealSong)
                        radioButton_SongName3.Text = s.getSong();
                    if (count == 4 && count != radioButtonHasRealSong)
                    {
                        radioButton_SongName4.Text = s.getSong();
                        break;
                    }
                    count++;
                }
                if (songs.Count < 4)
                    SetRadioButtons_WithAlreadyPlayed();
                SetRadiosTrue();

            }//end of duplicates 

            }//SetRadioButtons


        private void SetRadioButtons_WithAlreadyPlayed()
        {
            foreach(String s in songsAlreadyPlayed)
            {
                bool putIn = false;
                //Check Duplicates for the First
                if(radioButton_SongName1.Equals(radioButton_SongName2) || radioButton_SongName1.Equals(radioButton_SongName3) || radioButton_SongName1.Equals(radioButton_SongName4) || radioButton_SongName1.Equals("Ready"))
                {
                    radioButton_SongName1.Text = s;
                    putIn = true;
                }
                //Checks for dups in 3 and 4
                if(radioButton_SongName2.Equals(radioButton_SongName3) || radioButton_SongName2.Equals(radioButton_SongName4) || radioButton_SongName2.Equals("For"))
                {
                    if (!putIn)
                        radioButton_SongName2.Text = s;
                }

                if (radioButton_SongName3.Equals(radioButton_SongName4) || radioButton_SongName3.Equals("Next"))
                {
                    if (!putIn)
                        radioButton_SongName3.Text = s;
                }

                if (radioButton_SongName4.Equals("Round?!"))
                {
                    if (!putIn)
                        radioButton_SongName4.Text = s;
                }
                
            }// for each
        }


        private void formClosing(object sender, FormClosedEventArgs e)
        {
            wplayer.close();
        }

        

        public void SetFolderLocation(string s)
        {
            this._folder = s;
            //MessageBox.Show("did it transfer? " + s);//debug statement


            //Update files inside because gets called too fast if in initalize components
            update_How_Many_Files_Label();

            ParseFiles();

        }

        public void update_How_Many_Files_Label()
        {
            int fileCount = 0;
            try
            {
                if (_folder != null) fileCount = Directory.GetFiles(_folder).Length;
            }
            catch (Exception e)
            {
                this.Hide();
                //MessageBox.Show("Error Getting File Count (inside update how many files label method)");
                Form1 form = new Form1();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }

            

            _filesInFolder = fileCount;
            //UpdateCount();
        }


        public void ParseFiles()
        {
            DirectoryInfo d = new DirectoryInfo(_folder);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.mp3"); //Getting .mp3 files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                char[] delimit = { '-' };
                string[] words = str.Split(delimit);
                try
                {
                    songs.AddLast(new SongClips(words[0], words[1].Substring(0, words[1].Length - 3), str));
                }
                catch (IndexOutOfRangeException e)
                {
                    //popup custom dialog box, and have the user fix it, then continue on.
                    SongClips n = Prompt.ShowDialog(str);
                    //MessageBox.Show("this is outside that box." + n.ToString());
                    songs.AddLast(n);
                }
            }
        }//end of parse

        private void button_Submit_Button_Click(object sender, EventArgs e)
        {
            submitClicked = true;
            StopGame();
            if (songs.Count() <= 1)
            {
                MessageBox.Show("Congrats!!!! You Sure Know your songs!!");
                Application.Exit();
            }

            if (radioButton_SongName1.Checked && 1 == radioButtonHasRealSong)
            {
               ChangePoints();
            }
            else if(radioButton_SongName2.Checked && 2 == radioButtonHasRealSong)
            {
                ChangePoints();
            }
            else if (radioButton_SongName3.Checked && 3 == radioButtonHasRealSong)
            {
                ChangePoints();
            }
            else if (radioButton_SongName4.Checked && 4 == radioButtonHasRealSong)
            {
                ChangePoints();
            }

            else
            {
                livesLeft--;
                label_Lives_to_Change.Text = livesLeft.ToString();
            }

            AddtoSongsAlreadyPlayed();
            UpdateSongsLinkedList();
        }

        private void AddtoSongsAlreadyPlayed()
        {
            songsAlreadyPlayed.AddLast(_currentPlayingSong);
        }

        private void UpdateSongsLinkedList()
        {
            LinkedList<SongClips> tempLinked = new LinkedList<SongClips>();
            foreach (SongClips s in songs)
            {
                if (!(s.getSong().Equals(_currentPlayingSong)))
                {
                    tempLinked.AddLast(new SongClips(s.getArtist_Of_Song(), s.getSong(), s.getFileName()));
                }
            }//for each
            songs = tempLinked;
        }

        private void ChangePoints()
        {
          
                MessageBox.Show("You answered correctly.");
                pointsCount += 5;
                label_Change_Actual_Points.Text = pointsCount.ToString();
           
        }




    }//end of class

    

    
}
