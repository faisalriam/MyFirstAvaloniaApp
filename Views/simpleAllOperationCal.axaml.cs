using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using System;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia.Base;

namespace MyFirstAvaloniaApp.Views
{
    public partial class SimpleAllOperationCal : UserControl
    {
        public SimpleAllOperationCal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                int number1 = int.Parse(Input1.Text ?? "0");
                int number2 = int.Parse(Input2.Text ?? "0");
                int sum = number1 + number2;

                if (radiobutton1.IsChecked == true)
                {
                    Result.Text = sum.ToString();
                }
                else if (radiobutton2.IsChecked == true)
                {
                    Result.Text = (number1 - number2).ToString();
                }
                else if (radiobutton3.IsChecked == true)
                {
                    Result.Text = (number1 * number2).ToString();
                }
                else if (radiobutton4.IsChecked == true)
                {
                    Result.Text = (number1 / number2).ToString();
                }
                else
                {
                    var messageBox = MessageBoxManager
                        .GetMessageBoxStandard("Warning", "Please check the redio button", ButtonEnum.Ok);
                    await messageBox.ShowAsync();
                }
            }
            catch (FormatException)
            {
                Result.Text = "Please enter valid numbers.";
            }
        }
    }
}
