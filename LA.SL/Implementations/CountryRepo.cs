using LA.Models;
using LA.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.SL.Implementations
{
    public class CountryRepo : ICountryRepo
    {
        public readonly ApplicationDbContext _context;

        public CountryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Edit(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
        }

        public IEnumerable<Country> GetAll()
        {
            var countries = _context.Countries.ToList();
            return countries;
        }

        public Country GetById(int id)
        {
            var country = _context.Countries.Find(id);
            return country;
        }

        public void RemoveData(Country country)
        {
           _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        public void Save(Country country)
        {
           _context.Countries.Add(country); 
            _context.SaveChanges();
        }
    }
}
