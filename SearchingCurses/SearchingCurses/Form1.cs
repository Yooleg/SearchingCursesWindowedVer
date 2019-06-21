using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingCurses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string artistName;
        

        private void ArtistInput_TextChanged(object sender, EventArgs e)
        {
            artistName = ArtistInput.Text;
        }

        

        private void SongsInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        

    private void btn1_Click(object sender, EventArgs e)
        {
            
            var nameOfArtist = new Artist(artistName);
           
            var list = new List<string>();
            string st;
            string str;
                foreach (var item in ListOfSongs.Items)
                {
                    st = item.ToString();
                    str = Regex.Replace(st, @"\t|\n|\r", "");
                    list.Add(str);
                }
            nameOfArtist.songTitles = list;
            nameOfArtist.CalculateSwearAndWordCount();
            Result.Visible = true;
            Result.ReadOnly = true;
            
            nameOfArtist.DisplayStatistics();
            Result.Text = "";
            Result.Text +=   "For " + artistName + " every " + nameOfArtist.GetProfanityIndex() + " is a swear word.";
            
            
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void SaveSong_Click(object sender, EventArgs e)
        {
            if(this.SongsInput.Text!="")
            {
                ListOfSongs.Items.Add(this.SongsInput.Text);
                this.SongsInput.Focus();
                this.SongsInput.Clear();
            }

        }

        private void ListOfSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SongsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListOfSongs.Items.Add(this.SongsInput.Text);
                this.SongsInput.Focus();
                this.SongsInput.Clear();
                
            }
            
        }

        private void ArtistInput_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = ListOfSongs.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListOfSongs.Items.Remove(ListOfSongs.SelectedItems[i]);
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            ListOfSongs.Items.Clear();
        }
    }
}
