using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io_Pair4.Entities;
internal class Price
{
    public Price(int id, double price)
    {
        Id = id;
        Prices = price;
    }

    public int Id { get; set; }

    public double Prices { get; set; }
}
