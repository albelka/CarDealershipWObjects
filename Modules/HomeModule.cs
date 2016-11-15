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
        List<Car> _instance = Car.GetAll();
        return View["view_all_cars.cshtml", _instance];
      };
      Post["/car_added"] = _ =>
      {
        Car newCar = new Car(Request.Form["new-MakeModel"], Request.Form["new-Message"], int.Parse(Request.Form["new-Mileage"]), int.Parse(Request.Form["new-Price"]) );
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
