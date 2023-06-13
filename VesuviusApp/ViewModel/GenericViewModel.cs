using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel;

public partial class GenericViewModel : ObservableObject
{
    [field: ObservableProperty]
    public User myUser;

    [field: ObservableProperty] 
    public string Title { get; set; }

    public GenericViewModel()
    {
        Title = "Generic";
    }    
}