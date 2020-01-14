using System;
using System.Collections.Generic;
using System.Linq;

namespace HatcheryManagement
{
    public class IlishRepository : IIlishRepository
    {
        DbMarket dbMarket;
        public IlishRepository()
        {
            dbMarket = DbMarket.GetInstance();
        }
        public List<IlishFish> GetAll(){
            return dbMarket.ilishListMarket;
        }
        public IlishFish GetByID(int id){
            IlishFish obj = new IlishFish();
            return obj;
        }
        public void Insert(IlishFish obj){
            dbMarket.ilishListMarket.Add(obj);
        }
        public void Delete(int idx){
            dbMarket.ilishListMarket.RemoveAt(idx);
        }
        public void Update(IlishFish obj, int idx){
            dbMarket.ilishListMarket[idx] = obj;
        }
    }
}