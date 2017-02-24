using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_That_Song
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_startGame.Visible = false;
        }


        /*
         * 
         * 
         *http://www.dotnetperls.com/listbox shows how to use list box
         *http://stackoverflow.com/questions/366124/inserting-a-tab-character-into-text-using-c-sharp putting a tab for formatting scores
         *put in sqlite again for keeping the highscores
         * 
         */
        private void button_Select_File_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog_Select_Folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show("You clicked okay and the file you clicked was.... " + folderBrowserDialog_Select_Folder.SelectedPath);
                button_startGame.Visible = true;
            }

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You need to select a file before you can star the game.");
            }

        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            button_startGame.Enabled = false;
            GamePlay form = new GamePlay();
            form.SetFolderLocation(folderBrowserDialog_Select_Folder.SelectedPath);
            form.Closed += (s, args) => this.Close(); 
            form.Show();
        }
    }
}
