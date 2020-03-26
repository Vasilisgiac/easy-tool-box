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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Calculator : Page
    {
        double total1 = 0;
        double total2 = 0;
        double total3 = 0;
        double oldtotal = 0;
        double memory;
        string temp;
        bool buttonClickedPlus = false;
        bool buttonClickedMinus = false;
        bool buttonClickedepi = false;
        bool buttonClickeddia = false;
        bool buttonClickedequals = false;
        bool buttonClickedlog = false;
        bool buttonClickedroot = false;
        bool buttonClickedpercent = false;
        public Calculator()
        {
            this.InitializeComponent();

            //text.Text = "Insert number";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn1.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '1';
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn2.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '2';
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn3.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '3';
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn4.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '4';
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn5.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '5';
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn6.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '6';
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn7.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '7';
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn8.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '8';
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn9.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '9';
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (buttonClickedroot == true || buttonClickedlog == true || buttonClickedpercent == true)
            {
                text.Text = "";
                text2.Text = temp;
                buttonClickedroot = false;
                buttonClickedlog = false;
                buttonClickedpercent = false;
            }
            if (buttonClickedequals == true)
            {
                text.Text = "";
                text2.Text = "";
                buttonClickedequals = false;
            }
            if (text.Text == "Insert number" || text.Text == "0")
            {
                text.Text = btn0.Content.ToString();
            }
            else
            {
                text.Text = text.Text + '0';
            }
        }

        private void clearall_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            total1 = 0;
            total2 = 0;
            text.Text = "";
            text2.Text = "";
            buttonClickedPlus = false;
            buttonClickedMinus = false;
            buttonClickedepi = false;
            buttonClickeddia = false;
            buttonClickedequals = false;
            buttonClickedlog = false;
            buttonClickedroot = false;
            buttonClickedpercent = false;
            temp = "";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            text.Text = "";
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            if (buttonClickedPlus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 + double.Parse(text.Text);
                    
                }
                buttonClickedPlus = false;
            }
            else if (buttonClickedMinus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 - double.Parse(text.Text);
                    
                }
                buttonClickedMinus = false;
            }
            else if (buttonClickedepi == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 * double.Parse(text.Text);
                    
                }
                buttonClickedepi = false;
            }
            else if (buttonClickeddia == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 / double.Parse(text.Text);
                    
                }
                buttonClickeddia = false;
            }

            buttonClickedPlus = true;

            if (total1 == 0)
            {
                total1 = double.Parse(text.Text);
            }

            if (buttonClickedequals == true)
            {
                if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                {
                    buttonClickedequals = false;
                }
                else
                {
                    text2.Text = "";
                    buttonClickedequals = false;
                }
            }
            if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = text2.Text + " + ";
                text.Text = "";
                buttonClickedlog = false;
                buttonClickedroot = false;
                buttonClickedpercent = false;
            }
            else
            {
                text2.Text = text2.Text + text.Text + " + ";
                text.Text = "";
            }
        }

        private void btnequals_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            if (buttonClickedequals == true)
            {
                if (buttonClickedPlus == true)
                {
                    if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                    {
                        text2.Text = text2.Text + " + " + oldtotal.ToString() + " = ";
                        buttonClickedlog = false;
                        buttonClickedroot = false;
                        buttonClickedpercent = false;
                    }
                    else
                        text2.Text = text.Text + " + " + oldtotal.ToString() + " = ";

                    total2 = double.Parse(text.Text) + oldtotal;
                    text.Text = total2.ToString();
                    total2 = 0;

                }
                else if (buttonClickedMinus == true)
                {
                    if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                    {
                        text2.Text = text2.Text + " - " + oldtotal.ToString() + " = ";
                        buttonClickedlog = false;
                        buttonClickedroot = false;
                        buttonClickedpercent = false;
                    }
                    else
                        text2.Text = text.Text + " - " + oldtotal.ToString() + " = ";

                    total2 = double.Parse(text.Text) - oldtotal;
                    text.Text = total2.ToString();
                    total2 = 0;

                }
                else if (buttonClickedepi == true)
                {
                    if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                    {
                        text2.Text = text2.Text + " * " + oldtotal.ToString() + " = ";
                        buttonClickedlog = false;
                        buttonClickedroot = false;
                        buttonClickedpercent = false;
                    }
                    else
                        text2.Text = text.Text + " * " + oldtotal.ToString() + " = ";

                    total2 = double.Parse(text.Text) * oldtotal;
                    text.Text = total2.ToString();
                    total2 = 0;

                }
                else if (buttonClickeddia == true)
                {
                    if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true || buttonClickedpercent == true)
                    {
                        text2.Text = text2.Text + " / " + oldtotal.ToString() + " = ";
                        buttonClickedlog = false;
                        buttonClickedroot = false;
                        buttonClickedpercent = false;
                    }
                    else
                        text2.Text = text.Text + " / " + oldtotal.ToString() + " = ";

                    total2 = double.Parse(text.Text) / oldtotal;
                    text.Text = total2.ToString();
                    total2 = 0;

                }
                string s = text2.Text + text.Text;
                for (int i = 0; i < s.Length; i += 56)
                {
                    s = s.Substring(0, i) + "\n" + s.Substring(i);
                }
                MyList.Items.Add(s);
                return;
            }
            if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = text2.Text + " = ";
                buttonClickedlog = false;
                buttonClickedroot = false;
                buttonClickedpercent = false;
            }
            else
            {
                text2.Text = text2.Text + text.Text + " = ";
            }
            if (buttonClickedPlus == true)
            {
                total2 = total1 + double.Parse(text.Text);
                oldtotal = double.Parse(text.Text);
                text.Text = total2.ToString();
                total1 = 0;
                total2 = 0;

            }
            else if (buttonClickedMinus == true)
            {
                total2 = total1 - double.Parse(text.Text);
                oldtotal = double.Parse(text.Text);
                text.Text = total2.ToString();
                total1 = 0;
                total2 = 0;
            }
            else if (buttonClickedepi == true)
            {

                total2 = total1 * double.Parse(text.Text);
                oldtotal = double.Parse(text.Text);
                text.Text = total2.ToString();
                total1 = 0;
                total2 = 0;
            }
            else if (buttonClickeddia == true)
            {
                total2 = total1 / double.Parse(text.Text);
                oldtotal = double.Parse(text.Text);
                text.Text = total2.ToString();
                total1 = 0;
                total2 = 0;
            }
            buttonClickedequals = true;
            string a = text2.Text + text.Text;
            for (int i = 0; i < a.Length; i += 56)
            {
                a = a.Substring(0, i) + "\n" + a.Substring(i);
            }
            MyList.Items.Add(a);

        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            if (buttonClickedPlus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 + double.Parse(text.Text);

                }
                buttonClickedPlus = false;
            }
            else if (buttonClickedMinus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 - double.Parse(text.Text);

                }
                buttonClickedMinus = false;
            }
            else if (buttonClickedepi == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 * double.Parse(text.Text);

                }
                buttonClickedepi = false;
            }
            else if (buttonClickeddia == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 / double.Parse(text.Text);

                }
                buttonClickeddia = false;
            }

            buttonClickedMinus = true;

            if (total1 == 0)
            {
                total1 = double.Parse(text.Text);
            }

            if (buttonClickedequals == true)
            {
                if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                {
                    buttonClickedequals = false;
                }
                else
                {
                    text2.Text = "";
                    buttonClickedequals = false;
                }
            }
            if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = text2.Text + " - ";
                text.Text = "";
                buttonClickedlog = false;
                buttonClickedroot = false;
                buttonClickedpercent = false;
            }
            else
            {
                text2.Text = text2.Text + text.Text + " - ";
                text.Text = "";
            }
        }

        private void btnepi_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            if (buttonClickedPlus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 + double.Parse(text.Text);

                }
                buttonClickedPlus = false;
            }
            else if (buttonClickedMinus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 - double.Parse(text.Text);

                }
                buttonClickedMinus = false;
            }
            else if (buttonClickedepi == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 * double.Parse(text.Text);

                }
                buttonClickedepi = false;
            }
            else if (buttonClickeddia == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 / double.Parse(text.Text);

                }
                buttonClickeddia = false;
            }

            buttonClickedepi = true;

            if (total1 == 0)
            {
                total1 = double.Parse(text.Text);
            }

            if (buttonClickedequals == true)
            {
                if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                {
                    buttonClickedequals = false;
                }
                else
                {
                    text2.Text = "";
                    buttonClickedequals = false;
                }
            }
            if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = text2.Text + " * ";
                text.Text = "";
                buttonClickedlog = false;
                buttonClickedroot = false;
                buttonClickedpercent = false;
            }
            else
            {
                text2.Text = text2.Text + text.Text + " * ";
                text.Text = "";
            }
        }

        private void btndia_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            if (buttonClickedPlus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 + double.Parse(text.Text);

                }
                buttonClickedPlus = false;
            }
            else if (buttonClickedMinus == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 - double.Parse(text.Text);

                }
                buttonClickedMinus = false;
            }
            else if (buttonClickedepi == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 * double.Parse(text.Text);

                }
                buttonClickedepi = false;
            }
            else if (buttonClickeddia == true)
            {
                if (total1 != 0)
                {
                    total1 = total1 / double.Parse(text.Text);

                }
                buttonClickeddia = false;
            }

            buttonClickeddia = true;

            if (total1 == 0)
            {
                total1 = double.Parse(text.Text);
            }

            if (buttonClickedequals == true)
            {
                if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
                {
                    buttonClickedequals = false;
                }
                else
                {
                    text2.Text = "";
                    buttonClickedequals = false;
                }
            }
            if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = text2.Text + " / ";
                text.Text = "";
                buttonClickedlog = false;
                buttonClickedroot = false;
                buttonClickedpercent = false;
            }
            else
            {
                text2.Text = text2.Text + text.Text + " / ";
                text.Text = "";
            }
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "Invalid number")
                return;

            string s = text.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "";
            }
            text.Text = s;
        }

        private void btn_plusminus_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            total3 = double.Parse(text.Text);
            total3 = -total3;
            text.Text = total3.ToString();
        }

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            buttonClickedlog = true;
            total3 = double.Parse(text.Text);
            total3 = Math.Log10(total3);
            if (buttonClickedequals == true)
            {
                text2.Text = "";
            }
            if (buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = temp;
            }
            if (double.Parse(text.Text) <= 0)
            {
                text.Text = "Invalid number";
                temp = text2.Text;
            }
            else
            {
                temp = text2.Text;
                text2.Text = text2.Text + "log(" + text.Text + ')';
                text.Text = total3.ToString();
            }
        }

        private void btnroot_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            buttonClickedroot = true;
            total3 = double.Parse(text.Text);
            total3 = Math.Sqrt(total3);
            if (buttonClickedequals == true)
            {
                text2.Text = "";
            }
            if (buttonClickedlog == true || buttonClickedpercent == true)
            {
                text2.Text = temp;
            }
            if (double.Parse(text.Text) < 0)
            {
                text.Text = "Invalid number";
                temp = text2.Text;
            }
            else
            {
                temp = text2.Text;
                text2.Text = text2.Text + '√' + text.Text;
                text.Text = total3.ToString();
            }
        }

        private void btnpercent_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            buttonClickedpercent = true;
            total3 = double.Parse(text.Text);
            total3 = total1 * total3 / 100;
            if (buttonClickedequals == true)
            {
                text2.Text = "";
            }
            if (buttonClickedlog == true || buttonClickedroot == true)
            {
                text2.Text = temp;
            }
            temp = text2.Text;
            text2.Text = text2.Text + text.Text + '%';
            text.Text = total3.ToString();
        }

        private void btnreverse_Click(object sender, RoutedEventArgs e)
        {
            text.FontSize = 50;
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            total3 = double.Parse(text.Text);
            total3 = 1 / total3;
            if (buttonClickedequals == true)
            {
                text2.Text = "";
            }
            if (buttonClickedlog == true || buttonClickedroot == true || buttonClickedpercent == true)
            {
                text2.Text = temp;
            }
            text.Text = total3.ToString();
        }

        private void btnmc_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
        }

        private void btnmplus_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            memory = memory + double.Parse(text.Text);
        }

        private void btnmminus_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            memory = memory - double.Parse(text.Text);
        }

        private void btnmr_Click(object sender, RoutedEventArgs e)
        {
            text.Text = memory.ToString();
        }

        private void btndot_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "")
                return;
            if (text.Text == "Invalid number")
                return;
            text.Text = text.Text + '.';
        }

        private void backbutton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MyList.SelectedItems)
            {
                MyList.Items.Remove(item);

            }
        }

        private void btndeleteall_Click(object sender, RoutedEventArgs e)
        {
            MyList.Items.Clear();
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (text.Text.Length > 22)
            {
                if (text.FontSize <= 18)
                    return;
                text.FontSize = text.FontSize - 1.5;
            }
        }



        

    }
}
