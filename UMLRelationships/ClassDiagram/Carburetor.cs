using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLRelationships.ClassDiagram
{
    public class Carburetor
    {
        private string modelNumber;

        public Carburetor()
        {
            modelNumber = Guid.NewGuid().ToString();
        }
    }
}
