using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLRelationships.Aggregation
{
    public class Carburator
    {
        private string modelNumber;

        public Carburator()
        {
            modelNumber = Guid.NewGuid().ToString();
        }
    }
}
