using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLRelationships.Aggregation
{
    public class Car : Vehicule
    {
        private string name;
        private Carburator carburator;
        private List<Tire> tires;
        private Garage garage;

        public Car()
        {
            carburator = new Carburator();
            tires = new List<Tire>();
        }

        public void AddTire(Tire tire)
        {
            if (tires.Count < 5)
            {
                tires.Add(tire);    
            }
            else
            {
                Debug.Print("error, max 5 tires pro car (4 + 1 emergency tire)");
            }
            
        }

        public void StartCar(Key key)
        {
            //use the key to start the car
            Debug.Print("starts the car with the key " + key.Number);
        }

        public void RemoveTire(Tire tire)
        {
            tires.Remove(tire);
        }

        ~Car()
        {
            //destroy the carburator with the car
            carburator = null;
            //but the tires can continue to live outside of the car...
        }
    }
}
