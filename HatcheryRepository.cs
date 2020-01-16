using System;
using System.Collections.Generic;
using System.Linq;

namespace HatcheryManagement
{
    public class HatcheryRepository : IHatcheryRepository
    {
        // DbMarket dbMarket;
        DbHatchery dbHatchery;
        public HatcheryRepository()
        {
            dbHatchery = DbHatchery.GetInstance();
        }
        public List<T> GetAll<T>() where T : GenericFish
        {
            List<T> tList = null;
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                tList = dbHatchery.ruiList.Cast<T>().ToList();
                return tList;
            }
            else if(typeof(KatlaFish).Equals(typeof(T)))
            {
                tList = dbHatchery.katlaList.Cast<T>().ToList();
                return tList;
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                tList = dbHatchery.ilishList.Cast<T>().ToList();
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
                rf = dbHatchery.ruiList[id];
                t.Name = rf.Name;
                t.Weight = rf.Weight;
                return t;
            }
            else if(typeof(KatlaFish).Equals(typeof(T)))
            {
                KatlaFish kf = new KatlaFish();
                kf = dbHatchery.katlaList[id];
                t.Name = kf.Name;
                t.Weight = kf.Weight;
                return t;
            }
            else if(typeof(IlishFish).Equals(typeof(T)))
            {
                IlishFish ilishF = new IlishFish();
                ilishF = dbHatchery.ilishList[id];
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
                dbHatchery.ruiList.Add(rf);
            }
            else if (typeof(KatlaFish).Equals(typeof(T)))
            {
                KatlaFish kf = new KatlaFish();
                kf.Name = obj.Name;
                kf.Weight = obj.Weight;
                dbHatchery.katlaList.Add(kf);
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                IlishFish ilishf = new IlishFish();
                ilishf.Name = obj.Name;
                ilishf.Weight = obj.Weight;
                dbHatchery.ilishList.Add(ilishf);
            }

        }
        public void Delete<T>(int idx)
        {
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                dbHatchery.ruiList.RemoveAt(idx);
            }
            else if (typeof(KatlaFish).Equals(typeof(T)))
            {
                dbHatchery.katlaList.RemoveAt(idx);
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                dbHatchery.ilishList.RemoveAt(idx);
            }
        }
        public void Update<T>(T obj, int idx) where T : GenericFish
        {
            if (typeof(RuiFish).Equals(typeof(T)))
            {
                RuiFish rf = new RuiFish();
                rf.Name = obj.Name;
                rf.Weight = obj.Weight;
                dbHatchery.ruiList[idx] = rf;
            }
            else if (typeof(KatlaFish).Equals(typeof(T)))
            {
                KatlaFish kf = new KatlaFish();
                kf.Name = obj.Name;
                kf.Weight = obj.Weight;
                dbHatchery.katlaList[idx] = kf;
            }
            else if (typeof(IlishFish).Equals(typeof(T)))
            {
                IlishFish ilishF = new IlishFish();
                ilishF.Name = obj.Name;
                ilishF.Weight = obj.Weight;
                dbHatchery.ilishList[idx] = ilishF;
            }
        }
    }
}