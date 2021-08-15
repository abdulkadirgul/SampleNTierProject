using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.BLL.Abstract
{
   public interface IServices<T>
    {
        //ekleme
        string Add(T model);
        //silme
        string Delete(int id);
        //listeleme
        List<T> GetAll();
        //güncelleme
        string Update(T model);
        //getirme
        T GetById(int id);
    }
}
