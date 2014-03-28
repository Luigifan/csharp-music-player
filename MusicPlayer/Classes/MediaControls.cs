using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicPlayer;
using NAudio;
using NAudio.Wave;

namespace MusicPlayer.Classes
{
    /// <summary>
    /// This is the class that contains various methods for playback.
    /// </summary>

    class MediaControls
    {
        public static string playPause = "Pause";

        public static IWavePlayer waveOutDevice;
        public static AudioFileReader audioFileReader;
        //MainForm mf = new MainForm();

        public void beginPlayback(string fileName)
        {
            disposeWave();
            //
            MainForm mf = new MainForm();
            //
            MainForm.currentlyPlaying = fileName;
            audioFileReader = new AudioFileReader(fileName);
            waveOutDevice = new WaveOut();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.PlaybackStopped += new EventHandler<StoppedEventArgs>(waveOutDevice_PlaybackStopped);
            
            /*
            System.Timers.Timer stopTimer = new System.Timers.Timer(500);
            stopTimer.Elapsed += stopTimer_Elapsed;
            stopTimer.Enabled = true;
            stopTimer.Start();*/
            waveOutDevice.Play();
        }

        private void waveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.playNextSong();
        }
        
        public void pausePlayBack()
        {
            if (waveOutDevice != null)
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Playing)
                {
                    MediaControls.waveOutDevice.Pause();
                    playPause = "Play";
                }
                else if (waveOutDevice.PlaybackState == PlaybackState.Paused)
                {
                    MediaControls.waveOutDevice.Play();
                    playPause = "Pause";
                }
            }
        }

        public bool audioComplete()
        {
            if(waveOutDevice.PlaybackState == PlaybackState.Stopped)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public void disposeWave()
        {
            if (waveOutDevice != null)
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Playing) waveOutDevice.Stop();
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
        }
    }
}
