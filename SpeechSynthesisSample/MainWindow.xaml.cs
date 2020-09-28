using System;
using System.Speech.Synthesis;
using System.Windows;

namespace SpeechSynthesisSample.Audio_and_Video
{
    public partial class SpeechSynthesisSample : Window
    {
        public SpeechSynthesisSample()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak("Hallo Waleed!, Welcome to your project");
        }
    }
}