using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Room
{
    public string name;
    public string flavor;
    public int modifier;
    public Event[] EventArray;


    public Room(string name, string flavor, int modifier, Event[] EventArray)
    {
        this.name = name;
        this.flavor = flavor;
        this.modifier = modifier;
        this.EventArray = EventArray;
    }
}
