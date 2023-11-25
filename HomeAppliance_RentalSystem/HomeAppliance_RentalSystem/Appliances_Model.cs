using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAppliance_RentalSystem
{
    class Appliances_Model
    {
        private string _AppliancesID, _AppliancesName, _BrandID, _CategoryID, _Model, _Colour,_Dimensions, _EnergyConsumption,_MonthlyFee, _AppliancesQuantity, _AppliancesStatus, _AppliancesImage,_AdminID ;

        public string AppliancesID
        {
            set { _AppliancesID = value;}
            get {return _AppliancesID;}
        }
        public string AppliancesName
        {
            set { _AppliancesName = value;}
            get {return _AppliancesName;}
        }
        public string BrandID
        {
            set { _BrandID = value;}
            get {return _BrandID;}
        } 
       
        public string CategoryID
        {
            set { _CategoryID = value;}
            get {return _CategoryID;}
        }
        
        public string Model
        {
            set { _Model = value;}
            get {return _Model;}
        }
        public string Colour
        {
            set { _Colour = value;}
            get {return _Colour;}
        }
        public string Dimensions
        {
            set { _Dimensions = value;}
            get {return _Dimensions;}
        }
        public string EnergyConsumption
        {
            set { _EnergyConsumption = value;}
            get {return _EnergyConsumption;}
        }
        public string MonthlyFee
        {
            set { _MonthlyFee = value;}
            get {return _MonthlyFee;}
        }
        public string AppliancesQuantity
        {
            set { _AppliancesQuantity = value;}
            get {return _AppliancesQuantity;}
        }
        public string AppliancesStatus
        {
            set { _AppliancesStatus = value;}
            get {return _AppliancesStatus;}
        }
        public string AppliancesImage
        {
            set { _AppliancesImage = value;}
            get {return _AppliancesImage;}
        }
        public string AdminID
        {
            set { _AdminID = value; }
            get { return _AdminID; }
        }
    }
}
