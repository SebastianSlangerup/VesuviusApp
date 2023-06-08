using System.ComponentModel;
using System.Runtime.CompilerServices;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel;

public class GenericViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private bool isBusy;
    private string title;

    public GenericViewModel()
    {
        Title = "Generic";
    }

    public bool IsBusy
    {
        get => isBusy;
        set
        {
            if (IsBusy == value)
            {
                return;
            }

            isBusy = value;
            OnPropertyChanged();
        }
    }

    public string Title {
        get => title;
        set
        {
            if (Title == value)
            {
                return;
            }

            title = value;
            OnPropertyChanged();
        }
    }
    
    

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}