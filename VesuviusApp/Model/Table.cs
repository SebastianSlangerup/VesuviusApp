using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesuviusApp.Model
{
    public class Table
    {
        private int id;
        private int seats;
        private string name;

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
