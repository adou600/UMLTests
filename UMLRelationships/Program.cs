using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLRelationships.SequenceDiagram;

namespace UMLRelationships
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            string test = Class1.methodWithReturnAndParam("super");

        }
    }
}
