using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance_RentalSystem
{
    class Brand_Model
    {
        private string _BrandID, _BrandName;

        public string BrandID
        {
            set { _BrandID = value; }
            get { return _BrandID; }
        }
        public string BrandName
        {
            set { _BrandName = value; }
            get { return _BrandName; }
        }

    }
}
