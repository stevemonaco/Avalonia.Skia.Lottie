using System.Linq;
using Avalonia;
using Avalonia.Controls;
using LottieDemo.ViewModels;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;

namespace LottieDemo.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

        AddHandler(DragDrop.DragOverEvent, DragOver);
        AddHandler(DragDrop.DropEvent, Drop);
    }

    private void OnPlayClicked(object? sender, RoutedEventArgs e)
    {
        var lottie = this.FindControl<Avalonia.Skia.Lottie.Lottie>("Lottie");
        lottie?.Play();
    }

    private void OnPauseClicked(object? sender, RoutedEventArgs e)
    {
        var lottie = this.FindControl<Avalonia.Skia.Lottie.Lottie>("Lottie");
        lottie?.Pause();
    }

    private void OnStopClicked(object? sender, RoutedEventArgs e)
    {
        var lottie = this.FindControl<Avalonia.Skia.Lottie.Lottie>("Lottie");
        lottie?.Stop();
    }

    private void OnResumeClicked(object? sender, RoutedEventArgs e)
    {
        var lottie = this.FindControl<Avalonia.Skia.Lottie.Lottie>("Lottie");
        lottie?.Resume();
    }
    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        Focus();
    }

    private void DragOver(object? sender, DragEventArgs e)
    {
        e.DragEffects &= DragDropEffects.Copy | DragDropEffects.Link;

        if (!e.DataTransfer.Contains(DataFormat.File))
        {
            e.DragEffects = DragDropEffects.None;
        }
    }

    private void Drop(object? sender, DragEventArgs e)
    {
        if (!e.DataTransfer.Contains(DataFormat.File))
        {
            return;
        }

        if (DataContext is not MainViewModel vm)
        {
            return;
        }

        var paths = e.DataTransfer.TryGetFiles()?
            .Select(file => file.TryGetLocalPath())
            .Where(path => !string.IsNullOrWhiteSpace(path))
            .Cast<string>()
            .ToList();
        if (paths is null)
        {
            return;
        }

        for (var i = 0; i < paths.Count; i++)
        {
            var path = paths[i];
            if (string.IsNullOrWhiteSpace(path))
            {
                continue;
            }

            vm.Add(path);

            if (i == 0)
            {
                vm.SelectedAsset = vm.Assets[^1];
            }
        }
    }
}
