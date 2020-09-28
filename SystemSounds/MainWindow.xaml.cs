using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;


namespace SystemSounds.Audio_and_Video
{



#pragma warning disable format
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class SystemSoundsSample : Window
#pragma warning restore format
    {
        public SystemSoundsSample()
        {
        }


        private void btnAsterisk_Click(object sender, RoutedEventArgs e) => SystemSounds.Asterisk.Play();

        private void btnBeep_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnExclamation_Click(object sender, RoutedEventArgs e)
        {
            Exclamation.Play();
        }

        private void btnHand_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Question.Play();
        }
    }
}