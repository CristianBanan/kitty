﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        public Employee Employee;
        public Location departure;
        public Location destination;
        public DateTime startingDate;   
        public DateTime endDate;
        public string phone;
        private string accommodation;

        enum STATES { STATE_CANCELED = 0, STATE_APPROVED = 1, STATE_PENDING = 2 }
        private string meanOfTransportation;
        private string otherNeeds;
    }
}
