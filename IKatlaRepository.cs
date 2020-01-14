using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HatcheryManagement
{
    public interface IKatlaRepository
    {
        KatlaFish GetByID(int id);
        List<KatlaFish> GetAll();
        void Insert(KatlaFish t);
        void Delete(int id);
        void Update(KatlaFish t, int idx);
        // void Save();
    }

}
