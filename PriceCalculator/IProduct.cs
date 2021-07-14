using System;
using System.Collections.Generic;
using System.Text;

namespace PriceCalculator
{
    public interface IProduct
    {
        string Product(); //{ get; set; }
        decimal Price(); // { get;  }
    }
}
