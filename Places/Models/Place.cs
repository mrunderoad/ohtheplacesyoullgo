using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Landmarks { get; set; }
    public string People { get; set; }
    public string Journal { get; set; }
    public int Id { get; }

    public static List<Place> _instances = new List<Place> { };

    public Place (string cityName, string landmarks, string people, string journal)
    {
      CityName = cityName;
      Landmarks = landmarks;
      People = people;
      Journal = journal;
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
  }
}