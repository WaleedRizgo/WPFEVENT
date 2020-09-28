using System;
using System.Speech.Recognition;
using System.Windows;

namespace TextReading.Audio_and_Video
{
    public partial class SpeechRecognitionTextSample : Window
    {
        public SpeechRecognitionTextSample()
        {
            InitializeComponent();
            SpeechRecognizer speechRecognizer = new SpeechRecognizer();
        }
    }
}