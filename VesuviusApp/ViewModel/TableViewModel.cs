using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using VesuviusApp.Model;
using VesuviusApp.Services;

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
            NewOrder = new AsyncRelayCommand(newOrder);
            DeleteTable = new AsyncRelayCommand(deleteTable);
        }

        public IAsyncRelayCommand getAvailableTables { get; }
        public IAsyncRelayCommand NewOrder { get; }
        public IAsyncRelayCommand DeleteTable { get; }

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

        public async Task newOrder()
        {
            Application.Current.MainPage = new OrderViewModel();
        }
        public async Task deleteTable()
        {

        }



    }

}
