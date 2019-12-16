using System.IO;
using System.Windows.Forms;

namespace MP3Player
{
    public class PlaylistHelper
    {
        Serialisation serialisation = new Serialisation();

        public void SetNowPlayingText(ListBox playlist, Label label)
        {
            var playing = Path.GetFileName(playlist.SelectedItem.ToString());
            label.Text = $"Now Playing:    { playing }";
        }

        public void SetPausedText(ListBox playlist, Label label)
        {
            var paused = Path.GetFileName(playlist.SelectedItem.ToString());
            label.Text = $"Currently Paused: { paused }";
        }

        public void addMusic(ListBox playlist)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Music (*.mp3) | *.mp3";
            dlg.Multiselect = true;
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    foreach (var file in dlg.FileNames)
                    {
                        serialisation.SetFilenames(playlist, file);
                    }
                }
                catch
                {
                    MessageBox.Show("Could not add this file");
                }
            }
        }

    }
}

