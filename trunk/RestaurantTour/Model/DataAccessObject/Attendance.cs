using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantTour.Model.DataAccessObject
{
    internal class Attendance
    {
        internal string CardNo { get; set; }

        internal DateTime Time { get; set; }

        internal Attendance(string CardNo, DateTime Time)
        {
            this.CardNo = CardNo;
            this.Time = Time;
        }
    }
}
