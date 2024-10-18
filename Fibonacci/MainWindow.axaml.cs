using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Fibonacci;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new Model();
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var model = DataContext as Model
                    ?? throw new ApplicationException("Invalid DataContext");

        var skip = (int)(StepSpinner.Value ?? 1);
        Console.WriteLine($"Generating next {skip} Fibonacci numbers from {model.Numbers[^2]} and {model.Numbers[^1]}");
        var next = Fibonacci.Nth(skip, model.Numbers[^1], model.Numbers[^2]);
        model.Numbers.Add(next);
    }
}