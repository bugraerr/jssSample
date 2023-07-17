using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoSample.UI.Repos
{
    public class Repo<T> : IRepo<T> where T : class
    {
        DbContext db = null;
        DbSet<T> table = null;

        public Repo()
        {
            db = new NORTHWND2Entities();
            table = db.Set<T>();
        }

        public int Delete(T deleteData) // update ve deletelerde bu state değiştirme işleri  yapoılıyor.
        {
            //db.Entry(deleteData).State=EntityState.Deleted;
            var dbEntity = db.Entry(deleteData);
            dbEntity.State = EntityState.Deleted;
            // table.Attach(deleteData);
            table.Remove(deleteData);
            return db.SaveChanges();
        }

        public int Insert(T insertData)
        {
            table.Add(insertData);
            return db.SaveChanges();
        }

        public List<T> ListAll()
        {
            return table.ToList();
        }

        public T ListByID(object ID)
        {
            table.Find(ID);
            return table.Find(ID);
        }

        public T ListByID()
        {
            throw new NotImplementedException();
        }

        public int Update(T updateData)
        {
            table.Attach(updateData);
            db.Entry(updateData).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
