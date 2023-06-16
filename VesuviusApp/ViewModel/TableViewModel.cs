using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using VesuviusApp.Model;
using VesuviusApp.Services;
using VesuviusApp.View;

namespace VesuviusApp.ViewModel
{
    public partial class TableViewModel : GenericViewModel
    {
        [ObservableProperty]
        ObservableCollection<Table> tables;

        public TableViewModel()
        {
            Title = "Free Tables";
            tables = new ObservableCollection<Table>();
            getAvailableTables = new AsyncRelayCommand(getFreeTables);
            
            
        }

       

        public IAsyncRelayCommand getAvailableTables { get; }
       
        

        public async Task getFreeTables()
        {
            var Service = new TableService();
           var Available_tables =  await Service.SelectFreeTables();

            if (Available_tables == null)
            {
                return;
            }
            else
            {
                Tables = Available_tables;
            }
        }

        [RelayCommand]
        public async Task newOrder(Table table)
        {
            await Shell.Current.GoToAsync($"{nameof(OrderPage)}",
                new Dictionary<string, object>
                {
                    {"Table", table}
                });
        }

        [RelayCommand]
        public void DeleteTable(Table table)
        {
            Tables.Remove(table);
        }
    }

}
