using System;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class InterfaceForm : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        private PlaylistHelper playlistHelper = new PlaylistHelper();
        private Serialisation serialisation = new Serialisation();

        private string filename = "";


        public InterfaceForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
            label1.Visible = false;
            albumLabel.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Visible = true;
                albumLabel.Visible = true;

                if (playlist.SelectedIndex == -1)
                {
                    if (playlist.Items.Count >= 1)
                    {
                        playlist.SelectedIndex = 0;
                    }
                }

                playlistHelper.SetNowPlayingText(playlist, label1);

                var item = playlist.SelectedItem as ListBoxItem;
                TagLib.File tagFile = TagLib.File.Create(item.Path);
                albumLabel.Text = tagFile.Tag.Album;

                mp3Player.open(item.Path);
                mp3Player.play();
            }
            catch
            {
                MessageBox.Show("Not a valid mp3 file!");
            }
        }

        private void skipForwardButton_Click(object sender, EventArgs e)
        {
            try
            {
                mp3Player.stop();
                playlist.SelectedIndex += 1;
                playButton.PerformClick();
            }
            catch
            {
                MessageBox.Show("No more songs available");
            }
        }

        private void skipBackwardsButton_Click(object sender, EventArgs e)
        {
            try
            {
                mp3Player.stop();
                playlist.SelectedIndex -= 1;
                playButton.PerformClick();
            }
            catch
            {
                MessageBox.Show("No more songs available");
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            mp3Player.pause();
            playlistHelper.SetPausedText(playlist, label1);

        }


        private void openMusic_Click(object sender, EventArgs e)
        {
            playlistHelper.addMusic(playlist);
        }


        private void loadButton_Click(object sender, EventArgs e)
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void clearPlaylistButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wish to clear the current playlist?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                mp3Player.stop();
                playlist.Items.Clear();
            }
        }

        private void closeApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = playlist.Items;
            Random shuffle = new Random();
            int w = list.Count;
            playlist.BeginUpdate();
            while (w > 1)
            {
                w--;
                int u = shuffle.Next(w + 1);
                object value = list[u];
                list[u] = list[w];
                list[w] = value;
            }

            playlist.EndUpdate();
            playlist.Invalidate();
        }
    }
}
