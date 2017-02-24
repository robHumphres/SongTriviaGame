using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Name_That_Song
{
    public class SongClips
    {
        //Members
        private string Arist_Of_Song;
        private string Song;
        private string fileName;
        private Object songClip;


        public SongClips()
        {
            this.Arist_Of_Song = null;
            this.Song = null;
            this.fileName = null;
            this.songClip = null;
        }

        public SongClips(string Artist, string song,string filename)
        {
            this.Arist_Of_Song = Artist;
            this.Song = song;
            this.fileName = filename;
        }

        public void setFileName(string file)
        {
            this.fileName = file;
        }

        public void setSong(String song)
        {
            this.Song = song;
        }

        public void setArtist_Of_Song(string artist)
        {
            this.Arist_Of_Song = artist;
        }

        public string getArtist_Of_Song()
        {
            return this.Arist_Of_Song;
        }

        public string getFileName()
        {
            return this.fileName;
        }

        public string getSong()
        {
            return this.Song;
        }

        public override string ToString()
        {
            return "Artist: " + this.Arist_Of_Song + " Song: " + this.Song;
        }
    }
}
