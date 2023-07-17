using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoSample.UI.Repos
{
    public interface IRepo<T> where T : class
    {
        int Insert(T insertData);
        int Update(T updateData);
        int Delete(T deleteData);
        List<T> ListAll();
        T ListByID();

    }
}
