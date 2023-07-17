using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using RepoSample.UI;

namespace RepoCalisma2.Repos
{
    public class Repo2<T> : IRepo2<T> where T : class
    {
        DbContext db = null;
        DbSet<T> table = null;
        public Repo2()
        {
            db = new NORTHWND2Entities();
            table = db.Set<T>();
            
        }

        public int Delete(T deleteData)
        {
           db.Entry(deleteData).State=EntityState.Deleted;
            table.Remove(deleteData);
            return db.SaveChanges();
        }

        public int Insert(T insertData)
        {
            table.Add(insertData);
            return db.SaveChanges();
        }

        public List<T> listall()
        {
            return table.ToList();
        }

        public T ListByID(int id)
        {
           return table.Find(id);
        }

        public int Update(T updateData)
        {
            db.Entry(updateData).State= EntityState.Modified;
            table.Attach(updateData);
            return db.SaveChanges();
        }
    }
}
