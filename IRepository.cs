using System;
using System.Collections.Generic;

namespace HatcheryManagement
{
    public interface IRepository
    {
        // T GetByID<T>(int id);
        List<T> GetAll<T>() where T : GenericFish;
        void Insert<T>(T t) where T: GenericFish;
        void Delete<T>(int id);
        void Update<T>(T t, int idx) where T: GenericFish;
    }
}