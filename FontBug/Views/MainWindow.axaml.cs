using System.Text;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FontBug.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded+=OnLoaded;
    }

    private void OnLoaded(object? sender, RoutedEventArgs e)
    {
        StringBuilder textbuilder = new StringBuilder();
        for (int i = 0; i < 256; i++)
        {
            textbuilder.Append((char)i);

        }

        TextBlock.Text = textbuilder.ToString();
    }
}