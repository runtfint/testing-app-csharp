using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab_1.Utils;
internal abstract class BindableBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected void SetProperty<T>(ref T source, T value, [CallerMemberName] string? propertyName = null)
    {
        if (source?.Equals(value) ?? false) return;

        source = value;
        OnPropertyChanged(propertyName);
    }
}