﻿using LA.Models;
using LA.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.SL.Implementations
{
    
    public class StateRepo : IStateRepo
    {
        public readonly ApplicationDbContext _context;

        public StateRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Edit(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
        }

        public IEnumerable<State> GetAll()
        {
            var states = _context.States.ToList();  
            return states;
        }

        public State GetById(int id)
        {
            var state = _context.States.Find(id);
            return state;
        }

        public void RemoveData(State state)
        {
            _context.States.Remove(state);
            _context.SaveChanges();
        }

        public void Save(State state)
        {
           _context.States.Add(state);
            _context.SaveChanges();
        }
    }
}
