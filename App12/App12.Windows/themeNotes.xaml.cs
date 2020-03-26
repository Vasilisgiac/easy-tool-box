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
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class themeNotes : Page
    {
        int z = 0;

        public themeNotes()
        {
            this.InitializeComponent();
            //Windows.Storage.ApplicationData.Current.ClearAsync(Windows.Storage.ApplicationDataLocality.Local);
            if (ApplicationData.Current.LocalSettings.Values["Quantity"] != null)
            {
                int w = (int)ApplicationData.Current.LocalSettings.Values["Quantity"];
                for (int i = 0; i <= w; i++)
                {
                    if (ApplicationData.Current.LocalSettings.Values["Text" + i] != null && ApplicationData.Current.LocalSettings.Values["Color" + i] != null)
                    {
                        ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri(ApplicationData.Current.LocalSettings.Values["Color" + i].ToString())), Stretch = Stretch.Fill };
                        TextBox x = new TextBox();
                        x.Height = 250;
                        x.Width = 250;
                        x.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
                        x.Padding = new Thickness(21, 61, 5, 5);
                        x.Margin = new Thickness(5, 5, 5, 5);
                        x.Background = background;
                        x.FontSize = 10;
                        x.HorizontalContentAlignment = HorizontalAlignment.Left;
                        x.VerticalContentAlignment = VerticalAlignment.Top;
                        x.TextWrapping = TextWrapping.Wrap;
                        x.IsReadOnly = true;
                        x.Text = ApplicationData.Current.LocalSettings.Values["Text" + i].ToString();
                        GridView1.Items.Add(x);
                    }
                }
            }
            if (ApplicationData.Current.LocalSettings.Values["Quantity"] != null)
            {
                z = (int)ApplicationData.Current.LocalSettings.Values["Quantity"];
            }
            else
                z = 0;
            
        }
        TextBox y = new TextBox();


        private void backbutton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Save.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Close.Visibility = Windows.UI.Xaml.Visibility.Visible;
            GridView1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            text1.Text = "";
            GridView1.SelectedIndex = -1;
            Bar.IsOpen = false;
            Colorbar.IsOpen = true;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (GridView1.SelectedIndex > -1)
            {
                text1.Visibility = Windows.UI.Xaml.Visibility.Visible;

                Save.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Close.Visibility = Windows.UI.Xaml.Visibility.Visible;
                GridView1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Bar.IsOpen = false;
                Colorbar.IsOpen = true;
                y = (TextBox)GridView1.SelectedItem;
                text1.Background = y.Background;
                //y.Name = GridView1.SelectedValuePath.ToString();

                if (y.Text == null)
                {
                    text1.Text = "";

                }
                else
                    text1.Text = y.Text;

            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Bar.IsOpen = false;
            Colorbar.IsOpen = false;
            if (GridView1.SelectedIndex > -1)
            {

                y.Text = text1.Text;
                //y.Background = text1.Background;
                text1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Save.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Close.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                GridView1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                text1.Text = "";
                ApplicationData.Current.LocalSettings.Values["Text" + GridView1.SelectedIndex] = y.Text;
                //ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = text1.Tag.ToString();
                GridView1.SelectedIndex = -1;
            }
            else
            {
                TextBox x = new TextBox();
                x.Height = 250;
                x.Width = 250;
                x.Padding = new Thickness(21, 61, 5, 5);
                x.Margin = new Thickness(5, 5, 5, 5);
                x.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
                x.Background = text1.Background;
                x.HorizontalContentAlignment = HorizontalAlignment.Left;
                x.VerticalContentAlignment = VerticalAlignment.Top;
                x.TextWrapping = TextWrapping.Wrap;
                x.IsReadOnly = true;
                x.Name = z.ToString();
                x.FontSize= 10;



                x.Text = text1.Text;
                GridView1.Items.Add(x);
                text1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Save.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Close.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                GridView1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                text1.Text = "";
                ApplicationData.Current.LocalSettings.Values["Text" + z] = x.Text;
                ApplicationData.Current.LocalSettings.Values["Color" + z] = text1.Tag.ToString();
                z++;
                ApplicationData.Current.LocalSettings.Values["Quantity"] = z;


            }

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            text1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            text2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            text3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Save.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            Close.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            GridView1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Colorbar.IsOpen = false;
            Bar.IsOpen = false;
            GridView1.SelectedIndex = -1;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Bar.IsOpen = false;
            Colorbar.IsOpen = false;
            if (GridView1.SelectedIndex > -1)
            {
                ApplicationData.Current.LocalSettings.Values.Remove("Text" + GridView1.SelectedIndex);
                ApplicationData.Current.LocalSettings.Values.Remove("Color" + GridView1.SelectedIndex);
                for (int i = GridView1.SelectedIndex; i < GridView1.Items.Count - 1; i++)
                {
                    ApplicationData.Current.LocalSettings.Values["Text" + i] = ApplicationData.Current.LocalSettings.Values["Text" + (i + 1)];
                    ApplicationData.Current.LocalSettings.Values["Color" + i] = ApplicationData.Current.LocalSettings.Values["Color" + (i + 1)];
                }
                ApplicationData.Current.LocalSettings.Values.Remove("Text" + (GridView1.Items.Count - 1));
                ApplicationData.Current.LocalSettings.Values.Remove("Color" + (GridView1.Items.Count - 1));
                z--;
                ApplicationData.Current.LocalSettings.Values["Quantity"] = z;
                GridView1.Items.Remove(GridView1.SelectedItem);
            }

        }

        private void text1_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                text1.Text = text1.Text + '\n';
                text1.SelectionStart = text1.Text.Length;
            }
        }

        private void Full_Click(object sender, RoutedEventArgs e)
        {
            Bar.IsOpen = false;
            Colorbar.IsOpen = false;
            if (GridView1.SelectedIndex > -1)
            {
                GridView1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                text2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Close.Visibility = Windows.UI.Xaml.Visibility.Visible;
                y = (TextBox)GridView1.SelectedItem;
                text2.Background = y.Background;

                if (y.Text == null)
                {
                    text2.Text = "";

                }
                else
                {

                    text2.Text = y.Text;
                }
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Bar.IsOpen = false;
            Colorbar.IsOpen = false;
            text3.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Close.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void GridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GridView1.SelectedIndex > -1)
            {
                Bar.IsOpen = true;
                Colorbar.IsOpen = true;

            }
            if (GridView1.SelectedIndex == -1)
            {
                Bar.IsOpen = false;
                Colorbar.IsOpen = false;
            }

        }

        private async void Clearall_Click(object sender, RoutedEventArgs e)
        {
            if (z != 0)
            {
                MessageDialog messageDialog = new MessageDialog("All the saved notes will be deleted!", "Warning!");
                messageDialog.Commands.Add(new UICommand("OK", new UICommandInvokedHandler(this.CommandInvokedHandler)));
                messageDialog.Commands.Add(new UICommand("Cancel"));
                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 1;
                await messageDialog.ShowAsync();
            }

        }

        private async void CommandInvokedHandler(IUICommand command)
        {
            GridView1.Items.Clear();
            await Windows.Storage.ApplicationData.Current.ClearAsync(Windows.Storage.ApplicationDataLocality.Local);
        }

     
        private void Color1_Click(object sender, RoutedEventArgs e)
        {
            //Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/red.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/red.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/red.png";
            }
        }
        private void Color2_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/orangered.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/orangered.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/orangered.png";
            }
        }

        private void Color3_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/aqua.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/aqua.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/aqua.png";
            }
        }

        private void Color4_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/lightgreen.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/lightgreen.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/lightgreen.png";
            }
        }

        private void Color5_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/lightsalmon.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/lightsalmon.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/lightsalmon.png";
            }
        }

        private void Color6_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/hotpink.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/hotpink.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/hotpink.png";
            }
        }
        private void Color7_Click(object sender, RoutedEventArgs e)
        {
          //  Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/goldenrod.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/goldenrod.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/goldenrod.png";
            }
        }

        private void Color8_Click(object sender, RoutedEventArgs e)
        {
          //  Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/greenyellow.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/greenyellow.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/greenyellow.png";
            }
        }
        private void Color9_Click(object sender, RoutedEventArgs e)
        {
            //Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/indianred.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/indianred.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/indianred.png";
            }
        }
        private void Color10_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/lawngreen.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/lawngreen.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/lawngreen.png";
            }
        }
        private void Color11_Click(object sender, RoutedEventArgs e)
        {
            //Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/orchid.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/orchid.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/orchid.png";
            }
        }
        private void Color12_Click(object sender, RoutedEventArgs e)
        {
            //Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/tomato.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/tomato.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/tomato.png";
            }
        }
        private void Color13_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/dodgerblue.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/dodgerblue.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/dodgerblue.png";
            }
        }
        private void Color14_Click(object sender, RoutedEventArgs e)
        {
           // Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/steelblue.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/steelblue.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/steelblue.png";
            }
        }
        private void Color15_Click(object sender, RoutedEventArgs e)
        {
            //Colorbar.IsOpen = false;
            ImageBrush background = new ImageBrush { ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/coral.png")), Stretch = Stretch.Fill };
            if (GridView1.SelectedIndex > -1)
            {
                y = (TextBox)GridView1.SelectedItem;
                y.Background = background;
                text1.Background = background;
                ApplicationData.Current.LocalSettings.Values["Color" + GridView1.SelectedIndex] = "ms-appx:/Assets/coral.png";
            }
            else
            {
                text1.Background = background;
                text1.Tag = "ms-appx:/Assets/coral.png";
            }
        }





    }
}
