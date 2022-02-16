using System;
using System.Collections.Generic;

namespace Dealership.Models
{

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
  }
}





// using System;
// using System.Collections.Generic;

// namespace Dealership.Models
// {
//   public class Car
// {
//   public string Description { get; set; }
//     private static List<Item> _instances = new List<Item> {};
    
//     public Item (string description)
//     {
//       Description = description;
//       _instances.Add(this);
//     }

//     public static List<Item> GetAll()
//     {
//       return _instances;
//     }

  
//     }
//   }
// }
// //     public string Description { get; set; }
// //     private string _makeModel;

// //     public string MakeModel
// //     {
// //       get
// //       {
// //         return _makeModel;
// //       }
// //       set{
// //         _makeModel = value;
// //       }
// //     }
// //     private int _price;
// //     private int _miles;

// //     public void SetPrice(int newPrice)
// //     {
// //       _price = newPrice;
// //     }

// //     public Car(string makeModel, int price, int miles)
// //     {
// //       _makeModel = makeModel;
// //       _price = price;
// //       _miles = miles;
// //     }
// //     public string GetMakeModel()
// //     {
// //       return _makeModel;
// //     }
// //     public int GetPrice()
// //     {
// //       return _price;
// //     }

// //     public int GetMiles()
// //     {
// //       return _miles;
// //     }
    
// //   }
// // }


// //     public string Description { get; set; }
// //     private static List<Item> _instances = new List<Item> {};
    
// //     public Item (string description)
// //     {
// //       Description = description;
// //       _instances.Add(this);
// //     }

// //     public static List<Item> GetAll()
// //     {
// //       return _instances;
// //     }


// // using System;

// // namespace Dealership.Models
// // {

// //   public class Car
// //   {
// //     public string MakeModel { get; set; }
// //     public int Price { get; set; }
// //     public int Miles { get; set; }

// //     public Car(string makeModel, int price, int miles)
// //     {
// //       MakeModel = makeModel;
// //       Price = price;
// //       Miles = miles;
// //     }
// //     }
// //   }


