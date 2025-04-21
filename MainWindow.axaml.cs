using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyFirstAvaloniaApp.Views;

namespace MyFirstAvaloniaApp
{
   public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new SimpleAllOperationCal();
    }

        private void InitializeComponent()
        {
            {
                AvaloniaXamlLoader.Load(this);
            }
        }
    }
}
