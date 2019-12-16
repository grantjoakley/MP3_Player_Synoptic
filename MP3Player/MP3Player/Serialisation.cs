using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MP3Player
{
    public class Serialisation
    {

        public void SetFilenames(ListBox listbox, string path)
        {
            var item = new ListBoxItem();
            path.Replace("'", "\\'");
            var nowplaying = Path.GetFileNameWithoutExtension(path);
            item.Text = nowplaying;
            item.Name = nowplaying;
            item.Path = path;

            listbox.Items.Add(item);
        }
    }
}

