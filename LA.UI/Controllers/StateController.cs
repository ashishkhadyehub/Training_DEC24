using LA.Models;
using LA.SL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LA.UI.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateRepo _stateRepo;
        private readonly ICountryRepo _countryRepo;

        public StateController(IStateRepo stateRepo, ICountryRepo countryRepo)
        {
            _stateRepo = stateRepo;
            _countryRepo = countryRepo;
        }

        public IActionResult Index()
        {
            var states = _stateRepo.GetAll();
            return View(states);
        }

        [HttpGet]
        public IActionResult Create()
        {

            var countries = _countryRepo.GetAll();
            ViewBag.CountryList = new SelectList(countries, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            _stateRepo.Save(state);
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            var countries = _countryRepo.GetAll();
            ViewBag.CountryList = new SelectList(countries, "Id", "Name");

            var state = _stateRepo.GetById(id);

            return View(state);
        }

        [HttpPost]
        public IActionResult Edit(State state)
        {
            _stateRepo.Edit(state);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(State state) {
            _stateRepo.RemoveData(state);
            return RedirectToAction("Index");
        }
    }
}
