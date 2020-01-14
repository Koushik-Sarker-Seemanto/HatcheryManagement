using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HatcheryManagement
{
    public interface IRuiRepository
    {
        RuiFish GetByID(int id);
        List<RuiFish> GetAll();
        void Insert(RuiFish t);
        void Delete(int id);
        void Update(RuiFish t, int idx);
        // void Save();
    }

}
