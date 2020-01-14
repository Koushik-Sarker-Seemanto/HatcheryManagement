// using System;
// using System.Linq.Expressions;
// using System.Collections.Generic;

// namespace HatcheryManagement
// {
//     public class Repository<T> : IRepository<T>, IDisposable
//     {
//         private T context;

//         public Repository(T context)
//         {
//             this.context = context;
//         }

//         public List<T> GetAll()
//         {
//             return context.;
//         }

//         public T GetByID(int id)
//         {
//             return context.FishList.Find(id);
//         }

//         public void Insert(T fish)
//         {
//             context.FishList.Add(fish);
//         }

//         public void Delete(int id)
//         {
//             T fish = context.FishList.Find(id);
//             context.FishList.Remove(fish);
//         }

//         public void Update(T fish)
//         {
//             context.Entry(fish).State = EntityState.Modified;
//         }

//         public void Save()
//         {
//             context.SaveChanges();
//         }


//         private bool disposed = false;
//         protected virtual void Dispose(bool disposing)
//         {
//             if (!this.disposed)
//             {
//                 if (disposing)
//                 {
//                     context.Dispose();
//                 }
//             }
//             this.disposed = true;
//         }

//         public void Dispose()
//         {
//             Dispose(true);
//             GC.SuppressFinalize(this);
//         }

//     }
// }