using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VesuviusApp.Services;

namespace VesuviusApp.ViewModel
{
    internal class UserViewModel : GenericViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public Command Login; 

        public UserViewModel()
        {
            if (Users == null)
            {
                Users = new ObservableCollection<User>();
            }
        }

       

        

    }
}
