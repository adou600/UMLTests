using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLRelationships.Aggregation
{
    public enum Position
    {
        FRONT_LEFT = 0,
        FRONT_RIGHT = 1,
        BACK_LEFT = 2,
        BACK_RIGHT = 3,
        RESERVE = 4
    }

    public class Tire
    {
        private Position currentPosition;
    }
}
