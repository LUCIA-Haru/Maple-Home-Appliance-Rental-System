using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance_RentalSystem
{
    class Customer_Model
    {
        private string _CustomerID, _CustomerName, _CustomerPhone, _CustomerEmail, _CustomerNRC, _CustomerPassword, _CustomerDOB, _CustomerGender, _CustomerAddress, _CustomerProfilePicture;

        public string CustomerID
        {
            set { _CustomerID = value; }
            get { return _CustomerID; }
        }
        public string CustomerName
        {
            set { _CustomerName = value; }
            get { return _CustomerName; }
        }
        public string CustomerPhone
        {
            set { _CustomerPhone = value; }
            get { return _CustomerPhone; }
        }
        public string CustomerEmail
        {
            set { _CustomerEmail = value; }
            get { return _CustomerEmail; }
        }
        public string CustomerNRC
        {
            set { _CustomerNRC = value; }
            get { return _CustomerNRC; }
        }
        public string CustomerPassword
        {
            set { _CustomerPassword = value; }
            get { return _CustomerPassword; }
        }
        public string CustomerDOB
        {
            set { _CustomerDOB = value; }
            get { return _CustomerDOB; }
        }
        public string CustomerGender
        {
            set { _CustomerGender = value; }
            get { return _CustomerGender; }
        }
        public string CustomerAddress
        {
            set { _CustomerAddress = value; }
            get { return _CustomerAddress; }
        }
        public string CustomerProfilePicture
        {
            set { _CustomerProfilePicture = value; }
            get { return _CustomerProfilePicture; }
        }
    }
}
