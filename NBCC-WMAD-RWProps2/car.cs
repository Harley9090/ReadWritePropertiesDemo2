using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    public class car
    {
        private int? speed;
        private decimal? price2;

        //same as private decimal? price
        private Nullable<decimal> price;
        private int numberOfDoors;
        private string carType;

        public int? Year { get; set; }


        public int? Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

                
        public Nullable<decimal> Price
        {
            get {return price;}
            set {price = value;}
        }
        public decimal? Price2
        {
            get { return price2; }
            set { price2 = value; }
        }

        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                if (value < 10)
                {
                    numberOfDoors = value;
                }
            }
        }

        public string CarType
        {
            get
            {
                return carType;
            }
            set
            {
                carType = value;
            }
        }
    }
}
