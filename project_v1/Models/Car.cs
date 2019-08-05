using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace project_v1.Models
{
    public class Car //: ICar
    {
        public int id;
        public string manufacturer;
        public string model;
        public string[] availableGearboxes;
        public string[] availableEngines;
        public string[] description;
        public double startprice;
        public double finalprice;
        public Car()
        {
            //инициаизируются из бд, мб сразу все при запуске, сразу все машины

        }
        public Car(string lmanufacturer, string lmodel, string[] lavailableGearboxes, string[] lavailableEngines, int lfinalprice)
        {
            //мб его не паблик сделать
            manufacturer = lmanufacturer;
            model = lmodel;
            availableGearboxes = lavailableGearboxes;
            availableEngines = lavailableEngines;
            finalprice = lfinalprice;

        }
        public static void addCar(string lmanufacturer, string lmodel, string[] lavailableGearboxes, string[] lavailableEngines, int lfinalprice)
        {
            Car lcar = new Car(lmanufacturer, lmodel, lavailableGearboxes, lavailableEngines, lfinalprice);
            //по полям в бд хууяк

        }

        public string getManufacturer()
        {
            return manufacturer;
        }
        public string getModel() {
            return model;
        }
        /*public static Car[] getdata() {
            Car[] cars = new Car[] { };
            return cars;
        }*/
       /* public IEnumerable<Car> getData() {
             public static Car[] a_Cars = {
             new Car{ manufacturer="toyota" ,model="corolla", availableGearboxes=new [] { "mt", "at" }, availableEngines=new[] { "1,6"}, startprice=15000 },
              new Car{ manufacturer="honda" ,model="accord", availableGearboxes=new [] { "mt", "at" }, availableEngines=new[] { "2,4","3,0"}, startprice=20000 } };
    
        
            //return (IEnumerable<project_v1.Models.Car>)a_Cars;
            */
    }
        

     


    

    public class Cars : IEnumerable
    {
        private Car[] _cars;
        public Cars(Car[] pArray)
        {
            _cars = new Car[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _cars[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public CarsEnum GetEnumerator()
        {
            return new CarsEnum(_cars);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class CarsEnum : IEnumerator
    {
        public Car[] _cars;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public CarsEnum(Car[] list)
        {
            _cars = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _cars.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Car Current
        {
            get
            {
                try
                {
                    return _cars[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }



}

