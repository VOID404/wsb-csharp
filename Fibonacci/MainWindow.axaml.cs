using System;
using System.Collections.ObjectModel;
using System.Numerics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Fibonacci;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new ObservableCollection<BigInteger> { 0, 1 };
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var data = DataContext as ObservableCollection<BigInteger>
                   ?? throw new ApplicationException("Invalid DataContext");

        var skip = (int)(SkipSpinner.Value ?? 1);
        Console.WriteLine($"Generating next {skip} Fibonacci numbers from {data[^2]} and {data[^1]}");
        var next = Fibonacci.Nth(skip, data[^1], data[^2]);
        data.Add(next);
    }
}