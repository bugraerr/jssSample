using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoCalisma2.Repos
{
    public interface IRepo2<T> where T : class
    {
        int Insert (T insertData);
        int Update (T updateData);
        int Delete (T deleteData);
        List<T> listall ();
        T ListByID (int id);
 
    }
}
