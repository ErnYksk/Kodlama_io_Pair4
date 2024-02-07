using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io_Pair4.Entities;

public class Instructor
{
    public Instructor(int id, string name)
    {
        Id = id;
        Name = name;
            }

    public int Id { get; set; }

    public string Name { get; set; }

    //List halinde olacak
    public int Course_id{ get; set; }
}
