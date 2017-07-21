﻿using Kitty.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty
{
    public class BusinessTrip
    {
        public Guid ID;
        public STATES Status = STATES.STATE_NEW;

        public readonly Employee Employee;
        public Location Departure;
        public Location Destination;
        public DateTime StartingDate;
        public DateTime EndDate;
        public string Phone;
        public string BankCard;
        public bool AccommodationIsNeeded;

        public enum STATES { STATE_NEW=0, STATE_CANCELED = 1, STATE_APPROVED = 2, STATE_PENDING = 3 }
        public string MeanOfTransportation;

        public Manager Manager;
        //public string OtherNeeds;
        public BusinessTrip()
        {
            ID = Guid.NewGuid();
        }

        public BusinessTrip(Employee employee, Manager manager)
        {
            ID = Guid.NewGuid();
            Departure = employee.Office.Location;
            Employee = employee;
            Manager = manager;
        }


        public void Send()
        {
            Status = STATES.STATE_PENDING;

            BusinessTripRepository bs = new BusinessTripRepository();
            bs.Add(this);

            SendEmailToManager();
        }

        private void SendEmailToManager()
        {
            EmailService emailService = new EmailService();
            Email email = new Email();
            email.From = Employee.Email;
            email.To = Manager.Email;
            email.Subject = "Please aprove my request";

            var body = string.Format("Employee: {0}\n", Employee.Name);
            body += string.Format("Departure: {0}\n", Departure.Name);
            body += string.Format("Destination: {0}\n", Destination.Name);
            if (AccommodationIsNeeded)
                body += string.Format("Accomodation is needed");
            else
                body += string.Format("Accomodation is not needed");

            emailService.Send(email);
        }

        public void Approve()
        {
            Status = STATES.STATE_APPROVED;
        }

        public void Cancel()
        {
            Status = STATES.STATE_CANCELED;
        }
    }
}
