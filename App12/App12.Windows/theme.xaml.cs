using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class theme : Page
    {
        public theme()
        {
            this.InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(themeCalculator));
        }

        private void notes_Click(object sender, RoutedEventArgs e)
        {
             Frame.Navigate(typeof(themeNotes));
        }

        private void Stopwatch_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(themeStopwatch));
        }

       

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        
       
        

        



    }
}
