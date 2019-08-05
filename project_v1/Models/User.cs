using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_v1.Models
{
    //public interface 
    public class User
    {
        public int id;
        public string Login { get; set; }//такие поля наз. св-ва property
        public string Password { get; set; }
        public string Role;
        public string Name;
        //public Array
        public User() { }

        public User(string llogin, string ppassword) {
            //проверка логина  и пароля в бд, возвращает остальные атрибуты
            //типа Name=name_iz_bd;
        }

        public string[][] getHistory() { //вернуть таблицей историю, потом буду с бд ето тащить
                                         //селектить по юзеру(или ид), который сделал заказ
                                         //if(Role=="client")
                                         //return array result 

            string[][] res = new string[3][];
            res[0] = new string[] { "jora", "228" };
            return res;
        }

        //public string getLogs() { //вернуть таблицей историю, потом буду с бд ето тащить
        //return array result 
        //}

    }


}