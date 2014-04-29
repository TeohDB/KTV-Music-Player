using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace KTVPlayer
{
    class MusicPlayer
    {
        // Import winmm.dll enable the playing of music files (could be mp3, wma or wav).
        [DllImport("winmm.dll")] 

        //Creates the function mciSendString, which is used to open, play, stop and close a music file in the following functions.
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        //Function used to open a music file. 
        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMp3";
            mciSendString(command, null, 0, 0);
        }
        //Function to make the music file play.
        public void play()
        {
            string command = "play MyMp3";
            mciSendString(command, null, 0, 0);
        }
        //Function to make the music file stop plaing and close the file so a new file can be played if opened. 
        public void stop()
        {
            string command = "stop MyMp3";
            mciSendString(command, null, 0, 0);

            command = "close MyMp3";
            mciSendString(command, null, 0, 0);
        }
    }
}
