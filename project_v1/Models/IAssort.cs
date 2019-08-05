using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_v1.Models
{
    public interface IAssort
    {

        IEnumerable<project_v1.Models.ICar> getData();
        CarsContext getdbcont();
        void add(string[] args);
        void delete(int lid);
        void update(otherCar loc1,int locid);
        void init_car(otherCar loc1);
    }
}