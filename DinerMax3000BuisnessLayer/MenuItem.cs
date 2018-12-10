using System;
using System.Collections.Generic;
using System.Text;

namespace DinnerMax3000.Business
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value > 0) { _price = value; }
                else
                {
                    throw new ApplicationException("value shouldnt be zero or less");
                }
                
            }
        }

    }
}
