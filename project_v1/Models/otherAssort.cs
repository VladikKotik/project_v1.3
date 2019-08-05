using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure;

namespace project_v1.Models
{
    public class otherAssort : IAssort
    {


        IEnumerable<project_v1.Models.ICar> a_Cars;
  
        
        public List<otherCar> othercars;
        
        CarsContext db;
        public otherAssort()
        {

            db = new CarsContext();
            othercars = db.otherCars.ToList();
            
        }
        public IEnumerable<project_v1.Models.ICar> getData()
        {
            
            return othercars;
        }
        public CarsContext getdbcont() {
            return db;
        }

        //ассорт по сути и есть мой репозиторий
        public void add(string[] args) {
           
            db.otherCars.Add(new otherCar { manufacturer = args[0], model = args[1] });
            db.SaveChanges();
            var ctx = ((IObjectContextAdapter)db).ObjectContext;
            ctx.Refresh(System.Data.Entity.Core.Objects.RefreshMode.ClientWins, db.otherCars);
            ctx.Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, db.otherCars);


        }

        public void init_car(otherCar loc1) {
            loc1.manufacturer = "s";
            loc1.model = "s";
            db.otherCars.Add(loc1);
           
            db.SaveChanges();
           

        }

        public void delete(int lid) {
            
          
            otherCar oc1;
            oc1 = db.otherCars.ToList<otherCar>().Find(o => o.id == lid);
           
            db.otherCars.Remove(oc1);
            db.SaveChanges();
           
        }
        public void update(otherCar loc1,int locid) {
            otherCar oc1;
            oc1 = db.otherCars.ToList<otherCar>().Find(o => o.id == locid/*loc1.id*/);
          

            oc1.manufacturer = loc1.manufacturer;   
            oc1.model=loc1.model;
            db.SaveChanges();
            
        }
    }
        
          public class CarsContext : DbContext
    {
        public CarsContext():base("TestPG") {}
        public DbSet<otherCar> otherCars { get; set; }
        public otherCar tempcar=new otherCar();

         
 
    }

    [Table("public.cars")]
    public class otherCar : ICar
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("manufacturer")]
        public string manufacturer { get; set; }        
        [Column("model")]
        public string model { get; set; }

        public otherCar() { }


        public otherCar(int id, string manufacturer, string model) {
            this.id = id;
            this.manufacturer = manufacturer;
            this.model = model;

        }

        public string getManufacturer()
        {
            return manufacturer;
        }
        public string getModel()
        {
            return model;
        }
        public int getId() {
           return id;

        }
    }
 
 
         

    


}