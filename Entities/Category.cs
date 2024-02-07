using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io_Pair4.Entities;

public class Category
{
    public Category(int id, string category_name)
    {
        Id = id;
        Category_name = category_name;
    }

    public int Id { get; set; }
    public string Category_name { get; set; }
}
