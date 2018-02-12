using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Project.Models
{
  public class Model
  {
    private string _name;
    private string _description;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Thing(string name, string description)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _description = description;
    }
  }
}
