using System.Collections.Generic;
using Nancy;
using CarDealership.Objects;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _  => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ =>
      {
        List<Car> _instance = Cars.GetAll();
        return View["view_all_cars.cshtml", _instance];
      };
      Post["/car_added"] = _ =>
      {
        Car newCar = new Car();
        newCar.SetMakeModel(Request.Form["new-MakeModel"]);
        newCar.SetMiles(Request.Form["new-Mileage"]);
        newCar.SetPrice(Request.Form["new-Price"]);
        newCar.SetMessage(Request.Form["new-Message"]);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ =>
      {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
