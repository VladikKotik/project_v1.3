using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_v1.Models
{
    public class Configurator1 : IConfigurator
    {
        //public int price { get; set; }  //пока start price
        //public string complect { get; set; }
        public Car car { get; set; }
        //public string finalprice;
        public double finalprice;

        public Configurator1(Car lcar) {
            car = lcar;
        }


        public double calculate(Car lcar) {
            //double lfinalprice = car.startprice;
            double lfinalprice = 14.88;
            //if(dvushkapushka){finalprice*=1.05; }
            //и так далее, разные опции - умножение на коэфициент
              return lfinalprice;
            //return 14.88;
            //car.finalprice = lfinalprice;
        } 

       /* public void calculate(string lcar) {//сделать полем finalprice, a этот метод calculate
            string fp;
            fp = "";
            if (lcar == "corolla")
            {
                fp = "15000$";
            }
            else if (lcar == "camry")
            {
                fp = "20000$";
            }
            //return fp;
            finalprice = fp;
        }*/
        /*
         ваще в отдельный класс его
        public void makeOrder() {
            //заносить инфу в таблицу, заносить ид юзера, цену, комплектацию, машину, ну вот этот
            //метод после сабмита1
        }*/

        
    }
}