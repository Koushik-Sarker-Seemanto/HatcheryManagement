using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HatcheryManagement
{
    public interface IIlishRepository
    {
        IlishFish GetByID(int id);
        List<IlishFish> GetAll();
        void Insert(IlishFish t);
        void Delete(int id);
        void Update(IlishFish t, int idx);
        // void Save();
    }

}
