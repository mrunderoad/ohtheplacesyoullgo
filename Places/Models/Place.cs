using System.Collections.Generic;
using System;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Landmarks { get; set; }
    public string People { get; set; }
    public string Journal { get; set; }
    public string Arrive { get; set; }
    public string Depart { get; set; }
    public int Id { get; }

    public static List<Place> _instances = new List<Place> { };

    public Place (string cityName, string landmarks, string people, string journal, string arrive, string depart)
    {
      CityName = cityName;
      Landmarks = landmarks;
      People = people;
      Journal = journal;
      Arrive = arrive;
      Depart = depart;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

    // public static TimeSpan GetStay()
    // {
    //   return Depart - Arrive;
    // }
  }
}