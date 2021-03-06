using System;
using System.Collections.Generic;
using System.Linq;

namespace HatcheryManagement
{
    public class Repository : IRepository
    {
        DbMarket dbMarket;
        public Repository()
        {
            dbMarket = DbMarket.GetInstance();
        }
        public List<T> GetAll<T>() where T : GenericFish
        {
            List<T> tList = null;
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                tList = dbMarket.ruiListMarket.Cast<T>().ToList();
                return tList;
            }
            else if(typeof(KatlaFish).Equals(typeof(T)))
            {
                tList = dbMarket.katlaListMarket.Cast<T>().ToList();
                return tList;
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                tList = dbMarket.ilishListMarket.Cast<T>().ToList();
                return tList;
            }
            else
            {
                return tList;
            }
        }
        public T GetByID<T>(int id) where T : GenericFish, new()
        {
            T t = new T();
            if(typeof(RuiFish).Equals(typeof(T)))
            {
                RuiFish rf = new RuiFish();
                rf = dbMarket.ruiListMarket[id];
                t.Name = rf.Name;
                t.Weight = rf.Weight;
                return t;
            }
            else if(typeof(KatlaFish).Equals(typeof(T)))
            {
                KatlaFish kf = new KatlaFish();
                kf = dbMarket.katlaListMarket[id];
                t.Name = kf.Name;
                t.Weight = kf.Weight;
                return t;
            }
            else if(typeof(IlishFish).Equals(typeof(T)))
            {
                IlishFish ilishF = new IlishFish();
                ilishF = dbMarket.ilishListMarket[id];
                t.Name = ilishF.Name;
                t.Weight = ilishF.Weight;
                return t;
            }
            else
            {
                return t;
            }
        }
        public void Insert<T>(T obj) where T : GenericFish
        {
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                RuiFish rf = new RuiFish();
                rf.Name = obj.Name;
                rf.Weight = obj.Weight;
                dbMarket.ruiListMarket.Add(rf);
            }
            else if (typeof(KatlaFish).Equals(typeof(T)))
            {
                KatlaFish kf = new KatlaFish();
                kf.Name = obj.Name;
                kf.Weight = obj.Weight;
                dbMarket.katlaListMarket.Add(kf);
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                IlishFish ilishf = new IlishFish();
                ilishf.Name = obj.Name;
                ilishf.Weight = obj.Weight;
                dbMarket.ilishListMarket.Add(ilishf);
            }

        }
        public void Delete<T>(int idx)
        {
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                dbMarket.ruiListMarket.RemoveAt(idx);
            }
            else if (typeof(KatlaFish).Equals(typeof(T)))
            {
                dbMarket.katlaListMarket.RemoveAt(idx);
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                dbMarket.ilishListMarket.RemoveAt(idx);
            }
        }
        public void Update<T>(T obj, int idx) where T : GenericFish
        {
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                RuiFish rf = new RuiFish();
                rf.Name = obj.Name;
                rf.Weight = obj.Weight;
                dbMarket.ruiListMarket[idx] = rf;
            }
            else if (typeof(KatlaFish).Equals(typeof(T)))
            {
                KatlaFish kf = new KatlaFish();
                kf.Name = obj.Name;
                kf.Weight = obj.Weight;
                dbMarket.katlaListMarket[idx] = kf;
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                IlishFish ilishF = new IlishFish();
                ilishF.Name = obj.Name;
                ilishF.Weight = obj.Weight;
                dbMarket.ilishListMarket[idx] = ilishF;
            }
        }
    }
}