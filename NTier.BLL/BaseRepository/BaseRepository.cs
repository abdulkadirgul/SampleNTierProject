using NTier.BLL.Abstract;
using NTier.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.BaseRepository
{
    public class BaseRepository<T> : IServices<T>
    {
        NorthwindEntities db = new NorthwindEntities();
        public string Add(T model)
        {
           db.Set(typeof(T)).Add(model);
            if (db.SaveChanges() > 0)
            {
                return "Ekleme işlemi başarılı!";
            }
            else
            {
                return "Ekleme gerçekleştirilemedi!";
            }
        }

        public string Delete(int id)
        {
            var deleted = GetById(id);
            db.Set(typeof(T)).Remove(deleted);
            if (db.SaveChanges() > 0)
            {
                return "Silme işlemi başarılı";
            }
            else
            {
                return "Silme işlemi gerçekleşmedi!!";
            }
        }

        public List<T> GetAll()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }

        public T GetById(int id)
        {
            var type = (T)db.Set(typeof(T)).Find(id);
            return type;
        }

        public string Update(T model)
        {
            db.Entry(model).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return "Güncelleme işlemi gerçekleşti!";
            }
            else
            {
                return "Güncelleme işlemi gerçekleşmedi!";

            }
        }

    
    }
}
