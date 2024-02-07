using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kodlama_io_Pair4.Entities;

internal class Courses
{
    
    public Courses(int id, string title, string description, int instructor_id, int price_id)
    {
        Id = id;
        Title = title;
        Description = description;
        Instructor_id = instructor_id;
        Price_id = price_id;

    }



    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Instructor_id { get; set; }
    public int Price_id { get; set; }


    public override string ToString()
    {
        return $"ID: {Id}, Title: {Title}, Description: {Description},Instructor_id: {Instructor_id}";
    }

}
