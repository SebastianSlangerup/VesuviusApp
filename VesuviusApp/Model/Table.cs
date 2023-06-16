using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesuviusApp.Model
{
    public partial class Table
    {
        public int id;
        public int seats;
        public string name;

        public Table(int Id, int Seats)
        {
            id = Id;
            seats = Seats;
            name = "Table";

        }

        public override string ToString()
        {
            return $"Id {id}. {name} with {seats} seats";
        }
    }
}
