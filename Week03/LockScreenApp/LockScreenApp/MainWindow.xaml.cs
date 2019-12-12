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

namespace LockScreenApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private List<int> passcode = new List<int>();
        Boolean creatingPin = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
       
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (creatingPin == true && passcode.Count == 4) 
            {
                textBox.Text = "Enter your PIN";
                creatingPin = false;
            }
            
                
           else if (progressBar.Value == 100)
            {
                progressBar.Value = 0;


            }
            else if (passcode.Count == 4)
            {

            }
           
            else
            {
                progressBar.Value += 25;
                passcode.Add(1);
            }
           

            

            


        }
        

        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else 
            {
                progressBar.Value += 25;
                passcode.Add(2);
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(3);
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(4);
            }

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(5);
            }

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(6);
            }

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(7);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(8);
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(9);
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;

            }
            else
            {
                progressBar.Value += 25;
                passcode.Add(0);
            }
        }
    }
}
