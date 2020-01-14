using System;
using System.Collections.Generic;
using System.Linq;

namespace HatcheryManagement
{
    public class RuiRepository : IRuiRepository
    {
        DbMarket dbMarket;
        public RuiRepository()
        {
            dbMarket = DbMarket.GetInstance();
        }
        public List<RuiFish> GetAll(){
            return dbMarket.ruiListMarket;
        }
        public RuiFish GetByID(int id){
            RuiFish obj = new RuiFish();
            return obj;
        }
        public void Insert(RuiFish obj){
            dbMarket.ruiListMarket.Add(obj);
        }
        public void Delete(int idx){
            dbMarket.ruiListMarket.RemoveAt(idx);
        }
        public void Update(RuiFish obj, int idx){
            dbMarket.ruiListMarket[idx] = obj;
        }
    }
}