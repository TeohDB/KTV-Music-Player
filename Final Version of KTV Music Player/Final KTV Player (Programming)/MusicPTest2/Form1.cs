using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTVPlayer
{
    public partial class Form1 : Form
    {
        //Adding a new music player from the MusicPlayer class.
        MusicPlayer player = new MusicPlayer();

        //Call the other part of partial class Form1.
        public Form1()
        {
            InitializeComponent();
        }

        //When the first button is clicked the file dialog will open.
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
        //The file description will then be shown in the text of the application's label and the file will be added to the player. 
        //The open () function is created in the MusicPlayer Class.
        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            label2.Text = openFileDialog2.FileName;
            player.open(openFileDialog2.FileName);
        }
        //When the second button is pressed the song will play. The play () function is created in the MusicPlayer Class.
        private void button2_Click(object sender, EventArgs e)
        {
            player.play();
        }
        //Pressing the third button stops the music. The stop () function is created in the MusicPlayer Class.
        private void button3_Click(object sender, EventArgs e)
        {
            player.stop();
        }
    }
}
