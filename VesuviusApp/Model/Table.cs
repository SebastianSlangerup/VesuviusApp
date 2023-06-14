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

        public Table(int Id, int Seats)
        {
            id = Id;
            seats = Seats;
        }
    }
}
