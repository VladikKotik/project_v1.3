using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project_v1.Models
{
    public interface ICar
    {
        string getManufacturer();
        string getModel();
        int getId();
       // IEnumerable<Car> getData();
    }
}

// @Html.ActionLink(linkText: "addcar", actionName: "add", controllerName: "Home", routeValues: new { args[0]=Model.tempcar.getManufacturer(), args[1]Model.tempcar.getModel() }, htmlAttributes: null)
