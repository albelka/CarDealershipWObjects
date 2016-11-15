using System;
using System.Collections.Generic;

namespace CarDealership.Objects
  {
  public class Car
  {
    private string _makeModel;
    private string _message;
    private int _price;
    private int _miles;
    private static List<Car> _instance = new List<Car> {};

    public Car(string carMakeModel, string carMessage, int carMiles, int carPrice = 1000000)
    {
      _makeModel = carMakeModel;
      _message = carMessage;
      _price = carPrice;
      _miles = carMiles;
    }



    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMessage(string newMessage)
    {
      _message = newMessage;
    }

    public string GetMessage()
    {
      return _message;
    }

    public static List<Car> GetAll()
    {
        return _instance;
        }

    public void Save()
    {
      _instance.Add(this);
    }

    public static void ClearAll()
    {
      _instance.Clear();
    }


    public static List<Car> listByPrice(List<Car> list, int topPrice)
    {
      List<Car> priceCars = new List<Car>() {};

      foreach( Car car in list)
      {
        int price = car.GetPrice();
        if (price <= topPrice)
        {
          priceCars.Add(car);
        }

      }

      return priceCars;
    }
  }
}
