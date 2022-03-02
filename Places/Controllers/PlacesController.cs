using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;
using System;
// using System.Windows.Forms;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      return View(Place.GetAll());
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string landmarks, string people, string journal, string arrive, string depart)
    {
      Place myPlace = new Place(cityName, landmarks, people, journal, arrive, depart);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      return View(Place.Find(id));
    }
    
  }
}