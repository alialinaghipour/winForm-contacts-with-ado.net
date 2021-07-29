using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayer
{
    public interface IContactsRepository
    {
        DataTable GetAll();
        DataTable GetById(int id);
        DataTable Serach(string parameter);
        bool Insert(string fullName, string mobile, string email, string description);
        bool Update(int id, string fullName, string mobile, string email, string description);
        bool Delete(int id);
    }
}
