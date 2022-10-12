using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float a, b;
        int count;
        bool znak = true;
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(TextBlock.Text);
                    TextBlock.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(TextBlock.Text);
                    TextBlock.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(TextBlock.Text);
                    TextBlock.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(TextBlock.Text);
                    TextBlock.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 0;
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 1;
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 2;
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 3;
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 4;
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 5;
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 6;
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 7;
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 8;
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = TextBlock.Text + 9;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock.Text == "")
            {
                MessageBoxResult anyError = MessageBox.Show("Введите численное значение", "Ошибка");
            }
            else
            {
                a = float.Parse(TextBlock.Text);
                TextBlock.Text = String.Empty;
                count = 1;
                label1.Content = a.ToString() + "+";
                ButtonPlus.IsEnabled = false;
                znak = true;
            }
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock.Text == "")
            {
                MessageBoxResult anyError = MessageBox.Show("Введите численное значение", "Ошибка");
            }
            else
            {
                a = float.Parse(TextBlock.Text);
                TextBlock.Text = String.Empty;
                count = 3;
                label1.Content = a.ToString() + "*";
                ButtonMultiply.IsEnabled = false;
                znak = true;
            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock.Text == "")
            {
                MessageBoxResult anyError = MessageBox.Show("Введите численное значение", "Ошибка");
            }
            else
            {
                a = float.Parse(TextBlock.Text);
                TextBlock.Text = String.Empty;
                count = 4;
                label1.Content = a.ToString() + "/";
                ButtonDivide.IsEnabled = false;
                znak = true;
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = String.Empty;
            label1.Content = "";
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            int lenght = TextBlock.Text.Length - 1;
            string text = TextBlock.Text;
            TextBlock.Text = String.Empty;
            for (int i = 0; i < lenght; i++)
            {
                TextBlock.Text = TextBlock.Text + text[i];
            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBlock.Text == "")
            {
                MessageBoxResult anyError = MessageBox.Show("Введите численное значение", "Ошибка");
            }
            else
            {
                a = float.Parse(TextBlock.Text);
                TextBlock.Text = String.Empty;
                count = 2;
                label1.Content = a.ToString() + "-";
                ButtonMinus.IsEnabled = false;
                znak = true;
            }
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            label1.Content = "";
            ButtonPlus.IsEnabled = true;
            ButtonMinus.IsEnabled = true;
            ButtonMultiply.IsEnabled = true;
            ButtonDivide.IsEnabled = true;
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            if ((TextBlock.Text.IndexOf(",") == -1) && (TextBlock.Text.IndexOf("∞") == -1))
                TextBlock.Text += ",";
        }
    }
}