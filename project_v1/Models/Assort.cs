using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_v1.Models
{
    public class Assort //: IAssort
    {
        IEnumerable<project_v1.Models.ICar> a_Cars;
        /*public void init(){ Car[] a_Cars2 = {
              new Car{ manufacturer="toyota" ,model="corolla", availableGearboxes=new [] { "mt", "at" }, availableEngines=new[] { "1,6"}, startprice=15000 },
              new Car{ manufacturer="honda" ,model="accord", availableGearboxes=new [] { "mt", "at" }, availableEngines=new[] { "2,4","3,0"}, startprice=20000 }

              }; }*/
        public Assort()
        {
            Car[] a_Cars2 = {
              new Car{ manufacturer="toyota" ,model="corolla", availableGearboxes=new [] { "mt", "at" }, availableEngines=new[] { "1,6"}, startprice=15000 },
              new Car{ manufacturer="honda" ,model="accord", availableGearboxes=new [] { "mt", "at" }, availableEngines=new[] { "2,4","3,0"}, startprice=20000 }

              };
            a_Cars = (IEnumerable<project_v1.Models.ICar>)a_Cars2;
        }
        public IEnumerable<project_v1.Models.ICar> getData()
        {
          
            return a_Cars;
        }

    }
}