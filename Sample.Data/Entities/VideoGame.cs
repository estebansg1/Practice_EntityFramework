using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data.Entities;

public class VideoGame
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
    public string Developer { get; set; }
    public DateTime Created { get; set; }
    public double Price { get; set; }
}
