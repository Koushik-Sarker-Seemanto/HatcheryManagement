using System;
using System.Collections.Generic;
using System.Linq;

namespace HatcheryManagement
{
    public class KatlaRepository : IKatlaRepository
    {
        DbMarket dbMarket;
        public KatlaRepository()
        {
            dbMarket = DbMarket.GetInstance();
        }
        public List<KatlaFish> GetAll(){
            return dbMarket.katlaListMarket;
        }
        public KatlaFish GetByID(int id){
            KatlaFish obj = new KatlaFish();
            return obj;
        }
        public void Insert(KatlaFish obj){
            dbMarket.katlaListMarket.Add(obj);
        }
        public void Delete(int idx){
            dbMarket.katlaListMarket.RemoveAt(idx);
        }
        public void Update(KatlaFish obj, int idx){
            dbMarket.katlaListMarket[idx] = obj;
        }
    }
}