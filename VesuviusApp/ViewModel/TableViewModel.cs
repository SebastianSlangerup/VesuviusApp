using System;
using System.Collections.ObjectModel;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    public class TableViewModel : GenericViewModel
    {
        public ObservableCollection<Table> Tables { get; set; }
        TableService TableService { get; set; }

        public TableViewModel(TableService tableService)
        {
            Title = "Tables";
            this.TableService = tableService;

            gettable();
        }

        public async void gettable()
        {
            this.Tables = await TableService.selectFreeTables();
        }
    }
}
