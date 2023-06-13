using System;
using System.Collections.ObjectModel;
using VesuviusApp.Model;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    public class TableViewModel : GenericViewModel
    {
        public ObservableCollection<Table> Tables { get; set; }

        void GetTables()
        {
           Tables =  TableService.SelectFreeTables().Result;
        }
        
    }
}
