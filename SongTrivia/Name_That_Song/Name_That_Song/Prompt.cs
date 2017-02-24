using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_That_Song
{
    public class Prompt : Form
    {
        public static SongClips ShowDialog(string text)
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
            //MessageBox.Show("Artist: " + artistBox.Text + " Song: " + songBox.Text);
            //return (int)inputBox.Value;
            return new SongClips(artistBox.Text, songBox.Text, text);

        }// showDialod


    }//end of prompt static class
}
