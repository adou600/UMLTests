using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLRelationships.ClassDiagram
{
    public abstract class Vehicule : IRollable
    {
        public virtual void Roll()
        {
            Debug.Print("Started rolling");
        }
    }
}
