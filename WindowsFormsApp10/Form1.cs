using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        MyPlayer mp = new MyPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = mp.version(axWindowsMediaPlayer1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.myOpen(axWindowsMediaPlayer1, listBox1);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void полныйЭкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.fullScreen(axWindowsMediaPlayer1);
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.MyPause(axWindowsMediaPlayer1);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.MyStop(axWindowsMediaPlayer1);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.MyPlay(axWindowsMediaPlayer1);
        }

        private void soundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.MyMuteTrue(axWindowsMediaPlayer1);
        }

        private void soundOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.MyMuteFalse(axWindowsMediaPlayer1);
        }

        private void soundUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.SoundUp = 10;
        }

        private void soundDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.SoundDown = 10;
        }

        private void свойстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mp.MyPropeties(axWindowsMediaPlayer1);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            mp.MyClear(axWindowsMediaPlayer1);
        }

        private void listBox1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            listBox1.SelectedIndex++;
        }
    }
}
