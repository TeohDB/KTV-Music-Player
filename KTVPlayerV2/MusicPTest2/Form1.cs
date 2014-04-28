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
        MusicPlayer player = new MusicPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            label2.Text = openFileDialog2.FileName;
            player.open(openFileDialog2.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.stop();
        }
    }
}
