using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance_RentalSystem
{
    class Administrator_Model
    {
        private string _AdminID, _AdminName, _AdminPhone, _AdminEmail, _AdminPassword, _AdminNRC, _AdminDOB, _AdminPosition, _AdminAddress, _AdminProfilePic;

        public string AdminID
        {
            set { _AdminID = value; }
            get { return _AdminID; }
        }
        public string AdminName
        {
            set { _AdminName = value; }
            get { return _AdminName; }
        }
        public string AdminPhone
        {
            set { _AdminPhone = value; }
            get { return _AdminPhone; }
        }
        public string AdminEmail
        {
            set { _AdminEmail = value; }
            get { return _AdminEmail; }
        }
        public string AdminPassword
        {
            set { _AdminPassword = value; }
            get { return _AdminPassword; }
        }
        public string AdminNRC
        {
            set { _AdminNRC = value; }
            get { return _AdminNRC; }
        }
        public string AdminPosition
        {
            set { _AdminPosition = value; }
            get { return _AdminPosition; }
        }
        public string AdminDOB
        {
            set { _AdminDOB = value; }
            get { return _AdminDOB; }
        }
        public string AdminAddress
        {
            set { _AdminAddress = value; }
            get { return _AdminAddress; }
        }
        public string AdminProfilePic
        {
            set { _AdminProfilePic = value; }
            get { return _AdminProfilePic; }
        }
    }
}
