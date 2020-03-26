using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Stopwatch : Page
    {
        private DispatcherTimer timer;
        private DateTime startTime = DateTime.MinValue;
        private TimeSpan currentElapsedTime = TimeSpan.Zero;
        private TimeSpan totalElapsedTime = TimeSpan.Zero;
        private bool timerRunning = false;

        public Stopwatch()
        {
           this.InitializeComponent();
           
            timer = new DispatcherTimer();
            timer.Interval =TimeSpan.FromMilliseconds(1000); 
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender,object e)
        {
            var timeSinceStartTime = DateTime.Now - startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Days, timeSinceStartTime.Hours, timeSinceStartTime.Minutes, timeSinceStartTime.Seconds, timeSinceStartTime.Milliseconds);
            currentElapsedTime = timeSinceStartTime + totalElapsedTime;
            text2.Text = currentElapsedTime.ToString();
            text1.Text = timeSinceStartTime.ToString();
        }

        private void backbutton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (timerRunning == false)
            {
                startTime = DateTime.Now;
                totalElapsedTime = currentElapsedTime;
                timer.Start();
                timerRunning = true;
            }
            else 
            {
                timer.Stop();
                timerRunning = false;
                MyList.Items.Add(text1.Text);
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            timerRunning = false;
            totalElapsedTime = TimeSpan.Zero;
            currentElapsedTime = TimeSpan.Zero;
            text1.Text = "00:00:00.00000";
            text2.Text = "00:00:00.00000";
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MyList.SelectedItems)
            {
                MyList.Items.Remove(item);

            }
        }

        private void Deleteall_Click(object sender, RoutedEventArgs e)
        {
            MyList.Items.Clear();
        }

    }
}
