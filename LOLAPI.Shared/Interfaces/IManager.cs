using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLAPI.Shared.Entities;

namespace LOLAPI.Shared.Interfaces
{
    public interface IManager <T> where T : Entity
    {
        List<T> GetAll();
        T GetOneById(int id);
        T Add(T item);
        T EditById(T item, int id);
        T DeleteById(int id);
    }
}
