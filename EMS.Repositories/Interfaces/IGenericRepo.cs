﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repositories.Interfaces
{
    public interface IGenericRepo<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task Save(T model);

        Task Edit(T model);

        Task RemoveData(T model);



    }
}
