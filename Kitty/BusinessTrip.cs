﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    class BusinessTrip
    {
        private Employee Employee;
        private Location departure;
        private Location destination;
        private DateTime startingDate;   
        private DateTime endDate;
        private string phone;
        private string accommodation;
        enum STATES { STATE_CANCELED = 0, STATE_APPROVED = 1, STATE_PENDING = 2 }
        private string meanOfTransportation;
        private string otherNeeds;
    }
}
