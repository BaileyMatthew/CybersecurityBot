using System;
using NAudio.Wave;

namespace CybersecurityBot.Bot
{
    public static class VoicePlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                using (AudioFileReader audioFile = new AudioFileReader("ChatBot.wav"))
                using (WaveOutEvent outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Error playing voice greeting: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}
