using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_That_Song
{
    public partial class waitForm : Form
    {

        //Members
        private string _folder;
        private int _filesInFolder,_filesCompleted;
        private LinkedList<SongClips> songs = new LinkedList<SongClips>(); 




        public waitForm()
        {
            InitializeComponent();
            
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

           // var fileCoun = 
            
            _filesInFolder = fileCount;
            UpdateCount();
        }

        public void UpdateCount()
        {
                this.Label_files_Completed.Text = "     "+ _filesCompleted + " Files out of "+ _filesInFolder + Environment.NewLine + "have been completed";     
        }

        public void SetFolderLocation(string s)
        {
            this._folder = s;
            MessageBox.Show("did it transfer? "  + s);//debug statement


            //Update files inside because gets called too fast if in initalize components
            update_How_Many_Files_Label();
            
            ParseFiles();

        }
        //http://stackoverflow.com/questions/14877237/getting-all-file-names-from-a-folder-using-c-sharp
        public void ParseFiles()
        {
            DirectoryInfo d = new DirectoryInfo(_folder);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.mp3"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                char[] delimit = {'-'};
                string[] words = str.Split(delimit);
                try
                {
                    songs.AddLast(new SongClips(words[0], words[1].Substring(0, words[1].Length - 3), str));
                }catch(IndexOutOfRangeException e){
                  //popup custom dialog box, and have the user fix it, then continue on.
                    //int n = Prompt.ShowDialog(str);
                }
            } 
        }// ParseFiles


    }// partial class


    /*public static class Prompt
    {
        public static int ShowDialog(string text)
        {
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 300;
            //prompt.Text = caption;
            Label textlabelExplaination = new Label() { Left = 5, Top = 20, Width = 150, Text = "Enter Artist and Song name" };
            Label textLabel = new Label() { Left = 140, Top = 20, Width = 400, Text = text };
            Label textAristBox = new Label() { Left = 5, Top = 50, Width = 50, Text = "Artist: " };
            Label textSongBox = new Label() { Left = 5, Top = 75, Width = 50, Text = "Song: " };
            TextBox artistBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
            TextBox songBox = new TextBox() { Left = 50, Top = 75, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 100 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(artistBox);
            prompt.Controls.Add(songBox);
            prompt.Controls.Add(textlabelExplaination);
            prompt.Controls.Add(textAristBox);
            prompt.Controls.Add(textSongBox);




            prompt.ShowDialog();
            MessageBox.Show("Artist: " + artistBox.Text + " Song: " + songBox.Text);
            //return (int)inputBox.Value;
            return 0;

        }// showDialod


    }//end of prompt static class
     * */

}
