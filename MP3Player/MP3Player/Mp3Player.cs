using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    public class Mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder IpstrReturnString, int uReturnLength, int hwdCallBack);

        public long open(string file)
        {
            string command = $"open \"{file}\" type MPEGVideo alias MyMp3";
            return mciSendString(command, null, 0, 0);
        }

        public long play()
        {
            string command = "play MyMp3";
            return mciSendString(command, null, 0, 0);
        }

        public long stop()
        {
            string command = "close MyMp3";
            return mciSendString(command, null, 0, 0);
        }

        public long pause()
        {
            string command = "pause MyMp3";
            return mciSendString(command, null, 0, 0);
        }

    }
}
