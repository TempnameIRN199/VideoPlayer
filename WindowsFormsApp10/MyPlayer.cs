using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace WindowsFormsApp10
{
    class MyPlayer
    {
        OpenFileDialog openFileDialog1;
        AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
        String[] FilePath;

        public MyPlayer()
        {
            openFileDialog1 = new OpenFileDialog();
        }

        public string version(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            return "Windows Media Player, ver. = " + axWindowsMediaPlayer1.versionInfo;
        }

        public void myOpen(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1, ListBox listbBox1)
        {
            openFileDialog1.Multiselect = true;
            axWindowsMediaPlayer1.settings.autoStart = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("aa", "");
                foreach (string fn in openFileDialog1.FileNames)
                {
                    FilePath = openFileDialog1.FileNames;
                    listbBox1.Items.Add(Path.GetFileName(fn));
                    axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(fn));
                }
                listbBox1.SelectedIndex = -1;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        public void fullScreen(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        public void playfile(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1, ListBox listBox1)
        {
            if (listBox1.Items.Count <= 0)
            {
                return;
            }
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.URL = FilePath[listBox1.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.next();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        
        public void MyPause(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        public void MyPlay(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        public void MyStop(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        public void MyClear(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.currentPlaylist.clear();
        }

        public int SoundUp
        {
            set
            {
                if (axWindowsMediaPlayer1.settings.volume <= 100)
                    axWindowsMediaPlayer1.settings.volume += value; // не работает
            }
            get { return axWindowsMediaPlayer1.settings.volume; }
        }

        public int SoundDown
        {
            set
            {
                if (axWindowsMediaPlayer1.settings.volume > 0)
                    axWindowsMediaPlayer1 .settings.volume -= value; // не работает
            }
            get { return axWindowsMediaPlayer1.settings.volume; }
        }

        public void MyMuteFalse(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        { 
            axWindowsMediaPlayer1.settings.mute = false; 
        }

        public void MyMuteTrue(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.settings.mute = true;
        }

        public void MyPropeties(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1)
        {
            axWindowsMediaPlayer1.ShowPropertyPages();
        }
    }
}
